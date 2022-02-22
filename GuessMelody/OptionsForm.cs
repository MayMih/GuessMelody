using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using Microsoft.WindowsAPICodePack.Dialogs;


namespace GuessMelody
{
    public partial class OptionsForm : Form
    {
        private const string DEFAULT_MUSIC_SELECT_DIALOG_TITLE = "Выберите каталог(и) с музыкой";

        private readonly CommonOpenFileDialog musicFolderBrowseDialog = new CommonOpenFileDialog(DEFAULT_MUSIC_SELECT_DIALOG_TITLE);
        //private readonly BindingSource songseCollectionBindSourse = new BindingSource();
        private readonly ProgOptions _progOpts;

        public OptionsForm(ProgOptions progOpts)
        {
            InitializeComponent();
            musicFolderBrowseDialog.IsFolderPicker = true;
            musicFolderBrowseDialog.Multiselect = true;
            musicFolderBrowseDialog.NavigateToShortcut = true;
            //songseCollectionBindSourse.DataMember = "FileName";
            //songseCollectionBindSourse.DataSource = songsCollection;
            _progOpts = progOpts;    
        }

        private OptionsForm() { }


        /// <summary>
        /// При каждой загрузке формы обновляем список выбранных песен (т.к. предыдущие изменения могли быть отменены)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OptionsForm_Load(object sender, System.EventArgs e)
        {
            Reload();
        }

        /// <summary>
        /// При закрытии формы сохраняем выбранный список песен (если нажата кнопка "ОК")
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OptionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (((e.CloseReason == CloseReason.UserClosing) || (e.CloseReason == CloseReason.None)) && 
                ((this.DialogResult == DialogResult.OK) || (this.DialogResult == DialogResult.Cancel)))
            {
                e.Cancel = true;
                if (this.DialogResult == DialogResult.OK)
                {                   
                    _progOpts.SongsCollection.Clear();
                    foreach (ListViewItem itm in lvSongs.Items)
                    {
                        _progOpts.SongsCollection.Add((itm.Text, itm.Checked));
                    }
                    _progOpts.IsSubfolderScan = cbSubfolderScan.Checked;
                    _progOpts.IsDeleteUnexisting = cbDeleteUnexisting.Checked;
                    _progOpts.IsRandomStart = cbRandomStart.Checked;
                    int duration;
                    String errorMes = String.Empty;
                    if (Int32.TryParse(cmbGameDuration.Text.Trim(), out duration) && (duration > 0))
                    {
                        _progOpts.GameDuration = duration;
                    }
                    else
                    {
                        errorMes += " Продолжительность игры должна быть числом!";
                    }
                    if (Int32.TryParse(cmbSongDuration.Text.Trim(), out duration) && (duration > 0))
                    {
                        _progOpts.SongDuration = duration;
                    }
                    else
                    {
                        errorMes += (String.IsNullOrWhiteSpace(errorMes) ? Environment.NewLine : String.Empty) +
                            "Время на ответ должно быть числом!";
                    }
                    if (!String.IsNullOrWhiteSpace(errorMes))
                    {
                        MessageBox.Show(errorMes, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                this.Hide();
            }
        }


        private void btClear_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить из списка ВСЕ песни?", "Подтверждение",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                lvSongs.Items.Clear();
            }
        }

        /// <summary>
        /// Кнопка "Добавить композиции"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAddMusic_Click(object sender, System.EventArgs e)
        {
            musicFolderBrowseDialog.Title = cbSubfolderScan.Checked ? (DEFAULT_MUSIC_SELECT_DIALOG_TITLE +
                " (подкаталоги учитываются)") : DEFAULT_MUSIC_SELECT_DIALOG_TITLE;
            if (musicFolderBrowseDialog.ShowDialog() == CommonFileDialogResult.Cancel)
            {
                return;
            }
            try
            {
                lvSongs.SuspendLayout();
                this.Cursor = Cursors.WaitCursor;
                this.Update();
                foreach (var folder in musicFolderBrowseDialog.FileNames)
                {
                    var so = _progOpts.IsSubfolderScan ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
                    var fileCollection = Directory.EnumerateFiles(folder, "*.mp3", so).
                        Union(Directory.EnumerateFiles(folder, "*.aac", so)).Union(Directory.EnumerateFiles(folder, "*.m4a", so)).
                        Union(Directory.EnumerateFiles(folder, "*.ogg", so)).Union(Directory.EnumerateFiles(folder, "*.wav", so)).
                        Union(Directory.EnumerateFiles(folder, "*.flac", so));
                    // добавляем только песни с уникальными именами (даже если они находятся в разных каталогах)
                    // N.B.: Минус такого подхода в том, что одноимённые песни разных испольнителей тоже НЕ будут добавлены!
                    // TODO: тут нужно по идее или сравнивать теги Исполнителя, или в качестве ключа использовать полный путь
                    // к файлу, но тогда этот файл будет добавлен несколько раз, если он находится в разных каталогах (
                    //     например песня из обычного альбома и из сборника)
                    // UPD: Проще всего наверно будет сравнивать комбинацию Название + длительность (т.е. теги).
                    foreach (var songFile in fileCollection)
                    {
                        var songName = Path.GetFileName(songFile);
                        if (!lvSongs.Items.ContainsKey(songName))
                        {
                            var newItem = lvSongs.Items.Add(songFile);
                            newItem.Name = songName;
                            newItem.Checked = newItem.Selected = true;
                        }
                    }
                }
                _progOpts.LastFolder = musicFolderBrowseDialog.FileName;
            }
            catch (Exception ex)
            {
                Trace.TraceError("Ошибка добавления песен:{0}{1}", Environment.NewLine, ex.ToString());
            }
            finally
            {
                lvSongs.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                this.Cursor = Cursors.Default;
                lvSongs.ResumeLayout();
            }
        }


        private void OptionsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            musicFolderBrowseDialog?.Dispose();
        }


        private void btDeleteSelected_Click(object sender, EventArgs e)
        {
            lvSongs.SuspendLayout();
            foreach (ListViewItem itm in lvSongs.SelectedItems)
            {
                lvSongs.Items.Remove(itm);
            }
            lvSongs.ResumeLayout();
        }

        /// <summary>
        /// Сохраняем "Продолжительность игры" при её изменении польз-м
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbGameDuration_TextUpdate(object sender, EventArgs e)
        {
            int duration;
            if (!Int32.TryParse(cmbGameDuration.Text.Trim(), out duration) || (duration < 0))
            {
                MessageBox.Show("Продолжительность игры должна быть числом!", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
        }

        /// <summary>
        /// Сохраняем "Время на ответ" при его изменении польз-м
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSongDuration_TextUpdate(object sender, EventArgs e)
        {
            int duration;
            if (!Int32.TryParse(cmbSongDuration.Text.Trim(), out duration) || (duration < 0))
            {
                MessageBox.Show("Время на ответ должно быть числом!", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
        }

        /// <summary>
        /// Кнопка "Сброс настроек (на умолчания)"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>
        /// Работает по сути через костыль с удалением файла настроек и закрытием программы - вероятно можно поправить.
        /// </remarks>
        private void btResetSettings_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите сбросить настройки на значения по умолчанию?",
                "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                File.Delete(Path.Combine(Application.ExecutablePath) + ".config");
                MessageBox.Show("Сейчас программа будет перезапущена для применения настроек!");
                DialogResult = DialogResult.Abort;
            }
        }

        /// <summary>
        /// Метод перезагрузки настроек из файла
        /// </summary>
        private void Reload()
        {
            cbSubfolderScan.Checked = _progOpts.IsSubfolderScan;
            cbDeleteUnexisting.Checked = _progOpts.IsDeleteUnexisting;
            cbRandomStart.Checked = _progOpts.IsRandomStart;
            lvSongs.Items.Clear();
            lvSongs.Items.AddRange(_progOpts.SongsCollection.Select(x =>
                new ListViewItem(x.FileName)
                {
                    Checked = x.IsChecked
                }).ToArray());
            lvSongs.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            cmbGameDuration.Text = _progOpts.GameDuration.ToString();
            cmbSongDuration.Text = _progOpts.SongDuration.ToString();
            musicFolderBrowseDialog.InitialDirectory = _progOpts.LastFolder;
        }


    }
}

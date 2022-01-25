using System;
using System.Collections.Generic;
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
        private readonly Dictionary<string, bool> _songsCollection;


        public OptionsForm(Dictionary<string, bool> songsCollection)
        {
            InitializeComponent();
            musicFolderBrowseDialog.IsFolderPicker = true;
            musicFolderBrowseDialog.Multiselect = true;
            musicFolderBrowseDialog.NavigateToShortcut = true;
            //songseCollectionBindSourse.DataMember = "FileName";
            //songseCollectionBindSourse.DataSource = songsCollection;
            _songsCollection = songsCollection;            
        }

        private OptionsForm() { }


        public bool IsSubfolderSearch { get; set; }


        /// <summary>
        /// При каждой загрузке формы отмечаем все песни как используемые
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OptionsForm_Load(object sender, System.EventArgs e)
        {
            cbSubfolderSearch.Checked = IsSubfolderSearch;
            lvSongs.Items.Clear();
            lvSongs.Items.AddRange(_songsCollection.Select(x => new ListViewItem(x.Key) { 
                Checked = x.Value }).ToArray());
            lvSongs.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);            
        }


        private void OptionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (((e.CloseReason == CloseReason.UserClosing) || (e.CloseReason == CloseReason.None)) && 
                ((this.DialogResult == DialogResult.OK) || (this.DialogResult == DialogResult.Cancel)))
            {
                if (this.DialogResult == DialogResult.OK)
                {
                    _songsCollection.Clear();
                    foreach (ListViewItem itm in lvSongs.Items)
                    {
                        _songsCollection.Add(itm.Text, itm.Checked);
                    }
                }
                e.Cancel = true;
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
            musicFolderBrowseDialog.Title = cbSubfolderSearch.Checked ? (DEFAULT_MUSIC_SELECT_DIALOG_TITLE +
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
                    var so = this.IsSubfolderSearch ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
                    var fileCollection = Directory.EnumerateFiles(folder, "*.mp3", so).
                        Union(Directory.EnumerateFiles(folder, "*.aac", so)).Union(Directory.EnumerateFiles(folder, "*.m4a", so)).
                        Union(Directory.EnumerateFiles(folder, "*.ogg", so)).Union(Directory.EnumerateFiles(folder, "*.wav", so)).
                        Union(Directory.EnumerateFiles(folder, "*.flac", so));
                    // добавляем только песни с уникальными именами (даже если они находятся в разных каталогах)
                    // N.B.: Минус такого подхода в том, что одноимённые песни разных испольнителей тоже НЕ будут добавлены!
                    // TODO: тут нужно по идее или сравнивать теги Исполнителя, или в качестве ключа использовать полный путь
                    // к файлу, но тогда этот файл будет добавлен несколько раз, если он находится в разных каталогах (
                    //     например песня из обычного альбома и из сборника)
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


        private void cbSubfolderSearch_CheckedChanged(object sender, EventArgs e)
        {
            IsSubfolderSearch = cbSubfolderSearch.Checked;
        }
    }
}

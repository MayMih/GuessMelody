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

        
        public OptionsForm(List<(string FileName, bool isUsed)> songsCollection)
        {
            InitializeComponent();
            musicFolderBrowseDialog.IsFolderPicker = true;
            musicFolderBrowseDialog.Multiselect = true;
            musicFolderBrowseDialog.NavigateToShortcut = true;
            //songseCollectionBindSourse.DataMember = "FileName";
            //songseCollectionBindSourse.DataSource = songsCollection;            
        }

        private OptionsForm() { }


        public bool IsSubfolderSearch { get; set; }


        /// <summary>
        /// При первоначальной загрузке формы отмечаем все песни как используемые
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OptionsForm_Load(object sender, System.EventArgs e)
        {
            clbSongs.SuspendLayout();
            for (int i = 0; i < clbSongs.Items.Count; i++)
            {
                clbSongs.SetItemChecked(i, true);
            }
            clbSongs.ResumeLayout();
        }


        private void OptionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (((e.CloseReason == CloseReason.UserClosing) || (e.CloseReason == CloseReason.None)) && 
                ((this.DialogResult == DialogResult.OK) || (this.DialogResult == DialogResult.Cancel)))
            {
                if (this.DialogResult == DialogResult.OK)
                {
                    // TODO: сохраняем настройки
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
                clbSongs.Items.Clear();
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
                clbSongs.SuspendLayout();
                this.Cursor = Cursors.WaitCursor;
                this.Update();
                foreach (var folder in musicFolderBrowseDialog.FileNames)
                {
                    var so = this.IsSubfolderSearch ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
                    var fileCollection = Directory.EnumerateFiles(folder, "*.mp3", so).
                        Union(Directory.EnumerateFiles(folder, "*.aac", so)).Union(Directory.EnumerateFiles(folder, "*.m4a", so)).
                        Union(Directory.EnumerateFiles(folder, "*.ogg", so)).Union(Directory.EnumerateFiles(folder, "*.wav", so)).
                        Union(Directory.EnumerateFiles(folder, "*.flac", so));
                    foreach (var songFile in fileCollection)
                    {
                        clbSongs.SetSelected(clbSongs.Items.Add(songFile, true), true);
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError("Ошибка добавления песен:{0}{1}", Environment.NewLine, ex.ToString());
            }
            finally
            {
                this.Cursor = Cursors.Default;
                clbSongs.ResumeLayout();
            }
        }


        private void OptionsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            musicFolderBrowseDialog?.Dispose();
        }


        private void btDeleteSelected_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

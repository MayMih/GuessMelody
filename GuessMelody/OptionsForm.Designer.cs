
namespace GuessMelody
{
    partial class OptionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btAddMusic = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.cbSubfolderSearch = new System.Windows.Forms.CheckBox();
            this.btDeleteSelected = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.lvSongs = new System.Windows.Forms.ListView();
            this.colFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btAddMusic
            // 
            this.btAddMusic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAddMusic.Location = new System.Drawing.Point(12, 404);
            this.btAddMusic.Name = "btAddMusic";
            this.btAddMusic.Size = new System.Drawing.Size(173, 23);
            this.btAddMusic.TabIndex = 1;
            this.btAddMusic.Text = "Добавить каталог с музыкой";
            this.btAddMusic.UseVisualStyleBackColor = true;
            this.btAddMusic.Click += new System.EventHandler(this.btAddMusic_Click);
            // 
            // btClear
            // 
            this.btClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btClear.Location = new System.Drawing.Point(403, 404);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(115, 23);
            this.btClear.TabIndex = 2;
            this.btClear.Text = "Очистить список";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // cbSubfolderSearch
            // 
            this.cbSubfolderSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSubfolderSearch.AutoSize = true;
            this.cbSubfolderSearch.Location = new System.Drawing.Point(18, 444);
            this.cbSubfolderSearch.Name = "cbSubfolderSearch";
            this.cbSubfolderSearch.Size = new System.Drawing.Size(167, 17);
            this.cbSubfolderSearch.TabIndex = 3;
            this.cbSubfolderSearch.Text = "Обрабатывать подкаталоги";
            this.cbSubfolderSearch.UseVisualStyleBackColor = true;
            this.cbSubfolderSearch.CheckedChanged += new System.EventHandler(this.cbSubfolderSearch_CheckedChanged);
            // 
            // btDeleteSelected
            // 
            this.btDeleteSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btDeleteSelected.Location = new System.Drawing.Point(205, 404);
            this.btDeleteSelected.Name = "btDeleteSelected";
            this.btDeleteSelected.Size = new System.Drawing.Size(173, 23);
            this.btDeleteSelected.TabIndex = 4;
            this.btDeleteSelected.Text = "Удалить выбранное из списка";
            this.btDeleteSelected.UseVisualStyleBackColor = true;
            this.btDeleteSelected.Click += new System.EventHandler(this.btDeleteSelected_Click);
            // 
            // btOK
            // 
            this.btOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOK.Location = new System.Drawing.Point(303, 440);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 5;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(443, 440);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 6;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // lvSongs
            // 
            this.lvSongs.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvSongs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvSongs.CheckBoxes = true;
            this.lvSongs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFileName});
            this.lvSongs.FullRowSelect = true;
            this.lvSongs.GridLines = true;
            this.lvSongs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvSongs.HideSelection = false;
            this.lvSongs.Location = new System.Drawing.Point(12, 12);
            this.lvSongs.Name = "lvSongs";
            this.lvSongs.Size = new System.Drawing.Size(506, 386);
            this.lvSongs.TabIndex = 7;
            this.lvSongs.UseCompatibleStateImageBehavior = false;
            this.lvSongs.View = System.Windows.Forms.View.Details;
            // 
            // colFileName
            // 
            this.colFileName.Width = 0;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 475);
            this.Controls.Add(this.lvSongs);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.btDeleteSelected);
            this.Controls.Add(this.cbSubfolderSearch);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btAddMusic);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Настройки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OptionsForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OptionsForm_FormClosed);
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btAddMusic;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.CheckBox cbSubfolderSearch;
        private System.Windows.Forms.Button btDeleteSelected;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.ListView lvSongs;
        private System.Windows.Forms.ColumnHeader colFileName;
    }
}
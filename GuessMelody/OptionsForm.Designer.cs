
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
            this.cbSubfolderScan = new System.Windows.Forms.CheckBox();
            this.btDeleteSelected = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.lvSongs = new System.Windows.Forms.ListView();
            this.colFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbDeleteUnexisting = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbRandomStart = new System.Windows.Forms.CheckBox();
            this.cmbSongDuration = new System.Windows.Forms.ComboBox();
            this.cmbGameDuration = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btResetSettings = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAddMusic
            // 
            this.btAddMusic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddMusic.Location = new System.Drawing.Point(12, 367);
            this.btAddMusic.Name = "btAddMusic";
            this.btAddMusic.Size = new System.Drawing.Size(173, 23);
            this.btAddMusic.TabIndex = 1;
            this.btAddMusic.Text = "Добавить каталог с музыкой";
            this.btAddMusic.UseVisualStyleBackColor = true;
            this.btAddMusic.Click += new System.EventHandler(this.btAddMusic_Click);
            // 
            // btClear
            // 
            this.btClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btClear.Location = new System.Drawing.Point(403, 367);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(115, 23);
            this.btClear.TabIndex = 2;
            this.btClear.Text = "Очистить список";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // cbSubfolderScan
            // 
            this.cbSubfolderScan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSubfolderScan.AutoSize = true;
            this.cbSubfolderScan.Location = new System.Drawing.Point(18, 399);
            this.cbSubfolderScan.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cbSubfolderScan.Name = "cbSubfolderScan";
            this.cbSubfolderScan.Size = new System.Drawing.Size(167, 17);
            this.cbSubfolderScan.TabIndex = 3;
            this.cbSubfolderScan.Text = "Обрабатывать подкаталоги";
            this.cbSubfolderScan.UseVisualStyleBackColor = true;
            // 
            // btDeleteSelected
            // 
            this.btDeleteSelected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btDeleteSelected.Location = new System.Drawing.Point(205, 367);
            this.btDeleteSelected.Name = "btDeleteSelected";
            this.btDeleteSelected.Size = new System.Drawing.Size(173, 23);
            this.btDeleteSelected.TabIndex = 4;
            this.btDeleteSelected.Text = "Удалить выбранное из списка";
            this.btDeleteSelected.UseVisualStyleBackColor = true;
            this.btDeleteSelected.Click += new System.EventHandler(this.btDeleteSelected_Click);
            // 
            // btOK
            // 
            this.btOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOK.Location = new System.Drawing.Point(12, 515);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 5;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(110, 515);
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
            this.lvSongs.Size = new System.Drawing.Size(506, 344);
            this.lvSongs.TabIndex = 7;
            this.lvSongs.UseCompatibleStateImageBehavior = false;
            this.lvSongs.View = System.Windows.Forms.View.Details;
            // 
            // colFileName
            // 
            this.colFileName.Width = 0;
            // 
            // cbDeleteUnexisting
            // 
            this.cbDeleteUnexisting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDeleteUnexisting.AutoSize = true;
            this.cbDeleteUnexisting.Location = new System.Drawing.Point(205, 399);
            this.cbDeleteUnexisting.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cbDeleteUnexisting.Name = "cbDeleteUnexisting";
            this.cbDeleteUnexisting.Size = new System.Drawing.Size(313, 17);
            this.cbDeleteUnexisting.TabIndex = 8;
            this.cbDeleteUnexisting.Text = "Удалять из списка несуществующие песни при запуске";
            this.cbDeleteUnexisting.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btResetSettings);
            this.groupBox1.Controls.Add(this.cbRandomStart);
            this.groupBox1.Controls.Add(this.cmbSongDuration);
            this.groupBox1.Controls.Add(this.cmbGameDuration);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 425);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 79);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // cbRandomStart
            // 
            this.cbRandomStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRandomStart.AutoSize = true;
            this.cbRandomStart.Location = new System.Drawing.Point(263, 19);
            this.cbRandomStart.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cbRandomStart.Name = "cbRandomStart";
            this.cbRandomStart.Size = new System.Drawing.Size(234, 17);
            this.cbRandomStart.TabIndex = 10;
            this.cbRandomStart.Text = "Начинать игру со случайной композиции";
            this.cbRandomStart.UseVisualStyleBackColor = true;
            // 
            // cmbSongDuration
            // 
            this.cmbSongDuration.FormattingEnabled = true;
            this.cmbSongDuration.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25",
            "30",
            "35"});
            this.cmbSongDuration.Location = new System.Drawing.Point(127, 44);
            this.cmbSongDuration.Name = "cmbSongDuration";
            this.cmbSongDuration.Size = new System.Drawing.Size(121, 21);
            this.cmbSongDuration.TabIndex = 3;
            this.cmbSongDuration.TextUpdate += new System.EventHandler(this.cmbSongDuration_TextUpdate);
            // 
            // cmbGameDuration
            // 
            this.cmbGameDuration.FormattingEnabled = true;
            this.cmbGameDuration.Items.AddRange(new object[] {
            "30",
            "45",
            "60",
            "90",
            "120"});
            this.cmbGameDuration.Location = new System.Drawing.Point(127, 17);
            this.cmbGameDuration.Name = "cmbGameDuration";
            this.cmbGameDuration.Size = new System.Drawing.Size(121, 21);
            this.cmbGameDuration.TabIndex = 2;
            this.cmbGameDuration.TextUpdate += new System.EventHandler(this.cmbGameDuration_TextUpdate);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Время на ответ:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Продолжительность:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btResetSettings
            // 
            this.btResetSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btResetSettings.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btResetSettings.Location = new System.Drawing.Point(362, 45);
            this.btResetSettings.Name = "btResetSettings";
            this.btResetSettings.Size = new System.Drawing.Size(132, 23);
            this.btResetSettings.TabIndex = 10;
            this.btResetSettings.Text = "Сбросить настройки";
            this.btResetSettings.UseVisualStyleBackColor = true;
            this.btResetSettings.Click += new System.EventHandler(this.btResetSettings_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 550);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbDeleteUnexisting);
            this.Controls.Add(this.lvSongs);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.btDeleteSelected);
            this.Controls.Add(this.cbSubfolderScan);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btAddMusic);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OptionsForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OptionsForm_FormClosed);
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btAddMusic;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.CheckBox cbSubfolderScan;
        private System.Windows.Forms.Button btDeleteSelected;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.ListView lvSongs;
        private System.Windows.Forms.ColumnHeader colFileName;
        private System.Windows.Forms.CheckBox cbDeleteUnexisting;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbSongDuration;
        private System.Windows.Forms.ComboBox cmbGameDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbRandomStart;
        private System.Windows.Forms.Button btResetSettings;
    }
}
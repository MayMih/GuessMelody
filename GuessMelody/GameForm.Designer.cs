
namespace GuessMelody
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.btPlayNext = new System.Windows.Forms.Button();
            this.ttHint = new System.Windows.Forms.ToolTip(this.components);
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.btSendInfoToPlayers = new System.Windows.Forms.Button();
            this.btPlayPause = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslPlayState = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbVolumeLevel = new System.Windows.Forms.Label();
            this.cbPlayOnlyOnce = new System.Windows.Forms.CheckBox();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSongArtist = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel9 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSongYear = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip3 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSongName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSongAlbum = new System.Windows.Forms.ToolStripStatusLabel();
            this.wmpHiddenPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.cbAlwaysShowInfoOnSongEnd = new System.Windows.Forms.CheckBox();
            this.cbAutoResumeAfterWrongAsnwer = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.statusStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpHiddenPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSongDuration
            // 
            this.pbSongDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSongDuration.Maximum = 10;
            this.pbSongDuration.Size = new System.Drawing.Size(548, 21);
            // 
            // lbGameTimeRemaining
            // 
            this.lbGameTimeRemaining.Size = new System.Drawing.Size(71, 20);
            this.lbGameTimeRemaining.Text = "01:00:00";
            this.lbGameTimeRemaining.VisibleChanged += new System.EventHandler(this.GameForm_VisibleChanged);
            // 
            // pbGameDuration
            // 
            this.pbGameDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbGameDuration.Maximum = 3600;
            this.pbGameDuration.Size = new System.Drawing.Size(383, 23);
            // 
            // lbPlayer2Score
            // 
            this.lbPlayer2Score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPlayer2Score.Location = new System.Drawing.Point(533, 68);
            // 
            // lbPlayer2
            // 
            this.lbPlayer2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPlayer2.Location = new System.Drawing.Point(503, 17);
            // 
            // btPlayNext
            // 
            this.btPlayNext.Font = new System.Drawing.Font("Comic Sans MS", 16F);
            this.btPlayNext.Location = new System.Drawing.Point(11, 434);
            this.btPlayNext.Name = "btPlayNext";
            this.btPlayNext.Size = new System.Drawing.Size(162, 69);
            this.btPlayNext.TabIndex = 5;
            this.btPlayNext.Text = "Следующая композиция";
            this.btPlayNext.UseVisualStyleBackColor = true;
            this.btPlayNext.Click += new System.EventHandler(this.btPlayNext_Click);
            // 
            // tbVolume
            // 
            this.tbVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbVolume.Location = new System.Drawing.Point(531, 141);
            this.tbVolume.Maximum = 100;
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbVolume.Size = new System.Drawing.Size(45, 332);
            this.tbVolume.SmallChange = 3;
            this.tbVolume.TabIndex = 12;
            this.tbVolume.TickFrequency = 5;
            this.tbVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.ttHint.SetToolTip(this.tbVolume, "Уровень громкости (можно регулировать кнопками Num+|Num-)");
            this.tbVolume.ValueChanged += new System.EventHandler(this.tbVolume_ValueChanged);
            // 
            // btSendInfoToPlayers
            // 
            this.btSendInfoToPlayers.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.btSendInfoToPlayers.Location = new System.Drawing.Point(12, 206);
            this.btSendInfoToPlayers.Name = "btSendInfoToPlayers";
            this.btSendInfoToPlayers.Size = new System.Drawing.Size(106, 92);
            this.btSendInfoToPlayers.TabIndex = 32;
            this.btSendInfoToPlayers.Text = "Показать инфо игрокам";
            this.ttHint.SetToolTip(this.btSendInfoToPlayers, "Передаёт игрокам информацию о текущей песни");
            this.btSendInfoToPlayers.UseVisualStyleBackColor = true;
            this.btSendInfoToPlayers.Click += new System.EventHandler(this.btSendInfoToPlayers_Click);
            // 
            // btPlayPause
            // 
            this.btPlayPause.AutoSize = true;
            this.btPlayPause.Font = new System.Drawing.Font("Comic Sans MS", 16F);
            this.btPlayPause.Location = new System.Drawing.Point(235, 458);
            this.btPlayPause.Name = "btPlayPause";
            this.btPlayPause.Size = new System.Drawing.Size(178, 45);
            this.btPlayPause.TabIndex = 10;
            this.btPlayPause.Text = "Пауза";
            this.btPlayPause.UseVisualStyleBackColor = true;
            this.btPlayPause.Click += new System.EventHandler(this.btPlayPause_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsslPlayState});
            this.statusStrip1.Location = new System.Drawing.Point(0, 562);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(602, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(69, 17);
            this.toolStripStatusLabel1.Text = "Состояние:";
            // 
            // tsslPlayState
            // 
            this.tsslPlayState.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tsslPlayState.Name = "tsslPlayState";
            this.tsslPlayState.Size = new System.Drawing.Size(88, 17);
            this.tsslPlayState.Text = "Остановлено";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Громкость:";
            // 
            // lbVolumeLevel
            // 
            this.lbVolumeLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVolumeLevel.AutoSize = true;
            this.lbVolumeLevel.Location = new System.Drawing.Point(534, 490);
            this.lbVolumeLevel.Name = "lbVolumeLevel";
            this.lbVolumeLevel.Size = new System.Drawing.Size(30, 13);
            this.lbVolumeLevel.TabIndex = 14;
            this.lbVolumeLevel.Text = "30 %";
            // 
            // cbPlayOnlyOnce
            // 
            this.cbPlayOnlyOnce.AutoSize = true;
            this.cbPlayOnlyOnce.Checked = true;
            this.cbPlayOnlyOnce.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPlayOnlyOnce.Location = new System.Drawing.Point(12, 323);
            this.cbPlayOnlyOnce.Name = "cbPlayOnlyOnce";
            this.cbPlayOnlyOnce.Size = new System.Drawing.Size(177, 17);
            this.cbPlayOnlyOnce.TabIndex = 15;
            this.cbPlayOnlyOnce.Text = "Исключить повторение песен";
            this.cbPlayOnlyOnce.UseVisualStyleBackColor = true;
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel5,
            this.tsslSongArtist,
            this.toolStripStatusLabel9,
            this.tsslSongYear});
            this.statusStrip2.Location = new System.Drawing.Point(0, 540);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.ShowItemToolTips = true;
            this.statusStrip2.Size = new System.Drawing.Size(602, 22);
            this.statusStrip2.SizingGrip = false;
            this.statusStrip2.TabIndex = 22;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(447, 17);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = " ";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(83, 17);
            this.toolStripStatusLabel5.Text = "Исполнитель:";
            // 
            // tsslSongArtist
            // 
            this.tsslSongArtist.AutoToolTip = true;
            this.tsslSongArtist.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tsslSongArtist.Name = "tsslSongArtist";
            this.tsslSongArtist.Size = new System.Drawing.Size(13, 17);
            this.tsslSongArtist.Text = "-";
            // 
            // toolStripStatusLabel9
            // 
            this.toolStripStatusLabel9.Name = "toolStripStatusLabel9";
            this.toolStripStatusLabel9.Size = new System.Drawing.Size(31, 17);
            this.toolStripStatusLabel9.Text = "Год:";
            // 
            // tsslSongYear
            // 
            this.tsslSongYear.AutoToolTip = true;
            this.tsslSongYear.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tsslSongYear.Name = "tsslSongYear";
            this.tsslSongYear.Size = new System.Drawing.Size(13, 17);
            this.tsslSongYear.Text = "-";
            // 
            // statusStrip3
            // 
            this.statusStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.tsslSongName,
            this.toolStripStatusLabel7,
            this.tsslSongAlbum});
            this.statusStrip3.Location = new System.Drawing.Point(0, 518);
            this.statusStrip3.Name = "statusStrip3";
            this.statusStrip3.ShowItemToolTips = true;
            this.statusStrip3.Size = new System.Drawing.Size(602, 22);
            this.statusStrip3.SizingGrip = false;
            this.statusStrip3.TabIndex = 23;
            this.statusStrip3.Text = "statusStrip3";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(429, 17);
            this.toolStripStatusLabel3.Spring = true;
            this.toolStripStatusLabel3.Text = " ";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(79, 17);
            this.toolStripStatusLabel4.Text = "Композиция:";
            // 
            // tsslSongName
            // 
            this.tsslSongName.AutoToolTip = true;
            this.tsslSongName.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tsslSongName.Name = "tsslSongName";
            this.tsslSongName.Size = new System.Drawing.Size(13, 17);
            this.tsslSongName.Text = "-";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(53, 17);
            this.toolStripStatusLabel7.Text = "Альбом:";
            // 
            // tsslSongAlbum
            // 
            this.tsslSongAlbum.AutoToolTip = true;
            this.tsslSongAlbum.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tsslSongAlbum.Name = "tsslSongAlbum";
            this.tsslSongAlbum.Size = new System.Drawing.Size(13, 17);
            this.tsslSongAlbum.Text = "-";
            // 
            // wmpHiddenPlayer
            // 
            this.wmpHiddenPlayer.Enabled = true;
            this.wmpHiddenPlayer.Location = new System.Drawing.Point(12, 141);
            this.wmpHiddenPlayer.Name = "wmpHiddenPlayer";
            this.wmpHiddenPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpHiddenPlayer.OcxState")));
            this.wmpHiddenPlayer.Size = new System.Drawing.Size(193, 46);
            this.wmpHiddenPlayer.TabIndex = 4;
            this.wmpHiddenPlayer.Visible = false;
            this.wmpHiddenPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.wmpHiddenPlayer_PlayStateChange);
            this.wmpHiddenPlayer.MediaChange += new AxWMPLib._WMPOCXEvents_MediaChangeEventHandler(this.wmpHiddenPlayer_MediaChange);
            // 
            // cbAlwaysShowInfoOnSongEnd
            // 
            this.cbAlwaysShowInfoOnSongEnd.Location = new System.Drawing.Point(11, 353);
            this.cbAlwaysShowInfoOnSongEnd.Name = "cbAlwaysShowInfoOnSongEnd";
            this.cbAlwaysShowInfoOnSongEnd.Size = new System.Drawing.Size(177, 40);
            this.cbAlwaysShowInfoOnSongEnd.TabIndex = 33;
            this.cbAlwaysShowInfoOnSongEnd.Text = "Передавать игрокам инфу сразу после окончания песни";
            this.cbAlwaysShowInfoOnSongEnd.UseVisualStyleBackColor = true;
            // 
            // cbAutoResumeAfterWrongAsnwer
            // 
            this.cbAutoResumeAfterWrongAsnwer.AutoSize = true;
            this.cbAutoResumeAfterWrongAsnwer.Checked = true;
            this.cbAutoResumeAfterWrongAsnwer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutoResumeAfterWrongAsnwer.Location = new System.Drawing.Point(11, 399);
            this.cbAutoResumeAfterWrongAsnwer.Name = "cbAutoResumeAfterWrongAsnwer";
            this.cbAutoResumeAfterWrongAsnwer.Size = new System.Drawing.Size(223, 17);
            this.cbAutoResumeAfterWrongAsnwer.TabIndex = 34;
            this.cbAutoResumeAfterWrongAsnwer.Text = "Авто Play после неправильного ответа";
            this.cbAutoResumeAfterWrongAsnwer.UseVisualStyleBackColor = true;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GuessMelody.Properties.Resources._178b_The_butterflies_of_Naath__Arthur_Bozonnet_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(602, 584);
            this.Controls.Add(this.cbAutoResumeAfterWrongAsnwer);
            this.Controls.Add(this.cbAlwaysShowInfoOnSongEnd);
            this.Controls.Add(this.btSendInfoToPlayers);
            this.Controls.Add(this.statusStrip3);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.cbPlayOnlyOnce);
            this.Controls.Add(this.lbVolumeLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbVolume);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btPlayPause);
            this.Controls.Add(this.btPlayNext);
            this.Controls.Add(this.wmpHiddenPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.GameForm_VisibleChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.Controls.SetChildIndex(this.wmpHiddenPlayer, 0);
            this.Controls.SetChildIndex(this.btPlayNext, 0);
            this.Controls.SetChildIndex(this.btPlayPause, 0);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.Controls.SetChildIndex(this.tbVolume, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lbVolumeLevel, 0);
            this.Controls.SetChildIndex(this.cbPlayOnlyOnce, 0);
            this.Controls.SetChildIndex(this.statusStrip2, 0);
            this.Controls.SetChildIndex(this.statusStrip3, 0);
            this.Controls.SetChildIndex(this.lbPlayer1, 0);
            this.Controls.SetChildIndex(this.lbPlayer2, 0);
            this.Controls.SetChildIndex(this.lbPlayer1Score, 0);
            this.Controls.SetChildIndex(this.lbPlayer2Score, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.lbSongsCount, 0);
            this.Controls.SetChildIndex(this.pbGameDuration, 0);
            this.Controls.SetChildIndex(this.lbGameTimeRemaining, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.pbSongDuration, 0);
            this.Controls.SetChildIndex(this.btSendInfoToPlayers, 0);
            this.Controls.SetChildIndex(this.cbAlwaysShowInfoOnSongEnd, 0);
            this.Controls.SetChildIndex(this.cbAutoResumeAfterWrongAsnwer, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.statusStrip3.ResumeLayout(false);
            this.statusStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpHiddenPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpHiddenPlayer;
        private System.Windows.Forms.Button btPlayNext;
        private System.Windows.Forms.ToolTip ttHint;
        private System.Windows.Forms.Button btPlayPause;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslPlayState;
        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbVolumeLevel;
        private System.Windows.Forms.CheckBox cbPlayOnlyOnce;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel tsslSongArtist;
        private System.Windows.Forms.StatusStrip statusStrip3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel tsslSongName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel tsslSongAlbum;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel9;
        private System.Windows.Forms.ToolStripStatusLabel tsslSongYear;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Button btSendInfoToPlayers;
        private System.Windows.Forms.CheckBox cbAlwaysShowInfoOnSongEnd;
        private System.Windows.Forms.CheckBox cbAutoResumeAfterWrongAsnwer;
    }
}
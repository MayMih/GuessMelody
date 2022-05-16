
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
            this.wmpHiddenPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btPlayNext = new System.Windows.Forms.Button();
            this.ttHint = new System.Windows.Forms.ToolTip(this.components);
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.lbPlayer1 = new System.Windows.Forms.Label();
            this.lbPlayer2 = new System.Windows.Forms.Label();
            this.lbPlayer1Score = new System.Windows.Forms.Label();
            this.lbPlayer2Score = new System.Windows.Forms.Label();
            this.btPlayPause = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslPlayState = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbVolumeLevel = new System.Windows.Forms.Label();
            this.cbPlayOnlyOnce = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSongsCount = new System.Windows.Forms.Label();
            this.pbGameDuration = new System.Windows.Forms.ProgressBar();
            this.gameDurationTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.wmpHiddenPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wmpHiddenPlayer
            // 
            this.wmpHiddenPlayer.Enabled = true;
            this.wmpHiddenPlayer.Location = new System.Drawing.Point(25, 154);
            this.wmpHiddenPlayer.Name = "wmpHiddenPlayer";
            this.wmpHiddenPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpHiddenPlayer.OcxState")));
            this.wmpHiddenPlayer.Size = new System.Drawing.Size(193, 61);
            this.wmpHiddenPlayer.TabIndex = 4;
            this.wmpHiddenPlayer.Visible = false;
            this.wmpHiddenPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.wmpHiddenPlayer_PlayStateChange);
            // 
            // btPlayNext
            // 
            this.btPlayNext.Font = new System.Drawing.Font("Comic Sans MS", 16F);
            this.btPlayNext.Location = new System.Drawing.Point(18, 380);
            this.btPlayNext.Name = "btPlayNext";
            this.btPlayNext.Size = new System.Drawing.Size(162, 69);
            this.btPlayNext.TabIndex = 5;
            this.btPlayNext.Text = "Следующая композиция";
            this.btPlayNext.UseVisualStyleBackColor = true;
            this.btPlayNext.Click += new System.EventHandler(this.btPlayNext_Click);
            // 
            // tbVolume
            // 
            this.tbVolume.Location = new System.Drawing.Point(498, 145);
            this.tbVolume.Maximum = 100;
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbVolume.Size = new System.Drawing.Size(45, 267);
            this.tbVolume.SmallChange = 3;
            this.tbVolume.TabIndex = 12;
            this.tbVolume.TickFrequency = 5;
            this.tbVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.ttHint.SetToolTip(this.tbVolume, "Уровень громкости (можно регулировать кнопками Num+|Num-)");
            this.tbVolume.ValueChanged += new System.EventHandler(this.tbVolume_ValueChanged);
            // 
            // lbPlayer1
            // 
            this.lbPlayer1.AutoSize = true;
            this.lbPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPlayer1.Location = new System.Drawing.Point(21, 26);
            this.lbPlayer1.Name = "lbPlayer1";
            this.lbPlayer1.Size = new System.Drawing.Size(73, 20);
            this.lbPlayer1.TabIndex = 6;
            this.lbPlayer1.Text = "Игрок 1";
            // 
            // lbPlayer2
            // 
            this.lbPlayer2.AutoSize = true;
            this.lbPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPlayer2.Location = new System.Drawing.Point(464, 26);
            this.lbPlayer2.Name = "lbPlayer2";
            this.lbPlayer2.Size = new System.Drawing.Size(73, 20);
            this.lbPlayer2.TabIndex = 7;
            this.lbPlayer2.Text = "Игрок 2";
            // 
            // lbPlayer1Score
            // 
            this.lbPlayer1Score.AutoSize = true;
            this.lbPlayer1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPlayer1Score.Location = new System.Drawing.Point(46, 77);
            this.lbPlayer1Score.Name = "lbPlayer1Score";
            this.lbPlayer1Score.Size = new System.Drawing.Size(18, 20);
            this.lbPlayer1Score.TabIndex = 8;
            this.lbPlayer1Score.Text = "0";
            // 
            // lbPlayer2Score
            // 
            this.lbPlayer2Score.AutoSize = true;
            this.lbPlayer2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPlayer2Score.Location = new System.Drawing.Point(494, 77);
            this.lbPlayer2Score.Name = "lbPlayer2Score";
            this.lbPlayer2Score.Size = new System.Drawing.Size(18, 20);
            this.lbPlayer2Score.TabIndex = 9;
            this.lbPlayer2Score.Text = "0";
            // 
            // btPlayPause
            // 
            this.btPlayPause.AutoSize = true;
            this.btPlayPause.Font = new System.Drawing.Font("Comic Sans MS", 16F);
            this.btPlayPause.Location = new System.Drawing.Point(236, 404);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 469);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(566, 22);
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
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Громкость:";
            // 
            // lbVolumeLevel
            // 
            this.lbVolumeLevel.AutoSize = true;
            this.lbVolumeLevel.Location = new System.Drawing.Point(524, 424);
            this.lbVolumeLevel.Name = "lbVolumeLevel";
            this.lbVolumeLevel.Size = new System.Drawing.Size(30, 13);
            this.lbVolumeLevel.TabIndex = 14;
            this.lbVolumeLevel.Text = "30 %";
            // 
            // cbPlayOnlyOnce
            // 
            this.cbPlayOnlyOnce.AutoSize = true;
            this.cbPlayOnlyOnce.Location = new System.Drawing.Point(31, 304);
            this.cbPlayOnlyOnce.Name = "cbPlayOnlyOnce";
            this.cbPlayOnlyOnce.Size = new System.Drawing.Size(177, 17);
            this.cbPlayOnlyOnce.TabIndex = 15;
            this.cbPlayOnlyOnce.Text = "Исключить повторение песен";
            this.cbPlayOnlyOnce.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(202, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Песен осталось:";
            // 
            // lbSongsCount
            // 
            this.lbSongsCount.AutoSize = true;
            this.lbSongsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSongsCount.Location = new System.Drawing.Point(325, 29);
            this.lbSongsCount.Name = "lbSongsCount";
            this.lbSongsCount.Size = new System.Drawing.Size(17, 17);
            this.lbSongsCount.TabIndex = 17;
            this.lbSongsCount.Text = "0";
            // 
            // pbGameDuration
            // 
            this.pbGameDuration.Location = new System.Drawing.Point(108, 74);
            this.pbGameDuration.Name = "pbGameDuration";
            this.pbGameDuration.Size = new System.Drawing.Size(336, 23);
            this.pbGameDuration.TabIndex = 18;
            // 
            // gameDurationTimer
            // 
            this.gameDurationTimer.Interval = 1000;
            this.gameDurationTimer.Tick += new System.EventHandler(this.gameDurationTimer_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GuessMelody.Properties.Resources._178b_The_butterflies_of_Naath__Arthur_Bozonnet_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(566, 491);
            this.Controls.Add(this.pbGameDuration);
            this.Controls.Add(this.lbSongsCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbPlayOnlyOnce);
            this.Controls.Add(this.lbVolumeLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbVolume);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btPlayPause);
            this.Controls.Add(this.lbPlayer2Score);
            this.Controls.Add(this.lbPlayer1Score);
            this.Controls.Add(this.lbPlayer2);
            this.Controls.Add(this.lbPlayer1);
            this.Controls.Add(this.btPlayNext);
            this.Controls.Add(this.wmpHiddenPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Игра";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_FormClosed);
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.Shown += new System.EventHandler(this.GameForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.wmpHiddenPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpHiddenPlayer;
        private System.Windows.Forms.Button btPlayNext;
        private System.Windows.Forms.ToolTip ttHint;
        private System.Windows.Forms.Label lbPlayer1;
        private System.Windows.Forms.Label lbPlayer2;
        private System.Windows.Forms.Label lbPlayer1Score;
        private System.Windows.Forms.Label lbPlayer2Score;
        private System.Windows.Forms.Button btPlayPause;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslPlayState;
        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbVolumeLevel;
        private System.Windows.Forms.CheckBox cbPlayOnlyOnce;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbSongsCount;
        private System.Windows.Forms.ProgressBar pbGameDuration;
        private System.Windows.Forms.Timer gameDurationTimer;
    }
}
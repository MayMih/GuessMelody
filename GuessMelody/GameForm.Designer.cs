
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPlayer1Score = new System.Windows.Forms.Label();
            this.lbPlayer2Score = new System.Windows.Forms.Label();
            this.btPlayPause = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslPlayState = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbVolumeLevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wmpHiddenPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wmpHiddenPlayer
            // 
            this.wmpHiddenPlayer.Enabled = true;
            this.wmpHiddenPlayer.Location = new System.Drawing.Point(12, 231);
            this.wmpHiddenPlayer.Name = "wmpHiddenPlayer";
            this.wmpHiddenPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpHiddenPlayer.OcxState")));
            this.wmpHiddenPlayer.Size = new System.Drawing.Size(269, 47);
            this.wmpHiddenPlayer.TabIndex = 4;
            this.wmpHiddenPlayer.Visible = false;
            this.wmpHiddenPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.wmpHiddenPlayer_PlayStateChange);
            this.wmpHiddenPlayer.Enter += new System.EventHandler(this.wmpHiddenPlayer_Enter);
            // 
            // btPlayNext
            // 
            this.btPlayNext.Font = new System.Drawing.Font("Comic Sans MS", 16F);
            this.btPlayNext.Location = new System.Drawing.Point(12, 344);
            this.btPlayNext.Name = "btPlayNext";
            this.btPlayNext.Size = new System.Drawing.Size(162, 69);
            this.btPlayNext.TabIndex = 5;
            this.btPlayNext.Text = "Следующая композиция";
            this.btPlayNext.UseVisualStyleBackColor = true;
            this.btPlayNext.Click += new System.EventHandler(this.btPlayNext_Click);
            // 
            // tbVolume
            // 
            this.tbVolume.Location = new System.Drawing.Point(492, 109);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Игрок 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(464, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Игрок 2";
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
            this.btPlayPause.Location = new System.Drawing.Point(230, 368);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
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
            this.tsslPlayState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.tsslPlayState.Name = "tsslPlayState";
            this.tsslPlayState.Size = new System.Drawing.Size(82, 17);
            this.tsslPlayState.Text = "Остановлено";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Громкость:";
            // 
            // lbVolumeLevel
            // 
            this.lbVolumeLevel.AutoSize = true;
            this.lbVolumeLevel.Location = new System.Drawing.Point(518, 388);
            this.lbVolumeLevel.Name = "lbVolumeLevel";
            this.lbVolumeLevel.Size = new System.Drawing.Size(30, 13);
            this.lbVolumeLevel.TabIndex = 14;
            this.lbVolumeLevel.Text = "30 %";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GuessMelody.Properties.Resources._178b_The_butterflies_of_Naath__Arthur_Bozonnet_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(566, 450);
            this.Controls.Add(this.lbVolumeLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbVolume);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btPlayPause);
            this.Controls.Add(this.lbPlayer2Score);
            this.Controls.Add(this.lbPlayer1Score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_FormClosed);
            this.Load += new System.EventHandler(this.GameForm_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPlayer1Score;
        private System.Windows.Forms.Label lbPlayer2Score;
        private System.Windows.Forms.Button btPlayPause;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslPlayState;
        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbVolumeLevel;
    }
}
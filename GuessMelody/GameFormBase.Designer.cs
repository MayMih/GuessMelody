
namespace GuessMelody
{
    partial class GameFormBase
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
            this.pbSongDuration = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.lbGameTimeRemaining = new System.Windows.Forms.Label();
            this.pbGameDuration = new System.Windows.Forms.ProgressBar();
            this.lbSongsCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPlayer2Score = new System.Windows.Forms.Label();
            this.lbPlayer1Score = new System.Windows.Forms.Label();
            this.lbPlayer2 = new System.Windows.Forms.Label();
            this.lbPlayer1 = new System.Windows.Forms.Label();
            this.gameDurationTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pbSongDuration
            // 
            this.pbSongDuration.Location = new System.Drawing.Point(28, 100);
            this.pbSongDuration.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.pbSongDuration.Name = "pbSongDuration";
            this.pbSongDuration.Size = new System.Drawing.Size(512, 21);
            this.pbSongDuration.Step = 1;
            this.pbSongDuration.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbSongDuration.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(153, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Времени игры осталось:";
            // 
            // lbGameTimeRemaining
            // 
            this.lbGameTimeRemaining.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGameTimeRemaining.AutoSize = true;
            this.lbGameTimeRemaining.BackColor = System.Drawing.Color.Transparent;
            this.lbGameTimeRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGameTimeRemaining.Location = new System.Drawing.Point(327, 42);
            this.lbGameTimeRemaining.Name = "lbGameTimeRemaining";
            this.lbGameTimeRemaining.Size = new System.Drawing.Size(18, 20);
            this.lbGameTimeRemaining.TabIndex = 29;
            this.lbGameTimeRemaining.Text = "0";
            // 
            // pbGameDuration
            // 
            this.pbGameDuration.Location = new System.Drawing.Point(111, 65);
            this.pbGameDuration.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.pbGameDuration.Name = "pbGameDuration";
            this.pbGameDuration.Size = new System.Drawing.Size(347, 23);
            this.pbGameDuration.TabIndex = 28;
            // 
            // lbSongsCount
            // 
            this.lbSongsCount.AutoSize = true;
            this.lbSongsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSongsCount.Location = new System.Drawing.Point(328, 20);
            this.lbSongsCount.Name = "lbSongsCount";
            this.lbSongsCount.Size = new System.Drawing.Size(17, 17);
            this.lbSongsCount.TabIndex = 27;
            this.lbSongsCount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(205, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Песен осталось:";
            // 
            // lbPlayer2Score
            // 
            this.lbPlayer2Score.AutoSize = true;
            this.lbPlayer2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPlayer2Score.Location = new System.Drawing.Point(497, 68);
            this.lbPlayer2Score.Name = "lbPlayer2Score";
            this.lbPlayer2Score.Size = new System.Drawing.Size(18, 20);
            this.lbPlayer2Score.TabIndex = 25;
            this.lbPlayer2Score.Text = "0";
            // 
            // lbPlayer1Score
            // 
            this.lbPlayer1Score.AutoSize = true;
            this.lbPlayer1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPlayer1Score.Location = new System.Drawing.Point(49, 68);
            this.lbPlayer1Score.Name = "lbPlayer1Score";
            this.lbPlayer1Score.Size = new System.Drawing.Size(18, 20);
            this.lbPlayer1Score.TabIndex = 24;
            this.lbPlayer1Score.Text = "0";
            // 
            // lbPlayer2
            // 
            this.lbPlayer2.AutoSize = true;
            this.lbPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPlayer2.Location = new System.Drawing.Point(467, 17);
            this.lbPlayer2.Name = "lbPlayer2";
            this.lbPlayer2.Size = new System.Drawing.Size(73, 20);
            this.lbPlayer2.TabIndex = 23;
            this.lbPlayer2.Text = "Игрок 2";
            // 
            // lbPlayer1
            // 
            this.lbPlayer1.AutoSize = true;
            this.lbPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPlayer1.Location = new System.Drawing.Point(24, 17);
            this.lbPlayer1.Name = "lbPlayer1";
            this.lbPlayer1.Size = new System.Drawing.Size(73, 20);
            this.lbPlayer1.TabIndex = 22;
            this.lbPlayer1.Text = "Игрок 1";
            // 
            // gameDurationTimer
            // 
            this.gameDurationTimer.Interval = 1000;
            this.gameDurationTimer.Tick += new System.EventHandler(this.gameDurationTimer_Tick);
            // 
            // GameFormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 365);
            this.Controls.Add(this.pbSongDuration);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbGameTimeRemaining);
            this.Controls.Add(this.pbGameDuration);
            this.Controls.Add(this.lbSongsCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbPlayer2Score);
            this.Controls.Add(this.lbPlayer1Score);
            this.Controls.Add(this.lbPlayer2);
            this.Controls.Add(this.lbPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GameFormBase";
            this.Text = "-";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ProgressBar pbSongDuration;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label lbGameTimeRemaining;
        protected System.Windows.Forms.ProgressBar pbGameDuration;
        protected System.Windows.Forms.Label lbSongsCount;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label lbPlayer2Score;
        protected System.Windows.Forms.Label lbPlayer1Score;
        protected System.Windows.Forms.Label lbPlayer2;
        protected System.Windows.Forms.Label lbPlayer1;
        protected System.Windows.Forms.Timer gameDurationTimer;
    }
}

namespace GuessMelody
{
    partial class PlayerForm
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
            this.btRenamePlayer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btChangeColor = new System.Windows.Forms.Button();
            this.lbSongInfoCaption = new System.Windows.Forms.Label();
            this.txtSongInfo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbSongDuration
            // 
            this.pbSongDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSongDuration.Maximum = 10;
            this.pbSongDuration.Size = new System.Drawing.Size(494, 21);
            // 
            // lbGameTimeRemaining
            // 
            this.lbGameTimeRemaining.Size = new System.Drawing.Size(71, 20);
            this.lbGameTimeRemaining.Text = "01:00:00";
            // 
            // pbGameDuration
            // 
            this.pbGameDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbGameDuration.Maximum = 3600;
            this.pbGameDuration.Size = new System.Drawing.Size(329, 23);
            // 
            // lbPlayer2Score
            // 
            this.lbPlayer2Score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPlayer2Score.Location = new System.Drawing.Point(470, 68);
            // 
            // lbPlayer2
            // 
            this.lbPlayer2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPlayer2.Location = new System.Drawing.Point(440, 17);
            // 
            // btRenamePlayer
            // 
            this.btRenamePlayer.Location = new System.Drawing.Point(28, 249);
            this.btRenamePlayer.Name = "btRenamePlayer";
            this.btRenamePlayer.Size = new System.Drawing.Size(137, 38);
            this.btRenamePlayer.TabIndex = 35;
            this.btRenamePlayer.Text = "Переименовать игрока";
            this.btRenamePlayer.UseVisualStyleBackColor = true;
            this.btRenamePlayer.Click += new System.EventHandler(this.btRenamePlayer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(180, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 156);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки управления";
            // 
            // comboBox3
            // 
            this.comboBox3.Enabled = false;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(113, 101);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Кнопка ответа:";
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(113, 63);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(214, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Устройство ответа:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 133);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(168, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Разрешить редактирование";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(113, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Клавиша ответа:";
            // 
            // btChangeColor
            // 
            this.btChangeColor.Location = new System.Drawing.Point(28, 174);
            this.btChangeColor.Name = "btChangeColor";
            this.btChangeColor.Size = new System.Drawing.Size(113, 38);
            this.btChangeColor.TabIndex = 36;
            this.btChangeColor.Text = "Сменить цвет";
            this.btChangeColor.UseVisualStyleBackColor = true;
            this.btChangeColor.Click += new System.EventHandler(this.btChangeColor_Click);
            // 
            // lbSongInfoCaption
            // 
            this.lbSongInfoCaption.AutoSize = true;
            this.lbSongInfoCaption.Location = new System.Drawing.Point(123, 334);
            this.lbSongInfoCaption.Name = "lbSongInfoCaption";
            this.lbSongInfoCaption.Size = new System.Drawing.Size(42, 13);
            this.lbSongInfoCaption.TabIndex = 37;
            this.lbSongInfoCaption.Text = "Песня:";
            // 
            // txtSongInfo
            // 
            this.txtSongInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSongInfo.Location = new System.Drawing.Point(180, 332);
            this.txtSongInfo.Multiline = true;
            this.txtSongInfo.Name = "txtSongInfo";
            this.txtSongInfo.ReadOnly = true;
            this.txtSongInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSongInfo.Size = new System.Drawing.Size(333, 106);
            this.txtSongInfo.TabIndex = 38;
            this.txtSongInfo.TabStop = false;
            // 
            // PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 450);
            this.Controls.Add(this.txtSongInfo);
            this.Controls.Add(this.lbSongInfoCaption);
            this.Controls.Add(this.btChangeColor);
            this.Controls.Add(this.btRenamePlayer);
            this.Controls.Add(this.groupBox1);
            this.Name = "PlayerForm";
            this.Text = "PlayerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlayerForm_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.PlayerForm_VisibleChanged);
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
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btRenamePlayer, 0);
            this.Controls.SetChildIndex(this.btChangeColor, 0);
            this.Controls.SetChildIndex(this.lbSongInfoCaption, 0);
            this.Controls.SetChildIndex(this.txtSongInfo, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRenamePlayer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btChangeColor;
        private System.Windows.Forms.Label lbSongInfoCaption;
        private System.Windows.Forms.TextBox txtSongInfo;
    }
}
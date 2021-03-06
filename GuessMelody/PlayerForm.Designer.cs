
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
            this.gbPlayerControls = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAllowEditing = new System.Windows.Forms.CheckBox();
            this.cmbAnswerKey = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btChangeColor = new System.Windows.Forms.Button();
            this.lbSongInfoCaption = new System.Windows.Forms.Label();
            this.txtSongInfo = new System.Windows.Forms.TextBox();
            this.cbReady = new System.Windows.Forms.CheckBox();
            this.gbPlayerControls.SuspendLayout();
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
            this.btRenamePlayer.Location = new System.Drawing.Point(28, 224);
            this.btRenamePlayer.Name = "btRenamePlayer";
            this.btRenamePlayer.Size = new System.Drawing.Size(137, 38);
            this.btRenamePlayer.TabIndex = 35;
            this.btRenamePlayer.Text = "Переименовать игрока";
            this.btRenamePlayer.UseVisualStyleBackColor = true;
            this.btRenamePlayer.Click += new System.EventHandler(this.btRenamePlayer_Click);
            // 
            // gbPlayerControls
            // 
            this.gbPlayerControls.Controls.Add(this.comboBox3);
            this.gbPlayerControls.Controls.Add(this.label5);
            this.gbPlayerControls.Controls.Add(this.comboBox2);
            this.gbPlayerControls.Controls.Add(this.label3);
            this.gbPlayerControls.Controls.Add(this.cbAllowEditing);
            this.gbPlayerControls.Controls.Add(this.cmbAnswerKey);
            this.gbPlayerControls.Controls.Add(this.label1);
            this.gbPlayerControls.Location = new System.Drawing.Point(180, 158);
            this.gbPlayerControls.Name = "gbPlayerControls";
            this.gbPlayerControls.Size = new System.Drawing.Size(333, 156);
            this.gbPlayerControls.TabIndex = 34;
            this.gbPlayerControls.TabStop = false;
            this.gbPlayerControls.Text = "Настройки управления";
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
            // cbAllowEditing
            // 
            this.cbAllowEditing.AutoSize = true;
            this.cbAllowEditing.Location = new System.Drawing.Point(9, 133);
            this.cbAllowEditing.Name = "cbAllowEditing";
            this.cbAllowEditing.Size = new System.Drawing.Size(168, 17);
            this.cbAllowEditing.TabIndex = 2;
            this.cbAllowEditing.Text = "Разрешить редактирование";
            this.cbAllowEditing.UseVisualStyleBackColor = true;
            this.cbAllowEditing.CheckedChanged += new System.EventHandler(this.cbAllowEditing_CheckedChanged);
            // 
            // cmbAnswerKey
            // 
            this.cmbAnswerKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnswerKey.Enabled = false;
            this.cmbAnswerKey.FormattingEnabled = true;
            this.cmbAnswerKey.Location = new System.Drawing.Point(113, 26);
            this.cmbAnswerKey.Name = "cmbAnswerKey";
            this.cmbAnswerKey.Size = new System.Drawing.Size(214, 21);
            this.cmbAnswerKey.TabIndex = 1;
            this.cmbAnswerKey.SelectionChangeCommitted += new System.EventHandler(this.cmbAnswerKey_SelectionChangeCommitted);
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
            this.btChangeColor.Location = new System.Drawing.Point(28, 167);
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
            this.lbSongInfoCaption.Location = new System.Drawing.Point(35, 334);
            this.lbSongInfoCaption.Name = "lbSongInfoCaption";
            this.lbSongInfoCaption.Size = new System.Drawing.Size(70, 13);
            this.lbSongInfoCaption.TabIndex = 37;
            this.lbSongInfoCaption.Text = "Композиция";
            // 
            // txtSongInfo
            // 
            this.txtSongInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSongInfo.Location = new System.Drawing.Point(111, 332);
            this.txtSongInfo.Multiline = true;
            this.txtSongInfo.Name = "txtSongInfo";
            this.txtSongInfo.ReadOnly = true;
            this.txtSongInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSongInfo.Size = new System.Drawing.Size(402, 106);
            this.txtSongInfo.TabIndex = 38;
            this.txtSongInfo.TabStop = false;
            // 
            // cbReady
            // 
            this.cbReady.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbReady.BackColor = System.Drawing.SystemColors.Control;
            this.cbReady.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbReady.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbReady.Location = new System.Drawing.Point(28, 278);
            this.cbReady.Name = "cbReady";
            this.cbReady.Size = new System.Drawing.Size(113, 30);
            this.cbReady.TabIndex = 7;
            this.cbReady.Text = "Готов";
            this.cbReady.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ttHint.SetToolTip(this.cbReady, "Нажмите сюда, чтобы показать Ведущему, что вы отошли/настраиваетесь и наоборот");
            this.cbReady.UseVisualStyleBackColor = false;
            this.cbReady.CheckedChanged += new System.EventHandler(this.cbReady_CheckedChanged);
            // 
            // PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 450);
            this.Controls.Add(this.cbReady);
            this.Controls.Add(this.txtSongInfo);
            this.Controls.Add(this.lbSongInfoCaption);
            this.Controls.Add(this.btChangeColor);
            this.Controls.Add(this.btRenamePlayer);
            this.Controls.Add(this.gbPlayerControls);
            this.Name = "PlayerForm";
            this.Text = "PlayerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlayerForm_FormClosing);
            this.Load += new System.EventHandler(this.PlayerForm_Load);
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
            this.Controls.SetChildIndex(this.gbPlayerControls, 0);
            this.Controls.SetChildIndex(this.btRenamePlayer, 0);
            this.Controls.SetChildIndex(this.btChangeColor, 0);
            this.Controls.SetChildIndex(this.lbSongInfoCaption, 0);
            this.Controls.SetChildIndex(this.txtSongInfo, 0);
            this.Controls.SetChildIndex(this.cbReady, 0);
            this.gbPlayerControls.ResumeLayout(false);
            this.gbPlayerControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRenamePlayer;
        private System.Windows.Forms.GroupBox gbPlayerControls;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbAllowEditing;
        private System.Windows.Forms.ComboBox cmbAnswerKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btChangeColor;
        private System.Windows.Forms.Label lbSongInfoCaption;
        private System.Windows.Forms.TextBox txtSongInfo;
        private System.Windows.Forms.CheckBox cbReady;
    }
}
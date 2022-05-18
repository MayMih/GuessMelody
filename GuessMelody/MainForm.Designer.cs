
namespace GuessMelody
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btStart = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btSettings = new System.Windows.Forms.Button();
            this.btAssignPlayers = new System.Windows.Forms.Button();
            this.lbPlayer1 = new System.Windows.Forms.Label();
            this.lbPlayer2 = new System.Windows.Forms.Label();
            this.lbPlayer1Name = new System.Windows.Forms.Label();
            this.lbPlayer2Name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStart.Location = new System.Drawing.Point(48, 58);
            this.btStart.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(148, 49);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Начать игру";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btClose.Location = new System.Drawing.Point(48, 258);
            this.btClose.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(148, 49);
            this.btClose.TabIndex = 1;
            this.btClose.Text = "Выход";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btSettings
            // 
            this.btSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSettings.Location = new System.Drawing.Point(48, 191);
            this.btSettings.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.btSettings.Name = "btSettings";
            this.btSettings.Size = new System.Drawing.Size(148, 49);
            this.btSettings.TabIndex = 2;
            this.btSettings.Text = "Настройки";
            this.btSettings.UseVisualStyleBackColor = true;
            this.btSettings.Click += new System.EventHandler(this.btSettings_Click);
            // 
            // btAssignPlayers
            // 
            this.btAssignPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAssignPlayers.Location = new System.Drawing.Point(48, 125);
            this.btAssignPlayers.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.btAssignPlayers.Name = "btAssignPlayers";
            this.btAssignPlayers.Size = new System.Drawing.Size(148, 49);
            this.btAssignPlayers.TabIndex = 3;
            this.btAssignPlayers.Text = "Задать игроков";
            this.btAssignPlayers.UseVisualStyleBackColor = true;
            this.btAssignPlayers.Click += new System.EventHandler(this.btAssignPlayers_Click);
            // 
            // lbPlayer1
            // 
            this.lbPlayer1.AutoSize = true;
            this.lbPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.lbPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPlayer1.Location = new System.Drawing.Point(294, 9);
            this.lbPlayer1.Name = "lbPlayer1";
            this.lbPlayer1.Size = new System.Drawing.Size(73, 20);
            this.lbPlayer1.TabIndex = 7;
            this.lbPlayer1.Text = "Игрок 1";
            // 
            // lbPlayer2
            // 
            this.lbPlayer2.AutoSize = true;
            this.lbPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.lbPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPlayer2.Location = new System.Drawing.Point(470, 9);
            this.lbPlayer2.Name = "lbPlayer2";
            this.lbPlayer2.Size = new System.Drawing.Size(73, 20);
            this.lbPlayer2.TabIndex = 8;
            this.lbPlayer2.Text = "Игрок 2";
            // 
            // lbPlayer1Name
            // 
            this.lbPlayer1Name.AutoSize = true;
            this.lbPlayer1Name.BackColor = System.Drawing.Color.Transparent;
            this.lbPlayer1Name.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPlayer1Name.Location = new System.Drawing.Point(294, 58);
            this.lbPlayer1Name.Name = "lbPlayer1Name";
            this.lbPlayer1Name.Size = new System.Drawing.Size(63, 23);
            this.lbPlayer1Name.TabIndex = 9;
            this.lbPlayer1Name.Text = "noname";
            // 
            // lbPlayer2Name
            // 
            this.lbPlayer2Name.AutoSize = true;
            this.lbPlayer2Name.BackColor = System.Drawing.Color.Transparent;
            this.lbPlayer2Name.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPlayer2Name.Location = new System.Drawing.Point(470, 58);
            this.lbPlayer2Name.Name = "lbPlayer2Name";
            this.lbPlayer2Name.Size = new System.Drawing.Size(63, 23);
            this.lbPlayer2Name.TabIndex = 10;
            this.lbPlayer2Name.Text = "noname";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuessMelody.Properties.Resources._176_A_swan_ship_of_the_Summer_Isles__Marc_Simonetti_;
            this.ClientSize = new System.Drawing.Size(817, 495);
            this.Controls.Add(this.lbPlayer2Name);
            this.Controls.Add(this.lbPlayer1Name);
            this.Controls.Add(this.lbPlayer2);
            this.Controls.Add(this.lbPlayer1);
            this.Controls.Add(this.btAssignPlayers);
            this.Controls.Add(this.btSettings);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btStart);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Угадай Мелодию";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btSettings;
        private System.Windows.Forms.Button btAssignPlayers;
        private System.Windows.Forms.Label lbPlayer1;
        private System.Windows.Forms.Label lbPlayer2;
        private System.Windows.Forms.Label lbPlayer1Name;
        private System.Windows.Forms.Label lbPlayer2Name;
    }
}



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
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStart.Location = new System.Drawing.Point(47, 78);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(148, 49);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Начать игру";
            this.btStart.UseVisualStyleBackColor = true;
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btClose.Location = new System.Drawing.Point(47, 224);
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
            this.btSettings.Location = new System.Drawing.Point(47, 151);
            this.btSettings.Name = "btSettings";
            this.btSettings.Size = new System.Drawing.Size(148, 49);
            this.btSettings.TabIndex = 2;
            this.btSettings.Text = "Настройки";
            this.btSettings.UseVisualStyleBackColor = true;
            this.btSettings.Click += new System.EventHandler(this.btSettings_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuessMelody.Properties.Resources._176_A_swan_ship_of_the_Summer_Isles__Marc_Simonetti_;
            this.ClientSize = new System.Drawing.Size(817, 495);
            this.Controls.Add(this.btSettings);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btStart);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Угадай Мелодию";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btSettings;
    }
}


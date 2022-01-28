
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
            ((System.ComponentModel.ISupportInitialize)(this.wmpHiddenPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // wmpHiddenPlayer
            // 
            this.wmpHiddenPlayer.Enabled = true;
            this.wmpHiddenPlayer.Location = new System.Drawing.Point(12, 12);
            this.wmpHiddenPlayer.Name = "wmpHiddenPlayer";
            this.wmpHiddenPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpHiddenPlayer.OcxState")));
            this.wmpHiddenPlayer.Size = new System.Drawing.Size(269, 35);
            this.wmpHiddenPlayer.TabIndex = 4;
            this.wmpHiddenPlayer.Visible = false;
            // 
            // btPlayNext
            // 
            this.btPlayNext.Font = new System.Drawing.Font("Comic Sans MS", 16F);
            this.btPlayNext.Location = new System.Drawing.Point(392, 141);
            this.btPlayNext.Name = "btPlayNext";
            this.btPlayNext.Size = new System.Drawing.Size(162, 69);
            this.btPlayNext.TabIndex = 5;
            this.btPlayNext.Text = "Следующая композиция";
            this.btPlayNext.UseVisualStyleBackColor = true;
            this.btPlayNext.Click += new System.EventHandler(this.btPlayNext_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = global::GuessMelody.Properties.Resources._178a_The_butterflies_of_Naath__Arthur_Bozonnet_;
            this.ClientSize = new System.Drawing.Size(566, 450);
            this.Controls.Add(this.btPlayNext);
            this.Controls.Add(this.wmpHiddenPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "GameForm";
            this.TransparencyKey = System.Drawing.Color.Red;
            ((System.ComponentModel.ISupportInitialize)(this.wmpHiddenPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpHiddenPlayer;
        private System.Windows.Forms.Button btPlayNext;
        private System.Windows.Forms.ToolTip ttHint;
    }
}
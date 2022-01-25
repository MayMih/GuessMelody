using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace GuessMelody
{
    public partial class MainForm : Form
    {
        static readonly List<(string FileName, bool isUsed)> _songsCollection = new List<(string, bool)>();

        readonly OptionsForm frm = new OptionsForm(_songsCollection);


        public MainForm()
        {
            InitializeComponent();            
            this.MaximumSize = this.BackgroundImage.Size;
            //var gUnit = System.Drawing.GraphicsUnit.Pixel;
            //this.MaximizedBounds = System.Drawing.Rectangle.Ceiling(this.BackgroundImage.GetBounds(ref gUnit)) ;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: здесь считывание из настроек
            frm.IsSubfolderSearch = true;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }


        private void btSettings_Click(object sender, EventArgs e)
        {
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // TODO: применяем настройки
            }
        }

    }
}
 
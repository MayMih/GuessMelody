using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace GuessMelody
{
    public partial class MainForm : Form
    {
        private static readonly Dictionary<string, bool> _songsCollection = new Dictionary<string, bool>();

        private readonly OptionsForm frmOpts = new OptionsForm(_songsCollection);
        private readonly GameForm frmGame = new GameForm(_songsCollection);


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
            frmOpts.IsSubfolderSearch = true;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }


        private void btSettings_Click(object sender, EventArgs e)
        {
            if (frmOpts.ShowDialog() == DialogResult.OK)
            {
                // Действия не требуются (пока, т.к. список сохраняется самой формой в статической переменной)
            }
        }

        /// <summary>
        /// Кнопка "Начать игру"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btStart_Click(object sender, EventArgs e)
        {
            if (_songsCollection.Count == 0)
            {
                MessageBox.Show("Не задан список песен!", "Запуск игры невозможен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                frmGame.ShowDialog();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmOpts?.Dispose();
            frmGame?.Dispose();
        }
    }
}
 
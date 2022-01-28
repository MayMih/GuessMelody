using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace GuessMelody
{
    /// <summary>
    /// Форма игрового процесса
    /// </summary>
    public partial class GameForm : Form
    {
        private readonly ProgOptions _progOpts;
        private int _currentSongNumber;

        public GameForm(ProgOptions progOpts) : this()
        {
            _progOpts = progOpts;
        }
        
        private GameForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Кнопка "Играть следующую мелодию"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btPlayNext_Click(object sender, System.EventArgs e)
        {
            ttHint.Hide(btPlayNext);
            var songItem = _progOpts.SongsCollection[_currentSongNumber++];
            if (File.Exists(songItem.FileName))
            {
                wmpHiddenPlayer.URL = songItem.FileName;
            }
            else
            {
                if (_progOpts.IsDeleteUnexisting)
                {
                    songItem.IsChecked = false;
                }
                wmpHiddenPlayer.Ctlcontrols.stop();
                ttHint.Show("Композиция не найдена: " + Environment.NewLine + songItem.FileName, btPlayNext);
            }
        }


    }
}

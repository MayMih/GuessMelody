using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace GuessMelody
{
    /// <summary>
    /// Форма игрового процесса
    /// </summary>
    public partial class GameForm : Form
    {
        private readonly IReadOnlyDictionary<string, bool> _songsCollection;
        private int _currentSongNumber;

        public GameForm(IReadOnlyDictionary<string, bool> songsCollection) : this()
        {
            _songsCollection = songsCollection;
        }
        
        private GameForm()
        {
            InitializeComponent();
        }

        private void btPlayNext_Click(object sender, System.EventArgs e)
        {
            wmpHiddenPlayer.URL = _songsCollection.Keys.ElementAt(_currentSongNumber++);
        }
    }
}

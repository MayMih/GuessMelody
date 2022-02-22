using System;
using System.ComponentModel;
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
        private int _currentSongNumber;        
        private BindingList<(string FileName, bool IsChecked)> _checkedSongs;
        private readonly Random _rand = new Random();


        #region 'Методы'

        /// <summary>
        /// Двигаем ползунок громкости при прокрутке колеса мыши на форме
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);
            MoveVolumeSlider(e.Delta);
        }


        /// <summary>
        /// Метод управления ползунком громкости 
        /// </summary>
        /// <param name="direction"></param>
        /// <remarks>
        /// Посылает контролу trackBar нажатия клавиш со стрелками ВВЕРХ \ ВНИЗ на клавиатуре, т.о. можно
        ///     регулировать шаг изменения громкости настройкой соот-щих свойств контрола.
        /// </remarks>
        private void MoveVolumeSlider(int direction)
        {
            if (direction == 0)
            {
                return;
            }
            String key = String.Format("{{{0}}}", direction > 0 ? Keys.Up.ToString().ToUpper() :
                Keys.Down.ToString().ToUpper());
            tbVolume.Focus();
            SendKeys.Send(key);
        }

        /// <summary>
        /// Метод выбора очередной песни
        /// </summary>
        /// <returns>
        /// False - если файл с песней не найден
        /// </returns>
        private bool TryChooseSong(bool isRandomStart, bool doNotRepeat)
        {
            if (_checkedSongs.Count == 0)
            {
                return false;
            }
            _currentSongNumber = isRandomStart ? _rand.Next(0, _checkedSongs.Count) : _currentSongNumber + 1;
            var songItem = _checkedSongs[_currentSongNumber];
            if (songItem.IsChecked && File.Exists(songItem.FileName))
            {
                wmpHiddenPlayer.URL = songItem.FileName;
                if (doNotRepeat)
                {
                    _checkedSongs.Remove(songItem);
                }
            }
            else
            {
                if (ProgOptions.Instance.IsDeleteUnexisting)
                {
                    songItem.IsChecked = false;
                    _checkedSongs.Remove(songItem);
                }
                wmpHiddenPlayer.Ctlcontrols.stop();
                ttHint.Show("Композиция не найдена: " + Environment.NewLine + songItem.FileName, btPlayNext);
                return false;
            }
            return true;
        }

        #endregion 'Методы'


        /// <summary>
        /// Конструктор 
        /// </summary>
        public GameForm()
        {
            InitializeComponent();
            this.Icon = Program.APP_ICON;
            // определяет, будет ли воспроизведение начинаться сразу после смены пути к текущему файлу
            wmpHiddenPlayer.settings.autoStart = true;
            this.KeyPreview = true;
            GameState.Instance.Player1ScoreChanged += Instance_Player1ScoreChanged;
            GameState.Instance.Player2ScoreChanged += Instance_Player2ScoreChanged;
            GameState.Instance.GameHasEnded += Instance_GameHasEnded;
        }

        private void Instance_GameHasEnded(object sender, EventArgs e)
        {
            gameDurationTimer.Stop();
            var result = GameState.Instance.Result;
            MessageBox.Show(btPlayPause, ("Победил" + (result == GameState.GameResult.Player1Win ? (" " + lbPlayer1.Text) :
                (result == GameState.GameResult.Player2Win ? (" " + lbPlayer2.Text) : "а дружба!"))), "Результаты");
        }

        /// <summary>
        /// При загрузке формы подгружаем её настройки и запускаем воспроизведение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameForm_Load(object sender, EventArgs e)
        {            
            _checkedSongs = new BindingList<(string FileName, bool IsChecked)>(ProgOptions.Instance.SongsCollection.
                Where(x => x.IsChecked).ToList());
            _checkedSongs.ListChanged += _checkedSongs_ListChanged;
            lbSongsCount.Text = _checkedSongs.Count.ToString();
            tbVolume.Value = ProgOptions.Instance.VolumeLevel;
            lbVolumeLevel.Text = tbVolume.Value.ToString();
            btPlayNext_Click(this, EventArgs.Empty);
        }

        /// <summary>
        /// При каждом показе формы 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameForm_Shown(object sender, EventArgs e)
        {
            pbGameDuration.Maximum = ProgOptions.Instance.GameDuration;
        }

        private void Instance_Player2ScoreChanged(object sender, EventArgs e)
        {
            lbPlayer2Score.Text = GameState.Instance.Player2Score.ToString();
        }

        private void Instance_Player1ScoreChanged(object sender, EventArgs e)
        {
            lbPlayer1Score.Text = GameState.Instance.Player1Score.ToString();
        }

        /// <summary>
        /// Обработчик события изменения кол-ва песен в списке, порверяет условие победы, когда песни заканчиваются
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _checkedSongs_ListChanged(object sender, ListChangedEventArgs e)
        {
            int songsCount = _checkedSongs.Count;
            lbSongsCount.Text = songsCount.ToString();
            int player1Score = GameState.Instance.Player1Score;
            int player2Score = GameState.Instance.Player2Score;            
        }

        /// <summary>
        /// Кнопка "Играть следующую мелодию"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btPlayNext_Click(object sender, System.EventArgs e)
        {
            ttHint.Hide(btPlayNext);            
            this.Cursor = Cursors.AppStarting;
            this.Update();
            btPlayNext.Enabled = TryChooseSong(ProgOptions.Instance.IsRandomStart, cbPlayOnlyOnce.Checked);
            if (!btPlayNext.Enabled)
            {
                MessageBox.Show(btPlayPause, "Песни закончились");
                GameState.Instance.EndGame();
            }
            this.Cursor = Cursors.Default;
        }


        /// <summary>
        /// Отображает текущий статус воспроизведения - меняет надпись на кнопке "Play|Pause"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>
        /// См. пример здесь: <see cref="https://docs.microsoft.com/en-us/windows/win32/wmp/axwmplib-axwindowsmediaplayer-playstatechange"/>
        /// </remarks>
        private void wmpHiddenPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            var curState = (WMPLib.WMPPlayState)e.newState;
            bool isPlaying = curState == WMPLib.WMPPlayState.wmppsPlaying;
            btPlayPause.Text = (curState == WMPLib.WMPPlayState.wmppsPaused) || (curState == WMPLib.WMPPlayState.wmppsStopped)
                ? "Продолжить" : (isPlaying ? "Пауза" : "");
            tsslPlayState.Text = wmpHiddenPlayer.status;
            if (!GameState.Instance.IsGameEnded)
            {
                gameDurationTimer.Enabled = isPlaying;
            }
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((e.CloseReason == CloseReason.None || e.CloseReason == CloseReason.UserClosing) &&
                !GameState.Instance.IsGameEnded)
            {
                e.Cancel = MessageBox.Show("Вы уверены, что хотите закончить эту игру?", "Подтверждение",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No;
            }
        }

        /// <summary>
        /// При закрытии формы останавливаем воспроизведение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            wmpHiddenPlayer.Ctlcontrols.stop();
            ProgOptions.Instance.VolumeLevel = tbVolume.Value;
            gameDurationTimer.Stop();
        }

        /// <summary>
        /// Кнопка "Пауза/Продолжить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btPlayPause_Click(object sender, EventArgs e)
        {
            if (wmpHiddenPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                wmpHiddenPlayer.Ctlcontrols.pause();
            }
            else
            {
                wmpHiddenPlayer.Ctlcontrols.play();
            }
        }

        private void tbVolume_ValueChanged(object sender, EventArgs e)
        {
            wmpHiddenPlayer.settings.volume = tbVolume.Value;
            lbVolumeLevel.Text = tbVolume.Value.ToString();
        }

        /// <summary>
        /// Пересылает вместо клавиш (+) (-) в ползунок громкости клавиши (СТРЕЛКА_ВВЕРХ) (СТТРЕЛКА_ВНИЗ)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>
        /// Для корректной работы даного обрабобтчтка свойство формы KeyPreview должно быть установлено в True
        /// </remarks>
        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            int direction = (e.KeyCode == Keys.Add || e.KeyCode == Keys.Oemplus) ? 1 : (
                (e.KeyCode == Keys.OemMinus || e.KeyCode == Keys.Subtract) ? -1 : 0);
            if (direction != 0)
            {
                MoveVolumeSlider(direction);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        /// <summary>
        /// Обработчик общего таймера игры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gameDurationTimer_Tick(object sender, EventArgs e)
        {
            if (pbGameDuration.Value < pbGameDuration.Maximum)
            {
                pbGameDuration.Value++;
            }
            else
            {
                gameDurationTimer.Stop();
                GameState.Instance.EndGame();
            }
        }



    }
}

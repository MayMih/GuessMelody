using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace GuessMelody
{
    /// <summary>
    /// Форма игрового процесса
    /// </summary>
    public partial class GameForm : Form
    {
        private int _currentSongNumber;
        private readonly Random _rand = new Random();

        public GameForm()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            // определяет, будет ли воспроизведение начинаться сразу после смены пути к текущему файлу
            wmpHiddenPlayer.settings.autoStart = true;
            this.KeyPreview = true;            
        }

        /// <summary>
        /// При загрузке формы подгружаем её настройки и запускаем воспроизведение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameForm_Load(object sender, EventArgs e)
        {
            tbVolume.Value = ProgOptions.Instance.VolumeLevel;
            lbVolumeLevel.Text = tbVolume.Value.ToString();
            btPlayNext_Click(this, EventArgs.Empty);
        }

        /// <summary>
        /// Кнопка "Играть следующую мелодию"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btPlayNext_Click(object sender, System.EventArgs e)
        {
            ttHint.Hide(btPlayNext);
            _currentSongNumber = ProgOptions.Instance.IsRandomStart ? _rand.Next(0, ProgOptions.Instance.SongsCollection.Count) : 
                _currentSongNumber + 1;
            TryChooseSong();
        }

        private bool TryChooseSong()
        {
            var songItem = ProgOptions.Instance.SongsCollection[_currentSongNumber];
            if (songItem.IsChecked && File.Exists(songItem.FileName))
            {
                wmpHiddenPlayer.URL = songItem.FileName;
            }
            else
            {
                if (ProgOptions.Instance.IsDeleteUnexisting)
                {
                    songItem.IsChecked = false;
                }
                wmpHiddenPlayer.Ctlcontrols.stop();
                ttHint.Show("Композиция не найдена: " + Environment.NewLine + songItem.FileName, btPlayNext);
                return false;
            }
            return true;
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
            btPlayPause.Text = (curState == WMPLib.WMPPlayState.wmppsPaused) || (curState == WMPLib.WMPPlayState.wmppsStopped)
                ? "Продолжить" : (curState == WMPLib.WMPPlayState.wmppsPlaying ? "Пауза" : "");
            tsslPlayState.Text = wmpHiddenPlayer.status;
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

        protected override void OnMouseWheel(MouseEventArgs e) 
        {
            base.OnMouseWheel(e);
            MoveVolumeSlider(e.Delta);
        }

        private void wmpHiddenPlayer_Enter(object sender, EventArgs e)
        {

        }
    }
}

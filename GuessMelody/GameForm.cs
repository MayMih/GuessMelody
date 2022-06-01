using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace GuessMelody
{

    /// <summary>
    /// Форма игрового процесса
    /// </summary>
    public partial class GameForm : GameFormBase
    {

        #region 'Поля и константы'

        private const string DEFAULT_FORM_TITLE = "Игра";
        private readonly StringBuilder _songInfo = new StringBuilder();

        private int _currentSongNumber;        
        private BindingList<(string FileName, bool IsChecked)> _checkedSongs;  
        /// <summary>
        /// Признак того, что время на ответ истекло, а песню так и не угадали
        /// </summary>
        private bool _isSongGuessed = false;
        private string _curSongShortInfo;

        #endregion 'Поля и константы'


        /// <summary>
        /// Событие окончания текущей песни - точнее окончания его допустимого времени на отгадывание
        /// </summary>
        /// <remarks>
        /// Используется главной формой игры (<see cref="GameForm"/>) для передачи игрокам информации о последней 
        ///     неугаданной песне
        /// </remarks>
        internal event EventHandler<(string ShortInfo, string FullInfo)> SongHasEnded;
        /// <summary>
        /// Событие запуска очередной композиции
        /// </summary>
        internal event EventHandler NextSongStarted;
        /// <summary>
        /// Событие изменение состояния проигрывателя - сообщает о необходимости остановки/запуска таймера и синхронизации позиции прогрессбара.
        /// </summary>
        internal event EventHandler<bool> PlayStateChanged;


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
            this.Activate();
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
            _currentSongNumber = isRandomStart ? GameState.Instance.RGen.Next(0, _checkedSongs.Count) : _currentSongNumber + 1;
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

        /// <summary>
        /// Метод запролнения инфы о Песне - внимание: очищает <see cref="_songInfo"/>
        /// </summary>
        private void FillSongInfo()
        {
            _songInfo.Clear();
            using (var tf = TagLib.File.Create(wmpHiddenPlayer.currentMedia.sourceURL))
            {
                _songInfo.AppendFormat("{0,15}", " Альбом:").Append("\t").AppendLine(tf.Tag.Album);
                _songInfo.AppendFormat("{0,15}", " Название:").Append("\t").AppendLine(tf.Tag.Title);
                _songInfo.AppendFormat("{0,15}", " Исполнители:").Append("\t").AppendLine(String.Join(", ",
                    tf.Tag.AlbumArtists).TrimEnd(','));
                _songInfo.AppendFormat("{0,15}", " Год:").Append("\t").AppendLine(tf.Tag.Year.ToString());
                _songInfo.AppendFormat("{0,15}", " Композитор:").Append("\t").AppendLine(tf.Tag.FirstComposer);
                _songInfo.AppendFormat("{0,15}", " Имя файла:").Append("\t").AppendLine(Path.GetFileName(
                    wmpHiddenPlayer.currentMedia.sourceURL));
            }
        }

        #endregion 'Методы'




        #region 'Конструкторы'

        private GameForm()
        {
        }

        /// <summary>
        /// Конструктор - по умолчанию создаёт форму Распорядителя игры с заголовком "Игра"
        /// </summary>
        public GameForm(string title = DEFAULT_FORM_TITLE)
        {
            InitializeComponent();
            ttHint.IsBalloon = true;
            this.Text = title;
            this.KeyPreview = true;
            // определяет, будет ли воспроизведение начинаться сразу после смены пути к текущему файлу
            wmpHiddenPlayer.settings.autoStart = true;            
            base.gameDurationTimer.Tick += this.gameDurationTimer_Tick;
            GameState.Instance.PlayerAnswered += Instance_PlayerAnswered;
            GameState.Instance.GameHasEnded += Instance_GameHasEnded; 
        }

        #endregion 'Конструкторы'




        #region 'Обработчики'

        /// <summary>
        /// При каждом показе формы подгружаем её настройки и запускаем воспроизведение (т.к. она "никогда" не закрывается)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameForm_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible || !btPlayNext.Enabled)    // вторая проверка - это по сути костыль - попытка побороть повторный
                                                    // вход в обработчик при пустом списке песен на старте
            {                
                return;
            }
            _checkedSongs = new BindingList<(string FileName, bool IsChecked)>(ProgOptions.Instance.SongsCollection.
                Where(x => x.IsChecked).ToList());
            _checkedSongs.ListChanged += _checkedSongs_ListChanged;
            GameState.Instance.SongsCount = _checkedSongs.Count;
            tbVolume.Value = ProgOptions.Instance.VolumeLevel;
            lbVolumeLevel.Text = tbVolume.Value.ToString();
            _curSongShortInfo = String.Empty;
            _isSongGuessed = false;
            _currentSongNumber = 0;            
            btPlayNext_Click(this, EventArgs.Empty);            
        }

        /// <summary>
        /// Для каждого игрока показываем сообщение о завершении Игры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Instance_GameHasEnded(object sender, EventArgs e)
        {
            gameDurationTimer.Stop();
            var result = GameState.Instance.Result;
            MessageBox.Show(this, ("Победил" + (result == GameState.GameResult.Player1Win ? (" " + lbPlayer1.Text) :
                (result == GameState.GameResult.Player2Win ? (" " + lbPlayer2.Text) : "а дружба!"))), "Результаты", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Обработчик запроса пользователя на право ответа - прибавляет счётчик игрока в случае правильного ответа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Instance_PlayerAnswered(object sender, PlayerForm e)
        {
            // Запрещаем игрокам жать кнопки после того, как песня уже угадана
            if (_isSongGuessed)
            {
                return;
            }
            wmpHiddenPlayer.Ctlcontrols.pause();
            var res = MessageBox.Show("Игрок \"" + e.PlayerName + "\" ответил верно?", "Игрок \"" + e.PlayerName + 
                "\" запросил право на ответ!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                _isSongGuessed = true;
                if (e.IsFirstPlayer)
                {
                    GameState.Instance.Player1Score++;
                }
                else
                {
                    GameState.Instance.Player2Score++;
                }
                btSendInfoToPlayers_Click(this, EventArgs.Empty);
            }
            if (!_isSongGuessed && cbAutoResumeAfterWrongAsnwer.Checked)
            {
                wmpHiddenPlayer.Ctlcontrols.play();
            }
        }

        /// <summary>
        /// Обработчик события изменения кол-ва песен в списке, проверяет условие победы, когда песни заканчиваются.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _checkedSongs_ListChanged(object sender, ListChangedEventArgs e)
        {
            GameState.Instance.SongsCount = _checkedSongs.Count;
        }

        /// <summary>
        /// Кнопка "Играть следующую мелодию"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btPlayNext_Click(object sender, System.EventArgs e)
        {
            if (!GameState.Instance.IsPlayersReady)
            {
                ttHint.Show("Игроки ещё не готовы", btPlayPause);
                return;
            }
            _isSongGuessed = false;
            pbSongDuration.Value = 0;            
            ttHint.Hide(btPlayNext);            
            this.Cursor = Cursors.AppStarting;
            this.Update();
            btPlayNext.Enabled = TryChooseSong(ProgOptions.Instance.IsRandomStart, cbPlayOnlyOnce.Checked);
            if (!btPlayNext.Enabled)
            {
                MessageBox.Show(btPlayPause, "Песни закончились");
                GameState.Instance.EndGame();
            }
            else
            {
                // отправляем событие здесь, хотя логичнее было бы в момент реальной смены песни в проигрывателе, т.к.
                // иначе клиенты получают некоторую задержку
                NextSongStarted?.Invoke(this, EventArgs.Empty);
            }
            this.Cursor = Cursors.Default;
        }       

        /// <summary>
        /// Обработчик закрытия формы - запрашиваем подтверждение выхода, если форму закрыл пользователь при запущенной игре.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.None || e.CloseReason == CloseReason.UserClosing)
            {
                // всегда запрещаем закрытие, т.к. эта форма показывается немодально (чтобы предотвратить вызов Dispose())
                e.Cancel = true;
                var res = GameState.Instance.IsGameEnded || MessageBox.Show("Вы уверены, что хотите закончить эту игру?", 
                    "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
                if (res)
                {
                    //При закрытии формы останавливаем воспроизведение и отвязываем обработчики события окончания песни
                    try
                    {                        
                        _checkedSongs.Clear();
                        wmpHiddenPlayer.Ctlcontrols.stop();
                        gameDurationTimer.Stop();
                    }
                    finally
                    {
                        SongHasEnded = null;
                        ProgOptions.Instance.VolumeLevel = tbVolume.Value;                        
                        if (!GameState.Instance.IsGameEnded)
                        {
                            GameState.Instance.EndGame();
                        }
                        this.Hide();
                    }                    
                }
            }
        }

        /// <summary>
        /// Кнопка "Пауза/Продолжить" воспроизведение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btPlayPause_Click(object sender, EventArgs e)
        {
            if (!GameState.Instance.IsPlayersReady)
            {
                ttHint.Show("Игроки ещё не готовы", btPlayPause);
                return;
            }
            else
            {
                ttHint.SetToolTip(btPlayPause, "");
            }
            if (wmpHiddenPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                wmpHiddenPlayer.Ctlcontrols.pause();
            }
            else if (wmpHiddenPlayer.currentMedia != null)
            {
                wmpHiddenPlayer.Ctlcontrols.play();
            }
            else
            {
                btPlayNext_Click(btPlayPause, EventArgs.Empty);
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
        /// Кнопка - передать инфу о песне игрокам
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSendInfoToPlayers_Click(object sender, EventArgs e)
        {
            try
            {
                FillSongInfo();
                SongHasEnded?.Invoke(this, (_curSongShortInfo, _songInfo.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"Проблемный файл: {Environment.NewLine}""{wmpHiddenPlayer.currentMedia.sourceURL}""" +
                    Environment.NewLine + ex.Message, "Ошибка чтения тегов", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }

        /// <summary>
        /// Обработчик общего таймера игры (тикает каждую секунду)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gameDurationTimer_Tick(object sender, EventArgs e)
        {            
            if (!_isSongGuessed && (pbSongDuration.Value >= pbSongDuration.Maximum))
            {
                _isSongGuessed = true;  // отмечаем песню как угаданную по истечению таймера, чтобы не дать людям клацать
                                        // впустую и для прекращения реакции на таймер песни, пока не запустится следующая.
                wmpHiddenPlayer.Ctlcontrols.pause();
                try
                {
                    FillSongInfo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($@"Проблемный файл: {Environment.NewLine}""{wmpHiddenPlayer.currentMedia.sourceURL}""" +
                        Environment.NewLine + ex.Message, "Ошибка чтения тегов", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (cbAlwaysShowInfoOnSongEnd.Checked)
                {
                    SongHasEnded?.Invoke(this, (_curSongShortInfo, _songInfo.ToString()));
                }
                MessageBox.Show($@"Это был - ""{wmpHiddenPlayer.currentMedia.name}""{Environment.NewLine}{Environment.NewLine}" +
                    _songInfo.ToString(), "Песня Не угадана!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (pbGameDuration.Value >= pbGameDuration.Maximum)
            {                
                GameState.Instance.EndGame();
            }
        }


        #endregion 'Обработчики'




        #region 'Обработчики Плеера'

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
            tsslSongName.Text = wmpHiddenPlayer.currentMedia?.name ?? "";
            //tsslSongName.ToolTipText = wmpHiddenPlayer.currentMedia?.sourceURL ?? "";
            //tsslSongName.Text = wmpHiddenPlayer.currentMedia?.sourceURL ?? "";
            if (!GameState.Instance.IsGameEnded)
            {
                gameDurationTimer.Enabled = isPlaying;
                PlayStateChanged?.Invoke(this, isPlaying);
            }
        }

        /// <summary>
        /// При изменении текущей композиции
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wmpHiddenPlayer_MediaChange(object sender, AxWMPLib._WMPOCXEvents_MediaChangeEvent e)
        {
            var tf = default(TagLib.File);
            try
            {
                tf = TagLib.File.Create((e.item as WMPLib.IWMPMedia3).sourceURL);
                _curSongShortInfo = $@"""{ tf.Tag.Title} "" - ""{ tf.Tag.Album}"" - ""{ tf.Tag.FirstAlbumArtist}""";
                this.Text = $@"{DEFAULT_FORM_TITLE} - {_curSongShortInfo}";
                tsslSongName.Text = tf.Tag.Title;
                tsslSongAlbum.Text = tf.Tag.Album;
                tsslSongArtist.Text = tf.Tag.FirstAlbumArtist;
                tsslSongYear.Text = tf.Tag.Year.ToString();
            }
            catch (Exception ex)
            {
                this.Text = DEFAULT_FORM_TITLE;
                tsslSongName.Text = tsslSongAlbum.Text = tsslSongArtist.Text = tsslSongYear.Text = "-";
                MessageBox.Show($@"Проблемный файл: {Environment.NewLine}""{(e.item as WMPLib.IWMPMedia3)?.sourceURL}""" +
                    Environment.NewLine + ex.Message, "Ошибка чтения тегов", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                tf?.Dispose();
            }
        }

        #endregion 'Обработчики Плеера'


    }
}

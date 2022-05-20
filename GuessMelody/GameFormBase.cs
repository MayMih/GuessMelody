using System;
using System.Windows.Forms;


namespace GuessMelody
{
    /// <summary>
    /// Содержит общий код игровых форм (для Распорядителя и Игроков)
    /// </summary>
    /// <remarks>
    /// Наследники данной формы должны показываться строго НЕмодально!
    /// </remarks>
    public partial class GameFormBase : Form
    {
        private DateTime _gameEndTime, _gameStartTime;

        /// <summary>
        /// Конструктор - задаёт обработчикиобновления меток на форме при изменении состояния Игры
        /// </summary>
        public GameFormBase()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.DoubleBuffered = true;
            GameState.Instance.Player1ScoreChanged += (ob, e) => {
                lbPlayer1Score.Text = GameState.Instance.Player1Score.ToString();
            };
            GameState.Instance.Player2ScoreChanged += (ob, e) => {
                lbPlayer2Score.Text = GameState.Instance.Player2Score.ToString();
            };
            GameState.Instance.Player1NameChanged += (ob, e) => { lbPlayer1.Text = GameState.Instance.Player1Name; };
            GameState.Instance.Player2NameChanged += (ob, e) => { lbPlayer2.Text = GameState.Instance.Player2Name; };
            GameState.Instance.GameHasEnded += Instance_GameHasEnded;
            GameState.Instance.SongsCountChanged += (ob, e) => { lbSongsCount.Text = GameState.Instance.SongsCount.ToString(); };
        }

        /// <summary>
        /// При показе формы сбрасываем её поля, т.к. предполагается, что жта форма должна показываться строго НЕмодально!
        /// </summary>
        /// <param name="e"></param>        
        protected override void OnVisibleChanged(EventArgs e)
        {
            if (!Visible)
            {
                base.OnVisibleChanged(e);
                return;
            }
            pbGameDuration.Maximum = ProgOptions.Instance.GameDuration * 60;
            pbSongDuration.Maximum = ProgOptions.Instance.SongDuration;
            pbGameDuration.Value = pbSongDuration.Value = 0;
            _gameStartTime = DateTime.Now;
            _gameEndTime = _gameStartTime.AddMinutes(ProgOptions.Instance.GameDuration);
            lbGameTimeRemaining.Text = _gameEndTime.Subtract(_gameStartTime.AddSeconds(pbGameDuration.Value)).ToString();
            base.OnVisibleChanged(e);
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
                (result == GameState.GameResult.Player2Win ? (" " + lbPlayer2.Text) : "а дружба!"))), "Результаты");
        }

        /// <summary>
        /// Обработчик таймера игры - управляет прогресс-барами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gameDurationTimer_Tick(object sender, System.EventArgs e)
        {
            if (pbSongDuration.Value < pbSongDuration.Maximum)
            {
                pbSongDuration.Value++;
            }
            if (pbGameDuration.Value < pbGameDuration.Maximum)
            {
                pbGameDuration.Value++;
                lbGameTimeRemaining.Text = _gameEndTime.Subtract(_gameStartTime.AddSeconds(pbGameDuration.Value)).ToString();
            }
            else
            {
                gameDurationTimer.Stop();
                lbGameTimeRemaining.Text = "0";
            }
        }
    }
}

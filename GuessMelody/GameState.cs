using System;
using System.Windows.Forms;

namespace GuessMelody
{
    /// <summary>
    /// Класс текущего состояния игры - служит средством обмена инфой между формами
    /// </summary>
    public class GameState
    {

        public enum GameResult
        {
            None,
            Parity,
            Player1Win,
            Player2Win,
        }



        #region 'Поля и константы'

        private int _player2Score = 0;
        private int _player1Score = 0;
        private bool _isGameEnded = false;
        private string _player1Name = "Игрок 1";
        private string _player2Name = "Игрок 2";
        private int _songsCount = 0;
        /// <summary>
        /// Обощённый генератор случайных чисел
        /// </summary>
        public readonly Random RGen = new Random();

        #endregion 'Поля и константы'




        #region 'События'

        public event EventHandler Player1ScoreChanged;
        public event EventHandler Player2ScoreChanged;
        public event EventHandler Player1NameChanged;
        public event EventHandler Player2NameChanged;
        public event EventHandler GameHasEnded;
        public event EventHandler SongsCountChanged;
        public event EventHandler<PlayerForm> PlayerAnswered;

        #endregion 'События'




        #region 'Свойства'

        public int Player1Score
        {
            get => _player1Score;
            set
            {
                _player1Score = value;
                OnPlayer1ScoreChanged(EventArgs.Empty);
            }
        }

        public int Player2Score
        {
            get => _player2Score;
            set
            {
                _player2Score = value;
                OnPlayer2ScoreChanged(EventArgs.Empty);
            }
        }

        public string Player1Name
        {
            get => _player1Name;
            set
            {
                _player1Name = String.IsNullOrWhiteSpace(value) ? "Игрок 1" : value.Trim();
                OnPlayer1NameChanged(EventArgs.Empty);
            }
        }

        public string Player2Name
        {
            get => _player2Name;
            set
            {
                _player2Name = String.IsNullOrWhiteSpace(value) ? "Игрок 2" : value.Trim();
                OnPlayer2NameChanged(EventArgs.Empty);
            }
        }

        /// <summary>
        /// Расчётное свойство - НЕ является признаком окончания игры!
        /// </summary>
        public GameResult Result 
        {
            get => _player1Score > _player2Score ? GameResult.Player1Win : (_player1Score < _player2Score ?
                GameResult.Player2Win : GameResult.Parity);
        }

        public bool IsGameEnded { get => _isGameEnded; }

        public int SongsCount
        {
            get => _songsCount;
            set
            {
                _songsCount = value;
                OnSongsCountCanged(EventArgs.Empty);
            }
        }

        /// <summary>
        /// Кнопка активации ответа Игрока 1
        /// </summary>
        public Keys Player1Key { 
            get; 
            internal set; 
        }
        /// <summary>
        /// Кнопка активации ответа Игрока 2
        /// </summary>
        public Keys Player2Key { get; internal set; }

        public bool IsPlayersReady => Player1Key != Player2Key;

        #endregion 'Свойства'




        #region 'Методы'


        private void OnSongsCountCanged(EventArgs empty)
        {
            SongsCountChanged?.Invoke(this, empty);
        }

        private void OnPlayer1ScoreChanged(EventArgs e)
        {
            Player1ScoreChanged?.Invoke(this, e);
        }

        private void OnPlayer2ScoreChanged(EventArgs e)
        {
            Player2ScoreChanged?.Invoke(this, e);
        }

        private void OnPlayer1NameChanged(EventArgs empty)
        {
            Player1NameChanged?.Invoke(this, empty);
        }

        private void OnPlayer2NameChanged(EventArgs empty)
        {
            Player2NameChanged?.Invoke(this, empty);
        }

        internal void OnPlayerAnswered(PlayerForm senderForm)
        {
            PlayerAnswered?.Invoke(this, senderForm);
        }

        /// <summary>
        /// Сбрасывает состояние игры
        /// </summary>
        public void Reset()
        {
            _player1Score = _player2Score = _songsCount = 0;
            _isGameEnded = false;
            Player1Key = Player2Key = Keys.None;
            // Отвязываем все обработчики!
            //Player1ScoreChanged = null;
            //Player2ScoreChanged = null;
            //GameHasEnded = null;
            //Player1NameChanged = null;
            //Player2NameChanged = null;
        }

        private GameState() { }

        public static readonly GameState Instance = new GameState();

        internal void EndGame()
        {
            _isGameEnded = true;
            OnGameEnded(EventArgs.Empty);
        }

        private void OnGameEnded(EventArgs e)
        {
            GameHasEnded?.Invoke(this, e);
        }

        #endregion 'Методы'

    }
}

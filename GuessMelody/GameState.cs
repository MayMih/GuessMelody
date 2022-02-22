using System;


namespace GuessMelody
{
    
    public class GameState
    {
        public enum GameResult
        {
            None,
            Parity,
            Player1Win,
            Player2Win,
        }

        private int _player2Score = 0;
        private int _player1Score = 0;
        private bool _isGameEnded = false;

        public event EventHandler Player1ScoreChanged;
        public event EventHandler Player2ScoreChanged;
        public event EventHandler GameHasEnded;

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

        /// <summary>
        /// Расчётное свойство - НЕ является признаком окончания игры!
        /// </summary>
        public GameResult Result 
        {
            get => _player1Score > _player2Score ? GameResult.Player1Win : (_player1Score < _player2Score ?
                GameResult.Player2Win : GameResult.Parity);
        }

        public bool IsGameEnded { get => _isGameEnded; }

        private void OnPlayer1ScoreChanged(EventArgs e)
        {
            Player1ScoreChanged?.Invoke(this, e);
        }

        private void OnPlayer2ScoreChanged(EventArgs e)
        {
            Player2ScoreChanged?.Invoke(this, e);
        }

        public void Reset()
        {
            _player1Score = _player2Score = 0;
            _isGameEnded = false;
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
    }
}

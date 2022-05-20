using System;
using System.Drawing;
using System.Windows.Forms;

using Microsoft.VisualBasic;


namespace GuessMelody
{
    /// <summary>
    /// Форма игрока
    /// </summary>
    public partial class PlayerForm : GameFormBase
    {
        #region 'Поля и константы'

        private bool _isFirstPlayer;

        #endregion 'Поля и константы'


        /// <summary>
        /// Конструктор формы игрока - навешивает обработчики, задаёт заголовок на основе имени игрока
        /// </summary>
        public PlayerForm(bool isFirstPlayer)
        {
            InitializeComponent();
            this.ControlBox = false;
            _isFirstPlayer = isFirstPlayer;
            MainForm.frmGame.SongHasEnded += (ob, songInfo) => {
                //MessageBox.Show(songInfo, "Песня НЕ угадана", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Text = (_isFirstPlayer ? GameState.Instance.Player1Name : GameState.Instance.Player2Name) + " - " +
                    songInfo.ShortInfo;
                txtSongInfo.Text = songInfo.FullInfo;
            };
            MainForm.frmGame.NextSongStarted += (ob, e) => {
                pbSongDuration.Value = 0;
                txtSongInfo.Clear();
                Text = _isFirstPlayer ? GameState.Instance.Player1Name : GameState.Instance.Player2Name;
                base.gameDurationTimer.Start();
            };
            MainForm.frmGame.PlayStateChanged += (ob, isStarted) => {
                base.gameDurationTimer.Enabled = isStarted;
            };
            txtSongInfo.BorderStyle = BorderStyle.None;
        }

        /// <summary>
        /// При показе формы задаём ей случайный светлый цвет фона и  сбрасываем её состояние (т.к. доп. экземпляры создаваться Не будут)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        private void PlayerForm_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible)
            {
                return;
            }            
            Text = _isFirstPlayer ? GameState.Instance.Player1Name : GameState.Instance.Player2Name;
            btChangeColor_Click(this, EventArgs.Empty);
        }

        /// <summary>
        /// Кнопка "Переименовать игрока"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btRenamePlayer_Click(object sender, EventArgs e)
        {
            Text = _isFirstPlayer ? GameState.Instance.Player1Name : GameState.Instance.Player2Name;
            Text = Interaction.InputBox("Новое имя игрока", "Введите имя для Игрока", Text);
            if (_isFirstPlayer)
            {
                GameState.Instance.Player1Name = Text;
            }
            else
            {
                GameState.Instance.Player2Name = Text;
            }
        }

        /// <summary>
        /// По умолчанию пользователю закрывать форму запрещено (Игру должен прерывать распорядитель либо ОС)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // всегда запрещаем закрытие, т.к. эта форма показывается немодально (чтобы предотвратить вызов Dispose())
            e.Cancel = e.CloseReason == CloseReason.None || e.CloseReason == CloseReason.UserClosing;
        }

        /// <summary>
        /// Кнопка "Сменить цвет фона"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btChangeColor_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(GameState.Instance.RGen.Next(200, 255), GameState.Instance.RGen.Next(200, 255),
                GameState.Instance.RGen.Next(200, 255));
        }
    }
}

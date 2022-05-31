using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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

        #endregion 'Поля и константы'


        public string PlayerName => IsFirstPlayer ? GameState.Instance.Player1Name : GameState.Instance.Player2Name;
        public bool IsFirstPlayer { get; private set; }


        /// <summary>
        /// Конструктор формы игрока - навешивает обработчики, задаёт заголовок на основе имени игрока
        /// </summary>
        public PlayerForm(bool isFirstPlayer)
        {
            InitializeComponent();
            this.ControlBox = false;
            IsFirstPlayer = isFirstPlayer;
            this.KeyPreview = true;
            MainForm.frmGame.SongHasEnded += (ob, songInfo) => {
                //MessageBox.Show(songInfo, "Песня НЕ угадана", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Text = this.PlayerName+ " - " + songInfo.ShortInfo;
                txtSongInfo.Text = songInfo.FullInfo;
            };
            MainForm.frmGame.NextSongStarted += (ob, e) => {
                pbSongDuration.Value = 0;
                txtSongInfo.Clear();
                Text = this.PlayerName;
                base.gameDurationTimer.Start();
            };
            MainForm.frmGame.PlayStateChanged += (ob, isStarted) => {
                base.gameDurationTimer.Enabled = isStarted;
            };
            txtSongInfo.BorderStyle = BorderStyle.None;
        }

        /// <summary>
        /// При загрузке формы заполняем список доступных клавиш
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayerForm_Load(object sender, EventArgs e)
        {
            var availableKeys = new List<(Keys, string)> {
                (Keys.Enter, "\"Ввод\""), (Keys.RShiftKey, "\"Правый Shift" ),
                (Keys.Alt, "\"Alt" ), (Keys.LShiftKey, "\"Левый Shift\""), (Keys.LControlKey, "\"Левый Control\""),
                (Keys.RControlKey, "\"Правый Control\""), (Keys.Add, "\"+\""), (Keys.Subtract, "\"-\""), (Keys.Divide, "\"/\""),
                (Keys.Decimal, "\"Точка\""), (Keys.Right, "\"→\""), (Keys.Left, "\"←\""), (Keys.Up, "\"↑\""), (Keys.Down, "\"↓\""),
                (Keys.PageUp, "\"PageUp\""), (Keys.PageDown, "\"PageDown\""), (Keys.Home, "\"Home\""), (Keys.End, "\"End\""),
                (Keys.Back, "\"Backspace\""), (Keys.Tab, "\"Tab\""), (Keys.Escape, "\"Esc\""), (Keys.Delete, "\"Del\""),
                (Keys.Insert, "\"Insert\""), (Keys.Multiply, "\"Умножить (*)\""), (Keys.Space, "\"Пробел\""),
                (Keys.XButton1, "\"Кнопка мыши 4\""), (Keys.XButton2, "\"Кнопка мыши 5\""),
                (Keys.RButton, "\"Правая кнопка мыши\""), (Keys.MButton, "\"Средняя кнопка мыши\""),
            };
            int j = 0;
            for (var i = Keys.NumPad0; i <= Keys.NumPad9; i++)
            {
                availableKeys.Add((i, "Цифровая клавиатура \"" + j++.ToString() + "\""));
            }
            for (var i = Keys.A; i <= Keys.Z; i++)
            {
                availableKeys.Add((i, "Буква \"" + i.ToString() + "\""));
            }
            for (var i = Keys.D0; i <= Keys.D9; i++)
            {
                availableKeys.Add((i, "Цифра \"" + ((int)i - (int)Keys.D0).ToString() + "\""));
            }
            for (var i = Keys.F1; i <= Keys.F12; i++)
            {
                availableKeys.Add((i, "Спец. клавиша \"" + i.ToString() + "\""));
            }
            cmbAnswerKey.DataSource = availableKeys;
            cmbAnswerKey.SelectedIndex = GameState.Instance.RGen.Next(0, cmbAnswerKey.Items.Count);
            cmbAnswerKey_SelectionChangeCommitted(this, EventArgs.Empty);
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
            Text = this.PlayerName;
            btChangeColor_Click(this, EventArgs.Empty);            
        }

        /// <summary>
        /// Кнопка "Переименовать игрока"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btRenamePlayer_Click(object sender, EventArgs e)
        {
            Text = this.PlayerName;
            Text = Interaction.InputBox("Новое имя игрока", "Введите имя для Игрока", Text);
            if (IsFirstPlayer)
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
            txtSongInfo.BackColor = BackColor;
        }

        private void cbAllowEditing_CheckedChanged(object sender, EventArgs e)
        {
            gbPlayerControls.Controls.OfType<Control>().Where(ctr => ctr != cbAllowEditing).ToList().ForEach(ctr =>
                ctr.Enabled = cbAllowEditing.Checked);
        }

        private void cmbAnswerKey_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var selectedKey = ((ValueTuple<Keys, string>)cmbAnswerKey.SelectedItem).Item1;
            if (IsFirstPlayer)
            {
                GameState.Instance.Player1Key = selectedKey;
            }
            else
            {
                GameState.Instance.Player2Key = selectedKey;
            }
        }
    }
}

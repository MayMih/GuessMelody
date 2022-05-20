using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using Microsoft.VisualBasic;


namespace GuessMelody
{
    /// <summary>
    /// Главная форма программы
    /// </summary>
    public partial class MainForm : Form
    {

        #region 'Поля и константы'

        private readonly OptionsForm frmOpts = new OptionsForm(ProgOptions.Instance);
        internal static readonly GameForm frmGame = new GameForm();
        private readonly PlayerForm frmPlayer1 = new PlayerForm(true);
        private readonly PlayerForm frmPlayer2 = new PlayerForm(false);
        private bool _isResetExit;

        #endregion 'Поля и константы'



        /// <summary>
        /// Конструктор по умолчанию - навешиваем события прекращения игры и смены имён игроков
        /// </summary>
        public MainForm()
        {
            InitializeComponent();            
            this.MaximumSize = this.BackgroundImage.Size;
            frmGame.VisibleChanged += (ob, e) => {
                if (frmGame.Visible)
                {
                    return;
                }
                frmPlayer1.Hide();
                frmPlayer2.Hide();
                Controls.OfType<Control>().ToList().ForEach(ctr => ctr.Enabled = true); 
            };
            GameState.Instance.Player1NameChanged += (ob, e) => { lbPlayer1Name.Text = GameState.Instance.Player1Name; };
            GameState.Instance.Player2NameChanged += (ob, e) => { lbPlayer2Name.Text = GameState.Instance.Player2Name; };
        }

        /// <summary>
        /// Обработчик загрузки настроек программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void MainForm_Load(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;            
            Dictionary <string, bool> ctrState = new Dictionary<string, bool>(this.Controls.Count);
            this.Controls.OfType<Control>().ToList().ForEach(ctr => {
                ctrState.Add(ctr.Name, ctr.Enabled);
                ctr.Enabled = false;
                });
            this.Update();
            try
            {
                await ProgOptions.Instance.LoadAsync();
            }
            catch (Exception ex)
            {
                this.UseWaitCursor = false;
                MessageBox.Show("Непредвиденная ошибка загрузки настроек приложения:" + Environment.NewLine +
                    Environment.NewLine + ex.Message + Environment.NewLine + 
                    "будут использованы стандартные настройки", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.UseWaitCursor = false;
                this.Controls.OfType<Control>().ToList().ForEach(ctr => ctr.Enabled = ctrState[ctr.Name]);
            }
        }

        /// <summary>
        /// При показе формы настраиваем прозрачность меток
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>
        /// Взято отсюда: <see cref="https://stackoverflow.com/a/53307487/2323972"/>
        /// </remarks>
        private void MainForm_Shown(object sender, EventArgs e)
        {
            lbPlayer1.BackColor = lbPlayer2.BackColor = lbPlayer1Name.BackColor = lbPlayer2Name.BackColor = Color.Transparent;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        /// <summary>
        /// Кнопка "Настройки" - выводит окно 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btSettings_Click(object sender, EventArgs e)
        {
            frmOpts.Location = PointToScreen(btSettings.Location);
            frmOpts.Top = Math.Max(frmOpts.Top - (frmOpts.Height / 2) - btSettings.Height, this.Top);
            var res = frmOpts.ShowDialog();
            try
            {
                this.UseWaitCursor = true;
                this.Update();
                if (res == DialogResult.OK)
                {
                    // Тут будет реакция на изменение настроек, если потребуется
                    await ProgOptions.Instance.SaveAsync();
                }
                else if (res == DialogResult.Cancel)
                {
                    // перезагружаем настройки, на случай, если пользователь отменил изменения
                    await ProgOptions.Instance.LoadAsync();
                }
                else if (res == DialogResult.Abort)
                {
                    _isResetExit = true;
                    Application.Restart();
                }
            }
            finally
            {
                this.UseWaitCursor = false;
            }
        }

        /// <summary>
        /// Кнопка "Начать игру"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btStart_Click(object sender, EventArgs e)
        {
            if (ProgOptions.Instance.SongsCollection.Count == 0)
            {
                MessageBox.Show("Не задан список песен!", "Запуск игры невозможен", MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
            }
            else
            {
                GameState.Instance.Reset();
                this.Controls.OfType<Control>().ToList().ForEach(ctr => ctr.Enabled = false);
                try
                {
                    frmGame.Show();
                    frmPlayer1.Text = lbPlayer1Name.Text.Trim();
                    frmPlayer1.Show();
                    frmPlayer2.Text = lbPlayer2Name.Text.Trim();
                    frmPlayer2.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Неизвестная ошибка игрового процесса:" + ex.Message + Environment.NewLine + 
                        Environment.NewLine + ex.ToString(), "Непредвиденная ошибка");
                    this.Controls.OfType<Control>().ToList().ForEach(ctr => ctr.Enabled = true);
                }
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmOpts?.Dispose();
            frmGame?.Dispose();
            frmPlayer1?.Dispose();
            frmPlayer2?.Dispose();
        }

        /// <summary>
        /// Перед закрытием формы сохраняем настройки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isResetExit)
            {
                return;
            }
            this.UseWaitCursor = true;
            this.Controls.OfType<Control>().ToList().ForEach(ctr => ctr.Enabled = false);
            this.Update();
            try
            {
                await ProgOptions.Instance.SaveAsync();
            }
            catch (Exception ex)
            {
                this.UseWaitCursor = false;
                MessageBox.Show(String.Format("Непредвиденная ошибка при сохранении настроек программы:{0}{0}{1}",
                    Environment.NewLine, ex.ToString()), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.UseWaitCursor = false;
            }
        }

        /// <summary>
        /// Кпока "Назначить игроков"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAssignPlayers_Click(object sender, EventArgs e)
        {
            GameState.Instance.Player1Name = Interaction.InputBox("Имя игрока 1", "Введите имя для Игрока 1", "Игрок 1");
            GameState.Instance.Player2Name = Interaction.InputBox("Имя игрока 2", "Введите имя для Игрока 2", "Игрок 2");
        }
    }
}
 
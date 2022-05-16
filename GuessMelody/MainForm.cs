using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using GuessMelody.Properties;

namespace GuessMelody
{
    /// <summary>
    /// 
    /// </summary>
    public partial class MainForm : Form
    {

        #region 'Поля и константы'

        private readonly OptionsForm frmOpts = new OptionsForm(ProgOptions.Instance);
        private readonly GameForm frmGame = new GameForm();
        private bool _isResetExit;

        #endregion 'Поля и константы'



        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public MainForm()
        {
            InitializeComponent();            
            this.MaximumSize = this.BackgroundImage.Size;
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
                frmGame.ShowDialog();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmOpts?.Dispose();
            frmGame?.Dispose();
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
    }
}
 
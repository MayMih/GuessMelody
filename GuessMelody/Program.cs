using System;
using System.Drawing;
using System.Windows.Forms;


namespace GuessMelody
{
    static class Program
    {
        public static readonly Icon APP_ICON = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }

}

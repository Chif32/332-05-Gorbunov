using System;
using System.Windows.Forms;

namespace StudentsApp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Настройка стиля отображения приложения
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Запуск главной формы приложения
            Application.Run(new MainForm());
        }
    }
}

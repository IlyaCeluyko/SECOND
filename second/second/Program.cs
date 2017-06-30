using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace second
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// Разработать программу на с# WinFofms с кнопкой "Загрузить",
        /// по нажатию на которую выводится имя первого студента.
        /// Использовать  XML файл следующего содержания
        /// <?xml version = "1.0" encoding = "utf-8">
        /// <department name = "FIT">
        /// <student name = "Ольга" group ="1" age = "18" />
        /// <student name = "Никита" group ="2" age = "19" />
        /// <student name = "Павел" group ="7" age = "20" />
        /// </department>
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

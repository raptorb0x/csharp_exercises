using System;
using System.Windows.Forms;


//-------------------------------------------------------------
//Уже чуть более сложная программа с вин формами.
//Задача - оповещение пользвователя через определенный промежуток времени о наличии непрочтенных писем в gmail ящике пользователя
//Имеется возможность настраивания логина, пароля, и значения таймера
//Так как прогрмамма не имеет подписи безопастности то вероятно нужен разовый пароль приложения gmail
//-------------------------------------------------------------

namespace Tray
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
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

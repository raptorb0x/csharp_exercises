using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Prog
{
    static class Program
    {
        public static Form1 _Form1;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                _Form1 = new Form1();
                Application.Run(_Form1);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString());}
        }
    }
}

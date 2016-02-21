using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Calc_Logics;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ToolTip toolTip1 = new ToolTip();

        public MainWindow()
        {
            InitializeComponent();
            //textBox1.ToolTip = toolTip1;
            toolTip1.StaysOpen = false;
            ToolTipService.SetBetweenShowDelay(toolTip1, 1);
            ToolTipService.SetShowDuration(toolTip1, 1000);
        }

        
        
        #region Изменения формы 

        /// <summary>
        /// Обновление Textbox
        /// </summary>
        private void TextBoxRefresh()
        {
            textBox1.Text = Logics.Data;
        }

        /// <summary>
        /// Пишем выражение в верхнем окне
        /// </summary>
        /// <param name="Число"></param>
        /// <param name="Символ оператора"></param>
        private void TextAdd(string Toadd, char oper)
        {
            //Если символа выражения еще не было
            if (!(textBox2.Text.Contains('+') || textBox2.Text.Contains('-') || textBox2.Text.Contains('*') || textBox2.Text.Contains('/')))

                //Пишем  число и оператор
                textBox2.Text = " " + Toadd + " " + oper.ToString();

            //Если на вводе символ посчета результата и его еще не было 
            else if ((!textBox2.Text.Contains('=') && oper == '=') || (!textBox2.Text.Contains('%') && oper == '%'))

                //Пишем его
                textBox2.Text += " " + Toadd + " " + oper.ToString();

        }

        /// <summary>
        /// Проверка на очистку верхнего поля
        /// </summary>
        private void TextClr()
        {
            //Если выражение содержит символа подсчета результата
            if (textBox2.Text.Contains("=") || textBox2.Text.Contains("%"))

                //стираем его
                textBox2.Text = "";
        }

        /// <summary>
        /// Принудительна очистка верхнего поля
        /// </summary>
        /// <param name="force">Если истина то очищаем</param>
        private void TextClr(bool force)
        {
            if (force)
                textBox2.Text = "";
        }

        #endregion

        //-----------------------------------------------------------------------

       // #region Обработка ввода пользователя и взаимодействие с логикой

        /// <summary>
        /// Обработчик цифровой клавиши
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Digital_Click(object sender, RoutedEventArgs e)
        {
            //Проверяем необходимость очистки верхнего поля
            this.TextClr();

            try
            {
                //Отдаем в логику цифру
                Logics.addDigit(sender.ToString().Last());
                TextBoxRefresh();
            }
            //Если число слишком длинное
            catch (Exception)
            {
                //Выводим всплывающее окошко с подсказкой
                //toolTip1.Show("Число слишком длинное", textBox1, 1000);
                toolTip1.Content = "Число слишком длинное";
                toolTip1.IsOpen = true;
            }
        }


    }
}

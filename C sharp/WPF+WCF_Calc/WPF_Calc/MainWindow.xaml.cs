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


namespace Calc_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private WPF_Calc.ServiceReference1.Service1Client Logics = new WPF_Calc.ServiceReference1.Service1Client();

        

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
            textBox1.Text = Logics.Data();
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

        #region Обработка ввода пользователя и взаимодействие с логикой

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
                toolTip1.Content = "Число слишком длинное";
                if (toolTip1.IsOpen == true)
                    toolTip1.IsOpen = false;
                toolTip1.IsOpen = true;
            }
        }

        /// <summary>
        /// Обработчик смены знака
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bSigned_Click(object sender, RoutedEventArgs e)
        {
            //Отправляем в логику смену знака
            Logics.Sign();
            this.TextBoxRefresh();
        }


        /// <summary>
        /// Обработчик запятой
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bDiv_Click(object sender, RoutedEventArgs e)
        {
            this.TextClr();

            //Предаем запятую в логику
            Logics.Comma();
            this.TextBoxRefresh();
        }

        /// <summary>
        /// Обработчик backspace
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bBack_Click(object sender, RoutedEventArgs e)
        {
            this.TextClr();

            //backspace в логику
            Logics.Back();
            this.TextBoxRefresh();
        }

        /// <summary>
        /// Обработчик очистки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bClear_Click(object sender, RoutedEventArgs e)
        {
            this.TextClr();

            //Очистка в логику
            Logics.Clear();
            this.TextBoxRefresh();
        }

        /// <summary>
        /// Обработчик сброса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bReset_Click(object sender, RoutedEventArgs e)
        {
            TextClr(true);

            //Сброс в логику
            Logics.Reset();
            this.TextBoxRefresh();
        }

        /// <summary>
        /// Обработчик нажатия на операцию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bOper_Click(object sender, RoutedEventArgs e)
        {
            this.TextClr();

            //Пишем выражение в верхнее поле
            TextAdd(Logics.Data(), sender.ToString().Last());

            //отправляяем оператор в логику
            Logics.Oper(sender.ToString().Last());
            TextBoxRefresh();

        }

        /// <summary>
        /// Обработчик нажатиния на подсчет результата
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Equality_Click(object sender, RoutedEventArgs e)
        {
            TextClr();
            TextAdd(this.textBox1.Text, '=');

            //Отправляем запрос на расчёт в логику
            try
            {
                Logics.Equality();
            }
            catch (Exception)
            {
                //Выводим всплывающее окошко с подсказкой
                //toolTip1.Show("Операция не определена", textBox1, 1000);
                //Выводим всплывающее окошко с подсказкой
                toolTip1.Content = "Операция не определена";
                if (toolTip1.IsOpen == true)
                    toolTip1.IsOpen = false;
                toolTip1.IsOpen = true;
            }
            this.TextBoxRefresh();
        }

        /// <summary>
        /// Обработчик нажатия на взятие кв. корня
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bSqrt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Квадратный корень в лонику
                Logics.Sqrt();
            }
            catch (Exception)
            {
                //Исключение
                //toolTip1.Show("Корень из отрицательного числа", textBox1, 1000);
                toolTip1.Content = "Корень из отрицательного числа";
                if (toolTip1.IsOpen == true)
                    toolTip1.IsOpen = false;
                toolTip1.IsOpen = true;

            }

            this.TextBoxRefresh();
        }

        /// <summary>
        /// Нажатие на обратную пропорцианальность
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bRev_Click(object sender, RoutedEventArgs e)
        {
            //Обратная пропорциональность в логику
            Logics.Inverse();
            this.TextBoxRefresh();
        }

        /// <summary>
        /// Вычисление через процент
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bPerc_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Процент в логику
                Logics.Percent();
                TextClr();
                TextAdd(this.textBox1.Text, '%');
            }
            catch (Exception)
            {
                //Если исключение
                //toolTip1.Show("Процент от чего?", textBox1, 1000);
                toolTip1.Content = "Процент от чего?";
                if (toolTip1.IsOpen == true)
                    toolTip1.IsOpen = false;
                toolTip1.IsOpen = true;
            }

            this.TextBoxRefresh();
        }


        #endregion

        //-----------------------------------------------------------------------

    }
}

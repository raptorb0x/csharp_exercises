using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calc_Logics;

namespace Calc_Forms
{
    public partial class Form1 : Form
    {
        //Экземпляр класса с логикой
        Logics lLogic = new Logics();

        public Form1()
        {
            InitializeComponent();
            TextBoxRefresh();
        }

        /// <summary>
        /// Обновление Textbox
        /// </summary>
        private void TextBoxRefresh()
        {
            textBox1.Text = lLogic.Data;
        }

        /// <summary>
        /// Пишем выражение в верхнем окне
        /// </summary>
        /// <param name="Toadd"></param>
        /// <param name="oper"></param>
        private void TextAdd( string Toadd, char oper)
        {

            if (!textBox2.Text.Contains('+') && !textBox2.Text.Contains('-') && !textBox2.Text.Contains('*') && !textBox2.Text.Contains('/') && !textBox2.Text.Contains('='))
            { textBox2.Text += " " + Toadd + " " + oper.ToString(); }
            else if (!textBox2.Text.Contains('='))
                    { textBox2.Text += " " + Toadd + " " + oper.ToString(); }

        }

        /// <summary>
        /// Проверка на очистку верхнего поля
        /// </summary>
        private void TextClr()
        {
            if (textBox2.Text.Contains("="))
                textBox2.Text = "";
        }

        /// <summary>
        /// Обработчик цифровой клавиши
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Digital_Click(object sender, EventArgs e)
        {
            //Проверяем необходимость очистки верхнего поля
            this.TextClr();
            try
            {
                //Отдаем в логику цифру
                lLogic.addDigit(sender.ToString().Last());
                TextBoxRefresh();
            }
            
            catch (Exception)
            {
                toolTip1.Show("Число слишком длинное", textBox1, 1000);
            }
        }

        /// <summary>
        /// Обработчик backspace
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bBack_Click(object sender, EventArgs e)
        {
            this.TextClr();

            //backspace в логику
            lLogic.Back();
            this.TextBoxRefresh();
        }

        /// <summary>
        /// Обработчик очистки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bClear_Click(object sender, EventArgs e)
        {
            this.TextClr();

            //Очистка в логику
            lLogic.Clear();
            this.TextBoxRefresh();
        }

        /// <summary>
        /// Обработчик запятой
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bDiv_Click(object sender, EventArgs e)
        {
            this.TextClr();

            //Предаем запятую в логику
            lLogic.Comma();
            this.TextBoxRefresh();
        }


        private void bOper_Click(object sender, EventArgs e)
        {
            this.TextClr();

            //Пишем выражение в верхнее поле
            TextAdd(lLogic.Data,sender.ToString().Last());

            //отправляяем оператор в логику
            lLogic.Oper(sender.ToString().Last());
            TextBoxRefresh();

        }

        private void Equality_Click(object sender, EventArgs e)
        {
            TextAdd(this.textBox1.Text, '=');
            
            //Отправляем запрос на расчёт в логику
            lLogic.Equality();
            this.TextBoxRefresh();
        }

        private void bSigned_Click(object sender, EventArgs e)
        {
            lLogic.Sign();
            this.TextBoxRefresh();
        }

        private void bSqrt_Click(object sender, EventArgs e)
        {
            try
            {
                lLogic.Sqrt();
                this.TextBoxRefresh();
            }

            catch (Exception)
            {
                toolTip1.Show("Корень из отрицательного числа", textBox1, 1000);
                this.TextBoxRefresh();
            }
        }

        private void bRev_Click(object sender, EventArgs e)
        {
            lLogic.Inverse();
            this.TextBoxRefresh();
        }

        private void bPerc_Click(object sender, EventArgs e)
        {

        }
    }
}

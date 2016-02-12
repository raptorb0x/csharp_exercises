//Используемые пространства имен
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        Random r = new Random(); //создание объекта класса Random (так как его методы не статические)
        public Form1()
        {   
            //инициализация формы
            InitializeComponent();
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            //Реализация надписи
            MessageBox.Show("Двойной клик по форме"); 
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {   
            //реализация случайного перемещения кнопки по форме
            this.button1.Location = new System.Drawing.Point(r.Next(1,200),r.Next(1,200));
        }


        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            //Нажатие на бегающую кнопку
            MessageBox.Show("Вы победили!");
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            this.button1.Location = new System.Drawing.Point(r.Next(1, 200), r.Next(1, 200));
        }


    }
}

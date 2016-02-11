using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Logics

{
    public class Logics
    {
        //Поля для хранения чисел на вводе, памяти и операнда
        private string Calc = "0";
        private string Save = "";
        private char Operat = ' ';
        private char cSign = ' ';

        public string Data
        {
            get { return ((this.cSign.ToString() == " ") ? "" : this.cSign.ToString()) + this.Calc; }
        }
        /// <summary>
        /// Ввод нового числа
        /// </summary>
        /// <param name="Символ числа"></param>
        /// <exception cref="Число слишком длинное"></exception>
        public void addDigit(char sNumber)
        {
            if (this.Calc.Length < 10)
            {
                if (this.Calc != "0" || sNumber != '0')
                {
                    if (this.Calc == "0") this.Calc = "";
                    this.Calc += sNumber.ToString();
                }
            }
            else
            {
                throw new Exception("Number too long");
            }
        }

        /// <summary>
        /// Удаляем последнюю цифру, если таких нет то оставляем 0
        /// </summary>
        public void Back()
        {
            this.Calc = this.Calc.Remove(this.Calc.Length - 1, 1);
            if (this.Calc.Length == 0)
                this.Calc = "0";
        }

        /// <summary>
        /// Сбрасываем в 0
        /// </summary>
        public void Clear()
        {
            this.Calc = "0";

        }

        /// <summary>
        /// ввод запятой
        /// </summary>
        public void Comma()
        {
            if (!this.Calc.Contains(","))
                this.Calc += ",";
        }

        public void Sign()
        {
            if (this.Calc != "0")
            {
                if (this.cSign == ' ') this.cSign = '-';
                else cSign = ' ';
            }
        }

        /// <summary>
        /// Плюс
        /// </summary>
        public void Oper(char oper)
        {
            //текующу строку сбросить в сейв
            if (this.Operat == ' ')
            {

                this.Save = this.cSign.ToString() + this.Calc;
                this.Calc = "0";
                this.cSign = ' ';
                Operat = oper;
            }
        }

        /// <summary>
        /// Равно
        /// </summary>
        public void Equality()
        {

            if (Operat != ' ')
            {
                double temp = double.Parse(this.Save);
                switch (Operat)
                {
                    case '+': { temp += double.Parse(this.Data); break; }
                    case '-': { temp -= double.Parse(this.Data); break; }
                    case '*': { temp *= double.Parse(this.Data); break; }
                    case '/': { temp /= double.Parse(this.Data); break; }
                }

                Operat = ' ';
                if (!Double.IsNaN(temp))
                    this.Calc = temp.ToString();
                else this.Calc = "0";
                this.cSign = ' ';
                this.Save = "";

            }
        }

        /// <summary>
        /// Вычисление квадратного корня
        /// </summary>
        public void Sqrt()
        {
            if (cSign == '-')
            {
                cSign = ' ';
                Calc = "0";
                throw new Exception("SQRT from negative number");
            }
            this.Calc = Math.Sqrt(double.Parse(this.Data)).ToString();

        }

        public void Inverse()
        {
            var temp = 1 / double.Parse(this.Data);
            if (!Double.IsNaN(temp))
                this.Calc = temp.ToString();
            else this.Calc = "0";
        }
    }
}

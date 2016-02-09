using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_tests
{
    public class Logics
    {
        //Полz для хранения чисел на вводе и пямяти
        private string Calcul = "0";
        private string Savenumb = "";
        private char Operat = ' ';

        /// <summary>
        /// Свойство для обращения к полю Calcul
        /// </summary>
        public string Calc
        {
            get
            { return Calcul; }
            private set
            { Calcul = value; }
        }

        /// <summary>
        /// Свойство для обращения к полю Save
        /// </summary>
        private string Save
        {
            get
            { return Savenumb ; }
             set
            { Savenumb = value; }
        }

        /// <summary>
        /// Ввод нового числа
        /// </summary>
        /// <param name="Символ числа"></param>
        /// <exception cref="Число слишком длинное"></exception>
        public void addDigit(char sNumber)
        {
            if (this.Calc.Length < 9)
            {
                if (this.Calc != "0" || sNumber != '0')
                {
                    if (this.Calc == "0") this.Calc = "";
                    this.Calc += sNumber.ToString();
                }
            }
            else
            {
                throw new Exception("Число слишком длинное");
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
        public void Div()
        {
            if (!this.Calc.Contains(","))
                this.Calc += ",";
        }

        /// <summary>
        /// Плюс
        /// </summary>
        public void Oper( char oper)
        {
            //текующу строку сбросить в сейв
            if (this.Operat == ' ')
            {

                this.Save = this.Calc;
                this.Calc = "0";
                Operat = oper; 
            }
        }

        /// <summary>
        /// Равно
        /// </summary>
        public void Equality()
        {

            if(Operat!=' ')
            {
                var temp = double.Parse(this.Save);
                switch (Operat)
                {
                    case '+': {temp += double.Parse(this.Calc); break; }
                    case '-': {temp -= double.Parse(this.Calc); break; }
                    case '*': {temp *= double.Parse(this.Calc); break; }
                    case '/': {temp /= double.Parse(this.Calc); break; }
                }

                Operat = ' ';
                this.Calcul = temp.ToString();
                this.Save = "";

            }
        }



    }
}

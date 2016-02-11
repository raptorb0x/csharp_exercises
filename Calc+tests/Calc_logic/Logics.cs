using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Logics

{
    public static class Logics
    {


        //Поля для хранения чисел на вводе, памяти и операнда
        private static string Calc = "0";
        private static string Save = "";
        private static char Operat = ' ';

        /// <summary>
        /// Выдача числа на вводе
        /// </summary>
        public static string Data
        {
            get { return  Calc; }
        }



        /// <summary>
        /// Ввод нового цифры
        /// </summary>
        /// <param name="Символ цыфры"></param>
        /// <exception cref="Number too long"></exception>
        public static void addDigit(char sNumber)
        {
            if (Calc.Length < 10 && !double.IsInfinity(double.Parse(Calc)))
            {
                if (Calc != "0" || sNumber != '0')
                {
                    if (Calc == "0") Calc = "";
                    Calc += sNumber.ToString();
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
        public static void Back()
        {
            Calc = Calc.Remove(Calc.Length - 1, 1);
            if (Calc.Length == 0)
                Calc = "0";
        }

        /// <summary>
        /// Сбрасываем в 0
        /// </summary>
        public static void Clear()
        {
            Calc = "0";

        }

        public static void Reset()
        {
            Calc = "0";
            Save = "";
            Operat = ' ';
        }

        /// <summary>
        /// ввод запятой
        /// </summary>
        public static void Comma()
        {
            if (!Calc.Contains(","))
                Calc += ",";
        }

        public static void Sign()
        {

            var temp = -double.Parse(Data);
            Calc = temp.ToString();

        }

        /// <summary>
        /// Плюс
        /// </summary>
        public static void Oper(char oper)
        {
            //текующу строку сбросить в сейв
            if (Operat == ' ')
            {

                Save =  Calc;
                Calc = "0";
                Operat = oper;
            }
        }

        /// <summary>
        /// Равно
        /// </summary>
        public static void Equality()
        {

            if (Operat != ' ')
            {
                double temp = double.Parse(Save);
                switch (Operat)
                {
                    case '+': { temp += double.Parse(Data); break; }
                    case '-': { temp -= double.Parse(Data); break; }
                    case '*': { temp *= double.Parse(Data); break; }
                    case '/': { temp /= double.Parse(Data); break; }
                }

                Operat = ' ';
                if (!Double.IsNaN(temp))
                    Calc = temp.ToString();
                else Calc = "0";
                Save = "";

            }
        }

        /// <summary>
        /// Вычисление квадратного корня
        /// </summary>
        public static void Sqrt()
        {
            if (double.Parse(Data) < 0)
            {
                Calc = "0";
                throw new Exception("SQRT from negative number");
            }
            Calc = Math.Sqrt(double.Parse(Data)).ToString();

        }

        public static void Inverse()
        {
            var temp = 1 / double.Parse(Data);
            if (!Double.IsNaN(temp))
                Calc = temp.ToString();
            else Calc = "0";
        }


        public static void Percent()
        {
            try
            {
                var percent = double.Parse(Save) * double.Parse(Calc) / 100;
                Calc = percent.ToString();
                Equality();
            }
            catch(Exception )
            {
                throw new Exception("Percent from none");
            }
        }


    }
}

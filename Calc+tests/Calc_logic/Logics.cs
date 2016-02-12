using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Logics

{
    /// <summary>
    /// Статический класс логики
    /// </summary>
    public static class Logics
    {


        //Поля для хранения чисел на вводе, памяти и операнда
        private static string Calc = "0";
        private static string Save = "";
        private static char Operat = ' ';

        //-----------------------------------------------------------------------

        /// <summary>
        /// Вывод числа в работе
        /// </summary>
        public static string Data
        {
            get { return  Calc; }
        }

        //-----------------------------------------------------------------------

        #region Ввод и редактирование чисел

        /// <summary>
        /// Ввод новой цифры
        /// </summary>
        /// <param name="Символ цыфры"></param>
        /// <exception cref="Number too long"></exception>
        public static void addDigit(char sNumber)
        {
            //Если не превыше предела и значение не равно бесконечности
            if (Calc.Length < 10 && !double.IsInfinity(double.Parse(Calc)))
            {
                //Отсекаем лидирующие нули
                if (Calc != "0" || sNumber != '0')  // 
                {
                    //Если в памяти 0 затираем его
                    if (Calc == "0") Calc = ""; 
                    //пишем новую цифру
                    Calc += sNumber.ToString();
                }
            }
            //Если предел или уже есть бесконечность
            else
            {
                //Выбрасываем исключение
                throw new Exception("Number too long");
            }
        }

        /// <summary>
        /// Стирание последней цифры
        /// </summary>
        public static void Back()
        {
            //Стираем последнюю цифру
            Calc = Calc.Remove(Calc.Length - 1, 1);
           
            //Если их больше не осталось
            if (Calc=="" || Calc == "-")

                //Пишем ноль
                Calc = "0";
        }

        /// <summary>
        /// Сброс ввода в 0
        /// </summary>
        public static void Clear()
        {
            Calc = "0";

        }

        /// <summary>
        /// Сброс всей логики
        /// </summary>
        public static void Reset()
        {
            Calc = "0";
            Save = "";
            Operat = ' ';
        }

        /// <summary>
        /// Ввод запятой
        /// </summary>
        public static void Comma()
        {
            //Вводим запятую, только если таковой еще нет
            if (!Calc.Contains(","))
                Calc += ",";
        }

        /// <summary>
        /// Смена знака
        /// </summary>
        public static void Sign()
        {
            var temp = -double.Parse(Data);
            Calc = temp.ToString();
        }

        #endregion

        //-----------------------------------------------------------------------

        #region Вычисления
        
        /// <summary>
        /// Передача символа оператора
        /// </summary>
        /// <param name="символ оператора"></param>
        public static void Oper(char oper)
        {
            //если оператор пуст
            if (Operat == ' ')
            {
                //Сохраняем введенные данные и готовимся к приему новых
                Save =  Calc;
                Calc = "0";
                Operat = oper;
            }
        }

        /// <summary>
        /// Вычисление
        /// </summary>
        public static void Equality()
        {
            //Если оператор есть
            if (Operat != ' ')
            {
                //Вытаскиваем сохраненное значение
                double temp = double.Parse(Save);

                //Выбор по операторам и вычисление
                switch (Operat)
                {
                    case '+': { temp += double.Parse(Data); break; }
                    case '-': { temp -= double.Parse(Data); break; }
                    case '*': { temp *= double.Parse(Data); break; }
                    case '/': { temp /= double.Parse(Data); break; }
                }

                //Если итог определен пишем его на ввод
                if (!Double.IsNaN(temp))
                    Calc = temp.ToString();
                //если нет, то пишем ноль
                else Calc = "0"; 

                //Сбрасываем оператор и память
                Operat = ' ';
                Save = "";
            }
        }

        /// <summary>
        /// Вычисление квадратного корня
        /// </summary>
        public static void Sqrt()
        {
            //Если взятие корня из отрицательного числа
            if (double.Parse(Data) < 0)
            {
                //Сбрасываем в ноль
                Calc = "0";

                //Бросаем исключение
                throw new Exception("SQRT from negative number");
            }
            Calc = Math.Sqrt(double.Parse(Data)).ToString();

        }

        /// <summary>
        /// Обратная пропорцианальность
        /// </summary>
        public static void Inverse()
        {
            //делим единицу на число в работе
            var temp = 1 / double.Parse(Data);
            //сохраняем результат в Calc
            Calc = temp.ToString();
        }

        /// <summary>
        /// Вычисление через процент
        /// </summary>
        public static void Percent()
        {
            //пробуем 
            try
            {
                //Берем процент от значения в памяти, если такого нет - бросается исключение
                var percent = double.Parse(Save) * double.Parse(Calc) / 100;
                
                //Передаем вводу посчитаный процет от сохраненного числа
                Calc = percent.ToString();

                //И считаем выражение
                Equality();
            }

            //Если не смогли вычислить процент
            catch(Exception )
            {
                //Бросаем исключение
                throw new Exception("Percent from none");
            }
        }

        #endregion

        //-----------------------------------------------------------------------
    }
}

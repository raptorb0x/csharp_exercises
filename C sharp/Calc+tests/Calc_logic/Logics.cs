using System;

namespace Calc_logic

{
    /// <summary>
    /// Статический класс логики
    /// </summary>
    public static class Logics
    {


        //Поля для хранения чисел на вводе, памяти и операнда
        private static string _calc = "0";
        private static string _save = "";
        private static char _operat = ' ';

        //-----------------------------------------------------------------------

        /// <summary>
        /// Вывод числа в работе
        /// </summary>
        public static string Data
        {
            get { return  _calc; }
        }

        //-----------------------------------------------------------------------

        #region Ввод и редактирование чисел

        /// <summary>
        /// Ввод новой цифры
        /// </summary>
        /// <param name="Символ цыфры" />
        /// <exception cref="Number too long"></exception>
        public static void AddDigit(char sNumber)
        {
            //если результат не определен стираем его
            if (double.IsNaN(double.Parse(_calc))) _calc = "0";

            //Если не превыше предела и значение не равно бесконечности
            if (_calc.Length < 10 && !double.IsInfinity(double.Parse(_calc))  )
            {
                //Отсекаем лидирующие нули
                if (_calc != "0" || sNumber != '0')  // 
                {
                    //Если в памяти 0 затираем его
                    if (_calc == "0") _calc = ""; 
                    //пишем новую цифру
                    _calc += sNumber.ToString();
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
            _calc = _calc.Remove(_calc.Length - 1, 1);
           
            //Если их больше не осталось
            if (_calc=="" || _calc == "-")

                //Пишем ноль
                _calc = "0";
        }

        /// <summary>
        /// Сброс ввода в 0
        /// </summary>
        public static void Clear()
        {
            _calc = "0";

        }

        /// <summary>
        /// Сброс всей логики
        /// </summary>
        public static void Reset()
        {
            _calc = "0";
            _save = "";
            _operat = ' ';
        }

        /// <summary>
        /// Ввод запятой
        /// </summary>
        public static void Comma()
        {
            //Вводим запятую, только если таковой еще нет
            if (!_calc.Contains(","))
                _calc += ",";
        }

        /// <summary>
        /// Смена знака
        /// </summary>
        public static void Sign()
        {
            var temp = -double.Parse(Data);
            _calc = temp.ToString();
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
            if (_operat == ' ')
            {
                //Сохраняем введенные данные и готовимся к приему новых
                _save =  _calc;
                _calc = "0";
                _operat = oper;
            }
        }

        /// <summary>
        /// Вычисление
        /// </summary>
        public static void Equality()
        {
            //Если оператор есть
            if (_operat != ' ')
            {
                //Вытаскиваем сохраненное значение
                double temp = double.Parse(_save);

                //Выбор по операторам и вычисление
                switch (_operat)
                {
                    case '+': { temp += double.Parse(Data); break; }
                    case '-': { temp -= double.Parse(Data); break; }
                    case '*': { temp *= double.Parse(Data); break; }
                    case '/': { temp /= double.Parse(Data); break; }
                }


                _calc = temp.ToString();
 

                //Сбрасываем оператор и память
                _operat = ' ';
                _save = "";
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
                _calc = "0";

                //Бросаем исключение
                throw new Exception("SQRT from negative number");
            }
            _calc = Math.Sqrt(double.Parse(Data)).ToString();

        }

        /// <summary>
        /// Обратная пропорцианальность
        /// </summary>
        public static void Inverse()
        {
            //делим единицу на число в работе
            var temp = 1 / double.Parse(Data);
            //сохраняем результат в Calc
            _calc = temp.ToString();
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
                var percent = double.Parse(_save) * double.Parse(_calc) / 100;
                
                //Передаем вводу посчитаный процет от сохраненного числа
                _calc = percent.ToString();

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

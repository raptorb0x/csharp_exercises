using System;
namespace Types
{
    /// <summary>
    /// Класс Testing включает данные разных типов. Каждый его 
    /// открытый метод описывает некоторый пример, 
    /// демонстрирующий работу с типами.
    /// Открытые методы могут вызывать закрытые методы класса.
    /// </summary>
    public class Testing
    {
        /// <summary>
        /// набор скалярных данных разного типа.
        /// </summary>
        byte b = 255;
        int x = 11;
        uint ux = 1111;
        float y = 5.5f;
        double dy = 5.55;
        string s = "Hello!";
        string s1 = "25";
        object obj = new Object();
        // Далее идут методы класса, приводимые по ходу 
        // описания примеров

        /// <summary>
        /// Метод выводит на консоль информацию о типе и 
        /// значении фактического аргумента. Формальный 
        /// аргумент имеет тип object. Фактический аргумент 
        /// может иметь любой тип, поскольку всегда 
        /// допустимо неявное преобразование в тип object.
        /// </summary>
        /// <param name="name"> - Имя второго аргумента</param>
        /// <param name="any"> - Допустим аргумент любого типа</param>
        void WhoIsWho(string name, object any)
        {
            Console.WriteLine("type {0} is {1} , value is {2}",
                name, any.GetType(), any.ToString());
        }

        /// <summary>
        /// получаем информацию о типе и значении
        /// переданного аргумента - переменной или выражения
        /// </summary>
        public void WhoTest()
        {
            WhoIsWho("x", x);
            WhoIsWho("ux", ux);
            WhoIsWho("y", y);
            WhoIsWho("dy", dy);
            WhoIsWho("s", s);
            WhoIsWho("11 + 5.55 + 5.5f", 11 + 5.55 + 5.5f);
            obj = 11 + 5.55 + 5.5f;
            WhoIsWho("obj", obj);
        }

        /// <summary>
        /// Возвращает переданный ему аргумент.
        /// Фактический аргумент может иметь произвольный тип.
        /// Возвращается всегда объект класса object.
        /// Клиент, вызывающий метод, должен при необходимости 
        /// задать явное преобразование получаемого результата
        /// </summary>
        /// <param name="any"> Допустим любой аргумент</param>
        /// <returns></returns>
        object Back(object any)
        {
            return (any);
        }
        /// <summary>
        /// Неявное преобразование аргумента в тип object
        /// Явное приведение типа результата.
        /// </summary>
        public void BackTest()
        {
            ux = (uint)Back(ux);
            WhoIsWho("ux", ux);
            s1 = (string)Back(s);
            WhoIsWho("s1", s1);
            x = (int)(uint)Back(ux);
            WhoIsWho("x", x);
            y = (float)(double)Back(11 + 5.55 + 5.5f);
            WhoIsWho("y", y);
        }
    }
}
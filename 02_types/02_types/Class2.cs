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

        /// <summary>
        /// Группа перегруженных методов OLoad
        /// с одним или двумя аргументами арифметического типа.
        /// Если фактический аргумент один, то будет вызван один из 
        /// методов, наиболее близко подходящий по типу аргумента.
        /// При вызове метода с двумя аргументами возможен 
        /// конфликт выбора подходящего метода, приводящий 
        /// к ошибке периода компиляции.
        /// </summary>
        void OLoad(float par)
        {
            Console.WriteLine("float value {0}", par);
        }
        /// <summary>
        /// Перегруженный метод OLoad с одним параметром типа long
        /// </summary>
        /// <param name="par"></param>
        void OLoad(long par)
        {
            Console.WriteLine("long value {0}", par);
        }
        /// <summary>
        /// Перегруженный метод OLoad с одним параметром типа ulong
        /// </summary>
        /// <param name="par"></param>
        void OLoad(ulong par)
        {
            Console.WriteLine("ulong value {0}", par);
        }
        /// <summary>
        /// Перегруженный метод OLoad с одним параметром типа double
        /// </summary>
        /// <param name="par"></param>
        void OLoad(double par)
        {
            Console.WriteLine("double value {0}", par);
        }
        /// <summary>
        /// Перегруженный метод OLoad с двумя параметрами типа long и long
        /// </summary>
        /// <param name="par1"></param>
        /// <param name="par2"></param>
        void OLoad(long par1, long par2)
        {
            Console.WriteLine("long par1 {0}, long par2 {1}", par1, par2);
        }
        /// <summary>
        /// Перегруженный метод OLoad с двумя параметрами типа 
        /// double и double
        /// </summary>
        /// <param name="par1"></param>
        /// <param name="par2"></param>
        void OLoad(double par1, double par2)
        {
            Console.WriteLine("double par1 {0}, double par2 {1}", par1, par2);
        }
        /// <summary>
        /// Перегруженный метод OLoad с двумя параметрами типа 
        /// int и float
        /// </summary>
        /// <param name="par1"></param>
        /// <param name="par2"></param>
        void OLoad(int par1, float par2)
        {
            Console.WriteLine("int par1 {0}, float par2 {1}", par1, par2);
        }

        /// <summary>
        /// Вызов перегруженного метода OLoad. В зависимости от 
        /// типа и числа аргументов вызывается один из методов группы.
        /// </summary>
        public void OLoadTest()
        {
            OLoad(x); OLoad(ux);
            OLoad(y); OLoad(dy);
            // OLoad(x,ux); 
            // conflict: (int, float) и (long,long)
            OLoad(x, (float)ux);
            OLoad(y, dy); OLoad(x, dy);
        }
    }
}
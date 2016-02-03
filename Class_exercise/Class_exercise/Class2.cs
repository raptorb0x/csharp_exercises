using System;

namespace Class_exercise
{
    /// <summary>
    /// Класс Point для хранения точки и взаимодейсвием с ней
    /// </summary>
    /// <remarks>
    /// включает в себя
    /// Поля:
    ///     int x, y;
    ///Конструкторы, позволяющие создать экземпляр класса:
    ///     с нулевыми координатами;
    ///     с заданными координатами.
    ///Методы, позволяющие:
    ///     вывести координаты точки на экран;
    ///     рассчитать расстояние от начала координат до точки;
    ///     переместить точку на плоскости на вектор(a, b).
    ///Свойства:
    ///     получить-установить координаты точки(доступное для чтений и записи);
    ///     позволяющие умножить координаты точки на скаляр(доступное только для записи).
    /// </remarks>
    class Point
    {

        /// <summary>
        /// поля класса Point
        /// </summary>
        int x;
        int y;

        /// <summary>
        /// Конструктор объекта со значениями по умолчанию
        /// </summary>
        public Point()
        {
            x = 0;
            y = 0;
        }

        /// <summary>
        /// Конструктор объекта с заданными значениями
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Вывод координат точки
        /// </summary>
        public void Print()
        {
            Console.WriteLine("Координаты точки:\n x = {0}\n y = {1}", x, y);
        }

        /// <summary>
        /// Расчет растояния от центра координат до точки
        /// </summary>
        /// <returns>Расстояние от центра координат до точки</returns>
        public double Delta()
        {
            return Math.Sqrt(x * x + y * y);
        }

        /// <summary>
        /// Перемещение точки на вектрор (a,b)
        /// </summary>
        /// <param name="a">Координата вектора X</param>
        /// <param name="b">Координата векторв Y</param>
        public void Vector(int a,int b)
        {
            this.x += a;
            this.y += b;
        }

        /// <summary>
        /// Координата Х точки
        /// </summary>
         public int X
        {
           
            get
            {

                return x;
            }

            set
            {
                x = value;
            }
        }

        /// <summary>
        /// Координата Y точки
        /// </summary>
        public int Y
        {

            get
            {

                return y;
            }

            set
            {
                y = value;
            }
        }

        /// <summary>
        /// Умножение на скаляр
        /// </summary>
        public int Scale
        {
            set
            {
                x *= value;
                y *= value;
            }
        }
    }
}

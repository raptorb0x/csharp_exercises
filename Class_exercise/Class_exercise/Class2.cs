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
    /// 
    /// Продолжение 
    /// В класс Point добавить:
    ///     Индексатор, позволяющий по индексу 0 обращаться к полю x, по индексу 1 - к полю y, при других значениях индекса выдается сообщение об ошибке.
    ///Перегрузку:
    ///     операции ++ ( -- ): одновременно увеличивает(уменьшает) значение полей х и у на 1 ;
    ///     констант true и false: обращение к экземпляру класса дает значение true, если значение полей x и у совпадает, иначе false ;
    ///     операции бинарный +: одновременно добавляет к полям х и у значение скаляра;
    ///     преобразования типа Point в string (и наоборот).
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

        /// <summary>
        /// Индексатор с выбрасыванием исключания
        /// </summary>
        /// <param name="i">Индекс</param>
        /// <returns></returns>
        public int this [int i]
        {
            get
            {
                if (i == 0) return x;
                if (i == 1) return y;
                throw new Exception("При чтении индекс только 0 или 1");
            }

            set
            {
                if (i == 0) x = value;
                if (i == 1) y = value;
                if (i == 0 || i == 1) { }
                else throw new Exception("При записи индекс только 0 или 1");
            }
        }

        /// <summary>
        /// Перегруженный декремент вычитает из X и Y по единице
        /// </summary>
        /// <param name="a">Объект</param>
        /// <returns>Объект</returns>
        public static Point operator --(Point a)
        {
            Point temp = new Point(a.X - 1, a.Y - 1);
            return temp;
        }

        /// <summary>
        /// Перегруженный инкремент увеличивает X и Y на единицу
        /// </summary>
        /// <param name="a">Объект</param>
        /// <returns>Объект</returns>
        public static Point operator ++(Point a)
        {
            Point temp = new Point(a.X + 1, a.Y + 1);
            return temp;
        }

        /// <summary>
        /// Перегруженая истина в случае если X и Y равны
        /// </summary>
        /// <param name="a">Объект</param>
        /// <returns>bool</returns>
        public static bool operator true(Point a)
        {
            if (a.X == a.Y)
                return true;
            return false;
        }

        /// <summary>
        /// Перегруженая ложь в случае если X и Y равны
        /// </summary>
        /// <param name="a">Объект</param>
        /// <returns>Bool</returns>
        public static bool operator false(Point a)
        {
            if (a.X != a.Y)
                return false;
            return true;
        }

        /// <summary>
        /// Скалярное сложение
        /// </summary>
        /// <param name="a">Объект</param>
        /// <param name="b">Скаляр</param>
        /// <returns>Объект</returns>
        public static Point operator +(Point a, int b)
        {
            Point temp = new Point(a.X + b, a.Y + b);
            return temp;
        }

        /// <summary>
        /// Преобразование типа Point в string
        /// </summary>
        /// <param name="a">Объект</param>
        public static implicit operator string (Point a)
        {
            return a.X.ToString() + " " + a.Y.ToString();
        }

        /// <summary>
        /// Преобразование типа строки в Point
        /// </summary>
        /// <param name="s">Строка</param>
        public static implicit operator Point (String s)
        {
            //режем строку по кускам по пробелу
            String[] xy = s.Split(' ');

            //консруируем временный объект парся данные порезанных строк
            Point temp = new Point(Int32.Parse(xy[0]), Int32.Parse(xy[1]));

            //возвращает объект
            return temp;
        }
    }
}

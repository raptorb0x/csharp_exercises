using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    /// <summary>
    /// Потомок абстрактного класса Figure для реализации прямоугольника
    /// </summary>
    class Rectangle :Figure
    {

        private int x1;
        private int y1;
        private int x2;
        private int y2;

        /// <summary>
        /// Глобальный конструктор класса 
        /// </summary>
        /// <param name="x1">Первая координата X</param>
        /// <param name="y1">Первая координата Y</param>
        /// <param name="x2">Вторая координата X</param>
        /// <param name="y2">Вторая координата Y</param>
        public Rectangle(int x1,int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        /// <summary>
        /// Конструктор класса с значениями по умолчанию
        /// </summary>
        public Rectangle():this(0,0,1,1) { }

        /// <summary>
        /// Переопределение абстрактного метода подсчета площади для Rectangle
        /// </summary>
        /// <returns>Площадь</returns>
        public override double Area()
        {
            return (x2 - x1) * (y2 - y1);
        }

        /// <summary>
        /// Переопределение абстрактного метода подсчета периметра для Rectangle
        /// </summary>
        /// <returns>Периметр</returns>
        public override object Perimeter()
        {
            return (x2 - x1 + y2 - y1) * 2;
        }

        /// <summary>
        /// Переопределение абстрактного метода вывода информации о фигурах для Rectangle
        /// </summary>
        public override void Show()
        {
            Console.WriteLine("Прямоугольник  с кординатами {0},{1}:{2},{3} периметром {4:###} и площадью {5:###}", x1, y1, x2, y2, Perimeter(), Area());
        }


    }
}

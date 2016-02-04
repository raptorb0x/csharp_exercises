using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{

    /// <summary>
    /// Потомок абстрактного класса Figure для реализации круга
    /// </summary>
    class Circle:Figure
    {
        private int x;
        private int y;
        private int r;

        /// <summary>
        /// Глобальный конструктор класса 
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="r">Радиус</param>
        public Circle(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
        }

        /// <summary>
        /// Конструктор класса с значениями по умолчанию
        /// </summary>
        public Circle():this(0,0,0) {}

        /// <summary>
        /// Конструктор класса заданным радиусом
        /// </summary>
        /// <param name="r">Радиус</param>
        public Circle(int r):this(0,0,r) {}

        /// <summary>
        /// Конструктор класса заданными координатами
        /// </summary>
        /// <param name="x">Координата Х</param>
        /// <param name="y">Координата Y</param>
        public Circle(int x, int y):this(x,y,0) {}

        /// <summary>
        /// Переопределение абстрактного метода подсчета периметра для Circle
        /// </summary>
        /// <returns>Периметр</returns>
        public override double Perimeter()
        {
            return 2 * r * Math.PI;
        }

        /// <summary>
        /// Переопределение абстрактного метода подсчета площади для Circle
        /// </summary>
        /// <returns>Площадь</returns>
        public override double Area()
        {
            return  r * r * Math.PI;
        }

        /// <summary>
        /// Переопределение абстрактного метода вывода информации о фигурах для Circle
        /// </summary>
        public override void Show()
        {
            Console.WriteLine("Круг с кординатами {0},{1} периметром {2:###.###} и площадью {3:###.###}", x, y, Perimeter(), Area());
        }
    }
}

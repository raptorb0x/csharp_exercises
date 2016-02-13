using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Triangle:Figure
    {
        private int x1, x2, x3, y1, y2, y3;

        /// <summary>
        /// Глобальный конструктор класса 
        /// </summary>
        /// <param name="x1">Первая координата X</param>
        /// <param name="y1">Первая координата Y</param>
        /// <param name="x2">Вторая координата X</param>
        /// <param name="y2">Вторая координата Y</param>
        /// <param name="x3">Третья координата X</param>
        /// <param name="y3">Третья координата Y</param>
        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.y1 = y1;
            this.y2 = y2;
            this.y3 = y3;
        }

        /// <summary>
        /// Конструктор класса с значениями по умолчанию
        /// </summary>
        public Triangle ():this(0,0,3,0,0,4) { }

        //Для подсчета периметра и площади треугольника необходимо знать
        //длины его сторон, создамим их как свойства
        //считать их будем по формуле  p(1,2) = sqrt((x1-x2)^2 + (y1-y2)^2)
        //где p(1,2) - длина стороны x1,y1,x2,y2 - координаты соответствующих вершин стороны        

        /// <summary>
        /// Свойство для получения длины первой стороны треугольника
        /// </summary>
        protected double P12
        {
            get
            {
                return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            }
        }

        /// <summary>
        /// Свойство для получения длины второй стороны треугольника
        /// </summary>
        protected double P23
        {
            get
            {
                return Math.Sqrt((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3));
            }
        }

        /// <summary>
        /// Свойство для получения длины третьей стороны треугольника
        /// </summary>
        protected double P31
        {
            get
            {
                return Math.Sqrt((x3 - x1) * (x3 - x1) + (y3 - y1) * (y3 - y1));
            }
        }


        /// <summary>
        /// Переопределение абстрактного метода подсчета площади для Triangle
        /// </summary>
        /// <returns>Площадь</returns>
        public override double Area()
        {
            //для вычисления площади треугольника воспользуемся формулой Герона
            //S = sqrt(p(p-a)(p-b)(p-c)) где S - площадь треугольника
            // a,b,c - длины сторон треугольника, p - полупериметр треугольника 
            //p = (a+b+c)/2

            //получаем полупериметр
            double p =(double) Perimeter() / 2;

            return Math.Sqrt(p * (p - P12) * (p - P23) * (p - P31));
        }

        /// <summary>
        /// Переопределение абстрактного метода подсчета периметра для Triangle
        /// </summary>
        /// <returns>Периметр</returns>
        public override object Perimeter()
        {
            return P12+P23+P31;
        }

        /// <summary>
        /// Переопределение абстрактного метода вывода информации о фигурах для Rectangle
        /// </summary>
        public override void Show()
        {
            //Длинная строка получилась, решил разделить
            Console.WriteLine("Треугольник с вершинами {0},{1}:{2},{3}:{4},{5};" +                
                "периметром {6:##.###} и площадью {7:##.###}",x1,y1,x2,y2,x3,y3,Perimeter(),Area());
        }


    }
}

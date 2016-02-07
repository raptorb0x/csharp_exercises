using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    /// <summary>
    /// Абстрактный класс Figure
    /// состоит из абстрактных методов 
    /// подсчета площади, периметра
    /// и вывода результатов
    /// </summary>
    abstract class Figure:iFigure,IFig_Perimeter,IComparable
    {
        /// <summary>
        /// Абстрактный метод подсчета площади
        /// </summary>
        /// <returns>Площадь</returns>
        abstract public double Area();  

        /// <summary>
        /// Абстрактный метод подсчета периметра
        /// </summary>
        /// <returns>Периметр</returns>
        abstract public object Perimeter();

        /// <summary>
        /// Реализация метода CompareTo
        /// </summary>
        /// <param name="obj">Объект</param>
        /// <returns>Результат сравнения</returns>
        public int CompareTo(object obj)
        {
            // преобразуем к абстракному типу 
            Figure temp = (Figure)obj;

            // Сравниваем по площади 
            if (this.Area() == temp.Area()) return 0;
            else if (this.Area() > temp.Area()) return 1;
            else return -1;
        }

        /// <summary>
        /// Абстрактный метод вывода информации о фигурах
        /// </summary>
        abstract public void Show();
    }
}

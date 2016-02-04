using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    /// <summary>
    /// Абстрактный класс Figure
    /// состоит из абстрактных методов 
    /// подсчета площади, периметра
    /// и вывода результатов
    /// </summary>
    abstract class Figure
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
        abstract public double Perimeter();

        /// <summary>
        /// Абстрактный метод вывода информации о фигурах
        /// </summary>
        abstract public void Show();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    /// <summary>
    /// Интерфейс iFigure
    /// состоит из сигнатур методов 
    /// подсчета площади
    /// и вывода результатов
    /// </summary>
    interface iFigure
    {
        /// <summary>
        /// Сигнатура метода подсчета площади
        /// </summary>
        /// <returns>Площадь</returns>
        double Area();  

        /// <summary>
        /// Сигнатура метода вывода информации о фигурах
        /// </summary>
        void Show();
    }
}

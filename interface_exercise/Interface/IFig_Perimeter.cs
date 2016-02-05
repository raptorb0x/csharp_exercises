using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    /// <summary>
    /// Интерефейс IFig_Perimeter
    /// состоит из сигнатуры метода посчета периметра
    /// </summary>
    interface IFig_Perimeter
    {

        /// <summary>
        /// Сигнатура метода посчета периметра
        /// </summary>
        /// <returns>Объект</returns>
        object Perimeter();

        //Возвращает именно объект а не тип - костыль
        //В нашем случае у прямоугольника будет int тип значения периметра, у круга и треугольника - double 
        //для пробы сделал через object, упаковку/распаковку оставим системе
        //Площадь прямоугольника тоже типа int, пусть будет так.

        // может попробовать решить через шаблоны?.
    }
}

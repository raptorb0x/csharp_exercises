using System;

/// <summary>
/// Пространсво имен нашего проекта
/// </summary>
namespace Class_exercise
{
    /// <summary>
    /// Основной класс
    /// </summary>
    public class Class1
    {
        /// <summary>
        /// Точка входа
        /// </summary>
        static void Main()
        {
            // создаем объекты через разные конструкторы
            Point oPoint = new Point(10,5);
            Point oPoint2 = new Point(); 
            
            //выводим данные 
            oPoint.Print();
            oPoint2.Print();

            //считаем растояние от точки до центра координат
            Console.WriteLine("Расстояние от точки до центра координат = {0:.####}", oPoint.Delta());

            //Сложение точки с вектором
            oPoint.Vector(5, 10);
            oPoint.Print();

            //используем set 
            oPoint.X = 3;
            oPoint.Y = 5;

            //используем get
            Console.WriteLine("Координаты точки:\n x = {0}\n y = {1}", oPoint.X, oPoint.Y);
 
            oPoint.Scale = 3;
            oPoint.Print();

            Console.ReadKey();
        }
    }
}

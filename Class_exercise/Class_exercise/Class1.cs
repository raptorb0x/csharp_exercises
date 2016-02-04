using System;


namespace Class_Exercise
{
    /// <summary>
    /// Основной класс
    /// </summary>
    public static class Class1
    {
        /// <summary>
        /// Точка входа
        /// </summary>
        static void Main()
        {
            // создаем объект через разные конструкторы и выводим результат
            //первый конструктор
            Point oPoint = new Point();
            oPoint.Print();

            //второй консруктор 
            oPoint = new Point(10, 5);
            oPoint.Print();

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
 
            //Используем индексатор с отловом исключения
            try
            {
                oPoint[0] = 1;
                oPoint[1] = 2;
                //oPoint[2] = -1;   // возникает исключение set
                Console.WriteLine("Координаты точки:\n x = {0}\n y = {1}", oPoint[0], oPoint[1]);
                //Console.WriteLine("{0}", oPoint[2]);  /// возникает исключение get
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //Перегруженный декремент и вывод результата
            oPoint--;
            oPoint.Print();

            //Перегруженный инкремент и вывод результата
            oPoint++;
            oPoint.Print();    

            // Перегруженные True и False
            if (oPoint)
                Console.WriteLine("X и Y равны");
            else
                Console.WriteLine("X и Y неравны");

            //Свойство Scale для скалирования и вывод результата
            oPoint.Scale = 0;
            oPoint.Print();

            if (oPoint)
                Console.WriteLine("X и Y равны");
            else
                Console.WriteLine("X и Y неравны");

            //Перегруженное сложение
            oPoint += 5;
            oPoint.Print();

            //приведение типов - объект в строку
            Console.WriteLine("Преобразование объекта в строку " + oPoint);

            //преобразование строки в объект
            string sString = "21 13";
            oPoint = sString;
            oPoint.Print();

            //для задержки окна при отладке
            Console.ReadKey();

        }
    }
}

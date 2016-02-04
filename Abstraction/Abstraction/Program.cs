﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Задание :
/// Создать абстрактный класс Figure с методами вычисления площади и периметра, а также методом, выводящим информацию о фигуре на экран.
/// Создать производные классы: Rectangle(прямоугольник), Circle(круг), Triangle(треугольник) со своими методами вычисления площади и периметра.
/// Создать массив n фигур и вывести полную информацию о фигурах на экран.
/// </summary>


namespace Abstraction
{
    class Program
    {
        
        /// <summary>
        /// Точка входа
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Массив ссылок
            Figure[] Fig = new Figure[6];

            //заполнение массива ссылками на объекты поизводных классов
            Fig[0] = new Circle(7);
            Fig[1] = new Circle(2, 3, 2);

            //Пока не весь массив заполнен ссылками, ловим пустую ссылку 
            try
            {

                //Для каждого объекта 
                foreach (Figure item in Fig)
                {
                    //вызываем метод Show
                    item.Show();
                }
            }

            //ловим исключение
            catch (Exception e)
            {
                //пишем текс исключения
                Console.WriteLine(e.Message);
            }

            //Задерживаем консоль при отладке 
            Console.ReadKey();
        }
    }
}

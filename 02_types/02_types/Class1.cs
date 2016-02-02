using System;
namespace Types
{
    /// <summary>
    /// Проект Types содержит примеры, иллюстрирующие работу
    /// со встроенными скалярными типами языка С#.
    /// Проект содержит классы: Testing, Class1.
    /// 
    /// </summary>
    class Class1
    {
        /// <summary>
        /// Точка входа проекта.
        /// В ней создается объект класса Testing
        /// и вызываются его методы.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Testing tm = new Testing();
            Console.WriteLine("Testing.Who Test");
            tm.WhoTest();
            Console.WriteLine("Testing.Back Test");
            tm.BackTest();
            Console.WriteLine("Testing.OLoad Test");
            tm.OLoadTest();
            Console.WriteLine("Testing.ToString Test");
            tm.ToStringTest();
            Console.WriteLine("Testing.FromString Test");
            tm.FromStringTest();
            Console.WriteLine("Testing.CheckUncheck Test");
            tm.CheckUncheckTest();
        }
    }
}
using System;
namespace Types
{
    /// <summary>
    /// Класс Testing включает данные разных типов. Каждый его 
    /// открытый метод описывает некоторый пример, 
    /// демонстрирующий работу с типами.
    /// Открытые методы могут вызывать закрытые методы класса.
    /// </summary>
    public class Testing
    {
        /// <summary>
        /// набор скалярных данных разного типа.
        /// </summary>
        byte b = 255;
        int x = 11;
        uint ux = 1111;
        float y = 5.5f;
        double dy = 5.55;
        string s = "Hello!";
        string s1 = "25";
        object obj = new Object();
        // Далее идут методы класса, приводимые по ходу 
        // описания примеров
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure[] Fig = new Figure[6];

            Fig[0] = new Circle(7);
            Fig[1] = new Circle(2, 3, 2);
            try
            {
                foreach (Figure item in Fig)
                {
                    item.Show();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}

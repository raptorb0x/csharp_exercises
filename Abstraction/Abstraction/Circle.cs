using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Circle:Figure
    {
        private int x;
        private int y;
        private int r;

        public Circle(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
        }

        public Circle():this(0,0,0) {}

        public Circle(int r):this(0,0,r) {}

        public Circle(int x, int y):this(x,y,0) {}

        public override double Perimeter()
        {
            return 2 * r * Math.PI;
        }

        public override double Area()
        {
            return  r * r * Math.PI;
        }

        public override void Show()
        {
            Console.WriteLine("Круг с кординатами {0},{1} периметром {2:###.###} и площадью {3:###.###}", x, y, this.Perimeter(), this.Area());
        }
    }
}

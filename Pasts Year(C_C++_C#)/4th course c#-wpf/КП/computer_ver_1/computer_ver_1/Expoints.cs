using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace computer_ver_1
{
    public class Expoints
    {
        public int performance;
        public int energy;
        public int cost;
        public int safety;

        public Expoints(int p, int e, int c, int s)
        {
            Perfomance = p;
            Energy = e;
            Cost = c;
            Safety = s;
        }

        public int Perfomance
        {
            get { return performance; }
            set { performance = value; }
        }

        public int Energy
        {
            get { return energy; }
            set { energy = value; }
        }

        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public int Safety
        {
            get { return safety; }
            set { safety = value; }
        }
    }
}

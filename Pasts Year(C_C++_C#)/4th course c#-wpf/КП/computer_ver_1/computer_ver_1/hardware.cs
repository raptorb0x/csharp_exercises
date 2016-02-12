using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.ComponentModel;

namespace computer_ver_1
{
    class hardware
    {
        public hardware(string t, string cn, string mn, string desc, int c, string d, int pp, int pe, int pc, int ps)
        {
            TypeHardWare = t;
            CompanyName = cn;
            ModelName = mn;
            Describe = desc;
            Cost = c;
            Dependence = d;
            point = new Expoints(0,0,0,0);
            point.performance = pp;
            point.energy = pe;
            point.cost = pc;
            point.safety = ps;
        } 

        public string TypeHardWare
        {
            get { return typeh; }
            set { typeh = value; }
        }

        public string CompanyName
        {
            get { return companyname; }
            set { companyname = value; }
        }

        public string ModelName
        {
            get { return modelname; }
            set { modelname = value; }
        }

        public string Describe
        {
            get { return describe; }
            set { describe = value; }
        }

        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        [Browsable(false)]
        public Expoints Point
        {
            get { return point; }
            set { point = value; }
        }

        public int Perfomance
        {
            get { return Point.performance; }
            set { Point.performance = value; }
        }

        public int Power
        {
            get { return Point.energy; }
            set { Point.energy = value; }
        }

        public int CostBall
        {
            get { return Point.cost; }
            set { Point.cost = value; }
        }

        public int Safety
        {
            get { return Point.safety; }
            set { Point.safety = value; }
        }

        public string Dependence
        {
            get { return dependence; }
            set { dependence = value; }
        }

        private string typeh;
        private string companyname;
        private string modelname;
        private string describe;
        private string dependence;
        private int cost;
        private Expoints point;

        public XElement ToXml()
        {
            XElement elem = new XElement("hardware",
                new XElement("typeHardWare", TypeHardWare),
                new XElement("companyName", CompanyName),
                new XElement("modelName", ModelName),
                new XElement("describe", Describe),
                new XElement("cost", Cost),
                new XElement("dependence", Dependence),
                new XElement("point", 
                    new XElement ("performance", point.performance),
                    new XElement ("energy", point.energy),
                    new XElement ("cost", point.cost),
                    new XElement ("safety", point.safety)));
                return elem; 
        }

        static public hardware FromXml(XElement elem)
        {
            hardware h = new hardware("", "", "", "", 0, "", 0, 0, 0, 0);
            h.TypeHardWare = elem.Element("typeHardWare").Value;
            h.CompanyName = elem.Element("companyName").Value;
            h.ModelName = elem.Element("modelName").Value;
            h.Describe = elem.Element("describe").Value;
            h.Cost = Convert.ToInt32(elem.Element("cost").Value);
            h.Dependence = elem.Element("dependence").Value;
            XElement point = elem.Element("point");
            h.+t.performance = Convert.ToInt32(point.Element("performance").Value);
            h.point.energy = Convert.ToInt32(point.Element("energy").Value);
            h.point.cost = Convert.ToInt32(point.Element("cost").Value);
            h.point.safety = Convert.ToInt32(point.Element("safety").Value);
            return h;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace lab2
{
    public class MasterAnswers
    {
        

        public ArrayList _sata = new ArrayList();
        public ArrayList _pci = new ArrayList();
        public ArrayList _graphpu = new ArrayList();
        public ArrayList _ddr = new ArrayList();
        public ArrayList _sock = new ArrayList();
        public ArrayList _graph = new ArrayList();
        public ArrayList _price = new ArrayList();
        public MasterAnswers()
        {

        }

        public string ToString()
        {
            StringBuilder buf = new StringBuilder();
            buf.Append("Sata - ");
            foreach (int ag in _sata)
            {
                buf.AppendFormat("{0}, ", ag);
            }
            buf.Append("PCI - ");
            foreach (int ag in _pci)
            {
                buf.AppendFormat("{0}, ", ag);
            }
            buf.Append("GraphPU - ");
            foreach (int ag in _graphpu)
            {
                buf.AppendFormat("{0}, ", ag);
            }
            buf.Append("DDR - ");
            foreach (int ag in _ddr)
            {
                buf.AppendFormat("{0}, ", ag);
            }
            buf.Append("sock - ");
            foreach (int ag in _sock)
            {
                buf.AppendFormat("{0}, ", ag);
            }
            buf.Append("Graph - ");
            foreach (int ag in _graph)
            {
                buf.AppendFormat("{0}, ", ag);
            }
            buf.Append("Price - ");
            foreach (int ag in _price)
            {
                buf.AppendFormat("{0}, ", ag);
            }
            return buf.ToString();
        }
    }
}

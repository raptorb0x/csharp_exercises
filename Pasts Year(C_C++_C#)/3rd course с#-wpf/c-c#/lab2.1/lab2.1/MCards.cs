using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
namespace lab2
{
    class MCards //: IComparable
    {
        public MCards(string m, string ma, string s, string gr, int gpu, int pci, int ddr, int sata,int pr) {
            Model = m;
            Manufacturer = ma;
            Socket = s;
            Graph = gr;
            GraphPU = gpu;
            Amount_of_PCI = pci;
            Amount_of_DDR_DIMM = ddr;
            Amount_of_SATA_channels = sata;
            Price = pr;
        }

        public string Model {
            get { return model; }
            set { model = value; }
        }

        public string Manufacturer {
            get { return manufacturer; }
            set { manufacturer = value; }
        }
        public string Socket {
            get { return socket; }
            set { socket = value; }
        }
        public string Graph
        {
            get { return graph; }
            set { graph = value; }
        }
        public int GraphPU
        {
            get { return graphpu; }
            set { graphpu = value; }
        }
        public int Amount_of_PCI
        {
            get { return amount_of_pci; }
            set { amount_of_pci = value; }
        }
        public int Amount_of_DDR_DIMM
        {
            get { return amount_of_ddr_dimm; }
            set { amount_of_ddr_dimm = value; }
        }
        public int Amount_of_SATA_channels
        {
            get { return amount_of_sata_channels; }
            set { amount_of_sata_channels = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public XElement ToXml()
        {
            XElement elem = new XElement("MCards",
                new XElement("model", Model),
                new XElement("manufacturer", Manufacturer),
                new XElement("socket", Socket),
                new XElement("graph", Graph),
                new XElement("graphPU", GraphPU),
                new XElement("amount_of_pci", Amount_of_PCI),
                new XElement("amount_of_ddr_dimm", Amount_of_DDR_DIMM),
                new XElement("amount_of_sata_channels", Amount_of_SATA_channels),
                new XElement("price",Price));
            return elem;
        }
        static public MCards FromXml(XElement elem)
        {
            MCards p = new MCards("", "", "", "", 0,0,0,0,0);
            p.Model = elem.Element("model").Value;
            p.Manufacturer = elem.Element("manufacturer").Value;
            p.Socket = elem.Element("socket").Value;
            p.Graph = elem.Element("graph").Value;
            p.GraphPU = Convert.ToInt32(elem.Element("graphPU").Value);
            p.Amount_of_PCI = Convert.ToInt32(elem.Element("amount_of_pci").Value);
            p.Amount_of_DDR_DIMM = Convert.ToInt32(elem.Element("amount_of_ddr_dimm").Value);
            p.Amount_of_SATA_channels = Convert.ToInt32(elem.Element("amount_of_sata_channels").Value);
            p.Price = Convert.ToInt32(elem.Element("price").Value);
            return p;
        }

        private string model;
        private string manufacturer;
        private string socket;
        private string graph;
        private int graphpu;
        private int amount_of_pci;
        private int amount_of_ddr_dimm;
        private int amount_of_sata_channels;
        private int price;


        public bool CheckFilter(Dictionary<string, object> dict)
        {
            foreach (string key in dict.Keys)
            {
                switch (key)
                {
                    case "Model":
                        if (!Model.Contains((String)dict[key]))
                            return false;
                        break;
                    case "Manufacturer":
                        if (!Manufacturer.Contains((String)dict[key]))
                            return false;
                        break;
                    case "Socket":
                        if (!Socket.Contains((String)dict[key]))
                            return false;
                        break;
                    case "Graph":
                        if (!Graph.Contains((String)dict[key]))
                            return false;
                        break;
                    case "GraphPU":
                        if (!(GraphPU == Convert.ToInt32(dict[key])))
                            return false;
                        break;
                  /*  case "AmountofPCI":
                        if (!Amount_of_PCI.Contains((String)dict[key]))
                            return false;
                        break;
                    case "AmountofDDRDIMM":
                        if (!Amount_of_DDR_DIMM.Contains((String)dict[key]))
                            return false;
                        break;
                    case "AmountofSATAchannels":
                        if (!Amount_of_SATA_channels.Contains((String)dict[key]))
                            return false;
                        break;*/
                    case "Price":
                        if (!(Price == Convert.ToInt32(dict[key])))
                            return false;
                        break;
                }
            }
            return true;
        }

    }
}

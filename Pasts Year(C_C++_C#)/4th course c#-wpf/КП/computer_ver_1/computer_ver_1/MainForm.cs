using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace computer_ver_1
{
    public partial class MainForm : Form
    {
        ObjectList<hardware> bl = new ObjectList<hardware>();
        public string mode;
        public string mdep;

        public MainForm()
        {
            InitializeComponent();
            XDocument xdoc = XDocument.Load("../basa100.xml");
            foreach (XElement xelem in xdoc.Root.Descendants("hardware"))
            {
                bl.Add(hardware.FromXml(xelem));
            }
        }
        
        public string Mode
        {
            get { return mode; }
            set { mode = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mode = "enter";
            PassForm p = new PassForm(mode);
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowDB sdb1 = new ShowDB();
            #region xml open coment
            /*XDocument xdoc = XDocument.Load("D:/Учеба/prim2.xml");
            foreach (XElement xelem in xdoc.Root.Descendants("hardware"))
            {
                bl.Add(hardware.FromXml(xelem));
            }*/
            #endregion
            sdb1.dataGridViewShowDB.AutoGenerateColumns = true;
            sdb1.dataGridViewShowDB.DataSource = bl;
            sdb1.dataGridViewShowDB.Columns[8].Visible = false;
            sdb1.dataGridViewShowDB.Columns[7].Visible = false;
            sdb1.dataGridViewShowDB.Columns[6].Visible = false;
            sdb1.dataGridViewShowDB.Columns[5].Visible = false;
            sdb1.dataGridViewShowDB.Columns[9].Visible = false;
            sdb1.ShowDialog();
            //sdb1.dataGridViewShowDB.Rows.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mode = "enter";
            PassForm p = new PassForm(mode);
            p.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Master mas = new Master();
            mas.ShowDialog();
            ObjectList<hardware> _h_temp = new ObjectList<hardware>();
            foreach (hardware h in bl)
            {
                _h_temp.Add(h);
            }
            foreach (hardware h in bl)
            {
                if (mas._quest1.ContainsKey(h.TypeHardWare.ToString()))
                {
                    Expoints points = mas._quest1[h.TypeHardWare.ToString()];
                    if (points.cost == 5)
                    {
                        if (h.Point.cost < points.cost)
                        {
                            _h_temp.Remove(h);
                        }
                    }
                    if (points.cost == 4)
                    {
                        if (h.Point.cost > points.cost || h.Point.cost < 3)
                        {
                            _h_temp.Remove(h);
                        }
                    }
                    if (points.cost == 2)
                    { 
                        if(h.Point.cost > points.cost)
                        {
                            _h_temp.Remove(h);
                        }
                    }
                }
            }

            foreach (hardware h in bl)
            {
                if (mas._quest2.ContainsKey(h.TypeHardWare.ToString()))
                {
                    Expoints points = mas._quest2[h.TypeHardWare.ToString()];
                    if (h.Point.performance > points.performance || h.Point.safety > points.safety)
                        {
                            _h_temp.Remove(h);
                        }
                }
            }

            foreach (hardware h in bl)
            {
                if (mas._quest3.ContainsKey(h.TypeHardWare.ToString()))
                {
                    Expoints points = mas._quest3[h.TypeHardWare.ToString()];
                    if (points.performance == 4 && points.safety == 4)
                        {
                            if (h.Point.performance < points.performance || h.Point.safety < points.safety)
                            {
                                _h_temp.Remove(h);
                            }
                        }
                    if (points.performance == 3 && points.safety == 3)
                        {
                            if (h.Point.performance != points.performance || h.Point.safety != points.safety)
                            {
                                _h_temp.Remove(h);
                            }
                        }
                }
            }

            foreach (hardware h in bl)
            {
                if (mas._quest4.ContainsKey(h.TypeHardWare.ToString()))
                {
                    Expoints points = mas._quest4[h.TypeHardWare.ToString()];
                    if (points.performance == 5 && points.safety == 5)
                    {
                        if (h.Point.performance < points.performance || h.Point.safety < points.safety)
                        {
                            _h_temp.Remove(h);
                        }
                    }
                    if (points.performance == 4 && points.safety == 4)
                    {
                        if (h.Point.performance < points.performance || h.Point.safety < points.safety)
                        {
                            _h_temp.Remove(h);
                        }
                    }
                    if (points.performance == 3 && points.safety == 3)
                    {
                        if (h.Point.performance > points.performance || h.Point.safety > points.safety)
                        {
                            _h_temp.Remove(h);
                        }
                    }
                }
            }

            foreach (hardware h in bl)
            {
                if (mas._quest5.ContainsKey(h.TypeHardWare.ToString()))
                {
                    Expoints points = mas._quest5[h.TypeHardWare.ToString()];
                    if (h.Point.performance != points.performance || h.Point.safety != points.safety)
                    {
                        _h_temp.Remove(h);
                    }
                }

            }

            foreach (hardware h in bl)
            {
                if (mas._quest6.ContainsKey(h.TypeHardWare.ToString()))
                {
                    Expoints points = mas._quest6[h.TypeHardWare.ToString()];
                    if (h.Point.performance != points.performance || h.Point.safety != points.safety)
                    {
                        _h_temp.Remove(h);
                    }
                }
            }

            foreach (hardware h in bl)
            {
                if (mas._quest7.ContainsKey(h.TypeHardWare.ToString()))
                {
                    Expoints points = mas._quest7[h.TypeHardWare.ToString()];
                    if (h.Point.performance != points.performance || h.Point.safety != points.safety)
                    {
                        _h_temp.Remove(h);
                    }
                }
            }

            foreach (hardware h in bl)
            {
                if (mas._quest8.ContainsKey(h.TypeHardWare.ToString()))
                {
                    Expoints points = mas._quest8[h.TypeHardWare.ToString()];
                    if (h.Point.performance != points.performance || h.Point.safety != points.safety)
                    {
                        _h_temp.Remove(h);
                    }
                }
            }

            foreach (hardware h in bl)
            {
                if (h.TypeHardWare == "kolonki")
                {
                    if (!mas._quest8.ContainsKey("kolonki"))
                    {
                        _h_temp.Remove(h);
                    }
                }
                if (h.TypeHardWare == "Mouse")
                {
                    if (!mas._quest8.ContainsKey("Mouse"))
                    {
                        _h_temp.Remove(h);
                    }
                }
                if (h.TypeHardWare == "Webcam")
                {
                    if (!mas._quest8.ContainsKey("Webcam"))
                    {
                        _h_temp.Remove(h);
                    }
                }
                if (h.TypeHardWare == "Microphone")
                {
                    if (!mas._quest8.ContainsKey("Microphone"))
                    {
                        _h_temp.Remove(h);
                    }
                }
                if (h.TypeHardWare == "Keyboard")
                {
                    if (!mas._quest8.ContainsKey("Keyboard"))
                    {
                        _h_temp.Remove(h);
                    }
                }
                if (h.TypeHardWare == "Hearphone")
                {
                    if (!mas._quest8.ContainsKey("Hearphone"))
                    {
                        _h_temp.Remove(h);
                    }
                }
                if (h.TypeHardWare == "Printer")
                {
                    if (!mas._quest8.ContainsKey("Printer"))
                    {
                        _h_temp.Remove(h);
                    }
                }
                if (h.TypeHardWare == "TV")
                {
                    if (!mas._quest8.ContainsKey("TV"))
                    {
                        _h_temp.Remove(h);
                    }
                }
                if (h.TypeHardWare == "CDDVD")
                {
                    if (!mas._quest8.ContainsKey("CDDVD"))
                    {
                        _h_temp.Remove(h);
                    }
                }
                if (h.TypeHardWare == "Scaner")
                {
                    if (!mas._quest8.ContainsKey("Scaner"))
                    {
                        _h_temp.Remove(h);
                    }
                }
            }
            int energysum = 0;
            foreach (hardware h in _h_temp)
            {
                if (h.Point.Energy != 0 && h.TypeHardWare != "PowerBox")
                {
                    energysum = energysum + h.Point.Energy;
                }
            }
            foreach (hardware h in bl)
            {
                if (h.TypeHardWare == "PowerBox" && energysum < 25 && h.Point.Energy == 2)
                {
                    _h_temp.Remove(h);
                }

                if (h.TypeHardWare == "PowerBox" && energysum >= 25 && h.Point.Energy == 1)
                {
                    _h_temp.Remove(h);
                }
            }
            /*ObjectList<hardware> _h_temp1 = new ObjectList<hardware>();
            foreach (hardware h in _h_temp)
            {
                _h_temp1.Add(h);
            }
            
            foreach (hardware h in _h_temp)
            {
                if (h.TypeHardWare == "MotherBoard")
                {
                    mdep = h.Dependence;
                }
                if(h.TypeHardWare == "RAM" || h.TypeHardWare == "CPU")
                {
                    if(h.Dependence != mdep)
                        _h_temp1.Remove(h);
                }
            }*/
            if (mas.p == "ok")
            {
                /*ShowDB sdb = new ShowDB();
                sdb.dataGridViewShowDB.DataSource = _h_temp;
                sdb.ShowDialog();
                sdb.dataGridViewShowDB.Rows.Clear();*/
                Result res = new Result();
                int summ = 0;
                foreach (hardware h in _h_temp)
                {
                    if (h.TypeHardWare == "RAM")
                        res.textBoxRam.Text = h.CompanyName.ToString() + " " + h.ModelName.ToString();
                    if (h.TypeHardWare == "Monitor")
                        res.textBoxMonit.Text = h.CompanyName.ToString() + " " + h.ModelName.ToString();
                    if (h.TypeHardWare == "Microphone")
                        res.textBoxMic.Text = h.CompanyName.ToString() + " " + h.ModelName.ToString();
                    if (h.TypeHardWare == "PowerBox")
                        res.textBoxPB.Text = h.CompanyName.ToString() + " " + h.ModelName.ToString();
                    if (h.TypeHardWare == "Scaner")
                        res.textBoxScan.Text = h.CompanyName.ToString() + " " + h.ModelName.ToString();
                    if (h.TypeHardWare == "Webcam")
                        res.textBoxWeb.Text = h.CompanyName.ToString() + " " + h.ModelName.ToString();
                    if (h.TypeHardWare == "CPU")
                        res.textBoxCPU.Text = h.CompanyName.ToString() + " " + h.ModelName.ToString();
                    if (h.TypeHardWare == "VideoCard")
                        res.textBoxVideo.Text = h.CompanyName.ToString() + " " + h.ModelName.ToString();
                    if (h.TypeHardWare == "Audio")
                        res.textBoxAudio.Text = h.CompanyName.ToString() + " " + h.ModelName.ToString();
                    if (h.TypeHardWare == "HDD")
                        res.textBoxHDD.Text = h.CompanyName.ToString() + " " + h.ModelName.ToString();
                    if (h.TypeHardWare == "MotherBoard")
                        res.textBoxMB.Text = h.CompanyName.ToString() + " " + h.ModelName.ToString();
                    if (h.TypeHardWare == "Box")
                        res.textBoxBox.Text = h.CompanyName.ToString() + " " + h.ModelName.ToString();
                    if (h.TypeHardWare == "Printer")
                        res.textBoxPrint.Text = h.CompanyName.ToString() + " " + h.ModelName.ToString();
                    if (h.TypeHardWare == "kolonki")
                        res.textBoxKol.Text = h.CompanyName.ToString() + " " + h.ModelName.ToString();
                    if (h.TypeHardWare == "Mouse")
                        res.textBoxMouse.Text = h.CompanyName.ToString() + " " + h.ModelName.ToString();
                    if (h.TypeHardWare == "Hearphone")
                        res.textBoxHear.Text = h.CompanyName.ToString() + " " + h.ModelName.ToString();
                    if (h.TypeHardWare == "Keyboard")
                        res.textBoxKey.Text = h.CompanyName.ToString() + " " + h.ModelName.ToString();
                    if (h.TypeHardWare == "TV")
                        res.textBoxTV.Text = h.CompanyName.ToString() + " " + h.ModelName.ToString();
                    if (h.TypeHardWare == "CDDVD")
                        res.textBoxCDDVD.Text = h.CompanyName.ToString() + " " + h.ModelName.ToString();
                    summ = summ + h.Cost;
                }
                res.textBoxSumm.Text = summ.ToString();
                res.ShowDialog();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Search sf = new Search();
            sf.ShowDialog();
            ObjectList<hardware> _h_temp = new ObjectList<hardware>();
            foreach (hardware h in bl)
            {
                _h_temp.Add(h);
            }
            foreach (hardware h in bl)
            {
                if (h.TypeHardWare != sf.th && h.CompanyName != sf.cn)
                {
                    _h_temp.Remove(h);
                }
            }
            if (sf.p == "ok")
            {
                ShowDB sdb = new ShowDB();
                sdb.dataGridViewShowDB.DataSource = _h_temp;
                sdb.ShowDialog();
                sdb.dataGridViewShowDB.Rows.Clear();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
namespace lab2
{
    public partial class Form1 : Form
    {

        ObjectList<MCards> bl = new ObjectList<MCards>();//создание объекта класса 
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;//Автоформат ячеек
            dataGridView1.DataSource = bl;//Указание в качестве источника данных объект b1

        }

        private void addARowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bl.Add(new MCards("", "", "", "", 0,0,0,0,0));
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                bl.RemoveAt(dataGridView1.SelectedCells[0].RowIndex);
            }

        }

        private void saveDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "XML files (*.xml)|*.xml";
            saveFileDialog1.ShowDialog();
        }

        private void loadDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "XML files (*.xml)|*.xml";
            openFileDialog1.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            XDocument xdoc = new XDocument(new XElement("objects"));
            foreach (MCards p in bl)
            {
                xdoc.Root.Add(p.ToXml());
            }
            xdoc.Save(saveFileDialog1.FileName);

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            XDocument xdoc = XDocument.Load(openFileDialog1.FileName);
            foreach (XElement xelem in xdoc.Root.Descendants("MCards"))
            {
                bl.Add(MCards.FromXml(xelem));
            }

        }

        private void masterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void questionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 _master_form = new Form2();
            _master_form.ShowDialog();
        
            MasterAnswers answers = _master_form.Answers;
            ObjectList<MCards> _p_temp = new ObjectList<MCards>();
            foreach (MCards p in bl)
            {
                _p_temp.Add(p);
            }
            foreach (MCards p in bl)
            {
                if (_p_temp.Contains(p))
                {
                    if (p.Socket == "Socket370" && !answers._sock.Contains(0))
                        _p_temp.Remove(p);
                    else if (p.Socket == "Socket478" && !answers._sock.Contains(1))
                        _p_temp.Remove(p);
                    else if (p.Socket == "Socket754" && !answers._sock.Contains(2))
                        _p_temp.Remove(p);
                    else if (p.Socket == "Socket775" && !answers._sock.Contains(3))
                        _p_temp.Remove(p);
                    else if (p.Socket == "Socket940" && !answers._sock.Contains(4))
                        _p_temp.Remove(p);
                    else if (p.Socket == "SocketAM2" && !answers._sock.Contains(5))
                        _p_temp.Remove(p);
                }
            }
            foreach (MCards p in bl)
            {
                if (_p_temp.Contains(p))
                {
                    if (p.Graph == "Нет" && !answers._graph.Contains(0))
                        _p_temp.Remove(p);
                    else if (p.Graph == "Да" && !answers._graph.Contains(1))
                        _p_temp.Remove(p);
                }
            }
            foreach (MCards p in bl)
            {
                if (_p_temp.Contains(p))
                {
                    if (p.GraphPU == 1 && !answers._graphpu.Contains(0))
                        _p_temp.Remove(p);
                    else if (p.GraphPU == 2 && !answers._graphpu.Contains(1))
                        _p_temp.Remove(p);
                }
            }
            foreach (MCards p in bl)
            {
                if (_p_temp.Contains(p))
                {
                    if ((p.Amount_of_PCI < 3) && !answers._pci.Contains(0))
                        _p_temp.Remove(p);
                    else if ((p.Amount_of_PCI == 3) && !answers._pci.Contains(1))
                        _p_temp.Remove(p);
                    else if ((p.Amount_of_PCI > 3) && !answers._pci.Contains(2))
                        _p_temp.Remove(p);
                }
            }
            foreach (MCards p in bl)
            {
                if (_p_temp.Contains(p))
                {
                    if (p.Amount_of_DDR_DIMM == 2 && !answers._ddr.Contains(0))
                        _p_temp.Remove(p);
                    else if (p.Amount_of_DDR_DIMM == 4 && !answers._ddr.Contains(1))
                        _p_temp.Remove(p);
                }
            }
            foreach (MCards p in bl)
            {
                if (_p_temp.Contains(p))
                {
                    if (p.Amount_of_SATA_channels == 0 && !answers._sata.Contains(0))
                        _p_temp.Remove(p);
                    else if (p.Amount_of_SATA_channels == 4 && !answers._sata.Contains(2))
                        _p_temp.Remove(p);
                }
            }
            foreach (MCards p in bl)
            {
                if (_p_temp.Contains(p))
                {
                    if ((p.Price <= 3000) && !answers._price.Contains(0))
                        _p_temp.Remove(p);
                    else if ((p.Price > 3000 && p.Price <= 5000) && !answers._price.Contains(1))
                        _p_temp.Remove(p);
                    else if ((p.Price > 5000) && !answers._price.Contains(2))
                        _p_temp.Remove(p);
                }
            }
            int maxp=100000;
            foreach (MCards p in bl)
            {
                if (_p_temp.Contains(p))
                {
                    if (p.Price < maxp)
                    {
                        maxp = p.Price;
                    }
                }
            }
            foreach (MCards p in bl)
            {
                if (_p_temp.Contains(p))
                {
                    if (p.Price != maxp)
                    {
                        _p_temp.Remove(p);
                    }
                }
            }
            dataGridView1.DataSource = _p_temp;
            
        }

        private void revertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bl;
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.ShowDialog();
            Dictionary<string, object> dict = sf.SearchDictionary;

            ObjectList<MCards> _filtered_mcards = new ObjectList<MCards>();
            _filtered_mcards.AllowNew = false;
            foreach (MCards p in bl)
            {
                if (p.CheckFilter(dict))
                {
                    _filtered_mcards.Add(p);
                }
            }
            dataGridView1.DataSource = _filtered_mcards;

        }

        private void byNameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}

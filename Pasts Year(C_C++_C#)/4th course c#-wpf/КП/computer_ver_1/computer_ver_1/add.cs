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
    public partial class add : Form
    {
        ObjectList<hardware> bl = new ObjectList<hardware>();
        public string mode;
        
        public add()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
            //dataGridView1.AutoSize = true;
            dataGridView1.DataSource = bl;
        }

        public string Mode
        {
            get { return mode; }
            set { mode = value; }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (comboBoxDep.SelectedItem == null || comboBoxType.SelectedItem == null || String.IsNullOrEmpty(textBoxCN.Text) || String.IsNullOrEmpty(textBoxMN.Text) 
                || String.IsNullOrEmpty(textBoxD.Text) || String.IsNullOrEmpty(textBoxC.Text) || String.IsNullOrEmpty(textBoxPerf.Text) 
                || String.IsNullOrEmpty(textBoxEner.Text) || String.IsNullOrEmpty(textBoxCost.Text) || String.IsNullOrEmpty(textBoxSaf.Text))
            {
                MessageBox.Show("Не все поля заполнены !!!");
            }
            else
            {
                bl.Add(new hardware(comboBoxType.SelectedItem.ToString(), textBoxCN.Text, textBoxMN.Text, textBoxD.Text,
                    Convert.ToInt32(textBoxC.Text), comboBoxDep.SelectedItem.ToString(), Convert.ToInt32(textBoxPerf.Text), 
                    Convert.ToInt32(textBoxEner.Text), Convert.ToInt32(textBoxCost.Text), Convert.ToInt32(textBoxSaf.Text)));
                comboBoxType.SelectedItem = null;
                comboBoxPoint.SelectedItem = null;
                comboBoxDep.SelectedItem = null;
                textBoxCN.Text = null;
                textBoxMN.Text = null;
                textBoxD.Text = null;
                textBoxC.Text = null;
                textBoxPerf.Text = null;
                textBoxEner.Text = null;
                textBoxCost.Text = null;
                textBoxSaf.Text = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                bl.RemoveAt(dataGridView1.SelectedCells[0].RowIndex);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialogA.Filter = "XML files (*.xml)|*.xml";
            openFileDialogA.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialogA.Filter = "XML files (*.xml)|*.xml";
            saveFileDialogA.ShowDialog();
        }

        private void saveFileDialogA_FileOk(object sender, CancelEventArgs e)
        {
            XDocument xdoc = new XDocument(new XElement("objects"));
            foreach (hardware p in bl)
            {
                xdoc.Root.Add(p.ToXml());
            }
            xdoc.Save(saveFileDialogA.FileName);
        }

        private void openFileDialogA_FileOk(object sender, CancelEventArgs e)
        {
            dataGridView1.Rows.Clear();
            XDocument xdoc = XDocument.Load(openFileDialogA.FileName);
            //XDocument xdoc = XDocument.Load("D:\Учеба\prim.xml");
            foreach (XElement xelem in xdoc.Root.Descendants("hardware"))
            {
                bl.Add(hardware.FromXml(xelem));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void comboBoxPoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            //цена
            if (comboBoxPoint.SelectedItem == "цена")
            {
                textBoxCost.Visible = true;
                textBoxCost.Focus();
            }
            else
            {
                textBoxCost.Visible = false;
            }
            //производительность
            if (comboBoxPoint.SelectedItem == "производительность")
            {
                textBoxPerf.Visible = true;
                textBoxPerf.Focus();
            }
            else
            {
                textBoxPerf.Visible = false;
            }
            //эргономичноcть
            if (comboBoxPoint.SelectedItem == "энергопотребление")
            {
                textBoxEner.Visible = true;
                textBoxEner.Focus();
            }
            else
            {
                textBoxEner.Visible = false;
            }
            //надежность
            if (comboBoxPoint.SelectedItem == "надежность")
            {
                textBoxSaf.Visible = true;
                textBoxSaf.Focus();
            }
            else
            {
                textBoxSaf.Visible = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = "change";
            PassForm pf = new PassForm(mode);
            pf.Show();
        }
    }
}

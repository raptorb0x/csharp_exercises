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

        BindingList<Person> bl = new BindingList<Person>();//создание объекта класса Person
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;//Автоформат ячеек
            dataGridView1.DataSource = bl;//Указание в качестве источника данных объект b1

        }

        private void addARowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bl.Add(new Person("", "", "", "13.12.1980", "MSBU"));
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
            foreach (Person p in bl)
            {
                xdoc.Root.Add(p.ToXml());
            }
            xdoc.Save(saveFileDialog1.FileName);

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            XDocument xdoc = XDocument.Load(openFileDialog1.FileName);
            foreach (XElement xelem in xdoc.Root.Descendants("person"))
            {
                bl.Add(Person.FromXml(xelem));
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

            BindingList<Person> _p_temp = new BindingList<Person>();
            foreach (Person p in bl)
            {
                _p_temp.Add(p);
            }

            foreach (Person p in bl)
            {
                if ((answers._gender == 0 && p.Gender == "Female") || (answers._gender == 1 && p.Gender == "Male"))
                    _p_temp.Remove(p);
            }

            DateTime today = DateTime.Now;
            foreach (Person p in bl)
            {
                if (_p_temp.Contains(p))
                {
                    DateTime dt = Convert.ToDateTime(p.DateOfBirth);
                    int years = (today - dt).Days / 365;
                    if (years >= 20 && years < 30 && !answers._age_groups.Contains(0))
                        _p_temp.Remove(p);
                    else if (years >= 30 && years < 40 && !answers._age_groups.Contains(1))
                        _p_temp.Remove(p);
                    else if (years >= 40 && years < 50 && !answers._age_groups.Contains(2))
                        _p_temp.Remove(p);
                    else if (years >= 50 && !answers._age_groups.Contains(3))
                        _p_temp.Remove(p);
                }
            }

          /*  foreach (Person p in bl)
            {
                if (_p_temp.Contains(p))
                {
                    if ((answers._need_company_name == 0 && p.CompanyName == "") || (answers._need_company_name == 1 && p.CompanyName != ""))
                        _p_temp.Remove(p);
                }
            }*/

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

            BindingList<Person> _filtered_person = new BindingList<Person>();
            _filtered_person.AllowNew = false;
            foreach (Person p in bl)
            {
                if (p.CheckFilter(dict))
                {
                    _filtered_person.Add(p);
                }
            }
            dataGridView1.DataSource = _filtered_person;

        }

    }
}

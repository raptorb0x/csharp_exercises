using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab2
{
    
    public partial class SearchForm : Form
    {
        private Dictionary<string, object> _dict = new Dictionary<string, object>();
        public Dictionary<string, object> SearchDictionary
        {
            get { return _dict; }
        }
        public SearchForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                _dict.Add("Name", textBox1.Text);
            if (textBox2.Text.Length > 0)
                _dict.Add("Surname", textBox2.Text);
            if (comboBox1.Text.Length > 0)
                _dict.Add("Gender", comboBox1.Text);
            if (textBox3.Text.Length > 0)
                _dict.Add("DateOfBirth", textBox3.Text);
            if (textBox4.Text.Length > 0)
                _dict.Add("CompanyName", textBox4.Text);

            Close();

        }



    }
}

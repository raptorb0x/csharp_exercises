using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DezTEPWork.Forms.SPRWork
{
    public partial class SPRsnipUP : Form
    {
        public SPRsnipUP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.queriesTableAdapter1.SPRWORKS(Convert.ToDecimal(textBox1.Text), textBox2.Text, textBox3.Text,
                Convert.ToDecimal(textBox4.Text), textBox5.Text);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

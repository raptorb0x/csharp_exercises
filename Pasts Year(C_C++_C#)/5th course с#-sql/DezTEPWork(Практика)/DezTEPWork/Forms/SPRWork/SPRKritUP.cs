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
    public partial class SPRKritUP : Form
    {
        public SPRKritUP()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.queriesTableAdapter1.SPRCRITUP(Convert.ToDecimal(textBox1.Text), textBox2.Text,
                Convert.ToDecimal(textBox3.Text), Convert.ToDecimal(textBox4.Text));
            this.Close();
        }
    }
}

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
    public partial class SPRFondUP : Form
    {
        public SPRFondUP()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.queriesTableAdapter1.SPRFONDUP(
                  Convert.ToDecimal(textBox1.Text),
                  textBox3.Text,
                  Convert.ToDecimal(textBox4.Text),
                  textBox5.Text,
                  textBox6.Text,
                  textBox7.Text,
                  Convert.ToDecimal(textBox8.Text),
                  Convert.ToDecimal(textBox9.Text),
                  Convert.ToDecimal(textBox10.Text),
                  Convert.ToDecimal(textBox11.Text),
                  Convert.ToDecimal(textBox12.Text),
                  Convert.ToDecimal(textBox13.Text)
                  );
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

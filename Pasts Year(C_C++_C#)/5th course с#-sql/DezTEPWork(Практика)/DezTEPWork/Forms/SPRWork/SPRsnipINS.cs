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
    public partial class SPRsnipINS : Form
    {
        public SPRsnipINS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.spR_WORKSTableAdapter1.INSERT(Convert.ToInt32(textBox1.Text), textBox2.Text,
                textBox3.Text, Convert.ToDecimal(textBox4.Text), textBox5.Text);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

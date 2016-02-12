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
    public partial class SPRrpDEL : Form
    {
        public SPRrpDEL()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.queriesTableAdapter1.SPRPOSLEDDEL(Convert.ToDecimal(textBox1.Text));
            this.Close();
        }
    }
}

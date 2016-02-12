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
    public partial class SPRsnipDEL : Form
    {
        public SPRsnipDEL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.queriesTableAdapter1.SPRWORKSDEL(Convert.ToDecimal(textBox1.Text));
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

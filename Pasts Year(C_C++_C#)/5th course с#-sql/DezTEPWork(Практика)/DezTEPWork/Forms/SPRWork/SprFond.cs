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
    public partial class SprFond : Form
    {
        public SprFond()
        {
            InitializeComponent();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.spR_FONDTableAdapter1.SPRINS(Convert.ToInt32(textBox1.Text),
                textBox3.Text,
                Convert.ToInt32(textBox4.Text),
                textBox5.Text,
                textBox6.Text,
                textBox7.Text,
                Convert.ToInt32(textBox14.Text),
                Convert.ToInt32(textBox13.Text),
                Convert.ToInt32(textBox12.Text),
                Convert.ToInt32(textBox11.Text),
                Convert.ToInt32(textBox10.Text),
                Convert.ToInt32(textBox9.Text));

            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SprFond_Load(object sender, EventArgs e)
        {
            this.spR_FONDTableAdapter1.Fill(this.diplomOC.SPR_FOND);
        }

       

       
    }
}

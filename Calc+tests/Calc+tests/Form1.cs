using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_tests
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }

        private void Digital_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 9)
            {

                var temp = Double.Parse(textBox1.Text) * ((!textBox1.Text.Contains(","))?10:1) + 
                    Double.Parse(sender.ToString().Last().ToString()) * ((!textBox1.Text.Contains(",")) ? 1 : textBox1.Text.);
                textBox1.Text = temp.ToString();
            }
            else
            {
                toolTip1.Show("Число слишком большое", textBox1, 1000);
            }
        }

        private void bBack_Click(object sender, EventArgs e)
        {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                if (textBox1.Text.Length == 0)
                    textBox1.Text = "0";
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void bDiv_Click(object sender, EventArgs e)
        {
            if(!textBox1.Text.Contains(","))
            textBox1.Text += ",";
            
        }
    }
}

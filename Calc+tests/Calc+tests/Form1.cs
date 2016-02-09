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

        private string Calcul = "0";

        public Form1()
        {
            InitializeComponent();
        }

        private string Calc
        {
            get
            { return Calcul; }
            set
            { Calcul = value; TextBoxRefresh(); }
        }

        private void TextBoxRefresh()
        {
            textBox1.Text = this.Calc;
        }

        public void Digital_Click(object sender, EventArgs e)
        {
            if (this.Calc.Length < 9)
            {
                if (this.Calc != "0" || sender.ToString().Last().ToString() != "0")
                {
                    if (this.Calc == "0") this.Calc = "";
                    this.Calc += sender.ToString().Last().ToString();
                }
            }
            else
            {
                toolTip1.Show("Число слишком длинное", textBox1, 1000);
            }
        }

        private void bBack_Click(object sender, EventArgs e)
        {
                this.Calc = this.Calc.Remove(this.Calc.Length - 1, 1);
                if (this.Calc.Length == 0)
                this.Calc = "0";
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            this.Calc = "0";
        }

        private void bDiv_Click(object sender, EventArgs e)
        {
            if(!this.Calc.Contains(","))
                this.Calc += ",";
        }
    }
}

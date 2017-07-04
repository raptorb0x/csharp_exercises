using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUtil
{
    public partial class MainForm : Form
    {

        int count = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void TSMI_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TSMI_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа мои утилиты содержит ряд небольших программ, которые могут пригодиться в жизни. И научить основам программирования на С#.\nАвтор Шишин И.О.","О программе");
        }

        private void B_reset_Click(object sender, EventArgs e)
        {
            count = 0;
            L_Count.Text = count.ToString();
        }

        private void B_plus_Click(object sender, EventArgs e)
        {
            count++;
            L_Count.Text = count.ToString();
        }

        private void B_minus_Click(object sender, EventArgs e)
        {
            count--;
            L_Count.Text = count.ToString();
        }
    }
}

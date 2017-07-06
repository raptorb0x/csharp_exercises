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

        private int count = 0; 
        private Random rnd = new Random();
        private int Score = 0;

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

        private void B_Generate_Click(object sender, EventArgs e)
        {
            if (NUD_From.Value <= NUD_To.Value)
                L_Gen_Result.Text = rnd.Next(Convert.ToInt32(NUD_From.Value), Convert.ToInt32(NUD_To.Value) + 1).ToString();
            else
                L_Gen_Result.Text = "Проверьте\nдиапазоны";
        }

        private void B_one_Click(object sender, EventArgs e)
        {
            B_Two.Visible = true;
            B_one.Visible = false;
            Score++;
            L_Score.Text = Score.ToString();
        }

        private void B_Two_Click(object sender, EventArgs e)
        {
            B_Two.Visible = false;
            B_one.Visible = true;
            Score++;
            L_Score.Text = Score.ToString();
        }
    }
}

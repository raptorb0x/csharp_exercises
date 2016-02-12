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
    public partial class SPRrpUP : Form
    {
        public SPRrpUP()
        {
            InitializeComponent();

            WORK = orawork.Load("SELECT NAMEWORK FROM SPR_WORKS");



            foreach (DataRow row in WORK.Rows)
                comboBox1.Items.Add(row[0]);
        }

        FolderBase.OracleWork orawork = new FolderBase.OracleWork();
        DataTable WORK;

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable WR;

            string Wrok = "";


            WR = orawork.Load("SELECT CODEWORK FROM SPR_WORKS WHERE NAMEWORK='" + comboBox1.SelectedItem.ToString() + "'");


            foreach (DataRow row in WR.Rows)
                Wrok = row[0].ToString();

            this.queriesTableAdapter1.SPRPOSLEDUP(Convert.ToDecimal(textBox1.Text), Convert.ToDecimal(Wrok), Convert.ToDecimal(textBox3.Text));
            
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

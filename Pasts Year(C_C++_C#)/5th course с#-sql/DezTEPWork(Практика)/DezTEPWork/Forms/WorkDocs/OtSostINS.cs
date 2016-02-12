using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DezTEPWork.Forms.WorkDocs
{
    public partial class OtSostINS : Form
    {
        public OtSostINS()
        {
            InitializeComponent();
            JIL = orawork.Load("SELECT FIO FROM SPR_FONDKV");

            foreach (DataRow row in JIL.Rows)
                comboBox1.Items.Add(row[0]);
        }

        FolderBase.OracleWork orawork = new FolderBase.OracleWork();
        DataTable JIL;

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable WR;

            string Wrok = "";


            WR = orawork.Load("SELECT CODEJIL FROM SPR_FONDKV WHERE FIO='" + comboBox1.SelectedItem.ToString() + "'");


            foreach (DataRow row in WR.Rows)
                Wrok = row[0].ToString();
           
            this.oT_SOSTTableAdapter1.INSERT(Convert.ToDecimal(textBox1.Text), Convert.ToDecimal(Wrok), textBox7.Text, Convert.ToDecimal(textBox8.Text));
            
            //oT_SOSTTableAdapter1.OTSOSTINS(
            //    Convert.ToDecimal(textBox1.Text),
            //    textBox2.Text,
            //    textBox3.Text,
            //    textBox4.Text,
            //    textBox5.Text,
            //    textBox6.Text,
            //    textBox7.Text,
            //    Convert.ToDecimal(textBox8.Text),
            //    textBox9.Text);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}

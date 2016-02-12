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
    public partial class JrRemmsINS : Form
    {
        public JrRemmsINS()
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

            this.jR_REMMSTableAdapter1.INSERT(Convert.ToDecimal(textBox1.Text), Convert.ToDecimal(Wrok), textBox7.Text);
            



            //jR_REMMSTableAdapter1.JRREMMSINS(
            //    Convert.ToDecimal(textBox1.Text),
            //    textBox2.Text,
            //    textBox3.Text,
            //    textBox4.Text,
            //    textBox5.Text,
            //    Convert.ToDecimal(textBox6.Text),
            //    textBox7.Text,
            //    textBox8.Text,
            //    Convert.ToDecimal(textBox9.Text));

            
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

     
       
        

       

        


        
       
    }
}

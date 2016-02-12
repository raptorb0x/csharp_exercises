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
    public partial class JrRemmsUP : Form
    {
        public JrRemmsUP()
        {
            InitializeComponent();
            
            JIL = orawork.Load("SELECT FIO FROM SPR_FONDKV");

            foreach (DataRow row in JIL.Rows)
                comboBox2.Items.Add(row[0]);
        }

        FolderBase.OracleWork orawork = new FolderBase.OracleWork();
        DataTable JIL;

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable WR;

            string Wrok = "";


            WR = orawork.Load("SELECT CODEJIL FROM SPR_FONDKV WHERE FIO='" + comboBox2.SelectedItem.ToString() + "'");


            foreach (DataRow row in WR.Rows)
                Wrok = row[0].ToString();

            
            this.queriesTableAdapter1.JRREMMSUP(Convert.ToDecimal(comboBox1.SelectedItem.ToString()), Convert.ToDecimal(Wrok), textBox8.Text);
            
            
            //this.jR_REMMSTableAdapter1.JRREMUP(
            //    Convert.ToDecimal(comboBox1.SelectedItem.ToString()),
            //     textBox2.Text,
            //     textBox3.Text,
            //     textBox4.Text,
            //     textBox5.Text,
            //     Convert.ToDecimal(textBox6.Text),
            //     textBox7.Text,
            //     textBox8.Text,
            //     Convert.ToDecimal(textBox9.Text));
           
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void JrRemmsUP_Load(object sender, EventArgs e)
        {
            this.jR_REMMSTableAdapter1.Fill(this.diplomOC1.JR_REMMS);

            foreach (FolderBase.DiplomOC.JR_REMMSRow _row in this.diplomOC1.JR_REMMS.Rows)
                comboBox1.Items.Add(_row.ID.ToString());
        }
    }
}

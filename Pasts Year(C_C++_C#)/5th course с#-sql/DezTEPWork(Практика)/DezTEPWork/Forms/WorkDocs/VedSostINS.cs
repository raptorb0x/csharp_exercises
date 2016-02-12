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
    public partial class VedSostINS : Form
    {
        public VedSostINS()
        {
              
            InitializeComponent();
            WORK = orawork.Load("SELECT ADRESS FROM SPR_FOND");

            foreach (DataRow row in WORK.Rows)
                comboBox1.Items.Add(row[0]);
             
        }

        FolderBase.OracleWork orawork = new FolderBase.OracleWork();
        DataTable WORK;

       // private string _connect = "DATA SOURCE=;PASSWORD=12345;USER ID=DON";

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable WR;

            string Wrok = "";


            WR = orawork.Load("SELECT CODEHOUSE FROM SPR_FOND WHERE ADRESS='" + comboBox1.SelectedItem.ToString() + "'");


            foreach (DataRow row in WR.Rows)
                Wrok = row[0].ToString();


            veD_SOSTTableAdapter1.INSERT(
                Convert.ToDecimal(textBox1.Text),
                Convert.ToDecimal(Wrok),
                Convert.ToDecimal(OtextBox1.Text),
                Convert.ToDecimal(OtextBox2.Text),
                Convert.ToDecimal(OtextBox3.Text),
                Convert.ToDecimal(OtextBox4.Text),
                Convert.ToDecimal(OtextBox5.Text),
                Convert.ToDecimal(OtextBox6.Text),
                Convert.ToDecimal(OtextBox7.Text));

             this.Close();
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VedSostINS_Load(object sender, EventArgs e)
        {
            //this.spR_FONDTableAdapter1.Fill(this.diplomOC1.SPR_FOND);

            //foreach (FolderBase.DiplomOC.SPR_FONDRow _row in this.diplomOC1.SPR_FOND.Rows)
            //{
            //    this.comboBox1.Items.Add(Convert.ToString(_row.STREETHOUSE));
            //} 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //foreach (FolderBase.DiplomOC.SPR_FONDRow _row in this.diplomOC1.SPR_FOND.Rows)
            //{
            //    if(this.comboBox1.SelectedItem.ToString() == _row.STREETHOUSE.ToString())
            //      this.comboBox2.Items.Add(Convert.ToString(_row.NUMBERHOUSE));
            //}
            textBox1.Enabled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //foreach (FolderBase.DiplomOC.SPR_FONDRow _row in this.diplomOC1.SPR_FOND.Rows)
            //{ 
            //    if( this.comboBox1.SelectedItem.ToString() == _row.STREETHOUSE.ToString())
            //        if (this.comboBox2.SelectedItem.ToString() == _row.NUMBERHOUSE.ToString())
            //        {
            //            textBox2.Text = _row.TYPEHOUSE.ToString();
            //            textBox3.Text = _row.NUMBERROOMS.ToString();
            //            textBox4.Text = _row.YEARBUILD.ToString();
                          
                        
            //             groupBox1.Enabled = true;
            //             textBox1.Enabled = true;
            //        }
            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        

     

        

      

        

       

        
    }
}

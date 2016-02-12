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
    public partial class PlYearINS : Form
    {
        public PlYearINS()
        {
            InitializeComponent();
            WORK = orawork.Load("SELECT ADRESS FROM SPR_FOND");



            foreach (DataRow row in WORK.Rows)
                comboBox1.Items.Add(row[0]);
        }

        FolderBase.OracleWork orawork = new FolderBase.OracleWork();
        DataTable WORK;



        private void button1_Click(object sender, EventArgs e)
        {
            DataTable WR;

            string Wrok = "";


            WR = orawork.Load("SELECT CODEHOUSE FROM SPR_FOND WHERE ADRESS='" + comboBox1.SelectedItem.ToString() + "'");


            foreach (DataRow row in WR.Rows)
                Wrok = row[0].ToString();

            this.pL_REMYEARTableAdapter1.INSERT(
                Convert.ToDecimal(textBox1.Text),
                Convert.ToDecimal(Wrok),                
                Convert.ToDecimal(textBox6.Text)
                );
                        
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

       
    }
}

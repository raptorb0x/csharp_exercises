using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace DezTEPWork.Forms.SPRWork
{
    public partial class SPRremproINS : Form
    {
        public SPRremproINS()
        {
            InitializeComponent();
            
            this.spR_FONDTableAdapter1.Fill(this.diplomOC1.SPR_FOND);
            this.spR_CRITTableAdapter1.Fill(this.diplomOC1.SPR_CRIT);
            //FolderBase.OracleWork orawork = new FolderBase.OracleWork();
            foreach (FolderBase.DiplomOC.SPR_FONDRow row in this.diplomOC1.SPR_FOND.Rows)
                comboBox1.Items.Add(row.ADRESS);

            foreach (FolderBase.DiplomOC.SPR_CRITRow row in this.diplomOC1.SPR_CRIT.Rows)
                comboBox2.Items.Add(row.TYPEREM);
        }

        FolderBase.OracleWork orawork = new FolderBase.OracleWork();
        
        private void button1_Click(object sender, EventArgs e)
        {

            DataTable HO;
            DataTable KR;
            string HOM="";
            string KRi="";

            HO = orawork.Load("SELECT CODEHOUSE FROM SPR_FOND WHERE ADRESS='" + comboBox1.SelectedItem.ToString() + "'");
            KR = orawork.Load("SELECT ID FROM SPR_CRIT WHERE TYPEREM='"+comboBox2.SelectedItem.ToString()+"'");

            foreach (DataRow row in HO.Rows)
                HOM = row[0].ToString();
            
            foreach (DataRow row in KR.Rows)
                KRi = row[0].ToString();
            
            this.spR_PRORABTableAdapter1.INSERT(Convert.ToDecimal(textBox1.Text),
                Convert.ToDecimal(HOM),
                Convert.ToDecimal(KRi),
                Convert.ToDecimal(textBox4.Text));
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SPRremproINS_Load(object sender, EventArgs e)
        {
            

            
        }
    }
}

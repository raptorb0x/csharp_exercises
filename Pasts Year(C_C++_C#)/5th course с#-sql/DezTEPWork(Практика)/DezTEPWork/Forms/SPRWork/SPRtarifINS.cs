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
    public partial class SPRtarifINS : Form
    {
        public SPRtarifINS()
        {
            InitializeComponent();

            WORK = orawork.Load("SELECT NAMEWORK FROM SPR_WORKS");
            CRIT = orawork.Load("SELECT TYPEREM FROM SPR_CRIT");

            foreach (DataRow row in WORK.Rows)
                comboBox1.Items.Add(row[0]);
            foreach (DataRow row in CRIT.Rows)
                comboBox2.Items.Add(row[0]);

        }
        
        FolderBase.OracleWork orawork = new FolderBase.OracleWork();
        DataTable WORK;
        DataTable CRIT;

        

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable HO;
            DataTable KR;
            string HOM = "";
            string KRi = "";

            HO = orawork.Load("SELECT CODEWORK FROM SPR_WORKS WHERE NAMEWORK='" + comboBox1.SelectedItem.ToString() + "'");
            KR = orawork.Load("SELECT ID FROM SPR_CRIT WHERE TYPEREM='" + comboBox2.SelectedItem.ToString() + "'");

            foreach (DataRow row in HO.Rows)
                HOM = row[0].ToString();

            foreach (DataRow row in KR.Rows)
                KRi = row[0].ToString();

            this.spR_TARIFTableAdapter1.INSERT(Convert.ToDecimal(textBox1.Text),
               Convert.ToDecimal(HOM), Convert.ToDecimal(KRi), Convert.ToDecimal(textBox4.Text));

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

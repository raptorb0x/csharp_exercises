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
    public partial class SPRorINS : Form
    {
        public SPRorINS()
        {
            InitializeComponent();


            WORK = orawork.Load("SELECT NAMEWORK FROM SPR_WORKS");
            CRIT = orawork.Load("SELECT TYPEREM FROM SPR_CRIT");
            HOME = orawork.Load("SELECT ADRESS FROM SPR_FOND");

            foreach (DataRow row in HOME.Rows)
                comboBox1.Items.Add(row[0]);
            foreach (DataRow row in WORK.Rows)
                comboBox2.Items.Add(row[0]);
            foreach (DataRow row in CRIT.Rows)
                comboBox3.Items.Add(row[0]);
        }

        FolderBase.OracleWork orawork = new FolderBase.OracleWork();

        DataTable WORK;
        DataTable CRIT;
        DataTable HOME;

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable HO;
            DataTable KR;
            DataTable WR;
            string HOM = "";
            string KRi = "";
            string Wrok = "";

            HO = orawork.Load("SELECT CODEHOUSE FROM SPR_FOND WHERE ADRESS='" + comboBox1.SelectedItem.ToString() + "'");
            KR = orawork.Load("SELECT ID FROM SPR_CRIT WHERE TYPEREM='" + comboBox3.SelectedItem.ToString() + "'");
            WR = orawork.Load("SELECT CODEWORK FROM SPR_WORKS WHERE NAMEWORK='" + comboBox2.SelectedItem.ToString() + "'");

            foreach (DataRow row in HO.Rows)
                HOM = row[0].ToString();

            foreach (DataRow row in KR.Rows)
                KRi = row[0].ToString();
            foreach (DataRow row in WR.Rows)
                Wrok = row[0].ToString();


            orawork.ExecuteQuery("INSERT INTO SPR_ORAB VALUES("+Convert.ToDecimal(textBox1.Text)+","
                +Convert.ToDecimal(HOM)+","
                +Convert.ToDecimal(Wrok)+","
                +Convert.ToDecimal(KRi)+","
                +Convert.ToDecimal(textBox5.Text)+")");

            //this.spR_ORABTableAdapter1.INSERT(Convert.ToDecimal(textBox1.Text),
            //    Convert.ToDecimal(HOM),
            //    Convert.ToDecimal(Wrok),
            //    Convert.ToDecimal(KRi),
            //    Convert.ToDecimal(textBox5.Text));

            
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

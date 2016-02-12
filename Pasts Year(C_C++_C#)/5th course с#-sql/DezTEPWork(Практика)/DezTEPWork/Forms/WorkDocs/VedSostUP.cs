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
    public partial class VedSostUP : Form
    {
        public VedSostUP()
        {
            InitializeComponent();

            WORK = orawork.Load("SELECT ADRESS FROM SPR_FOND");

            foreach (DataRow row in WORK.Rows)
                comboBox2.Items.Add(row[0]);
        }

        FolderBase.OracleWork orawork = new FolderBase.OracleWork();
        DataTable WORK;

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable WR;

            string Wrok = "";


            WR = orawork.Load("SELECT CODEHOUSE FROM SPR_FOND WHERE ADRESS='" + comboBox2.SelectedItem.ToString() + "'");


            foreach (DataRow row in WR.Rows)
                Wrok = row[0].ToString();

            queriesTableAdapter1.VEDSOSTUP(
                Convert.ToDecimal(comboBox1.SelectedItem.ToString()),
                Convert.ToDecimal(Wrok),
                Convert.ToDecimal(OtextBox1.Text),
                Convert.ToDecimal(OtextBox2.Text),
                Convert.ToDecimal(OtextBox3.Text),
                Convert.ToDecimal(OtextBox4.Text),
                Convert.ToDecimal(OtextBox5.Text),
                Convert.ToDecimal(OtextBox6.Text),
                Convert.ToDecimal(OtextBox7.Text));

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VedSostUP_Load(object sender, EventArgs e)
        {
            
            this.veD_SOSTTableAdapter1.Fill(this.diplomOC1.VED_SOST);

            foreach (FolderBase.DiplomOC.VED_SOSTRow _row in this.diplomOC1.VED_SOST)
            {
                this.comboBox1.Items.Add(_row.ID);
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            //foreach (FolderBase.DiplomOC.VED_SOSTRow _rowVed in this.diplomOC1.VED_SOST)            
            //   if(this.comboBox1.SelectedItem.ToString() == _rowVed.CODE.ToString())

            //       foreach (FolderBase.DiplomOC.SPR_FONDRow _rowSpr in this.diplomOC1.SPR_FOND)
            //           if (_rowVed.KEYHOUSES == _rowSpr.CODEHOUSE)
            //           {
            //               this.textBox5.Text = _rowSpr.STREETHOUSE;
            //               this.textBox1.Text = _rowSpr.NUMBERHOUSE.ToString();
            //               this.textBox2.Text = _rowSpr.TYPEHOUSE.ToString();
            //               this.textBox3.Text = _rowSpr.NUMBERROOMS.ToString();
            //               this.textBox4.Text = _rowSpr.YEARBUILD.ToString();

            //               groupBox1.Enabled = true;
            //           }


            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

    }
}

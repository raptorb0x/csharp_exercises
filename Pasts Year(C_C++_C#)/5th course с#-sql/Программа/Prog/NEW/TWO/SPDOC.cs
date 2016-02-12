using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prog.NEW
{
    public partial class SPDOC : Form
    {
        public SPDOC(string Action)
        {
            InitializeComponent();
            this.Text = Action;

            _Action = Action;
        }

        string _Action;
        string Date = "";
        OracleWork OW = new OracleWork();

        private void INSRT()
        {
            try
            {
                OW.ExecuteQuery("INSERT INTO SP_DOC VALUES(" + textBox1.Text +
                    ",(SELECT CODEPO FROM SP_POST WHERE NAMEPO='" + comboBox3.SelectedItem.ToString() + "'),'"
                    + textBox2.Text + "',TO_DATE('" + Date + "','dd/mm/yyyy'))");
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        private void UPDATE()
        {
            try
            {
                OW.ExecuteQuery("UPDATE SP_DOC SET CODEPOST=(SELECT CODEPO FROM SP_POST WHERE NAMEPO='" + comboBox3.SelectedItem.ToString() + "'),CELLS='"
                    + textBox2.Text + "', DATES=TO_DATE('" + Date + "','dd/mm/yyyy') WHERE CODEDOG="+textBox1.Text );
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        private void DELETE()
        {
            try
            {
                OW.ExecuteQuery("DELETE FROM SP_DOC WHERE CODEDOG =" + textBox1.Text);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void SPDOC_Load(object sender, EventArgs e)
        {
            DataTable DT = OW.LoadData("SELECT NAMEPO FROM SP_POST");

            foreach (DataRow row in DT.Rows)
                comboBox3.Items.Add(row[0]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Date = dateTimePicker1.Value.Day.ToString() + "/" + dateTimePicker1.Value.Month.ToString() + "/" + dateTimePicker1.Value.Year.ToString();

            switch (_Action)
            {
                case "Изменить":
                    UPDATE();
                    break;

                case "Удалить":
                    DELETE();
                    break;

                case "Вставить":
                    INSRT();
                    break;

                default:
                    MessageBox.Show("Неполадки в программе, обратитесь к создателю!");
                    this.Close();
                    break;
            }

            this.Close();
        }
    }
}

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
    public partial class MAGPOST : Form
    {
        public MAGPOST(string Action)
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
                OW.ExecuteQuery("INSERT INTO MAG_POST VALUES((SELECT CODEPO FROM SP_POST WHERE NAMEPO='" + comboBox3.SelectedItem.ToString() + "'),"
                    + "TO_DATE('" + Date + "','dd/mm/yyyy')," + textBox2.Text + "," + textBox1.Text + ",(SELECT CODEMAT FROM SP_MAT WHERE NAMEMTP='" + comboBox1.SelectedItem.ToString() + "'))");
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        private void UPDATE()
        {
            try
            {
                OW.ExecuteQuery("UPDATE MAG_POST SET CODEPOST=(SELECT CODEPO FROM SP_POST WHERE NAMEPO='" + comboBox3.SelectedItem.ToString() + "'),KOLVO="
                    + textBox2.Text + ", DATEPOST=TO_DATE('" + Date + "','dd/mm/yyyy'), CODEMTP=(SELECT CODEMAT FROM SP_MAT WHERE NAMEMTP='" + comboBox1.SelectedItem.ToString() + "') WHERE ID="+textBox1.Text);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        private void DELETE()
        {
            try
            {
                OW.ExecuteQuery("DELETE FROM MAG_POST WHERE ID =" + textBox1.Text);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void MAGPOST_Load(object sender, EventArgs e)
        {
            DataTable DT = OW.LoadData("SELECT NAMEPO FROM SP_POST");

            foreach (DataRow row in DT.Rows)
                comboBox3.Items.Add(row[0]);

            DT = OW.LoadData("SELECT NAMEMTP FROM SP_MAT");

            foreach (DataRow row in DT.Rows)
                comboBox1.Items.Add(row[0]);
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

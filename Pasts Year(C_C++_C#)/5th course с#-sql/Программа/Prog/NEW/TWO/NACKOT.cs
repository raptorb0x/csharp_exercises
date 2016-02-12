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
    public partial class NACKOT : Form
    {
        public NACKOT(string Action)
        {
            InitializeComponent();
            this.Text = Action;

            _Action = Action;
        }

        string _Action;
        string Date = "";
        string Date2 = "";

        OracleWork OW = new OracleWork();

        private void INSRT()
        {
            try
            {
                OW.ExecuteQuery("INSERT INTO NACK_OT VALUES(" + textBox1.Text +
                    ",(SELECT CODEDOG FROM SP_DOC WHERE CELLS='" + comboBox1.SelectedItem.ToString() + "'),"
                    + "(SELECT CODEMAT FROM SP_MAT WHERE NAMEMTP='" + comboBox2.SelectedItem.ToString() + "'),"
                    + " TO_DATE('" + Date + "','dd/mm/yyyy')," + textBox2.Text + ","+textBox3.Text+", TO_DATE('" + Date2 + "','dd/mm/yyyy'),'"+textBox4.Text+"')");
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        private void UPDATE()
        {
            try
            {
                OW.ExecuteQuery("UPDATE NACK_OT SET CODEDOG=(SELECT CODEDOG FROM SP_DOC WHERE CELLS='" + comboBox1.SelectedItem.ToString() + "'),"
                    + "CODEMAT=(SELECT CODEMAT FROM SP_MAT WHERE NAMEMTP='" + comboBox2.SelectedItem.ToString() + "'),"
                    + " DATEPR=TO_DATE('" + Date + "','dd/mm/yyyy'),TAKE=" + textBox2.Text + ",GIVE=" + textBox3.Text + ", DATEOTPK=TO_DATE('" + Date2 + "','dd/mm/yyyy'),COMM='" + textBox4.Text + "' WHERE NUMNAK="+textBox1.Text);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        private void DELETE()
        {
            try
            {
                OW.ExecuteQuery("DELETE FROM NACK_OT WHERE NUMNAK =" + textBox1.Text);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void NACKOT_Load(object sender, EventArgs e)
        {
            DataTable DT = OW.LoadData("SELECT CELLS FROM SP_DOC");

            foreach (DataRow row in DT.Rows)
                comboBox1.Items.Add(row[0]);


            DT = OW.LoadData("SELECT NAMEMTP FROM SP_MAT");

            foreach (DataRow row in DT.Rows)
                comboBox2.Items.Add(row[0]);          

            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Date = dateTimePicker1.Value.Day.ToString() + "/" + dateTimePicker1.Value.Month.ToString() + "/" + dateTimePicker1.Value.Year.ToString();
            Date2 = dateTimePicker2.Value.Day.ToString() + "/" + dateTimePicker2.Value.Month.ToString() + "/" + dateTimePicker2.Value.Year.ToString();

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

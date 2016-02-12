using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prog.NEW.OUT2
{
    public partial class JORPOSTOB : Form
    {
        public JORPOSTOB(string Action)
        {
            InitializeComponent();
            this.Text = Action;

            _Action = Action;
        }
        
        string _Action;
        string Date = "";
        string Date2 = "";
        int ID;

        OracleWork OW = new OracleWork();

        private void button1_Click(object sender, EventArgs e)
        {
            Date = dateTimePicker1.Value.Day.ToString() + "/" + dateTimePicker1.Value.Month.ToString() + "/" + dateTimePicker1.Value.Year.ToString();
          //Date2 = dateTimePicker2.Value.Day.ToString() + "/" + dateTimePicker2.Value.Month.ToString() + "/" + dateTimePicker2.Value.Year.ToString();

            DataTable DT = OW.LoadData("SELECT * FROM JOR_POST_OB");
            ID = DT.Rows.Count + 1;

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

        private void JORPOSTOB_Load(object sender, EventArgs e)
        {
            DataTable DT = OW.LoadData("SELECT NAMEPO FROM SP_POST");

            foreach (DataRow row in DT.Rows)
                comboBox1.Items.Add(row[0]);


            DT = OW.LoadData("SELECT NAMEOBJ FROM SP_OBJ");

            foreach (DataRow row in DT.Rows)
                comboBox2.Items.Add(row[0]);

            DT = OW.LoadData("SELECT NAMEMTP FROM SP_MAT");

            foreach (DataRow row in DT.Rows)
                comboBox3.Items.Add(row[0]);

            
        }

        private void INSRT()
        {
            try
            {
                OW.ExecuteQuery("INSERT INTO JOR_POST_OB VALUES((SELECT CODEPO FROM SP_POST WHERE NAMEPO='" + comboBox1.SelectedItem.ToString() + "'),"
                    + "(SELECT CODEOBJ FROM SP_OBJ WHERE NAMEOBJ='" + comboBox2.SelectedItem.ToString() + "'),(SELECT CODEMAT FROM SP_MAT WHERE NAMEMTP='" + comboBox3.SelectedItem.ToString() + "'),"
                    + textBox1.Text+","+textBox2.Text+" ,TO_DATE('" + Date + "','dd/mm/yyyy'),"+ID.ToString()+")");
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        private void UPDATE()
        {
            try
            {
                OW.ExecuteQuery("UPDATE JOR_POST_OB SET CODEPOST=(SELECT CODEPO FROM SP_POST WHERE NAMEPO='" + comboBox1.SelectedItem.ToString() + "'),"
                    + "CODEOBJ=(SELECT CODEOBJ FROM SP_OBJ WHERE NAMEOBJ='" + comboBox2.SelectedItem.ToString() + "'),CODEMAT=(SELECT CODEMAT FROM SP_MAT WHERE NAMEMTP='" + comboBox3.SelectedItem.ToString() + "'),KOLVO="
                    + textBox1.Text + ",KACH=" + textBox2.Text + ",DATEPOST=TO_DATE('" + Date + "','dd/mm/yyyy') WHERE CODEPOST=(SELECT CODEPO FROM SP_POST WHERE NAMEPO='" + comboBox1.SelectedItem.ToString() + "') AND "
                    + "CODEOBJ=(SELECT CODEOBJ FROM SP_OBJ WHERE NAMEOBJ='" + comboBox2.SelectedItem.ToString() + "') AND CODEMAT=(SELECT CODEMAT FROM SP_MAT WHERE NAMEMTP='" + comboBox3.SelectedItem.ToString() + "')");
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        private void DELETE()
        {
            try
            {
                OW.ExecuteQuery("DELETE FROM JOR_POST_OB WHERE CODEPOST=(SELECT CODEPO FROM SP_POST WHERE NAMEPO='" + comboBox1.SelectedItem.ToString() + "') AND "
                    + "CODEOBJ=(SELECT CODEOBJ FROM SP_OBJ WHERE NAMEOBJ='" + comboBox2.SelectedItem.ToString() + "') AND CODEMAT=(SELECT CODEMAT FROM SP_MAT WHERE NAMEMTP='" + comboBox3.SelectedItem.ToString() + "')");
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class ZAVPOST : Form
    {
        public ZAVPOST(string Action)
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
                OW.ExecuteQuery("INSERT INTO ZAV_POST VALUES("+textBox1.Text+
                    ",(SELECT CODEOBJ FROM SP_OBJ WHERE NAMEOBJ='"+comboBox1.SelectedItem.ToString()+"'),"
                    +"(SELECT CODEPO FROM SP_POST WHERE NAMEPO='"+comboBox2.SelectedItem.ToString()+"'),"
                    +"(SELECT CODEMAT FROM SP_MAT WHERE NAMEMTP='"+comboBox3.SelectedItem.ToString()+"'),"
                    +textBox2.Text+",TO_DATE('"+Date+"','dd/mm/yyyy')"+")");
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        private void UPDATE()
        {
            try
            {
                OW.ExecuteQuery("UPDATE ZAV_POST SET CODEOBJ=(SELECT CODEOBJ FROM SP_OBJ WHERE NAMEOBJ='"+comboBox1.SelectedItem.ToString()+"'),"
                    +"CODEPOST=(SELECT CODEPO FROM SP_POST WHERE NAMEPO='"+comboBox2.SelectedItem.ToString()+"'),"
                    +"CODEMAT=(SELECT CODEMAT FROM SP_MAT WHERE NAMEMTP='"+comboBox3.SelectedItem.ToString()+"'),KOLVO="
                    +textBox2.Text+",DATENEED=TO_DATE('"+Date+"','dd/mm/yyyy')");
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        private void DELETE()
        {
            try
            {
                OW.ExecuteQuery("DELETE FROM ZAV_POST WHERE NUM ="+textBox1.Text);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
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

        private void ZAVPOST_Load(object sender, EventArgs e)
        {
            DataTable DT = OW.LoadData("SELECT NAMEOBJ FROM SP_OBJ");
            
            foreach (DataRow row in DT.Rows)
                comboBox1.Items.Add(row[0]);


            DT = OW.LoadData("SELECT NAMEMTP FROM SP_MAT");
            
            foreach (DataRow row in DT.Rows)
                comboBox3.Items.Add(row[0]);


            DT = OW.LoadData("SELECT NAMEPO FROM SP_POST");

            foreach (DataRow row in DT.Rows)
                comboBox2.Items.Add(row[0]);
        }
    }
}

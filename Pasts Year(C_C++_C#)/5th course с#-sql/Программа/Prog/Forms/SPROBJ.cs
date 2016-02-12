using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace Prog.Forms
{
    public partial class SPROBJ : Form
    {
        public SPROBJ(string Action)
        {
            InitializeComponent();
            this.Text = Action;
            OC.ConnectionString = ora_conn;
            OC.Open();
            _Action = Action;
            if (Action == "Удалить")
            {
                groupBox1.Enabled = false;
                textBox5.Enabled = false;
                textBox4.Enabled = false;
                textBox3.Enabled = false;
                textBox2.Enabled = false;
            }

        }


        OracleConnection OC = new OracleConnection();
        OracleCommand command;
        string _Action = "";
        
        string Date="";

        string ora_conn = "DATA SOURCE=127.0.0.1:1521;PASSWORD=1234;PERSIST SECURITY INFO=True;USER ID=URR";

        private void INSRT()
        {
            try
            {
                ExecuteQuery("INSERT INTO SP_OBJ VALUES(" + textBox1.Text + ",'" + textBox2.Text + "','"+textBox3.Text+"','"+
                    textBox4.Text+"',"+"TO_DATE('"+Date+"','dd/mm/YYYY'),"+textBox5.Text+")", OC);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        private void UPDATE()
        {
            try
            {
                ExecuteQuery("UPDATE SP_OBJ SET CODEOBJ=" + textBox1.Text + ", NAMEOBJ='" + textBox2.Text + "', TYPECONSTR='" +textBox3.Text + "',ZAK='"
                    + textBox4.Text + "',DATEELP=(TO_DATE('" + Date + "','dd/mm/YYYY')),VOLUMWORK=" + textBox5.Text + "WHERE CODEOBJ=" + textBox1.Text, OC);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        private void DELETE()
        {

            
            try
            {
                ExecuteQuery("DELETE FROM SP_OBJ WHERE CODEOBJ=" + textBox1.Text, OC);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

      
        private void ExecuteQuery(string txtQuery, OracleConnection ora_con)
        {
            if (ora_con.State.ToString() != "Open")
                ora_con.Open();

            command = ora_con.CreateCommand();
            command.CommandText = txtQuery;
            command.ExecuteNonQuery();
            ora_con.Close();
        }
        private DataTable LoadData(string CommandText, OracleConnection oracleConnection)
        {
            DataTable DT1 = new DataTable();
            OracleDataAdapter DA = new OracleDataAdapter(CommandText, oracleConnection);
            DataSet DS1 = new DataSet();
            DS1.Reset();
            DA.Fill(DS1);
            DT1 = DS1.Tables[0];
            oracleConnection.Close();
            return DT1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (_Action == "Изменить" || _Action == "Вставить")
                    Date = comboBox1.SelectedItem.ToString() + "/" + comboBox2.SelectedItem.ToString() + "/" + comboBox3.SelectedItem.ToString();
                
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
            catch { }
        }
    }
}

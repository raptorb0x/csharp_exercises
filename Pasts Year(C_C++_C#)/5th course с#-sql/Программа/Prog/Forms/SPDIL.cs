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
    public partial class SPDIL : Form
    {
        public SPDIL(string Action)
        {
            InitializeComponent();
            this.Text = Action;
            OC.ConnectionString = ora_conn;
            OC.Open();
            _Action = Action;
            if (Action == "Удалить")
            {
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                textBox5.Enabled = false;
                textBox4.Enabled = false;
               
                textBox2.Enabled = false;
                textBox6.Enabled = false;
                textBox1.Enabled = false;
            }
            
             

        }


        OracleConnection OC = new OracleConnection();
        OracleCommand command;
        DataTable POST;
        DataTable MAT;
        
        string _Action = "";

        string Date = "";

        string ora_conn = "DATA SOURCE=127.0.0.1:1521;PASSWORD=1234;PERSIST SECURITY INFO=True;USER ID=URR";

        private void INSRT()
        {
            try
            {
                DataTable DT = LoadData("SELECT COUNT(*) FROM SP_DIL",OC);
                int Count = 0;
                foreach (DataRow row in DT.Rows)
                    Count = Convert.ToInt32(row[0])+1;
                    

                ExecuteQuery("INSERT INTO SP_DIL VALUES(" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox4.Text + "'," +
                    textBox5.Text + "," +textBox6.Text+ ", (SELECT CODEPO FROM SP_POST WHERE NAMEPO='"+comboBox1.SelectedItem.ToString()+"'),(SELECT CODEMAT FROM SP_MAT WHERE NAMEMTP='"+comboBox2.SelectedItem.ToString()+"'),"+Count.ToString()+ ")", OC);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        private void UPDATE()
        {
            try
            {
                ExecuteQuery("UPDATE SP_DIL SET PRICE="+textBox1.Text +", POSTAV='" + textBox2.Text + "', VSAIM='" +textBox4.Text+"',PREDOPL="
                    + textBox5.Text + ",SROK=" + textBox6.Text + ",CODEPOST=(SELECT CODEPO FROM SP_POST WHERE NAMEPO='" + comboBox1.SelectedItem.ToString() + "'),CODEMAT=(SELECT CODEMAT FROM SP_MAT WHERE NAMEMTP='"+comboBox2.SelectedItem.ToString()+"') WHERE ID="+textBox7.Text, OC);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        private void DELETE()
        {
            try
            {
                ExecuteQuery("DELETE FROM SP_DIL WHERE ID=" + textBox7.Text, OC);
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

        private void SPDIL_Load(object sender, EventArgs e)
        {
            MAT = LoadData("SELECT * FROM SP_MAT", OC);
            POST = LoadData("SELECT * FROM SP_POST",OC);

            foreach (DataRow row in POST.Rows)
                comboBox1.Items.Add(row[1]);
            foreach (DataRow row in MAT.Rows)
                comboBox2.Items.Add(row[1]);
        }
    }
}

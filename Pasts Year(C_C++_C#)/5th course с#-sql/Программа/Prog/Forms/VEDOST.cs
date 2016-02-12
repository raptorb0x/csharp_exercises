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
    public partial class VEDOST : Form
    {
        public VEDOST(string Action)
        {
            InitializeComponent(); this.Text = Action;
            OC.ConnectionString = ora_conn;
            OC.Open();
            _Action = Action;
            if (Action == "Удалить")
            {
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
            }
            DataTable OBJ = LoadData("SELECT NAMEOBJ FROM SP_OBJ", OC);
            DataTable MAT = LoadData("SELECT NAMEMTP FROM SP_MAT", OC);
            
            foreach (DataRow row in OBJ.Rows)
                comboBox1.Items.Add(row[0]);
            
            foreach (DataRow row in MAT.Rows)
                comboBox2.Items.Add(row[0]);

        }


        OracleConnection OC = new OracleConnection();
        OracleCommand command;
        string _Action = "";

        string Date = "";

        string ora_conn = "DATA SOURCE=127.0.0.1:1521;PASSWORD=1234;PERSIST SECURITY INFO=True;USER ID=URR";

        private void INSRT()
        {
            try
            {
                DataTable OBJ = LoadData("SELECT CODEOBJ FROM SP_OBJ WHERE NAMEOBJ='"+comboBox1.SelectedItem.ToString()+"'", OC);
                DataTable MAT = LoadData("SELECT CODEMAT FROM SP_MAT WHERE NAMEMTP='"+comboBox2.SelectedItem.ToString()+"'", OC);

               string CODEO="";
                string CODEM ="";

                foreach (DataRow row in OBJ.Rows)
                    CODEO = row[0].ToString();

                foreach (DataRow row in MAT.Rows)
                    CODEM = row[0].ToString(); 

                ExecuteQuery("INSERT INTO VED_OST VALUES(" + textBox2.Text + "," + CODEO + "," + CODEM + "," +
                    textBox1.Text +")", OC);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        private void UPDATE()
        {
            try
            {
                DataTable OBJ = LoadData("SELECT CODEOBJ FROM SP_OBJ WHERE NAMEOBJ='" + comboBox1.SelectedItem.ToString() + "'", OC);
                DataTable MAT = LoadData("SELECT CODEMAT FROM SP_MAT WHERE NAMEMTP='" + comboBox2.SelectedItem.ToString() + "'", OC);

                string CODEO = "";
                string CODEM = "";

                foreach (DataRow row in OBJ.Rows)
                    CODEO = row[0].ToString();

                foreach (DataRow row in MAT.Rows)
                    CODEM = row[0].ToString();

                ExecuteQuery("UPDATE  VED_OST SET VOLUMEOST=" + textBox2.Text + ", CODEOBJ=" + CODEO + ",CODEMAT=" + CODEM + "WHERE ID=" +
                    textBox1.Text, OC);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        private void DELETE()
        {


            try
            {
                ExecuteQuery("DELETE FROM VED_OST WHERE ID=" + textBox1.Text, OC);
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
            //    if (_Action == "Изменить" || _Action == "Вставить")
                   // Date = comboBox1.SelectedItem.ToString() + "/" + comboBox2.SelectedItem.ToString() + "/" + comboBox3.SelectedItem.ToString();

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

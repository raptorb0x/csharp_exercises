using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace Prog
{
    public partial class Zapr : Form
    {
        public Zapr()
        {
            InitializeComponent();
            _OC.ConnectionString = ora_conn;
            _OC.Open();
        }

        string ora_conn = "DATA SOURCE=127.0.0.1:1521;PASSWORD=1234;PERSIST SECURITY INFO=True;USER ID=KIR";
        OracleConnection _OC = new OracleConnection();
        OracleCommand command;

        private void ExecuteQuery(string txtQuery, OracleConnection ora_con)
        {
            if (ora_con.State.ToString() != "Open")
                ora_con.Open();

            command = ora_con.CreateCommand();
            command.CommandText = txtQuery;
            command.ExecuteNonQuery();
            ora_con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ExecuteQuery(textBox1.Text, _OC);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}

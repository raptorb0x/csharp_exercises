using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.DataAccess.Client;
using System.Windows.Forms;

namespace Prog.NEW
{
    class OracleWork
    {
        public OracleWork()
        {
            try
            {
                oracleConnection.ConnectionString = ConnSTR;
                oracleConnection.Open();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        ~OracleWork()
        {
            try
            {
                oracleConnection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        
        }

        OracleConnection oracleConnection = new OracleConnection();
        OracleCommand command;

        private string ConnSTR = "DATA SOURCE=127.0.0.1:1521;PASSWORD=1234;PERSIST SECURITY INFO=True;USER ID=URR";

        public void ExecuteQuery(string txtQuery)
        {
            if (oracleConnection.State.ToString() != "Open")
                oracleConnection.Open();

            command = oracleConnection.CreateCommand();
            command.CommandText = txtQuery;
            command.ExecuteNonQuery();
            oracleConnection.Close();
        }
        
        public  DataTable LoadData(string CommandText)
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using System.Data;
using System.Windows.Forms;

namespace DezTEPWork.FolderBase
{
    class OracleWork
    {
        public OracleWork()
        {
            try
            {
                OC.ConnectionString = ora_con;
                OC.Open();
            }
            catch (Exception ex) {MessageBox.Show(ex.ToString());}
        }

        OracleConnection OC = new OracleConnection();
        OracleCommand command;

        public string ora_con = "DATA SOURCE=;PERSIST SECURITY INFO=True;USER ID=DON;PASSWORD=12345";

        public void ExecuteQuery(string txt)
        {
            if (OC.State.ToString() != "Open")
                OC.Open();

            command = OC.CreateCommand();
            command.CommandText = txt;
            command.ExecuteNonQuery();
            OC.Close();
        
        }

        public DataTable Load(string txt)
        {
            if (OC.State.ToString() != "Open")
                OC.Open();

            DataTable DT = new DataTable();
            OracleDataAdapter DA = new OracleDataAdapter(txt, OC);
            DataSet DS = new DataSet();
            DS.Reset();
            DA.Fill(DS);
            DT = DS.Tables[0];
            
            OC.Close();

            return DT;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;


namespace Prog
{
    public partial class VedZakPost : Form
    {
        public VedZakPost()
        {
            InitializeComponent();
            
            _OC.ConnectionString = ora_conn;
            _OC.Open();

            ExecuteQuery("DELETE FROM "+TableName, _OC);
        }

        //
        //
        //Работа с базой данных
        //
        //
        string ora_conn = "DATA SOURCE=127.0.0.1:1521;PASSWORD=1234;PERSIST SECURITY INFO=True;USER ID=URR";
        OracleConnection _OC = new OracleConnection();
        OracleCommand command;

        DataTable OBJ;
        DataTable Works;
        DataTable POSTAV;
        DataTable SMETA;
        DataTable SPDIL;
        DataTable VEDDILDON;

        DataTable MAT;
        DataTable Doc;


        string TableName = "VED_DIL_ON";

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

    


        //
        //
        //Обработчики событий
        //
        //
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Works = LoadData("SELECT NAMEWORK,NAMEMTP,EDZ,KOLVO FROM VEDPVIEW WHERE NAMEOBJ='"+comboBox1.SelectedItem.ToString()+"'", _OC);
             // dataGridView1.DataSource = Works;

           // comboBox2.SelectedItem = null;
           // comboBox2.Items.Clear();

          //  foreach(DataRow _row in Works.Rows)
           //   comboBox2.Items.Add(_row[0]);

          //  comboBox2.Enabled = true;

            try
            {
                POSTAV = LoadData("SELECT * FROM VED_DIL_P WHERE NAMEMTP=(SELECT NAMEMTP FROM VEDPVIEW WHERE NAMEMTP='" +
                    comboBox1.SelectedItem.ToString() + "')"
                    , _OC);
            }
            catch (Exception Ex) { MessageBox.Show(Ex.ToString()); }
            //dataGridView1.DataSource = POSTAV;

            comboBox4.Enabled = true;

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string[] mass = new string[6];
                decimal Price;



               // SMETA = LoadData("SELECT * FROM LOCSVIEW WHERE NAMEOBJ='" + comboBox1.SelectedItem.ToString() + "'", _OC);
                SPDIL = LoadData("SELECT * FROM SPDILVIEW", _OC);

                foreach (DataRow _postav in POSTAV.Rows)
                {
                    mass[0] = _postav[1].ToString();
                    mass[1] = _postav[0].ToString();
                    mass[2] = _postav[2].ToString();


                    foreach (DataRow _spdil in SPDIL.Rows)
                    {

                        Price = Convert.ToDecimal(_spdil[0]);
                        Price = (int)(Price / 5);

                        mass[3] = Price.ToString();

                       
                        
                            if ((Convert.ToDecimal(_spdil[7]) - Convert.ToDecimal(comboBox4.SelectedItem)) <= 0)
                            {
                                mass[5] = _spdil[7].ToString();
                                
                                //Works = LoadData("SELECT KOLVO FROM VEDPVIEW WHERE NAMEOBJ='" + comboBox1.SelectedItem.ToString() +
                                //    "' AND NAMEWORK='" + comboBox2.SelectedItem.ToString() + "'", _OC);

                                //foreach (DataRow _works in Works.Rows)
                                //{
                                    mass[4] = "10";

                                //}




                            }

                        

                    }

                    string zapros = "INSERT INTO " + TableName + " VALUES ('" + mass[0] + "','" + mass[1] + "','" + mass[2] + "'," + mass[3] + "," + mass[4] + "," + mass[5] + ")";

                    ExecuteQuery(zapros, _OC);
                    mass = new string[6];
                }

            }
            catch (Exception Ex) { MessageBox.Show(Ex.ToString()); }
                     
            
            VEDDILDON = LoadData("SELECT * FROM "+TableName, _OC);
            
            dataGridView1.DataSource = VEDDILDON;

            groupBox1.Enabled = true;
            
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application OXl;
                Excel._Workbook oWB;
                Excel._Worksheet Sheet;

                Doc = LoadData("SELECT * FROM "+TableName+" WHERE NAMEMTP='"+comboBox3.SelectedItem.ToString()+
                "'", _OC);

                OXl = new Excel.Application();
                OXl.Visible = true;

                oWB = (Excel._Workbook)(OXl.Workbooks.Add(Missing.Value));
                Sheet = (Excel._Worksheet)oWB.ActiveSheet;

                Sheet.get_Range("A6", "F6").ColumnWidth = 23;

                Sheet.Cells[2, 5] = "Ведомость закупаемых материалов";
                Sheet.Cells[4, 2] = "Документ составен программой";

                Sheet.Cells[6, 1] = "Наименование Поставщика";
                Sheet.Cells[6, 2] = "Наименование Материала";
                Sheet.Cells[6, 3] = "Ед. Измр.";
                Sheet.Cells[6, 4] = "Цена";
                Sheet.Cells[6, 5] = "Количество";
                Sheet.Cells[6, 6] = "Срок поставки";
                

                int Start = 7;

                foreach (DataRow _row in Doc.Rows)
                {
                    Sheet.Cells[Start, 1] = _row[0].ToString();
                    Sheet.Cells[Start, 2] = _row[1].ToString();
                    Sheet.Cells[Start, 3] = _row[2].ToString();
                    Sheet.Cells[Start, 4] = _row[3].ToString();
                    Sheet.Cells[Start, 5] = _row[4].ToString();
                    Sheet.Cells[Start, 6] = _row[5].ToString();
                    
                    Start++;
                }

                OXl.UserControl = true;

                DrawBorders(Sheet, "A6", "F" + Start.ToString());


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            _OC.Close();
            this.Close();
        }
        private void VedZakPost_Load(object sender, EventArgs e)
        {
            OBJ = LoadData("SELECT * FROM SP_OBJ", _OC);
            MAT = LoadData("SELECT NAMEMTP FROM SP_MAT", _OC);
            
            foreach (DataRow _row in MAT.Rows)
                comboBox1.Items.Add(_row[0]);
            foreach (DataRow _row in MAT.Rows)
                comboBox3.Items.Add(_row[0]);   

            
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        //
        //
        //Работа с Эксель
        //
        //
        private void DrawBorders(Excel._Worksheet oSheet, string FirstCell, string SecondCell)
        {
            oSheet.get_Range(FirstCell, SecondCell).Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;
            oSheet.get_Range(FirstCell, SecondCell).Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlContinuous;
            oSheet.get_Range(FirstCell, SecondCell).Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
            oSheet.get_Range(FirstCell, SecondCell).Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
            oSheet.get_Range(FirstCell, SecondCell).Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
            oSheet.get_Range(FirstCell, SecondCell).Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

    }
}

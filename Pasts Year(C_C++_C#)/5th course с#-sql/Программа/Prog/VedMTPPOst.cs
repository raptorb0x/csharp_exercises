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
    public partial class VedMTPPOst : Form
    {
        public VedMTPPOst()
        {
            InitializeComponent();

            _OC.ConnectionString = ora_conn;
            _OC.Open();

            ExecuteQuery("DELETE FROM "+TableName, _OC);
            comboBox2.Enabled = false;
        }

        //
        //
        //Переменные
        //
        //

        string[] USL = { "car", "air", "ship" };

        //
        //
        //Работа с БД
        //
        //
        
        string ora_conn = "DATA SOURCE=127.0.0.1:1521;PASSWORD=1234;PERSIST SECURITY INFO=True;USER ID=URR";
        OracleConnection _OC = new OracleConnection();
        OracleCommand command;

        DataTable OBJ;
        DataTable WORKS;
        DataTable KRITER;
        DataTable POSTAV;
        DataTable VEDDILP;


        DataTable VREMEN;

        string TableName = "VED_DIL_P";

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
       
        private void VedMTPPOst_Load(object sender, EventArgs e)
        {
            OBJ = LoadData("SELECT CODEOBJ,NAMEOBJ FROM SP_OBJ", _OC);
            KRITER = LoadData("SELECT * FROM SP_CRIT", _OC);
            VREMEN = LoadData("SELECT * FROM SP_MAT", _OC);
            
             
             foreach(DataRow _row in OBJ.Rows)
             {
                 comboBox1.Items.Add(_row[1]);
             }

             foreach (DataRow _row in VREMEN.Rows)
             {
                 comboBox3.Items.Add(_row[1]);
             }

             comboBox3.Enabled = false;

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // WORKS = LoadData("SELECT NAMEWORK,NAMEMTP FROM VEDPVIEW WHERE NAMEOBJ='"+comboBox1.SelectedItem.ToString()+"'", _OC);

          //  comboBox2.Items.Clear();

          //  foreach (DataRow _row in WORKS.Rows)
          //      comboBox2.Items.Add(_row[0]);

           // comboBox2.Enabled = true;
            button1.Enabled = true;
            
            POSTAV = LoadData("SELECT * FROM SPDILVIEW WHERE NAMEMTP IN (SELECT NAMEMTP FROM VEDPVIEW WHERE NAMEOBJ='" +
                comboBox1.SelectedItem.ToString() + "')", _OC);

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            

            //dataGridView1.DataSource = POSTAV;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] mass = new string[4];

            foreach (DataRow _row in POSTAV.Rows)
            {
                mass[0] = _row[2].ToString();
                mass[1] = _row[3].ToString();
                mass[2] = _row[1].ToString();

                for (int i = 0; i < USL.Length; i++)
                {
                    if (_row[5].ToString() == USL[i])
                    {

                        foreach (DataRow _KRITER in KRITER.Rows)
                        {
                            if (_KRITER[0].ToString() == "Доставка")
                                mass[3] = _KRITER[2].ToString();
                        }
                        
                        ExecuteQuery("INSERT INTO " + TableName + " VALUES ('" + mass[0] + "','" + mass[2] +
                                "','" + mass[1] + "'," + mass[3] + ")", _OC);
                        break;
                    }
                    
                }
                mass = new string[4];
            }

            VEDDILP = LoadData("SELECT * FROM "+TableName, _OC);
            dataGridView1.DataSource = VEDDILP;

            groupBox1.Enabled = true;
            comboBox3.Enabled = true;
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            VREMEN.Clear();
            VREMEN = LoadData("SELECT * FROM " + TableName + " WHERE NAMEMTP='" + comboBox3.SelectedItem.ToString() + "'", _OC);

            try
            {
                Excel.Application OXl;
                Excel._Workbook oWB;
                Excel._Worksheet Sheet;

                OXl = new Excel.Application();
                OXl.Visible = true;

                oWB = (Excel._Workbook)(OXl.Workbooks.Add(Missing.Value));
                Sheet = (Excel._Worksheet)oWB.ActiveSheet;

                Sheet.get_Range("A6", "E5").ColumnWidth = 23;

                Sheet.Cells[2, 5] = "Ведомость закупки материалов("+ comboBox3.SelectedItem.ToString()+") по поставщикам" ;
                Sheet.Cells[4, 2] = "Документ составен программой";

                Sheet.Cells[6, 1] = "Наименование Материала";
                Sheet.Cells[6, 2] = "Наименование Поставщика";
                Sheet.Cells[6, 3] = "Ед. Измр.";
                Sheet.Cells[6, 4] = "Балл";
                


                int Start = 7;

                foreach (DataRow _row in VREMEN.Rows)
                {
                    Sheet.Cells[Start, 1] = _row[0].ToString();
                    Sheet.Cells[Start, 2] = _row[1].ToString();
                    Sheet.Cells[Start, 3] = _row[2].ToString();
                    Sheet.Cells[Start, 4] = _row[3].ToString();
                    



                    Start++;
                }

                OXl.UserControl = true;

                DrawBorders(Sheet, "A6", "E" + Start.ToString());


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            _OC.Close();
            this.Close();

           // dataGridView1.DataSource = VREMEN;
            this.Close();
            _OC.Close();
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
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

        private void label3_Click(object sender, EventArgs e)
        {

        }


    }
}

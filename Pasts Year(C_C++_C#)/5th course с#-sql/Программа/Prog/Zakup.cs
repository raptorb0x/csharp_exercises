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
    public partial class Zakup : Form
    {
        public Zakup()
        {
            InitializeComponent();
            
            _OC.ConnectionString = ora_conn;
            _OC.Open();

        }
        
        //
        //
        //Работа с БД
        //
        //        
        string ora_conn = "DATA SOURCE=127.0.0.1:1521;PASSWORD=1234;PERSIST SECURITY INFO=True;USER ID=URR";
        OracleConnection _OC = new OracleConnection();
        OracleCommand command;

        DataTable Zakupka;        
        DataTable VedomDT;
        DataTable Ost;

        string TableName = "VED_POT_";

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
            TableName += "_" + comboBox1.SelectedItem.ToString();

            try
            {
                               
                VedomDT = LoadData("SELECT * FROM "+TableName, _OC);
                button1.Enabled = true;
                
                
            }
            catch (Exception e1)
            {
                if (e1.Message.Split(':')[0] == "ORA-00942")
                {
                    TableName = "VED_POT_";    
                    MessageBox.Show("Таблицы не существует выбрерите другой год либо создайте таблицу!!");
                    button1.Enabled = false;
                }
            }

            PreviwWindow.DataSource = VedomDT;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            string Time = "01-June-"+comboBox1.SelectedItem.ToString();

            
            
            ExecuteQuery("delete from VED_ZAK",_OC);
            
            Ost = LoadData("Select * from VEDOSTVIEW", _OC);

            foreach (DataRow Ved in VedomDT.Rows)
            {
                foreach (DataRow _Ost in Ost.Rows)
                {
                   if(Ved[0].ToString()== _Ost[1].ToString())
                    if (Ved[1].ToString() == _Ost[0].ToString())
                    {
                        if (Convert.ToUInt32(_Ost[3].ToString()) == 0)
                        {
                            ExecuteQuery("Insert into VED_ZAK values('" + Ved[0].ToString() +"','"+
                                Ved[1].ToString() + "','" + Ved[3].ToString() + "','" + Ved[4].ToString() + "','" + Time + "')", _OC);
                        }
                        else
                        {
                            string Price = "";
                            Price = Convert.ToString(Convert.ToUInt32(Ved[4])-Convert.ToUInt32(_Ost[3]));
                            ExecuteQuery("Insert into VED_ZAK values('" + Ved[0].ToString() + "','" +
                                Ved[1].ToString() + "','" + Ved[3].ToString() + "','" + Price + "','" + Time + "')", _OC);
                        }


                    }

                  
                }
            }

            Zakupka = LoadData("select * from VED_ZAK", _OC);
            PreviwWindow.DataSource = Zakupka;
        
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application OXl;
                Excel._Workbook oWB;
                Excel._Worksheet Sheet;

                OXl = new Excel.Application();
                OXl.Visible = true;

                oWB = (Excel._Workbook)(OXl.Workbooks.Add(Missing.Value));
                Sheet = (Excel._Worksheet)oWB.ActiveSheet;

                Sheet.get_Range("A6", "E6").ColumnWidth = 23;

                Sheet.Cells[2, 5] = "Ведомость закупки материалов на " + comboBox1.SelectedItem.ToString();
                Sheet.Cells[4, 2] = "Документ составен программой";

                Sheet.Cells[6, 1] = "Наименование объекта";
                Sheet.Cells[6, 2] = "Наименование Материала";
                Sheet.Cells[6, 3] = "Ед. Измр.";
                Sheet.Cells[6, 4] = "Количество";
                Sheet.Cells[6, 5] = "Дата закупки";
                

                int Start = 7;

                foreach (DataRow _row in Zakupka.Rows)
                {
                    Sheet.Cells[Start, 1] = _row[0].ToString();
                    Sheet.Cells[Start, 2] = _row[1].ToString();
                    Sheet.Cells[Start, 3] = _row[2].ToString();
                    Sheet.Cells[Start, 4] = _row[3].ToString();
                    Sheet.Cells[Start, 5] = _row[4].ToString();
                    


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


    }
}

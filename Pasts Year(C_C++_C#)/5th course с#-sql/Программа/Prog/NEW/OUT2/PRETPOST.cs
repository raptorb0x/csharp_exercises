using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using Prog.NEW;

namespace Prog.OUT2
{
    public partial class PRETPOST : Form
    {
        public PRETPOST()
        {
            InitializeComponent();
        }

        OracleWork OW = new OracleWork();



        private void PRETPOST_Load(object sender, EventArgs e)
        {
            DataTable DT = OW.LoadData("SELECT NAMEOBJ FROM SP_OBJ");

            foreach (DataRow row in DT.Rows)
            {
                comboBox1.Items.Add(row[0]);
            }


        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable GRRAPH = OW.LoadData("SELECT * FROM GRAPH_MATER WHERE NAMEOBJ='"+comboBox1.SelectedItem.ToString()+"'");
            DataTable JUR = OW.LoadData("SELECT * FROM JOR_POST_OB WHERE CODEOBJ=(SELECT CODEOBJ FROM SP_OBJ WHERE NAMEOBJ='"+comboBox1.SelectedItem.ToString()+"')");

            int ID = 0;
            
            string DateT = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
            
            if (GRRAPH.Rows.Count == 0)
            {
                MessageBox.Show("Данных нет");
                return;
            }

            OW.ExecuteQuery("DELETE FROM PRET");

            foreach(DataRow VED in GRRAPH.Rows)
                foreach (DataRow _TTN in JUR.Rows)
                {
                    DateTime FAKT = Convert.ToDateTime(_TTN[5]);
                    DateTime PLAN = Convert.ToDateTime(VED[3]);

                    string Date1 = FAKT.Day.ToString()+"/"+FAKT.Month.ToString()+"/"+FAKT.Year.ToString();
                    string Date2 = PLAN.Day.ToString() + "/" + PLAN.Month.ToString() + "/" + PLAN.Year.ToString();
                   

                    
                        if (_TTN[0].ToString() == VED[1].ToString())
                        //  if (Convert.ToInt32(_TTN[2]) - Convert.ToInt32(VED[3]) != 0)
                          {
                              int Kol = (Convert.ToInt32(_TTN[3]) - Convert.ToInt32(VED[2]));
                              
                              OW.ExecuteQuery("INSERT INTO PRET VALUES(TO_DATE('"+DateT+"','dd/mm/yyyy'),"
                                  + _TTN[2].ToString() + "," + VED[2].ToString() + "," + _TTN[3].ToString() +","+Kol.ToString() +","
                                   + "TO_DATE('" + Date2 + "','dd/mm/yyyy'),TO_DATE('" + Date1 + "','dd/mm/yyyy'),'"+PLAN.Subtract(FAKT).ToString()+"',"
                                   +ID.ToString()+",10,"+_TTN[4].ToString()+","+Convert.ToString(10-Convert.ToInt32(_TTN[4].ToString()))+")");
                              ID++;
                          }     
                        
                    
                    
                
                }
            //
            //
            //
            //
            dataGridView1.DataSource = OW.LoadData("SELECT * FROM PRETVIEW");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           try
            {
                Excel.Application OXl;
                Excel._Workbook oWB;
                Excel._Worksheet Sheet;

                DataTable DT = OW.LoadData("SELECT * FROM PRETVIEW");

                OXl = new Excel.Application();
                OXl.Visible = true;

                oWB = (Excel._Workbook)(OXl.Workbooks.Add(Missing.Value));
                Sheet = (Excel._Worksheet)oWB.ActiveSheet;

                Sheet.get_Range("A6", "Z6").ColumnWidth = 23;

                Sheet.Cells[2, 5] = "Претензии к поставщикам при поставки МТР на объект " + comboBox1.SelectedItem.ToString();
                Sheet.Cells[4, 2] = "Документ составен программой";

                Sheet.Cells[6, 1] = "Индекс";
                Sheet.Cells[6, 2] = "Дата поставки";
                Sheet.Cells[6, 3] = "Наименование МТР";
                Sheet.Cells[6, 4] = "Ед. измр";
                Sheet.Cells[6, 5] = "Плановое количество";
                Sheet.Cells[6, 6] = "Фактическое количестов";
                Sheet.Cells[6, 7] = "Отклонения";
                Sheet.Cells[6, 8] = " Дата плановая";
                Sheet.Cells[6, 9] = " Дата фактическая";
                Sheet.Cells[6, 10] = "Отклонения";
                

                int Start = 7;

                foreach (DataRow _row in DT.Rows)
                {
                    Sheet.Cells[Start, 1] = _row[0].ToString();
                    Sheet.Cells[Start, 2] = _row[1].ToString();
                    Sheet.Cells[Start, 3] = _row[2].ToString();
                    Sheet.Cells[Start, 4] = _row[3].ToString();
                    Sheet.Cells[Start, 5] = _row[4].ToString();
                    Sheet.Cells[Start, 6] = _row[5].ToString();
                    Sheet.Cells[Start, 7] = _row[6].ToString();
                    Sheet.Cells[Start, 8] = _row[7].ToString();
                    Sheet.Cells[Start, 9] = _row[8].ToString();
                    Sheet.Cells[Start, 10] = _row[9].ToString();
                    


                    Start++;
                }

                OXl.UserControl = true;

                DrawBorders(Sheet, "A6", "G" + Start.ToString());


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

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

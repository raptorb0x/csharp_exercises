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
    public partial class GRAFPOSTMAT : Form
    {
        public GRAFPOSTMAT()
        {
            InitializeComponent();
        }


       OracleWork OW = new OracleWork();
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable ZAVPOST = OW.LoadData("SELECT * FROM ZAVPOSTVIEW WHERE NAMEOBJ='"+comboBox1.SelectedItem.ToString()+"'");
            DataTable VEDDIL = OW.LoadData("SELECT * FROM VED_DIL_ON");

            DateTime NEED = new DateTime();
            DateTime TD = DateTime.Today;

            OW.ExecuteQuery("DELETE FROM GRAPH_MATER");

            int ID = 0;
            string Date = "";

            foreach(DataRow Zav in ZAVPOST.Rows)
                foreach (DataRow VED in VEDDIL.Rows)
                {

                    NEED = Convert.ToDateTime(Zav[7]);
                    
                    if (Zav[4].ToString() == VED[1].ToString())
                    { 
                       TD=TD.AddDays(Convert.ToInt32(VED[5]));
                       if (NEED.CompareTo(TD) < 0)
                       {
                           Date = TD.Day.ToString() + "/" + TD.Month.ToString() + "/" + TD.Year.ToString();
                           OW.ExecuteQuery("INSERT INTO GRAPH_MATER VALUES((SELECT CODEMAT FROM SP_MAT WHERE NAMEMTP='"+VED[1].ToString()+"'),(SELECT CODEPO FROM SP_POST WHERE NAMEPO='"+VED[0].ToString()+"'),"+Zav[6].ToString()+",TO_DATE('"+Date+"','dd/mm/yyyy'),"+ID.ToString()+",'"+comboBox1.SelectedItem.ToString()+"')");
                           ID++;
                       }
                    }
                    

                }
            DataTable DT = OW.LoadData("SELECT * FROM GRAPH_MATER");
            DT.Columns[0].ColumnName = "Код материала";
            DT.Columns[1].ColumnName = "Код поставщика";
            DT.Columns[2].ColumnName = "Количество";
            DT.Columns[3].ColumnName = "Дата";
            DT.Columns[4].ColumnName = "Номер";
            DT.Columns[5].ColumnName = "Код объекта";

             dataGridView1.DataSource = DT;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GRAFPOSTMAT_Load(object sender, EventArgs e)
        {
            DataTable DT = OW.LoadData("SELECT NAMEOBJ FROM SP_OBJ");
            
            foreach (DataRow row in DT.Rows)
                comboBox1.Items.Add(row[0]);
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application OXl;
                Excel._Workbook oWB;
                Excel._Worksheet Sheet;

                DataTable DT = OW.LoadData("SELECT * FROM GRAPHMATERVIEW");

                OXl = new Excel.Application();
                OXl.Visible = true;

                oWB = (Excel._Workbook)(OXl.Workbooks.Add(Missing.Value));
                Sheet = (Excel._Worksheet)oWB.ActiveSheet;

                Sheet.get_Range("A6", "E6").ColumnWidth = 23;

                Sheet.Cells[2, 5] = "График поставки МТР на объект " + comboBox1.SelectedItem.ToString();
                Sheet.Cells[4, 2] = "Документ составен программой";

                Sheet.Cells[6, 1] = "Индекс";
                Sheet.Cells[6, 2] = "Тип";
                Sheet.Cells[6, 3] = "Имя объекта";
                Sheet.Cells[6, 4] = "Имя поставщика";
                Sheet.Cells[6, 5] = "Наименование МТР";
                Sheet.Cells[6, 6] = "Ед. Измр";
                Sheet.Cells[6, 7] = "Количестов";
                Sheet.Cells[6, 8] = "Дата поставки";


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
    }
}

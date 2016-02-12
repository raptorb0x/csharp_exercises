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
    public partial class OTKLGRAPHMAT : Form
    {
        public OTKLGRAPHMAT()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OTKLGRAPHMAT_Load(object sender, EventArgs e)
        {
            DataTable DT = OW.LoadData("SELECT NAMEPO FROM SP_POST");

            foreach (DataRow row in DT.Rows)
                comboBox1.Items.Add(row[0]);
        }

        OracleWork OW = new OracleWork();

        private void button1_Click(object sender, EventArgs e)
        {
            OW.ExecuteQuery("DELETE FROM GRAPFPOST");

            
            DataTable GRAPH = OW.LoadData("SELECT * FROM GRAPH_MATER WHERE POST=(SELECT CODEPO FROM SP_POST WHERE NAMEPO='" + comboBox1.SelectedItem.ToString() + "')");

           
            string Date1 = "";
            Random kr = new Random();

            foreach (DataRow GR in GRAPH.Rows)
            {
                DateTime DT = Convert.ToDateTime(GR[3]);
                int KAH = kr.Next(0, 10);
                Date1 = DT.Day.ToString() + "/" + DT.Month.ToString() + "/" + DT.Year.ToString();
                OW.ExecuteQuery("INSERT INTO GRAPFPOST VALUES((SELECT CODEPO FROM SP_POST WHERE NAMEPO='" + comboBox1.SelectedItem.ToString() + "'),(SELECT CODEOBJ FROM SP_OBJ WHERE NAMEOBJ='"+GR[5].ToString()+"'),"+GR[0].ToString()+","+GR[2].ToString()+",TO_DATE('"+Date1+"','dd/mm/yyyy'),"+KAH.ToString()+")");
            }

            dataGridView1.DataSource = OW.LoadData("SELECT * FROM GRAPFPOSTVIEW");
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application OXl;
                Excel._Workbook oWB;
                Excel._Worksheet Sheet;

                DataTable DT = OW.LoadData("SELECT * FROM GRAPFPOSTVIEW");

                OXl = new Excel.Application();
                OXl.Visible = true;

                oWB = (Excel._Workbook)(OXl.Workbooks.Add(Missing.Value));
                Sheet = (Excel._Worksheet)oWB.ActiveSheet;

                Sheet.get_Range("A6", "Z6").ColumnWidth = 23;

                Sheet.Cells[2, 5] = "Отчет отклонений от графика поставки МТР для поставщика " + comboBox1.SelectedItem.ToString();
                Sheet.Cells[4, 2] = "Документ составен программой";

                Sheet.Cells[6, 1] = "Имя поставщика";
                Sheet.Cells[6, 2] = "Имя объекта";
                Sheet.Cells[6, 3] = "Имя МТР";
                Sheet.Cells[6, 4] = "Ед. Изм.";
                Sheet.Cells[6, 5] = "Тип, ГОСТ, Марка";
                Sheet.Cells[6, 6] = "Количество";
                Sheet.Cells[6, 7] = "Дата поставки";          


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

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
    public partial class VEDDVIJMAT : Form
    {
        public VEDDVIJMAT()
        {
            InitializeComponent();
        }

       OracleWork OW = new OracleWork();

        private void button1_Click(object sender, EventArgs e)
        {
            OW.ExecuteQuery("DELETE FROM VED_M");
            
            DataTable MAG = OW.LoadData("SELECT * FROM MAGPOSTVIEW");
            DataTable ZAV = OW.LoadData("SELECT * FROM ZAVPOSTVIEW WHERE NAMEOBJ='"+comboBox1.SelectedItem.ToString()+"'");
            DataTable NACKOT = OW.LoadData("SELECT * FROM NACKOTVIEW");

            string Date = "";
            int ID = 0;
            //   foreach (DataRow _ZAV in ZAV.Rows)
            // foreach(DataRow _NACK in NACKOT.Rows)
            
            
            foreach (DataRow _ZAV in ZAV.Rows)    
                   {
                
                        DateTime PER = Convert.ToDateTime(_ZAV[7]);
                        Date = PER.Day.ToString() + "/" + PER.Month.ToString() + "/" + PER.Year.ToString();


                        if (PER.CompareTo(dateTimePicker1.Value) < 0)
                        {
                            foreach (DataRow _MAG in MAG.Rows)
                            {
                                if (_ZAV[4].ToString() == _MAG[2].ToString())
                                {
                                    foreach (DataRow _NACK in NACKOT.Rows)
                                    {
                                        if (_ZAV[4].ToString() == _NACK[2].ToString())
                                        {
                                                                                       
                                            OW.ExecuteQuery("INSERT INTO VED_M VALUES("+
                                                "(SELECT CODEOBJ FROM SP_OBJ WHERE NAMEOBJ='"+comboBox1.SelectedItem.ToString()+"'),"
                                                +"(SELECT CODEMAT FROM SP_MAT WHERE NAMEMTP='"+_ZAV[4].ToString()+"'),"
                                                +"TO_DATE('"+Date+"','dd/mm/yyyy'),"+
                                                _ZAV[6].ToString()+","
                                                +"TO_DATE('"+Date+"','dd/mm/yyyy'),"
                                                + _ZAV[6].ToString() +",0,0,"+ID.ToString()+ ")");
                                            break;
                                        }
                                    }
                                }
                               
                            }
                        
                        }
                    }
         
        
            //
            //
            //
            //

            DataTable DT = OW.LoadData("SELECT * FROM VED_M");
            DT.Columns[0].ColumnName = "Код объекта";
            DT.Columns[1].ColumnName = "Код материала";
            DT.Columns[2].ColumnName = "Дата прихода";
            DT.Columns[3].ColumnName = "количество прихода";
            DT.Columns[4].ColumnName = "Дата расхода";
            DT.Columns[5].ColumnName = "Количество расхода";
            DT.Columns[6].ColumnName = "Остаток на начало периода";
            DT.Columns[7].ColumnName = "Остаток на конец периода";
            

            dataGridView1.DataSource = DT;
        }

        private void VEDDVIJMAT_Load(object sender, EventArgs e)
        {
            DataTable DT = OW.LoadData("SELECT NAMEOBJ FROM SP_OBJ");
            
            foreach(DataRow row in DT.Rows)
                 comboBox1.Items.Add(row[0]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application OXl;
                Excel._Workbook oWB;
                Excel._Worksheet Sheet;

                DataTable DT = OW.LoadData("SELECT * FROM VEDMVIEW");

                OXl = new Excel.Application();
                OXl.Visible = true;

                oWB = (Excel._Workbook)(OXl.Workbooks.Add(Missing.Value));
                Sheet = (Excel._Worksheet)oWB.ActiveSheet;

                Sheet.get_Range("A6", "Z6").ColumnWidth = 23;

                Sheet.Cells[2, 5] = "Претензии к поставщикам при поставки МТР на объект " + comboBox1.SelectedItem.ToString();
                Sheet.Cells[4, 2] = "Документ составен программой";

                Sheet.Cells[6, 1] = "Индекс";
                Sheet.Cells[6, 2] = "Имя объекта";
                Sheet.Cells[6, 3] = "Наименование МТР";
                Sheet.Cells[6, 4] = "Ед. измр";
                Sheet.Cells[6, 5] = "Дата приема";
                Sheet.Cells[6, 6] = "Количество";
                Sheet.Cells[6, 7] = "Дата отгрузки";
                Sheet.Cells[6, 8] = " Количестов";
                Sheet.Cells[6, 9] = " Остаток начала периода";
                Sheet.Cells[6, 10] = "Остаток конца периода";


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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

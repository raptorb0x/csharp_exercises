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

namespace DezTEPWork.Forms.OutputForms
{
    public partial class GrORemCreate : Form
    {
        public GrORemCreate()
        {
            InitializeComponent();
        }

        private void GrORemCreate_Load(object sender, EventArgs e)
        {

            this.fiN_OT_SOSTTableAdapter1.Fill(this.diplomOC1.FIN_OT_SOST);

            if (this.diplomOC1.FIN_OT_SOST.Rows.Count == 0)
            {
                MessageBox.Show("Для начала работы сформируйте отчет состояния жилищного фонда");
                this.Close();
            }

            this.plremviewTableAdapter1.Fill(this.diplomOC1.PLREMVIEW);
            this.jrremmsviewTableAdapter1.Fill(this.diplomOC1.JRREMMSVIEW);
            this.sprprorabviewTableAdapter1.Fill(this.diplomOC1.SPRPRORABVIEW);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal Koev = 0;
            decimal K = 0;

            string typeneedwork = "";

            this.otsostfinviewTableAdapter1.Fill(this.diplomOC1.OTSOSTFINVIEW);

            this.queriesTableAdapter1.FINGRREMOALLDEL();

            foreach (FolderBase.DiplomOC.PLREMVIEWRow _PLYear in this.diplomOC1.PLREMVIEW.Rows)
            {
                 foreach (FolderBase.DiplomOC.JRREMMSVIEWRow _Jr in this.diplomOC1.JRREMMSVIEW.Rows)
                    {
                        if (_PLYear.ADRESS == _Jr.ADRESS)
                           
                                Koev += 1;            

                    }
                

                foreach (FolderBase.DiplomOC.OTSOSTFINVIEWRow _OtSost in this.diplomOC1.OTSOSTFINVIEW.Rows)
                {                          


                    if (_PLYear.ADRESS == _OtSost.ADRESS)
                        
                        {
                            K = (_OtSost.SCALE + Koev) / 12;
                            typeneedwork = _OtSost.TYPEREM;

                        }
                    
                }
                foreach (FolderBase.DiplomOC.SPRPRORABVIEWRow _spr in this.diplomOC1.SPRPRORABVIEW.Rows)
                {
                    if (_PLYear.TYPE == _spr.TYPE)
                    {
                        FolderBase.OracleWork OW = new FolderBase.OracleWork();

                        DataTable CODEH = OW.Load("SELECT CODEHOUSE FROM SPR_FOND WHERE ADRESS='" + _PLYear.ADRESS.ToString() + "'");
                        decimal _CODEH = 0;
                        
                        foreach (DataRow row in CODEH.Rows)
                            _CODEH = Convert.ToDecimal(row[0]);

                        DataTable CODER = OW.Load("SELECT ID FROM SPR_CRIT WHERE TYPEREM='" + typeneedwork + "'");
                        decimal _CODER = 0;

                        foreach (DataRow row in CODEH.Rows)
                            _CODER = Convert.ToDecimal(row[0]);

                        this.fiN_GR_OREMTableAdapter1.INSERT(
                            _PLYear.ID,
                           _CODEH,
                            _CODER,K,
                            _spr.SCALE
                            );

                        

                        K = 0;
                        Koev = 0;



                        break;
                    }
                    
                    
                }

            }


            this.fiN_GR_OREMTableAdapter1.Fill(this.diplomOC1.FIN_GR_OREM);
            OtextBox1.Text = this.diplomOC1.FIN_GR_OREM.Rows.Count.ToString();

            int MaxKol = 0;
            foreach (FolderBase.DiplomOC.GRREMOVIEWRow _row in this.diplomOC1.GRREMOVIEW.Rows)
            {
                MaxKol += (int)_row.SACELETIME;
            }

            OtextBox2.Text = MaxKol.ToString();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            Excel.Application oXL;
            Excel._Workbook oWB;
            Excel._Worksheet oSheet;
            

            int MaxKolRight = 3;
            int MaxKolDown = 2;

            try
            {

               // this.gR_OREMTableAdapter1.FillBy(this.diplomOC1.GR_OREM);

               // foreach(FolderBase.DiplomOC.GR_OREMRow _row in this.diplomOC1.GR_OREM.Rows)
               // {
               //     MaxKolRight += (int)_row.SCALETIME; 
               // }

               // MaxKolDown += this.diplomOC1.GR_OREM.Rows.Count;

               // //Start Excel and get Application object.
               // oXL = new Excel.Application();
               // oXL.Visible = true;

               // //Get a new workbook.
               // oWB = (Excel._Workbook)(oXL.Workbooks.Add(Missing.Value));
               // oSheet = (Excel._Worksheet)oWB.ActiveSheet;

               // oSheet.get_Range("D1", GetCell(MaxKolDown,MaxKolRight+1)).ColumnWidth = 2;

               // //Add table headers going cell by cell.
               // oSheet.Cells[1, 1] = "График составила:"+" "+this.textBox1.Text;
               // oSheet.Cells[1, 10] = "Исполнитель:"+" "+textBox2.Text;
               // oSheet.Cells[2, 5] = "Контролирующий орган:"+" "+textBox3.Text;
               
               // // oSheet.Cells[1, 4] = "Утверждаю: Генеральный директор "+"________________"+textBox4.Text+"/"+textBox5.Text;

               
               ////  oSheet.get_Range("B2", "C4").Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
               //// oSheet.get_Range("C3", "M4").Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlDashDot;
               // int i =3;
               // foreach (FolderBase.DiplomOC.GR_OREMRow _row in this.diplomOC1.GR_OREM.Rows)
               // {

               //     oSheet.Cells[i, 1] = _row.CODE.ToString();
               //     oSheet.Cells[i, 2] = _row.ADRESS.ToString();
               //     oSheet.Cells[i, 3] = _row.TYPENEEDWORK;

               //     i++;
               // }


               // int StartCellhor = 3;
               // int StarCellVer = 3;

                
               // foreach (FolderBase.DiplomOC.GR_OREMRow _row in this.diplomOC1.GR_OREM.Rows)
               // {
                    
               //     oSheet.get_Range(GetCell(StarCellVer,StartCellhor), GetCell(StarCellVer,StartCellhor+(int)_row.SCALETIME)).Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
               //     StartCellhor+=(int)_row.SCALETIME+1;
               //     StarCellVer++;
               // }

               // DrawBorders(oSheet,"A3",GetCell(StarCellVer-1,StartCellhor-1));
                
               // oSheet.Cells[MaxKolDown + 1, 2] = "Утверждаю: Генеральный директор " + "________________" + textBox4.Text + "/" + textBox5.Text+"/______________м.п.";


               // //Make sure Excel is visible and give the user control
               // //of Microsoft Excel's lifetime.
               // oXL.Visible = true;
               // oXL.UserControl = true;
            }
            catch (Exception theException)
            {
                String errorMessage;
                errorMessage = "Error: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " Line: ");
                errorMessage = String.Concat(errorMessage, theException.Source);

                MessageBox.Show(errorMessage, "Error");
            }

            this.Close();
        }

        private string GetCell(int Ver,int Hor)
        {
            string Cell = string.Empty;
         string[] Alf = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};

         int Ind = (int)(Hor / Alf.Length);

         if (Ind >= 1)
             Cell = Alf[Ind] + Alf[Hor - (Ind * Alf.Length)] + Ver.ToString();
         else
             Cell = Alf[Hor] + Ver.ToString();

         return Cell;
        }
        private void DrawBorders(Excel._Worksheet oSheet,string FirstCell,string SecondCell) 
        {
            oSheet.get_Range(FirstCell,SecondCell).Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;
            oSheet.get_Range(FirstCell, SecondCell).Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlContinuous;
            oSheet.get_Range(FirstCell, SecondCell).Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
            oSheet.get_Range(FirstCell, SecondCell).Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
            oSheet.get_Range(FirstCell, SecondCell).Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
            oSheet.get_Range(FirstCell, SecondCell).Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = true;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = true;
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox5.Enabled = true;
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
               
    }
}

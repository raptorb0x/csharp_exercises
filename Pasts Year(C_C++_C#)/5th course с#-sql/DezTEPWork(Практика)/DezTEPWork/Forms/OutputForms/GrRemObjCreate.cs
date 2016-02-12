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
    public partial class GrRemObjCreate : Form
    {
        public GrRemObjCreate()
        {
            InitializeComponent();
        }
        
        FolderBase.OracleWork OW = new FolderBase.OracleWork();

        private void GrRemObjCreate_Load(object sender, EventArgs e)
        {
            
            this.sprorabviewTableAdapter1.Fill(this.diplomOC1.SPRORABVIEW);
            this.sprposledTableAdapter1.Fill(this.diplomOC1.SPRPOSLED);
            this.sprworksviewTableAdapter1.Fill(this.diplomOC1.SPRWORKSVIEW);
            this.sprtarifviewTableAdapter1.Fill(this.diplomOC1.SPRTARIFVIEW);

            this.grremoviewTableAdapter1.Fill(this.diplomOC1.GRREMOVIEW);

            DataTable DT = OW.Load("SELECT ADRESS FROM SPR_FOND");

            foreach (DataRow row in DT.Rows)
                comboBox1.Items.Add(row[0]);
            
        }       

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
            //this.gR_REMOBJTableAdapter1.Fill(this.diplomOC1.GR_REMOBJ);

            this.queriesTableAdapter1.FINGRREMOBJALLDEL();

            string Workers0 = string.Empty;
            string Workers1 = string.Empty;

            decimal Scalew = 1;
            decimal STR = 1;
            decimal KolSmen = 1;
            decimal PriceEdz = 1;
            decimal StartWork = 0;
            decimal numeric = 0;

            int KolRabBR1 = 4;
            int KolRabBR2 = 3;

            if (Convert.ToInt16(comboBox3.SelectedItem.ToString()) == 1)

                foreach (FolderBase.DiplomOC.GRREMOVIEWRow _rowGr in this.diplomOC1.GRREMOVIEW)
                {
                    if (_rowGr.ADRESS == comboBox1.SelectedItem.ToString())
                    {
                        foreach (FolderBase.DiplomOC.SPRTARIFVIEWRow _rowTarif in this.diplomOC1.SPRTARIFVIEW)
                        {

                            if (_rowGr.TYPEREM == _rowTarif.TYPEREM)
                            {
                                PriceEdz = _rowTarif.STOIM;

                                foreach (FolderBase.DiplomOC.SPRORABVIEWRow _row_sprOrab in this.diplomOC1.SPRORABVIEW.Rows)
                                {
                                    if (_rowTarif.NAMEWORK == _row_sprOrab.TYPEREM)
                                    {
                                        Scalew = _row_sprOrab.SCALE;

                                    }

                                    foreach (FolderBase.DiplomOC.SPRWORKSVIEWRow _rowSprSnip in this.diplomOC1.SPRWORKSVIEW.Rows)
                                    {
                                        if (_rowTarif.NAMEWORK == _rowSprSnip.NAMEWORK)
                                        {

                                            STR = Scalew / _rowSprSnip.NORM;
                                            KolSmen = STR * 2;
                                            break;

                                        }
                                    }


                                    if (this.diplomOC1.FIN_GR_REMOBJ.Rows.Count == 0)
                                    {
                                        StartWork = 0;
                                    }


                                }
                            }

                            DataTable CODEH = OW.Load("SELECT CODEHOUSE FROM SPR_FOND WHERE ADRESS='" + comboBox1.SelectedItem.ToString() + "'");
                            decimal _CODEH = 0;

                            foreach (DataRow row in CODEH.Rows)
                                _CODEH = Convert.ToDecimal(row[0]);

                            DataTable CODER = OW.Load("SELECT ID FROM SPR_CRIT WHERE TYPEREM='" + _rowGr.TYPEREM + "'");
                            decimal _CODER = 0;

                            foreach (DataRow row in CODEH.Rows)
                                _CODER = Convert.ToDecimal(row[0]);
                            
                            this.fiN_GR_REMOBJTableAdapter1.INSERT(
                                       numeric,
                                       _CODEH,
                                       _CODER,
                                       Scalew,
                                       STR,
                                       KolSmen,
                                       KolRabBR1,
                                       PriceEdz * Scalew,
                                       StartWork,
                                       (int)(KolSmen + StartWork));

                            StartWork += KolSmen;
                            KolSmen = 1;
                            Scalew = 1;
                            STR = 1;
                            PriceEdz = 0;
                            numeric++;
                            break;
                        }
                    }



                }


            else
            {

                int CountWorkBr1 = 0;
                int CountWorkBr2 = 0;

                decimal StartWorkBr1 = 0;
                decimal StartWorkBr2 = 0;



                foreach (FolderBase.DiplomOC.GRREMOVIEWRow _rowGr in this.diplomOC1.GRREMOVIEW)
                {
                    if (_rowGr.ADRESS == comboBox1.SelectedItem.ToString())
                    {
                        foreach (FolderBase.DiplomOC.SPRTARIFVIEWRow _rowTarif in this.diplomOC1.SPRTARIFVIEW)
                        {

                            if (_rowGr.TYPEREM == _rowTarif.TYPEREM)
                            {
                                PriceEdz = _rowTarif.STOIM;

                                foreach (FolderBase.DiplomOC.SPRORABVIEWRow _row_sprOrab in this.diplomOC1.SPRORABVIEW.Rows)
                                {
                                    if (_rowTarif.NAMEWORK == _row_sprOrab.TYPEREM)
                                    {
                                        Scalew = _row_sprOrab.SCALE;

                                    }

                                    foreach (FolderBase.DiplomOC.SPRWORKSVIEWRow _rowSprSnip in this.diplomOC1.SPRWORKSVIEW.Rows)
                                    {
                                        if (_rowTarif.NAMEWORK == _rowSprSnip.NAMEWORK)
                                        {

                                            STR = Scalew / _rowSprSnip.NORM;
                                            KolSmen = STR * 2;
                                            break;

                                        }
                                    }


                                    if (this.diplomOC1.FIN_GR_REMOBJ.Rows.Count == 0)
                                    {
                                        StartWork = 0;
                                    }
                                }
                            }

                            foreach (FolderBase.DiplomOC.SPRPOSLEDRow _sprRabpo in this.diplomOC1.SPRPOSLED.Rows)
                            {

                                if (_rowTarif.NAMEWORK == _sprRabpo.NAMEWORK)
                                    if (Convert.ToInt16(_sprRabpo.POSLED) == 0)
                                    {


                                        if (CountWorkBr1 == 0)
                                        { StartWorkBr1 = 0; }

                                        DataTable CODEH = OW.Load("SELECT CODEHOUSE FROM SPR_FOND WHERE ADRESS='" + comboBox1.SelectedItem.ToString() + "'");
                                        decimal _CODEH = 0;

                                        foreach (DataRow row in CODEH.Rows)
                                            _CODEH = Convert.ToDecimal(row[0]);

                                        DataTable CODER = OW.Load("SELECT ID FROM SPR_CRIT WHERE TYPEREM='" + _rowGr.TYPEREM + "'");
                                        decimal _CODER = 0;

                                        foreach (DataRow row in CODEH.Rows)
                                            _CODER = Convert.ToDecimal(row[0]);

                                        this.fiN_GR_REMOBJTableAdapter1.INSERT(
                                                   numeric,
                                                   _CODEH,
                                                   _CODER,
                                                   Scalew,
                                                   STR,
                                                   KolSmen,
                                                   KolRabBR1,
                                                   PriceEdz * Scalew,
                                                   StartWork,
                                                   (int)(KolSmen + StartWork));

                                        StartWork += (int)KolSmen+1;
                                        KolSmen = 1;
                                        Scalew = 1;
                                        STR = 1;
                                        PriceEdz = 0;
                                        numeric++;

                                        CountWorkBr1++;
                                        break;
                                    }

                                    else
                                    {



                                        if (CountWorkBr2 == 0)
                                        { StartWorkBr2 = 0; }

                                        DataTable CODEH = OW.Load("SELECT CODEHOUSE FROM SPR_FOND WHERE ADRESS='" + comboBox1.SelectedItem.ToString() + "'");
                                        decimal _CODEH = 0;

                                        foreach (DataRow row in CODEH.Rows)
                                            _CODEH = Convert.ToDecimal(row[0]);

                                        DataTable CODER = OW.Load("SELECT ID FROM SPR_CRIT WHERE TYPEREM='" + _rowGr.TYPEREM + "'");
                                        decimal _CODER = 0;

                                        foreach (DataRow row in CODEH.Rows)
                                            _CODER = Convert.ToDecimal(row[0]);

                                        this.fiN_GR_REMOBJTableAdapter1.INSERT(
                                                   numeric,
                                                   _CODEH,
                                                   _CODER,
                                                   Scalew,
                                                   STR,
                                                   KolSmen,
                                                   KolRabBR1,
                                                   PriceEdz * Scalew,
                                                   StartWork,
                                                   (int)(KolSmen + StartWork));

                                        StartWork += (int)KolSmen+1;
                                        KolSmen = 1;
                                        Scalew = 1;
                                        STR = 1;
                                        PriceEdz = 0;
                                        numeric++;

                                        CountWorkBr2++;
                                        break;
                                    }

                            }
                        }
                    }



                }


            }

            this.grremobjviewTableAdapter1.Fill(this.diplomOC1.GRREMOBJVIEW);

            OtextBox1.Text = diplomOC1.GRREMOBJVIEW.Rows.Count.ToString();


            foreach (FolderBase.DiplomOC.GRREMOBJVIEWRow _row in this.diplomOC1.GRREMOBJVIEW.Rows)
            {
                if (_row.STOPWORK > k)
                {
                    k = (int)_row.STOPWORK;
                }
            }

            OtextBox2.Text = k.ToString();

            groupBox3.Enabled = true;


        }

        int k = 0;

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }

        private void ItextBox1_TextChanged(object sender, EventArgs e)
        {
            ItextBox2.Enabled = true;
        }
        private void ItextBox2_TextChanged(object sender, EventArgs e)
        {
            ItextBox3.Enabled = true;
        }
        private void ItextBox3_TextChanged(object sender, EventArgs e)
        {
            ItextBox4.Enabled = true;
        }
        private void ItextBox4_TextChanged(object sender, EventArgs e)
        {
            ItextBox5.Enabled = true;
        }
        private void ItextBox5_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox2.SelectedItem = null;

            //comboBox2.Items.Clear();
            //foreach (FolderBase.DiplomOC.SPR_FONDRow _row in this.diplomOC1.SPR_FOND.Rows)
            //{
            //    if (_row.STREETHOUSE == comboBox1.SelectedItem.ToString())
            //        comboBox2.Items.Add(_row.NUMBERHOUSE);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application oXL;
            Excel._Workbook oWB;
            Excel._Worksheet oSheet;


            int MaxKolRight = 3;
            int MaxKolDown = 2;

            decimal index = 0;

            try
            {

                this.grremobjviewTableAdapter1.Fill(this.diplomOC1.GRREMOBJVIEW);

                foreach (FolderBase.DiplomOC.GRREMOBJVIEWRow _row in this.diplomOC1.GRREMOBJVIEW.Rows)
                {
                    index += _row.SCALESMEN;

                }

                MaxKolRight = (int)index;

                MaxKolDown += this.diplomOC1.FIN_GR_REMOBJ.Rows.Count;

                //Start Excel and get Application object.
                oXL = new Excel.Application();
                oXL.Visible = true;

                //Get a new workbook.
                oWB = (Excel._Workbook)(oXL.Workbooks.Add(Missing.Value));
                oSheet = (Excel._Worksheet)oWB.ActiveSheet;

                oSheet.get_Range("A4", GetCell(4, 9)).ColumnWidth = 20;
                oSheet.get_Range(GetCell(4, 10), GetCell(MaxKolDown, MaxKolRight + 40)).ColumnWidth = 0.5;


                //Add table headers going cell by cell.
                oSheet.Cells[1, 1] = "График составил(а):" + " " + this.ItextBox1.Text;
                oSheet.Cells[1, 10] = "Исполнитель:" + " " + ItextBox2.Text;
                oSheet.Cells[2, 5] = "Контролирующий орган:" + " " + ItextBox3.Text;

                // oSheet.Cells[1, 4] = "Утверждаю: Генеральный директор "+"________________"+textBox4.Text+"/"+textBox5.Text;


                //  oSheet.get_Range("B2", "C4").Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
                // oSheet.get_Range("C3", "M4").Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlDashDot;
                oSheet.Cells[4, 1] = "Индекс";
                oSheet.Cells[4, 2] = "Наименование работы";
                oSheet.Cells[4, 3] = "Ед. Изм.";
                oSheet.Cells[4, 4] = "Объем работ";
                oSheet.Cells[4, 5] = "Затраты труда, чел. дн.";
                oSheet.Cells[4, 6] = "Число смен";
                oSheet.Cells[4, 7] = "Численность рабочих";
                oSheet.Cells[4, 8] = "Стоимость за ед. изм.";
                oSheet.Cells[4, 9] = "Общая стоимость работ";
                oSheet.Cells[4, 10] = "Дни:";

                for (int j = 0; j < MaxKolRight; j++)
                {
                    oSheet.Cells[4, 11 + j] = j + 1;
                }

                oSheet.get_Range("A4", GetCell(4, 10)).Font.Bold = true;
                oSheet.get_Range("A1", GetCell(4, 10)).VerticalAlignment =
                    Excel.XlVAlign.xlVAlignCenter;


                int i = 5;
                foreach (FolderBase.DiplomOC.GRREMOBJVIEWRow _row in this.diplomOC1.GRREMOBJVIEW.Rows)
                {

                    oSheet.Cells[i, 1] = _row.ID;
                    oSheet.Cells[i, 2] = _row.NAMEWORK;
                    oSheet.Cells[i, 3] = _row.EDZ;
                    oSheet.Cells[i, 4] = _row.SCALEWORK;
                    oSheet.Cells[i, 5] = _row.SCALESMEN;
                    oSheet.Cells[i, 6] = _row.ZTR;
                    oSheet.Cells[i, 7] = _row.SCALEWORKER;
                    oSheet.Cells[i, 8] = _row.STOIM;
                    oSheet.Cells[i, 9] = _row.PRICE;

                    i++;
                }



                int StarCellVer = 5;


                foreach (FolderBase.DiplomOC.GRREMOBJVIEWRow _row in this.diplomOC1.GRREMOBJVIEW.Rows)
                {
                    string CellOne = string.Empty;
                    string CellTwo = string.Empty;

                    CellOne = GetCell(StarCellVer, (int)_row.STARTWORK + 10);
                    CellTwo = GetCell(StarCellVer, (int)_row.STOPWORK + 10);

                    oSheet.get_Range(CellOne, CellTwo).Interior.Color =
                        System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);


                    StarCellVer++;
                }

                DrawBorders(oSheet, "A4", GetCell(StarCellVer - 1, k + 20));

                oSheet.Cells[i + 1, 2] = "Утверждаю: Генеральный директор " + "________________" + ItextBox4.Text + "/" + ItextBox5.Text + "/______________м.п.";


                //Make sure Excel is visible and give the user control
                //of Microsoft Excel's lifetime.
                oXL.Visible = true;
                oXL.UserControl = true;
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



        private string GetCell(int Ver, int Hor)
        {
            string Cell = string.Empty;
            string[] Alf = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            int[] rasr = { 701, 1378, 2054, 2730, 3406, 4082, 4758, 5434, 6110, 6786, 7462, 8138, 8814, 9490, 10166 };

            int Ind = (int)(Hor / Alf.Length);

            if (Hor > 701)
            {
                int k = 0;

                for (int i = 0; i < rasr.Count() - 1; i++)
                    if (Hor >= rasr[i])
                        if (Hor <= rasr[i + 1])
                            k = i;

                Cell += GettCellf(k);

                Cell += GettCellf(Hor - rasr[k] + 25);

                Cell += Ver.ToString();

            }
            else
                if (Ind >= 1)
                {
                    Cell += Alf[Ind - 1];
                    Cell += Alf[Hor - (Ind * Alf.Length)];
                    Cell += Ver.ToString();
                }
                else
                    Cell = Alf[Hor] + Ver.ToString();

            return Cell;
        }
        private string GettCellf(int Hor)
        {
            string Cell = string.Empty;
            string[] Alf = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            int Ind = (int)(Hor / Alf.Length);

            if (Ind >= 1)
            {
                Cell += Alf[Ind - 1];
                Cell += Alf[Hor - (Ind * Alf.Length)];

            }
            else

                Cell = Alf[Hor];

            return Cell;
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

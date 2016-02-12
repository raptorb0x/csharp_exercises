using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;

namespace DezTEPWork.Forms.OutputForms
{
    public partial class OTSostFINCreate : Form
    {
        public OTSostFINCreate()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OTSostFINCreate_Load(object sender, EventArgs e)
        {
            this.sprfondviewTableAdapter1.Fill(this.diplomOC1.SPRFONDVIEW);
            this.vedsostviewTableAdapter1.Fill(this.diplomOC1.VEDSOSTVIEW);
            this.otsostviewTableAdapter1.Fill(this.diplomOC1.OTSOSTVIEW);
            this.sprkritviewTableAdapter1.Fill(this.diplomOC1.SPRKRITVIEW);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal KoevSos = 0;
            decimal JrRemSos = 0;

            decimal sh = 1;

            string adress = string.Empty;
            string numberhouse = string.Empty;

            this.queriesTableAdapter1.FINOTSOSTALLDELL();

            foreach (FolderBase.DiplomOC.VEDSOSTVIEWRow _VedSost in this.diplomOC1.VEDSOSTVIEW.Rows)
            {
                KoevSos = (_VedSost.WATER + _VedSost.KANAL + _VedSost.ELECTRO + _VedSost.KONSTR +
                    _VedSost.FIRE + _VedSost.WINDOW + _VedSost.ROOF)/7;

                //foreach (FolderBase.DiplomOC.SPR_FONDRow _sprFond in this.diplomOC1.SPR_FOND.Rows)
               // {
                   // if (_VedSost.ADRESS == _sprFond.CODEHOUSE)
                   // {
                        foreach (FolderBase.DiplomOC.OTSOSTVIEWRow _OtSost in this.diplomOC1.OTSOSTVIEW)
                        {

                        
                            
                             if(_VedSost.ADRESS == _OtSost.ADRESS)                                  
                                  {
                                      JrRemSos += _OtSost.COMMSCALE;
                                      sh++;
                                  }
                            
                        }

                        if(JrRemSos != 0)
                        JrRemSos = JrRemSos / sh;

                        if (KoevSos > JrRemSos)
                        {

                            string type = string.Empty;
                            decimal CodeR=0;
                       foreach (FolderBase.DiplomOC.SPRKRITVIEWRow _row in this.diplomOC1.SPRKRITVIEW.Rows)
                                if (_row.STARTS >= KoevSos)
                                    if (_row.STOPS <= KoevSos)
                                    { 
                                     CodeR = _row.ID;
                                    }

                            FolderBase.OracleWork OW = new FolderBase.OracleWork();

                            DataTable CODEH = OW.Load("SELECT CODEHOUSE FROM SPR_FOND WHERE ADRESS='"+_VedSost.ADRESS.ToString()+"'");
                            decimal _CODEH=0;

                            foreach(DataRow row in CODEH.Rows)
                                _CODEH = Convert.ToDecimal(row[0]);

                            this.fiN_OT_SOSTTableAdapter1.Insert(
                                _VedSost.ID,
                                _CODEH,
                                KoevSos,
                                CodeR);
                        
                        }
                        else                            
                        {
                            FolderBase.OracleWork OW = new FolderBase.OracleWork();
                            DataTable CODEH = OW.Load("SELECT CODEHOUSE FROM SPR_FOND WHERE ADRESS='"+_VedSost.ADRESS.ToString()+"'");
                            decimal _CODEH=0;

                            foreach(DataRow row in CODEH.Rows)
                                _CODEH = Convert.ToDecimal(row[0]);
                            
                            this.fiN_OT_SOSTTableAdapter1.Insert(
                                _VedSost.ID,
                                _CODEH,
                                JrRemSos,
                                0);
                        }
                    
                  //  }
                
              

            
            }

            this.otsostviewTableAdapter1.Fill(diplomOC1.OTSOSTVIEW);

            textBox7.Text = this.diplomOC1.OTSOSTVIEW.Rows.Count.ToString();

            decimal Pok = 999999;
            decimal Rem = 0;
            decimal Norm = 0;
            foreach (FolderBase.DiplomOC.OTSOSTFINVIEWRow _row in this.diplomOC1.OTSOSTFINVIEW.Rows)
            {
                if (_row.SCALE < Pok)
                    Pok = _row.SCALE;
                if (_row.SCALE < 5)
                    Rem++;
                else
                    Norm++;

            }

            textBox8.Text = Pok.ToString();
            textBox9.Text = Rem.ToString();
            textBox10.Text = Norm.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
        }       
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = true;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = true;
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox5.Enabled = true;
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox6.Enabled = true;
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.fiN_OT_SOSTTableAdapter1.Fill(this.diplomOC1.FIN_OT_SOST);

            OfficeClasses.WordClassWork _word = new OfficeClasses.WordClassWork();

            Word._Application oWord;
            Word._Document oDoc;

            oWord = new Word.Application();
            oWord.Visible = true;
            oDoc = oWord.Documents.Add(ref _word.oMissing, ref _word.oMissing,
                ref _word.oMissing, ref _word.oMissing);

            Word.Paragraph oPara1;
            oPara1 = oDoc.Content.Paragraphs.Add(ref _word.oMissing);

            _word.InsertParInBegDoc(oDoc, oPara1, "Отчет выполнил(а) :" + textBox1.Text);
                       
            Word.Paragraph oPara3;
            oPara3 = oDoc.Content.Paragraphs.Add(ref _word.oMissing);
            

            _word.InserTextEndDoc(oDoc,
                "                     Отчет о состоянии жилищного фонда на текущий период(ГОД)", oPara3, 16);

            Word.Paragraph oPara2;
            oPara2 = oDoc.Content.Paragraphs.Add(ref _word.oMissing);

            _word.InsertParInEndDoc(oPara2, "Организация ответсвенная за содержание жилищного фонда:" + textBox2.Text);

            Word.Paragraph oPara4;
            oPara4 = oDoc.Content.Paragraphs.Add(ref _word.oMissing);

            _word.InserTextEndDoc(oDoc, "Ниже представленны оценочные данные состояния домов после обработки документов:", oPara4, 13);


            Word.Table oTable;
            
            Word.Range wrdRng = oDoc.Bookmarks.get_Item(ref _word.oEndOfDoc).Range;
            object oRng = oDoc.Bookmarks.get_Item(ref _word.oEndOfDoc).Range;

            int kol = this.diplomOC1.OTSOSTVIEW.Rows.Count;

            oTable = oDoc.Tables.Add(wrdRng, kol,4, ref _word.oMissing, ref _word.oMissing);
            oTable.Range.ParagraphFormat.SpaceAfter = 6;

            

            int i=1;
            foreach (FolderBase.DiplomOC.OTSOSTFINVIEWRow _row in this.diplomOC1.OTSOSTFINVIEW.Rows)
            {
                _word.InsertValueIntoCell(oTable, _row.ID.ToString(), i, 1);
                _word.InsertValueIntoCell(oTable, _row.ADRESS, i, 2);
                 int kij = (int)(_row.SCALE);
                _word.InsertValueIntoCell(oTable, kij.ToString(), i, 3);
                _word.InsertValueIntoCell(oTable, _row.TYPEREM, i, 4);
                i++;
            
            }

            Word.Paragraph oPara5;
            oPara5 = oDoc.Content.Paragraphs.Add(ref _word.oMissing);

            _word.InserTextEndDoc(oDoc, "Работу фирмы контролирует:" + textBox3.Text, oPara5, 10);

            Word.Paragraph oPara6;
            oPara6 = oDoc.Content.Paragraphs.Add(ref _word.oMissing);

            _word.InserTextEndDoc(oDoc, "Контролирующее лицо от фирмы:" + textBox4.Text, oPara6, 10);

            Word.Paragraph oPara7;
            oPara7 = oDoc.Content.Paragraphs.Add(ref _word.oMissing);

            _word.InserTextEndDoc(oDoc, "Генеральный директор:" + textBox5.Text+"_____________/"+textBox6.Text, oPara7, 10);
               

            this.Close();
        }

        
        

        
    }
}
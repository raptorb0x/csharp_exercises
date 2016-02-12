using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;

namespace DezTEPWork.OfficeClasses
{
    class WordClassWork
    {
        public object oMissing = System.Reflection.Missing.Value;
	    public object oEndOfDoc = "\\endofdoc"; /* \endofdoc is a predefined bookmark */
        //Word._Application oWord;
        //Word._Document oDoc;
        //object oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
        //oPara = oDoc.Content.Paragraphs.Add(ref oRng);

    //Создание документа Ворд
        /*
    
         Word._Application oWord;
                 Word._Document oDoc;

                 oWord = new Word.Application();
                 oWord.Visible = true;
                 oDoc = oWord.Documents.Add(ref _word.oMissing, ref _word.oMissing,
                     ref _word.oMissing, ref _word.oMissing);
         */

    // Создать параграф в начале страници
    public void InsertParInBegDoc(Word._Document oDoc, Word.Paragraph oPara,string Text) 
        {
	
	
	oPara.Range.Text = Text;
	oPara.Range.Font.Bold = 1;
    oPara.Format.SpaceAfter = 24;    //24 pt spacing after paragraph.
	oPara.Range.InsertParagraphAfter();
        }

    // Вставить параграф в конце документа
    public void InsertParInEndDoc(Word.Paragraph oPara, string Text )
        {	
	
	oPara.Range.Text = Text;
	oPara.Format.SpaceAfter = 6;
	oPara.Range.InsertParagraphAfter();
        }

    public void InserTextEndDoc(Word._Document oDoc, string SampleText, Word.Paragraph oPara,int size)
    {
    // Insert another paragraph
	
     
	 oPara.Range.Text = SampleText;
	 oPara.Range.Font.Bold = 0;
     oPara.Range.Font.Size = size;
	 oPara.Format.SpaceAfter = 24;
	 oPara.Range.InsertParagraphAfter();
        }

    //Insert a r x c table, fill it with data, and make the first row
    public void InsertTable(Word._Document oDoc, int r, int c, Word.Table oTable)  
        {
    Word.Range wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;

        object oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;

	oTable = oDoc.Tables.Add(wrdRng, r, c, ref oMissing, ref oMissing);
	oTable.Range.ParagraphFormat.SpaceAfter = 6;
			
	oTable.Rows[1].Range.Font.Bold = 1;
	oTable.Rows[1].Range.Font.Italic = 1;	
        }

    // Вставка значения в яйчеку таблицы
    public void InsertValueIntoCell(Word.Table oTable,string strText, int r,int c)
    {
        oTable.Cell(r, c).Range.Text = strText;
    }
      
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Prog.NEW;

namespace Prog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try 
            {
                ora_con.ConnectionString = ora_conn;
                ora_con.Open();
                ora_con.Close();
            }
            catch (Exception Ex) { MessageBox.Show(Ex.ToString()); }
        }

        OracleConnection ora_con = new OracleConnection();
        OracleCommand command;



        string ora_conn = "DATA SOURCE=127.0.0.1:1521;PASSWORD=1234;PERSIST SECURITY INFO=True;USER ID=URR";
        
       


        private void ExecuteQuery(string txtQuery)
        {
            if (ora_con.State.ToString() != "Open")
                ora_con.Open();

            command = ora_con.CreateCommand();
            command.CommandText = txtQuery;
            command.ExecuteNonQuery();
            ora_con.Close();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dip.JRRR". При необходимости она может быть перемещена или удалена.
            this.jRRRTableAdapter.Fill(this.dip.JRRR);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dip.NACKOTVIEW". При необходимости она может быть перемещена или удалена.
            this.nACKOTVIEWTableAdapter.Fill(this.dip.NACKOTVIEW);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dip.MAGPOSTVIEW". При необходимости она может быть перемещена или удалена.
            this.mAGPOSTVIEWTableAdapter.Fill(this.dip.MAGPOSTVIEW);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dip.ZAVPOSTVIEW". При необходимости она может быть перемещена или удалена.
            this.zAVPOSTVIEWTableAdapter.Fill(this.dip.ZAVPOSTVIEW);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dip.SP_DOC". При необходимости она может быть перемещена или удалена.
            this.sP_DOCTableAdapter.Fill(this.dip.SP_DOC);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dip.SPR_WORKS". При необходимости она может быть перемещена или удалена.
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dip.VEDPVIEW". При необходимости она может быть перемещена или удалена.
            this.vEDPVIEWTableAdapter.Fill(this.dip.VEDPVIEW);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dip.VEDOSTVIEW". При необходимости она может быть перемещена или удалена.
            this.vEDOSTVIEWTableAdapter.Fill(this.dip.VEDOSTVIEW);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dip.SPPOSTVIEW". При необходимости она может быть перемещена или удалена.
            this.sPPOSTVIEWTableAdapter.Fill(this.dip.SPPOSTVIEW);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dip.SPOBJVIEW". При необходимости она может быть перемещена или удалена.
            this.sPOBJVIEWTableAdapter.Fill(this.dip.SPOBJVIEW);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dip.SPMATVIEW". При необходимости она может быть перемещена или удалена.
            this.sPMATVIEWTableAdapter.Fill(this.dip.SPMATVIEW);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dip.SPKRIT". При необходимости она может быть перемещена или удалена.
            this.sPKRITTableAdapter.Fill(this.dip.SPKRIT);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dip.SPDILVIEW". При необходимости она может быть перемещена или удалена.
            this.sPDILVIEWTableAdapter.Fill(this.dip.SPDILVIEW);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dip.LOCSVIEW". При необходимости она может быть перемещена или удалена.
           
            
            
            

        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dip.NACKOTVIEW". При необходимости она может быть перемещена или удалена.
            this.nACKOTVIEWTableAdapter.Fill(this.dip.NACKOTVIEW);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dip.MAGPOSTVIEW". При необходимости она может быть перемещена или удалена.
            this.mAGPOSTVIEWTableAdapter.Fill(this.dip.MAGPOSTVIEW);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dip.ZAVPOSTVIEW". При необходимости она может быть перемещена или удалена.
            this.zAVPOSTVIEWTableAdapter.Fill(this.dip.ZAVPOSTVIEW);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dip.SP_DOC". При необходимости она может быть перемещена или удалена.
            this.sP_DOCTableAdapter.Fill(this.dip.SP_DOC);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dip.SPR_WORKS". При необходимости она может быть перемещена или удалена.
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dip.JRRR". При необходимости она может быть перемещена или удалена.
            this.jRRRTableAdapter.Fill(this.dip.JRRR);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dip.VEDPVIEW". При необходимости она может быть перемещена или удалена.
            this.vEDPVIEWTableAdapter.Fill(this.dip.VEDPVIEW);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dip.VEDOSTVIEW". При необходимости она может быть перемещена или удалена.
            this.vEDOSTVIEWTableAdapter.Fill(this.dip.VEDOSTVIEW);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dip.SPPOSTVIEW". При необходимости она может быть перемещена или удалена.
            this.sPPOSTVIEWTableAdapter.Fill(this.dip.SPPOSTVIEW);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dip.SPOBJVIEW". При необходимости она может быть перемещена или удалена.
            this.sPOBJVIEWTableAdapter.Fill(this.dip.SPOBJVIEW);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dip.SPMATVIEW". При необходимости она может быть перемещена или удалена.
            this.sPMATVIEWTableAdapter.Fill(this.dip.SPMATVIEW);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dip.SPKRIT". При необходимости она может быть перемещена или удалена.
            this.sPKRITTableAdapter.Fill(this.dip.SPKRIT);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dip.SPDILVIEW". При необходимости она может быть перемещена или удалена.
            this.sPDILVIEWTableAdapter.Fill(this.dip.SPDILVIEW);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dip.LOCSVIEW". При необходимости она может быть перемещена или удалена.
           
        }
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
              if (this.MdiChildren[i].Text == e.Node.Text)
                {
                    this.MdiChildren[i].Activate();
                    return;
                }
           
            ViewForm newf =  new ViewForm();
            Classes.Documents Doc;
           
            
            switch(e.Node.Name)
            {
                case "S1":
                
                Doc = new Classes.SPMAT();
                newf = new ViewForm(sPMATVIEWBindingSource, e.Node.Text,Doc);                
 
                break;

                case "S2":

                Doc = new Classes.SPPOST();
                newf = new ViewForm(sPPOSTVIEWBindingSource, e.Node.Text,Doc);                

                break;

                case "S3":
                
                Doc = new Classes.SPDIL();
                newf = new ViewForm(sPDILVIEWBindingSource, e.Node.Text,Doc);
                
  
                break;

                case "S4":

                Doc = new Classes.SPKRIT();
                newf = new ViewForm(sPKRITBindingSource, e.Node.Text,Doc);
               
                
                break;

                case "S6":

                Doc = new Classes.SPROBJ();
                newf = new ViewForm(sPOBJVIEWBindingSource, e.Node.Text,Doc);
                
                break;
                
                case "S7":

                Doc = new NEW.Class.SPDOC();
                newf = new ViewForm(SP_DOC, e.Node.Text, Doc);

                break;

                case "R1":
                Doc = new Classes.VEDP();
                newf = new ViewForm(vEDPVIEWBindingSource, e.Node.Text,Doc);
                
                break;

                

                case "R3":

                Doc = new Classes.VEDSOS();  
                newf = new ViewForm(vEDOSTVIEWBindingSource, e.Node.Text,Doc);
                     
                break;
                
                case "R4":

                Doc = new NEW.Class.ZAVPOST();
                newf = new ViewForm(ZAVPOSTVIEW, e.Node.Text, Doc);

                break;

                case "R5":

                Doc = new NEW.Class.MAGPOST();
                newf = new ViewForm(MAGPOSTVIEW, e.Node.Text, Doc);

                break;

                case "R6":

                Doc = new NEW.Class.NACKOT();
                newf = new ViewForm(NACKOTVIEW, e.Node.Text, Doc);

                break;
                
                case "R7":

                Doc = new NEW.Clasess.JRRR();
                newf = new ViewForm(JRRR, e.Node.Text, Doc);

                break;
                
                default: return;      


            }

            newf.MdiParent = this;
            newf.Show();
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ведомостиПотребностейМатериаловНаГодToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vedomost newf = new Vedomost();
            newf.ShowDialog();
        }
        private void выполнитЗапросКБазеДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zapr newf = new Zapr();
            newf.MdiParent = this;
            newf.Show();
        }
        private void ведомостьЗакупокМатериаловНаГодToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zakup newf = new Zakup();
            newf.ShowDialog();

        }
        private void ведомостьПоставщиковНаКаждыйВидМТРToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VedMTPPOst newf = new VedMTPPOst();
            newf.ShowDialog();
            
        }
        private void ведомостьЗакупаемыхМатериаловУПоставщиковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VedZakPost newf = new VedZakPost();
            newf.ShowDialog();

            
        }
        private void REFRSBUT_Click(object sender, EventArgs e)
        {
         
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dip.VEDPVIEW". При необходимости она может быть перемещена или удалена.
            this.vEDPVIEWTableAdapter.Fill(this.dip.VEDPVIEW);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dip.VEDOSTVIEW". При необходимости она может быть перемещена или удалена.
            this.vEDOSTVIEWTableAdapter.Fill(this.dip.VEDOSTVIEW);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dip.SPPOSTVIEW". При необходимости она может быть перемещена или удалена.
            this.sPPOSTVIEWTableAdapter.Fill(this.dip.SPPOSTVIEW);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dip.SPOBJVIEW". При необходимости она может быть перемещена или удалена.
            this.sPOBJVIEWTableAdapter.Fill(this.dip.SPOBJVIEW);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dip.SPMATVIEW". При необходимости она может быть перемещена или удалена.
            this.sPMATVIEWTableAdapter.Fill(this.dip.SPMATVIEW);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dip.SPKRIT". При необходимости она может быть перемещена или удалена.
            this.sPKRITTableAdapter.Fill(this.dip.SPKRIT);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dip.SPDILVIEW". При необходимости она может быть перемещена или удалена.
            this.sPDILVIEWTableAdapter.Fill(this.dip.SPDILVIEW);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dip.LOCSVIEW". При необходимости она может быть перемещена или удалена.
           
        }
        private void графикПоставкиМТРToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prog.OUT2.GRAFPOSTMAT newf = new OUT2.GRAFPOSTMAT();
            newf.ShowDialog();
        }
        private void графикДвиженияМатериаловToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prog.OUT2.VEDDVIJMAT newf = new OUT2.VEDDVIJMAT();
            newf.ShowDialog();
        }
        private void графикПоставкиДляПоставщикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OUT2.OTKLGRAPHMAT newf = new OUT2.OTKLGRAPHMAT();
            newf.ShowDialog();
           
        }
        private void претензииКПоставщикамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OUT2.PRETPOST newf = new OUT2.PRETPOST();
            newf.ShowDialog();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        

       
    }
}

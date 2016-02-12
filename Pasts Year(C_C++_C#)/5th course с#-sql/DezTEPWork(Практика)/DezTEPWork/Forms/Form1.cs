using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace DezTEPWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        #region Верхнее меню

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm newf = new HelpForm();
              newf.ShowDialog();
        }
        private void справочникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SPRFormAdministr newf = new SPRFormAdministr();
                newf.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.grremobjvieW1TableAdapter1.Fill(this.diplomOC.GRREMOBJVIEW1);
            this.grremovieW1TableAdapter1.Fill(this.diplomOC.GRREMOVIEW1);
            this.jrremmsvieW1TableAdapter1.Fill(this.diplomOC.JRREMMSVIEW1);
            this.otsostfinvieW1TableAdapter1.Fill(this.diplomOC.OTSOSTFINVIEW1);
            this.otsostvieW1TableAdapter1.Fill(this.diplomOC.OTSOSTVIEW1);
            this.plremvieW1TableAdapter1.Fill(this.diplomOC.PLREMVIEW1);
            this.vedsostvieW1TableAdapter1.Fill(this.diplomOC.VEDSOSTVIEW1);

        }

        #endregion




        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Name == "R1")
            {
                
                
                dataGridView1.DataSource = VEDSOST;
                dataGridView1.Enabled = true;
                InsertButton.Enabled = true;
                DeleteButton.Enabled = true;
                EditButton.Enabled = true;
                
                DelebuttonsEvent();

                Interface.WorkDocInter _work = new Classes.WorkVedSost();
                EventClick(_work);
             
            }
            if (e.Node.Name == "R2")
            {
                DelebuttonsEvent();
                
                dataGridView1.DataSource = OTSOST;
                dataGridView1.Enabled = true;
                InsertButton.Enabled = true;
                DeleteButton.Enabled = true;
                EditButton.Enabled = true;

                Interface.WorkDocInter _work = new Classes.WorkOtSost();
                EventClick(_work);
                
            }
            if (e.Node.Name == "R3")
            {
                DelebuttonsEvent();
                
                dataGridView1.DataSource = JRREMMS;
                dataGridView1.Enabled = true;
                InsertButton.Enabled = true;
                DeleteButton.Enabled = true;
                EditButton.Enabled = true;

                Interface.WorkDocInter _work = new Classes.WorkJrRem() ;
                EventClick(_work);
               
            }
            if (e.Node.Name == "R4")
            {
                DelebuttonsEvent();

                dataGridView1.DataSource = PLREMYEAR;
                dataGridView1.Enabled = true;
                InsertButton.Enabled = true;
                DeleteButton.Enabled = true;
                EditButton.Enabled = true;

                Interface.WorkDocInter _work = new Classes.WorkPlRemYear();
                EventClick(_work);
                
            }
            if (e.Node.Name == "V1")
            {
              
                
                dataGridView1.DataSource = OTSOSTFIN;
                dataGridView1.ReadOnly = true;
                InsertButton.Enabled = false;
                DeleteButton.Enabled = false;
                EditButton.Enabled = false;
                
            }
            if (e.Node.Name == "V2")
            {
                
                
                dataGridView1.DataSource = GROREM;
                dataGridView1.ReadOnly = true;
                InsertButton.Enabled = false;
                DeleteButton.Enabled = false;
                EditButton.Enabled = false;
               
            }
            if (e.Node.Name == "V3")
            {
                
                
                dataGridView1.DataSource = GRREMOBJ;
                dataGridView1.ReadOnly = true;
                InsertButton.Enabled = false;
                DeleteButton.Enabled = false;
                EditButton.Enabled = false;
                
            }
        }
        private void EventClick(Interface.WorkDocInter  wr)
        {
            InsertButton.Click += wr.InsertIntoTable;
            DeleteButton.Click += wr.DeleteIntoTable;
            EditButton.Click += wr.EditTable;
        }        
        private void DelebuttonsEvent()
        {
            RemoveClickEvent(InsertButton);
            RemoveClickEvent(DeleteButton);
            RemoveClickEvent(EditButton);
           
        }        
        private void RemoveClickEvent(Button b)
        {
            FieldInfo f1 = typeof(Control).GetField("EventClick",
                BindingFlags.Static | BindingFlags.NonPublic);
            object obj = f1.GetValue(b);
            PropertyInfo pi = b.GetType().GetProperty("Events",
                BindingFlags.NonPublic | BindingFlags.Instance);
            EventHandlerList list = (EventHandlerList)pi.GetValue(b, null);
            list.RemoveHandler(obj, list[obj]);
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            this.grremobjvieW1TableAdapter1.Fill(this.diplomOC.GRREMOBJVIEW1);
            this.grremovieW1TableAdapter1.Fill(this.diplomOC.GRREMOVIEW1);
            this.jrremmsvieW1TableAdapter1.Fill(this.diplomOC.JRREMMSVIEW1);
            this.otsostfinvieW1TableAdapter1.Fill(this.diplomOC.OTSOSTFINVIEW1);
            this.otsostvieW1TableAdapter1.Fill(this.diplomOC.OTSOSTVIEW1);
            this.plremvieW1TableAdapter1.Fill(this.diplomOC.PLREMVIEW1);
            this.vedsostvieW1TableAdapter1.Fill(this.diplomOC.VEDSOSTVIEW1);
            
        }

        private void графикОчередиРемонтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.OutputForms.GrORemCreate newf = new Forms.OutputForms.GrORemCreate();
             newf.ShowDialog();
        }
        private void отчетСостоянияЖилищногоФондаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Forms.OutputForms.OTSostFINCreate newf = new Forms.OutputForms.OTSostFINCreate();
                newf.ShowDialog();
            }
            catch (Exception Ex) { MessageBox.Show(Ex.ToString()); }
        }
        private void графикРемонтаОбъектаЖилищногоФондаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.OutputForms.GrRemObjCreate newf = new Forms.OutputForms.GrRemObjCreate();
            newf.ShowDialog();
        }
               

       
    }
}

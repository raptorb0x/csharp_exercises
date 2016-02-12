using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prog
{
    internal partial class ViewForm : Form
    {
      internal ViewForm(BindingSource bs,string Name,Classes.Documents _Doc)
        {
            InitializeComponent();
            dataGridView1.DataSource = bs;
            this.Text = Name;            
            Doc = _Doc;
            _Name = Name;
        }
      
        internal ViewForm(BindingSource bs, string Name)
      {
          InitializeComponent();
          dataGridView1.DataSource = bs;
          _Name = Name;
          this.Text = Name;
      }
        public ViewForm() {    } //Пустой конструктор


        string _Name = "";
        Classes.Documents Doc;        
       

        

        private void ViewForm_Activated(object sender, EventArgs e)
        {
            if (_Name != "Ведомость на закупку МТР")
            {
                Program._Form1.INSBUT.Click += Doc.Insert;
                Program._Form1.DELBUT.Click += Doc.Delete;
                Program._Form1.UPBUT.Click += Doc.Update;
            }
        }

        private void ViewForm_Deactivate(object sender, EventArgs e)
        {
            if (_Name != "Ведомость на закупку МТР")
            {
                Program._Form1.INSBUT.Click -= Doc.Insert;
                Program._Form1.DELBUT.Click -= Doc.Delete;
                Program._Form1.UPBUT.Click -= Doc.Update;
            }
        }


    }
}

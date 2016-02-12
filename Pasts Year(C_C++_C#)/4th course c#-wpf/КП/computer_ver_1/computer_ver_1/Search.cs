using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace computer_ver_1
{
    public partial class Search : Form
    {
        //private Dictionary<string, object> _dict = new Dictionary<string, object>();
        public string th;
        public string cn;
        public string p;
        public Search()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxTH.Text.Length > 0)
                th = textBoxTH.Text;
                //_dict.Add("TypeHardWare", textBoxTH.Text);
            if (textBoxCN.Text.Length > 0)
                cn = textBoxCN.Text;
                //_dict.Add("CompanyName", textBoxCN.Text);
            p = "ok";
            Close();
        }

        public string ComN
        {
            get { return cn; }
            set { cn = value; }
        }
        public string TypeHW
        {
            get { return th; }
            set { th = value; }
        }

        public string Pr
        {
            get { return p; }
            set { p = value; }
        }
    }
}

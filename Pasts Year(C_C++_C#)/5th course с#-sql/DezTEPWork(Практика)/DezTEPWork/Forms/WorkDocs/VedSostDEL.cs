﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DezTEPWork.Forms.WorkDocs
{
    public partial class VedSostDEL : Form
    {
        public VedSostDEL()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            queriesTableAdapter1.VEDSOSTDEL(Convert.ToDecimal(textBox1.Text));

            this.Close();
        }

       
    }
}

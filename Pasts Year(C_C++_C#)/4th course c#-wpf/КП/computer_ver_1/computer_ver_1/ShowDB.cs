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
    public partial class ShowDB : Form
    {
        public ShowDB()
        {
            InitializeComponent();
        }

        private void dataGridViewShowDB_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex % 2 != 0)
                dataGridViewShowDB.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(255)))), ((int)(((byte)(240))))); //раскрашиваем строки через одну
        }
    }
}

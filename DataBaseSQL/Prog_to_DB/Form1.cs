using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_to_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataBaseSQLDataSet.Student_view' table. You can move, or remove it, as needed.
            this.student_viewTableAdapter.Fill(this.dataBaseSQLDataSet.Student_view);
            // TODO: This line of code loads data into the 'dataBaseSQLDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.dataBaseSQLDataSet.Student);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //label1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            label1.Text = queriesTableAdapter1.F_Averange_grade((int)dataGridView1.CurrentRow.Cells[0].Value).ToString();
        }
    }
}

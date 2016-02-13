namespace Prog_to_DB
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseSQLDataSet = new Prog_to_DB.DataBaseSQLDataSet();
            this.studentTableAdapter = new Prog_to_DB.DataBaseSQLDataSetTableAdapters.StudentTableAdapter();
            this.studentviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_viewTableAdapter = new Prog_to_DB.DataBaseSQLDataSetTableAdapters.Student_viewTableAdapter();
            this.номерСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.институтDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.queriesTableAdapter1 = new Prog_to_DB.DataBaseSQLDataSetTableAdapters.QueriesTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseSQLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentviewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерСтудентаDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.институтDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentviewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(735, 285);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.dataBaseSQLDataSet;
            // 
            // dataBaseSQLDataSet
            // 
            this.dataBaseSQLDataSet.DataSetName = "DataBaseSQLDataSet";
            this.dataBaseSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // studentviewBindingSource
            // 
            this.studentviewBindingSource.DataMember = "Student_view";
            this.studentviewBindingSource.DataSource = this.dataBaseSQLDataSet;
            // 
            // student_viewTableAdapter
            // 
            this.student_viewTableAdapter.ClearBeforeFill = true;
            // 
            // номерСтудентаDataGridViewTextBoxColumn
            // 
            this.номерСтудентаDataGridViewTextBoxColumn.DataPropertyName = "Номер студента";
            this.номерСтудентаDataGridViewTextBoxColumn.HeaderText = "Номер студента";
            this.номерСтудентаDataGridViewTextBoxColumn.Name = "номерСтудентаDataGridViewTextBoxColumn";
            this.номерСтудентаDataGridViewTextBoxColumn.ReadOnly = true;
            this.номерСтудентаDataGridViewTextBoxColumn.Width = 105;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.ReadOnly = true;
            this.имяDataGridViewTextBoxColumn.Width = 54;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.ReadOnly = true;
            this.фамилияDataGridViewTextBoxColumn.Width = 81;
            // 
            // институтDataGridViewTextBoxColumn
            // 
            this.институтDataGridViewTextBoxColumn.DataPropertyName = "Институт";
            this.институтDataGridViewTextBoxColumn.HeaderText = "Институт";
            this.институтDataGridViewTextBoxColumn.Name = "институтDataGridViewTextBoxColumn";
            this.институтDataGridViewTextBoxColumn.ReadOnly = true;
            this.институтDataGridViewTextBoxColumn.Width = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "!выберите студента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "средняя оценка выбраного студента";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 442);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseSQLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentviewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataBaseSQLDataSet dataBaseSQLDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private DataBaseSQLDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource studentviewBindingSource;
        private DataBaseSQLDataSetTableAdapters.Student_viewTableAdapter student_viewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерСтудентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn институтDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private DataBaseSQLDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.Label label2;
    }
}


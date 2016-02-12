namespace DezTEPWork.Forms.OutputForms
{
    partial class GrORemCreate
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OtextBox2 = new System.Windows.Forms.TextBox();
            this.OtextBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.diplomOC1 = new DezTEPWork.FolderBase.DiplomOC();
            this.otsostfinviewTableAdapter1 = new DezTEPWork.FolderBase.DiplomOCTableAdapters.OTSOSTFINVIEWTableAdapter();
            this.jrremmsviewTableAdapter1 = new DezTEPWork.FolderBase.DiplomOCTableAdapters.JRREMMSVIEWTableAdapter();
            this.plremviewTableAdapter1 = new DezTEPWork.FolderBase.DiplomOCTableAdapters.PLREMVIEWTableAdapter();
            this.sprprorabviewTableAdapter1 = new DezTEPWork.FolderBase.DiplomOCTableAdapters.SPRPRORABVIEWTableAdapter();
            this.queriesTableAdapter1 = new DezTEPWork.FolderBase.DiplomOCTableAdapters.QueriesTableAdapter();
            this.pL_REMYEARTableAdapter1 = new DezTEPWork.FolderBase.DiplomOCTableAdapters.PL_REMYEARTableAdapter();
            this.fiN_GR_OREMTableAdapter1 = new DezTEPWork.FolderBase.DiplomOCTableAdapters.FIN_GR_OREMTableAdapter();
            this.fiN_OT_SOSTTableAdapter1 = new DezTEPWork.FolderBase.DiplomOCTableAdapters.FIN_OT_SOSTTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diplomOC1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(285, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(366, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.OtextBox2);
            this.groupBox1.Controls.Add(this.OtextBox1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(285, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 168);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные отчета";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Общая \r\nпродолжительность: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество домов \r\nв графике:";
            // 
            // OtextBox2
            // 
            this.OtextBox2.Location = new System.Drawing.Point(50, 99);
            this.OtextBox2.Name = "OtextBox2";
            this.OtextBox2.ReadOnly = true;
            this.OtextBox2.Size = new System.Drawing.Size(100, 20);
            this.OtextBox2.TabIndex = 2;
            // 
            // OtextBox1
            // 
            this.OtextBox1.Location = new System.Drawing.Point(50, 47);
            this.OtextBox1.Name = "OtextBox1";
            this.OtextBox1.ReadOnly = true;
            this.OtextBox1.Size = new System.Drawing.Size(100, 20);
            this.OtextBox1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(50, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 26);
            this.button3.TabIndex = 0;
            this.button3.Text = "Расчитать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "График составил(а):";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(12, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(267, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Фирма ответсвенная за содержание домов:";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(12, 112);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(267, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Контролирующий орган:";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(12, 152);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(267, 20);
            this.textBox4.TabIndex = 10;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Генеральный директор:";
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(12, 200);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(267, 20);
            this.textBox5.TabIndex = 12;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Дата:";
            // 
            // diplomOC1
            // 
            this.diplomOC1.DataSetName = "DiplomOC";
            this.diplomOC1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // otsostfinviewTableAdapter1
            // 
            this.otsostfinviewTableAdapter1.ClearBeforeFill = true;
            // 
            // jrremmsviewTableAdapter1
            // 
            this.jrremmsviewTableAdapter1.ClearBeforeFill = true;
            // 
            // plremviewTableAdapter1
            // 
            this.plremviewTableAdapter1.ClearBeforeFill = true;
            // 
            // sprprorabviewTableAdapter1
            // 
            this.sprprorabviewTableAdapter1.ClearBeforeFill = true;
            // 
            // pL_REMYEARTableAdapter1
            // 
            this.pL_REMYEARTableAdapter1.ClearBeforeFill = true;
            // 
            // fiN_GR_OREMTableAdapter1
            // 
            this.fiN_GR_OREMTableAdapter1.ClearBeforeFill = true;
            // 
            // fiN_OT_SOSTTableAdapter1
            // 
            this.fiN_OT_SOSTTableAdapter1.ClearBeforeFill = true;
            // 
            // GrORemCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 232);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "GrORemCreate";
            this.Text = "График очереди ремонта на заданный перод";
            this.Load += new System.EventHandler(this.GrORemCreate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diplomOC1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OtextBox2;
        private System.Windows.Forms.TextBox OtextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;

        private FolderBase.DiplomOC diplomOC1;
        private FolderBase.DiplomOCTableAdapters.OTSOSTFINVIEWTableAdapter otsostfinviewTableAdapter1;
        private FolderBase.DiplomOCTableAdapters.JRREMMSVIEWTableAdapter jrremmsviewTableAdapter1;
        private FolderBase.DiplomOCTableAdapters.PLREMVIEWTableAdapter plremviewTableAdapter1;
        private FolderBase.DiplomOCTableAdapters.SPRPRORABVIEWTableAdapter sprprorabviewTableAdapter1;
        private FolderBase.DiplomOCTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private FolderBase.DiplomOCTableAdapters.PL_REMYEARTableAdapter pL_REMYEARTableAdapter1;
        private FolderBase.DiplomOCTableAdapters.FIN_GR_OREMTableAdapter fiN_GR_OREMTableAdapter1;
        private FolderBase.DiplomOCTableAdapters.FIN_OT_SOSTTableAdapter fiN_OT_SOSTTableAdapter1;
       
    }
}
namespace DezTEPWork.Forms.OutputForms
{
    partial class GrRemObjCreate
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
            this.diplomOC1 = new DezTEPWork.FolderBase.DiplomOC();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.OtextBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OtextBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ItextBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ItextBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ItextBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ItextBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ItextBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sprorabviewTableAdapter1 = new DezTEPWork.FolderBase.DiplomOCTableAdapters.SPRORABVIEWTableAdapter();
            this.grremoviewTableAdapter1 = new DezTEPWork.FolderBase.DiplomOCTableAdapters.GRREMOVIEWTableAdapter();
            this.fiN_GR_REMOBJTableAdapter1 = new DezTEPWork.FolderBase.DiplomOCTableAdapters.FIN_GR_REMOBJTableAdapter();
            this.sprworksviewTableAdapter1 = new DezTEPWork.FolderBase.DiplomOCTableAdapters.SPRWORKSVIEWTableAdapter();
            this.sprtarifviewTableAdapter1 = new DezTEPWork.FolderBase.DiplomOCTableAdapters.SPRTARIFVIEWTableAdapter();
            this.sprposledTableAdapter1 = new DezTEPWork.FolderBase.DiplomOCTableAdapters.SPRPOSLEDTableAdapter();
            this.queriesTableAdapter1 = new DezTEPWork.FolderBase.DiplomOCTableAdapters.QueriesTableAdapter();
            this.grremobjviewTableAdapter1 = new DezTEPWork.FolderBase.DiplomOCTableAdapters.GRREMOBJVIEWTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.diplomOC1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // diplomOC1
            // 
            this.diplomOC1.DataSetName = "DiplomOC";
            this.diplomOC1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор объекта и исполнителей:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Количество бригад:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox3.Location = new System.Drawing.Point(136, 73);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(79, 21);
            this.comboBox3.TabIndex = 4;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Улица:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(96, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.OtextBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.OtextBox1);
            this.groupBox2.Location = new System.Drawing.Point(5, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 126);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация о графике";
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(132, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Расчитать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Продолжительность:";
            // 
            // OtextBox2
            // 
            this.OtextBox2.Location = new System.Drawing.Point(133, 64);
            this.OtextBox2.Name = "OtextBox2";
            this.OtextBox2.ReadOnly = true;
            this.OtextBox2.Size = new System.Drawing.Size(90, 20);
            this.OtextBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Работ в графике:";
            // 
            // OtextBox1
            // 
            this.OtextBox1.Location = new System.Drawing.Point(132, 37);
            this.OtextBox1.Name = "OtextBox1";
            this.OtextBox1.ReadOnly = true;
            this.OtextBox1.Size = new System.Drawing.Size(90, 20);
            this.OtextBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ItextBox5);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.ItextBox4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.ItextBox3);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.ItextBox2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.ItextBox1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(259, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(195, 239);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Информация о составителе:";
            // 
            // ItextBox5
            // 
            this.ItextBox5.Enabled = false;
            this.ItextBox5.Location = new System.Drawing.Point(12, 210);
            this.ItextBox5.Name = "ItextBox5";
            this.ItextBox5.Size = new System.Drawing.Size(177, 20);
            this.ItextBox5.TabIndex = 22;
            this.ItextBox5.TextChanged += new System.EventHandler(this.ItextBox5_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Дата:";
            // 
            // ItextBox4
            // 
            this.ItextBox4.Enabled = false;
            this.ItextBox4.Location = new System.Drawing.Point(12, 162);
            this.ItextBox4.Name = "ItextBox4";
            this.ItextBox4.Size = new System.Drawing.Size(177, 20);
            this.ItextBox4.TabIndex = 20;
            this.ItextBox4.TextChanged += new System.EventHandler(this.ItextBox4_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Генеральный директор:";
            // 
            // ItextBox3
            // 
            this.ItextBox3.Enabled = false;
            this.ItextBox3.Location = new System.Drawing.Point(12, 122);
            this.ItextBox3.Name = "ItextBox3";
            this.ItextBox3.Size = new System.Drawing.Size(177, 20);
            this.ItextBox3.TabIndex = 18;
            this.ItextBox3.TextChanged += new System.EventHandler(this.ItextBox3_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Заказчик:";
            // 
            // ItextBox2
            // 
            this.ItextBox2.Enabled = false;
            this.ItextBox2.Location = new System.Drawing.Point(12, 78);
            this.ItextBox2.Name = "ItextBox2";
            this.ItextBox2.Size = new System.Drawing.Size(177, 20);
            this.ItextBox2.TabIndex = 16;
            this.ItextBox2.TextChanged += new System.EventHandler(this.ItextBox2_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Подрядчик:";
            // 
            // ItextBox1
            // 
            this.ItextBox1.Location = new System.Drawing.Point(12, 37);
            this.ItextBox1.Name = "ItextBox1";
            this.ItextBox1.Size = new System.Drawing.Size(177, 20);
            this.ItextBox1.TabIndex = 14;
            this.ItextBox1.TextChanged += new System.EventHandler(this.ItextBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "График составил(а):";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(271, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(371, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sprorabviewTableAdapter1
            // 
            this.sprorabviewTableAdapter1.ClearBeforeFill = true;
            // 
            // grremoviewTableAdapter1
            // 
            this.grremoviewTableAdapter1.ClearBeforeFill = true;
            // 
            // fiN_GR_REMOBJTableAdapter1
            // 
            this.fiN_GR_REMOBJTableAdapter1.ClearBeforeFill = true;
            // 
            // sprworksviewTableAdapter1
            // 
            this.sprworksviewTableAdapter1.ClearBeforeFill = true;
            // 
            // sprtarifviewTableAdapter1
            // 
            this.sprtarifviewTableAdapter1.ClearBeforeFill = true;
            // 
            // sprposledTableAdapter1
            // 
            this.sprposledTableAdapter1.ClearBeforeFill = true;
            // 
            // grremobjviewTableAdapter1
            // 
            this.grremobjviewTableAdapter1.ClearBeforeFill = true;
            // 
            // GrRemObjCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 289);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GrRemObjCreate";
            this.Text = "Формирование графика ремонта объекта жилищного фонда";
            this.Load += new System.EventHandler(this.GrRemObjCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diplomOC1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FolderBase.DiplomOC diplomOC1;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OtextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OtextBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox ItextBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ItextBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ItextBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ItextBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ItextBox1;
        private System.Windows.Forms.Label label10;
        private FolderBase.DiplomOCTableAdapters.SPRORABVIEWTableAdapter sprorabviewTableAdapter1;
        private FolderBase.DiplomOCTableAdapters.GRREMOVIEWTableAdapter grremoviewTableAdapter1;
        private FolderBase.DiplomOCTableAdapters.FIN_GR_REMOBJTableAdapter fiN_GR_REMOBJTableAdapter1;
        private FolderBase.DiplomOCTableAdapters.SPRWORKSVIEWTableAdapter sprworksviewTableAdapter1;
        private FolderBase.DiplomOCTableAdapters.SPRTARIFVIEWTableAdapter sprtarifviewTableAdapter1;
        private FolderBase.DiplomOCTableAdapters.SPRPOSLEDTableAdapter sprposledTableAdapter1;
        private FolderBase.DiplomOCTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private FolderBase.DiplomOCTableAdapters.GRREMOBJVIEWTableAdapter grremobjviewTableAdapter1;
        
    }
}
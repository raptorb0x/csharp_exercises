namespace DezTEPWork
{
    partial class SPRFormAdministr
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.diplomOC = new DezTEPWork.FolderBase.DiplomOC();
            this.sPRFONDKVVIEW1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPRFONDKVVIEW1TableAdapter = new DezTEPWork.FolderBase.DiplomOCTableAdapters.SPRFONDKVVIEW1TableAdapter();
            this.tableAdapterManager = new DezTEPWork.FolderBase.DiplomOCTableAdapters.TableAdapterManager();
            this.sPRFONDVIEW1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPRFONDVIEW1TableAdapter = new DezTEPWork.FolderBase.DiplomOCTableAdapters.SPRFONDVIEW1TableAdapter();
            this.sPRKRITVIEW1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPRKRITVIEW1TableAdapter = new DezTEPWork.FolderBase.DiplomOCTableAdapters.SPRKRITVIEW1TableAdapter();
            this.sPRORABVIEW1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPRORABVIEW1TableAdapter = new DezTEPWork.FolderBase.DiplomOCTableAdapters.SPRORABVIEW1TableAdapter();
            this.sPRPOSLED1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPRPOSLED1TableAdapter = new DezTEPWork.FolderBase.DiplomOCTableAdapters.SPRPOSLED1TableAdapter();
            this.sPRPRORABVIEW1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPRPRORABVIEW1TableAdapter = new DezTEPWork.FolderBase.DiplomOCTableAdapters.SPRPRORABVIEW1TableAdapter();
            this.sPRTARIFVIEW1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPRTARIFVIEW1TableAdapter = new DezTEPWork.FolderBase.DiplomOCTableAdapters.SPRTARIFVIEW1TableAdapter();
            this.sPRWORKSVIEW1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPRWORKSVIEW1TableAdapter = new DezTEPWork.FolderBase.DiplomOCTableAdapters.SPRWORKSVIEW1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRFONDKVVIEW1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRFONDVIEW1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRKRITVIEW1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRORABVIEW1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRPOSLED1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRPRORABVIEW1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRTARIFVIEW1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRWORKSVIEW1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Справочник домов",
            "Справочник критериев",
            "Справочник тарифов на производство работ",
            "Нормативы производства работ",
            "Справочник объемов работ",
            "Справочник последовательности производства работ",
            "Справочник продолжительности производства работ при ремонте объекта жилищного фон" +
                "да"});
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 173);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Вставить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 308);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 33);
            this.button4.TabIndex = 4;
            this.button4.Text = "Помощь";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 347);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 33);
            this.button5.TabIndex = 5;
            this.button5.Text = "Закрыть";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(138, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(524, 368);
            this.dataGridView1.TabIndex = 6;
            // 
            // diplomOC
            // 
            this.diplomOC.DataSetName = "DiplomOC";
            this.diplomOC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPRFONDKVVIEW1BindingSource
            // 
            this.sPRFONDKVVIEW1BindingSource.DataMember = "SPRFONDKVVIEW1";
            this.sPRFONDKVVIEW1BindingSource.DataSource = this.diplomOC;
            // 
            // sPRFONDKVVIEW1TableAdapter
            // 
            this.sPRFONDKVVIEW1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.FIN_GR_OREMTableAdapter = null;
            this.tableAdapterManager.FIN_GR_REMOBJTableAdapter = null;
            this.tableAdapterManager.FIN_OT_SOSTTableAdapter = null;
            this.tableAdapterManager.JR_REMMSTableAdapter = null;
            this.tableAdapterManager.OT_SOSTTableAdapter = null;
            this.tableAdapterManager.PL_REMYEARTableAdapter = null;
            this.tableAdapterManager.SPR_CRITTableAdapter = null;
            this.tableAdapterManager.SPR_FONDKVTableAdapter = null;
            this.tableAdapterManager.SPR_FONDTableAdapter = null;
            this.tableAdapterManager.SPR_ORABTableAdapter = null;
            this.tableAdapterManager.SPR_POSLEDTableAdapter = null;
            this.tableAdapterManager.SPR_PRORABTableAdapter = null;
            this.tableAdapterManager.SPR_TARIFTableAdapter = null;
            this.tableAdapterManager.SPR_WORKSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DezTEPWork.FolderBase.DiplomOCTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VED_SOSTTableAdapter = null;
            // 
            // sPRFONDVIEW1BindingSource
            // 
            this.sPRFONDVIEW1BindingSource.DataMember = "SPRFONDVIEW1";
            this.sPRFONDVIEW1BindingSource.DataSource = this.diplomOC;
            // 
            // sPRFONDVIEW1TableAdapter
            // 
            this.sPRFONDVIEW1TableAdapter.ClearBeforeFill = true;
            // 
            // sPRKRITVIEW1BindingSource
            // 
            this.sPRKRITVIEW1BindingSource.DataMember = "SPRKRITVIEW1";
            this.sPRKRITVIEW1BindingSource.DataSource = this.diplomOC;
            // 
            // sPRKRITVIEW1TableAdapter
            // 
            this.sPRKRITVIEW1TableAdapter.ClearBeforeFill = true;
            // 
            // sPRORABVIEW1BindingSource
            // 
            this.sPRORABVIEW1BindingSource.DataMember = "SPRORABVIEW1";
            this.sPRORABVIEW1BindingSource.DataSource = this.diplomOC;
            // 
            // sPRORABVIEW1TableAdapter
            // 
            this.sPRORABVIEW1TableAdapter.ClearBeforeFill = true;
            // 
            // sPRPOSLED1BindingSource
            // 
            this.sPRPOSLED1BindingSource.DataMember = "SPRPOSLED1";
            this.sPRPOSLED1BindingSource.DataSource = this.diplomOC;
            // 
            // sPRPOSLED1TableAdapter
            // 
            this.sPRPOSLED1TableAdapter.ClearBeforeFill = true;
            // 
            // sPRPRORABVIEW1BindingSource
            // 
            this.sPRPRORABVIEW1BindingSource.DataMember = "SPRPRORABVIEW1";
            this.sPRPRORABVIEW1BindingSource.DataSource = this.diplomOC;
            // 
            // sPRPRORABVIEW1TableAdapter
            // 
            this.sPRPRORABVIEW1TableAdapter.ClearBeforeFill = true;
            // 
            // sPRTARIFVIEW1BindingSource
            // 
            this.sPRTARIFVIEW1BindingSource.DataMember = "SPRTARIFVIEW1";
            this.sPRTARIFVIEW1BindingSource.DataSource = this.diplomOC;
            // 
            // sPRTARIFVIEW1TableAdapter
            // 
            this.sPRTARIFVIEW1TableAdapter.ClearBeforeFill = true;
            // 
            // sPRWORKSVIEW1BindingSource
            // 
            this.sPRWORKSVIEW1BindingSource.DataMember = "SPRWORKSVIEW1";
            this.sPRWORKSVIEW1BindingSource.DataSource = this.diplomOC;
            // 
            // sPRWORKSVIEW1TableAdapter
            // 
            this.sPRWORKSVIEW1TableAdapter.ClearBeforeFill = true;
            // 
            // SPRFormAdministr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 384);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.MaximumSize = new System.Drawing.Size(690, 422);
            this.MinimumSize = new System.Drawing.Size(690, 38);
            this.Name = "SPRFormAdministr";
            this.Text = "Просмотр справочников";
            this.Activated += new System.EventHandler(this.SPRFormAdministr_Activated);
            this.Load += new System.EventHandler(this.SPRFormAdministr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRFONDKVVIEW1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRFONDVIEW1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRKRITVIEW1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRORABVIEW1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRPOSLED1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRPRORABVIEW1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRTARIFVIEW1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRWORKSVIEW1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FolderBase.DiplomOC diplomOC;
        private System.Windows.Forms.BindingSource sPRFONDKVVIEW1BindingSource;
        private FolderBase.DiplomOCTableAdapters.SPRFONDKVVIEW1TableAdapter sPRFONDKVVIEW1TableAdapter;
        private FolderBase.DiplomOCTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource sPRFONDVIEW1BindingSource;
        private FolderBase.DiplomOCTableAdapters.SPRFONDVIEW1TableAdapter sPRFONDVIEW1TableAdapter;
        private System.Windows.Forms.BindingSource sPRKRITVIEW1BindingSource;
        private FolderBase.DiplomOCTableAdapters.SPRKRITVIEW1TableAdapter sPRKRITVIEW1TableAdapter;
        private System.Windows.Forms.BindingSource sPRORABVIEW1BindingSource;
        private FolderBase.DiplomOCTableAdapters.SPRORABVIEW1TableAdapter sPRORABVIEW1TableAdapter;
        private System.Windows.Forms.BindingSource sPRPOSLED1BindingSource;
        private FolderBase.DiplomOCTableAdapters.SPRPOSLED1TableAdapter sPRPOSLED1TableAdapter;
        private System.Windows.Forms.BindingSource sPRPRORABVIEW1BindingSource;
        private FolderBase.DiplomOCTableAdapters.SPRPRORABVIEW1TableAdapter sPRPRORABVIEW1TableAdapter;
        private System.Windows.Forms.BindingSource sPRTARIFVIEW1BindingSource;
        private FolderBase.DiplomOCTableAdapters.SPRTARIFVIEW1TableAdapter sPRTARIFVIEW1TableAdapter;
        private System.Windows.Forms.BindingSource sPRWORKSVIEW1BindingSource;
        private FolderBase.DiplomOCTableAdapters.SPRWORKSVIEW1TableAdapter sPRWORKSVIEW1TableAdapter;
        
        
        
    }
}
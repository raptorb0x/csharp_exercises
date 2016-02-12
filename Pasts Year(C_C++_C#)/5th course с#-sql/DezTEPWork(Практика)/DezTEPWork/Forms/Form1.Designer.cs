namespace DezTEPWork
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Ведомость состояния жилищного фонда");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Отчет удовлетворенности жильцов состоянием жилищного фонда");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Журнал заявок на ремонт");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("План ремонта на год");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Рабочие документы", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Отчет состояния жилищного фонда");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("График очереди ремонта жилищного фонда");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("График ремонта объекта жилищного фонда");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Выходные документы(для просмотра)", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сформироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графикОчередиРемонтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графикРемонтаОбъектаЖилищногоФондаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетСостоянияЖилищногоФондаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.diplomOC = new DezTEPWork.FolderBase.DiplomOC();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Ved_Sost_view = new System.Windows.Forms.BindingSource(this.components);
            this.grremobjvieW1TableAdapter1 = new DezTEPWork.FolderBase.DiplomOCTableAdapters.GRREMOBJVIEW1TableAdapter();
            this.grremovieW1TableAdapter1 = new DezTEPWork.FolderBase.DiplomOCTableAdapters.GRREMOVIEW1TableAdapter();
            this.jrremmsvieW1TableAdapter1 = new DezTEPWork.FolderBase.DiplomOCTableAdapters.JRREMMSVIEW1TableAdapter();
            this.otsostfinvieW1TableAdapter1 = new DezTEPWork.FolderBase.DiplomOCTableAdapters.OTSOSTFINVIEW1TableAdapter();
            this.otsostvieW1TableAdapter1 = new DezTEPWork.FolderBase.DiplomOCTableAdapters.OTSOSTVIEW1TableAdapter();
            this.plremvieW1TableAdapter1 = new DezTEPWork.FolderBase.DiplomOCTableAdapters.PLREMVIEW1TableAdapter();
            this.vedsostvieW1TableAdapter1 = new DezTEPWork.FolderBase.DiplomOCTableAdapters.VEDSOSTVIEW1TableAdapter();
            this.GRREMOBJ = new System.Windows.Forms.BindingSource(this.components);
            this.GROREM = new System.Windows.Forms.BindingSource(this.components);
            this.JRREMMS = new System.Windows.Forms.BindingSource(this.components);
            this.OTSOSTFIN = new System.Windows.Forms.BindingSource(this.components);
            this.OTSOST = new System.Windows.Forms.BindingSource(this.components);
            this.PLREMYEAR = new System.Windows.Forms.BindingSource(this.components);
            this.VEDSOST = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ved_Sost_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRREMOBJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GROREM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JRREMMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OTSOSTFIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OTSOST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PLREMYEAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VEDSOST)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.сформироватьToolStripMenuItem,
            this.просмотToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьToolStripMenuItem,
            this.toolStripSeparator2,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(120, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // сформироватьToolStripMenuItem
            // 
            this.сформироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.графикиToolStripMenuItem,
            this.отчетыToolStripMenuItem});
            this.сформироватьToolStripMenuItem.Name = "сформироватьToolStripMenuItem";
            this.сформироватьToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.сформироватьToolStripMenuItem.Text = "Сформировать";
            // 
            // графикиToolStripMenuItem
            // 
            this.графикиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.графикОчередиРемонтаToolStripMenuItem,
            this.графикРемонтаОбъектаЖилищногоФондаToolStripMenuItem});
            this.графикиToolStripMenuItem.Name = "графикиToolStripMenuItem";
            this.графикиToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.графикиToolStripMenuItem.Text = "Графики";
            // 
            // графикОчередиРемонтаToolStripMenuItem
            // 
            this.графикОчередиРемонтаToolStripMenuItem.Name = "графикОчередиРемонтаToolStripMenuItem";
            this.графикОчередиРемонтаToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.графикОчередиРемонтаToolStripMenuItem.Text = "График очереди ремонта";
            this.графикОчередиРемонтаToolStripMenuItem.Click += new System.EventHandler(this.графикОчередиРемонтаToolStripMenuItem_Click);
            // 
            // графикРемонтаОбъектаЖилищногоФондаToolStripMenuItem
            // 
            this.графикРемонтаОбъектаЖилищногоФондаToolStripMenuItem.Name = "графикРемонтаОбъектаЖилищногоФондаToolStripMenuItem";
            this.графикРемонтаОбъектаЖилищногоФондаToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.графикРемонтаОбъектаЖилищногоФондаToolStripMenuItem.Text = "График ремонта объекта жилищного фонда";
            this.графикРемонтаОбъектаЖилищногоФондаToolStripMenuItem.Click += new System.EventHandler(this.графикРемонтаОбъектаЖилищногоФондаToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчетСостоянияЖилищногоФондаToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // отчетСостоянияЖилищногоФондаToolStripMenuItem
            // 
            this.отчетСостоянияЖилищногоФондаToolStripMenuItem.Name = "отчетСостоянияЖилищногоФондаToolStripMenuItem";
            this.отчетСостоянияЖилищногоФондаToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.отчетСостоянияЖилищногоФондаToolStripMenuItem.Text = "Отчет состояния жилищного фонда";
            this.отчетСостоянияЖилищногоФондаToolStripMenuItem.Click += new System.EventHandler(this.отчетСостоянияЖилищногоФондаToolStripMenuItem_Click);
            // 
            // просмотToolStripMenuItem
            // 
            this.просмотToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem});
            this.просмотToolStripMenuItem.Name = "просмотToolStripMenuItem";
            this.просмотToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.просмотToolStripMenuItem.Text = "Просмотр";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            this.справочникиToolStripMenuItem.Click += new System.EventHandler(this.справочникиToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DeleteButton);
            this.splitContainer1.Panel1.Controls.Add(this.EditButton);
            this.splitContainer1.Panel1.Controls.Add(this.InsertButton);
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(784, 338);
            this.splitContainer1.SplitterDistance = 164;
            this.splitContainer1.TabIndex = 2;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(13, 296);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(149, 30);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.Enabled = false;
            this.EditButton.Location = new System.Drawing.Point(13, 250);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(149, 30);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // InsertButton
            // 
            this.InsertButton.Enabled = false;
            this.InsertButton.Location = new System.Drawing.Point(12, 204);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(149, 30);
            this.InsertButton.TabIndex = 1;
            this.InsertButton.Text = "Вставить";
            this.InsertButton.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "R1";
            treeNode1.Text = "Ведомость состояния жилищного фонда";
            treeNode2.Name = "R2";
            treeNode2.Text = "Отчет удовлетворенности жильцов состоянием жилищного фонда";
            treeNode3.Name = "R3";
            treeNode3.Text = "Журнал заявок на ремонт";
            treeNode4.Name = "R4";
            treeNode4.Text = "План ремонта на год";
            treeNode5.Checked = true;
            treeNode5.Name = "Узел0";
            treeNode5.Text = "Рабочие документы";
            treeNode6.Name = "V1";
            treeNode6.Text = "Отчет состояния жилищного фонда";
            treeNode7.Name = "V2";
            treeNode7.Text = "График очереди ремонта жилищного фонда";
            treeNode8.Name = "V3";
            treeNode8.Text = "График ремонта объекта жилищного фонда";
            treeNode9.Checked = true;
            treeNode9.Name = "Узел1";
            treeNode9.Text = "Выходные документы(для просмотра)";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode9});
            this.treeView1.Size = new System.Drawing.Size(164, 198);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.Size = new System.Drawing.Size(616, 338);
            this.dataGridView1.TabIndex = 1;
            // 
            // diplomOC
            // 
            this.diplomOC.DataSetName = "DiplomOC";
            this.diplomOC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Ved_Sost_view
            // 
            this.Ved_Sost_view.DataMember = "VEDSOSTVIEW";
            this.Ved_Sost_view.DataSource = this.diplomOC;
            // 
            // grremobjvieW1TableAdapter1
            // 
            this.grremobjvieW1TableAdapter1.ClearBeforeFill = true;
            // 
            // grremovieW1TableAdapter1
            // 
            this.grremovieW1TableAdapter1.ClearBeforeFill = true;
            // 
            // jrremmsvieW1TableAdapter1
            // 
            this.jrremmsvieW1TableAdapter1.ClearBeforeFill = true;
            // 
            // otsostfinvieW1TableAdapter1
            // 
            this.otsostfinvieW1TableAdapter1.ClearBeforeFill = true;
            // 
            // otsostvieW1TableAdapter1
            // 
            this.otsostvieW1TableAdapter1.ClearBeforeFill = true;
            // 
            // plremvieW1TableAdapter1
            // 
            this.plremvieW1TableAdapter1.ClearBeforeFill = true;
            // 
            // vedsostvieW1TableAdapter1
            // 
            this.vedsostvieW1TableAdapter1.ClearBeforeFill = true;
            // 
            // GRREMOBJ
            // 
            this.GRREMOBJ.DataMember = "GRREMOBJVIEW1";
            this.GRREMOBJ.DataSource = this.diplomOC;
            // 
            // GROREM
            // 
            this.GROREM.DataMember = "GRREMOVIEW1";
            this.GROREM.DataSource = this.diplomOC;
            // 
            // JRREMMS
            // 
            this.JRREMMS.DataMember = "JRREMMSVIEW1";
            this.JRREMMS.DataSource = this.diplomOC;
            // 
            // OTSOSTFIN
            // 
            this.OTSOSTFIN.DataMember = "OTSOSTFINVIEW1";
            this.OTSOSTFIN.DataSource = this.diplomOC;
            // 
            // OTSOST
            // 
            this.OTSOST.DataMember = "OTSOSTVIEW1";
            this.OTSOST.DataSource = this.diplomOC;
            // 
            // PLREMYEAR
            // 
            this.PLREMYEAR.DataMember = "PLREMVIEW1";
            this.PLREMYEAR.DataSource = this.diplomOC;
            // 
            // VEDSOST
            // 
            this.VEDSOST.DataMember = "VEDSOSTVIEW1";
            this.VEDSOST.DataSource = this.diplomOC;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Планировщик v 0.1.1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diplomOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ved_Sost_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRREMOBJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GROREM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JRREMMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OTSOSTFIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OTSOST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PLREMYEAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VEDSOST)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сформироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графикОчередиРемонтаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графикРемонтаОбъектаЖилищногоФондаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетСостоянияЖилищногоФондаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TreeView treeView1;
        private FolderBase.DiplomOC diplomOC;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.BindingSource Ved_Sost_view;
        private FolderBase.DiplomOCTableAdapters.GRREMOBJVIEW1TableAdapter grremobjvieW1TableAdapter1;
        private FolderBase.DiplomOCTableAdapters.GRREMOVIEW1TableAdapter grremovieW1TableAdapter1;
        private FolderBase.DiplomOCTableAdapters.JRREMMSVIEW1TableAdapter jrremmsvieW1TableAdapter1;
        private FolderBase.DiplomOCTableAdapters.OTSOSTFINVIEW1TableAdapter otsostfinvieW1TableAdapter1;
        private FolderBase.DiplomOCTableAdapters.OTSOSTVIEW1TableAdapter otsostvieW1TableAdapter1;
        private FolderBase.DiplomOCTableAdapters.PLREMVIEW1TableAdapter plremvieW1TableAdapter1;
        private FolderBase.DiplomOCTableAdapters.VEDSOSTVIEW1TableAdapter vedsostvieW1TableAdapter1;
        private System.Windows.Forms.BindingSource GRREMOBJ;
        private System.Windows.Forms.BindingSource GROREM;
        private System.Windows.Forms.BindingSource JRREMMS;
        private System.Windows.Forms.BindingSource OTSOSTFIN;
        private System.Windows.Forms.BindingSource OTSOST;
        private System.Windows.Forms.BindingSource PLREMYEAR;
        private System.Windows.Forms.BindingSource VEDSOST;
        



    }
}


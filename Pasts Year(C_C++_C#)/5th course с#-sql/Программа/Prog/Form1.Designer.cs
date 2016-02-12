namespace Prog
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
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Справочник материалов");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Справочник поставщиков");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Данные о возможныш поставщиках");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Критерии по выбору поставщика");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Справочник объектов");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Договора на поставку МТР");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Справочники", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Ведомость потребностей материалов по объектам");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Ведомость остатков МТР на складе");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Заявки на поставку МТР");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Журнал поступлений МТР на склад");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Накладная на отпуск МТР");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Журнал поступлений МТР на объект");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Рабочие документы", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode27});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.формированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ведомостиПотребностейМатериаловНаГодToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ведомостьЗакупокМатериаловНаГодToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ведомостьПоставщиковНаКаждыйВидМТРToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ведомостьЗакупаемыхМатериаловУПоставщиковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графикПоставкиМТРToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графикДвиженияМатериаловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графикПоставкиДляПоставщикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.претензииКПоставщикамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.INSBUT = new System.Windows.Forms.ToolStripButton();
            this.UPBUT = new System.Windows.Forms.ToolStripButton();
            this.DELBUT = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.REFRSBUT = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.dip = new Prog.Dip();
            this.tableAdapterManager = new Prog.DipTableAdapters.TableAdapterManager();
            this.sPDILVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPDILVIEWTableAdapter = new Prog.DipTableAdapters.SPDILVIEWTableAdapter();
            this.sPKRITBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPKRITTableAdapter = new Prog.DipTableAdapters.SPKRITTableAdapter();
            this.sPMATVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPMATVIEWTableAdapter = new Prog.DipTableAdapters.SPMATVIEWTableAdapter();
            this.sPOBJVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPOBJVIEWTableAdapter = new Prog.DipTableAdapters.SPOBJVIEWTableAdapter();
            this.sPPOSTVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPPOSTVIEWTableAdapter = new Prog.DipTableAdapters.SPPOSTVIEWTableAdapter();
            this.vEDOSTVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vEDOSTVIEWTableAdapter = new Prog.DipTableAdapters.VEDOSTVIEWTableAdapter();
            this.vEDPVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vEDPVIEWTableAdapter = new Prog.DipTableAdapters.VEDPVIEWTableAdapter();
            this.vED_ZAKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_DOC = new System.Windows.Forms.BindingSource(this.components);
            this.sP_DOCTableAdapter = new Prog.DipTableAdapters.SP_DOCTableAdapter();
            this.ZAVPOSTVIEW = new System.Windows.Forms.BindingSource(this.components);
            this.zAVPOSTVIEWTableAdapter = new Prog.DipTableAdapters.ZAVPOSTVIEWTableAdapter();
            this.MAGPOSTVIEW = new System.Windows.Forms.BindingSource(this.components);
            this.mAGPOSTVIEWTableAdapter = new Prog.DipTableAdapters.MAGPOSTVIEWTableAdapter();
            this.NACKOTVIEW = new System.Windows.Forms.BindingSource(this.components);
            this.nACKOTVIEWTableAdapter = new Prog.DipTableAdapters.NACKOTVIEWTableAdapter();
            this.JRRR = new System.Windows.Forms.BindingSource(this.components);
            this.jRRRTableAdapter = new Prog.DipTableAdapters.JRRRTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDILVIEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPKRITBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMATVIEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPOBJVIEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPPOSTVIEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEDOSTVIEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEDPVIEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vED_ZAKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_DOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZAVPOSTVIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MAGPOSTVIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NACKOTVIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JRRR)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.формированиеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // формированиеToolStripMenuItem
            // 
            this.формированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ведомостиПотребностейМатериаловНаГодToolStripMenuItem,
            this.ведомостьЗакупокМатериаловНаГодToolStripMenuItem,
            this.ведомостьПоставщиковНаКаждыйВидМТРToolStripMenuItem,
            this.ведомостьЗакупаемыхМатериаловУПоставщиковToolStripMenuItem,
            this.графикПоставкиМТРToolStripMenuItem,
            this.графикДвиженияМатериаловToolStripMenuItem,
            this.графикПоставкиДляПоставщикаToolStripMenuItem,
            this.претензииКПоставщикамToolStripMenuItem});
            this.формированиеToolStripMenuItem.Name = "формированиеToolStripMenuItem";
            this.формированиеToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.формированиеToolStripMenuItem.Text = "Формирование";
            // 
            // ведомостиПотребностейМатериаловНаГодToolStripMenuItem
            // 
            this.ведомостиПотребностейМатериаловНаГодToolStripMenuItem.Name = "ведомостиПотребностейМатериаловНаГодToolStripMenuItem";
            this.ведомостиПотребностейМатериаловНаГодToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.ведомостиПотребностейМатериаловНаГодToolStripMenuItem.Text = "Ведомости потребностей материалов на год";
            this.ведомостиПотребностейМатериаловНаГодToolStripMenuItem.Click += new System.EventHandler(this.ведомостиПотребностейМатериаловНаГодToolStripMenuItem_Click);
            // 
            // ведомостьЗакупокМатериаловНаГодToolStripMenuItem
            // 
            this.ведомостьЗакупокМатериаловНаГодToolStripMenuItem.Name = "ведомостьЗакупокМатериаловНаГодToolStripMenuItem";
            this.ведомостьЗакупокМатериаловНаГодToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.ведомостьЗакупокМатериаловНаГодToolStripMenuItem.Text = "Ведомость закупок материалов на год";
            this.ведомостьЗакупокМатериаловНаГодToolStripMenuItem.Click += new System.EventHandler(this.ведомостьЗакупокМатериаловНаГодToolStripMenuItem_Click);
            // 
            // ведомостьПоставщиковНаКаждыйВидМТРToolStripMenuItem
            // 
            this.ведомостьПоставщиковНаКаждыйВидМТРToolStripMenuItem.Name = "ведомостьПоставщиковНаКаждыйВидМТРToolStripMenuItem";
            this.ведомостьПоставщиковНаКаждыйВидМТРToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.ведомостьПоставщиковНаКаждыйВидМТРToolStripMenuItem.Text = "Ведомость поставщиков на каждый вид МТР";
            this.ведомостьПоставщиковНаКаждыйВидМТРToolStripMenuItem.Click += new System.EventHandler(this.ведомостьПоставщиковНаКаждыйВидМТРToolStripMenuItem_Click);
            // 
            // ведомостьЗакупаемыхМатериаловУПоставщиковToolStripMenuItem
            // 
            this.ведомостьЗакупаемыхМатериаловУПоставщиковToolStripMenuItem.Name = "ведомостьЗакупаемыхМатериаловУПоставщиковToolStripMenuItem";
            this.ведомостьЗакупаемыхМатериаловУПоставщиковToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.ведомостьЗакупаемыхМатериаловУПоставщиковToolStripMenuItem.Text = "Ведомость закупаемых материалов у поставщиков";
            this.ведомостьЗакупаемыхМатериаловУПоставщиковToolStripMenuItem.Click += new System.EventHandler(this.ведомостьЗакупаемыхМатериаловУПоставщиковToolStripMenuItem_Click);
            // 
            // графикПоставкиМТРToolStripMenuItem
            // 
            this.графикПоставкиМТРToolStripMenuItem.Name = "графикПоставкиМТРToolStripMenuItem";
            this.графикПоставкиМТРToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.графикПоставкиМТРToolStripMenuItem.Text = "График поставки МТР";
            this.графикПоставкиМТРToolStripMenuItem.Click += new System.EventHandler(this.графикПоставкиМТРToolStripMenuItem_Click);
            // 
            // графикДвиженияМатериаловToolStripMenuItem
            // 
            this.графикДвиженияМатериаловToolStripMenuItem.Name = "графикДвиженияМатериаловToolStripMenuItem";
            this.графикДвиженияМатериаловToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.графикДвиженияМатериаловToolStripMenuItem.Text = "Движения материалов";
            this.графикДвиженияМатериаловToolStripMenuItem.Click += new System.EventHandler(this.графикДвиженияМатериаловToolStripMenuItem_Click);
            // 
            // графикПоставкиДляПоставщикаToolStripMenuItem
            // 
            this.графикПоставкиДляПоставщикаToolStripMenuItem.Name = "графикПоставкиДляПоставщикаToolStripMenuItem";
            this.графикПоставкиДляПоставщикаToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.графикПоставкиДляПоставщикаToolStripMenuItem.Text = "График поставки для поставщика";
            this.графикПоставкиДляПоставщикаToolStripMenuItem.Click += new System.EventHandler(this.графикПоставкиДляПоставщикаToolStripMenuItem_Click);
            // 
            // претензииКПоставщикамToolStripMenuItem
            // 
            this.претензииКПоставщикамToolStripMenuItem.Name = "претензииКПоставщикамToolStripMenuItem";
            this.претензииКПоставщикамToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.претензииКПоставщикамToolStripMenuItem.Text = "Претензии к поставщикам";
            this.претензииКПоставщикамToolStripMenuItem.Click += new System.EventHandler(this.претензииКПоставщикамToolStripMenuItem_Click);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 24);
            this.treeView1.Name = "treeView1";
            treeNode15.Name = "S1";
            treeNode15.Text = "Справочник материалов";
            treeNode16.Name = "S2";
            treeNode16.Text = "Справочник поставщиков";
            treeNode17.Name = "S3";
            treeNode17.Text = "Данные о возможныш поставщиках";
            treeNode18.Name = "S4";
            treeNode18.Text = "Критерии по выбору поставщика";
            treeNode19.Name = "S6";
            treeNode19.Text = "Справочник объектов";
            treeNode20.Name = "S7";
            treeNode20.Text = "Договора на поставку МТР";
            treeNode21.Name = "Узел0";
            treeNode21.Text = "Справочники";
            treeNode22.Name = "R1";
            treeNode22.Text = "Ведомость потребностей материалов по объектам";
            treeNode23.Name = "R3";
            treeNode23.Text = "Ведомость остатков МТР на складе";
            treeNode24.Name = "R4";
            treeNode24.Text = "Заявки на поставку МТР";
            treeNode25.Name = "R5";
            treeNode25.Text = "Журнал поступлений МТР на склад";
            treeNode26.Name = "R6";
            treeNode26.Text = "Накладная на отпуск МТР";
            treeNode27.Name = "R7";
            treeNode27.Text = "Журнал поступлений МТР на объект";
            treeNode28.Name = "Узел0";
            treeNode28.Text = "Рабочие документы";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode28});
            this.treeView1.Size = new System.Drawing.Size(254, 544);
            this.treeView1.TabIndex = 2;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(254, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 544);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.INSBUT,
            this.UPBUT,
            this.DELBUT,
            this.toolStripSeparator1,
            this.REFRSBUT,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(257, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(533, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // INSBUT
            // 
            this.INSBUT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.INSBUT.Image = ((System.Drawing.Image)(resources.GetObject("INSBUT.Image")));
            this.INSBUT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.INSBUT.Name = "INSBUT";
            this.INSBUT.Size = new System.Drawing.Size(23, 22);
            this.INSBUT.Text = "Вставить";
            // 
            // UPBUT
            // 
            this.UPBUT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UPBUT.Image = ((System.Drawing.Image)(resources.GetObject("UPBUT.Image")));
            this.UPBUT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UPBUT.Name = "UPBUT";
            this.UPBUT.Size = new System.Drawing.Size(23, 22);
            this.UPBUT.Text = "Изменить";
            // 
            // DELBUT
            // 
            this.DELBUT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DELBUT.Image = ((System.Drawing.Image)(resources.GetObject("DELBUT.Image")));
            this.DELBUT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DELBUT.Name = "DELBUT";
            this.DELBUT.Size = new System.Drawing.Size(23, 22);
            this.DELBUT.Text = "Удалить";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // REFRSBUT
            // 
            this.REFRSBUT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.REFRSBUT.Image = ((System.Drawing.Image)(resources.GetObject("REFRSBUT.Image")));
            this.REFRSBUT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.REFRSBUT.Name = "REFRSBUT";
            this.REFRSBUT.Size = new System.Drawing.Size(23, 22);
            this.REFRSBUT.Text = "toolStripButton4";
            this.REFRSBUT.Click += new System.EventHandler(this.REFRSBUT_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // dip
            // 
            this.dip.DataSetName = "Dip";
            this.dip.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.SP_CRITTableAdapter = null;
            this.tableAdapterManager.SP_DILTableAdapter = null;
            this.tableAdapterManager.SP_DOCTableAdapter = null;
            this.tableAdapterManager.SP_MATTableAdapter = null;
            this.tableAdapterManager.SP_OBJTableAdapter = null;
            this.tableAdapterManager.SP_POSTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Prog.DipTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VED_OSTTableAdapter = null;
            this.tableAdapterManager.VED_PTableAdapter = null;
            this.tableAdapterManager.VED_ZAKTableAdapter = null;
            // 
            // sPDILVIEWBindingSource
            // 
            this.sPDILVIEWBindingSource.DataMember = "SPDILVIEW";
            this.sPDILVIEWBindingSource.DataSource = this.dip;
            // 
            // sPDILVIEWTableAdapter
            // 
            this.sPDILVIEWTableAdapter.ClearBeforeFill = true;
            // 
            // sPKRITBindingSource
            // 
            this.sPKRITBindingSource.DataMember = "SPKRIT";
            this.sPKRITBindingSource.DataSource = this.dip;
            // 
            // sPKRITTableAdapter
            // 
            this.sPKRITTableAdapter.ClearBeforeFill = true;
            // 
            // sPMATVIEWBindingSource
            // 
            this.sPMATVIEWBindingSource.DataMember = "SPMATVIEW";
            this.sPMATVIEWBindingSource.DataSource = this.dip;
            // 
            // sPMATVIEWTableAdapter
            // 
            this.sPMATVIEWTableAdapter.ClearBeforeFill = true;
            // 
            // sPOBJVIEWBindingSource
            // 
            this.sPOBJVIEWBindingSource.DataMember = "SPOBJVIEW";
            this.sPOBJVIEWBindingSource.DataSource = this.dip;
            // 
            // sPOBJVIEWTableAdapter
            // 
            this.sPOBJVIEWTableAdapter.ClearBeforeFill = true;
            // 
            // sPPOSTVIEWBindingSource
            // 
            this.sPPOSTVIEWBindingSource.DataMember = "SPPOSTVIEW";
            this.sPPOSTVIEWBindingSource.DataSource = this.dip;
            // 
            // sPPOSTVIEWTableAdapter
            // 
            this.sPPOSTVIEWTableAdapter.ClearBeforeFill = true;
            // 
            // vEDOSTVIEWBindingSource
            // 
            this.vEDOSTVIEWBindingSource.DataMember = "VEDOSTVIEW";
            this.vEDOSTVIEWBindingSource.DataSource = this.dip;
            // 
            // vEDOSTVIEWTableAdapter
            // 
            this.vEDOSTVIEWTableAdapter.ClearBeforeFill = true;
            // 
            // vEDPVIEWBindingSource
            // 
            this.vEDPVIEWBindingSource.DataMember = "VEDPVIEW";
            this.vEDPVIEWBindingSource.DataSource = this.dip;
            // 
            // vEDPVIEWTableAdapter
            // 
            this.vEDPVIEWTableAdapter.ClearBeforeFill = true;
            // 
            // vED_ZAKBindingSource
            // 
            this.vED_ZAKBindingSource.DataMember = "VED_ZAK";
            this.vED_ZAKBindingSource.DataSource = this.dip;
            // 
            // SP_DOC
            // 
            this.SP_DOC.DataMember = "SP_DOC";
            this.SP_DOC.DataSource = this.dip;
            // 
            // sP_DOCTableAdapter
            // 
            this.sP_DOCTableAdapter.ClearBeforeFill = true;
            // 
            // ZAVPOSTVIEW
            // 
            this.ZAVPOSTVIEW.DataMember = "ZAVPOSTVIEW";
            this.ZAVPOSTVIEW.DataSource = this.dip;
            // 
            // zAVPOSTVIEWTableAdapter
            // 
            this.zAVPOSTVIEWTableAdapter.ClearBeforeFill = true;
            // 
            // MAGPOSTVIEW
            // 
            this.MAGPOSTVIEW.DataMember = "MAGPOSTVIEW";
            this.MAGPOSTVIEW.DataSource = this.dip;
            // 
            // mAGPOSTVIEWTableAdapter
            // 
            this.mAGPOSTVIEWTableAdapter.ClearBeforeFill = true;
            // 
            // NACKOTVIEW
            // 
            this.NACKOTVIEW.DataMember = "NACKOTVIEW";
            this.NACKOTVIEW.DataSource = this.dip;
            // 
            // nACKOTVIEWTableAdapter
            // 
            this.nACKOTVIEWTableAdapter.ClearBeforeFill = true;
            // 
            // JRRR
            // 
            this.JRRR.DataMember = "JRRR";
            this.JRRR.DataSource = this.dip;
            // 
            // jRRRTableAdapter
            // 
            this.jRRRTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 568);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Отдел МТС";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDILVIEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPKRITBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMATVIEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPOBJVIEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPPOSTVIEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEDOSTVIEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEDPVIEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vED_ZAKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_DOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZAVPOSTVIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MAGPOSTVIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NACKOTVIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JRRR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem формированиеToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Splitter splitter1;
        private Dip dip;
        private System.Windows.Forms.ToolStripMenuItem ведомостиПотребностейМатериаловНаГодToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ведомостьЗакупокМатериаловНаГодToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ведомостьПоставщиковНаКаждыйВидМТРToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ведомостьЗакупаемыхМатериаловУПоставщиковToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        
        private DipTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource sPDILVIEWBindingSource;
        private DipTableAdapters.SPDILVIEWTableAdapter sPDILVIEWTableAdapter;
        private System.Windows.Forms.BindingSource sPKRITBindingSource;
        private DipTableAdapters.SPKRITTableAdapter sPKRITTableAdapter;
        private System.Windows.Forms.BindingSource sPMATVIEWBindingSource;
        private DipTableAdapters.SPMATVIEWTableAdapter sPMATVIEWTableAdapter;
        private System.Windows.Forms.BindingSource sPOBJVIEWBindingSource;
        private DipTableAdapters.SPOBJVIEWTableAdapter sPOBJVIEWTableAdapter;
        private System.Windows.Forms.BindingSource sPPOSTVIEWBindingSource;
        private DipTableAdapters.SPPOSTVIEWTableAdapter sPPOSTVIEWTableAdapter;
        private System.Windows.Forms.BindingSource vEDOSTVIEWBindingSource;
        private DipTableAdapters.VEDOSTVIEWTableAdapter vEDOSTVIEWTableAdapter;
        private System.Windows.Forms.BindingSource vEDPVIEWBindingSource;
        private DipTableAdapters.VEDPVIEWTableAdapter vEDPVIEWTableAdapter;
       
        private System.Windows.Forms.BindingSource vED_ZAKBindingSource;
        public System.Windows.Forms.ToolStripButton INSBUT;
        public System.Windows.Forms.ToolStripButton UPBUT;
        public System.Windows.Forms.ToolStripButton DELBUT;
        public System.Windows.Forms.ToolStripButton REFRSBUT;
        private System.Windows.Forms.BindingSource SP_DOC;
        private DipTableAdapters.SP_DOCTableAdapter sP_DOCTableAdapter;
        private System.Windows.Forms.BindingSource ZAVPOSTVIEW;
        private DipTableAdapters.ZAVPOSTVIEWTableAdapter zAVPOSTVIEWTableAdapter;
        private System.Windows.Forms.BindingSource MAGPOSTVIEW;
        private DipTableAdapters.MAGPOSTVIEWTableAdapter mAGPOSTVIEWTableAdapter;
        private System.Windows.Forms.BindingSource NACKOTVIEW;
        private DipTableAdapters.NACKOTVIEWTableAdapter nACKOTVIEWTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem графикПоставкиМТРToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графикДвиженияМатериаловToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графикПоставкиДляПоставщикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem претензииКПоставщикамToolStripMenuItem;
        private System.Windows.Forms.BindingSource JRRR;
        private DipTableAdapters.JRRRTableAdapter jRRRTableAdapter;
        

       
    }
}


namespace MyUtil
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_About = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.L_Count = new System.Windows.Forms.Label();
            this.B_reset = new System.Windows.Forms.Button();
            this.B_minus = new System.Windows.Forms.Button();
            this.B_plus = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NUD_To = new System.Windows.Forms.NumericUpDown();
            this.NUD_From = new System.Windows.Forms.NumericUpDown();
            this.L_Gen_Result = new System.Windows.Forms.Label();
            this.B_Generate = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.B_one = new System.Windows.Forms.Button();
            this.B_Two = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.L_Score = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_To)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_From)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Exit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // TSMI_Exit
            // 
            this.TSMI_Exit.Name = "TSMI_Exit";
            this.TSMI_Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.TSMI_Exit.Size = new System.Drawing.Size(144, 22);
            this.TSMI_Exit.Tag = "";
            this.TSMI_Exit.Text = "Выход";
            this.TSMI_Exit.Click += new System.EventHandler(this.TSMI_Exit_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_About});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // TSMI_About
            // 
            this.TSMI_About.Name = "TSMI_About";
            this.TSMI_About.Size = new System.Drawing.Size(149, 22);
            this.TSMI_About.Text = "О программе";
            this.TSMI_About.Click += new System.EventHandler(this.TSMI_About_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(259, 222);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.L_Count);
            this.tabPage1.Controls.Add(this.B_reset);
            this.tabPage1.Controls.Add(this.B_minus);
            this.tabPage1.Controls.Add(this.B_plus);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(251, 196);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Счетчик";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // L_Count
            // 
            this.L_Count.AutoSize = true;
            this.L_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_Count.Location = new System.Drawing.Point(121, 75);
            this.L_Count.Name = "L_Count";
            this.L_Count.Size = new System.Drawing.Size(19, 20);
            this.L_Count.TabIndex = 3;
            this.L_Count.Text = "0";
            // 
            // B_reset
            // 
            this.B_reset.Location = new System.Drawing.Point(7, 70);
            this.B_reset.Name = "B_reset";
            this.B_reset.Size = new System.Drawing.Size(75, 23);
            this.B_reset.TabIndex = 2;
            this.B_reset.Text = "Сброс";
            this.B_reset.UseVisualStyleBackColor = true;
            this.B_reset.Click += new System.EventHandler(this.B_reset_Click);
            // 
            // B_minus
            // 
            this.B_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_minus.Location = new System.Drawing.Point(108, 116);
            this.B_minus.Name = "B_minus";
            this.B_minus.Size = new System.Drawing.Size(75, 30);
            this.B_minus.TabIndex = 1;
            this.B_minus.Text = "&-";
            this.B_minus.UseVisualStyleBackColor = true;
            this.B_minus.Click += new System.EventHandler(this.B_minus_Click);
            // 
            // B_plus
            // 
            this.B_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_plus.Location = new System.Drawing.Point(108, 24);
            this.B_plus.Name = "B_plus";
            this.B_plus.Size = new System.Drawing.Size(75, 29);
            this.B_plus.TabIndex = 0;
            this.B_plus.Text = "&+";
            this.B_plus.UseVisualStyleBackColor = true;
            this.B_plus.Click += new System.EventHandler(this.B_plus_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.NUD_To);
            this.tabPage2.Controls.Add(this.NUD_From);
            this.tabPage2.Controls.Add(this.L_Gen_Result);
            this.tabPage2.Controls.Add(this.B_Generate);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(251, 196);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Генератор";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "До";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "От";
            // 
            // NUD_To
            // 
            this.NUD_To.Location = new System.Drawing.Point(42, 75);
            this.NUD_To.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUD_To.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_To.Name = "NUD_To";
            this.NUD_To.Size = new System.Drawing.Size(92, 20);
            this.NUD_To.TabIndex = 3;
            this.NUD_To.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // NUD_From
            // 
            this.NUD_From.Location = new System.Drawing.Point(42, 36);
            this.NUD_From.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.NUD_From.Name = "NUD_From";
            this.NUD_From.Size = new System.Drawing.Size(92, 20);
            this.NUD_From.TabIndex = 2;
            // 
            // L_Gen_Result
            // 
            this.L_Gen_Result.AutoSize = true;
            this.L_Gen_Result.Location = new System.Drawing.Point(181, 43);
            this.L_Gen_Result.Name = "L_Gen_Result";
            this.L_Gen_Result.Size = new System.Drawing.Size(13, 13);
            this.L_Gen_Result.TabIndex = 1;
            this.L_Gen_Result.Text = "0";
            // 
            // B_Generate
            // 
            this.B_Generate.Location = new System.Drawing.Point(154, 72);
            this.B_Generate.Name = "B_Generate";
            this.B_Generate.Size = new System.Drawing.Size(75, 37);
            this.B_Generate.TabIndex = 0;
            this.B_Generate.Text = "Сгенерировать";
            this.B_Generate.UseVisualStyleBackColor = true;
            this.B_Generate.Click += new System.EventHandler(this.B_Generate_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.L_Score);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.B_Two);
            this.tabPage3.Controls.Add(this.B_one);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(251, 196);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Херота";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // B_one
            // 
            this.B_one.Location = new System.Drawing.Point(37, 75);
            this.B_one.Name = "B_one";
            this.B_one.Size = new System.Drawing.Size(75, 23);
            this.B_one.TabIndex = 0;
            this.B_one.Text = "Тыкни";
            this.B_one.UseVisualStyleBackColor = true;
            this.B_one.Click += new System.EventHandler(this.B_one_Click);
            // 
            // B_Two
            // 
            this.B_Two.Location = new System.Drawing.Point(127, 75);
            this.B_Two.Name = "B_Two";
            this.B_Two.Size = new System.Drawing.Size(75, 23);
            this.B_Two.TabIndex = 1;
            this.B_Two.Text = "Тыкни";
            this.B_Two.UseVisualStyleBackColor = true;
            this.B_Two.Visible = false;
            this.B_Two.Click += new System.EventHandler(this.B_Two_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Счет:";
            // 
            // L_Score
            // 
            this.L_Score.AutoSize = true;
            this.L_Score.Location = new System.Drawing.Point(96, 34);
            this.L_Score.Name = "L_Score";
            this.L_Score.Size = new System.Drawing.Size(13, 13);
            this.L_Score.TabIndex = 3;
            this.L_Score.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "MainForm";
            this.Text = "MyUtil";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_To)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_From)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Exit;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_About;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label L_Count;
        private System.Windows.Forms.Button B_reset;
        private System.Windows.Forms.Button B_minus;
        private System.Windows.Forms.Button B_plus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NUD_To;
        private System.Windows.Forms.NumericUpDown NUD_From;
        private System.Windows.Forms.Label L_Gen_Result;
        private System.Windows.Forms.Button B_Generate;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label L_Score;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_Two;
        private System.Windows.Forms.Button B_one;
    }
}


﻿namespace DVHAnalyzer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_calc = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_structure = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column_dv = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column_dvvalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_dvunit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column_unit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column_space = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_textunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_space2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_sign = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column_criteria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_tol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_mu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_print = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.button_export = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_open = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Controls.Add(this.button_print);
            this.splitContainer1.Panel2.Controls.Add(this.button_close);
            this.splitContainer1.Panel2.Controls.Add(this.button_export);
            this.splitContainer1.Panel2.Controls.Add(this.button_save);
            this.splitContainer1.Panel2.Controls.Add(this.button_open);
            this.splitContainer1.Size = new System.Drawing.Size(953, 761);
            this.splitContainer1.SplitterDistance = 672;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.button_delete);
            this.splitContainer2.Panel1.Controls.Add(this.button_add);
            this.splitContainer2.Panel1.Controls.Add(this.button_calc);
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.SplitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(953, 672);
            this.splitContainer2.SplitterDistance = 128;
            this.splitContainer2.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(953, 27);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(81, 24);
            this.toolStripButton1.Text = "Templates";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(45, 24);
            this.toolStripButton2.Text = "Help";
            this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 21);
            this.label7.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 21);
            this.label6.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 21);
            this.label5.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Plan ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Patient\'s Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Patient ID";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(677, 86);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(115, 36);
            this.button_delete.TabIndex = 4;
            this.button_delete.Text = "Delete Row";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.Button_delete_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(550, 86);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(121, 36);
            this.button_add.TabIndex = 3;
            this.button_add.Text = "Add Row";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // button_calc
            // 
            this.button_calc.Location = new System.Drawing.Point(798, 86);
            this.button_calc.Name = "button_calc";
            this.button_calc.Size = new System.Drawing.Size(141, 36);
            this.button_calc.TabIndex = 2;
            this.button_calc.Text = "Calculate DVH";
            this.button_calc.UseVisualStyleBackColor = true;
            this.button_calc.Click += new System.EventHandler(this.Button_calc_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.label9);
            this.splitContainer3.Panel2.Controls.Add(this.label8);
            this.splitContainer3.Panel2.Controls.Add(this.label_mu);
            this.splitContainer3.Panel2.Controls.Add(this.label1);
            this.splitContainer3.Size = new System.Drawing.Size(953, 540);
            this.splitContainer3.SplitterDistance = 487;
            this.splitContainer3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_structure,
            this.Column_dv,
            this.Column_dvvalue,
            this.Column_dvunit,
            this.Column_unit,
            this.Column_space,
            this.Column_result,
            this.Column_textunit,
            this.Column_space2,
            this.Column_sign,
            this.Column_criteria,
            this.Column_tol});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(953, 487);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellValueChanged);
            // 
            // Column_structure
            // 
            this.Column_structure.FillWeight = 110F;
            this.Column_structure.HeaderText = "Structure";
            this.Column_structure.Name = "Column_structure";
            this.Column_structure.Sorted = true;
            // 
            // Column_dv
            // 
            this.Column_dv.FillWeight = 90F;
            this.Column_dv.HeaderText = "Dose/Volume";
            this.Column_dv.Items.AddRange(new object[] {
            "V",
            "D",
            "Dmax",
            "Dmean",
            "Dmin",
            "CV",
            "DC"});
            this.Column_dv.Name = "Column_dv";
            // 
            // Column_dvvalue
            // 
            this.Column_dvvalue.FillWeight = 60F;
            this.Column_dvvalue.HeaderText = "Value";
            this.Column_dvvalue.Name = "Column_dvvalue";
            this.Column_dvvalue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column_dvunit
            // 
            this.Column_dvunit.FillWeight = 60F;
            this.Column_dvunit.HeaderText = "In_Unit";
            this.Column_dvunit.Items.AddRange(new object[] {
            "Gy",
            "cc",
            "%"});
            this.Column_dvunit.Name = "Column_dvunit";
            // 
            // Column_unit
            // 
            this.Column_unit.FillWeight = 60F;
            this.Column_unit.HeaderText = "Out_Unit";
            this.Column_unit.Items.AddRange(new object[] {
            "Gy",
            "cc",
            "%"});
            this.Column_unit.Name = "Column_unit";
            // 
            // Column_space
            // 
            this.Column_space.FillWeight = 8F;
            this.Column_space.HeaderText = "";
            this.Column_space.Name = "Column_space";
            this.Column_space.ReadOnly = true;
            this.Column_space.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_space.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column_result
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column_result.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column_result.FillWeight = 97.63348F;
            this.Column_result.HeaderText = "Result";
            this.Column_result.Name = "Column_result";
            this.Column_result.ReadOnly = true;
            this.Column_result.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column_textunit
            // 
            this.Column_textunit.FillWeight = 30F;
            this.Column_textunit.HeaderText = "";
            this.Column_textunit.Name = "Column_textunit";
            this.Column_textunit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column_space2
            // 
            this.Column_space2.FillWeight = 8F;
            this.Column_space2.HeaderText = "";
            this.Column_space2.Name = "Column_space2";
            this.Column_space2.ReadOnly = true;
            this.Column_space2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_space2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column_sign
            // 
            this.Column_sign.FillWeight = 50F;
            this.Column_sign.HeaderText = "Sign";
            this.Column_sign.Items.AddRange(new object[] {
            "=",
            "<=",
            ">="});
            this.Column_sign.Name = "Column_sign";
            this.Column_sign.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column_criteria
            // 
            this.Column_criteria.FillWeight = 80F;
            this.Column_criteria.HeaderText = "Criteria";
            this.Column_criteria.Name = "Column_criteria";
            this.Column_criteria.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column_tol
            // 
            this.Column_tol.FillWeight = 70F;
            this.Column_tol.HeaderText = "Tolerance";
            this.Column_tol.Name = "Column_tol";
            this.Column_tol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label9.Location = new System.Drawing.Point(327, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 21);
            this.label9.TabIndex = 13;
            this.label9.Text = "Creation Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(12, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "User ";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // label_mu
            // 
            this.label_mu.AutoSize = true;
            this.label_mu.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label_mu.Location = new System.Drawing.Point(820, 10);
            this.label_mu.Name = "label_mu";
            this.label_mu.Size = new System.Drawing.Size(0, 25);
            this.label_mu.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label1.Location = new System.Drawing.Point(732, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total MU";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVHAnalyzer.Properties.Resources.ECU_logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button_print
            // 
            this.button_print.Location = new System.Drawing.Point(530, 42);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(141, 36);
            this.button_print.TabIndex = 5;
            this.button_print.Text = "Print";
            this.button_print.UseVisualStyleBackColor = true;
            this.button_print.Click += new System.EventHandler(this.Button_print_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(827, 42);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(112, 35);
            this.button_close.TabIndex = 3;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.Button_close_Click);
            // 
            // button_export
            // 
            this.button_export.Location = new System.Drawing.Point(827, 0);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(112, 36);
            this.button_export.TabIndex = 2;
            this.button_export.Text = "Export";
            this.button_export.UseVisualStyleBackColor = true;
            this.button_export.Click += new System.EventHandler(this.Button_export_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(677, 0);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(141, 36);
            this.button_save.TabIndex = 1;
            this.button_save.Text = "Save as Template";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.Button_save_Click);
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(530, 0);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(141, 36);
            this.button_open.TabIndex = 0;
            this.button_open.Text = "Open Template";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.Button_open_Click);
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog2_FileOk);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.PrintPreviewDialog1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 761);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DVH Analyzer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.Button button_open;
    private System.Windows.Forms.Button button_save;
    private System.Windows.Forms.Button button_calc;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.SplitContainer splitContainer2;
    private System.Windows.Forms.Button button_export;
    private System.Windows.Forms.Button button_add;
    private System.Windows.Forms.Button button_delete;
    private System.Windows.Forms.SplitContainer splitContainer3;
    private System.Windows.Forms.Label label_mu;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    private System.Windows.Forms.SaveFileDialog saveFileDialog2;
    private System.Windows.Forms.Button button_close;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton toolStripButton1;
    private System.Windows.Forms.ToolStripButton toolStripButton2;
    private System.Windows.Forms.DataGridViewComboBoxColumn Column_structure;
    private System.Windows.Forms.DataGridViewComboBoxColumn Column_dv;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column_dvvalue;
    private System.Windows.Forms.DataGridViewComboBoxColumn Column_dvunit;
    private System.Windows.Forms.DataGridViewComboBoxColumn Column_unit;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column_space;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column_result;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column_textunit;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column_space2;
    private System.Windows.Forms.DataGridViewComboBoxColumn Column_sign;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column_criteria;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column_tol;
        private System.Windows.Forms.Button button_print;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}
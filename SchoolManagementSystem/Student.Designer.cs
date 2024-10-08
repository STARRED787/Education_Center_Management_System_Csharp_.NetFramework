﻿namespace SchoolManagementSystem
{
    partial class Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.cb_stsubsec = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_stsub = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_stclear = new System.Windows.Forms.Button();
            this.cb_stgen = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtp_stinfo = new System.Windows.Forms.DateTimePicker();
            this.bt_display = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.tb_stemail = new System.Windows.Forms.TextBox();
            this.tb_stnum = new System.Windows.Forms.TextBox();
            this.tb_stname = new System.Windows.Forms.TextBox();
            this.tb_stid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_stinfo = new Guna.UI.WinForms.GunaDataGridView();
            this.studentInfoTbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sclManagementSystemDataSet = new SchoolManagementSystem.sclManagementSystemDataSet();
            this.studentInfoTbTableAdapter = new SchoolManagementSystem.sclManagementSystemDataSetTableAdapters.StudentInfoTbTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoTbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sclManagementSystemDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.tb_search);
            this.groupBox1.Controls.Add(this.cb_stsubsec);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tb_stsub);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bt_stclear);
            this.groupBox1.Controls.Add(this.cb_stgen);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.dtp_stinfo);
            this.groupBox1.Controls.Add(this.bt_display);
            this.groupBox1.Controls.Add(this.bt_delete);
            this.groupBox1.Controls.Add(this.bt_update);
            this.groupBox1.Controls.Add(this.bt_add);
            this.groupBox1.Controls.Add(this.bt_save);
            this.groupBox1.Controls.Add(this.tb_stemail);
            this.groupBox1.Controls.Add(this.tb_stnum);
            this.groupBox1.Controls.Add(this.tb_stname);
            this.groupBox1.Controls.Add(this.tb_stid);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 439);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(17, 351);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(93, 35);
            this.btn_search.TabIndex = 42;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(140, 358);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(236, 25);
            this.tb_search.TabIndex = 41;
            // 
            // cb_stsubsec
            // 
            this.cb_stsubsec.FormattingEnabled = true;
            this.cb_stsubsec.Items.AddRange(new object[] {
            "Primary",
            "Secondary",
            "O/L",
            "A/L"});
            this.cb_stsubsec.Location = new System.Drawing.Point(140, 315);
            this.cb_stsubsec.Name = "cb_stsubsec";
            this.cb_stsubsec.Size = new System.Drawing.Size(320, 26);
            this.cb_stsubsec.TabIndex = 35;
            this.cb_stsubsec.Text = "Select";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 18);
            this.label9.TabIndex = 34;
            this.label9.Text = "Subejct Section";
            // 
            // tb_stsub
            // 
            this.tb_stsub.Location = new System.Drawing.Point(143, 275);
            this.tb_stsub.Name = "tb_stsub";
            this.tb_stsub.Size = new System.Drawing.Size(320, 25);
            this.tb_stsub.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Subject";
            // 
            // bt_stclear
            // 
            this.bt_stclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_stclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_stclear.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_stclear.Location = new System.Drawing.Point(380, 399);
            this.bt_stclear.Name = "bt_stclear";
            this.bt_stclear.Size = new System.Drawing.Size(88, 34);
            this.bt_stclear.TabIndex = 22;
            this.bt_stclear.Text = "Clear";
            this.bt_stclear.UseVisualStyleBackColor = false;
            this.bt_stclear.Click += new System.EventHandler(this.bt_stclear_Click);
            // 
            // cb_stgen
            // 
            this.cb_stgen.FormattingEnabled = true;
            this.cb_stgen.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cb_stgen.Location = new System.Drawing.Point(140, 157);
            this.cb_stgen.Name = "cb_stgen";
            this.cb_stgen.Size = new System.Drawing.Size(320, 26);
            this.cb_stgen.TabIndex = 21;
            this.cb_stgen.Text = "Select";
            this.cb_stgen.SelectedIndexChanged += new System.EventHandler(this.cb_stgen_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(479, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dtp_stinfo
            // 
            this.dtp_stinfo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_stinfo.Location = new System.Drawing.Point(140, 116);
            this.dtp_stinfo.Name = "dtp_stinfo";
            this.dtp_stinfo.Size = new System.Drawing.Size(320, 25);
            this.dtp_stinfo.TabIndex = 18;
            this.dtp_stinfo.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.dtp_stinfo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_stinfo_KeyDown);
            // 
            // bt_display
            // 
            this.bt_display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_display.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_display.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_display.Location = new System.Drawing.Point(619, 399);
            this.bt_display.Name = "bt_display";
            this.bt_display.Size = new System.Drawing.Size(88, 34);
            this.bt_display.TabIndex = 17;
            this.bt_display.Text = "Display";
            this.bt_display.UseVisualStyleBackColor = false;
            this.bt_display.Click += new System.EventHandler(this.bt_display_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_delete.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_delete.Location = new System.Drawing.Point(504, 399);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(88, 34);
            this.bt_delete.TabIndex = 15;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = false;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_update
            // 
            this.bt_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_update.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_update.Location = new System.Drawing.Point(129, 399);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(88, 34);
            this.bt_update.TabIndex = 14;
            this.bt_update.Text = "Update";
            this.bt_update.UseVisualStyleBackColor = false;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_add.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add.Location = new System.Drawing.Point(254, 399);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(88, 34);
            this.bt_add.TabIndex = 13;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_save
            // 
            this.bt_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_save.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_save.Location = new System.Drawing.Point(17, 399);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(88, 34);
            this.bt_save.TabIndex = 12;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = false;
            this.bt_save.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_stemail
            // 
            this.tb_stemail.Location = new System.Drawing.Point(140, 238);
            this.tb_stemail.Name = "tb_stemail";
            this.tb_stemail.Size = new System.Drawing.Size(320, 25);
            this.tb_stemail.TabIndex = 11;
            this.tb_stemail.TextChanged += new System.EventHandler(this.tb_stemail_TextChanged);
            this.tb_stemail.Validating += new System.ComponentModel.CancelEventHandler(this.tb_stemail_Validating);
            this.tb_stemail.Validated += new System.EventHandler(this.tb_stemail_Validated);
            // 
            // tb_stnum
            // 
            this.tb_stnum.Location = new System.Drawing.Point(140, 196);
            this.tb_stnum.Name = "tb_stnum";
            this.tb_stnum.Size = new System.Drawing.Size(320, 25);
            this.tb_stnum.TabIndex = 10;
            this.tb_stnum.TextChanged += new System.EventHandler(this.tb_stnum_TextChanged);
            // 
            // tb_stname
            // 
            this.tb_stname.Location = new System.Drawing.Point(140, 73);
            this.tb_stname.Name = "tb_stname";
            this.tb_stname.Size = new System.Drawing.Size(320, 25);
            this.tb_stname.TabIndex = 7;
            this.tb_stname.TextChanged += new System.EventHandler(this.tb_stname_TextChanged);
            // 
            // tb_stid
            // 
            this.tb_stid.Location = new System.Drawing.Point(140, 34);
            this.tb_stid.Name = "tb_stid";
            this.tb_stid.Size = new System.Drawing.Size(320, 25);
            this.tb_stid.TabIndex = 6;
            this.tb_stid.TextChanged += new System.EventHandler(this.tb_stid_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "Email";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Phone Number";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Gender";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Date Of Birth";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Student Name";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Student Id";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dgv_stinfo
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(189)))));
            this.dgv_stinfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_stinfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_stinfo.BackgroundColor = System.Drawing.Color.White;
            this.dgv_stinfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_stinfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_stinfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_stinfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_stinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(221)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(143)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_stinfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_stinfo.EnableHeadersVisualStyles = false;
            this.dgv_stinfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(186)))));
            this.dgv_stinfo.Location = new System.Drawing.Point(12, 504);
            this.dgv_stinfo.Name = "dgv_stinfo";
            this.dgv_stinfo.RowHeadersVisible = false;
            this.dgv_stinfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_stinfo.Size = new System.Drawing.Size(713, 129);
            this.dgv_stinfo.TabIndex = 24;
            this.dgv_stinfo.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.DeepOrange;
            this.dgv_stinfo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(189)))));
            this.dgv_stinfo.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_stinfo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_stinfo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_stinfo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_stinfo.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_stinfo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(186)))));
            this.dgv_stinfo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.dgv_stinfo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_stinfo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_stinfo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_stinfo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_stinfo.ThemeStyle.HeaderStyle.Height = 23;
            this.dgv_stinfo.ThemeStyle.ReadOnly = false;
            this.dgv_stinfo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(221)))), ((int)(((byte)(211)))));
            this.dgv_stinfo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_stinfo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_stinfo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_stinfo.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_stinfo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(143)))), ((int)(((byte)(107)))));
            this.dgv_stinfo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_stinfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_stinfo_CellContentClick_1);
            // 
            // studentInfoTbBindingSource
            // 
            this.studentInfoTbBindingSource.DataMember = "StudentInfoTb";
            this.studentInfoTbBindingSource.DataSource = this.sclManagementSystemDataSet;
            this.studentInfoTbBindingSource.CurrentChanged += new System.EventHandler(this.studentInfoTbBindingSource_CurrentChanged);
            // 
            // sclManagementSystemDataSet
            // 
            this.sclManagementSystemDataSet.DataSetName = "sclManagementSystemDataSet";
            this.sclManagementSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentInfoTbTableAdapter
            // 
            this.studentInfoTbTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(300, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(32)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(662, 3);
            this.button1.MaximumSize = new System.Drawing.Size(1920, 720);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 23);
            this.button1.TabIndex = 5;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(737, 30);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(32)))));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(690, 6);
            this.button5.MaximumSize = new System.Drawing.Size(1920, 720);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(21, 20);
            this.button5.TabIndex = 4;
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 647);
            this.Controls.Add(this.dgv_stinfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoTbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sclManagementSystemDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_stemail;
        private System.Windows.Forms.TextBox tb_stnum;
        private System.Windows.Forms.TextBox tb_stname;
        private System.Windows.Forms.TextBox tb_stid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_display;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.DateTimePicker dtp_stinfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cb_stgen;
        private System.Windows.Forms.Button bt_stclear;
        private Guna.UI.WinForms.GunaDataGridView dgv_stinfo;
        private sclManagementSystemDataSet sclManagementSystemDataSet;
        private System.Windows.Forms.BindingSource studentInfoTbBindingSource;
        private sclManagementSystemDataSetTableAdapters.StudentInfoTbTableAdapter studentInfoTbTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_stsub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_stsubsec;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
    }
}
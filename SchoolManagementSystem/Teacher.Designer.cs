namespace SchoolManagementSystem
{
    partial class Teacher
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher));
            this.studentInfoTbTableAdapter = new SchoolManagementSystem.sclManagementSystemDataSetTableAdapters.StudentInfoTbTableAdapter();
            this.studentInfoTbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sclManagementSystemDataSet = new SchoolManagementSystem.sclManagementSystemDataSet();
            this.dgv_teinfo = new Guna.UI.WinForms.GunaDataGridView();
            this.bt_stclear = new System.Windows.Forms.Button();
            this.cb_tegen = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtp_teinfo = new System.Windows.Forms.DateTimePicker();
            this.bt_display = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_teemail = new System.Windows.Forms.TextBox();
            this.tb_tenum = new System.Windows.Forms.TextBox();
            this.tb_tename = new System.Windows.Forms.TextBox();
            this.tb_teid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.cb_al = new System.Windows.Forms.CheckBox();
            this.cb_ol = new System.Windows.Forms.CheckBox();
            this.cb_sec = new System.Windows.Forms.CheckBox();
            this.cb_pri = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_tesub = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoTbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sclManagementSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentInfoTbTableAdapter
            // 
            this.studentInfoTbTableAdapter.ClearBeforeFill = true;
            // 
            // studentInfoTbBindingSource
            // 
            this.studentInfoTbBindingSource.DataMember = "StudentInfoTb";
            this.studentInfoTbBindingSource.DataSource = this.sclManagementSystemDataSet;
            // 
            // sclManagementSystemDataSet
            // 
            this.sclManagementSystemDataSet.DataSetName = "sclManagementSystemDataSet";
            this.sclManagementSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgv_teinfo
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(189)))));
            this.dgv_teinfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_teinfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_teinfo.BackgroundColor = System.Drawing.Color.White;
            this.dgv_teinfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_teinfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_teinfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_teinfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_teinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(221)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(143)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_teinfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_teinfo.EnableHeadersVisualStyles = false;
            this.dgv_teinfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(186)))));
            this.dgv_teinfo.Location = new System.Drawing.Point(12, 523);
            this.dgv_teinfo.Name = "dgv_teinfo";
            this.dgv_teinfo.RowHeadersVisible = false;
            this.dgv_teinfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_teinfo.Size = new System.Drawing.Size(713, 210);
            this.dgv_teinfo.TabIndex = 27;
            this.dgv_teinfo.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.DeepOrange;
            this.dgv_teinfo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(189)))));
            this.dgv_teinfo.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_teinfo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_teinfo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_teinfo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_teinfo.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_teinfo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(186)))));
            this.dgv_teinfo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.dgv_teinfo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_teinfo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_teinfo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_teinfo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_teinfo.ThemeStyle.HeaderStyle.Height = 23;
            this.dgv_teinfo.ThemeStyle.ReadOnly = false;
            this.dgv_teinfo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(221)))), ((int)(((byte)(211)))));
            this.dgv_teinfo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_teinfo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_teinfo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_teinfo.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_teinfo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(143)))), ((int)(((byte)(107)))));
            this.dgv_teinfo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_teinfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_teinfo_CellClick);
            this.dgv_teinfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_teinfo_CellContentClick);
            // 
            // bt_stclear
            // 
            this.bt_stclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_stclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_stclear.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_stclear.Location = new System.Drawing.Point(373, 403);
            this.bt_stclear.Name = "bt_stclear";
            this.bt_stclear.Size = new System.Drawing.Size(88, 34);
            this.bt_stclear.TabIndex = 22;
            this.bt_stclear.Text = "Clear";
            this.bt_stclear.UseVisualStyleBackColor = false;
            this.bt_stclear.Click += new System.EventHandler(this.bt_stclear_Click);
            // 
            // cb_tegen
            // 
            this.cb_tegen.AutoCompleteCustomSource.AddRange(new string[] {
            "Male",
            "Female",
            "Other"});
            this.cb_tegen.FormattingEnabled = true;
            this.cb_tegen.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cb_tegen.Location = new System.Drawing.Point(140, 157);
            this.cb_tegen.Name = "cb_tegen";
            this.cb_tegen.Size = new System.Drawing.Size(320, 26);
            this.cb_tegen.TabIndex = 21;
            this.cb_tegen.Text = "Select";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(480, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // dtp_teinfo
            // 
            this.dtp_teinfo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_teinfo.Location = new System.Drawing.Point(140, 116);
            this.dtp_teinfo.Name = "dtp_teinfo";
            this.dtp_teinfo.Size = new System.Drawing.Size(320, 25);
            this.dtp_teinfo.TabIndex = 18;
            // 
            // bt_display
            // 
            this.bt_display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_display.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_display.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_display.Location = new System.Drawing.Point(612, 403);
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
            this.bt_delete.Location = new System.Drawing.Point(497, 403);
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
            this.bt_update.Location = new System.Drawing.Point(122, 403);
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
            this.bt_add.Location = new System.Drawing.Point(247, 403);
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
            this.bt_save.Location = new System.Drawing.Point(10, 403);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(88, 34);
            this.bt_save.TabIndex = 12;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = false;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(32)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(663, 11);
            this.button1.MaximumSize = new System.Drawing.Size(1920, 720);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 23);
            this.button1.TabIndex = 5;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_teemail
            // 
            this.tb_teemail.Location = new System.Drawing.Point(140, 238);
            this.tb_teemail.Name = "tb_teemail";
            this.tb_teemail.Size = new System.Drawing.Size(320, 25);
            this.tb_teemail.TabIndex = 11;
            // 
            // tb_tenum
            // 
            this.tb_tenum.Location = new System.Drawing.Point(140, 196);
            this.tb_tenum.Name = "tb_tenum";
            this.tb_tenum.Size = new System.Drawing.Size(320, 25);
            this.tb_tenum.TabIndex = 10;
            // 
            // tb_tename
            // 
            this.tb_tename.Location = new System.Drawing.Point(140, 73);
            this.tb_tename.Name = "tb_tename";
            this.tb_tename.Size = new System.Drawing.Size(320, 25);
            this.tb_tename.TabIndex = 7;
            // 
            // tb_teid
            // 
            this.tb_teid.Location = new System.Drawing.Point(140, 34);
            this.tb_teid.Name = "tb_teid";
            this.tb_teid.Size = new System.Drawing.Size(320, 25);
            this.tb_teid.TabIndex = 6;
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
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Date Of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Teacher Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Teacher Id";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(737, 57);
            this.panel2.TabIndex = 25;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(32)))));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(691, 14);
            this.button5.MaximumSize = new System.Drawing.Size(1920, 720);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(21, 20);
            this.button5.TabIndex = 4;
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(300, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "TEACHERS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.tb_search);
            this.groupBox1.Controls.Add(this.cb_al);
            this.groupBox1.Controls.Add(this.cb_ol);
            this.groupBox1.Controls.Add(this.cb_sec);
            this.groupBox1.Controls.Add(this.cb_pri);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tb_tesub);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bt_stclear);
            this.groupBox1.Controls.Add(this.cb_tegen);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.dtp_teinfo);
            this.groupBox1.Controls.Add(this.bt_display);
            this.groupBox1.Controls.Add(this.bt_delete);
            this.groupBox1.Controls.Add(this.bt_update);
            this.groupBox1.Controls.Add(this.bt_add);
            this.groupBox1.Controls.Add(this.bt_save);
            this.groupBox1.Controls.Add(this.tb_teemail);
            this.groupBox1.Controls.Add(this.tb_tenum);
            this.groupBox1.Controls.Add(this.tb_tename);
            this.groupBox1.Controls.Add(this.tb_teid);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 443);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teacher Information";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(11, 355);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(87, 35);
            this.btn_search.TabIndex = 46;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(131, 365);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(236, 25);
            this.tb_search.TabIndex = 45;
            // 
            // cb_al
            // 
            this.cb_al.AutoSize = true;
            this.cb_al.Location = new System.Drawing.Point(409, 324);
            this.cb_al.Name = "cb_al";
            this.cb_al.Size = new System.Drawing.Size(55, 22);
            this.cb_al.TabIndex = 31;
            this.cb_al.Text = "A/L";
            this.cb_al.UseVisualStyleBackColor = true;
            // 
            // cb_ol
            // 
            this.cb_ol.AutoSize = true;
            this.cb_ol.Location = new System.Drawing.Point(345, 324);
            this.cb_ol.Name = "cb_ol";
            this.cb_ol.Size = new System.Drawing.Size(58, 22);
            this.cb_ol.TabIndex = 30;
            this.cb_ol.Text = "O/L";
            this.cb_ol.UseVisualStyleBackColor = true;
            // 
            // cb_sec
            // 
            this.cb_sec.AutoSize = true;
            this.cb_sec.Location = new System.Drawing.Point(235, 324);
            this.cb_sec.Name = "cb_sec";
            this.cb_sec.Size = new System.Drawing.Size(104, 22);
            this.cb_sec.TabIndex = 29;
            this.cb_sec.Text = "Secondary";
            this.cb_sec.UseVisualStyleBackColor = true;
            // 
            // cb_pri
            // 
            this.cb_pri.AutoSize = true;
            this.cb_pri.Location = new System.Drawing.Point(140, 323);
            this.cb_pri.Name = "cb_pri";
            this.cb_pri.Size = new System.Drawing.Size(89, 22);
            this.cb_pri.TabIndex = 28;
            this.cb_pri.Text = "Primary";
            this.cb_pri.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 18);
            this.label9.TabIndex = 27;
            this.label9.Text = "Subejct Section";
            // 
            // tb_tesub
            // 
            this.tb_tesub.Location = new System.Drawing.Point(140, 283);
            this.tb_tesub.Name = "tb_tesub";
            this.tb_tesub.Size = new System.Drawing.Size(320, 25);
            this.tb_tesub.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Subject";
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 763);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_teinfo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Teacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher";
            this.Load += new System.EventHandler(this.Teacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoTbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sclManagementSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private sclManagementSystemDataSetTableAdapters.StudentInfoTbTableAdapter studentInfoTbTableAdapter;
        private System.Windows.Forms.BindingSource studentInfoTbBindingSource;
        private sclManagementSystemDataSet sclManagementSystemDataSet;
        private Guna.UI.WinForms.GunaDataGridView dgv_teinfo;
        private System.Windows.Forms.Button bt_stclear;
        private System.Windows.Forms.ComboBox cb_tegen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtp_teinfo;
        private System.Windows.Forms.Button bt_display;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_teemail;
        private System.Windows.Forms.TextBox tb_tenum;
        private System.Windows.Forms.TextBox tb_tename;
        private System.Windows.Forms.TextBox tb_teid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_tesub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cb_al;
        private System.Windows.Forms.CheckBox cb_ol;
        private System.Windows.Forms.CheckBox cb_sec;
        private System.Windows.Forms.CheckBox cb_pri;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_search;
    }
}
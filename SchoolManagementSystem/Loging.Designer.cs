namespace SchoolManagementSystem
{
    partial class loging_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loging_form));
            this.pl_head = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_pass = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_lg = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_uername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_sign = new System.Windows.Forms.Label();
            this.pl_head.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_head
            // 
            this.pl_head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.pl_head.Controls.Add(this.label1);
            this.pl_head.Controls.Add(this.bt_close);
            this.pl_head.Location = new System.Drawing.Point(0, 0);
            this.pl_head.Name = "pl_head";
            this.pl_head.Size = new System.Drawing.Size(702, 26);
            this.pl_head.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "School Management System | Login";
            // 
            // bt_close
            // 
            this.bt_close.BackColor = System.Drawing.Color.White;
            this.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_close.Location = new System.Drawing.Point(672, 0);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(27, 26);
            this.bt_close.TabIndex = 0;
            this.bt_close.Text = "X";
            this.bt_close.UseVisualStyleBackColor = false;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cb_pass);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_lg);
            this.panel1.Controls.Add(this.tb_password);
            this.panel1.Controls.Add(this.tb_uername);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lb_sign);
            this.panel1.Location = new System.Drawing.Point(194, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 374);
            this.panel1.TabIndex = 1;
            // 
            // cb_pass
            // 
            this.cb_pass.AutoSize = true;
            this.cb_pass.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_pass.Location = new System.Drawing.Point(179, 235);
            this.cb_pass.Name = "cb_pass";
            this.cb_pass.Size = new System.Drawing.Size(108, 18);
            this.cb_pass.TabIndex = 10;
            this.cb_pass.Text = "Show Password";
            this.cb_pass.UseVisualStyleBackColor = true;
            this.cb_pass.CheckedChanged += new System.EventHandler(this.cb_pass_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(251, 186);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(251, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(46, 213);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(199, 3);
            this.panel3.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(46, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 3);
            this.panel2.TabIndex = 6;
            // 
            // btn_lg
            // 
            this.btn_lg.BackColor = System.Drawing.Color.Green;
            this.btn_lg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lg.Font = new System.Drawing.Font("Big John", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lg.Location = new System.Drawing.Point(73, 268);
            this.btn_lg.Name = "btn_lg";
            this.btn_lg.Size = new System.Drawing.Size(149, 42);
            this.btn_lg.TabIndex = 5;
            this.btn_lg.Text = "Login";
            this.btn_lg.UseVisualStyleBackColor = false;
            this.btn_lg.Click += new System.EventHandler(this.btn_lg_Click);
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.White;
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_password.Location = new System.Drawing.Point(46, 193);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(199, 13);
            this.tb_password.TabIndex = 4;
            this.tb_password.TextChanged += new System.EventHandler(this.tb_password_TextChanged);
            // 
            // tb_uername
            // 
            this.tb_uername.BackColor = System.Drawing.Color.White;
            this.tb_uername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_uername.Location = new System.Drawing.Point(46, 127);
            this.tb_uername.Name = "tb_uername";
            this.tb_uername.Size = new System.Drawing.Size(199, 13);
            this.tb_uername.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lb_sign
            // 
            this.lb_sign.AutoSize = true;
            this.lb_sign.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sign.Location = new System.Drawing.Point(95, 45);
            this.lb_sign.Name = "lb_sign";
            this.lb_sign.Size = new System.Drawing.Size(96, 30);
            this.lb_sign.TabIndex = 0;
            this.lb_sign.Text = "Sign In";
            // 
            // loging_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pl_head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loging_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.pl_head.ResumeLayout(false);
            this.pl_head.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_head;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_lg;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_uername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_sign;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cb_pass;
    }
}
namespace SchoolManagementSystem
{
    partial class intro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(intro));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pl_color = new System.Windows.Forms.Panel();
            this.pl_loading = new System.Windows.Forms.Panel();
            this.lb_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(240, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pl_color
            // 
            this.pl_color.BackColor = System.Drawing.Color.White;
            this.pl_color.Location = new System.Drawing.Point(2, 273);
            this.pl_color.Name = "pl_color";
            this.pl_color.Size = new System.Drawing.Size(85, 26);
            this.pl_color.TabIndex = 1;
            // 
            // pl_loading
            // 
            this.pl_loading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(32)))));
            this.pl_loading.Location = new System.Drawing.Point(2, 273);
            this.pl_loading.Name = "pl_loading";
            this.pl_loading.Size = new System.Drawing.Size(523, 26);
            this.pl_loading.TabIndex = 2;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Crafter", 12F, System.Drawing.FontStyle.Bold);
            this.lb_name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_name.Location = new System.Drawing.Point(116, 151);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(334, 16);
            this.lb_name.TabIndex = 3;
            this.lb_name.Text = "School Management Systen";
            // 
            // intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(525, 300);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.pl_color);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pl_loading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "intro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pl_color;
        private System.Windows.Forms.Panel pl_loading;
        private System.Windows.Forms.Label lb_name;
    }
}


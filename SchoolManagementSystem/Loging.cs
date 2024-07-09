﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class loging_form : Form
    {
        public loging_form()
        {
            InitializeComponent();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_lg_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = " data source = DESKTOP-LDJQNC1\\SQLEXPRESS; database = sclManagementSystem; integrated security=true ";
            SqlCommand comd = new SqlCommand();
            comd.Connection = conn;

            comd.CommandText = " select * from LogingTb where Username='" + tb_uername.Text + "' and Password ='" + tb_password.Text + "'";
            SqlDataAdapter dta = new SqlDataAdapter(comd);
            DataSet des = new DataSet();
            dta.Fill(des);

            if (des.Tables[0].Rows.Count != 0)
            {
                MessageBox.Show("Your Loging is complete", "Succsses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                Mainfoam dashboard = new Mainfoam();
                dashboard.Show();


            }

            else
            {
                MessageBox.Show("Wrong username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cb_pass_CheckedChanged(object sender, EventArgs e)
        {
            tb_password.PasswordChar = cb_pass.Checked ? '\0' : '*';
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolManagementSystem
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

       

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void gunaGradientPanel1_Click(object sender, EventArgs e)
        {
          
        }

        private void Student_Load(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LDJQNC1\SQLEXPRESS;Initial Catalog=sclManagementSystem;Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO StudentInfoTb (Student_Id, Student_Name, Dob, Gender, Phone_Num, Email) VALUES (@Student_Id, @Student_Name, @Dob, @Gender, @Phone_Num, @Email)", conn);

            cmd.Parameters.AddWithValue("@Student_Id", int.Parse(tb_stid.Text));
            cmd.Parameters.AddWithValue("@Student_Name", tb_stname.Text);
            cmd.Parameters.AddWithValue("@Dob", dtp_stinfo.Value);
            cmd.Parameters.AddWithValue("@Gender", cb_stgen.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Phone_Num", tb_stnum.Text);
            cmd.Parameters.AddWithValue("@Email", tb_stemail.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Record Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
             dtp_stinfo.CustomFormat = "dd/MM/yyyy";
        }

        private void dtp_stinfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtp_stinfo.CustomFormat = "";
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
           
        }
    }
}

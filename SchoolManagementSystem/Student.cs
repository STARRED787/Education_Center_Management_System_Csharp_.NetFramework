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
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LDJQNC1\SQLEXPRESS;Initial Catalog=sclManagementSystem;Integrated Security=True");
            conn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM StudentInfoTb", conn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd; // Set the SelectCommand property

                DataTable table = new DataTable();
                adapter.Fill(table); // Fill the DataTable with the results of the SQL query

                dgv_stinfo.DataSource = table; // Assuming dgv_stinfo DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dgv_stinfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LDJQNC1\SQLEXPRESS;Initial Catalog=sclManagementSystem;Integrated Security=True");
            conn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE StudentInfoTb SET Student_Name = @Student_Name, Dob = @Dob, Gender = @Gender, Phone_Num = @Phone_Num, Email = @Email WHERE Student_Id = @Student_Id", conn);

                cmd.Parameters.AddWithValue("@Student_Id", int.Parse(tb_stid.Text));
                cmd.Parameters.AddWithValue("@Student_Name", tb_stname.Text);
                cmd.Parameters.AddWithValue("@Dob", dtp_stinfo.Value);
                cmd.Parameters.AddWithValue("@Gender", cb_stgen.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Phone_Num", tb_stnum.Text);
                cmd.Parameters.AddWithValue("@Email", tb_stemail.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void bt_stclear_Click(object sender, EventArgs e)
        {
            tb_stid.Clear();
            tb_stname.Clear();
            dtp_stinfo.Value = DateTime.Now; // Reset the date picker to the current date
            cb_stgen.SelectedIndex = -1; // Deselect any selected item
            tb_stnum.Clear();
            tb_stemail.Clear();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LDJQNC1\SQLEXPRESS;Initial Catalog=sclManagementSystem;Integrated Security=True");
            conn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM StudentInfoTb WHERE Student_Id = @Student_Id", conn);

                cmd.Parameters.AddWithValue("@Student_Id", int.Parse(tb_stid.Text));

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No record found with the given Student_Id", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void bt_display_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LDJQNC1\SQLEXPRESS;Initial Catalog=sclManagementSystem;Integrated Security=True");
            conn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM StudentInfoTb", conn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd; // Set the SelectCommand property

                DataTable table = new DataTable();
                adapter.Fill(table); // Fill the DataTable with the results of the SQL query

                dgv_stinfo.DataSource = table; // Assuming dgv_stinfo DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

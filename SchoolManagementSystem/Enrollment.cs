using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Enrollment : Form
    {
        public Enrollment()
        {
            InitializeComponent();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            // Basic validation checks
            if (string.IsNullOrWhiteSpace(tb_enid.Text) ||
                string.IsNullOrWhiteSpace(tb_enstid.Text) ||
                string.IsNullOrWhiteSpace(tb_enstname.Text) )
               
            {
                MessageBox.Show("Please fill all required fields and select at least one section", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tb_enid.Text, out int EnrolllId))
            {
                MessageBox.Show("Invalid Student ID", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

       

            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LDJQNC1\SQLEXPRESS;Initial Catalog=sclManagementSystem;Integrated Security=True"))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO EnrollmentInfoTbl (Enroll_Id, Student_Id, Student_Name, Doe) VALUES (@Enroll_Id, @Student_Id, @Student_Name, @Doe)", conn);

                    cmd.Parameters.AddWithValue("@Enroll_Id", EnrolllId);
                    cmd.Parameters.AddWithValue("@Student_Id", tb_enid.Text);
                    cmd.Parameters.AddWithValue("@Student_Name", tb_enstname.Text);
                    cmd.Parameters.AddWithValue("@Doe", dtp_eninfo.Value);
                 
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dtp_eninfo.CustomFormat = "dd/MM/yyyy";
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            // Basic validation checks
            if (string.IsNullOrWhiteSpace(tb_enid.Text) ||
                string.IsNullOrWhiteSpace(tb_enstid.Text) ||
                string.IsNullOrWhiteSpace(tb_enstname.Text))
            {
                MessageBox.Show("Please fill all required fields and select at least one section", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tb_enid.Text, out int EnrolllId))
            {
                MessageBox.Show("Invalid Enrollment ID", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LDJQNC1\SQLEXPRESS;Initial Catalog=sclManagementSystem;Integrated Security=True"))
            {
                try
                {
                    conn.Open();

                    // Update command to update existing record based on Enrollment ID
                    SqlCommand cmd = new SqlCommand("UPDATE EnrollmentInfoTbl SET Student_Id = @Student_Id, Student_Name = @Student_Name, Doe = @Doe WHERE Enroll_Id = @Enroll_Id", conn);

                    cmd.Parameters.AddWithValue("@Enroll_Id", EnrolllId);
                    cmd.Parameters.AddWithValue("@Student_Id", tb_enstid.Text); // Use Student ID textbox value
                    cmd.Parameters.AddWithValue("@Student_Name", tb_enstname.Text);
                    cmd.Parameters.AddWithValue("@Doe", dtp_eninfo.Value);

                    int rowsAffected = cmd.ExecuteNonQuery(); // Execute the update command

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No record found with the provided Enrollment ID.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            // Basic validation checks
            if (string.IsNullOrWhiteSpace(tb_enid.Text))
            {
                MessageBox.Show("Please enter a valid Enrollment ID to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tb_enid.Text, out int EnrolllId))
            {
                MessageBox.Show("Invalid Enrollment ID", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LDJQNC1\SQLEXPRESS;Initial Catalog=sclManagementSystem;Integrated Security=True"))
            {
                try
                {
                    conn.Open();

                    // Delete command to delete the record based on Enrollment ID
                    SqlCommand cmd = new SqlCommand("DELETE FROM EnrollmentInfoTbl WHERE Enroll_Id = @Enroll_Id", conn);

                    cmd.Parameters.AddWithValue("@Enroll_Id", EnrolllId);

                    int rowsAffected = cmd.ExecuteNonQuery(); // Execute the delete command

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No record found with the provided Enrollment ID.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

        }

        private void bt_stclear_Click(object sender, EventArgs e)
        {
           
                // Clear all TextBox fields
                tb_enid.Text = string.Empty;
                tb_enstid.Text = string.Empty;
                tb_enstname.Text = string.Empty;

                // Reset DateTimePicker to current date
                dtp_eninfo.Value = DateTime.Now;


;
            }

        private void bt_display_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LDJQNC1\SQLEXPRESS;Initial Catalog=sclManagementSystem;Integrated Security=True"))
                {
                    conn.Open();
                  
                    string sql = "SELECT Enroll_Id, Student_Id, Student_Name, Doe FROM EnrollmentInfoTbl";

                    SqlCommand cmd = new SqlCommand(sql, conn); // Create SqlCommand with the SQL query

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd); // Create SqlDataAdapter with the SqlCommand

                    DataTable table = new DataTable();
                    adapter.Fill(table); // Fill the DataTable with the results of the SQL query

                    dgv_eninfo.DataSource = table; // Assuming dgv_stinfo is a DataGridView

                    // Optional: Auto-resize columns to fit content
                    dgv_eninfo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_eninfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked row index is valid (to avoid index out of range errors)
            if (e.RowIndex >= 0)
            {
                // Get the current row
                DataGridViewRow row = dgv_eninfo.Rows[e.RowIndex];

                // Assuming the DataGridView columns are in this order:
                // Enroll_Id, Student_Id, Student_Name, Doe

                // Set the values from the selected row to the TextBoxes or other controls
                tb_enid.Text = row.Cells["Enroll_Id"].Value.ToString();
                tb_enstid.Text = row.Cells["Student_Id"].Value.ToString();
                tb_enstname.Text = row.Cells["Student_Name"].Value.ToString();

                // Parse the date value to set it to the DateTimePicker
                dtp_eninfo.Value = DateTime.Parse(row.Cells["Doe"].Value.ToString());

            }
        }

        private void Enrollment_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LDJQNC1\SQLEXPRESS;Initial Catalog=sclManagementSystem;Integrated Security=True");
            conn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM EnrollmentInfoTbl", conn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd; // Set the SelectCommand property

                DataTable table = new DataTable();
                adapter.Fill(table); // Fill the DataTable with the results of the SQL query

                dgv_eninfo.DataSource = table; // Assuming dgv_stinfo DataGridView
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

        private void bt_add_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LDJQNC1\SQLEXPRESS;Initial Catalog=sclManagementSystem;Integrated Security=True");
            conn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM EnrollmentInfoTbl", conn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd; // Set the SelectCommand property

                DataTable table = new DataTable();
                adapter.Fill(table); // Fill the DataTable with the results of the SQL query

                dgv_eninfo.DataSource = table; // Assuming dgv_stinfo DataGridView
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

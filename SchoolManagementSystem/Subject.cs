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
    public partial class Subject : Form
    {
        public Subject()
        {
            InitializeComponent();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            // Basic validation checks
            if (string.IsNullOrWhiteSpace(tb_subid.Text) ||
                string.IsNullOrWhiteSpace(tb_subname.Text) ||
                (!cb_pri.Checked && !cb_sec.Checked && !cb_ol.Checked && !cb_al.Checked)) // Ensure at least one section is selected
            {
                MessageBox.Show("Please fill all required fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tb_subid.Text, out int subjectId))
            {
                MessageBox.Show("Invalid Subject ID", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create a list to hold selected sections
            List<string> selectedSections = new List<string>();
            if (cb_pri.Checked) selectedSections.Add("Primary");
            if (cb_sec.Checked) selectedSections.Add("Secondary");
            if (cb_ol.Checked) selectedSections.Add("O/L");
            if (cb_al.Checked) selectedSections.Add("A/L");

            // Join selected sections into a single string, separated by commas
            string selectedSectionsString = string.Join(", ", selectedSections);

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LDJQNC1\SQLEXPRESS;Initial Catalog=sclManagementSystem;Integrated Security=True");
            conn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO SubjectInfoTb (subject_Id, subject_Name, subject_Section) VALUES (@subject_Id, @subject_Name, @subject_Section)", conn);

                cmd.Parameters.AddWithValue("@subject_Id", subjectId);
                cmd.Parameters.AddWithValue("@subject_Name", tb_subname.Text);
                cmd.Parameters.AddWithValue("@subject_Section", selectedSectionsString);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgv_subinfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bt_display_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LDJQNC1\SQLEXPRESS;Initial Catalog=sclManagementSystem;Integrated Security=True"))
                {
                    conn.Open();

                    string sql = "SELECT subject_Id, subject_Name, subject_Section FROM SubjectInfoTb";

                    SqlCommand cmd = new SqlCommand(sql, conn); // Create SqlCommand with the SQL query

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd); // Create SqlDataAdapter with the SqlCommand

                    DataTable table = new DataTable();
                    adapter.Fill(table); // Fill the DataTable with the results of the SQL query

                    dgv_subinfo.DataSource = table; // Assuming dgv_stinfo is a DataGridView

                    // Optional: Auto-resize columns to fit content
                    dgv_subinfo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Subject_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LDJQNC1\SQLEXPRESS;Initial Catalog=sclManagementSystem;Integrated Security=True"))
                {
                    conn.Open();

                    string sql = "SELECT subject_Id, subject_Name, subject_Section FROM SubjectInfoTb";

                    SqlCommand cmd = new SqlCommand(sql, conn); // Create SqlCommand with the SQL query

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd); // Create SqlDataAdapter with the SqlCommand

                    DataTable table = new DataTable();
                    adapter.Fill(table); // Fill the DataTable with the results of the SQL query

                    dgv_subinfo.DataSource = table; // Assuming dgv_stinfo is a DataGridView

                    // Optional: Auto-resize columns to fit content
                    dgv_subinfo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LDJQNC1\SQLEXPRESS;Initial Catalog=sclManagementSystem;Integrated Security=True"))
                {
                    conn.Open();

                    string sql = "SELECT subject_Id, subject_Name, subject_Section FROM SubjectInfoTb";

                    SqlCommand cmd = new SqlCommand(sql, conn); // Create SqlCommand with the SQL query

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd); // Create SqlDataAdapter with the SqlCommand

                    DataTable table = new DataTable();
                    adapter.Fill(table); // Fill the DataTable with the results of the SQL query

                    dgv_subinfo.DataSource = table; // Assuming dgv_stinfo is a DataGridView

                    // Optional: Auto-resize columns to fit content
                    dgv_subinfo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_stclear_Click(object sender, EventArgs e)
        {
            tb_subid.Clear();             // Clear Subject ID textbox
            tb_subname.Clear();           // Clear Subject Name textbox

            // Uncheck all checkboxes
            cb_pri.Checked = false;
            cb_sec.Checked = false;
            cb_ol.Checked = false;
            cb_al.Checked = false;

        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
           
            // Validate if Subject ID is an integer
            if (!int.TryParse(tb_subid.Text, out int subjectId))
            {
                MessageBox.Show("Invalid Subject ID", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm deletion with the user
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult != DialogResult.Yes) return;

            string connectionString = @"Data Source=DESKTOP-LDJQNC1\SQLEXPRESS;Initial Catalog=sclManagementSystem;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM SubjectInfoTb WHERE subject_Id = @subject_Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@subject_Id", subjectId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                        else
                        {
                            MessageBox.Show("No record found with the given Subject ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            // Method to Update Subject Information in the Database
            
                // Validate Subject ID input
                if (string.IsNullOrWhiteSpace(tb_subid.Text))
                {
                    MessageBox.Show("Please enter the Subject ID to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ensure Subject ID is an integer
                if (!int.TryParse(tb_subid.Text, out int subjectId))
                {
                    MessageBox.Show("Invalid Subject ID", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate Subject Name input
                if (string.IsNullOrWhiteSpace(tb_subname.Text))
                {
                    MessageBox.Show("Please enter the Subject Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ensure at least one section is selected
                if (!cb_pri.Checked && !cb_sec.Checked && !cb_ol.Checked && !cb_al.Checked)
                {
                    MessageBox.Show("Please select at least one section.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get selected sections as a comma-separated string
                string selectedSections = GetSelectedSections();

                string connectionString = @"Data Source=DESKTOP-LDJQNC1\SQLEXPRESS;Initial Catalog=sclManagementSystem;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    try
                    {
                        // SQL command to update subject information
                        SqlCommand cmd = new SqlCommand("UPDATE SubjectInfoTb SET subject_Name = @subject_Name, subject_Section = @subject_Section WHERE subject_Id = @subject_Id", conn);

                        // Add parameters to the command
                        cmd.Parameters.AddWithValue("@subject_Id", subjectId);
                        cmd.Parameters.AddWithValue("@subject_Name", tb_subname.Text);
                        cmd.Parameters.AddWithValue("@subject_Section", selectedSections);

                        // Execute the command
                        cmd.ExecuteNonQuery();

                        // Notify user of success
                        MessageBox.Show("Record Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear input fields after update
                        ClearFields();
                    }
                    catch (Exception ex)
                    {
                        // Display error message
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Close the connection
                        conn.Close();
                    }
                }
                
            }

            // Method to Get Selected Sections as a Comma-Separated String
            private string GetSelectedSections()
            {
                List<string> selectedSections = new List<string>();
            if (cb_pri.Checked) selectedSections.Add("Primary");
            if (cb_sec.Checked) selectedSections.Add("Secondary");
            if (cb_ol.Checked) selectedSections.Add("O/L");
            if (cb_al.Checked) selectedSections.Add("A/L");

            return string.Join(", ", selectedSections);
            }

            // Method to Clear Input Fields and Reset Checkboxes
            private void ClearFields()
            {
                tb_subid.Clear();             // Clear Subject ID textbox
                tb_subname.Clear();           // Clear Subject Name textbox

                cb_pri.Checked = false;       // Uncheck Section A
                cb_sec.Checked = false;       // Uncheck Section B
                cb_ol.Checked = false;        // Uncheck Section C
                cb_al.Checked = false;        // Uncheck Section D
            }

        }



    }



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SchoolManagementSystem
{
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            // Basic validation checks
            if (string.IsNullOrWhiteSpace(tb_teid.Text) ||
                string.IsNullOrWhiteSpace(tb_tename.Text) ||
                string.IsNullOrWhiteSpace(tb_tenum.Text) ||
                string.IsNullOrWhiteSpace(tb_teemail.Text) ||
                string.IsNullOrWhiteSpace(tb_tesub.Text) ||
                cb_tegen.SelectedItem == null ||
                (!cb_pri.Checked && !cb_sec.Checked && !cb_ol.Checked && !cb_al.Checked))  // New validation for checkboxes
            {
                MessageBox.Show("Please fill all required fields and select at least one section", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tb_teid.Text, out int studentId))
            {
                MessageBox.Show("Invalid Student ID", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(tb_tenum.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Phone number must be exactly 10 digits", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Collect checkbox values (e.g., sections selected)
            string selectedSections = "";
            if (cb_pri.Checked) selectedSections += "Primary, ";
            if (cb_sec.Checked) selectedSections += "Secondary, ";
            if (cb_ol.Checked) selectedSections += "O/L, ";
            if (cb_al.Checked) selectedSections += "A/L, ";

            // Remove the trailing comma and space
            selectedSections = selectedSections.TrimEnd(',', ' ');

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LDJQNC1\SQLEXPRESS;Initial Catalog=sclManagementSystem;Integrated Security=True");
            conn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO TeacherInfoTbl (Teacher_Id, Teacher_Name, Dob, Gender, Phone_Num, Email, Subject, Subject_Section) VALUES (@Teacher_Id, @Teacher_Name, @Dob, @Gender, @Phone_Num, @Email, @Subject, @Subject_Section)", conn);

                cmd.Parameters.AddWithValue("@Teacher_Id", studentId);
                cmd.Parameters.AddWithValue("@Teacher_Name", tb_tename.Text);
                cmd.Parameters.AddWithValue("@Dob", dtp_teinfo.Value);
                cmd.Parameters.AddWithValue("@Gender", cb_tegen.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Phone_Num", tb_tenum.Text);
                cmd.Parameters.AddWithValue("@Email", tb_teemail.Text);
                cmd.Parameters.AddWithValue("@Subject", tb_tesub.Text);
                cmd.Parameters.AddWithValue("@Subject_Section", selectedSections);  // Include selected sections

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

        private void Teacher_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LDJQNC1\SQLEXPRESS;Initial Catalog=sclManagementSystem;Integrated Security=True"))
                {
                    conn.Open();

                    string sql = "SELECT Teacher_Id, Teacher_Name, Dob, Gender, Phone_Num, Email, Subject, Subject_Section FROM TeacherInfoTbl";

                    SqlCommand cmd = new SqlCommand(sql, conn); // Create SqlCommand with the SQL query

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd); // Create SqlDataAdapter with the SqlCommand

                    DataTable table = new DataTable();
                    adapter.Fill(table); // Fill the DataTable with the results of the SQL query

                    dgv_teinfo.DataSource = table; // Assuming dgv_stinfo is a DataGridView

                    // Optional: Auto-resize columns to fit content
                    dgv_teinfo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
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

                    string sql = "SELECT Teacher_Id, Teacher_Name, Dob, Gender, Phone_Num, Email, Subject, Subject_Section FROM TeacherInfoTbl";

                    SqlCommand cmd = new SqlCommand(sql, conn); // Create SqlCommand with the SQL query

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd); // Create SqlDataAdapter with the SqlCommand

                    DataTable table = new DataTable();
                    adapter.Fill(table); // Fill the DataTable with the results of the SQL query

                    dgv_teinfo.DataSource = table; // Assuming dgv_stinfo is a DataGridView

                    // Optional: Auto-resize columns to fit content
                    dgv_teinfo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_display_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LDJQNC1\SQLEXPRESS;Initial Catalog=sclManagementSystem;Integrated Security=True"))
                {
                    conn.Open();

                    string sql = "SELECT Teacher_Id, Teacher_Name, Dob, Gender, Phone_Num, Email, Subject, Subject_Section FROM TeacherInfoTbl";

                    SqlCommand cmd = new SqlCommand(sql, conn); // Create SqlCommand with the SQL query

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd); // Create SqlDataAdapter with the SqlCommand

                    DataTable table = new DataTable();
                    adapter.Fill(table); // Fill the DataTable with the results of the SQL query

                    dgv_teinfo.DataSource = table; // Assuming dgv_stinfo is a DataGridView

                    // Optional: Auto-resize columns to fit content
                    dgv_teinfo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            // Basic validation checks
            if (string.IsNullOrWhiteSpace(tb_teid.Text) ||
                string.IsNullOrWhiteSpace(tb_tename.Text) ||
                string.IsNullOrWhiteSpace(tb_tenum.Text) ||
                string.IsNullOrWhiteSpace(tb_teemail.Text) ||
                string.IsNullOrWhiteSpace(tb_tesub.Text) ||
                cb_tegen.SelectedItem == null ||
                (!cb_pri.Checked && !cb_sec.Checked && !cb_ol.Checked && !cb_al.Checked)) // Validation for checkboxes
            {
                MessageBox.Show("Please fill all required fields and select at least one section", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tb_teid.Text, out int studentId))
            {
                MessageBox.Show("Invalid Student ID", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(tb_tenum.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Phone number must be exactly 10 digits", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Collect checkbox values (e.g., sections selected)
            string selectedSections = "";
            if (cb_pri.Checked) selectedSections += "Primary, ";
            if (cb_sec.Checked) selectedSections += "Secondary, ";
            if (cb_ol.Checked) selectedSections += "O/L, ";
            if (cb_al.Checked) selectedSections += "A/L, ";


            // Remove the trailing comma and space
            selectedSections = selectedSections.TrimEnd(',', ' ');

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LDJQNC1\SQLEXPRESS;Initial Catalog=sclManagementSystem;Integrated Security=True");
            conn.Open();

            try
            {
                // Check if record exists
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM TeacherInfoTbl WHERE Teacher_Id = @Teacher_Id", conn);
                checkCmd.Parameters.AddWithValue("@Teacher_Id", studentId);

                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    // Update the existing record
                    SqlCommand updateCmd = new SqlCommand("UPDATE TeacherInfoTbl SET Teacher_Name = @Teacher_Name, Dob = @Dob, Gender = @Gender, Phone_Num = @Phone_Num, Email = @Email, Subject = @Subject, Subject_Section = @Subject_Section WHERE Teacher_Id = @Teacher_Id", conn);

                    updateCmd.Parameters.AddWithValue("@Teacher_Id", studentId);
                    updateCmd.Parameters.AddWithValue("@Teacher_Name", tb_tename.Text);
                    updateCmd.Parameters.AddWithValue("@Dob", dtp_teinfo.Value);
                    updateCmd.Parameters.AddWithValue("@Gender", cb_tegen.SelectedItem.ToString());
                    updateCmd.Parameters.AddWithValue("@Phone_Num", tb_tenum.Text);
                    updateCmd.Parameters.AddWithValue("@Email", tb_teemail.Text);
                    updateCmd.Parameters.AddWithValue("@Subject", tb_tesub.Text);
                    updateCmd.Parameters.AddWithValue("@Subject_Section", selectedSections);  // Include selected sections

                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show("Record Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Record not found with the provided Teacher ID", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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

        private void dgv_teinfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                // Ensure the click is on a valid row (not header row)
                if (e.RowIndex >= 0)
                {
                    // Get the DataGridViewRow object
                    DataGridViewRow row = dgv_teinfo.Rows[e.RowIndex];

                    // Populate the textboxes with the values from the selected row
                    tb_teid.Text = row.Cells["Teacher_Id"].Value.ToString();
                    tb_tename.Text = row.Cells["Teacher_Name"].Value.ToString();
                    dtp_teinfo.Value = Convert.ToDateTime(row.Cells["Dob"].Value);
                    cb_tegen.SelectedItem = row.Cells["Gender"].Value.ToString();
                    tb_tenum.Text = row.Cells["Phone_Num"].Value.ToString();
                    tb_teemail.Text = row.Cells["Email"].Value.ToString();
                    tb_tesub.Text = row.Cells["Subject"].Value.ToString();

                    // Clear all checkboxes first
                    cb_pri.Checked = false;
                    cb_sec.Checked = false;
                    cb_ol.Checked = false;
                    cb_al.Checked = false;

                    // Get selected sections and check the relevant checkboxes
                    string selectedSections = row.Cells["Subject_Section"].Value.ToString();
                    if (selectedSections.Contains("Primary")) cb_pri.Checked = true;
                    if (selectedSections.Contains("Secondary")) cb_sec.Checked = true;
                    if (selectedSections.Contains("O/L")) cb_ol.Checked = true;
                    if (selectedSections.Contains("A/L")) cb_al.Checked = true;
                }
            }

        private void bt_stclear_Click(object sender, EventArgs e)
        {
            // Clear all textboxes
            tb_teid.Clear();
            tb_tename.Clear();
            tb_tenum.Clear();
            tb_teemail.Clear();
            tb_tesub.Clear();
            tb_search.Clear();

            // Reset the DateTimePicker to today's date
            dtp_teinfo.Value = DateTime.Now;

            // Reset the ComboBox
            cb_tegen.SelectedItem = null;

            // Uncheck all checkboxes
            cb_pri.Checked = false;
            cb_sec.Checked = false;
            cb_ol.Checked = false;
            cb_al.Checked = false;
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            // Check if a valid Teacher ID is selected
            if (string.IsNullOrWhiteSpace(tb_teid.Text) || !int.TryParse(tb_teid.Text, out int teacherId))
            {
                MessageBox.Show("Please select a valid record to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm delete action
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LDJQNC1\SQLEXPRESS;Initial Catalog=sclManagementSystem;Integrated Security=True"))
                {
                    try
                    {
                        conn.Open();

                        // SQL DELETE command
                        SqlCommand cmd = new SqlCommand("DELETE FROM TeacherInfoTbl WHERE Teacher_Id = @Teacher_Id", conn);
                        cmd.Parameters.AddWithValue("@Teacher_Id", teacherId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Optionally, refresh the DataGridView to reflect the changes
                            bt_display_Click(sender, e); // Assuming this method reloads the data
                        }
                        else
                        {
                            MessageBox.Show("No record found to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while deleting the record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        
    }

        private void dgv_teinfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            // Get the search ID from the search textbox
            string searchId = tb_search.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchId))
            {
                MessageBox.Show("Please enter a Teacher ID to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(searchId, out int teacherId))
            {
                MessageBox.Show("Invalid Teacher ID. Please enter a valid numeric ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LDJQNC1\SQLEXPRESS;Initial Catalog=sclManagementSystem;Integrated Security=True"))
                {
                    conn.Open();

                    // Use a parameterized query to prevent SQL injection
                    string sql = "SELECT Teacher_Id, Teacher_Name, Dob, Gender, Phone_Num, Email, Subject, Subject_Section FROM TeacherInfoTbl WHERE Teacher_Id = @Teacher_Id";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Teacher_Id", teacherId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        // Display the first result in the TextBoxes and other controls
                        DataRow row = table.Rows[0];

                        tb_teid.Text = row["Teacher_Id"].ToString();
                        tb_tename.Text = row["Teacher_Name"].ToString();
                        dtp_teinfo.Value = DateTime.Parse(row["Dob"].ToString());
                        cb_tegen.SelectedItem = row["Gender"].ToString();
                        tb_tenum.Text = row["Phone_Num"].ToString();
                        tb_teemail.Text = row["Email"].ToString();
                        tb_tesub.Text = row["Subject"].ToString();

                        // Set checkboxes based on the sections string from the database
                        string[] sections = row["Subject_Section"].ToString().Split(new[] { ", " }, StringSplitOptions.None);
                        cb_pri.Checked = sections.Contains("Primary");
                        cb_sec.Checked = sections.Contains("Secondary");
                        cb_ol.Checked = sections.Contains("O/L");
                        cb_al.Checked = sections.Contains("A/L");
                    }
                    else
                    {
                        MessageBox.Show("No records found for the provided Teacher ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

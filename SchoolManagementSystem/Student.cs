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
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


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
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LDJQNC1\SQLEXPRESS;Initial Catalog=sclManagementSystem;Integrated Security=True");
            conn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM StudentInfoTbl", conn);
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
            // Basic validation checks
            if (string.IsNullOrWhiteSpace(tb_stid.Text) ||
                string.IsNullOrWhiteSpace(tb_stname.Text) ||
                string.IsNullOrWhiteSpace(tb_stnum.Text) ||
                string.IsNullOrWhiteSpace(tb_stemail.Text) ||
                string.IsNullOrWhiteSpace(tb_stsub.Text) ||
                cb_stgen.SelectedItem == null ||
                cb_stsubsec.SelectedItem == null) // Ensure at least one section is selected
            {
                MessageBox.Show("Please fill all required fields and select at least one section", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tb_stid.Text, out int studentId))
            {
                MessageBox.Show("Invalid Student ID", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(tb_stnum.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Phone number must be exactly 10 digits", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LDJQNC1\SQLEXPRESS;Initial Catalog=sclManagementSystem;Integrated Security=True"))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO StudentInfoTbl (Student_Id, Student_Name, Dob, Gender, Phone_Num, Email, Subject, Subject_Section) VALUES (@Student_Id, @Student_Name, @Dob, @Gender, @Phone_Num, @Email, @Subject, @Subject_Section)", conn);

                    cmd.Parameters.AddWithValue("@Student_Id", studentId);
                    cmd.Parameters.AddWithValue("@Student_Name", tb_stname.Text);
                    cmd.Parameters.AddWithValue("@Dob", dtp_stinfo.Value);
                    cmd.Parameters.AddWithValue("@Gender", cb_stgen.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Phone_Num", tb_stnum.Text);
                    cmd.Parameters.AddWithValue("@Email", tb_stemail.Text);
                    cmd.Parameters.AddWithValue("@Subject", tb_stsub.Text); // Add Subject parameter
                    cmd.Parameters.AddWithValue("@Subject_Section", cb_stsubsec.SelectedItem.ToString()); // Corrected to use cb_stsubsec.SelectedItem.ToString()

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
                SqlCommand cmd = new SqlCommand("SELECT * FROM StudentInfoTbl", conn);
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
            // Basic validation checks
            if (string.IsNullOrWhiteSpace(tb_stid.Text) ||
                string.IsNullOrWhiteSpace(tb_stname.Text) ||
                string.IsNullOrWhiteSpace(tb_stnum.Text) ||
                string.IsNullOrWhiteSpace(tb_stemail.Text) ||
                string.IsNullOrWhiteSpace(tb_stsub.Text) ||
                cb_stgen.SelectedItem == null ||
                cb_stsubsec.SelectedItem == null)  // Ensure at least one section is selected
            {
                MessageBox.Show("Please fill all required fields and select at least one section", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tb_stid.Text, out int studentId))
            {
                MessageBox.Show("Invalid Student ID", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(tb_stnum.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Phone number must be exactly 10 digits", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LDJQNC1\SQLEXPRESS;Initial Catalog=sclManagementSystem;Integrated Security=True"))
            {
                try
                {
                    conn.Open();

                    // Check if record exists
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM StudentInfoTbl WHERE Student_Id = @Student_Id", conn);
                    checkCmd.Parameters.AddWithValue("@Student_Id", studentId);

                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        // Update the existing record
                        SqlCommand updateCmd = new SqlCommand("UPDATE StudentInfoTbl SET Student_Name = @Student_Name, Dob = @Dob, Gender = @Gender, Phone_Num = @Phone_Num, Email = @Email, Subject = @Subject, Subject_Section = @Subject_Section WHERE Student_Id = @Student_Id", conn);

                        updateCmd.Parameters.AddWithValue("@Student_Id", studentId); // Corrected parameter name
                        updateCmd.Parameters.AddWithValue("@Student_Name", tb_stname.Text); // Corrected parameter name
                        updateCmd.Parameters.AddWithValue("@Dob", dtp_stinfo.Value);
                        updateCmd.Parameters.AddWithValue("@Gender", cb_stgen.SelectedItem.ToString());
                        updateCmd.Parameters.AddWithValue("@Phone_Num", tb_stnum.Text);
                        updateCmd.Parameters.AddWithValue("@Email", tb_stemail.Text);
                        updateCmd.Parameters.AddWithValue("@Subject", tb_stsub.Text);
                        updateCmd.Parameters.AddWithValue("@Subject_Section", cb_stsubsec.SelectedItem.ToString()); // Added parameter for Subject_Section

                        updateCmd.ExecuteNonQuery();

                        MessageBox.Show("Record Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Record not found with the provided Student ID", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            tb_stid.Clear();
            tb_stname.Clear();
            dtp_stinfo.Value = DateTime.Now; // Reset the date picker to the current date
            cb_stgen.SelectedIndex = -1; // Deselect any selected item
            tb_stnum.Clear();
            tb_stemail.Clear();
            tb_stsub.Clear();
            cb_stsubsec.SelectedIndex = -1;
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LDJQNC1\SQLEXPRESS;Initial Catalog=sclManagementSystem;Integrated Security=True");
            conn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM StudentInfoTbl WHERE Student_Id = @Student_Id", conn);

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
                MessageBox.Show("An error occurred: " + ex.Message, " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void bt_display_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LDJQNC1\SQLEXPRESS;Initial Catalog=sclManagementSystem;Integrated Security=True"))
                {
                    conn.Open();

                    string sql = "SELECT Student_Id, Student_Name, Dob, Gender, Phone_Num, Email, Subject, Subject_Section FROM StudentInfoTbl";

                    SqlCommand cmd = new SqlCommand(sql, conn); // Create SqlCommand with the SQL query

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd); // Create SqlDataAdapter with the SqlCommand

                    DataTable table = new DataTable();
                    adapter.Fill(table); // Fill the DataTable with the results of the SQL query

                    dgv_stinfo.DataSource = table; // Assuming dgv_stinfo is a DataGridView

                    // Optional: Auto-resize columns to fit content
                    dgv_stinfo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_stemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_stemail_Validated(object sender, EventArgs e)
        {

        }

        private void tb_stemail_Validating(object sender, CancelEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dgv_stinfo_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
                // Ensure the click is on a valid row (not header row)
                if (e.RowIndex >= 0)
                {
                    // Get the DataGridViewRow object for the clicked row
                    DataGridViewRow row = dgv_stinfo.Rows[e.RowIndex];

                    // Populate the textboxes with the values from the selected row
                    tb_stid.Text = row.Cells["Student_Id"].Value.ToString();
                    tb_stname.Text = row.Cells["Student_Name"].Value.ToString();
                    dtp_stinfo.Value = Convert.ToDateTime(row.Cells["Dob"].Value);
                    tb_stnum.Text = row.Cells["Phone_Num"].Value.ToString();
                    tb_stemail.Text = row.Cells["Email"].Value.ToString();
                tb_stsub.Text = row.Cells["Subject"].Value.ToString();

                // Set the ComboBox for Gender
                string gender = row.Cells["Gender"].Value.ToString();
                    cb_stgen.SelectedItem = gender;
                 
                string subsec = row.Cells["Subject_Section"].Value.ToString();
                cb_stsubsec.SelectedItem = subsec;
            }
            

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cb_stgen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tb_stnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_stname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_stid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void studentInfoTbBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
    }






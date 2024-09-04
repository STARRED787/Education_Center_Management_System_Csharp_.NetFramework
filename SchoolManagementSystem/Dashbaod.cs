using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Dashbaod : Form
    {
        public Dashbaod()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this .Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Dashbaod_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LDJQNC1\SQLEXPRESS;Initial Catalog=sclManagementSystem;Integrated Security=True"))
                {
                    conn.Open();

                    // Define queries to count records in various tables
                    string[] queries = {
                "SELECT COUNT(*) FROM TeacherInfoTbl",
                "SELECT COUNT(*) FROM StudentInfoTbl",
                "SELECT COUNT(*) FROM SubjectInfoTb"
            };

                    // Create a list to hold counts
                    int[] counts = new int[queries.Length];

                    for (int i = 0; i < queries.Length; i++)
                    {
                        using (SqlCommand cmd = new SqlCommand(queries[i], conn))
                        {
                            counts[i] = (int)cmd.ExecuteScalar();
                        }
                    }

                    // Assuming you have labels or text boxes on your dashboard to display the counts
                    lblTeacherCount.Text = $"{counts[0]}";
                    lblStudentCount.Text = $"{counts[1]}";
                    lblSubjectCount.Text = $"{counts[2]}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading dashboard counts: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Mainfoam : Form
    {
        public Mainfoam()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            Dashbaod dash_form = new Dashbaod();
            dash_form.Show();
        }

        private void btn_lgout_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {

        }

        private void lgout_lb_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you want log out", "Configaration Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (check == DialogResult.Yes) { 
                loging_form lform= new loging_form();
                lform.Show();
                this.Hide();    
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            Student st =new Student();
            st.Show();
        }

        private void btn_grade_Click(object sender, EventArgs e)
        {
            Enrollment en = new Enrollment();
            en.Show();
        }

        private void btn_teachers_Click(object sender, EventArgs e)
        {
            Teacher Te = new Teacher();
            Te.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Subject su = new Subject();
            su.Show();
        }
    }
    
}

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
    public partial class intro : Form
    {
        public intro()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pl_color.Width += 6;

            if (pl_color.Width >= 523)
            {
                timer.Stop();

                loging_form login = new loging_form();
                login.Show();
                this.Hide();
            }
        }
    }
}

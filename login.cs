using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff_login staff_log = new Staff_login();
            staff_log.Show();
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
             student_login std = new student_login();
            std.Show();
        }

        private void admin_pic_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_login admin_log = new Admin_login();
            admin_log.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void staff_txt_Click(object sender, EventArgs e)
        {

        }

        private void admin_txt_Click(object sender, EventArgs e)
        {

        }

        private void student_txt_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}

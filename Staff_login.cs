using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace WindowsFormsApp1
{
    public partial class Staff_login : Form
    {
        public string connection_string = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=hello;Password=hello";
        public Staff_login()
        {
            InitializeComponent();
        }

        private void Staff_login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login l = new login();
            l.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login l = new login();
            l.Show();
        }

        private void stlogin_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            staff_signup ss = new staff_signup();
            ss.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string id = " ";
            string pass = " ";
            OracleConnection ocl = new OracleConnection(connection_string);
            ocl.Open();
            string query = "select username,password from stafflogin where username='" + student_username.Text + "'";
            OracleCommand cmd = new OracleCommand(query, ocl);
            OracleDataReader r = cmd.ExecuteReader();
            if (r.Read())
            {
                id = r["username"].ToString();
                pass = r["password"].ToString();
                //  MessageBox.Show(id + pass);
            }

            ocl.Close();

            if (staff_username.Text == " " || password_staff.Text == " ")
            {
                notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath("C://Users//hasee//Downloads//notification.ico"));
                notifyIcon1.Text = "";
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipTitle = "Staff Not Login Sucessfully ";
                notifyIcon1.BalloonTipText = "Enter a valid Data";
                notifyIcon1.ShowBalloonTip(50);
            }
            else if (student_username.Text == id && password_staff.Text == pass)
            {
                this.Hide();
                notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath("C://Users//hasee//Downloads//notification.ico"));
                notifyIcon1.Text = "";
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipTitle = " Staff Login Sucessfully ";
                notifyIcon1.BalloonTipText = "Congratulations";
                notifyIcon1.ShowBalloonTip(50);
                Staff_I si = new Staff_I();
                si.Show();
            }
            else
            {
                notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath("C://Users//hasee//Downloads//notification.ico"));
                notifyIcon1.Text = "";
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipTitle = "Staff Not Login Sucessfully ";
                notifyIcon1.BalloonTipText = "Enter a valid Data";
                notifyIcon1.ShowBalloonTip(50);
                student_username.ResetText();
                password_staff.ResetText();
                
            }
        }

        private void show_Password_CheckedChanged(object sender, EventArgs e)
        {
            if (show_Password.Checked)
            {
                password_staff.isPassword = false;
            }
            else
            {
                password_staff.isPassword = true;
            }
        }

        private void password_staff_OnValueChanged(object sender, EventArgs e)
        {
            password_staff.isPassword = true;
        }
    }
}

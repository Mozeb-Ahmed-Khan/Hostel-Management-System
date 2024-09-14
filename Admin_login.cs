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
    public partial class Admin_login : Form
    {
        public string con = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=hello;Password=hello";
        public Admin_login()
        {
            InitializeComponent();
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            password_admin.isPassword = true;
        }
        
        private void login_btn_Click(object sender, EventArgs e)
        {
            string id = " ";
            string pass = " ";
            OracleConnection ocl = new OracleConnection(con);
            ocl.Open();
            string query = "select username,password from admin where username='" + admin_username.Text + "'";
            OracleCommand cmd = new OracleCommand(query, ocl);
            OracleDataReader r = cmd.ExecuteReader();
            if(r.Read())
            {
                id = r["username"].ToString();
                pass = r["password"].ToString();
              //  MessageBox.Show(id + pass);
            }

            ocl.Close();
           
            if (admin_username.Text == " " || password_admin.Text == " ")
            {
                notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath("C://Users//hasee//Downloads//notification.ico"));
                notifyIcon1.Text = "";
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipTitle = "Admin Not Login Sucessfully ";
                notifyIcon1.BalloonTipText = "Enter a valid Data";
                notifyIcon1.ShowBalloonTip(50);
            }
            else if (admin_username.Text == id && password_admin.Text == pass)
            {
                this.Hide();
                notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath("C://Users//hasee//Downloads//notification.ico"));
                notifyIcon1.Text = "";
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipTitle = "Admin Login Sucessfully ";
                notifyIcon1.BalloonTipText = "Congratulations";
                notifyIcon1.ShowBalloonTip(50);
                Admin_A admin_a = new Admin_A();
                admin_a.Show();
            }
            else
            {
                notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath("C://Users//hasee//Downloads//notification.ico"));
                notifyIcon1.Text = "";
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipTitle = "Admin Not Login Sucessfully ";
                notifyIcon1.BalloonTipText = "Enter a valid Data";
                notifyIcon1.ShowBalloonTip(50);
                admin_username.ResetText();
                password_admin.ResetText();
               
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login l = new login();
            l.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login l = new login();
            l.Show();
        }

        private void Admin_login_Load(object sender, EventArgs e)
        {

        }

        private void admin_username_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void show_Password_CheckedChanged(object sender, EventArgs e)
        {
            if(show_Password.Checked)
            {
                password_admin.isPassword = false;
            }
            else
            {
                password_admin.isPassword = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}

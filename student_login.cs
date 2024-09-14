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
    public partial class student_login : Form
    {
        public string connection_string = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=hello;Password=hello";

        public student_login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Slogin_btn_Click(object sender, EventArgs e)
        {
            string id = " ";
            string pass = " ";
            OracleConnection ocl = new OracleConnection(connection_string);
            ocl.Open();
            string query = "select username,password from studentlogin where username='" + student_username.Text + "'";
            OracleCommand cmd = new OracleCommand(query, ocl);
            OracleDataReader r = cmd.ExecuteReader();
            if (r.Read())
            {
                id = r["username"].ToString();
                pass = r["password"].ToString();
                //  MessageBox.Show(id + pass);
            }

            ocl.Close();

            if (student_username.Text == " " || password_student.Text == " ")
            {
                notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath("C://Users//hasee//Downloads//notification.ico"));
                notifyIcon1.Text = "";
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipTitle = "Student Not Login Sucessfully ";
                notifyIcon1.BalloonTipText = "Enter a valid Data";
                notifyIcon1.ShowBalloonTip(50);
            }
            else if (student_username.Text == id && password_student.Text == pass)
            {
                this.Hide();
                notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath("C://Users//hasee//Downloads//notification.ico"));
                notifyIcon1.Text = "";
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipTitle = "Student Login Sucessfully ";
                notifyIcon1.BalloonTipText = "Congratulations";
                notifyIcon1.ShowBalloonTip(50);
                Student_A student = new Student_A();
                student.Show();
            }
            else
            {
                notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath("C://Users//hasee//Downloads//notification.ico"));
                notifyIcon1.Text = "";
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipTitle = "Student Not Login Sucessfully ";
                notifyIcon1.BalloonTipText = "Enter a valid Data";
                notifyIcon1.ShowBalloonTip(50);
                student_username.ResetText();
                password_student.ResetText();
             
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            student_signup student = new student_signup();
            student.Show();
        }

        private void show_Password_CheckedChanged(object sender, EventArgs e)
        {
            if (show_Password.Checked)
            {
                password_student.isPassword = false;
            }
            else
            {
                password_student.isPassword = true;
            }
        }

        private void password_student_OnValueChanged(object sender, EventArgs e)
        {
            password_student.isPassword = true;
        }
    }
 }
    

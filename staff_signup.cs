using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class staff_signup : Form
    {
        public string connection_string = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=hello;Password=hello";
        public staff_signup()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff_login sl = new Staff_login();
            sl.Show();
        }

        private void stlogin_btn_Click(object sender, EventArgs e)
        {
            OracleConnection ocl = new OracleConnection(connection_string);
            ocl.Open();
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "INSERT INTO STafflogin VALUES('" + student_username.Text + "','" + student_password.Text +"','"+bunifuMaterialTextbox1.Text+ "')";
                cmd.Connection = ocl;
                cmd.ExecuteNonQuery();
                add_datacs ad = new add_datacs();
                ad.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR!!! ");
            }
            ocl.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void show_Password_CheckedChanged(object sender, EventArgs e)
        {
            if (show_Password.Checked)
            {
              student_password .isPassword = false;
            }
            else
            {
                student_password.isPassword = true;
            }
        }

        private void student_password_OnValueChanged(object sender, EventArgs e)
        {
            student_password.isPassword = true;
        }
    }
}

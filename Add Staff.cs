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
    public partial class Add_Staff : Form
    {
        public string connection_string = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=hello;Password=hello";
        public Add_Staff()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_A admin = new Admin_A();
            admin.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2TextBox12_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            OracleConnection ocl = new OracleConnection(connection_string);
            ocl.Open();
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "INSERT INTO staff VALUES('" + staff_id.Text + "','" + staff_name.Text + "','" + staff_cnic.Text + "','" + staff_con.Text + "','" + staff_religion.Text + "','" + building_num.Text + "','" + room_no.Text + "','" + gym_status.Text + "','" + staff_gender.Text + "')";
                cmd.Connection = ocl;
                cmd.ExecuteNonQuery();
                add_datacs ad = new add_datacs();
                ad.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Room No " + room_no.Text + "not inserted in Room table ");
            }
            ocl.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void room_no_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}

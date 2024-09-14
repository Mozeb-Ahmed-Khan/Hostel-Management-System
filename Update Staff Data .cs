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
    public partial class Update_Staff_Data : Form
    {
        public string connection_string = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=hello;Password=hello";
        public Update_Staff_Data()
        {
            InitializeComponent();
        }

        private void Update_Staff_Data_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Admin_A a = new Admin_A();
            a.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            OracleConnection ocl = new OracleConnection(connection_string);
            ocl.Open();
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = ("update staff set STAFF_ID='" +staff_id.Text  + "',STAFF_NAME='" +s_name.Text+ "',STAFF_CNIC='" + s_cnic.Text + "', CONTACT_NO='" + contact.Text + "',RELIGION='" + religion.Text + "',BUILDING_NO='" + building_no.Text + "',ROOM_NUMBER='" + room_no.Text + "',GYM_STATUS='" + gym_status.Text + "',GENDER='" + gender.Text + "'WHERE STAFF_ID='" + staff_id.Text + "'");
                cmd.Connection = ocl;
                cmd.ExecuteNonQuery();
                update_data up = new update_data();
                up.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid staff ID\n Please Enter a valid Data\nThank you!!");
            }
            staff_id.ResetText();s_name.ResetText();s_cnic.ResetText(); contact.ResetText();
            religion.ResetText();building_no.ResetText();room_no.ResetText();gym_status.ResetText();gender.ResetText();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            OracleConnection ocl = new OracleConnection(connection_string);
            ocl.Open();
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "delete from STAFF where  STAFF_ID='" + staff_id.Text + "'";
                cmd.Connection = ocl;
                cmd.ExecuteNonQuery();
                Delete_data dd = new Delete_data();
                dd.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("STAFF Id " + staff_id.Text + "does not Exist");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OracleConnection ocl = new OracleConnection(connection_string);
            ocl.Open();

            OracleDataAdapter oda = new OracleDataAdapter("select * from Staff", connection_string);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            ocl.Close();
        }

        private void search_Click(object sender, EventArgs e)
        {
            OracleConnection ocl = new OracleConnection(connection_string);
            ocl.Open();
            OracleDataAdapter oda = new OracleDataAdapter("select * from staff where STaff_ID='" + search_box.Text + "'", connection_string);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            staff_id.Text = dt.Rows[0][0].ToString();
            s_name.Text = dt.Rows[0][1].ToString();
            s_cnic.Text = dt.Rows[0][2].ToString();
            contact.Text = dt.Rows[0][3].ToString();
            religion.Text = dt.Rows[0][4].ToString();
            building_no.Text = dt.Rows[0][5].ToString();
            room_no.Text = dt.Rows[0][6].ToString();
            gym_status.Text = dt.Rows[0][7].ToString();
            gender.Text = dt.Rows[0][8].ToString();
            search_box.ResetText();
            ocl.Close();

        }
    }
}

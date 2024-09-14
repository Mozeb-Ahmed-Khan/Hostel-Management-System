using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Update_Student_Data : Form
    {
        public string connection_string = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=hello;Password=hello";
        public Update_Student_Data()
        {
            InitializeComponent();
        }

        private void Update_Student_Data_Load(object sender, EventArgs e)
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

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            OracleConnection ocl = new OracleConnection(connection_string);
            ocl.Open();
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = ("update student set STUDENT_ID='" + s_id.Text + "',STUDENT_NAME='" + s_name.Text + "',STUDENT_CNIC='" + s_cnic.Text + "',CONTACT_NO='" + s_no.Text + "',RELIGION='" + s_religion.Text + "',BUILDING_NO='" + b_no.Text + "',ROOM_NUMBER='" + r_no.Text + "',GYM_STATUS='" + gym_status.Text + "',GENDER='" + s_gender.Text + "',HOME_NO='" + s_home.Text + "'WHERE STUDENT_ID='" + s_id.Text + "'");
                cmd.Connection = ocl;
                cmd.ExecuteNonQuery();
                update_data up = new update_data();
                up.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Student ID\n Please Enter a valid Data\nThank you!!");
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            OracleConnection ocl = new OracleConnection(connection_string);
            ocl.Open();
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "delete from STUDENT where  STUDENT_ID='" + s_id.Text + "'";
                cmd.Connection = ocl;
                cmd.ExecuteNonQuery();
                Delete_data dd = new Delete_data();
                dd.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("STUDENT Id " + s_id.Text + "does not Exist");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OracleConnection ocl = new OracleConnection(connection_string);
            ocl.Open();

            OracleDataAdapter oda = new OracleDataAdapter("select * from STUDENT", connection_string);
            DataTable dt = new DataTable();
            oda.Fill(dt);
           dataGridView1.DataSource = dt;
            ocl.Close();
        }

        private void search_Click(object sender, EventArgs e)
        {
            /*OracleConnection ocl = new OracleConnection(connection_string);
             ocl.Open();
             OracleDataAdapter oda = new OracleDataAdapter("select * from student where STUDENT_ID='" + search_box.Text + "'", connection_string);
             DataTable dt = new DataTable();
             oda.Fill(dt);
             dataGridView1.DataSource = dt;
             ocl.Close();*/
           try
            {


                OracleConnection ocl = new OracleConnection(connection_string);
                ocl.Open();
                if (search_box.Text != " ")
                {
                    string query = "Select * from Student where Student_id='" + search_box.Text + "'";
                    OracleDataAdapter oda = new OracleDataAdapter(query, connection_string);
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    s_id.Text = dt.Rows[0][0].ToString();
                    s_name.Text = dt.Rows[0][1].ToString();
                    s_cnic.Text = dt.Rows[0][2].ToString(); s_no.Text = dt.Rows[0][3].ToString(); s_religion.Text = dt.Rows[0][4].ToString(); b_no.Text = dt.Rows[0][5].ToString(); r_no.Text = dt.Rows[0][6].ToString(); gym_status.Text = dt.Rows[0][7].ToString(); s_gender.Text = dt.Rows[0][8].ToString(); s_home.Text = dt.Rows[0][9].ToString();
                    ocl.Close();
                }
                else
                {
                    MessageBox.Show("Error!!!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }

        }
    }
}

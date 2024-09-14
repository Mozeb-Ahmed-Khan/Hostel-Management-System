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
    public partial class Update_Room : Form
    {
        
        public string connection_string = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=hello;Password=hello";
        public Update_Room()
        {
            InitializeComponent();
        }

        private void Update_Room_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            OracleConnection ocl = new OracleConnection(connection_string);
            ocl.Open();
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = ("update room set  ROOM_TYPE='" + R_type.Text + "',ROOM_STRENGTH='" + r_strength.Text + "',ROOM_ASSETS='" + r_assets.Text + "',       ROOM_STATUS='" + r_status.Text + "',ROOM_FACILITIES='" + r_facility.Text + "',BUILDING_ID='" + B_no.Text + "',BUILDING_NAME='" + b_name.Text + "',BUILDING_LOCATION='" + b_loc.Text + "',BUILDING_ROOMS='" + b_floor.Text + "'WHERE ROOM_NUMBER='" + R_no.Text + "'");
                cmd.Connection = ocl;
                cmd.ExecuteNonQuery();
                update_data up = new update_data();
                up.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Room ID" + R_no.Text + "Does not Exits");
            }
            ocl.Close();
            R_no.ResetText(); R_type.ResetText(); r_strength.ResetText(); r_strength.ResetText(); r_status.ResetText(); r_assets.ResetText();
            r_facility.ResetText(); B_no.ResetText(); b_name.ResetText(); b_loc.ResetText();
            b_floor.ResetText();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            OracleConnection ocl = new OracleConnection(connection_string);
            ocl.Open();
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "delete from room where  ROOM_NUMBER='" + R_no.Text + "'";
                cmd.Connection = ocl;
                cmd.ExecuteNonQuery();
                Delete_data dd = new Delete_data();
                dd.Show();
            }
            catch(Exception)
            {
                MessageBox.Show("Room Id " + R_no.Text + "does not Exist");
            }
            R_no.ResetText(); R_type.ResetText(); r_strength.ResetText(); r_strength.ResetText(); r_status.ResetText(); r_assets.ResetText();
            r_facility.ResetText(); B_no.ResetText(); b_name.ResetText(); b_loc.ResetText();
            b_floor.ResetText();
        }

        private void View_Click(object sender, EventArgs e)
        {
            OracleConnection ocl = new OracleConnection(connection_string);
            ocl.Open();

            OracleDataAdapter oda = new OracleDataAdapter("select * from Room", connection_string);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            ocl.Close();

        }

        private void search_Click(object sender, EventArgs e)
        {
            OracleConnection ocl = new OracleConnection(connection_string);
            ocl.Open();
            OracleDataAdapter oda = new OracleDataAdapter("select * from Room where Room_Number='"+search_box.Text+"'", connection_string);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            R_no.Text = dt.Rows[0][0].ToString();
            R_type.Text = dt.Rows[0][1].ToString();
            r_strength.Text = dt.Rows[0][2].ToString(); r_assets.Text = dt.Rows[0][3].ToString(); r_status.Text = dt.Rows[0][4].ToString(); r_facility.Text = dt.Rows[0][5].ToString();
            B_no.Text = dt.Rows[0][6].ToString(); b_name.Text = dt.Rows[0][7].ToString();b_loc.Text = dt.Rows[0][8].ToString(); b_floor.Text = dt.Rows[0][9].ToString();
            ocl.Close();
        }

        private void guna2TextBox12_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

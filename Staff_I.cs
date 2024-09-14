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
    public partial class Staff_I : Form
    {
        public string connection_string = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=hello;Password=hello";
        public Staff_I()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login l = new login();
            l.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OracleConnection ocl = new OracleConnection(connection_string);
            ocl.Open();
            OracleDataAdapter oda = new OracleDataAdapter("select * from staff where Staff_ID='" + SEARCH.Text + "'", connection_string);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            ocl.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            OracleConnection ocl = new OracleConnection(connection_string);
            ocl.Open();
            OracleDataAdapter oda = new OracleDataAdapter("select * from STafflogin WHERE CNIC ='" + SEARCH.Text + "'", connection_string);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            ocl.Close();
        }
    }
}

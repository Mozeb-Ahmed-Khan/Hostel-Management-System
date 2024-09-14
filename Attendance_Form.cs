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
    public partial class Attendance_Form : Form
    {
        public string connection_string = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=hello;Password=hello";
        public Attendance_Form()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OracleConnection ocl = new OracleConnection(connection_string);
            ocl.Open();
            OracleDataAdapter oda = new OracleDataAdapter("select * from STUDENTATTENDANCE where STUDENT_ID='" + guna2TextBox1.Text + "'", connection_string);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            ocl.Close();
        }

        private void Attendance_Form_Load(object sender, EventArgs e)
        {

        }
    }
}

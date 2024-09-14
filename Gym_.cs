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
    public partial class Gym_ : Form
    {
        public string connection_string = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=hello;Password=hello";
        public Gym_()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Gym__Load(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            OracleConnection ocl = new OracleConnection(connection_string);
            ocl.Open();
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "insert into Gym Values ('" + student_id.Text + "','" + joining_date.Text + "' ,'" + subscription_plan.Text + "')";
                cmd.Connection = ocl;
                cmd.ExecuteNonQuery();
                add_datacs ad = new add_datacs();
                ad.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR!!!");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OracleConnection ocl = new OracleConnection(connection_string);
            ocl.Open();

            OracleDataAdapter oda = new OracleDataAdapter("select * from Gym", connection_string);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            ocl.Close();
        }
    }
}

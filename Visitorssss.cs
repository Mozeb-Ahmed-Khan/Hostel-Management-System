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
    public partial class Visitorssss : Form
    {
        public string connection_string = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=hello;Password=hello";
        public Visitorssss()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

            OracleConnection ocl = new OracleConnection(connection_string);
            ocl.Open();
             try
             {
                    OracleCommand cmd = new OracleCommand();
                    //string mydate = V_DATE.ToString("dd/MM/yyy");

                    cmd.CommandText = "insert into VISITORS Values ('" + V_CNIC.Text + "','" + V_NAME.Text + "','" + visitng_data.Text + "','" + V_REASON.Text + "')";
                    cmd.Connection = ocl;
                    cmd.ExecuteNonQuery();
                add_datacs ad = new add_datacs();
                ad.Show();
             }
            catch (Exception)
            {
                MessageBox.Show("VISITOR CNIC " + V_CNIC.Text + "already Exist");

            }
            ocl.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OracleConnection ocl = new OracleConnection(connection_string);
            ocl.Open();

            OracleDataAdapter oda = new OracleDataAdapter("select * from visitors", connection_string);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            ocl.Close();
        }
    }
}

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
    public partial class Hostel_Expenses : Form
    {
        public string connection_string = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=hello;Password=hello";
        public Hostel_Expenses()
        {
            InitializeComponent();
        }

        private void Hostel_Expenses_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            OracleConnection ocl = new OracleConnection(connection_string);
            ocl.Open();
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "insert into HostelExpense Values ('" + datee.Text + "','" +g_bill.Text + "' ,'" + internet_bill.Text + "' ,'" + e_bill.Text + "','" + gass_bill.Text + "' ,'" + medical_bill.Text + "')";
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

            OracleDataAdapter oda = new OracleDataAdapter("select E_date,Grocery_Bill,Internet_Bill,E_Bill,Gas_Bill,Medical_Bill,Medical_Bill+Internet_Bill+E_Bill+Gas_Bill+Grocery_Bill As tot from HostelExpense", connection_string);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            ocl.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}

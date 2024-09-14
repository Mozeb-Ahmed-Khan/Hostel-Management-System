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
    public partial class Student_Staff_Accountscs : Form
    {
        public string connection_string = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=hello;Password=hello";
        public Student_Staff_Accountscs()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Admin_A a = new Admin_A();
            a.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            OracleConnection ocl = new OracleConnection(connection_string);
            ocl.Open();
           
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "insert into Accounts Values ('" + student_id.Text + "','" +e_bill.Text + "' ,'" + mess_bill.Text + "','" + water_bill.Text + "' ,'" +laundary_bill.Text + "')";
                cmd.Connection = ocl;
                cmd.ExecuteNonQuery();
                add_datacs ad = new add_datacs();
                ad.Show();
            
            

            ocl.Close();
        }
    }
}

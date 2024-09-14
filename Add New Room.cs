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
    public partial class Add_New_Room : Form
    {
        public string connection_string = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=hello;Password=hello";
        public Add_New_Room()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_New_Room_Load(object sender, EventArgs e)
        {
            this.Location = new Point(320,150);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {

            OracleConnection ocl = new OracleConnection(connection_string);
            ocl.Open();
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = ocl;  
                cmd.CommandText = "insert into Room Values ('" + R_no.Text + "','" + R_type.Text + "' ,'" + r_strength.Text + "' ,'" + R_Asset.Text + "','" + r_status.Text + "' ,'" + r_facility.Text + "','" + B_no.Text + "' ,'" + b_name.Text + "','" + B_loc.Text + "','" + b_floor.Text + "')";
                
                cmd.ExecuteNonQuery();
                add_datacs ad = new add_datacs();
                ad.Show();
            }
            catch(Exception)
            {
                MessageBox.Show("Data Missing\n Or \n Room Already Filled");
            }
          
           ocl.Close();
            R_no.ResetText();R_type.ResetText();r_strength.ResetText();r_strength.ResetText();r_status.ResetText();R_Asset.ResetText();
            r_facility.ResetText();B_no.ResetText();b_name.ResetText();B_loc.ResetText();
            b_floor.ResetText();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void B_no_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Admin_A : Form
    {
        public string con = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=hello;Password=hello";

        public string LoggedInUser { get; private set; }

        public Admin_A()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_A_Load(object sender, EventArgs e)
        {
            OracleConnection ocl = new OracleConnection(con);
            ocl.Open();
            OracleDataAdapter od = new OracleDataAdapter(" select count(*) from Admin", con);
            DataTable dt = new DataTable();
            od.Fill(dt);
            label5.Text = dt.Rows[0][0].ToString();


            OracleDataAdapter o = new OracleDataAdapter(" select count(*) from Staff", con);
            DataTable d = new DataTable();
            o.Fill(d);
            label7.Text = d.Rows[0][0].ToString();


            
            OracleDataAdapter odtt = new OracleDataAdapter(" select count(*) from Student", con);
            DataTable dttt = new DataTable();
            odtt.Fill(dttt);
            label9.Text = dttt.Rows[0][0].ToString();
            OracleDataAdapter odt = new OracleDataAdapter(" select count(*) from Room", con);
            DataTable dtt = new DataTable();
            odt.Fill(dtt);
            label14.Text = dtt.Rows[0][0].ToString();
            ocl.Close();

/*
            OracleDataAdapter odde = new OracleDataAdapter("select username,password from admin",con);
            DataTable dd = new DataTable();
            odde.Fill(dd);
            label15.Text = dd.Rows.ToString();
            label16.Text = dd.Rows.ToString();
*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
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
            Manage_Rooms_Option manage = new Manage_Rooms_Option();
            manage.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Add_New_Student ads = new Add_New_Student();
            ads.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Add_Staff hel = new Add_Staff();
            hel.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Update_Student_Data usd = new Update_Student_Data();
            usd.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Update_Staff_Data ustd = new Update_Staff_Data();
            ustd.Show();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Student_Staff_Accountscs ssa = new Student_Staff_Accountscs();
            ssa.Show();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            Hostel_Expenses he = new Hostel_Expenses();
            he.Show();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            Visitorssss v = new Visitorssss();
            v.Show();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            Gym_ g = new Gym_();
            g.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Attendance_Form af = new Attendance_Form();
            af.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void kryptonMonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void kryptonMonthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {

        }

        private void kryptonGroupBox1_Panel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void kryptonGallery1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
     
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}

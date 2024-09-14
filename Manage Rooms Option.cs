using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Manage_Rooms_Option : Form
    {
        public Manage_Rooms_Option()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void staff_pic_Click(object sender, EventArgs e)
        {
            Update_Room upr = new Update_Room();
            upr.Show();
            this.Location = new Point(320, 150);
        }

        private void student_pic_Click(object sender, EventArgs e)
        {
           
        }

        private void student_pic_Click_1(object sender, EventArgs e)
        {
            Add_New_Room adr = new Add_New_Room();
            adr.Show();
            this.Location = new Point(320, 150);
        }
    }
}

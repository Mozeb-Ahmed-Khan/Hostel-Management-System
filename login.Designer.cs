
namespace WindowsFormsApp1
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.student_txt = new System.Windows.Forms.Label();
            this.staff_txt = new System.Windows.Forms.Label();
            this.admin_txt = new System.Windows.Forms.Label();
            this.student_pic = new System.Windows.Forms.PictureBox();
            this.staff_pic = new System.Windows.Forms.PictureBox();
            this.admin_pic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staff_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.guna2HtmlLabel1);
            this.panel1.Controls.Add(this.student_txt);
            this.panel1.Controls.Add(this.staff_txt);
            this.panel1.Controls.Add(this.admin_txt);
            this.panel1.Controls.Add(this.student_pic);
            this.panel1.Controls.Add(this.staff_pic);
            this.panel1.Controls.Add(this.admin_pic);
            this.panel1.Location = new System.Drawing.Point(-1, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 269);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.OrangeRed;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(381, 5);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(57, 27);
            this.guna2HtmlLabel1.TabIndex = 8;
            this.guna2HtmlLabel1.Text = "Login ";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // student_txt
            // 
            this.student_txt.AutoSize = true;
            this.student_txt.BackColor = System.Drawing.Color.Transparent;
            this.student_txt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.student_txt.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_txt.ForeColor = System.Drawing.Color.OrangeRed;
            this.student_txt.Location = new System.Drawing.Point(615, 214);
            this.student_txt.Name = "student_txt";
            this.student_txt.Size = new System.Drawing.Size(88, 25);
            this.student_txt.TabIndex = 7;
            this.student_txt.Text = "Student";
            this.student_txt.Click += new System.EventHandler(this.student_txt_Click);
            // 
            // staff_txt
            // 
            this.staff_txt.AutoSize = true;
            this.staff_txt.BackColor = System.Drawing.Color.Transparent;
            this.staff_txt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staff_txt.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff_txt.ForeColor = System.Drawing.Color.OrangeRed;
            this.staff_txt.Location = new System.Drawing.Point(357, 214);
            this.staff_txt.Name = "staff_txt";
            this.staff_txt.Size = new System.Drawing.Size(55, 25);
            this.staff_txt.TabIndex = 6;
            this.staff_txt.Text = "Staff";
            this.staff_txt.Click += new System.EventHandler(this.staff_txt_Click);
            // 
            // admin_txt
            // 
            this.admin_txt.AutoSize = true;
            this.admin_txt.BackColor = System.Drawing.Color.Transparent;
            this.admin_txt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.admin_txt.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_txt.ForeColor = System.Drawing.Color.OrangeRed;
            this.admin_txt.Location = new System.Drawing.Point(102, 214);
            this.admin_txt.Name = "admin_txt";
            this.admin_txt.Size = new System.Drawing.Size(86, 25);
            this.admin_txt.TabIndex = 5;
            this.admin_txt.Text = "Admin ";
            this.admin_txt.Click += new System.EventHandler(this.admin_txt_Click);
            // 
            // student_pic
            // 
            this.student_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.student_pic.Image = global::WindowsFormsApp1.Properties.Resources.student;
            this.student_pic.Location = new System.Drawing.Point(576, 49);
            this.student_pic.Name = "student_pic";
            this.student_pic.Size = new System.Drawing.Size(165, 131);
            this.student_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.student_pic.TabIndex = 4;
            this.student_pic.TabStop = false;
            this.student_pic.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // staff_pic
            // 
            this.staff_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staff_pic.Image = global::WindowsFormsApp1.Properties.Resources.teacher;
            this.staff_pic.Location = new System.Drawing.Point(314, 37);
            this.staff_pic.Name = "staff_pic";
            this.staff_pic.Size = new System.Drawing.Size(192, 164);
            this.staff_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.staff_pic.TabIndex = 3;
            this.staff_pic.TabStop = false;
            this.staff_pic.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // admin_pic
            // 
            this.admin_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.admin_pic.Image = global::WindowsFormsApp1.Properties.Resources.admin_;
            this.admin_pic.Location = new System.Drawing.Point(51, 37);
            this.admin_pic.Name = "admin_pic";
            this.admin_pic.Size = new System.Drawing.Size(195, 174);
            this.admin_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.admin_pic.TabIndex = 2;
            this.admin_pic.TabStop = false;
            this.admin_pic.Click += new System.EventHandler(this.admin_pic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(186, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hostel Management System";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.close__1_;
            this.pictureBox2.Location = new System.Drawing.Point(771, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(826, 384);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staff_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox staff_pic;
        private System.Windows.Forms.PictureBox admin_pic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox student_pic;
        private System.Windows.Forms.Label student_txt;
        private System.Windows.Forms.Label staff_txt;
        private System.Windows.Forms.Label admin_txt;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
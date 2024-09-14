
namespace WindowsFormsApp1
{
    partial class Staff_login
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
            this.show_Password = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.staff_username = new Guna.UI2.WinForms.Guna2Button();
            this.stlogin_btn = new Guna.UI2.WinForms.Guna2Button();
            this.password_staff = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Password = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.student_username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.show_Password);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.staff_username);
            this.panel1.Controls.Add(this.stlogin_btn);
            this.panel1.Controls.Add(this.password_staff);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.student_username);
            this.panel1.Location = new System.Drawing.Point(0, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 260);
            this.panel1.TabIndex = 0;
            // 
            // show_Password
            // 
            this.show_Password.Location = new System.Drawing.Point(595, 119);
            this.show_Password.Name = "show_Password";
            this.show_Password.Size = new System.Drawing.Size(108, 20);
            this.show_Password.TabIndex = 25;
            this.show_Password.Values.Text = "Show Password";
            this.show_Password.CheckedChanged += new System.EventHandler(this.show_Password_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Note: Sign Up Required ! First Sign Up !";
            // 
            // staff_username
            // 
            this.staff_username.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.staff_username.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.staff_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.staff_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.staff_username.FillColor = System.Drawing.Color.OrangeRed;
            this.staff_username.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff_username.ForeColor = System.Drawing.Color.Black;
            this.staff_username.Location = new System.Drawing.Point(402, 173);
            this.staff_username.Name = "staff_username";
            this.staff_username.Size = new System.Drawing.Size(107, 42);
            this.staff_username.TabIndex = 20;
            this.staff_username.Text = "Log in";
            this.staff_username.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // stlogin_btn
            // 
            this.stlogin_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.stlogin_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.stlogin_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.stlogin_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.stlogin_btn.FillColor = System.Drawing.Color.OrangeRed;
            this.stlogin_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stlogin_btn.ForeColor = System.Drawing.Color.Black;
            this.stlogin_btn.Location = new System.Drawing.Point(550, 173);
            this.stlogin_btn.Name = "stlogin_btn";
            this.stlogin_btn.Size = new System.Drawing.Size(107, 42);
            this.stlogin_btn.TabIndex = 19;
            this.stlogin_btn.Text = "Sign up";
            this.stlogin_btn.Click += new System.EventHandler(this.stlogin_btn_Click);
            // 
            // password_staff
            // 
            this.password_staff.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_staff.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.password_staff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password_staff.HintForeColor = System.Drawing.Color.Empty;
            this.password_staff.HintText = "Password";
            this.password_staff.isPassword = true;
            this.password_staff.LineFocusedColor = System.Drawing.Color.Brown;
            this.password_staff.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.password_staff.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.password_staff.LineThickness = 3;
            this.password_staff.Location = new System.Drawing.Point(366, 108);
            this.password_staff.Margin = new System.Windows.Forms.Padding(4);
            this.password_staff.Name = "password_staff";
            this.password_staff.Size = new System.Drawing.Size(302, 44);
            this.password_staff.TabIndex = 18;
            this.password_staff.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.password_staff.OnValueChanged += new System.EventHandler(this.password_staff_OnValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.teacher_login;
            this.pictureBox1.Location = new System.Drawing.Point(62, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(246, 133);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(80, 19);
            this.Password.TabIndex = 16;
            this.Password.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "User Name";
            // 
            // student_username
            // 
            this.student_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.student_username.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.student_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.student_username.HintForeColor = System.Drawing.Color.Empty;
            this.student_username.HintText = "Username";
            this.student_username.isPassword = false;
            this.student_username.LineFocusedColor = System.Drawing.Color.Brown;
            this.student_username.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.student_username.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.student_username.LineThickness = 3;
            this.student_username.Location = new System.Drawing.Point(366, 45);
            this.student_username.Margin = new System.Windows.Forms.Padding(4);
            this.student_username.Name = "student_username";
            this.student_username.Size = new System.Drawing.Size(302, 44);
            this.student_username.TabIndex = 14;
            this.student_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Home";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.previous;
            this.pictureBox2.Location = new System.Drawing.Point(33, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(279, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 32);
            this.label3.TabIndex = 25;
            this.label3.Text = "Staff Login";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Staff_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(730, 375);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staff_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff_login";
            this.Load += new System.EventHandler(this.Staff_login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button stlogin_btn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password_staff;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox student_username;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button staff_username;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox show_Password;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}
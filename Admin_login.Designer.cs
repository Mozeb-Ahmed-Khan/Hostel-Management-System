
namespace WindowsFormsApp1
{
    partial class Admin_login
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
            this.login_btn = new Guna.UI2.WinForms.Guna2Button();
            this.password_admin = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Password = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.admin_username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
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
            this.panel1.Controls.Add(this.login_btn);
            this.panel1.Controls.Add(this.password_admin);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.admin_username);
            this.panel1.Location = new System.Drawing.Point(0, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 260);
            this.panel1.TabIndex = 0;
            // 
            // show_Password
            // 
            this.show_Password.Location = new System.Drawing.Point(576, 134);
            this.show_Password.Name = "show_Password";
            this.show_Password.Size = new System.Drawing.Size(108, 20);
            this.show_Password.TabIndex = 24;
            this.show_Password.Values.Text = "Show Password";
            this.show_Password.CheckedChanged += new System.EventHandler(this.show_Password_CheckedChanged);
            // 
            // login_btn
            // 
            this.login_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.login_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.login_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.login_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.login_btn.FillColor = System.Drawing.Color.OrangeRed;
            this.login_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.Black;
            this.login_btn.Location = new System.Drawing.Point(551, 193);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(107, 42);
            this.login_btn.TabIndex = 7;
            this.login_btn.Text = "Log In";
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // password_admin
            // 
            this.password_admin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_admin.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.password_admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password_admin.HintForeColor = System.Drawing.Color.Empty;
            this.password_admin.HintText = "Password";
            this.password_admin.isPassword = true;
            this.password_admin.LineFocusedColor = System.Drawing.Color.Brown;
            this.password_admin.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.password_admin.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.password_admin.LineThickness = 3;
            this.password_admin.Location = new System.Drawing.Point(356, 123);
            this.password_admin.Margin = new System.Windows.Forms.Padding(4);
            this.password_admin.Name = "password_admin";
            this.password_admin.Size = new System.Drawing.Size(302, 44);
            this.password_admin.TabIndex = 6;
            this.password_admin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.password_admin.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.padlock;
            this.pictureBox1.Location = new System.Drawing.Point(52, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(236, 148);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(80, 19);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // admin_username
            // 
            this.admin_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.admin_username.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.admin_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.admin_username.HintForeColor = System.Drawing.Color.Empty;
            this.admin_username.HintText = "Username";
            this.admin_username.isPassword = false;
            this.admin_username.LineFocusedColor = System.Drawing.Color.Brown;
            this.admin_username.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.admin_username.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.admin_username.LineThickness = 3;
            this.admin_username.Location = new System.Drawing.Point(356, 60);
            this.admin_username.Margin = new System.Windows.Forms.Padding(4);
            this.admin_username.Name = "admin_username";
            this.admin_username.Size = new System.Drawing.Size(302, 44);
            this.admin_username.TabIndex = 0;
            this.admin_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.admin_username.OnValueChanged += new System.EventHandler(this.admin_username_OnValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Admin Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Home";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.previous;
            this.pictureBox2.Location = new System.Drawing.Point(28, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
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
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Admin_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(730, 375);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_login";
            this.Load += new System.EventHandler(this.Admin_login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox admin_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password_admin;
        private Guna.UI2.WinForms.Guna2Button login_btn;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox show_Password;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}
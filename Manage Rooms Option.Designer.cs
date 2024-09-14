
namespace WindowsFormsApp1
{
    partial class Manage_Rooms_Option
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
            this.student_txt = new System.Windows.Forms.Label();
            this.student_pic = new System.Windows.Forms.PictureBox();
            this.staff_txt = new System.Windows.Forms.Label();
            this.staff_pic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staff_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.student_txt);
            this.panel1.Controls.Add(this.student_pic);
            this.panel1.Controls.Add(this.staff_txt);
            this.panel1.Controls.Add(this.staff_pic);
            this.panel1.Location = new System.Drawing.Point(-15, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 244);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // student_txt
            // 
            this.student_txt.AutoSize = true;
            this.student_txt.BackColor = System.Drawing.Color.Transparent;
            this.student_txt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.student_txt.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_txt.ForeColor = System.Drawing.Color.OrangeRed;
            this.student_txt.Location = new System.Drawing.Point(167, 206);
            this.student_txt.Name = "student_txt";
            this.student_txt.Size = new System.Drawing.Size(66, 25);
            this.student_txt.TabIndex = 9;
            this.student_txt.Text = "Insert";
            // 
            // student_pic
            // 
            this.student_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.student_pic.Image = global::WindowsFormsApp1.Properties.Resources.plus;
            this.student_pic.Location = new System.Drawing.Point(93, 29);
            this.student_pic.Name = "student_pic";
            this.student_pic.Size = new System.Drawing.Size(211, 164);
            this.student_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.student_pic.TabIndex = 8;
            this.student_pic.TabStop = false;
            this.student_pic.Click += new System.EventHandler(this.student_pic_Click_1);
            // 
            // staff_txt
            // 
            this.staff_txt.AutoSize = true;
            this.staff_txt.BackColor = System.Drawing.Color.Transparent;
            this.staff_txt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staff_txt.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff_txt.ForeColor = System.Drawing.Color.OrangeRed;
            this.staff_txt.Location = new System.Drawing.Point(511, 206);
            this.staff_txt.Name = "staff_txt";
            this.staff_txt.Size = new System.Drawing.Size(86, 25);
            this.staff_txt.TabIndex = 6;
            this.staff_txt.Text = "Update";
            // 
            // staff_pic
            // 
            this.staff_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staff_pic.Image = global::WindowsFormsApp1.Properties.Resources.updated;
            this.staff_pic.Location = new System.Drawing.Point(464, 29);
            this.staff_pic.Name = "staff_pic";
            this.staff_pic.Size = new System.Drawing.Size(192, 164);
            this.staff_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.staff_pic.TabIndex = 3;
            this.staff_pic.TabStop = false;
            this.staff_pic.Click += new System.EventHandler(this.staff_pic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(242, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Manage Rooms ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.close__1_;
            this.pictureBox1.Location = new System.Drawing.Point(636, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Manage_Rooms_Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(714, 336);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manage_Rooms_Option";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage_Rooms_Option";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staff_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label staff_txt;
        private System.Windows.Forms.PictureBox staff_pic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label student_txt;
        private System.Windows.Forms.PictureBox student_pic;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
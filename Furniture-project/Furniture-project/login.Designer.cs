namespace Furniture_project
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
            this.picbxloginbanner = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtadmin = new System.Windows.Forms.TextBox();
            this.lbladmin = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbxloginbanner)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picbxloginbanner
            // 
            this.picbxloginbanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.picbxloginbanner.Location = new System.Drawing.Point(0, 0);
            this.picbxloginbanner.Name = "picbxloginbanner";
            this.picbxloginbanner.Size = new System.Drawing.Size(407, 142);
            this.picbxloginbanner.TabIndex = 6;
            this.picbxloginbanner.TabStop = false;
            this.picbxloginbanner.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 313);
            this.panel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtadmin);
            this.groupBox1.Controls.Add(this.lbladmin);
            this.groupBox1.Controls.Add(this.lblpassword);
            this.groupBox1.Controls.Add(this.btnlogin);
            this.groupBox1.Controls.Add(this.txtpassword);
            this.groupBox1.Location = new System.Drawing.Point(7, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 162);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtadmin
            // 
            this.txtadmin.Location = new System.Drawing.Point(160, 28);
            this.txtadmin.Name = "txtadmin";
            this.txtadmin.Size = new System.Drawing.Size(184, 20);
            this.txtadmin.TabIndex = 2;
            this.txtadmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbladmin
            // 
            this.lbladmin.AutoSize = true;
            this.lbladmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladmin.Location = new System.Drawing.Point(53, 31);
            this.lbladmin.Name = "lbladmin";
            this.lbladmin.Size = new System.Drawing.Size(45, 13);
            this.lbladmin.TabIndex = 0;
            this.lbladmin.Text = "Admin:";
            this.lbladmin.Click += new System.EventHandler(this.lbladmin_Click);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(39, 74);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(59, 13);
            this.lblpassword.TabIndex = 1;
            this.lblpassword.Text = "Pasword:";
            // 
            // btnlogin
            // 
            this.btnlogin.AutoSize = true;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(160, 113);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(91, 25);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtpassword.Location = new System.Drawing.Point(160, 71);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(184, 20);
            this.txtpassword.TabIndex = 3;
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(407, 313);
            this.Controls.Add(this.picbxloginbanner);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(423, 352);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(423, 352);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbxloginbanner)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picbxloginbanner;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtadmin;
        private System.Windows.Forms.Label lbladmin;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtpassword;
    }
}


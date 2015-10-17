namespace Furniture_project.Category
{
    partial class addcategory
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsavecategory = new System.Windows.Forms.Button();
            this.btndeletecategory = new System.Windows.Forms.Button();
            this.lbladdcategory = new System.Windows.Forms.Label();
            this.txtcategory = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btncancelcategory = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Categoryname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btncancelcategory);
            this.panel1.Controls.Add(this.txtcategory);
            this.panel1.Controls.Add(this.lbladdcategory);
            this.panel1.Controls.Add(this.btndeletecategory);
            this.panel1.Controls.Add(this.btnsavecategory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 97);
            this.panel1.TabIndex = 0;
            // 
            // btnsavecategory
            // 
            this.btnsavecategory.Location = new System.Drawing.Point(30, 55);
            this.btnsavecategory.Name = "btnsavecategory";
            this.btnsavecategory.Size = new System.Drawing.Size(58, 23);
            this.btnsavecategory.TabIndex = 0;
            this.btnsavecategory.Text = "Save";
            this.btnsavecategory.UseVisualStyleBackColor = true;
            // 
            // btndeletecategory
            // 
            this.btndeletecategory.Location = new System.Drawing.Point(112, 55);
            this.btndeletecategory.Name = "btndeletecategory";
            this.btndeletecategory.Size = new System.Drawing.Size(59, 23);
            this.btndeletecategory.TabIndex = 1;
            this.btndeletecategory.Text = "Delete";
            this.btndeletecategory.UseVisualStyleBackColor = true;
            this.btndeletecategory.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbladdcategory
            // 
            this.lbladdcategory.AutoSize = true;
            this.lbladdcategory.Location = new System.Drawing.Point(12, 22);
            this.lbladdcategory.Name = "lbladdcategory";
            this.lbladdcategory.Size = new System.Drawing.Size(83, 13);
            this.lbladdcategory.TabIndex = 2;
            this.lbladdcategory.Text = "Category Name:";
            // 
            // txtcategory
            // 
            this.txtcategory.Location = new System.Drawing.Point(112, 19);
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.Size = new System.Drawing.Size(149, 20);
            this.txtcategory.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 222);
            this.panel2.TabIndex = 1;
            // 
            // btncancelcategory
            // 
            this.btncancelcategory.Location = new System.Drawing.Point(192, 55);
            this.btncancelcategory.Name = "btncancelcategory";
            this.btncancelcategory.Size = new System.Drawing.Size(64, 23);
            this.btncancelcategory.TabIndex = 4;
            this.btncancelcategory.Text = "Cancel";
            this.btncancelcategory.UseVisualStyleBackColor = true;
            this.btncancelcategory.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Categoryname});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(290, 222);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Categoryname
            // 
            this.Categoryname.DataPropertyName = "Categoryname";
            this.Categoryname.HeaderText = "Category Name";
            this.Categoryname.Name = "Categoryname";
            this.Categoryname.ReadOnly = true;
            this.Categoryname.Width = 250;
            // 
            // addcategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 319);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "addcategory";
            this.Text = "Add Category";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btndeletecategory;
        private System.Windows.Forms.Button btnsavecategory;
        private System.Windows.Forms.TextBox txtcategory;
        private System.Windows.Forms.Label lbladdcategory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btncancelcategory;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoryname;
    }
}
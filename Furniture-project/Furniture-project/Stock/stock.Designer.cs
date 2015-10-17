namespace Furniture_project.Stock
{
    partial class stock
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
            this.btnaddstock = new System.Windows.Forms.Button();
            this.btnsearchstock = new System.Windows.Forms.Button();
            this.lblsearchstock = new System.Windows.Forms.Label();
            this.txtsearchstock = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ddlsearchstockcategory = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewstock = new System.Windows.Forms.DataGridView();
            this.Categoryname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewstock)).BeginInit();
            this.SuspendLayout();
            // 
            // btnaddstock
            // 
            this.btnaddstock.Location = new System.Drawing.Point(29, 12);
            this.btnaddstock.Name = "btnaddstock";
            this.btnaddstock.Size = new System.Drawing.Size(163, 23);
            this.btnaddstock.TabIndex = 0;
            this.btnaddstock.Text = "Add Stock";
            this.btnaddstock.UseVisualStyleBackColor = true;
            this.btnaddstock.Click += new System.EventHandler(this.btnaddstock_Click);
            // 
            // btnsearchstock
            // 
            this.btnsearchstock.Location = new System.Drawing.Point(382, 49);
            this.btnsearchstock.Name = "btnsearchstock";
            this.btnsearchstock.Size = new System.Drawing.Size(66, 23);
            this.btnsearchstock.TabIndex = 3;
            this.btnsearchstock.Text = "Search";
            this.btnsearchstock.UseVisualStyleBackColor = true;
            this.btnsearchstock.Click += new System.EventHandler(this.btnsearchstock_Click);
            // 
            // lblsearchstock
            // 
            this.lblsearchstock.AutoSize = true;
            this.lblsearchstock.Location = new System.Drawing.Point(26, 53);
            this.lblsearchstock.Name = "lblsearchstock";
            this.lblsearchstock.Size = new System.Drawing.Size(44, 13);
            this.lblsearchstock.TabIndex = 0;
            this.lblsearchstock.Text = "Search:";
            // 
            // txtsearchstock
            // 
            this.txtsearchstock.Location = new System.Drawing.Point(199, 51);
            this.txtsearchstock.Name = "txtsearchstock";
            this.txtsearchstock.Size = new System.Drawing.Size(168, 20);
            this.txtsearchstock.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ddlsearchstockcategory);
            this.panel1.Controls.Add(this.btnaddstock);
            this.panel1.Controls.Add(this.btnsearchstock);
            this.panel1.Controls.Add(this.txtsearchstock);
            this.panel1.Controls.Add(this.lblsearchstock);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 85);
            this.panel1.TabIndex = 4;
            // 
            // ddlsearchstockcategory
            // 
            this.ddlsearchstockcategory.FormattingEnabled = true;
            this.ddlsearchstockcategory.Location = new System.Drawing.Point(76, 50);
            this.ddlsearchstockcategory.Name = "ddlsearchstockcategory";
            this.ddlsearchstockcategory.Size = new System.Drawing.Size(116, 21);
            this.ddlsearchstockcategory.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewstock);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 293);
            this.panel2.TabIndex = 5;
            // 
            // dataGridViewstock
            // 
            this.dataGridViewstock.AllowUserToDeleteRows = false;
            this.dataGridViewstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewstock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Categoryname,
            this.Productname,
            this.Quantity,
            this.Price,
            this.modify,
            this.Delete});
            this.dataGridViewstock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewstock.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewstock.Name = "dataGridViewstock";
            this.dataGridViewstock.Size = new System.Drawing.Size(652, 293);
            this.dataGridViewstock.TabIndex = 0;
            this.dataGridViewstock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewstock_CellClick);
            this.dataGridViewstock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewstock_CellContentClick);
            this.dataGridViewstock.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewstock_MouseDoubleClick);
            // 
            // Categoryname
            // 
            this.Categoryname.DataPropertyName = "Categoryname";
            this.Categoryname.HeaderText = "Category Name";
            this.Categoryname.Name = "Categoryname";
            this.Categoryname.ReadOnly = true;
            this.Categoryname.Width = 110;
            // 
            // Productname
            // 
            this.Productname.DataPropertyName = "Productname";
            this.Productname.HeaderText = "Product Name";
            this.Productname.Name = "Productname";
            this.Productname.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // modify
            // 
            this.modify.HeaderText = "";
            this.modify.Name = "modify";
            this.modify.ReadOnly = true;
            this.modify.Text = "Modify";
            this.modify.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 378);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.stock_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewstock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnaddstock;
        private System.Windows.Forms.Button btnsearchstock;
        private System.Windows.Forms.Label lblsearchstock;
        private System.Windows.Forms.TextBox txtsearchstock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewstock;
        private System.Windows.Forms.ComboBox ddlsearchstockcategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoryname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewButtonColumn modify;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}
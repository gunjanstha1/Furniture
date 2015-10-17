namespace Furniture_project.Sales
{
    partial class productlist
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnsearchlistsales = new System.Windows.Forms.Button();
            this.ddlsearchcategorysaleslist = new System.Windows.Forms.ComboBox();
            this.txtsearchlistsales = new System.Windows.Forms.TextBox();
            this.lblsearchsaleslist = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewsalesproductlist = new System.Windows.Forms.DataGridView();
            this.Categoryname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsalesproductlist)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnsearchlistsales);
            this.panel2.Controls.Add(this.ddlsearchcategorysaleslist);
            this.panel2.Controls.Add(this.txtsearchlistsales);
            this.panel2.Controls.Add(this.lblsearchsaleslist);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 62);
            this.panel2.TabIndex = 1;
            // 
            // btnsearchlistsales
            // 
            this.btnsearchlistsales.Location = new System.Drawing.Point(337, 20);
            this.btnsearchlistsales.Name = "btnsearchlistsales";
            this.btnsearchlistsales.Size = new System.Drawing.Size(76, 23);
            this.btnsearchlistsales.TabIndex = 3;
            this.btnsearchlistsales.Text = "Search";
            this.btnsearchlistsales.UseVisualStyleBackColor = true;
            // 
            // ddlsearchcategorysaleslist
            // 
            this.ddlsearchcategorysaleslist.FormattingEnabled = true;
            this.ddlsearchcategorysaleslist.Location = new System.Drawing.Point(60, 21);
            this.ddlsearchcategorysaleslist.Name = "ddlsearchcategorysaleslist";
            this.ddlsearchcategorysaleslist.Size = new System.Drawing.Size(101, 21);
            this.ddlsearchcategorysaleslist.TabIndex = 1;
            // 
            // txtsearchlistsales
            // 
            this.txtsearchlistsales.Location = new System.Drawing.Point(167, 22);
            this.txtsearchlistsales.Name = "txtsearchlistsales";
            this.txtsearchlistsales.Size = new System.Drawing.Size(154, 20);
            this.txtsearchlistsales.TabIndex = 2;
            // 
            // lblsearchsaleslist
            // 
            this.lblsearchsaleslist.AutoSize = true;
            this.lblsearchsaleslist.Location = new System.Drawing.Point(10, 25);
            this.lblsearchsaleslist.Name = "lblsearchsaleslist";
            this.lblsearchsaleslist.Size = new System.Drawing.Size(44, 13);
            this.lblsearchsaleslist.TabIndex = 6;
            this.lblsearchsaleslist.Text = "Search:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewsalesproductlist);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 392);
            this.panel1.TabIndex = 2;
            // 
            // dataGridViewsalesproductlist
            // 
            this.dataGridViewsalesproductlist.AllowUserToAddRows = false;
            this.dataGridViewsalesproductlist.AllowUserToDeleteRows = false;
            this.dataGridViewsalesproductlist.AllowUserToOrderColumns = true;
            this.dataGridViewsalesproductlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewsalesproductlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Categoryname,
            this.Productname,
            this.Quantity,
            this.Price});
            this.dataGridViewsalesproductlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewsalesproductlist.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewsalesproductlist.Name = "dataGridViewsalesproductlist";
            this.dataGridViewsalesproductlist.ReadOnly = true;
            this.dataGridViewsalesproductlist.Size = new System.Drawing.Size(470, 392);
            this.dataGridViewsalesproductlist.TabIndex = 1;
            this.dataGridViewsalesproductlist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewsalesproductlist_CellClick);
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
            // productlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 454);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "productlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product list for Sales";
            this.Load += new System.EventHandler(this.productlist_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsalesproductlist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewsalesproductlist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoryname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Button btnsearchlistsales;
        private System.Windows.Forms.ComboBox ddlsearchcategorysaleslist;
        private System.Windows.Forms.TextBox txtsearchlistsales;
        private System.Windows.Forms.Label lblsearchsaleslist;
    }
}
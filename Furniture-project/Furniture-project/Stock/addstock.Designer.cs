namespace Furniture_project.Stock
{
    partial class addstock
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
            this.btncanceladdstock = new System.Windows.Forms.Button();
            this.txtstockprice = new System.Windows.Forms.TextBox();
            this.lblstockprice = new System.Windows.Forms.Label();
            this.btnaddstock = new System.Windows.Forms.Button();
            this.lblstockname = new System.Windows.Forms.Label();
            this.lblstockcategory = new System.Windows.Forms.Label();
            this.ddlstockcategory = new System.Windows.Forms.ComboBox();
            this.lblstockquantity = new System.Windows.Forms.Label();
            this.txtstockquantity = new System.Windows.Forms.TextBox();
            this.lblstockqtyunit = new System.Windows.Forms.Label();
            this.txtstockname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncanceladdstock
            // 
            this.btncanceladdstock.Location = new System.Drawing.Point(224, 204);
            this.btncanceladdstock.Name = "btncanceladdstock";
            this.btncanceladdstock.Size = new System.Drawing.Size(94, 23);
            this.btncanceladdstock.TabIndex = 6;
            this.btncanceladdstock.Text = "Cancel";
            this.btncanceladdstock.UseVisualStyleBackColor = true;
            this.btncanceladdstock.Click += new System.EventHandler(this.btncanceladdstock_Click);
            // 
            // txtstockprice
            // 
            this.txtstockprice.Location = new System.Drawing.Point(106, 162);
            this.txtstockprice.Name = "txtstockprice";
            this.txtstockprice.Size = new System.Drawing.Size(141, 20);
            this.txtstockprice.TabIndex = 4;
            // 
            // lblstockprice
            // 
            this.lblstockprice.AutoSize = true;
            this.lblstockprice.Location = new System.Drawing.Point(36, 162);
            this.lblstockprice.Name = "lblstockprice";
            this.lblstockprice.Size = new System.Drawing.Size(34, 13);
            this.lblstockprice.TabIndex = 9;
            this.lblstockprice.Text = "Price:";
            // 
            // btnaddstock
            // 
            this.btnaddstock.Location = new System.Drawing.Point(81, 204);
            this.btnaddstock.Name = "btnaddstock";
            this.btnaddstock.Size = new System.Drawing.Size(94, 23);
            this.btnaddstock.TabIndex = 5;
            this.btnaddstock.Text = "Add";
            this.btnaddstock.UseVisualStyleBackColor = true;
            this.btnaddstock.Click += new System.EventHandler(this.btnaddstock_Click);
            // 
            // lblstockname
            // 
            this.lblstockname.AutoSize = true;
            this.lblstockname.Location = new System.Drawing.Point(34, 80);
            this.lblstockname.Name = "lblstockname";
            this.lblstockname.Size = new System.Drawing.Size(38, 13);
            this.lblstockname.TabIndex = 7;
            this.lblstockname.Text = "Name:";
            // 
            // lblstockcategory
            // 
            this.lblstockcategory.AutoSize = true;
            this.lblstockcategory.Location = new System.Drawing.Point(27, 25);
            this.lblstockcategory.Name = "lblstockcategory";
            this.lblstockcategory.Size = new System.Drawing.Size(49, 13);
            this.lblstockcategory.TabIndex = 12;
            this.lblstockcategory.Text = "Category";
            // 
            // ddlstockcategory
            // 
            this.ddlstockcategory.FormattingEnabled = true;
            this.ddlstockcategory.Location = new System.Drawing.Point(108, 22);
            this.ddlstockcategory.Name = "ddlstockcategory";
            this.ddlstockcategory.Size = new System.Drawing.Size(141, 21);
            this.ddlstockcategory.TabIndex = 1;
            this.ddlstockcategory.SelectedIndexChanged += new System.EventHandler(this.ddlstockcategory_SelectedIndexChanged);
            // 
            // lblstockquantity
            // 
            this.lblstockquantity.AutoSize = true;
            this.lblstockquantity.Location = new System.Drawing.Point(27, 122);
            this.lblstockquantity.Name = "lblstockquantity";
            this.lblstockquantity.Size = new System.Drawing.Size(49, 13);
            this.lblstockquantity.TabIndex = 15;
            this.lblstockquantity.Text = "Quantity:";
            // 
            // txtstockquantity
            // 
            this.txtstockquantity.Location = new System.Drawing.Point(108, 119);
            this.txtstockquantity.Name = "txtstockquantity";
            this.txtstockquantity.Size = new System.Drawing.Size(122, 20);
            this.txtstockquantity.TabIndex = 3;
            // 
            // lblstockqtyunit
            // 
            this.lblstockqtyunit.AutoSize = true;
            this.lblstockqtyunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstockqtyunit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblstockqtyunit.Location = new System.Drawing.Point(250, 165);
            this.lblstockqtyunit.Name = "lblstockqtyunit";
            this.lblstockqtyunit.Size = new System.Drawing.Size(126, 13);
            this.lblstockqtyunit.TabIndex = 16;
            this.lblstockqtyunit.Text = "Per/piece or per/quantity";
            // 
            // txtstockname
            // 
            this.txtstockname.Location = new System.Drawing.Point(106, 77);
            this.txtstockname.Name = "txtstockname";
            this.txtstockname.Size = new System.Drawing.Size(165, 20);
            this.txtstockname.TabIndex = 2;
            // 
            // addstock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 254);
            this.Controls.Add(this.txtstockname);
            this.Controls.Add(this.lblstockqtyunit);
            this.Controls.Add(this.lblstockquantity);
            this.Controls.Add(this.txtstockquantity);
            this.Controls.Add(this.ddlstockcategory);
            this.Controls.Add(this.lblstockcategory);
            this.Controls.Add(this.btncanceladdstock);
            this.Controls.Add(this.txtstockprice);
            this.Controls.Add(this.lblstockprice);
            this.Controls.Add(this.btnaddstock);
            this.Controls.Add(this.lblstockname);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addstock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Stock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.addstock_FormClosing);
            this.Load += new System.EventHandler(this.addstock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncanceladdstock;
        private System.Windows.Forms.TextBox txtstockprice;
        private System.Windows.Forms.Label lblstockprice;
        private System.Windows.Forms.Button btnaddstock;
        private System.Windows.Forms.Label lblstockname;
        private System.Windows.Forms.Label lblstockcategory;
        private System.Windows.Forms.ComboBox ddlstockcategory;
        private System.Windows.Forms.Label lblstockquantity;
        private System.Windows.Forms.TextBox txtstockquantity;
        private System.Windows.Forms.Label lblstockqtyunit;
        private System.Windows.Forms.TextBox txtstockname;
    }
}
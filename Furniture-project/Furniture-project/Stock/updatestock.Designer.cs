namespace Furniture_project.Stock
{
    partial class updatestock
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
            this.btncancelupdatestock = new System.Windows.Forms.Button();
            this.txtstockpriceupdate = new System.Windows.Forms.TextBox();
            this.lblstockpriceupdate = new System.Windows.Forms.Label();
            this.btnupdatestock = new System.Windows.Forms.Button();
            this.lblstocknameupdate = new System.Windows.Forms.Label();
            this.txtstocknameupdate = new System.Windows.Forms.TextBox();
            this.ddlstockcategory = new System.Windows.Forms.ComboBox();
            this.lblstockcategory = new System.Windows.Forms.Label();
            this.lblstockquantity = new System.Windows.Forms.Label();
            this.txtstockquantityupdate = new System.Windows.Forms.TextBox();
            this.lblstockqtyunit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncancelupdatestock
            // 
            this.btncancelupdatestock.Location = new System.Drawing.Point(209, 231);
            this.btncancelupdatestock.Name = "btncancelupdatestock";
            this.btncancelupdatestock.Size = new System.Drawing.Size(94, 23);
            this.btncancelupdatestock.TabIndex = 6;
            this.btncancelupdatestock.Text = "Cancel";
            this.btncancelupdatestock.UseVisualStyleBackColor = true;
            this.btncancelupdatestock.Click += new System.EventHandler(this.btncancelupdatestock_Click);
            // 
            // txtstockpriceupdate
            // 
            this.txtstockpriceupdate.Location = new System.Drawing.Point(99, 188);
            this.txtstockpriceupdate.Name = "txtstockpriceupdate";
            this.txtstockpriceupdate.Size = new System.Drawing.Size(141, 20);
            this.txtstockpriceupdate.TabIndex = 4;
            // 
            // lblstockpriceupdate
            // 
            this.lblstockpriceupdate.AutoSize = true;
            this.lblstockpriceupdate.Location = new System.Drawing.Point(26, 191);
            this.lblstockpriceupdate.Name = "lblstockpriceupdate";
            this.lblstockpriceupdate.Size = new System.Drawing.Size(34, 13);
            this.lblstockpriceupdate.TabIndex = 9;
            this.lblstockpriceupdate.Text = "Price:";
            // 
            // btnupdatestock
            // 
            this.btnupdatestock.Location = new System.Drawing.Point(59, 231);
            this.btnupdatestock.Name = "btnupdatestock";
            this.btnupdatestock.Size = new System.Drawing.Size(94, 23);
            this.btnupdatestock.TabIndex = 5;
            this.btnupdatestock.Text = "Update";
            this.btnupdatestock.UseVisualStyleBackColor = true;
            this.btnupdatestock.Click += new System.EventHandler(this.btnupdatestock_Click);
            // 
            // lblstocknameupdate
            // 
            this.lblstocknameupdate.AutoSize = true;
            this.lblstocknameupdate.Location = new System.Drawing.Point(23, 113);
            this.lblstocknameupdate.Name = "lblstocknameupdate";
            this.lblstocknameupdate.Size = new System.Drawing.Size(38, 13);
            this.lblstocknameupdate.TabIndex = 7;
            this.lblstocknameupdate.Text = "Name:";
            // 
            // txtstocknameupdate
            // 
            this.txtstocknameupdate.Location = new System.Drawing.Point(99, 110);
            this.txtstocknameupdate.Name = "txtstocknameupdate";
            this.txtstocknameupdate.Size = new System.Drawing.Size(204, 20);
            this.txtstocknameupdate.TabIndex = 2;
            // 
            // ddlstockcategory
            // 
            this.ddlstockcategory.FormattingEnabled = true;
            this.ddlstockcategory.Location = new System.Drawing.Point(99, 60);
            this.ddlstockcategory.Name = "ddlstockcategory";
            this.ddlstockcategory.Size = new System.Drawing.Size(141, 21);
            this.ddlstockcategory.TabIndex = 1;
            // 
            // lblstockcategory
            // 
            this.lblstockcategory.AutoSize = true;
            this.lblstockcategory.Location = new System.Drawing.Point(18, 63);
            this.lblstockcategory.Name = "lblstockcategory";
            this.lblstockcategory.Size = new System.Drawing.Size(49, 13);
            this.lblstockcategory.TabIndex = 14;
            this.lblstockcategory.Text = "Category";
            // 
            // lblstockquantity
            // 
            this.lblstockquantity.AutoSize = true;
            this.lblstockquantity.Location = new System.Drawing.Point(18, 153);
            this.lblstockquantity.Name = "lblstockquantity";
            this.lblstockquantity.Size = new System.Drawing.Size(49, 13);
            this.lblstockquantity.TabIndex = 18;
            this.lblstockquantity.Text = "Quantity:";
            // 
            // txtstockquantityupdate
            // 
            this.txtstockquantityupdate.Location = new System.Drawing.Point(99, 150);
            this.txtstockquantityupdate.Name = "txtstockquantityupdate";
            this.txtstockquantityupdate.Size = new System.Drawing.Size(94, 20);
            this.txtstockquantityupdate.TabIndex = 3;
            // 
            // lblstockqtyunit
            // 
            this.lblstockqtyunit.AutoSize = true;
            this.lblstockqtyunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstockqtyunit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblstockqtyunit.Location = new System.Drawing.Point(243, 191);
            this.lblstockqtyunit.Name = "lblstockqtyunit";
            this.lblstockqtyunit.Size = new System.Drawing.Size(126, 13);
            this.lblstockqtyunit.TabIndex = 20;
            this.lblstockqtyunit.Text = "Per/piece or per/quantity";
            // 
            // updatestock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 282);
            this.Controls.Add(this.lblstockqtyunit);
            this.Controls.Add(this.lblstockquantity);
            this.Controls.Add(this.txtstockquantityupdate);
            this.Controls.Add(this.ddlstockcategory);
            this.Controls.Add(this.lblstockcategory);
            this.Controls.Add(this.btncancelupdatestock);
            this.Controls.Add(this.txtstockpriceupdate);
            this.Controls.Add(this.lblstockpriceupdate);
            this.Controls.Add(this.btnupdatestock);
            this.Controls.Add(this.lblstocknameupdate);
            this.Controls.Add(this.txtstocknameupdate);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "updatestock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Stock";
            this.Load += new System.EventHandler(this.updatestock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelupdatestock;
        private System.Windows.Forms.Label lblstockpriceupdate;
        private System.Windows.Forms.Button btnupdatestock;
        private System.Windows.Forms.Label lblstocknameupdate;
        private System.Windows.Forms.Label lblstockcategory;
        private System.Windows.Forms.Label lblstockquantity;
        private System.Windows.Forms.Label lblstockqtyunit;
        public System.Windows.Forms.TextBox txtstockpriceupdate;
        public System.Windows.Forms.TextBox txtstocknameupdate;
        public System.Windows.Forms.ComboBox ddlstockcategory;
        public System.Windows.Forms.TextBox txtstockquantityupdate;
    }
}
namespace Furniture_project.Sales
{
    partial class Billing
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
            this.txttotalsalesamount = new System.Windows.Forms.TextBox();
            this.lbltotalsalesamount = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePickerbilling = new System.Windows.Forms.DateTimePicker();
            this.lbldatebilling = new System.Windows.Forms.Label();
            this.btnprintbills = new System.Windows.Forms.Button();
            this.txtbillnosales = new System.Windows.Forms.TextBox();
            this.lblbillnosales = new System.Windows.Forms.Label();
            this.btnsavesalesrecord = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewBilling = new System.Windows.Forms.DataGridView();
            this.Categoryname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBilling)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txttotalsalesamount);
            this.panel1.Controls.Add(this.lbltotalsalesamount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 336);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 68);
            this.panel1.TabIndex = 0;
            // 
            // txttotalsalesamount
            // 
            this.txttotalsalesamount.Location = new System.Drawing.Point(413, 20);
            this.txttotalsalesamount.Name = "txttotalsalesamount";
            this.txttotalsalesamount.Size = new System.Drawing.Size(139, 20);
            this.txttotalsalesamount.TabIndex = 5;
            // 
            // lbltotalsalesamount
            // 
            this.lbltotalsalesamount.AutoSize = true;
            this.lbltotalsalesamount.Location = new System.Drawing.Point(334, 23);
            this.lbltotalsalesamount.Name = "lbltotalsalesamount";
            this.lbltotalsalesamount.Size = new System.Drawing.Size(73, 13);
            this.lbltotalsalesamount.TabIndex = 4;
            this.lbltotalsalesamount.Text = "Total Amount:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTimePickerbilling);
            this.panel2.Controls.Add(this.lbldatebilling);
            this.panel2.Controls.Add(this.btnprintbills);
            this.panel2.Controls.Add(this.txtbillnosales);
            this.panel2.Controls.Add(this.lblbillnosales);
            this.panel2.Controls.Add(this.btnsavesalesrecord);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 81);
            this.panel2.TabIndex = 1;
            // 
            // dateTimePickerbilling
            // 
            this.dateTimePickerbilling.Location = new System.Drawing.Point(67, 47);
            this.dateTimePickerbilling.Name = "dateTimePickerbilling";
            this.dateTimePickerbilling.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerbilling.TabIndex = 2;
            // 
            // lbldatebilling
            // 
            this.lbldatebilling.AutoSize = true;
            this.lbldatebilling.Location = new System.Drawing.Point(28, 50);
            this.lbldatebilling.Name = "lbldatebilling";
            this.lbldatebilling.Size = new System.Drawing.Size(33, 13);
            this.lbldatebilling.TabIndex = 4;
            this.lbldatebilling.Text = "Date:";
            // 
            // btnprintbills
            // 
            this.btnprintbills.Location = new System.Drawing.Point(464, 29);
            this.btnprintbills.Name = "btnprintbills";
            this.btnprintbills.Size = new System.Drawing.Size(75, 23);
            this.btnprintbills.TabIndex = 4;
            this.btnprintbills.Text = "Print";
            this.btnprintbills.UseVisualStyleBackColor = true;
            // 
            // txtbillnosales
            // 
            this.txtbillnosales.Location = new System.Drawing.Point(74, 13);
            this.txtbillnosales.Name = "txtbillnosales";
            this.txtbillnosales.Size = new System.Drawing.Size(125, 20);
            this.txtbillnosales.TabIndex = 1;
            // 
            // lblbillnosales
            // 
            this.lblbillnosales.AutoSize = true;
            this.lblbillnosales.Location = new System.Drawing.Point(28, 16);
            this.lblbillnosales.Name = "lblbillnosales";
            this.lblbillnosales.Size = new System.Drawing.Size(40, 13);
            this.lblbillnosales.TabIndex = 1;
            this.lblbillnosales.Text = "Bill No:";
            // 
            // btnsavesalesrecord
            // 
            this.btnsavesalesrecord.Location = new System.Drawing.Point(397, 29);
            this.btnsavesalesrecord.Name = "btnsavesalesrecord";
            this.btnsavesalesrecord.Size = new System.Drawing.Size(61, 23);
            this.btnsavesalesrecord.TabIndex = 3;
            this.btnsavesalesrecord.Text = "Save";
            this.btnsavesalesrecord.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridViewBilling);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(553, 255);
            this.panel3.TabIndex = 2;
            // 
            // dataGridViewBilling
            // 
            this.dataGridViewBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBilling.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Categoryname,
            this.Productname,
            this.Quantity,
            this.Price,
            this.Amount});
            this.dataGridViewBilling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBilling.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBilling.Name = "dataGridViewBilling";
            this.dataGridViewBilling.Size = new System.Drawing.Size(553, 255);
            this.dataGridViewBilling.TabIndex = 0;
            this.dataGridViewBilling.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBilling_CellClick);
            this.dataGridViewBilling.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBilling_CellContentClick);
            // 
            // Categoryname
            // 
            this.Categoryname.DataPropertyName = "Categoryname";
            this.Categoryname.HeaderText = "Category Name";
            this.Categoryname.Name = "Categoryname";
            this.Categoryname.Width = 110;
            // 
            // Productname
            // 
            this.Productname.DataPropertyName = "Productname";
            this.Productname.HeaderText = "Product Name";
            this.Productname.Name = "Productname";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Unit Price";
            this.Price.Name = "Price";
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 404);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Billing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing for Sold Product";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Billing_FormClosing);
            this.Load += new System.EventHandler(this.Billing_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBilling)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txttotalsalesamount;
        private System.Windows.Forms.Label lbltotalsalesamount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnprintbills;
        private System.Windows.Forms.TextBox txtbillnosales;
        private System.Windows.Forms.Label lblbillnosales;
        private System.Windows.Forms.Button btnsavesalesrecord;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewBilling;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoryname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DateTimePicker dateTimePickerbilling;
        private System.Windows.Forms.Label lbldatebilling;
    }
}
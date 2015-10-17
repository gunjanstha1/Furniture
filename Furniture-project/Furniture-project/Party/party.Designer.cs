namespace Furniture_project
{
    partial class party
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
            this.panelparty = new System.Windows.Forms.Panel();
            this.btnaddnewparty = new System.Windows.Forms.Button();
            this.btnsearchparty = new System.Windows.Forms.Button();
            this.txtsearchparty = new System.Windows.Forms.TextBox();
            this.lblsearchparty = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewparty = new System.Windows.Forms.DataGridView();
            this.ddlsearchpartycategory = new System.Windows.Forms.ComboBox();
            this.panelparty.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewparty)).BeginInit();
            this.SuspendLayout();
            // 
            // panelparty
            // 
            this.panelparty.Controls.Add(this.ddlsearchpartycategory);
            this.panelparty.Controls.Add(this.btnaddnewparty);
            this.panelparty.Controls.Add(this.btnsearchparty);
            this.panelparty.Controls.Add(this.txtsearchparty);
            this.panelparty.Controls.Add(this.lblsearchparty);
            this.panelparty.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelparty.Location = new System.Drawing.Point(0, 0);
            this.panelparty.Name = "panelparty";
            this.panelparty.Size = new System.Drawing.Size(696, 89);
            this.panelparty.TabIndex = 0;
            // 
            // btnaddnewparty
            // 
            this.btnaddnewparty.Location = new System.Drawing.Point(58, 12);
            this.btnaddnewparty.Name = "btnaddnewparty";
            this.btnaddnewparty.Size = new System.Drawing.Size(111, 25);
            this.btnaddnewparty.TabIndex = 3;
            this.btnaddnewparty.Text = "Add New Party";
            this.btnaddnewparty.UseVisualStyleBackColor = true;
            this.btnaddnewparty.Click += new System.EventHandler(this.btnaddnewparty_Click);
            // 
            // btnsearchparty
            // 
            this.btnsearchparty.Location = new System.Drawing.Point(389, 52);
            this.btnsearchparty.Name = "btnsearchparty";
            this.btnsearchparty.Size = new System.Drawing.Size(86, 20);
            this.btnsearchparty.TabIndex = 2;
            this.btnsearchparty.Text = "Search";
            this.btnsearchparty.UseVisualStyleBackColor = true;
            // 
            // txtsearchparty
            // 
            this.txtsearchparty.Location = new System.Drawing.Point(202, 52);
            this.txtsearchparty.Name = "txtsearchparty";
            this.txtsearchparty.Size = new System.Drawing.Size(171, 20);
            this.txtsearchparty.TabIndex = 1;
            // 
            // lblsearchparty
            // 
            this.lblsearchparty.AutoSize = true;
            this.lblsearchparty.Location = new System.Drawing.Point(30, 57);
            this.lblsearchparty.Name = "lblsearchparty";
            this.lblsearchparty.Size = new System.Drawing.Size(44, 13);
            this.lblsearchparty.TabIndex = 0;
            this.lblsearchparty.Text = "Search:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewparty);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 267);
            this.panel1.TabIndex = 1;
            // 
            // dataGridViewparty
            // 
            this.dataGridViewparty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewparty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewparty.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewparty.Name = "dataGridViewparty";
            this.dataGridViewparty.Size = new System.Drawing.Size(696, 267);
            this.dataGridViewparty.TabIndex = 0;
            // 
            // ddlsearchpartycategory
            // 
            this.ddlsearchpartycategory.FormattingEnabled = true;
            this.ddlsearchpartycategory.Location = new System.Drawing.Point(80, 52);
            this.ddlsearchpartycategory.Name = "ddlsearchpartycategory";
            this.ddlsearchpartycategory.Size = new System.Drawing.Size(116, 21);
            this.ddlsearchpartycategory.TabIndex = 15;
            // 
            // party
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 356);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelparty);
            this.Name = "party";
            this.Text = "Party";
            this.Load += new System.EventHandler(this.party_Load);
            this.panelparty.ResumeLayout(false);
            this.panelparty.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewparty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelparty;
        private System.Windows.Forms.Button btnsearchparty;
        private System.Windows.Forms.TextBox txtsearchparty;
        private System.Windows.Forms.Label lblsearchparty;
        private System.Windows.Forms.Button btnaddnewparty;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewparty;
        private System.Windows.Forms.ComboBox ddlsearchpartycategory;
    }
}
namespace Furniture_project
{
    partial class sales
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
            this.btnsearchlist = new System.Windows.Forms.Button();
            this.ddlsearchcategory = new System.Windows.Forms.ComboBox();
            this.txtsearchlist = new System.Windows.Forms.TextBox();
            this.lblsearchsaleslist = new System.Windows.Forms.Label();
            this.btnsalesbilling = new System.Windows.Forms.Button();
            this.btnprintsaleslist = new System.Windows.Forms.Button();
            this.dataGridViewsaleslist = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txttotalamountsales = new System.Windows.Forms.TextBox();
            this.lbltotalamountsales = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsaleslist)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnsearchlist);
            this.panel1.Controls.Add(this.ddlsearchcategory);
            this.panel1.Controls.Add(this.txtsearchlist);
            this.panel1.Controls.Add(this.lblsearchsaleslist);
            this.panel1.Controls.Add(this.btnsalesbilling);
            this.panel1.Controls.Add(this.btnprintsaleslist);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 84);
            this.panel1.TabIndex = 0;
            // 
            // btnsearchlist
            // 
            this.btnsearchlist.Location = new System.Drawing.Point(390, 47);
            this.btnsearchlist.Name = "btnsearchlist";
            this.btnsearchlist.Size = new System.Drawing.Size(76, 23);
            this.btnsearchlist.TabIndex = 4;
            this.btnsearchlist.Text = "Search";
            this.btnsearchlist.UseVisualStyleBackColor = true;
            // 
            // ddlsearchcategory
            // 
            this.ddlsearchcategory.FormattingEnabled = true;
            this.ddlsearchcategory.Location = new System.Drawing.Point(79, 48);
            this.ddlsearchcategory.Name = "ddlsearchcategory";
            this.ddlsearchcategory.Size = new System.Drawing.Size(121, 21);
            this.ddlsearchcategory.TabIndex = 2;
            // 
            // txtsearchlist
            // 
            this.txtsearchlist.Location = new System.Drawing.Point(209, 49);
            this.txtsearchlist.Name = "txtsearchlist";
            this.txtsearchlist.Size = new System.Drawing.Size(170, 20);
            this.txtsearchlist.TabIndex = 3;
            // 
            // lblsearchsaleslist
            // 
            this.lblsearchsaleslist.AutoSize = true;
            this.lblsearchsaleslist.Location = new System.Drawing.Point(29, 52);
            this.lblsearchsaleslist.Name = "lblsearchsaleslist";
            this.lblsearchsaleslist.Size = new System.Drawing.Size(44, 13);
            this.lblsearchsaleslist.TabIndex = 2;
            this.lblsearchsaleslist.Text = "Search:";
            // 
            // btnsalesbilling
            // 
            this.btnsalesbilling.Location = new System.Drawing.Point(29, 12);
            this.btnsalesbilling.Name = "btnsalesbilling";
            this.btnsalesbilling.Size = new System.Drawing.Size(171, 23);
            this.btnsalesbilling.TabIndex = 1;
            this.btnsalesbilling.Text = "Biling todays sales";
            this.btnsalesbilling.UseVisualStyleBackColor = true;
            this.btnsalesbilling.Click += new System.EventHandler(this.btnsalesbilling_Click);
            // 
            // btnprintsaleslist
            // 
            this.btnprintsaleslist.Location = new System.Drawing.Point(550, 12);
            this.btnprintsaleslist.Name = "btnprintsaleslist";
            this.btnprintsaleslist.Size = new System.Drawing.Size(75, 23);
            this.btnprintsaleslist.TabIndex = 5;
            this.btnprintsaleslist.Text = "Print";
            this.btnprintsaleslist.UseVisualStyleBackColor = true;
            // 
            // dataGridViewsaleslist
            // 
            this.dataGridViewsaleslist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewsaleslist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewsaleslist.Location = new System.Drawing.Point(0, 84);
            this.dataGridViewsaleslist.Name = "dataGridViewsaleslist";
            this.dataGridViewsaleslist.Size = new System.Drawing.Size(648, 312);
            this.dataGridViewsaleslist.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txttotalamountsales);
            this.panel2.Controls.Add(this.lbltotalamountsales);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 351);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(648, 45);
            this.panel2.TabIndex = 2;
            // 
            // txttotalamountsales
            // 
            this.txttotalamountsales.Location = new System.Drawing.Point(470, 13);
            this.txttotalamountsales.Name = "txttotalamountsales";
            this.txttotalamountsales.Size = new System.Drawing.Size(141, 20);
            this.txttotalamountsales.TabIndex = 6;
            // 
            // lbltotalamountsales
            // 
            this.lbltotalamountsales.AutoSize = true;
            this.lbltotalamountsales.Location = new System.Drawing.Point(394, 16);
            this.lbltotalamountsales.Name = "lbltotalamountsales";
            this.lbltotalamountsales.Size = new System.Drawing.Size(72, 13);
            this.lbltotalamountsales.TabIndex = 6;
            this.lbltotalamountsales.Text = "Total amount:";
            // 
            // sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 396);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewsaleslist);
            this.Controls.Add(this.panel1);
            this.Name = "sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sales";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsaleslist)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnprintsaleslist;
        private System.Windows.Forms.DataGridView dataGridViewsaleslist;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnsalesbilling;
        private System.Windows.Forms.Button btnsearchlist;
        private System.Windows.Forms.ComboBox ddlsearchcategory;
        private System.Windows.Forms.TextBox txtsearchlist;
        private System.Windows.Forms.Label lblsearchsaleslist;
        private System.Windows.Forms.TextBox txttotalamountsales;
        private System.Windows.Forms.Label lbltotalamountsales;
    }
}
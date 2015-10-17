namespace Furniture_project
{
    partial class adminmaster
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyWorkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thekkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.purchasesToolStripMenuItem,
            this.partyToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.diaryToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(689, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.stockToolStripMenuItem.Text = "Stock";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.salesToolStripMenuItem.Text = "Sales";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // purchasesToolStripMenuItem
            // 
            this.purchasesToolStripMenuItem.Name = "purchasesToolStripMenuItem";
            this.purchasesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.purchasesToolStripMenuItem.Text = "Purchase";
            this.purchasesToolStripMenuItem.Click += new System.EventHandler(this.purchasesToolStripMenuItem_Click);
            // 
            // partyToolStripMenuItem
            // 
            this.partyToolStripMenuItem.Name = "partyToolStripMenuItem";
            this.partyToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.partyToolStripMenuItem.Text = "Party";
            this.partyToolStripMenuItem.Click += new System.EventHandler(this.partyToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monthlyWorkerToolStripMenuItem,
            this.thekkaToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // diaryToolStripMenuItem
            // 
            this.diaryToolStripMenuItem.Name = "diaryToolStripMenuItem";
            this.diaryToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.diaryToolStripMenuItem.Text = "Diary";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // monthlyWorkerToolStripMenuItem
            // 
            this.monthlyWorkerToolStripMenuItem.Name = "monthlyWorkerToolStripMenuItem";
            this.monthlyWorkerToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.monthlyWorkerToolStripMenuItem.Text = "Monthly worker";
            this.monthlyWorkerToolStripMenuItem.Click += new System.EventHandler(this.monthlyWorkerToolStripMenuItem_Click);
            // 
            // thekkaToolStripMenuItem
            // 
            this.thekkaToolStripMenuItem.Name = "thekkaToolStripMenuItem";
            this.thekkaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.thekkaToolStripMenuItem.Text = " Thekka worker";
            this.thekkaToolStripMenuItem.Click += new System.EventHandler(this.thekkaToolStripMenuItem_Click);
            // 
            // adminmaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(689, 430);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "adminmaster";
            this.Text = "adminmaster";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyWorkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thekkaToolStripMenuItem;
    }
}
namespace SimpleCallLogger
{
    partial class MainForm
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
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callLogReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byStaffToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.byDateRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byDurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.staffToolStripMenuItem,
            this.logCallToolStripMenuItem,
            this.callLogReportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(323, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCustomerToolStripMenuItem,
            this.updateCustomerToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // addNewCustomerToolStripMenuItem
            // 
            this.addNewCustomerToolStripMenuItem.Name = "addNewCustomerToolStripMenuItem";
            this.addNewCustomerToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.addNewCustomerToolStripMenuItem.Text = "Add New Customer";
            this.addNewCustomerToolStripMenuItem.Click += new System.EventHandler(this.addNewCustomerToolStripMenuItem_Click);
            // 
            // updateCustomerToolStripMenuItem
            // 
            this.updateCustomerToolStripMenuItem.Name = "updateCustomerToolStripMenuItem";
            this.updateCustomerToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.updateCustomerToolStripMenuItem.Text = "Update Customer";
            this.updateCustomerToolStripMenuItem.Click += new System.EventHandler(this.updateCustomerToolStripMenuItem_Click);
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStaffToolStripMenuItem,
            this.updateStaffToolStripMenuItem});
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.staffToolStripMenuItem.Text = "Staff";
            this.staffToolStripMenuItem.Click += new System.EventHandler(this.staffToolStripMenuItem_Click);
            // 
            // addNewStaffToolStripMenuItem
            // 
            this.addNewStaffToolStripMenuItem.Name = "addNewStaffToolStripMenuItem";
            this.addNewStaffToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.addNewStaffToolStripMenuItem.Text = "Add New Staff";
            this.addNewStaffToolStripMenuItem.Click += new System.EventHandler(this.addNewStaffToolStripMenuItem_Click);
            // 
            // updateStaffToolStripMenuItem
            // 
            this.updateStaffToolStripMenuItem.Name = "updateStaffToolStripMenuItem";
            this.updateStaffToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.updateStaffToolStripMenuItem.Text = "Update Staff";
            this.updateStaffToolStripMenuItem.Click += new System.EventHandler(this.updateStaffToolStripMenuItem_Click);
            // 
            // logCallToolStripMenuItem
            // 
            this.logCallToolStripMenuItem.Name = "logCallToolStripMenuItem";
            this.logCallToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.logCallToolStripMenuItem.Text = "Log Call";
            this.logCallToolStripMenuItem.Click += new System.EventHandler(this.logCallToolStripMenuItem_Click);
            // 
            // callLogReportsToolStripMenuItem
            // 
            this.callLogReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byStaffToolStripMenuItem,
            this.byStaffToolStripMenuItem1,
            this.byDateRangeToolStripMenuItem,
            this.byDurationToolStripMenuItem});
            this.callLogReportsToolStripMenuItem.Name = "callLogReportsToolStripMenuItem";
            this.callLogReportsToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.callLogReportsToolStripMenuItem.Text = "Call Log Reports";
            // 
            // byStaffToolStripMenuItem
            // 
            this.byStaffToolStripMenuItem.Name = "byStaffToolStripMenuItem";
            this.byStaffToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.byStaffToolStripMenuItem.Text = "By Customer";
            this.byStaffToolStripMenuItem.Click += new System.EventHandler(this.byStaffToolStripMenuItem_Click);
            // 
            // byStaffToolStripMenuItem1
            // 
            this.byStaffToolStripMenuItem1.Name = "byStaffToolStripMenuItem1";
            this.byStaffToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.byStaffToolStripMenuItem1.Text = "By Staff";
            this.byStaffToolStripMenuItem1.Click += new System.EventHandler(this.byStaffToolStripMenuItem1_Click);
            // 
            // byDateRangeToolStripMenuItem
            // 
            this.byDateRangeToolStripMenuItem.Name = "byDateRangeToolStripMenuItem";
            this.byDateRangeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.byDateRangeToolStripMenuItem.Text = "By Date Range";
            this.byDateRangeToolStripMenuItem.Click += new System.EventHandler(this.byDateRangeToolStripMenuItem_Click);
            // 
            // byDurationToolStripMenuItem
            // 
            this.byDurationToolStripMenuItem.Name = "byDurationToolStripMenuItem";
            this.byDurationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.byDurationToolStripMenuItem.Text = "By Duration";
            this.byDurationToolStripMenuItem.Click += new System.EventHandler(this.byDurationToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Simple Call Logger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logCallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem callLogReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byStaffToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem byDateRangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byDurationToolStripMenuItem;
    }
}


namespace SimpleCallLogger
{
    partial class ReportByDuration
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rdbThirtySeconds = new System.Windows.Forms.RadioButton();
            this.rdbOneHour = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbAll = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(265, 51);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(105, 23);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate Report";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 138);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(426, 209);
            this.crystalReportViewer1.TabIndex = 3;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // rdbThirtySeconds
            // 
            this.rdbThirtySeconds.AutoSize = true;
            this.rdbThirtySeconds.Location = new System.Drawing.Point(27, 42);
            this.rdbThirtySeconds.Name = "rdbThirtySeconds";
            this.rdbThirtySeconds.Size = new System.Drawing.Size(125, 17);
            this.rdbThirtySeconds.TabIndex = 1;
            this.rdbThirtySeconds.TabStop = true;
            this.rdbThirtySeconds.Text = "less than 30 seconds";
            this.rdbThirtySeconds.UseVisualStyleBackColor = true;
            // 
            // rdbOneHour
            // 
            this.rdbOneHour.AutoSize = true;
            this.rdbOneHour.Location = new System.Drawing.Point(27, 19);
            this.rdbOneHour.Name = "rdbOneHour";
            this.rdbOneHour.Size = new System.Drawing.Size(105, 17);
            this.rdbOneHour.TabIndex = 0;
            this.rdbOneHour.TabStop = true;
            this.rdbOneHour.Text = "more than 1 hour";
            this.rdbOneHour.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbAll);
            this.groupBox1.Controls.Add(this.rdbThirtySeconds);
            this.groupBox1.Controls.Add(this.rdbOneHour);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 91);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Duration";
            // 
            // rdbAll
            // 
            this.rdbAll.AutoSize = true;
            this.rdbAll.Location = new System.Drawing.Point(27, 65);
            this.rdbAll.Name = "rdbAll";
            this.rdbAll.Size = new System.Drawing.Size(76, 17);
            this.rdbAll.TabIndex = 2;
            this.rdbAll.TabStop = true;
            this.rdbAll.Text = "all duration";
            this.rdbAll.UseVisualStyleBackColor = true;
            // 
            // ReportByDuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 359);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btnGenerate);
            this.Name = "ReportByDuration";
            this.Text = "ReportByDuration";
            this.Load += new System.EventHandler(this.ReportByDuration_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.RadioButton rdbThirtySeconds;
        private System.Windows.Forms.RadioButton rdbOneHour;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbAll;
    }
}
namespace Lingo_Application
{
    partial class ReportForm
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.admReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterDateAdmissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unPaidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feeTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feeGroupDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feeGroupTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salarySlipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(946, 515);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.admReportToolStripMenuItem,
            this.feeReportToolStripMenuItem,
            this.salaryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(474, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(308, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // admReportToolStripMenuItem
            // 
            this.admReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterDateAdmissionToolStripMenuItem,
            this.filterDepartmentToolStripMenuItem});
            this.admReportToolStripMenuItem.Name = "admReportToolStripMenuItem";
            this.admReportToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.admReportToolStripMenuItem.Text = "Adm Report";
            // 
            // filterDateAdmissionToolStripMenuItem
            // 
            this.filterDateAdmissionToolStripMenuItem.Name = "filterDateAdmissionToolStripMenuItem";
            this.filterDateAdmissionToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.filterDateAdmissionToolStripMenuItem.Text = "Start Date End Date Teacher Filter";
            this.filterDateAdmissionToolStripMenuItem.Click += new System.EventHandler(this.filterDateAdmissionToolStripMenuItem_Click);
            // 
            // filterDepartmentToolStripMenuItem
            // 
            this.filterDepartmentToolStripMenuItem.Name = "filterDepartmentToolStripMenuItem";
            this.filterDepartmentToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.filterDepartmentToolStripMenuItem.Text = "Teacher Group Filter";
            this.filterDepartmentToolStripMenuItem.Click += new System.EventHandler(this.filterDepartmentToolStripMenuItem_Click);
            // 
            // feeReportToolStripMenuItem
            // 
            this.feeReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paidToolStripMenuItem,
            this.unPaidToolStripMenuItem,
            this.feeTeacherToolStripMenuItem,
            this.feeGroupDepartmentToolStripMenuItem,
            this.feeGroupTeacherToolStripMenuItem});
            this.feeReportToolStripMenuItem.Name = "feeReportToolStripMenuItem";
            this.feeReportToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.feeReportToolStripMenuItem.Text = "Fee Report";
            // 
            // paidToolStripMenuItem
            // 
            this.paidToolStripMenuItem.Name = "paidToolStripMenuItem";
            this.paidToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.paidToolStripMenuItem.Text = "Start End Date Filter";
            this.paidToolStripMenuItem.Click += new System.EventHandler(this.paidToolStripMenuItem_Click);
            // 
            // unPaidToolStripMenuItem
            // 
            this.unPaidToolStripMenuItem.Name = "unPaidToolStripMenuItem";
            this.unPaidToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.unPaidToolStripMenuItem.Text = "Month Depart Teacher Timing Filter";
            this.unPaidToolStripMenuItem.Click += new System.EventHandler(this.unPaidToolStripMenuItem_Click);
            // 
            // feeTeacherToolStripMenuItem
            // 
            this.feeTeacherToolStripMenuItem.Name = "feeTeacherToolStripMenuItem";
            this.feeTeacherToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.feeTeacherToolStripMenuItem.Text = "Student Status Filter";
            this.feeTeacherToolStripMenuItem.Click += new System.EventHandler(this.feeTeacherToolStripMenuItem_Click);
            // 
            // feeGroupDepartmentToolStripMenuItem
            // 
            this.feeGroupDepartmentToolStripMenuItem.Name = "feeGroupDepartmentToolStripMenuItem";
            this.feeGroupDepartmentToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.feeGroupDepartmentToolStripMenuItem.Text = "T. Fee Department Filter";
            this.feeGroupDepartmentToolStripMenuItem.Click += new System.EventHandler(this.feeGroupDepartmentToolStripMenuItem_Click);
            // 
            // feeGroupTeacherToolStripMenuItem
            // 
            this.feeGroupTeacherToolStripMenuItem.Name = "feeGroupTeacherToolStripMenuItem";
            this.feeGroupTeacherToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.feeGroupTeacherToolStripMenuItem.Text = "T. Fee Teacher Filter";
            this.feeGroupTeacherToolStripMenuItem.Click += new System.EventHandler(this.feeGroupTeacherToolStripMenuItem_Click);
            // 
            // salaryToolStripMenuItem
            // 
            this.salaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salarySlipToolStripMenuItem});
            this.salaryToolStripMenuItem.Name = "salaryToolStripMenuItem";
            this.salaryToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.salaryToolStripMenuItem.Text = "Salary";
            // 
            // salarySlipToolStripMenuItem
            // 
            this.salarySlipToolStripMenuItem.Name = "salarySlipToolStripMenuItem";
            this.salarySlipToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salarySlipToolStripMenuItem.Text = "Salary Slip";
            this.salarySlipToolStripMenuItem.Click += new System.EventHandler(this.salarySlipToolStripMenuItem_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 515);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.crystalReportViewer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem admReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterDateAdmissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterDepartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feeReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unPaidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feeTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feeGroupDepartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feeGroupTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salarySlipToolStripMenuItem;
    }
}
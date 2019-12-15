namespace Lingo_Application
{
    partial class DailyExpenseReportForm
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
            this.label16 = new System.Windows.Forms.Label();
            this.ExpTodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.ExpFromdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ReportViewbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(175, 65);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(989, 520);
            this.crystalReportViewer1.TabIndex = 12;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(279, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 17);
            this.label16.TabIndex = 45;
            this.label16.Text = "To:";
            // 
            // ExpTodateTimePicker
            // 
            this.ExpTodateTimePicker.CustomFormat = " ";
            this.ExpTodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ExpTodateTimePicker.Location = new System.Drawing.Point(282, 35);
            this.ExpTodateTimePicker.Name = "ExpTodateTimePicker";
            this.ExpTodateTimePicker.Size = new System.Drawing.Size(100, 24);
            this.ExpTodateTimePicker.TabIndex = 43;
            this.ExpTodateTimePicker.ValueChanged += new System.EventHandler(this.ExpTodateTimePicker_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(173, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 17);
            this.label15.TabIndex = 44;
            this.label15.Text = "From:";
            // 
            // ExpFromdateTimePicker
            // 
            this.ExpFromdateTimePicker.CustomFormat = " ";
            this.ExpFromdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ExpFromdateTimePicker.Location = new System.Drawing.Point(176, 35);
            this.ExpFromdateTimePicker.Name = "ExpFromdateTimePicker";
            this.ExpFromdateTimePicker.Size = new System.Drawing.Size(100, 24);
            this.ExpFromdateTimePicker.TabIndex = 42;
            this.ExpFromdateTimePicker.ValueChanged += new System.EventHandler(this.ExpFromdateTimePicker_ValueChanged);
            // 
            // ReportViewbutton
            // 
            this.ReportViewbutton.Location = new System.Drawing.Point(388, 35);
            this.ReportViewbutton.Name = "ReportViewbutton";
            this.ReportViewbutton.Size = new System.Drawing.Size(100, 23);
            this.ReportViewbutton.TabIndex = 46;
            this.ReportViewbutton.Text = "Report View";
            this.ReportViewbutton.UseVisualStyleBackColor = true;
            this.ReportViewbutton.Click += new System.EventHandler(this.ReportViewbutton_Click);
            // 
            // DailyExpenseReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 607);
            this.Controls.Add(this.ReportViewbutton);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ExpTodateTimePicker);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ExpFromdateTimePicker);
            this.Controls.Add(this.crystalReportViewer1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.Name = "DailyExpenseReportForm";
            this.Text = "DailyExpenseReportForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Controls.SetChildIndex(this.crystalReportViewer1, 0);
            this.Controls.SetChildIndex(this.ExpFromdateTimePicker, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.ExpTodateTimePicker, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.ReportViewbutton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker ExpTodateTimePicker;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker ExpFromdateTimePicker;
        private System.Windows.Forms.Button ReportViewbutton;
    }
}
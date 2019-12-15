namespace Lingo_Application
{
    partial class UnpaidStudentForm
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
            this.PaidUnpaidcomboBox = new System.Windows.Forms.ComboBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PaidUnpaidSearchingtextBox = new System.Windows.Forms.TextBox();
            this.Searchingbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PaidUnpaidcomboBox
            // 
            this.PaidUnpaidcomboBox.FormattingEnabled = true;
            this.PaidUnpaidcomboBox.Items.AddRange(new object[] {
            "Paid",
            "Unpaid"});
            this.PaidUnpaidcomboBox.Location = new System.Drawing.Point(183, 49);
            this.PaidUnpaidcomboBox.Name = "PaidUnpaidcomboBox";
            this.PaidUnpaidcomboBox.Size = new System.Drawing.Size(121, 25);
            this.PaidUnpaidcomboBox.TabIndex = 9;
            this.PaidUnpaidcomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(183, 90);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(989, 500);
            this.crystalReportViewer1.TabIndex = 11;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Paid/Unpaid:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Search:";
            // 
            // PaidUnpaidSearchingtextBox
            // 
            this.PaidUnpaidSearchingtextBox.Location = new System.Drawing.Point(321, 50);
            this.PaidUnpaidSearchingtextBox.Name = "PaidUnpaidSearchingtextBox";
            this.PaidUnpaidSearchingtextBox.Size = new System.Drawing.Size(200, 24);
            this.PaidUnpaidSearchingtextBox.TabIndex = 19;
            // 
            // Searchingbutton
            // 
            this.Searchingbutton.Location = new System.Drawing.Point(527, 50);
            this.Searchingbutton.Name = "Searchingbutton";
            this.Searchingbutton.Size = new System.Drawing.Size(75, 23);
            this.Searchingbutton.TabIndex = 21;
            this.Searchingbutton.Text = "Search";
            this.Searchingbutton.UseVisualStyleBackColor = true;
            this.Searchingbutton.Click += new System.EventHandler(this.Searchingbutton_Click);
            // 
            // UnpaidStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 600);
            this.Controls.Add(this.Searchingbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PaidUnpaidSearchingtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.PaidUnpaidcomboBox);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.Name = "UnpaidStudentForm";
            this.Text = "UnpaidStudentForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.UnpaidStudentForm_Load);
            this.Controls.SetChildIndex(this.PaidUnpaidcomboBox, 0);
            this.Controls.SetChildIndex(this.crystalReportViewer1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.PaidUnpaidSearchingtextBox, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.Searchingbutton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox PaidUnpaidcomboBox;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PaidUnpaidSearchingtextBox;
        private System.Windows.Forms.Button Searchingbutton;
    }
}
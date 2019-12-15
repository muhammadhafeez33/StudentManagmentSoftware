namespace Lingo_Application
{
    partial class PaidUnpaidView
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
            this.label1 = new System.Windows.Forms.Label();
            this.PaidUnpaidcomboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ropertbutton = new System.Windows.Forms.Button();
            this.PaidUnpaidSearchingtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Searchingbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Paid/Unpaid:";
            // 
            // PaidUnpaidcomboBox
            // 
            this.PaidUnpaidcomboBox.FormattingEnabled = true;
            this.PaidUnpaidcomboBox.Items.AddRange(new object[] {
            "Paid",
            "Unpaid"});
            this.PaidUnpaidcomboBox.Location = new System.Drawing.Point(179, 52);
            this.PaidUnpaidcomboBox.Name = "PaidUnpaidcomboBox";
            this.PaidUnpaidcomboBox.Size = new System.Drawing.Size(121, 25);
            this.PaidUnpaidcomboBox.TabIndex = 13;
            this.PaidUnpaidcomboBox.SelectedIndexChanged += new System.EventHandler(this.PaidUnpaidcomboBox_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(179, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1030, 500);
            this.dataGridView1.TabIndex = 15;
            // 
            // Ropertbutton
            // 
            this.Ropertbutton.Location = new System.Drawing.Point(605, 52);
            this.Ropertbutton.Name = "Ropertbutton";
            this.Ropertbutton.Size = new System.Drawing.Size(75, 23);
            this.Ropertbutton.TabIndex = 16;
            this.Ropertbutton.Text = "Report";
            this.Ropertbutton.UseVisualStyleBackColor = true;
            this.Ropertbutton.Click += new System.EventHandler(this.Ropertbutton_Click);
            // 
            // PaidUnpaidSearchingtextBox
            // 
            this.PaidUnpaidSearchingtextBox.Location = new System.Drawing.Point(318, 52);
            this.PaidUnpaidSearchingtextBox.Name = "PaidUnpaidSearchingtextBox";
            this.PaidUnpaidSearchingtextBox.Size = new System.Drawing.Size(200, 24);
            this.PaidUnpaidSearchingtextBox.TabIndex = 17;
            this.PaidUnpaidSearchingtextBox.TextChanged += new System.EventHandler(this.PaidUnpaidSearchingtextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Searching:";
            // 
            // Searchingbutton
            // 
            this.Searchingbutton.Location = new System.Drawing.Point(524, 52);
            this.Searchingbutton.Name = "Searchingbutton";
            this.Searchingbutton.Size = new System.Drawing.Size(75, 23);
            this.Searchingbutton.TabIndex = 22;
            this.Searchingbutton.Text = "Search";
            this.Searchingbutton.UseVisualStyleBackColor = true;
            this.Searchingbutton.Click += new System.EventHandler(this.Searchingbutton_Click);
            // 
            // PaidUnpaidView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 639);
            this.Controls.Add(this.Searchingbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PaidUnpaidSearchingtextBox);
            this.Controls.Add(this.Ropertbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PaidUnpaidcomboBox);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.Name = "PaidUnpaidView";
            this.Text = "PaidUnpaidReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.PaidUnpaidView_Load);
            this.Controls.SetChildIndex(this.PaidUnpaidcomboBox, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.Ropertbutton, 0);
            this.Controls.SetChildIndex(this.PaidUnpaidSearchingtextBox, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.Searchingbutton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PaidUnpaidcomboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Ropertbutton;
        private System.Windows.Forms.TextBox PaidUnpaidSearchingtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Searchingbutton;
    }
}
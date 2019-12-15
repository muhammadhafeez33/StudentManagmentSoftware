namespace Lingo_Application
{
    partial class FilterRecordForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.StudentStatuscomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DepartmentcomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProgramcomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TeachercomboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TimingcomboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button7 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.AdmAmountlabel = new System.Windows.Forms.Label();
            this.MonthlyAmountlabel = new System.Windows.Forms.Label();
            this.BalanceAmountlabel = new System.Windows.Forms.Label();
            this.TotalFeeAmountlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(185, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1070, 400);
            this.dataGridView1.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adm Or Fee Collect:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Student Admission",
            "Fee Collection"});
            this.comboBox1.Location = new System.Drawing.Point(185, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 25);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // StudentStatuscomboBox
            // 
            this.StudentStatuscomboBox.FormattingEnabled = true;
            this.StudentStatuscomboBox.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Completed"});
            this.StudentStatuscomboBox.Location = new System.Drawing.Point(185, 92);
            this.StudentStatuscomboBox.Name = "StudentStatuscomboBox";
            this.StudentStatuscomboBox.Size = new System.Drawing.Size(150, 25);
            this.StudentStatuscomboBox.TabIndex = 2;
            this.StudentStatuscomboBox.SelectedIndexChanged += new System.EventHandler(this.StudentStatuscomboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Student Status:";
            // 
            // DepartmentcomboBox
            // 
            this.DepartmentcomboBox.FormattingEnabled = true;
            this.DepartmentcomboBox.Location = new System.Drawing.Point(344, 92);
            this.DepartmentcomboBox.Name = "DepartmentcomboBox";
            this.DepartmentcomboBox.Size = new System.Drawing.Size(150, 25);
            this.DepartmentcomboBox.TabIndex = 3;
            this.DepartmentcomboBox.SelectedIndexChanged += new System.EventHandler(this.DepartmentcomboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Department:";
            // 
            // ProgramcomboBox
            // 
            this.ProgramcomboBox.FormattingEnabled = true;
            this.ProgramcomboBox.Location = new System.Drawing.Point(500, 92);
            this.ProgramcomboBox.Name = "ProgramcomboBox";
            this.ProgramcomboBox.Size = new System.Drawing.Size(150, 25);
            this.ProgramcomboBox.TabIndex = 4;
            this.ProgramcomboBox.SelectedIndexChanged += new System.EventHandler(this.ProgramcomboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(497, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Program:";
            // 
            // TeachercomboBox
            // 
            this.TeachercomboBox.FormattingEnabled = true;
            this.TeachercomboBox.Location = new System.Drawing.Point(656, 92);
            this.TeachercomboBox.Name = "TeachercomboBox";
            this.TeachercomboBox.Size = new System.Drawing.Size(150, 25);
            this.TeachercomboBox.TabIndex = 5;
            this.TeachercomboBox.SelectedIndexChanged += new System.EventHandler(this.TeachercomboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(653, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Teacher:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(809, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Timing:";
            // 
            // TimingcomboBox
            // 
            this.TimingcomboBox.FormattingEnabled = true;
            this.TimingcomboBox.Location = new System.Drawing.Point(812, 92);
            this.TimingcomboBox.Name = "TimingcomboBox";
            this.TimingcomboBox.Size = new System.Drawing.Size(150, 25);
            this.TimingcomboBox.TabIndex = 6;
            this.TimingcomboBox.SelectedIndexChanged += new System.EventHandler(this.TimingcomboBox_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(185, 140);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 24);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Start Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "End Date:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(291, 140);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(100, 24);
            this.dateTimePicker2.TabIndex = 16;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(397, 140);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 41;
            this.button7.Text = "Excel";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(182, 597);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "Admission Amount:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(182, 620);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 17);
            this.label10.TabIndex = 43;
            this.label10.Text = "Monthly Fee Amount:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(497, 597);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 17);
            this.label11.TabIndex = 44;
            this.label11.Text = "Total Fee Amount:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(497, 620);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 17);
            this.label12.TabIndex = 45;
            this.label12.Text = "Balance Amount:";
            // 
            // AdmAmountlabel
            // 
            this.AdmAmountlabel.AutoSize = true;
            this.AdmAmountlabel.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdmAmountlabel.Location = new System.Drawing.Point(319, 597);
            this.AdmAmountlabel.Name = "AdmAmountlabel";
            this.AdmAmountlabel.Size = new System.Drawing.Size(40, 17);
            this.AdmAmountlabel.TabIndex = 46;
            this.AdmAmountlabel.Text = "0000";
            // 
            // MonthlyAmountlabel
            // 
            this.MonthlyAmountlabel.AutoSize = true;
            this.MonthlyAmountlabel.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthlyAmountlabel.Location = new System.Drawing.Point(319, 620);
            this.MonthlyAmountlabel.Name = "MonthlyAmountlabel";
            this.MonthlyAmountlabel.Size = new System.Drawing.Size(40, 17);
            this.MonthlyAmountlabel.TabIndex = 47;
            this.MonthlyAmountlabel.Text = "0000";
            // 
            // BalanceAmountlabel
            // 
            this.BalanceAmountlabel.AutoSize = true;
            this.BalanceAmountlabel.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceAmountlabel.Location = new System.Drawing.Point(614, 620);
            this.BalanceAmountlabel.Name = "BalanceAmountlabel";
            this.BalanceAmountlabel.Size = new System.Drawing.Size(40, 17);
            this.BalanceAmountlabel.TabIndex = 49;
            this.BalanceAmountlabel.Text = "0000";
            // 
            // TotalFeeAmountlabel
            // 
            this.TotalFeeAmountlabel.AutoSize = true;
            this.TotalFeeAmountlabel.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalFeeAmountlabel.Location = new System.Drawing.Point(614, 596);
            this.TotalFeeAmountlabel.Name = "TotalFeeAmountlabel";
            this.TotalFeeAmountlabel.Size = new System.Drawing.Size(40, 17);
            this.TotalFeeAmountlabel.TabIndex = 48;
            this.TotalFeeAmountlabel.Text = "0000";
            // 
            // FilterRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 646);
            this.Controls.Add(this.BalanceAmountlabel);
            this.Controls.Add(this.TotalFeeAmountlabel);
            this.Controls.Add(this.MonthlyAmountlabel);
            this.Controls.Add(this.AdmAmountlabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TimingcomboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TeachercomboBox);
            this.Controls.Add(this.ProgramcomboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DepartmentcomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StudentStatuscomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.Name = "FilterRecordForm";
            this.Text = "FilterRecordForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.FilterRecordForm_Load);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.StudentStatuscomboBox, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.DepartmentcomboBox, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.ProgramcomboBox, 0);
            this.Controls.SetChildIndex(this.TeachercomboBox, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.TimingcomboBox, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.dateTimePicker2, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.button7, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.AdmAmountlabel, 0);
            this.Controls.SetChildIndex(this.MonthlyAmountlabel, 0);
            this.Controls.SetChildIndex(this.TotalFeeAmountlabel, 0);
            this.Controls.SetChildIndex(this.BalanceAmountlabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox StudentStatuscomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DepartmentcomboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ProgramcomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TeachercomboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox TimingcomboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label AdmAmountlabel;
        private System.Windows.Forms.Label MonthlyAmountlabel;
        private System.Windows.Forms.Label BalanceAmountlabel;
        private System.Windows.Forms.Label TotalFeeAmountlabel;
    }
}
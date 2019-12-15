namespace Lingo_Application
{
    partial class EmployeeRegistForm
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
            this.EmpIdtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SalEmpNametextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EmpAdvanceSalarytextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.EmpPreviousSalarytextBox = new System.Windows.Forms.TextBox();
            this.EmpPerctextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.EmpRevenuetextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.EmpNetSalarytextBox = new System.Windows.Forms.TextBox();
            this.EmplSalaryMonthcomboBox = new System.Windows.Forms.ComboBox();
            this.EmpSalaryYearcomboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.EmpSalaryDatedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EmpWorkingDaystextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.EmpLeavetextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.EmpDeductionSalarytextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.EmpPerDaySalarytextBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.AllowancetextBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.OtherDeductiontextBox = new System.Windows.Forms.TextBox();
            this.EmplSavebutton = new System.Windows.Forms.Button();
            this.EmpDeletebutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.Excelbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalSalarylabel = new System.Windows.Forms.Label();
            this.EnddateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.StartdateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpIdtextBox
            // 
            this.EmpIdtextBox.Location = new System.Drawing.Point(181, 62);
            this.EmpIdtextBox.Name = "EmpIdtextBox";
            this.EmpIdtextBox.Size = new System.Drawing.Size(100, 24);
            this.EmpIdtextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employ Id:";
            // 
            // SalEmpNametextBox
            // 
            this.SalEmpNametextBox.Location = new System.Drawing.Point(287, 62);
            this.SalEmpNametextBox.Name = "SalEmpNametextBox";
            this.SalEmpNametextBox.Size = new System.Drawing.Size(200, 24);
            this.SalEmpNametextBox.TabIndex = 2;
            this.SalEmpNametextBox.TextChanged += new System.EventHandler(this.EmpNametextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Employ Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 50;
            this.label7.Text = "Advance Salary:";
            // 
            // EmpAdvanceSalarytextBox
            // 
            this.EmpAdvanceSalarytextBox.Location = new System.Drawing.Point(181, 179);
            this.EmpAdvanceSalarytextBox.Name = "EmpAdvanceSalarytextBox";
            this.EmpAdvanceSalarytextBox.Size = new System.Drawing.Size(100, 24);
            this.EmpAdvanceSalarytextBox.TabIndex = 16;
            this.EmpAdvanceSalarytextBox.Text = "0";
            this.EmpAdvanceSalarytextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmpAdvanceSalarytextBox.TextChanged += new System.EventHandler(this.EmpAdvanceSalarytextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(440, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 50;
            this.label8.Text = "Empl Salary:";
            // 
            // EmpPreviousSalarytextBox
            // 
            this.EmpPreviousSalarytextBox.Location = new System.Drawing.Point(443, 119);
            this.EmpPreviousSalarytextBox.Name = "EmpPreviousSalarytextBox";
            this.EmpPreviousSalarytextBox.Size = new System.Drawing.Size(100, 24);
            this.EmpPreviousSalarytextBox.TabIndex = 11;
            this.EmpPreviousSalarytextBox.Text = "0";
            this.EmpPreviousSalarytextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmpPreviousSalarytextBox.TextChanged += new System.EventHandler(this.EmpPreviousSalarytextBox_TextChanged);
            // 
            // EmpPerctextBox
            // 
            this.EmpPerctextBox.Location = new System.Drawing.Point(337, 119);
            this.EmpPerctextBox.Name = "EmpPerctextBox";
            this.EmpPerctextBox.Size = new System.Drawing.Size(100, 24);
            this.EmpPerctextBox.TabIndex = 10;
            this.EmpPerctextBox.Text = "0";
            this.EmpPerctextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmpPerctextBox.TextChanged += new System.EventHandler(this.EmpPerctextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(334, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 50;
            this.label9.Text = "Perc %:";
            // 
            // EmpRevenuetextBox
            // 
            this.EmpRevenuetextBox.Location = new System.Drawing.Point(181, 119);
            this.EmpRevenuetextBox.Name = "EmpRevenuetextBox";
            this.EmpRevenuetextBox.Size = new System.Drawing.Size(150, 24);
            this.EmpRevenuetextBox.TabIndex = 9;
            this.EmpRevenuetextBox.Text = "0";
            this.EmpRevenuetextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmpRevenuetextBox.TextChanged += new System.EventHandler(this.EmpRevenuetextBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(178, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 17);
            this.label10.TabIndex = 50;
            this.label10.Text = "Employe Revenue:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(496, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Net Salary:";
            // 
            // EmpNetSalarytextBox
            // 
            this.EmpNetSalarytextBox.Location = new System.Drawing.Point(499, 179);
            this.EmpNetSalarytextBox.Name = "EmpNetSalarytextBox";
            this.EmpNetSalarytextBox.Size = new System.Drawing.Size(100, 24);
            this.EmpNetSalarytextBox.TabIndex = 19;
            this.EmpNetSalarytextBox.Text = "0";
            this.EmpNetSalarytextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EmplSalaryMonthcomboBox
            // 
            this.EmplSalaryMonthcomboBox.FormattingEnabled = true;
            this.EmplSalaryMonthcomboBox.Location = new System.Drawing.Point(496, 61);
            this.EmplSalaryMonthcomboBox.Name = "EmplSalaryMonthcomboBox";
            this.EmplSalaryMonthcomboBox.Size = new System.Drawing.Size(121, 25);
            this.EmplSalaryMonthcomboBox.TabIndex = 7;
            this.EmplSalaryMonthcomboBox.SelectedIndexChanged += new System.EventHandler(this.EmplSalaryMonthcomboBox_SelectedIndexChanged);
            // 
            // EmpSalaryYearcomboBox
            // 
            this.EmpSalaryYearcomboBox.FormattingEnabled = true;
            this.EmpSalaryYearcomboBox.Location = new System.Drawing.Point(623, 61);
            this.EmpSalaryYearcomboBox.Name = "EmpSalaryYearcomboBox";
            this.EmpSalaryYearcomboBox.Size = new System.Drawing.Size(121, 25);
            this.EmpSalaryYearcomboBox.TabIndex = 8;
            this.EmpSalaryYearcomboBox.SelectedIndexChanged += new System.EventHandler(this.EmpSalaryYearcomboBox_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(620, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 17);
            this.label13.TabIndex = 28;
            this.label13.Text = "Salary Year:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(493, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 17);
            this.label14.TabIndex = 29;
            this.label14.Text = "Salary Month:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(602, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 17);
            this.label12.TabIndex = 31;
            this.label12.Text = "Salary Date:";
            // 
            // EmpSalaryDatedateTimePicker
            // 
            this.EmpSalaryDatedateTimePicker.CustomFormat = " ";
            this.EmpSalaryDatedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EmpSalaryDatedateTimePicker.Location = new System.Drawing.Point(605, 179);
            this.EmpSalaryDatedateTimePicker.Name = "EmpSalaryDatedateTimePicker";
            this.EmpSalaryDatedateTimePicker.Size = new System.Drawing.Size(150, 24);
            this.EmpSalaryDatedateTimePicker.TabIndex = 20;
            this.EmpSalaryDatedateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(181, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1040, 380);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // EmpWorkingDaystextBox
            // 
            this.EmpWorkingDaystextBox.Location = new System.Drawing.Point(549, 119);
            this.EmpWorkingDaystextBox.Name = "EmpWorkingDaystextBox";
            this.EmpWorkingDaystextBox.Size = new System.Drawing.Size(100, 24);
            this.EmpWorkingDaystextBox.TabIndex = 12;
            this.EmpWorkingDaystextBox.Text = "0";
            this.EmpWorkingDaystextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmpWorkingDaystextBox.TextChanged += new System.EventHandler(this.EmpWorkingDaystextBox_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(546, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 17);
            this.label15.TabIndex = 34;
            this.label15.Text = "Working Days:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(758, 99);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 17);
            this.label16.TabIndex = 36;
            this.label16.Text = "Leave:";
            // 
            // EmpLeavetextBox
            // 
            this.EmpLeavetextBox.Location = new System.Drawing.Point(761, 119);
            this.EmpLeavetextBox.Name = "EmpLeavetextBox";
            this.EmpLeavetextBox.Size = new System.Drawing.Size(100, 24);
            this.EmpLeavetextBox.TabIndex = 14;
            this.EmpLeavetextBox.Text = "0";
            this.EmpLeavetextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmpLeavetextBox.TextChanged += new System.EventHandler(this.EmpLeavetextBox_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(864, 98);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(112, 17);
            this.label17.TabIndex = 38;
            this.label17.Text = "Deduction Salary:";
            // 
            // EmpDeductionSalarytextBox
            // 
            this.EmpDeductionSalarytextBox.Location = new System.Drawing.Point(867, 118);
            this.EmpDeductionSalarytextBox.Name = "EmpDeductionSalarytextBox";
            this.EmpDeductionSalarytextBox.Size = new System.Drawing.Size(100, 24);
            this.EmpDeductionSalarytextBox.TabIndex = 15;
            this.EmpDeductionSalarytextBox.Text = "0";
            this.EmpDeductionSalarytextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmpDeductionSalarytextBox.TextChanged += new System.EventHandler(this.EmpDeductionSalarytextBox_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(652, 99);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(102, 17);
            this.label18.TabIndex = 40;
            this.label18.Text = "Per Day Salary:";
            // 
            // EmpPerDaySalarytextBox
            // 
            this.EmpPerDaySalarytextBox.Location = new System.Drawing.Point(655, 119);
            this.EmpPerDaySalarytextBox.Name = "EmpPerDaySalarytextBox";
            this.EmpPerDaySalarytextBox.Size = new System.Drawing.Size(100, 24);
            this.EmpPerDaySalarytextBox.TabIndex = 13;
            this.EmpPerDaySalarytextBox.Text = "0";
            this.EmpPerDaySalarytextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmpPerDaySalarytextBox.TextChanged += new System.EventHandler(this.EmpPerDaySalarytextBox_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(390, 159);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 17);
            this.label19.TabIndex = 42;
            this.label19.Text = "Allowance:";
            // 
            // AllowancetextBox
            // 
            this.AllowancetextBox.Location = new System.Drawing.Point(393, 179);
            this.AllowancetextBox.Name = "AllowancetextBox";
            this.AllowancetextBox.Size = new System.Drawing.Size(100, 24);
            this.AllowancetextBox.TabIndex = 18;
            this.AllowancetextBox.Text = "0";
            this.AllowancetextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AllowancetextBox.TextChanged += new System.EventHandler(this.AllowancetextBox_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(283, 159);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(109, 17);
            this.label20.TabIndex = 44;
            this.label20.Text = "Other Deduction:";
            // 
            // OtherDeductiontextBox
            // 
            this.OtherDeductiontextBox.Location = new System.Drawing.Point(287, 179);
            this.OtherDeductiontextBox.Name = "OtherDeductiontextBox";
            this.OtherDeductiontextBox.Size = new System.Drawing.Size(100, 24);
            this.OtherDeductiontextBox.TabIndex = 17;
            this.OtherDeductiontextBox.Text = "0";
            this.OtherDeductiontextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OtherDeductiontextBox.TextChanged += new System.EventHandler(this.OtherDeductiontextBox_TextChanged);
            // 
            // EmplSavebutton
            // 
            this.EmplSavebutton.Location = new System.Drawing.Point(761, 179);
            this.EmplSavebutton.Name = "EmplSavebutton";
            this.EmplSavebutton.Size = new System.Drawing.Size(75, 23);
            this.EmplSavebutton.TabIndex = 21;
            this.EmplSavebutton.Text = "Save";
            this.EmplSavebutton.UseVisualStyleBackColor = true;
            this.EmplSavebutton.Click += new System.EventHandler(this.EmplSavebutton_Click);
            // 
            // EmpDeletebutton
            // 
            this.EmpDeletebutton.Location = new System.Drawing.Point(842, 179);
            this.EmpDeletebutton.Name = "EmpDeletebutton";
            this.EmpDeletebutton.Size = new System.Drawing.Size(75, 23);
            this.EmpDeletebutton.TabIndex = 22;
            this.EmpDeletebutton.Text = "Delete";
            this.EmpDeletebutton.UseVisualStyleBackColor = true;
            this.EmpDeletebutton.Click += new System.EventHandler(this.EmpDeletebutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1071, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 24);
            this.textBox1.TabIndex = 24;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1013, 122);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 17);
            this.label21.TabIndex = 49;
            this.label21.Text = "Search:";
            // 
            // Excelbutton
            // 
            this.Excelbutton.Location = new System.Drawing.Point(923, 179);
            this.Excelbutton.Name = "Excelbutton";
            this.Excelbutton.Size = new System.Drawing.Size(75, 23);
            this.Excelbutton.TabIndex = 23;
            this.Excelbutton.Text = "Excel";
            this.Excelbutton.UseVisualStyleBackColor = true;
            this.Excelbutton.Click += new System.EventHandler(this.Excelbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 617);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Total Salary:";
            // 
            // TotalSalarylabel
            // 
            this.TotalSalarylabel.AutoSize = true;
            this.TotalSalarylabel.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSalarylabel.Location = new System.Drawing.Point(254, 617);
            this.TotalSalarylabel.Name = "TotalSalarylabel";
            this.TotalSalarylabel.Size = new System.Drawing.Size(40, 17);
            this.TotalSalarylabel.TabIndex = 52;
            this.TotalSalarylabel.Text = "0000";
            // 
            // EnddateTimePicker1
            // 
            this.EnddateTimePicker1.CustomFormat = " ";
            this.EnddateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EnddateTimePicker1.Location = new System.Drawing.Point(1121, 179);
            this.EnddateTimePicker1.Name = "EnddateTimePicker1";
            this.EnddateTimePicker1.Size = new System.Drawing.Size(100, 24);
            this.EnddateTimePicker1.TabIndex = 53;
            this.EnddateTimePicker1.ValueChanged += new System.EventHandler(this.EnddateTimePicker1_ValueChanged);
            // 
            // StartdateTimePicker2
            // 
            this.StartdateTimePicker2.CustomFormat = " ";
            this.StartdateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartdateTimePicker2.Location = new System.Drawing.Point(1004, 179);
            this.StartdateTimePicker2.Name = "StartdateTimePicker2";
            this.StartdateTimePicker2.Size = new System.Drawing.Size(100, 24);
            this.StartdateTimePicker2.TabIndex = 54;
            this.StartdateTimePicker2.ValueChanged += new System.EventHandler(this.StartdateTimePicker2_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1001, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 55;
            this.label4.Text = "Start:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1118, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 56;
            this.label5.Text = "End:";
            // 
            // EmployeeRegistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 647);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StartdateTimePicker2);
            this.Controls.Add(this.EnddateTimePicker1);
            this.Controls.Add(this.TotalSalarylabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Excelbutton);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.EmpDeletebutton);
            this.Controls.Add(this.EmplSavebutton);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.OtherDeductiontextBox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.AllowancetextBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.EmpPerDaySalarytextBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.EmpDeductionSalarytextBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.EmpLeavetextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.EmpWorkingDaystextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.EmpSalaryDatedateTimePicker);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.EmpSalaryYearcomboBox);
            this.Controls.Add(this.EmplSalaryMonthcomboBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.EmpNetSalarytextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.EmpRevenuetextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.EmpPerctextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EmpAdvanceSalarytextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EmpPreviousSalarytextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SalEmpNametextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmpIdtextBox);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "EmployeeRegistForm";
            this.Text = "EmployeeRegistForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.EmployeeRegistForm_Load);
            this.Controls.SetChildIndex(this.EmpIdtextBox, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.SalEmpNametextBox, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.EmpPreviousSalarytextBox, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.EmpAdvanceSalarytextBox, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.EmpPerctextBox, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.EmpRevenuetextBox, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.EmpNetSalarytextBox, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.EmplSalaryMonthcomboBox, 0);
            this.Controls.SetChildIndex(this.EmpSalaryYearcomboBox, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.EmpSalaryDatedateTimePicker, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.EmpWorkingDaystextBox, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.EmpLeavetextBox, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.EmpDeductionSalarytextBox, 0);
            this.Controls.SetChildIndex(this.label17, 0);
            this.Controls.SetChildIndex(this.EmpPerDaySalarytextBox, 0);
            this.Controls.SetChildIndex(this.label18, 0);
            this.Controls.SetChildIndex(this.AllowancetextBox, 0);
            this.Controls.SetChildIndex(this.label19, 0);
            this.Controls.SetChildIndex(this.OtherDeductiontextBox, 0);
            this.Controls.SetChildIndex(this.label20, 0);
            this.Controls.SetChildIndex(this.EmplSavebutton, 0);
            this.Controls.SetChildIndex(this.EmpDeletebutton, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.label21, 0);
            this.Controls.SetChildIndex(this.Excelbutton, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.TotalSalarylabel, 0);
            this.Controls.SetChildIndex(this.EnddateTimePicker1, 0);
            this.Controls.SetChildIndex(this.StartdateTimePicker2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmpIdtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SalEmpNametextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox EmpAdvanceSalarytextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox EmpPreviousSalarytextBox;
        private System.Windows.Forms.TextBox EmpPerctextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox EmpRevenuetextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox EmpNetSalarytextBox;
        private System.Windows.Forms.ComboBox EmplSalaryMonthcomboBox;
        private System.Windows.Forms.ComboBox EmpSalaryYearcomboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker EmpSalaryDatedateTimePicker;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox EmpWorkingDaystextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox EmpLeavetextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox EmpDeductionSalarytextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox EmpPerDaySalarytextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox AllowancetextBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox OtherDeductiontextBox;
        private System.Windows.Forms.Button EmplSavebutton;
        private System.Windows.Forms.Button EmpDeletebutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button Excelbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TotalSalarylabel;
        private System.Windows.Forms.DateTimePicker EnddateTimePicker1;
        private System.Windows.Forms.DateTimePicker StartdateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
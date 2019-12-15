namespace Lingo_Application
{
    partial class ProftOrLossForm
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
            this.label16 = new System.Windows.Forms.Label();
            this.ExpTodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.ExpFromdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DateIncometextBox = new System.Windows.Forms.TextBox();
            this.DateExpensetextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DateBalancetextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProfitOrLosstextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.BalanceSelectYearcomboBox = new System.Windows.Forms.ComboBox();
            this.BalanceSelectMonthcomboBox = new System.Windows.Forms.ComboBox();
            this.MonthlyProfitOrlosstextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MonthlyBalancetextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MonthlyExpensetextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MonthlyIncometextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MonthlySalaryExptextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.BalanceSearchingtextBox = new System.Windows.Forms.TextBox();
            this.ProfitOrLossIdtextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DailyBookCertificatetextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.MonthlyBookOrCertitextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(289, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 17);
            this.label16.TabIndex = 45;
            this.label16.Text = "To:";
            // 
            // ExpTodateTimePicker
            // 
            this.ExpTodateTimePicker.CustomFormat = "dd-MMM-yyy";
            this.ExpTodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ExpTodateTimePicker.Location = new System.Drawing.Point(292, 45);
            this.ExpTodateTimePicker.Name = "ExpTodateTimePicker";
            this.ExpTodateTimePicker.Size = new System.Drawing.Size(100, 24);
            this.ExpTodateTimePicker.TabIndex = 2;
            this.ExpTodateTimePicker.ValueChanged += new System.EventHandler(this.ExpTodateTimePicker_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(183, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 17);
            this.label15.TabIndex = 43;
            this.label15.Text = "From:";
            // 
            // ExpFromdateTimePicker
            // 
            this.ExpFromdateTimePicker.CustomFormat = "dd-MMM-yyy";
            this.ExpFromdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ExpFromdateTimePicker.Location = new System.Drawing.Point(186, 45);
            this.ExpFromdateTimePicker.Name = "ExpFromdateTimePicker";
            this.ExpFromdateTimePicker.Size = new System.Drawing.Size(100, 24);
            this.ExpFromdateTimePicker.TabIndex = 1;
            this.ExpFromdateTimePicker.ValueChanged += new System.EventHandler(this.ExpFromdateTimePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Fee Income:";
            // 
            // DateIncometextBox
            // 
            this.DateIncometextBox.Location = new System.Drawing.Point(186, 92);
            this.DateIncometextBox.Name = "DateIncometextBox";
            this.DateIncometextBox.Size = new System.Drawing.Size(150, 24);
            this.DateIncometextBox.TabIndex = 3;
            this.DateIncometextBox.Text = "0";
            this.DateIncometextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateIncometextBox.TextChanged += new System.EventHandler(this.DateIncometextBox_TextChanged);
            // 
            // DateExpensetextBox
            // 
            this.DateExpensetextBox.Location = new System.Drawing.Point(498, 92);
            this.DateExpensetextBox.Name = "DateExpensetextBox";
            this.DateExpensetextBox.Size = new System.Drawing.Size(150, 24);
            this.DateExpensetextBox.TabIndex = 5;
            this.DateExpensetextBox.Text = "0";
            this.DateExpensetextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateExpensetextBox.TextChanged += new System.EventHandler(this.DateExpensetextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(495, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "Daily Total Exp:";
            // 
            // DateBalancetextBox
            // 
            this.DateBalancetextBox.Location = new System.Drawing.Point(654, 92);
            this.DateBalancetextBox.Name = "DateBalancetextBox";
            this.DateBalancetextBox.Size = new System.Drawing.Size(150, 24);
            this.DateBalancetextBox.TabIndex = 6;
            this.DateBalancetextBox.Text = "0";
            this.DateBalancetextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateBalancetextBox.TextChanged += new System.EventHandler(this.DateBalancetextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(651, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "Balance:";
            // 
            // ProfitOrLosstextBox
            // 
            this.ProfitOrLosstextBox.Location = new System.Drawing.Point(810, 92);
            this.ProfitOrLosstextBox.Name = "ProfitOrLosstextBox";
            this.ProfitOrLosstextBox.Size = new System.Drawing.Size(150, 24);
            this.ProfitOrLosstextBox.TabIndex = 7;
            this.ProfitOrLosstextBox.Text = "0";
            this.ProfitOrLosstextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(807, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 52;
            this.label4.Text = "Profit/Loss:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(269, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 17);
            this.label14.TabIndex = 57;
            this.label14.Text = "Select Month:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(396, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 17);
            this.label13.TabIndex = 56;
            this.label13.Text = "Select Year:";
            // 
            // BalanceSelectYearcomboBox
            // 
            this.BalanceSelectYearcomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.BalanceSelectYearcomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.BalanceSelectYearcomboBox.FormattingEnabled = true;
            this.BalanceSelectYearcomboBox.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040",
            "2041",
            "2042",
            "2043",
            "2044",
            "2045",
            "2046",
            "2047",
            "2048",
            "2049",
            "2050"});
            this.BalanceSelectYearcomboBox.Location = new System.Drawing.Point(399, 171);
            this.BalanceSelectYearcomboBox.Name = "BalanceSelectYearcomboBox";
            this.BalanceSelectYearcomboBox.Size = new System.Drawing.Size(121, 25);
            this.BalanceSelectYearcomboBox.TabIndex = 10;
            this.BalanceSelectYearcomboBox.SelectedIndexChanged += new System.EventHandler(this.BalanceSelectYearcomboBox_SelectedIndexChanged);
            // 
            // BalanceSelectMonthcomboBox
            // 
            this.BalanceSelectMonthcomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.BalanceSelectMonthcomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.BalanceSelectMonthcomboBox.FormattingEnabled = true;
            this.BalanceSelectMonthcomboBox.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.BalanceSelectMonthcomboBox.Location = new System.Drawing.Point(272, 171);
            this.BalanceSelectMonthcomboBox.Name = "BalanceSelectMonthcomboBox";
            this.BalanceSelectMonthcomboBox.Size = new System.Drawing.Size(121, 25);
            this.BalanceSelectMonthcomboBox.TabIndex = 9;
            this.BalanceSelectMonthcomboBox.SelectedIndexChanged += new System.EventHandler(this.BalanceSelectMonthcomboBox_SelectedIndexChanged);
            // 
            // MonthlyProfitOrlosstextBox
            // 
            this.MonthlyProfitOrlosstextBox.Location = new System.Drawing.Point(186, 269);
            this.MonthlyProfitOrlosstextBox.Name = "MonthlyProfitOrlosstextBox";
            this.MonthlyProfitOrlosstextBox.Size = new System.Drawing.Size(150, 24);
            this.MonthlyProfitOrlosstextBox.TabIndex = 16;
            this.MonthlyProfitOrlosstextBox.Text = "0";
            this.MonthlyProfitOrlosstextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 64;
            this.label5.Text = "Profit/Loss:";
            // 
            // MonthlyBalancetextBox
            // 
            this.MonthlyBalancetextBox.Location = new System.Drawing.Point(810, 220);
            this.MonthlyBalancetextBox.Name = "MonthlyBalancetextBox";
            this.MonthlyBalancetextBox.Size = new System.Drawing.Size(150, 24);
            this.MonthlyBalancetextBox.TabIndex = 15;
            this.MonthlyBalancetextBox.Text = "0";
            this.MonthlyBalancetextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MonthlyBalancetextBox.TextChanged += new System.EventHandler(this.MonthlyBalancetextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(651, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 62;
            this.label6.Text = "Balance:";
            // 
            // MonthlyExpensetextBox
            // 
            this.MonthlyExpensetextBox.Location = new System.Drawing.Point(498, 220);
            this.MonthlyExpensetextBox.Name = "MonthlyExpensetextBox";
            this.MonthlyExpensetextBox.Size = new System.Drawing.Size(150, 24);
            this.MonthlyExpensetextBox.TabIndex = 13;
            this.MonthlyExpensetextBox.Text = "0";
            this.MonthlyExpensetextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MonthlyExpensetextBox.TextChanged += new System.EventHandler(this.MonthlyExpensetextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(495, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 17);
            this.label7.TabIndex = 60;
            this.label7.Text = "Monthly Total Exp:";
            // 
            // MonthlyIncometextBox
            // 
            this.MonthlyIncometextBox.Location = new System.Drawing.Point(186, 221);
            this.MonthlyIncometextBox.Name = "MonthlyIncometextBox";
            this.MonthlyIncometextBox.Size = new System.Drawing.Size(150, 24);
            this.MonthlyIncometextBox.TabIndex = 11;
            this.MonthlyIncometextBox.Text = "0";
            this.MonthlyIncometextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MonthlyIncometextBox.TextChanged += new System.EventHandler(this.MonthlyIncometextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(183, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 58;
            this.label8.Text = "Fee Income:";
            // 
            // MonthlySalaryExptextBox
            // 
            this.MonthlySalaryExptextBox.Location = new System.Drawing.Point(654, 220);
            this.MonthlySalaryExptextBox.Name = "MonthlySalaryExptextBox";
            this.MonthlySalaryExptextBox.Size = new System.Drawing.Size(150, 24);
            this.MonthlySalaryExptextBox.TabIndex = 14;
            this.MonthlySalaryExptextBox.Text = "0";
            this.MonthlySalaryExptextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MonthlySalaryExptextBox.TextChanged += new System.EventHandler(this.MonthlySalaryExptextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(651, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 17);
            this.label9.TabIndex = 66;
            this.label9.Text = "Salary Expense:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(186, 308);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(774, 250);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(342, 270);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Location = new System.Drawing.Point(423, 270);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(75, 23);
            this.Deletebutton.TabIndex = 18;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(504, 270);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 19;
            this.button7.Text = "Show All";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(738, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 17);
            this.label10.TabIndex = 118;
            this.label10.Text = "Searching";
            // 
            // BalanceSearchingtextBox
            // 
            this.BalanceSearchingtextBox.Location = new System.Drawing.Point(810, 270);
            this.BalanceSearchingtextBox.Name = "BalanceSearchingtextBox";
            this.BalanceSearchingtextBox.Size = new System.Drawing.Size(150, 24);
            this.BalanceSearchingtextBox.TabIndex = 21;
            this.BalanceSearchingtextBox.TextChanged += new System.EventHandler(this.BalanceSearchingtextBox_TextChanged);
            // 
            // ProfitOrLossIdtextBox
            // 
            this.ProfitOrLossIdtextBox.Location = new System.Drawing.Point(186, 172);
            this.ProfitOrLossIdtextBox.Name = "ProfitOrLossIdtextBox";
            this.ProfitOrLossIdtextBox.Size = new System.Drawing.Size(80, 24);
            this.ProfitOrLossIdtextBox.TabIndex = 8;
            this.ProfitOrLossIdtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(183, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 17);
            this.label11.TabIndex = 120;
            this.label11.Text = "Id:";
            // 
            // DailyBookCertificatetextBox
            // 
            this.DailyBookCertificatetextBox.Location = new System.Drawing.Point(342, 92);
            this.DailyBookCertificatetextBox.Name = "DailyBookCertificatetextBox";
            this.DailyBookCertificatetextBox.Size = new System.Drawing.Size(150, 24);
            this.DailyBookCertificatetextBox.TabIndex = 4;
            this.DailyBookCertificatetextBox.Text = "0";
            this.DailyBookCertificatetextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DailyBookCertificatetextBox.TextChanged += new System.EventHandler(this.DailyBookCertificatetextBox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(339, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 17);
            this.label12.TabIndex = 121;
            this.label12.Text = "Book Or Certi Income:";
            // 
            // MonthlyBookOrCertitextBox
            // 
            this.MonthlyBookOrCertitextBox.Location = new System.Drawing.Point(342, 221);
            this.MonthlyBookOrCertitextBox.Name = "MonthlyBookOrCertitextBox";
            this.MonthlyBookOrCertitextBox.Size = new System.Drawing.Size(150, 24);
            this.MonthlyBookOrCertitextBox.TabIndex = 12;
            this.MonthlyBookOrCertitextBox.Text = "0";
            this.MonthlyBookOrCertitextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MonthlyBookOrCertitextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(339, 201);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(143, 17);
            this.label17.TabIndex = 123;
            this.label17.Text = "Book Or Certi Income:";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(807, 200);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 17);
            this.label18.TabIndex = 125;
            this.label18.Text = "Balance:";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(585, 270);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 20;
            this.button6.Text = "Excel";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ProftOrLossForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 593);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.MonthlyBookOrCertitextBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.DailyBookCertificatetextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ProfitOrLossIdtextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BalanceSearchingtextBox);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MonthlySalaryExptextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.MonthlyProfitOrlosstextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MonthlyBalancetextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MonthlyExpensetextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MonthlyIncometextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.BalanceSelectYearcomboBox);
            this.Controls.Add(this.BalanceSelectMonthcomboBox);
            this.Controls.Add(this.ProfitOrLosstextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DateBalancetextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateExpensetextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateIncometextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ExpTodateTimePicker);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ExpFromdateTimePicker);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.Name = "ProftOrLossForm";
            this.Text = "ProftOrLossForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.ProftOrLossForm_Load);
            this.Controls.SetChildIndex(this.ExpFromdateTimePicker, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.ExpTodateTimePicker, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.DateIncometextBox, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.DateExpensetextBox, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.DateBalancetextBox, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.ProfitOrLosstextBox, 0);
            this.Controls.SetChildIndex(this.BalanceSelectMonthcomboBox, 0);
            this.Controls.SetChildIndex(this.BalanceSelectYearcomboBox, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.MonthlyIncometextBox, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.MonthlyExpensetextBox, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.MonthlyBalancetextBox, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.MonthlyProfitOrlosstextBox, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.MonthlySalaryExptextBox, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.button5, 0);
            this.Controls.SetChildIndex(this.Deletebutton, 0);
            this.Controls.SetChildIndex(this.button7, 0);
            this.Controls.SetChildIndex(this.BalanceSearchingtextBox, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.ProfitOrLossIdtextBox, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.DailyBookCertificatetextBox, 0);
            this.Controls.SetChildIndex(this.label17, 0);
            this.Controls.SetChildIndex(this.MonthlyBookOrCertitextBox, 0);
            this.Controls.SetChildIndex(this.label18, 0);
            this.Controls.SetChildIndex(this.button6, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker ExpTodateTimePicker;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker ExpFromdateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DateIncometextBox;
        private System.Windows.Forms.TextBox DateExpensetextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DateBalancetextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProfitOrLosstextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox BalanceSelectYearcomboBox;
        private System.Windows.Forms.ComboBox BalanceSelectMonthcomboBox;
        private System.Windows.Forms.TextBox MonthlyProfitOrlosstextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MonthlyBalancetextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MonthlyExpensetextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MonthlyIncometextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MonthlySalaryExptextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox BalanceSearchingtextBox;
        private System.Windows.Forms.TextBox ProfitOrLossIdtextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox DailyBookCertificatetextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox MonthlyBookOrCertitextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button6;
    }
}
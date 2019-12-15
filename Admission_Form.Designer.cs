namespace Lingo_Application
{
    partial class Admission_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admission_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.AdmBranchCodetextBox = new System.Windows.Forms.TextBox();
            this.DateOfAdmissiondateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Findbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.StudentNametextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FatherNametextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ContactNotextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.WhatsAppNotextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.FaceBookIDtextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DepartmentcomboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ProgramNamecomboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DueDatedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.TeacherNamecomboBox = new System.Windows.Forms.ComboBox();
            this.ClassTimingcomboBox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.AdmUpdatebutton = new System.Windows.Forms.Button();
            this.AdmDeletebutton = new System.Windows.Forms.Button();
            this.AdmClearbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GendercomboBox = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.LastIDlabel = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.AdmSavebutton = new System.Windows.Forms.Button();
            this.AdmStudentStatuscomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AdmStudentIdextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PictureBrowserbutton = new System.Windows.Forms.Button();
            this.StudentPictureBox = new System.Windows.Forms.PictureBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.AdmSearchingtextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ShowAllbutton = new System.Windows.Forms.Button();
            this.Excelbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Branch Code:";
            // 
            // AdmBranchCodetextBox
            // 
            this.AdmBranchCodetextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.AdmBranchCodetextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.AdmBranchCodetextBox.Location = new System.Drawing.Point(169, 39);
            this.AdmBranchCodetextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AdmBranchCodetextBox.Name = "AdmBranchCodetextBox";
            this.AdmBranchCodetextBox.Size = new System.Drawing.Size(143, 24);
            this.AdmBranchCodetextBox.TabIndex = 1;
            this.AdmBranchCodetextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AdmBranchCodetextBox.TextChanged += new System.EventHandler(this.StudentIDtextBox_TextChanged);
            // 
            // DateOfAdmissiondateTimePicker
            // 
            this.DateOfAdmissiondateTimePicker.CustomFormat = "dd-MMM-yyy";
            this.DateOfAdmissiondateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateOfAdmissiondateTimePicker.Location = new System.Drawing.Point(514, 40);
            this.DateOfAdmissiondateTimePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DateOfAdmissiondateTimePicker.Name = "DateOfAdmissiondateTimePicker";
            this.DateOfAdmissiondateTimePicker.Size = new System.Drawing.Size(137, 24);
            this.DateOfAdmissiondateTimePicker.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date Of Admission:";
            // 
            // Findbutton
            // 
            this.Findbutton.Location = new System.Drawing.Point(428, 36);
            this.Findbutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Findbutton.Name = "Findbutton";
            this.Findbutton.Size = new System.Drawing.Size(78, 31);
            this.Findbutton.TabIndex = 3;
            this.Findbutton.Text = "Find";
            this.Findbutton.UseVisualStyleBackColor = true;
            this.Findbutton.Click += new System.EventHandler(this.Findbutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Student Name:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // StudentNametextBox
            // 
            this.StudentNametextBox.Location = new System.Drawing.Point(169, 111);
            this.StudentNametextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.StudentNametextBox.Name = "StudentNametextBox";
            this.StudentNametextBox.Size = new System.Drawing.Size(328, 24);
            this.StudentNametextBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(500, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Father/Guardian Name: ";
            // 
            // FatherNametextBox
            // 
            this.FatherNametextBox.Location = new System.Drawing.Point(505, 111);
            this.FatherNametextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FatherNametextBox.Name = "FatherNametextBox";
            this.FatherNametextBox.Size = new System.Drawing.Size(328, 24);
            this.FatherNametextBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 155);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Contact No:";
            // 
            // ContactNotextBox
            // 
            this.ContactNotextBox.Location = new System.Drawing.Point(169, 175);
            this.ContactNotextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ContactNotextBox.Name = "ContactNotextBox";
            this.ContactNotextBox.Size = new System.Drawing.Size(199, 24);
            this.ContactNotextBox.TabIndex = 9;
            this.ContactNotextBox.TextChanged += new System.EventHandler(this.ContactNotextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(373, 158);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Whatsapp No:";
            // 
            // WhatsAppNotextBox
            // 
            this.WhatsAppNotextBox.Location = new System.Drawing.Point(376, 175);
            this.WhatsAppNotextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.WhatsAppNotextBox.Name = "WhatsAppNotextBox";
            this.WhatsAppNotextBox.Size = new System.Drawing.Size(199, 24);
            this.WhatsAppNotextBox.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(583, 152);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Facebook Id:";
            // 
            // FaceBookIDtextBox
            // 
            this.FaceBookIDtextBox.Location = new System.Drawing.Point(583, 175);
            this.FaceBookIDtextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FaceBookIDtextBox.Name = "FaceBookIDtextBox";
            this.FaceBookIDtextBox.Size = new System.Drawing.Size(245, 24);
            this.FaceBookIDtextBox.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(166, 220);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Department:";
            // 
            // DepartmentcomboBox
            // 
            this.DepartmentcomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DepartmentcomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.DepartmentcomboBox.FormattingEnabled = true;
            this.DepartmentcomboBox.Location = new System.Drawing.Point(169, 240);
            this.DepartmentcomboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DepartmentcomboBox.Name = "DepartmentcomboBox";
            this.DepartmentcomboBox.Size = new System.Drawing.Size(199, 25);
            this.DepartmentcomboBox.TabIndex = 13;
            this.DepartmentcomboBox.SelectedIndexChanged += new System.EventHandler(this.DepartmentcomboBox_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(376, 220);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Program Name:";
            // 
            // ProgramNamecomboBox
            // 
            this.ProgramNamecomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ProgramNamecomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ProgramNamecomboBox.FormattingEnabled = true;
            this.ProgramNamecomboBox.Location = new System.Drawing.Point(376, 240);
            this.ProgramNamecomboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ProgramNamecomboBox.Name = "ProgramNamecomboBox";
            this.ProgramNamecomboBox.Size = new System.Drawing.Size(199, 25);
            this.ProgramNamecomboBox.TabIndex = 14;
            this.ProgramNamecomboBox.SelectedIndexChanged += new System.EventHandler(this.ProgramNamecomboBox_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(838, 155);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "Due Date:";
            // 
            // DueDatedateTimePicker
            // 
            this.DueDatedateTimePicker.CustomFormat = "dd-MMM-yyy";
            this.DueDatedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DueDatedateTimePicker.Location = new System.Drawing.Point(841, 175);
            this.DueDatedateTimePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DueDatedateTimePicker.Name = "DueDatedateTimePicker";
            this.DueDatedateTimePicker.Size = new System.Drawing.Size(137, 24);
            this.DueDatedateTimePicker.TabIndex = 12;
            this.DueDatedateTimePicker.ValueChanged += new System.EventHandler(this.DueDatedateTimePicker_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(580, 220);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "Teacher Name:";
            // 
            // TeacherNamecomboBox
            // 
            this.TeacherNamecomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TeacherNamecomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TeacherNamecomboBox.FormattingEnabled = true;
            this.TeacherNamecomboBox.Location = new System.Drawing.Point(583, 240);
            this.TeacherNamecomboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TeacherNamecomboBox.Name = "TeacherNamecomboBox";
            this.TeacherNamecomboBox.Size = new System.Drawing.Size(199, 25);
            this.TeacherNamecomboBox.TabIndex = 15;
            this.TeacherNamecomboBox.SelectedIndexChanged += new System.EventHandler(this.TeacherNamecomboBox_SelectedIndexChanged);
            // 
            // ClassTimingcomboBox
            // 
            this.ClassTimingcomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ClassTimingcomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ClassTimingcomboBox.FormattingEnabled = true;
            this.ClassTimingcomboBox.Location = new System.Drawing.Point(793, 240);
            this.ClassTimingcomboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ClassTimingcomboBox.Name = "ClassTimingcomboBox";
            this.ClassTimingcomboBox.Size = new System.Drawing.Size(199, 25);
            this.ClassTimingcomboBox.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(790, 220);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 17);
            this.label14.TabIndex = 32;
            this.label14.Text = "Class Timing:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(838, 90);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 17);
            this.label16.TabIndex = 35;
            this.label16.Text = "Gender:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AdmUpdatebutton
            // 
            this.AdmUpdatebutton.Location = new System.Drawing.Point(251, 280);
            this.AdmUpdatebutton.Name = "AdmUpdatebutton";
            this.AdmUpdatebutton.Size = new System.Drawing.Size(75, 23);
            this.AdmUpdatebutton.TabIndex = 18;
            this.AdmUpdatebutton.Text = "Update";
            this.AdmUpdatebutton.UseVisualStyleBackColor = true;
            this.AdmUpdatebutton.Click += new System.EventHandler(this.AdmUpdatebutton_Click);
            // 
            // AdmDeletebutton
            // 
            this.AdmDeletebutton.Location = new System.Drawing.Point(332, 280);
            this.AdmDeletebutton.Name = "AdmDeletebutton";
            this.AdmDeletebutton.Size = new System.Drawing.Size(75, 23);
            this.AdmDeletebutton.TabIndex = 19;
            this.AdmDeletebutton.Text = "Delete";
            this.AdmDeletebutton.UseVisualStyleBackColor = true;
            this.AdmDeletebutton.Click += new System.EventHandler(this.AdmDeletebutton_Click);
            // 
            // AdmClearbutton
            // 
            this.AdmClearbutton.Location = new System.Drawing.Point(413, 280);
            this.AdmClearbutton.Name = "AdmClearbutton";
            this.AdmClearbutton.Size = new System.Drawing.Size(75, 23);
            this.AdmClearbutton.TabIndex = 20;
            this.AdmClearbutton.Text = "Clear";
            this.AdmClearbutton.UseVisualStyleBackColor = true;
            this.AdmClearbutton.Click += new System.EventHandler(this.AdmClearbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(169, 321);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(950, 250);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // GendercomboBox
            // 
            this.GendercomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.GendercomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.GendercomboBox.FormattingEnabled = true;
            this.GendercomboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GendercomboBox.Location = new System.Drawing.Point(841, 110);
            this.GendercomboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GendercomboBox.Name = "GendercomboBox";
            this.GendercomboBox.Size = new System.Drawing.Size(138, 25);
            this.GendercomboBox.TabIndex = 8;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(320, 69);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 17);
            this.label20.TabIndex = 52;
            this.label20.Text = "Last Id:";
            // 
            // LastIDlabel
            // 
            this.LastIDlabel.AutoSize = true;
            this.LastIDlabel.Location = new System.Drawing.Point(369, 69);
            this.LastIDlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastIDlabel.Name = "LastIDlabel";
            this.LastIDlabel.Size = new System.Drawing.Size(15, 17);
            this.LastIDlabel.TabIndex = 53;
            this.LastIDlabel.Text = "0";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // AdmSavebutton
            // 
            this.AdmSavebutton.Location = new System.Drawing.Point(169, 280);
            this.AdmSavebutton.Name = "AdmSavebutton";
            this.AdmSavebutton.Size = new System.Drawing.Size(75, 23);
            this.AdmSavebutton.TabIndex = 17;
            this.AdmSavebutton.Text = "Save";
            this.AdmSavebutton.UseVisualStyleBackColor = true;
            this.AdmSavebutton.Click += new System.EventHandler(this.AdmSavebutton_Click);
            // 
            // AdmStudentStatuscomboBox
            // 
            this.AdmStudentStatuscomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.AdmStudentStatuscomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.AdmStudentStatuscomboBox.FormattingEnabled = true;
            this.AdmStudentStatuscomboBox.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Completed"});
            this.AdmStudentStatuscomboBox.Location = new System.Drawing.Point(659, 39);
            this.AdmStudentStatuscomboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AdmStudentStatuscomboBox.Name = "AdmStudentStatuscomboBox";
            this.AdmStudentStatuscomboBox.Size = new System.Drawing.Size(150, 25);
            this.AdmStudentStatuscomboBox.TabIndex = 5;
            this.AdmStudentStatuscomboBox.Text = "Active";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(656, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 71;
            this.label4.Text = "Student Status";
            // 
            // AdmStudentIdextBox
            // 
            this.AdmStudentIdextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.AdmStudentIdextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.AdmStudentIdextBox.Location = new System.Drawing.Point(320, 40);
            this.AdmStudentIdextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AdmStudentIdextBox.Name = "AdmStudentIdextBox";
            this.AdmStudentIdextBox.Size = new System.Drawing.Size(100, 24);
            this.AdmStudentIdextBox.TabIndex = 2;
            this.AdmStudentIdextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 109;
            this.label3.Text = "Id No:";
            // 
            // PictureBrowserbutton
            // 
            this.PictureBrowserbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PictureBrowserbutton.Location = new System.Drawing.Point(1004, 155);
            this.PictureBrowserbutton.Name = "PictureBrowserbutton";
            this.PictureBrowserbutton.Size = new System.Drawing.Size(124, 23);
            this.PictureBrowserbutton.TabIndex = 37;
            this.PictureBrowserbutton.Text = "Picture Browser";
            this.PictureBrowserbutton.UseVisualStyleBackColor = true;
            this.PictureBrowserbutton.Click += new System.EventHandler(this.PictureBrowserbutton_Click);
            // 
            // StudentPictureBox
            // 
            this.StudentPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StudentPictureBox.Location = new System.Drawing.Point(1004, 24);
            this.StudentPictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.StudentPictureBox.Name = "StudentPictureBox";
            this.StudentPictureBox.Size = new System.Drawing.Size(123, 122);
            this.StudentPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StudentPictureBox.TabIndex = 14;
            this.StudentPictureBox.TabStop = false;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // AdmSearchingtextBox
            // 
            this.AdmSearchingtextBox.Location = new System.Drawing.Point(792, 280);
            this.AdmSearchingtextBox.Name = "AdmSearchingtextBox";
            this.AdmSearchingtextBox.Size = new System.Drawing.Size(200, 24);
            this.AdmSearchingtextBox.TabIndex = 21;
            this.AdmSearchingtextBox.TextChanged += new System.EventHandler(this.AdmSearchingtextBox_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(720, 283);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 17);
            this.label15.TabIndex = 111;
            this.label15.Text = "Searching";
            // 
            // ShowAllbutton
            // 
            this.ShowAllbutton.Location = new System.Drawing.Point(494, 280);
            this.ShowAllbutton.Name = "ShowAllbutton";
            this.ShowAllbutton.Size = new System.Drawing.Size(75, 23);
            this.ShowAllbutton.TabIndex = 112;
            this.ShowAllbutton.Text = "Show All";
            this.ShowAllbutton.UseVisualStyleBackColor = true;
            this.ShowAllbutton.Click += new System.EventHandler(this.ShowAllbutton_Click);
            // 
            // Excelbutton
            // 
            this.Excelbutton.Location = new System.Drawing.Point(575, 280);
            this.Excelbutton.Name = "Excelbutton";
            this.Excelbutton.Size = new System.Drawing.Size(75, 23);
            this.Excelbutton.TabIndex = 113;
            this.Excelbutton.Text = "Excel";
            this.Excelbutton.UseVisualStyleBackColor = true;
            this.Excelbutton.Click += new System.EventHandler(this.Excelbutton_Click);
            // 
            // Admission_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 592);
            this.Controls.Add(this.Excelbutton);
            this.Controls.Add(this.ShowAllbutton);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.AdmSearchingtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AdmStudentIdextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AdmStudentStatuscomboBox);
            this.Controls.Add(this.AdmSavebutton);
            this.Controls.Add(this.LastIDlabel);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.GendercomboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AdmClearbutton);
            this.Controls.Add(this.AdmDeletebutton);
            this.Controls.Add(this.AdmUpdatebutton);
            this.Controls.Add(this.PictureBrowserbutton);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ClassTimingcomboBox);
            this.Controls.Add(this.TeacherNamecomboBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.DueDatedateTimePicker);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ProgramNamecomboBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DepartmentcomboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.FaceBookIDtextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.WhatsAppNotextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ContactNotextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FatherNametextBox);
            this.Controls.Add(this.StudentPictureBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StudentNametextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Findbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateOfAdmissiondateTimePicker);
            this.Controls.Add(this.AdmBranchCodetextBox);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Admission_Form";
            this.Text = "Admission Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.Admission_Form_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.AdmBranchCodetextBox, 0);
            this.Controls.SetChildIndex(this.DateOfAdmissiondateTimePicker, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.Findbutton, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.StudentNametextBox, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.StudentPictureBox, 0);
            this.Controls.SetChildIndex(this.FatherNametextBox, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.ContactNotextBox, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.WhatsAppNotextBox, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.FaceBookIDtextBox, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.DepartmentcomboBox, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.ProgramNamecomboBox, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.DueDatedateTimePicker, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.TeacherNamecomboBox, 0);
            this.Controls.SetChildIndex(this.ClassTimingcomboBox, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.PictureBrowserbutton, 0);
            this.Controls.SetChildIndex(this.AdmUpdatebutton, 0);
            this.Controls.SetChildIndex(this.AdmDeletebutton, 0);
            this.Controls.SetChildIndex(this.AdmClearbutton, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.GendercomboBox, 0);
            this.Controls.SetChildIndex(this.label20, 0);
            this.Controls.SetChildIndex(this.LastIDlabel, 0);
            this.Controls.SetChildIndex(this.AdmSavebutton, 0);
            this.Controls.SetChildIndex(this.AdmStudentStatuscomboBox, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.AdmStudentIdextBox, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.AdmSearchingtextBox, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.ShowAllbutton, 0);
            this.Controls.SetChildIndex(this.Excelbutton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AdmBranchCodetextBox;
        private System.Windows.Forms.DateTimePicker DateOfAdmissiondateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Findbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox StudentNametextBox;
        private System.Windows.Forms.TextBox FatherNametextBox;
        private System.Windows.Forms.TextBox FaceBookIDtextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox WhatsAppNotextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ContactNotextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ProgramNamecomboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox DepartmentcomboBox;
        private System.Windows.Forms.DateTimePicker DueDatedateTimePicker;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox TeacherNamecomboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox ClassTimingcomboBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button AdmClearbutton;
        private System.Windows.Forms.Button AdmDeletebutton;
        private System.Windows.Forms.Button AdmUpdatebutton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox GendercomboBox;
        private System.Windows.Forms.Label LastIDlabel;
        private System.Windows.Forms.Label label20;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button AdmSavebutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox AdmStudentStatuscomboBox;
        private System.Windows.Forms.TextBox AdmStudentIdextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button PictureBrowserbutton;
        private System.Windows.Forms.PictureBox StudentPictureBox;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox AdmSearchingtextBox;
        private System.Windows.Forms.Button ShowAllbutton;
        private System.Windows.Forms.Button Excelbutton;
    }
}
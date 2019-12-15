namespace Lingo_Application
{
    partial class EmpNewRegisterForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.EmpWhatsaaptextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmpJoinDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.EmpMobileNotextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmpDesigtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmpNametextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmpIdtextBox = new System.Windows.Forms.TextBox();
            this.EmplSavebutton = new System.Windows.Forms.Button();
            this.EmplUpdatebutton = new System.Windows.Forms.Button();
            this.EmpDeletebutton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Excelbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(180, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1030, 450);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1008, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "Whatapp No:";
            // 
            // EmpWhatsaaptextBox
            // 
            this.EmpWhatsaaptextBox.Location = new System.Drawing.Point(1011, 41);
            this.EmpWhatsaaptextBox.Name = "EmpWhatsaaptextBox";
            this.EmpWhatsaaptextBox.Size = new System.Drawing.Size(200, 24);
            this.EmpWhatsaaptextBox.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(646, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Joining Date:";
            // 
            // EmpJoinDateTimePicker
            // 
            this.EmpJoinDateTimePicker.CustomFormat = " ";
            this.EmpJoinDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EmpJoinDateTimePicker.Location = new System.Drawing.Point(649, 41);
            this.EmpJoinDateTimePicker.Name = "EmpJoinDateTimePicker";
            this.EmpJoinDateTimePicker.Size = new System.Drawing.Size(150, 24);
            this.EmpJoinDateTimePicker.TabIndex = 37;
            this.EmpJoinDateTimePicker.ValueChanged += new System.EventHandler(this.EmpJoinDateTimePicker_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(802, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "Mobile No:";
            // 
            // EmpMobileNotextBox
            // 
            this.EmpMobileNotextBox.Location = new System.Drawing.Point(805, 41);
            this.EmpMobileNotextBox.Name = "EmpMobileNotextBox";
            this.EmpMobileNotextBox.Size = new System.Drawing.Size(200, 24);
            this.EmpMobileNotextBox.TabIndex = 39;
            this.EmpMobileNotextBox.TextChanged += new System.EventHandler(this.EmpMobileNotextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Designation:";
            // 
            // EmpDesigtextBox
            // 
            this.EmpDesigtextBox.Location = new System.Drawing.Point(492, 41);
            this.EmpDesigtextBox.Name = "EmpDesigtextBox";
            this.EmpDesigtextBox.Size = new System.Drawing.Size(150, 24);
            this.EmpDesigtextBox.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Employ Name:";
            // 
            // EmpNametextBox
            // 
            this.EmpNametextBox.Location = new System.Drawing.Point(286, 41);
            this.EmpNametextBox.Name = "EmpNametextBox";
            this.EmpNametextBox.Size = new System.Drawing.Size(200, 24);
            this.EmpNametextBox.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Employ Id:";
            // 
            // EmpIdtextBox
            // 
            this.EmpIdtextBox.Location = new System.Drawing.Point(180, 41);
            this.EmpIdtextBox.Name = "EmpIdtextBox";
            this.EmpIdtextBox.Size = new System.Drawing.Size(100, 24);
            this.EmpIdtextBox.TabIndex = 33;
            // 
            // EmplSavebutton
            // 
            this.EmplSavebutton.Location = new System.Drawing.Point(180, 75);
            this.EmplSavebutton.Name = "EmplSavebutton";
            this.EmplSavebutton.Size = new System.Drawing.Size(75, 23);
            this.EmplSavebutton.TabIndex = 46;
            this.EmplSavebutton.Text = "Save";
            this.EmplSavebutton.UseVisualStyleBackColor = true;
            this.EmplSavebutton.Click += new System.EventHandler(this.EmplSavebutton_Click);
            // 
            // EmplUpdatebutton
            // 
            this.EmplUpdatebutton.Location = new System.Drawing.Point(261, 75);
            this.EmplUpdatebutton.Name = "EmplUpdatebutton";
            this.EmplUpdatebutton.Size = new System.Drawing.Size(75, 23);
            this.EmplUpdatebutton.TabIndex = 47;
            this.EmplUpdatebutton.Text = "Update";
            this.EmplUpdatebutton.UseVisualStyleBackColor = true;
            this.EmplUpdatebutton.Click += new System.EventHandler(this.EmplUpdatebutton_Click);
            // 
            // EmpDeletebutton
            // 
            this.EmpDeletebutton.Location = new System.Drawing.Point(342, 75);
            this.EmpDeletebutton.Name = "EmpDeletebutton";
            this.EmpDeletebutton.Size = new System.Drawing.Size(75, 23);
            this.EmpDeletebutton.TabIndex = 48;
            this.EmpDeletebutton.Text = "Delete";
            this.EmpDeletebutton.UseVisualStyleBackColor = true;
            this.EmpDeletebutton.Click += new System.EventHandler(this.EmpDeletebutton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(423, 75);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 49;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Excelbutton
            // 
            this.Excelbutton.Location = new System.Drawing.Point(504, 75);
            this.Excelbutton.Name = "Excelbutton";
            this.Excelbutton.Size = new System.Drawing.Size(75, 23);
            this.Excelbutton.TabIndex = 50;
            this.Excelbutton.Text = "Excel";
            this.Excelbutton.UseVisualStyleBackColor = true;
            this.Excelbutton.Click += new System.EventHandler(this.Excelbutton_Click);
            // 
            // EmpNewRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 591);
            this.Controls.Add(this.Excelbutton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.EmpDeletebutton);
            this.Controls.Add(this.EmplUpdatebutton);
            this.Controls.Add(this.EmplSavebutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EmpWhatsaaptextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmpJoinDateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmpMobileNotextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmpDesigtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmpNametextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmpIdtextBox);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.Name = "EmpNewRegisterForm";
            this.Text = "EmpNewRegisterForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.EmpNewRegisterForm_Load);
            this.Controls.SetChildIndex(this.EmpIdtextBox, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.EmpNametextBox, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.EmpDesigtextBox, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.EmpMobileNotextBox, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.EmpJoinDateTimePicker, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.EmpWhatsaaptextBox, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.EmplSavebutton, 0);
            this.Controls.SetChildIndex(this.EmplUpdatebutton, 0);
            this.Controls.SetChildIndex(this.EmpDeletebutton, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.Excelbutton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EmpWhatsaaptextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker EmpJoinDateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EmpMobileNotextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmpDesigtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmpNametextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmpIdtextBox;
        private System.Windows.Forms.Button EmplSavebutton;
        private System.Windows.Forms.Button EmplUpdatebutton;
        private System.Windows.Forms.Button EmpDeletebutton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Excelbutton;
    }
}
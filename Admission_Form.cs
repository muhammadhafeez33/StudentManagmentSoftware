using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using System.IO;
using System.Web;
using Lingo_Application;
using Excel = Microsoft.Office.Interop.Excel;


namespace Lingo_Application
{
    public partial class Admission_Form : Main_Form
    {
        public Admission_Form()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void PictureBrowserbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                StudentPictureBox.Image = new Bitmap(open.FileName);
                // image file path  


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Findbutton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Lingo$ where Branch_Code='" + AdmBranchCodetextBox.Text + "' and Student_Id='" + AdmStudentIdextBox.Text + "'", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                dataGridView1.DataSource = dt;



                DateOfAdmissiondateTimePicker.Text = dt.Rows[0][2].ToString();
                StudentNametextBox.Text = dt.Rows[0][3].ToString();
                FatherNametextBox.Text = dt.Rows[0][4].ToString();
                GendercomboBox.Text = dt.Rows[0][5].ToString();
                ContactNotextBox.Text = dt.Rows[0][6].ToString();
                WhatsAppNotextBox.Text = dt.Rows[0][7].ToString();
                FaceBookIDtextBox.Text = dt.Rows[0][8].ToString();
                DepartmentcomboBox.Text = dt.Rows[0][9].ToString();
                ProgramNamecomboBox.Text = dt.Rows[0][10].ToString();
                TeacherNamecomboBox.Text = dt.Rows[0][11].ToString();
                ClassTimingcomboBox.Text = dt.Rows[0][12].ToString();
                DueDatedateTimePicker.Text = dt.Rows[0][13].ToString();

            }
            catch
            {
                MessageBox.Show("Record was not found");
            }
        }

        private void Admission_Form_Load(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con1.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT top(1)Student_Id from Lingo$ ORDER BY Student_Id DESC", con1);
            try
            {
                var a1 = cmd1.ExecuteScalar();
                LastIDlabel.Text = a1.ToString();
                con1.Close();
            }
            catch
            {

            }


            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Lingo$", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;

            con.Open();
            SqlCommand cmd3 = new SqlCommand("select Branch_Code from Lingo$ group by Branch_Code", con);
            SqlDataReader Reader3 = cmd3.ExecuteReader();
            AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            while (Reader3.Read())
            {
                MyCollection.Add(Reader3.GetString(0));

            }
            AdmBranchCodetextBox.AutoCompleteCustomSource = MyCollection;
            con.Close();

            con.Open();
            SqlCommand cmdDep = new SqlCommand("select * from Department", con);
            SqlDataReader ReaderDep = cmdDep.ExecuteReader();
            AutoCompleteStringCollection MyCollectionDep = new AutoCompleteStringCollection();
            while (ReaderDep.Read())
            {
                MyCollectionDep.Add(ReaderDep.GetString(1));

            }
            DepartmentcomboBox.AutoCompleteCustomSource = MyCollectionDep;
            con.Close();

            con.Open();
            SqlCommand cmdProg = new SqlCommand("select * from Program", con);
            SqlDataReader ReaderProg = cmdProg.ExecuteReader();
            AutoCompleteStringCollection MyCollectionProg = new AutoCompleteStringCollection();
            while (ReaderProg.Read())
            {
                MyCollectionProg.Add(ReaderProg.GetString(1));

            }
            ProgramNamecomboBox.AutoCompleteCustomSource = MyCollectionProg;
            con.Close();

            con.Open();
            SqlCommand cmdEmpl = new SqlCommand("select EmployName from EmplTable", con);
            SqlDataReader ReaderEmpl = cmdEmpl.ExecuteReader();
            AutoCompleteStringCollection MyCollectionEmpl = new AutoCompleteStringCollection();
            while (ReaderEmpl.Read())
            {
                MyCollectionEmpl.Add(ReaderEmpl.GetString(0));

            }
            TeacherNamecomboBox.AutoCompleteCustomSource = MyCollectionEmpl;
            con.Close();

            con.Open();
            SqlCommand cmdTim = new SqlCommand("select * from Timing", con);
            SqlDataReader ReaderTim = cmdTim.ExecuteReader();
            AutoCompleteStringCollection MyCollectionTim = new AutoCompleteStringCollection();
            while (ReaderTim.Read())
            {
                MyCollectionTim.Add(ReaderTim.GetString(1));

            }
            ClassTimingcomboBox.AutoCompleteCustomSource = MyCollectionTim;
            con.Close();

        }

        private void DepartmentcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProgramNamecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TeacherNamecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AdmSavebutton_Click(object sender, EventArgs e)
        {
            if (AdmBranchCodetextBox.Text == "" && StudentNametextBox.Text == "")
            {
                MessageBox.Show("Please Enter Branch Code and Student Name.");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Lingo$(Branch_Code,Adm_Date,Student_Name,Father_Name,Gender,Contact_No,Whatsapp_no,Fecebook_Id,Department,Program,Teacher,Timing,Due_Date,StudentStatus)values('" + AdmBranchCodetextBox.Text + "','" + DateOfAdmissiondateTimePicker.Text + "','" + StudentNametextBox.Text + "','" + FatherNametextBox.Text + "','" + GendercomboBox.Text + "','" + ContactNotextBox.Text + "','" + WhatsAppNotextBox.Text + "','" + FaceBookIDtextBox.Text + "','" + DepartmentcomboBox.Text + "','" + ProgramNamecomboBox.Text + "','" + TeacherNamecomboBox.Text + "','" + ClassTimingcomboBox.Text + "','" + DueDatedateTimePicker.Text + "','" + AdmStudentStatuscomboBox.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter("select * from Lingo$ where Student_Id='" + AdmStudentIdextBox.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;

                    SqlCommand cmd1 = new SqlCommand("SELECT top(1)Student_Id from Lingo$ ORDER BY Student_Id DESC", con);

                    var a1 = cmd1.ExecuteScalar();
                    LastIDlabel.Text = a1.ToString();

                    MessageBox.Show("Data Saved into Database");

                    AdmStudentIdextBox.Text = "";
                    AdmBranchCodetextBox.Text = "";
                    DateOfAdmissiondateTimePicker.Text = "";
                    StudentNametextBox.Text = "";
                    FatherNametextBox.Text = "";
                    GendercomboBox.Text = "";
                    ContactNotextBox.Text = "";
                    WhatsAppNotextBox.Text = "";
                    FaceBookIDtextBox.Text = "";
                    DepartmentcomboBox.Text = "";
                    ProgramNamecomboBox.Text = "";
                    TeacherNamecomboBox.Text = "";
                    ClassTimingcomboBox.Text = "";
                    DueDatedateTimePicker.Text = "";
                    AdmStudentStatuscomboBox.Text = "";

                    con.Close();

                    CollectionForm s = new CollectionForm();
                    s.Show();
                }
                catch
                {
                    MessageBox.Show("Record Already Saved");
                }

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void AdmUpdatebutton_Click(object sender, EventArgs e)
        {
            if (AdmBranchCodetextBox.Text == "" && StudentNametextBox.Text == "")
            {
                MessageBox.Show("Please Enter Branch Code and Student Name.");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update Lingo$ set Branch_Code='" + AdmBranchCodetextBox.Text + "',Adm_Date='" + DateOfAdmissiondateTimePicker.Text + "',Student_Name='" + StudentNametextBox.Text + "',Father_Name='" + FatherNametextBox.Text + "',Gender='" + GendercomboBox.Text + "',Contact_No='" + ContactNotextBox.Text + "',Whatsapp_no='" + WhatsAppNotextBox.Text + "',Fecebook_Id='" + FaceBookIDtextBox.Text + "',Department='" + DepartmentcomboBox.Text + "',Program='" + ProgramNamecomboBox.Text + "',Teacher='" + TeacherNamecomboBox.Text + "',Timing='" + ClassTimingcomboBox.Text + "',Due_Date='" + DueDatedateTimePicker.Text + "',StudentStatus='" + AdmStudentStatuscomboBox.Text + "' where Branch_Code='" + AdmBranchCodetextBox.Text + "'and Student_Id='" + AdmStudentIdextBox.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter("select * from Lingo$ where Student_Id='" + AdmStudentIdextBox.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                    MessageBox.Show("Record Updated in database.");
                }
                catch
                {
                    MessageBox.Show("Record is not Update");
                }
            }
        }

        private void AdmDeletebutton_Click(object sender, EventArgs e)
        {
            if (AdmBranchCodetextBox.Text == "" && StudentNametextBox.Text == "")
            {
                MessageBox.Show("Please Enter Branch Code and Student Name.");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete Lingo$ where Student_Id='" + AdmStudentIdextBox.Text + "' and Branch_Code='" + AdmBranchCodetextBox.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter("select * from Lingo$ where Student_Id='" + AdmStudentIdextBox.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;

                    MessageBox.Show("Record Deleted in database.");

                    SqlCommand cmd1 = new SqlCommand("SELECT top(1)Student_Id from Lingo$ ORDER BY Student_Id DESC", con);
                    var a1 = cmd1.ExecuteScalar();
                    LastIDlabel.Text = a1.ToString();
                    con.Close();

                    AdmBranchCodetextBox.Text = "";
                    AdmStudentIdextBox.Text = "";
                    DateOfAdmissiondateTimePicker.Text = "";
                    StudentNametextBox.Text = "";
                    FatherNametextBox.Text = "";
                    GendercomboBox.Text = "";
                    ContactNotextBox.Text = "";
                    WhatsAppNotextBox.Text = "";
                    FaceBookIDtextBox.Text = "";
                    DepartmentcomboBox.Text = "";
                    ProgramNamecomboBox.Text = "";
                    TeacherNamecomboBox.Text = "";
                    ClassTimingcomboBox.Text = "";
                    DueDatedateTimePicker.Text = "";
                    AdmStudentStatuscomboBox.Text = "";

                }
                catch
                {
                    MessageBox.Show("Record is not Delete");
                }
            }
        }

        private void AdmClearbutton_Click(object sender, EventArgs e)
        {

            AdmBranchCodetextBox.Text = "";
            DateOfAdmissiondateTimePicker.Text = "";
            StudentNametextBox.Text = "";
            FatherNametextBox.Text = "";
            GendercomboBox.Text = "";
            ContactNotextBox.Text = "";
            WhatsAppNotextBox.Text = "";
            FaceBookIDtextBox.Text = "";
            DepartmentcomboBox.Text = "";
            ProgramNamecomboBox.Text = "";
            TeacherNamecomboBox.Text = "";
            ClassTimingcomboBox.Text = "";
            DueDatedateTimePicker.Text = "";
            AdmStudentStatuscomboBox.Text = "";
        }

        private void DueDatedateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void StudentIDtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;
                    AdmBranchCodetextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Branch_Code"].FormattedValue.ToString();
                    AdmStudentIdextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Student_Id"].FormattedValue.ToString();
                    DateOfAdmissiondateTimePicker.Text = dataGridView1.Rows[e.RowIndex].Cells["Adm_Date"].FormattedValue.ToString();
                    StudentNametextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Student_Name"].FormattedValue.ToString();
                    FatherNametextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Father_Name"].FormattedValue.ToString();
                    GendercomboBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Gender"].FormattedValue.ToString();
                    ContactNotextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Contact_No"].FormattedValue.ToString();
                    WhatsAppNotextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Whatsapp_No"].FormattedValue.ToString();
                    FaceBookIDtextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Fecebook_Id"].FormattedValue.ToString();
                    DepartmentcomboBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Department"].FormattedValue.ToString();
                    ProgramNamecomboBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Program"].FormattedValue.ToString();
                    TeacherNamecomboBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Teacher"].FormattedValue.ToString();
                    ClassTimingcomboBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Timing"].FormattedValue.ToString();
                    DueDatedateTimePicker.Text = dataGridView1.Rows[e.RowIndex].Cells["Due_Date"].FormattedValue.ToString();
                    AdmStudentStatuscomboBox.Text = dataGridView1.Rows[e.RowIndex].Cells["StudentStatus"].FormattedValue.ToString();

                }

            }

            catch
            {
                MessageBox.Show("Click on any cell not column");
            }
        }

        private void AdmSearchingtextBox_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Lingo$ where Branch_Code like '%" + AdmSearchingtextBox.Text + "%' or Student_Id like'%" + AdmSearchingtextBox.Text + "%' or Student_Name like'%" + AdmSearchingtextBox.Text + "%' or Father_Name like'%" + AdmSearchingtextBox.Text + "%' or Contact_No like'%" + AdmSearchingtextBox.Text + "%' or Department like'%" + AdmSearchingtextBox.Text + "%' or Program like'%" + AdmSearchingtextBox.Text + "%' or Teacher like'%" + AdmSearchingtextBox.Text + "%' or StudentStatus like'%" + AdmSearchingtextBox.Text + "%'", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowAllbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Lingo$", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
        }

        private void ContactNotextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                WhatsAppNotextBox.Text = ContactNotextBox.Text;
            }
            catch
            {

            }
        }

        private void Excelbutton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null)
            {
                MessageBox.Show("Nothing to Export");
                return;
            }
            int rowsTotal = 0;
            int colsTotal = 0;
            int i = 0;
            int j = 0;
            int iC = 0;

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            Excel.Application xlApp = new Excel.Application();
            try
            {
                Excel.Workbook excelBook = xlApp.Workbooks.Add();
                Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelBook.Worksheets[1];
                xlApp.Visible = true;

                rowsTotal = dataGridView1.RowCount - 1;
                colsTotal = dataGridView1.Columns.Count - 1;
                var _with1 = excelWorksheet;
                _with1.Cells.Select();
                _with1.Cells.Delete();

                for (iC = 0; iC <= colsTotal; iC++)
                {
                    _with1.Cells[1, iC + 1] = dataGridView1.Columns[iC].HeaderText;
                   
                }

                for (i = 0; i <= rowsTotal - 1; i++)
                {
                    for (j=0;j<=colsTotal;j++)
                    {
                        _with1.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                       
                    }

                }

                
                _with1.Cells.Columns.AutoFit();
                _with1.Cells.Select();
                


            }
            catch
            {
                MessageBox.Show("Error");
            }

        }
    }
}
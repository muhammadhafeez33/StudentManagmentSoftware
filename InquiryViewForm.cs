using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace Lingo_Application
{
    public partial class InquiryViewForm : Main_Form
    {
        public InquiryViewForm()
        {
            InitializeComponent();
        }

        private void InquiryViewForm_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Inquiry_Table", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dataGridView1.DataSource = dt;


                SqlCommand cmd0 = new SqlCommand("select COUNT(Program) from Inquiry_Table where Program='Lingo'", con);
                int TotalInquiryLang = Convert.ToInt32(cmd0.ExecuteScalar());
                TotalInquiryLanguagelabel.Text = TotalInquiryLang.ToString();

                SqlCommand cmd1 = new SqlCommand("select COUNT(Program) from Inquiry_Table where Program='Lingo' and Pending_Done_Cencal='Pending'", con);
                int InquiryPendingLan = Convert.ToInt32(cmd1.ExecuteScalar());
                InquiryPendingLanguagelabel.Text = InquiryPendingLan.ToString();

                SqlCommand cmd2 = new SqlCommand("select COUNT(Program) from Inquiry_Table where Program='Lingo' and Pending_Done_Cencal='Done'", con);
                int InquiryDoneLan = Convert.ToInt32(cmd2.ExecuteScalar());
                InquiryDoneLanguagelabel.Text = InquiryDoneLan.ToString();

                SqlCommand cmd3 = new SqlCommand("select COUNT(Program) from Inquiry_Table where Program='Lingo' and Pending_Done_Cencal='Cancel'", con);
                int InquiryCancelLan = Convert.ToInt32(cmd3.ExecuteScalar());
                InquiryCancelLanguagelabel.Text = InquiryCancelLan.ToString();

                SqlCommand cmd4 = new SqlCommand("select COUNT(Program) from Inquiry_Table where Program='Computer'", con);
                int InquiryTotalComp = Convert.ToInt32(cmd4.ExecuteScalar());
                InquiryTotalComplabel.Text = InquiryTotalComp.ToString();

                SqlCommand cmd5 = new SqlCommand("select COUNT(Program) from Inquiry_Table where Program='Computer' and Pending_Done_Cencal='Pending'", con);
                int InquiryPedingComp = Convert.ToInt32(cmd5.ExecuteScalar());
                InquiryPendingComplabel.Text = InquiryPedingComp.ToString();

                SqlCommand cmd6 = new SqlCommand("select COUNT(Program) from Inquiry_Table where Program='Computer' and Pending_Done_Cencal='Done'", con);
                int InquiryDoneComp = Convert.ToInt32(cmd6.ExecuteScalar());
                InquiryDoneComplabel.Text = InquiryDoneComp.ToString();

                SqlCommand cmd7 = new SqlCommand("select COUNT(Program) from Inquiry_Table where Program='Computer' and Pending_Done_Cencal='Cancel'", con);
                int InquiryCancelComp = Convert.ToInt32(cmd7.ExecuteScalar());
                InquiryCancelComplabel.Text = InquiryCancelComp.ToString();

                SqlCommand cmd8 = new SqlCommand("select COUNT(Program) from Inquiry_Table where Program='Training'", con);
                int InquiryTotalTrain = Convert.ToInt32(cmd8.ExecuteScalar());
                InquiryTotalTrainlabel.Text = InquiryTotalTrain.ToString();

                SqlCommand cmd9 = new SqlCommand("select COUNT(Program) from Inquiry_Table where Program='Training' and Pending_Done_Cencal='Pending'", con);
                int InquiryPendingTrain = Convert.ToInt32(cmd9.ExecuteScalar());
                InquiryPendingTrainlabel.Text = InquiryPendingTrain.ToString();

                SqlCommand cmd10 = new SqlCommand("select COUNT(Program) from Inquiry_Table where Program='Training' and Pending_Done_Cencal='Done'", con);
                int InquiryDoneTrain = Convert.ToInt32(cmd10.ExecuteScalar());
                InquiryDoneTrainlabel.Text = InquiryDoneTrain.ToString();

                SqlCommand cmd11 = new SqlCommand("select COUNT(Program) from Inquiry_Table where Program='Training' and Pending_Done_Cencal='Cancel'", con);
                int InquiryCancelTrain = Convert.ToInt32(cmd11.ExecuteScalar());
                InquiryCancelTrainlabel.Text = InquiryCancelTrain.ToString();

                SqlCommand cmdImranTotal = new SqlCommand("select COUNT(Program) from Inquiry_Table where Program='Imran Yamin'", con);
                int InquiryImranTotal = Convert.ToInt32(cmdImranTotal.ExecuteScalar());
                ImranTotallabel.Text = InquiryImranTotal.ToString();

                SqlCommand cmdImranPending = new SqlCommand("select COUNT(Program) from Inquiry_Table where Program='Imran Yamin' and Pending_Done_Cencal='Pending'", con);
                int InquiryImranPending = Convert.ToInt32(cmdImranPending.ExecuteScalar());
                ImranPendinglabel41.Text = InquiryImranPending.ToString();

                SqlCommand cmdImranDone = new SqlCommand("select COUNT(Program) from Inquiry_Table where Program='Imran Yamin' and Pending_Done_Cencal='Done'", con);
                int InquiryImranDone = Convert.ToInt32(cmdImranDone.ExecuteScalar());
                ImranDonelabel40.Text = InquiryImranDone.ToString();

                SqlCommand cmdImranCancel = new SqlCommand("select COUNT(Program) from Inquiry_Table where Program='Imran Yamin' and Pending_Done_Cencal='Cancel'", con);
                int InquiryImranCancel = Convert.ToInt32(cmdImranCancel.ExecuteScalar());
                ImranCancellabel39.Text = InquiryImranCancel.ToString();

                int sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells["Expected_Fee"].Value != DBNull.Value)
                    {
                        sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["Expected_Fee"].Value);
                    }
                    TotalPendingExpectedlabel.Text = sum.ToString();
                }
            }
            catch
            {

            }
        }
        private void InquiryViewStudentNametextBox_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Inquiry_Table where Student_Name like'%" +InquirySearchingtextBox.Text + "%' or Attendant like'%" + InquirySearchingtextBox.Text + "%' or Program like'%" + InquirySearchingtextBox.Text + "%' or Course_Name like'%" + InquirySearchingtextBox.Text + "%' or Student_Name like'%" + InquirySearchingtextBox.Text + "%' or Phone like'%" + InquirySearchingtextBox.Text + "%' or Pending_Done_Cencal like'%" + InquirySearchingtextBox.Text + "%'", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView1.DataSource = dt;

            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["Expected_Fee"].Value != DBNull.Value)
                {
                    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["Expected_Fee"].Value);
                }
                TotalPendingExpectedlabel.Text = sum.ToString();
            }

            }

        
        private void TotalInquiryLanguagelabel_Click(object sender, EventArgs e)
        {

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
                    for (j = 0; j <= colsTotal; j++)
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

        private void StartdateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Inquiry_Table where Inquiry_Date between '"+StartdateTimePicker1.Text+"' and '"+EnddateTimePicker2.Text+"'", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView1.DataSource = dt;

            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["Expected_Fee"].Value != DBNull.Value)
                {
                    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["Expected_Fee"].Value);
                }
                TotalPendingExpectedlabel.Text = sum.ToString();
            }
        }

        private void EnddateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Inquiry_Table where Inquiry_Date between '" + StartdateTimePicker1.Text + "' and '" + EnddateTimePicker2.Text + "'", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView1.DataSource = dt;

            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["Expected_Fee"].Value != DBNull.Value)
                {
                    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["Expected_Fee"].Value);
                }
                TotalPendingExpectedlabel.Text = sum.ToString();
            }
        }
    }
}

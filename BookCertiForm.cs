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
    public partial class BookCertiForm : Main_Form
    {
        public BookCertiForm()
        {
            InitializeComponent();
        }

        private void BookCertiForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select SlipNo,Lingo$.Student_Id,CertificateNo,Lingo$.Student_Name,Lingo$.Father_Name,Lingo$.Program,BookOrCertificate,TotalAmount,DateOfIssue,MonthName,YearName from Lingo$ left join BookCertificate on Lingo$.Student_Id=BookCertificate.Student_Id", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sdaGrid = new SqlDataAdapter(cmd);
            DataTable dtGrid = new DataTable();
            sdaGrid.Fill(dtGrid);
            dataGridView1.DataSource = dtGrid;
            con.Close();

            int sumTotal = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["TotalAmount"].Value != DBNull.Value)
                {
                    sumTotal += Convert.ToInt32(dataGridView1.Rows[i].Cells["TotalAmount"].Value);
                }
                TotalAmountlabel.Text = sumTotal.ToString();
            }

        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (StudentIdtextBox.Text == "" && SlipNoextBox.Text == "")
                {
                    MessageBox.Show("Please enter the Student Id name and Slip No");
                }

                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into BookCertificate(SlipNo,Student_Id,CertificateNo,Student_Name,Father_Name,Program,BookOrCertificate,TotalAmount,DateOfIssue,MonthName,YearName)values('"+SlipNoextBox.Text+ "','"+StudentIdtextBox.Text+ "','"+CertificateNotextBox.Text+ "','"+StudentNametextBox.Text+ "','" + FatherNametextBox.Text + "','" + ProgramNametextBox.Text + "','" + BookCerttextBox.Text+ "','"+TotalAmounttextBox.Text+ "','"+IssuedateTimePicker.Text+ "','"+SelectMonthcomboBox.Text+ "','"+SelectYearcomboBox.Text+"')", con);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sdaGrid = new SqlDataAdapter("Select * from BookCertificate", con);
                    DataTable dtGrid = new DataTable();
                    sdaGrid.Fill(dtGrid);
                    dataGridView1.DataSource = dtGrid;
                    con.Close();
                    MessageBox.Show("Saved");

                    SlipNoextBox.Text = "";
                    StudentIdtextBox.Text = "";
                    CertificateNotextBox.Text = "";
                    StudentNametextBox.Text = "";
                    FatherNametextBox.Text = " ";
                    ProgramNametextBox.Text = "";
                    BookCerttextBox.Text = "";
                    TotalAmounttextBox.Text = "";
                    IssuedateTimePicker.Text = "";
                    SelectMonthcomboBox.Text = "";
                    SelectYearcomboBox.Text = "";

                    int sumTotal = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["TotalAmount"].Value != DBNull.Value)
                        {
                            sumTotal += Convert.ToInt32(dataGridView1.Rows[i].Cells["TotalAmount"].Value);
                        }
                        TotalAmountlabel.Text = sumTotal.ToString();
                    }
                }
            }
            catch
            {

                MessageBox.Show("Cant save");
            }
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
               if (StudentIdtextBox.Text == "" && SlipNoextBox.Text == "")
                {
                    MessageBox.Show("Please enter the Student Id name and Slip No");
                }

                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update BookCertificate set Student_Id='"+StudentIdtextBox.Text+ "',CertificateNo='"+CertificateNotextBox.Text+ "' ,Student_Name='"+StudentNametextBox.Text+ "',Father_Name='"+FatherNametextBox.Text+"',BookOrCertificate='" + BookCerttextBox.Text+ "' ,TotalAmount='"+TotalAmounttextBox.Text+ "' ,DateOfIssue='"+IssuedateTimePicker.Text+ "' ,MonthName='"+SelectMonthcomboBox.Text+ "' ,YearName='"+SelectYearcomboBox.Text+"' where SlipNo='"+SlipNoextBox.Text+"'", con);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sdaGrid = new SqlDataAdapter("Select * from BookCertificate", con);
                    DataTable dtGrid = new DataTable();
                    sdaGrid.Fill(dtGrid);
                    dataGridView1.DataSource = dtGrid;
                    con.Close();
                    MessageBox.Show("Updated");

                    SlipNoextBox.Text = "";
                    StudentIdtextBox.Text = "";
                    CertificateNotextBox.Text = "";
                    StudentNametextBox.Text = "";
                    FatherNametextBox.Text = " ";
                    ProgramNametextBox.Text = "";
                    BookCerttextBox.Text = "";
                    TotalAmounttextBox.Text = "";
                    IssuedateTimePicker.Text = "";
                    SelectMonthcomboBox.Text = "";
                    SelectYearcomboBox.Text = "";

                    int sumTotal = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["TotalAmount"].Value != DBNull.Value)
                        {
                            sumTotal += Convert.ToInt32(dataGridView1.Rows[i].Cells["TotalAmount"].Value);
                        }
                        TotalAmountlabel.Text = sumTotal.ToString();
                    }
                }
           }
            catch
            {

              MessageBox.Show("Cant Update");
            }
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {

            try
            {
                if (SlipNoextBox.Text == "")
                {
                    MessageBox.Show("Please enter the Slip No");
                }

                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete BookCertificate where SlipNo='" + SlipNoextBox.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sdaGrid = new SqlDataAdapter("Select * from BookCertificate", con);
                    DataTable dtGrid = new DataTable();
                    sdaGrid.Fill(dtGrid);
                    dataGridView1.DataSource = dtGrid;
                    con.Close();
                    MessageBox.Show("Deleted");

                    SlipNoextBox.Text = "";
                    StudentIdtextBox.Text = "";
                    CertificateNotextBox.Text = "";
                    StudentNametextBox.Text = "";
                    FatherNametextBox.Text = " ";
                    ProgramNametextBox.Text = "";
                    BookCerttextBox.Text = "";
                    TotalAmounttextBox.Text = "";
                    IssuedateTimePicker.Text = "";
                    SelectMonthcomboBox.Text = "";
                    SelectYearcomboBox.Text = "";

                    int sumTotal = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["TotalAmount"].Value != DBNull.Value)
                        {
                            sumTotal += Convert.ToInt32(dataGridView1.Rows[i].Cells["TotalAmount"].Value);
                        }
                        TotalAmountlabel.Text = sumTotal.ToString();
                    }
                }
            }
            catch
            {

                MessageBox.Show("Cant Delete");
            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            SlipNoextBox.Text = "";
            StudentIdtextBox.Text = "";
            StudentNametextBox.Text = "";
            CertificateNotextBox.Text = "";
            FatherNametextBox.Text = " ";
            ProgramNametextBox.Text = "";
            BookCerttextBox.Text = "";
            TotalAmounttextBox.Text = "";
            IssuedateTimePicker.Text = "";
            SelectMonthcomboBox.Text = "";
            SelectYearcomboBox.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    SlipNoextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["SlipNo"].FormattedValue.ToString();
                    StudentIdtextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Student_Id"].FormattedValue.ToString();
                    CertificateNotextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["CertificateNo"].FormattedValue.ToString();
                    StudentNametextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Student_Name"].FormattedValue.ToString();
                    FatherNametextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Father_Name"].FormattedValue.ToString();
                    ProgramNametextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Program"].FormattedValue.ToString();
                    BookCerttextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["BookOrCertificate"].FormattedValue.ToString();
                    TotalAmounttextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["TotalAmount"].FormattedValue.ToString();
                    IssuedateTimePicker.Text = dataGridView1.Rows[e.RowIndex].Cells["DateOfIssue"].FormattedValue.ToString();
                    SelectMonthcomboBox.Text = dataGridView1.Rows[e.RowIndex].Cells["MonthName"].FormattedValue.ToString();
                    SelectYearcomboBox.Text = dataGridView1.Rows[e.RowIndex].Cells["YearName"].FormattedValue.ToString();
                   
                }

            }

            catch
            {
               
            }
        }

        private void ShowAllbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from BookCertificate", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sdaGrid = new SqlDataAdapter(cmd);
            DataTable dtGrid = new DataTable();
            sdaGrid.Fill(dtGrid);
            dataGridView1.DataSource = dtGrid;
            con.Close();

            int sumTotal = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["TotalAmount"].Value != DBNull.Value)
                {
                    sumTotal += Convert.ToInt32(dataGridView1.Rows[i].Cells["TotalAmount"].Value);
                }
                TotalAmountlabel.Text = sumTotal.ToString();
            }
        }

        private void SearchingtextBox_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select SlipNo,Lingo$.Student_Id,CertificateNo,Lingo$.Student_Name,Lingo$.Father_Name,Lingo$.Program,BookOrCertificate,TotalAmount,DateOfIssue,MonthName,YearName from Lingo$ left join BookCertificate on Lingo$.Student_Id=BookCertificate.Student_Id where SlipNO like '%" + SearchingtextBox.Text+ "%' or BookCertificate.Student_Id like '%" + SearchingtextBox.Text + "%' or CertificateNo like '%" + SearchingtextBox.Text + "%' or Lingo$.Student_Name like '%" + SearchingtextBox.Text+ "%' or Lingo$.Father_Name like '%" + SearchingtextBox.Text + "%' or Lingo$.Program like '%" + SearchingtextBox.Text + "%' or BookOrCertificate like '%" + SearchingtextBox.Text + "%' or MonthName like '%" + SearchingtextBox.Text + "%' or YearName like '%" + SearchingtextBox.Text + "%'", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sdaGrid = new SqlDataAdapter(cmd);
            DataTable dtGrid = new DataTable();
            sdaGrid.Fill(dtGrid);
            dataGridView1.DataSource = dtGrid;
            con.Close();

            int sumTotal = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["TotalAmount"].Value != DBNull.Value)
                {
                    sumTotal += Convert.ToInt32(dataGridView1.Rows[i].Cells["TotalAmount"].Value);
                }
                TotalAmountlabel.Text = sumTotal.ToString();
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

        private void FiltercomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from BookCertificate where BookOrCertificate='" + FiltercomboBox.Text+"'", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sdaGrid = new SqlDataAdapter(cmd);
            DataTable dtGrid = new DataTable();
            sdaGrid.Fill(dtGrid);
            dataGridView1.DataSource = dtGrid;
            con.Close();

            int sumTotal = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["TotalAmount"].Value != DBNull.Value)
                {
                    sumTotal += Convert.ToInt32(dataGridView1.Rows[i].Cells["TotalAmount"].Value);
                }
                TotalAmountlabel.Text = sumTotal.ToString();
            }
        }

        private void StartdateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from BookCertificate where BookOrCertificate='" + FiltercomboBox.Text + "' and DateOfIssue between '"+StartdateTimePicker1.Text+ "' and '" + EnddateTimePicker2.Text + "'", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sdaGrid = new SqlDataAdapter(cmd);
            DataTable dtGrid = new DataTable();
            sdaGrid.Fill(dtGrid);
            dataGridView1.DataSource = dtGrid;
            con.Close();

            int sumTotal = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["TotalAmount"].Value != DBNull.Value)
                {
                    sumTotal += Convert.ToInt32(dataGridView1.Rows[i].Cells["TotalAmount"].Value);
                }
                TotalAmountlabel.Text = sumTotal.ToString();
            }
        }

        private void EnddateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from BookCertificate where BookOrCertificate='" + FiltercomboBox.Text + "' and DateOfIssue between '" + StartdateTimePicker1.Text + "' and '" + EnddateTimePicker2.Text + "'", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sdaGrid = new SqlDataAdapter(cmd);
            DataTable dtGrid = new DataTable();
            sdaGrid.Fill(dtGrid);
            dataGridView1.DataSource = dtGrid;
            con.Close();

            int sumTotal = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["TotalAmount"].Value != DBNull.Value)
                {
                    sumTotal += Convert.ToInt32(dataGridView1.Rows[i].Cells["TotalAmount"].Value);
                }
                TotalAmountlabel.Text = sumTotal.ToString();
            }
        }
    }
}

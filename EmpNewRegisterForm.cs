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
    public partial class EmpNewRegisterForm : Main_Form
    {
        public EmpNewRegisterForm()
        {
            InitializeComponent();
        }

        private void EmplSavebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpDesigtextBox.Text == "" && EmpNametextBox.Text == "")
                {
                    MessageBox.Show("Please enter the Employee name and designation");
                }

                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into EmplTable(EmployName,Designation,JoiningDate,MobileNo,WhatsApp)values('" + EmpNametextBox.Text + "','" + EmpDesigtextBox.Text + "','" + EmpJoinDateTimePicker.Text + "','" + EmpMobileNotextBox.Text + "','" + EmpWhatsaaptextBox.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sdaGrid = new SqlDataAdapter("select * from EmplTable", con);
                    DataTable dtGrid = new DataTable();
                    sdaGrid.Fill(dtGrid);
                    dataGridView1.DataSource = dtGrid;
                    con.Close();
                    MessageBox.Show("Saved");

                    EmpIdtextBox.Text = "";
                    EmpNametextBox.Text = "";
                    EmpDesigtextBox.Text = "";
                    EmpJoinDateTimePicker.CustomFormat = " ";
                    EmpMobileNotextBox.Text = "";
                    EmpWhatsaaptextBox.Text = "";
                    EmpWhatsaaptextBox.Text = "";
               }
            }
            catch
            {

                MessageBox.Show("Employee Id Already Saved");
            }

        }

        private void EmpNewRegisterForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from EmplTable", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;

        }

        private void EmpJoinDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            EmpJoinDateTimePicker.CustomFormat = "dd-MMM-yyy";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmpIdtextBox.Text = "";
            EmpNametextBox.Text = "";
            EmpDesigtextBox.Text = "";
            EmpJoinDateTimePicker.CustomFormat = " ";
            EmpMobileNotextBox.Text = "";
            EmpWhatsaaptextBox.Text = "";
            EmpWhatsaaptextBox.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;
                    EmpIdtextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
                    EmpNametextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["EmployName"].FormattedValue.ToString();
                    EmpDesigtextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Designation"].FormattedValue.ToString();
                    EmpJoinDateTimePicker.Text = dataGridView1.Rows[e.RowIndex].Cells["JoiningDate"].FormattedValue.ToString();
                    EmpMobileNotextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["MobileNo"].FormattedValue.ToString();
                    EmpWhatsaaptextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["WhatsApp"].FormattedValue.ToString();
                }


            }
            catch
            {
                MessageBox.Show("Click on any cell not Column");
            }
        }

        private void EmplUpdatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpDesigtextBox.Text == "" && EmpNametextBox.Text == "")
                {
                    MessageBox.Show("Please enter the Employee name and designation");
                }

                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update EmplTable set EmployName='"+EmpNametextBox.Text+ "' , Designation='"+EmpDesigtextBox.Text+ "' , JoiningDate='"+EmpJoinDateTimePicker.Text+ "' , MobileNo='"+EmpMobileNotextBox.Text+ "' , WhatsApp='"+EmpWhatsaaptextBox.Text+ "' where Id='"+EmpIdtextBox.Text+"'", con);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sdaGrid = new SqlDataAdapter("select * from EmplTable where Id='"+EmpIdtextBox.Text+"'", con);
                    DataTable dtGrid = new DataTable();
                    sdaGrid.Fill(dtGrid);
                    dataGridView1.DataSource = dtGrid;
                    con.Close();
                    MessageBox.Show("Updated");

                
                }
            }
            catch
            {

                MessageBox.Show("Not Update");
            }
        }

        private void EmpDeletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpDesigtextBox.Text == "" && EmpNametextBox.Text == "")
                {
                    MessageBox.Show("Please enter the Employee name and designation");
                }

                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete EmplTable  where Id='" + EmpIdtextBox.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sdaGrid = new SqlDataAdapter("select * from EmplTable", con);
                    DataTable dtGrid = new DataTable();
                    sdaGrid.Fill(dtGrid);
                    dataGridView1.DataSource = dtGrid;
                    con.Close();
                    MessageBox.Show("Deleted");

                    EmpIdtextBox.Text = "";
                    EmpNametextBox.Text = "";
                    EmpDesigtextBox.Text = "";
                    EmpJoinDateTimePicker.CustomFormat = " ";
                    EmpMobileNotextBox.Text = "";
                    EmpWhatsaaptextBox.Text = "";
                    EmpWhatsaaptextBox.Text = "";

                }
            }
            catch
            {

                MessageBox.Show("Not delete");
            }
        }

        private void EmpMobileNotextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                EmpWhatsaaptextBox.Text = EmpMobileNotextBox.Text;
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
    }
}

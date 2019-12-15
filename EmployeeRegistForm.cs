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
    public partial class EmployeeRegistForm : Main_Form
    {
        public EmployeeRegistForm()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void EmployeeRegistForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select EmplTable.Id,EmployId,EmployName,SalaryMonth,SalaryYear,EmployRevenue,Perc,EmplSalary,WorkingDays,SalaryPerday,Leave,DeductionSalary,AdvanceSalary,OtherDeduction,Allowance,NerSalary,SalaryDate from EmplTable left join EmployeeSalary on EmplTable.Id=EmployeeSalary.EmployId", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;


           
            con.Open();
            SqlCommand cmd2 = new SqlCommand("select FeeMonth from StudentFee group by FeeMonth", con);
            cmd2.ExecuteNonQuery();
            SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);

            foreach (DataRow dr in dt2.Rows)
            {
                EmplSalaryMonthcomboBox.Items.Add(dr[0]);

            }

            con.Close();

            con.Open();
            SqlCommand cmd3 = new SqlCommand("select Year from StudentFee group by Year", con);
            cmd3.ExecuteNonQuery();
            SqlDataAdapter sda3 = new SqlDataAdapter(cmd3);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);

            foreach (DataRow dr in dt3.Rows)
            {
                EmpSalaryYearcomboBox.Items.Add(dr[0]);

            }

            con.Close();

            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["NerSalary"].Value != DBNull.Value)
                {
                    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["NerSalary"].Value);
                }
                TotalSalarylabel.Text = sum.ToString();
            }


        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            EmpSalaryDatedateTimePicker.CustomFormat = "dd-MMM-yyy";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;
                    EmpIdtextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
                    SalEmpNametextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["EmployName"].FormattedValue.ToString();
                    //EmplSalaryMonthcomboBox.Text = dataGridView1.Rows[e.RowIndex].Cells["SalaryMonth"].FormattedValue.ToString();
                    //EmpSalaryYearcomboBox.Text = dataGridView1.Rows[e.RowIndex].Cells["SalaryYear"].FormattedValue.ToString();
                    //EmpRevenuetextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["EmployRevenue"].FormattedValue.ToString();
                    //EmpPerctextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Perc"].FormattedValue.ToString();
                    //EmpPreviousSalarytextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["EmplSalary"].FormattedValue.ToString();
                    //EmpWorkingDaystextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["WorkingDays"].FormattedValue.ToString();
                    //EmpPerDaySalarytextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["SalaryPerday"].FormattedValue.ToString();
                    //EmpLeavetextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Leave"].FormattedValue.ToString();
                    //EmpDeductionSalarytextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["DeductionSalary"].FormattedValue.ToString();
                    //EmpAdvanceSalarytextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["AdvanceSalary"].FormattedValue.ToString();
                    //OtherDeductiontextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["OtherDeduction"].FormattedValue.ToString();
                    //AllowancetextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Allowance"].FormattedValue.ToString();
                    //EmpNetSalarytextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["NerSalary"].FormattedValue.ToString();
                    //EmpSalaryDatedateTimePicker.Text = dataGridView1.Rows[e.RowIndex].Cells["SalaryDate"].FormattedValue.ToString();

                    EmplSalaryMonthcomboBox.Text = "";
                    EmpSalaryYearcomboBox.Text = "";
                    EmpRevenuetextBox.Text = "0";
                    EmpPerctextBox.Text = "0";
                    EmpPreviousSalarytextBox.Text = "0";
                    EmpWorkingDaystextBox.Text = "0";
                    EmpPerDaySalarytextBox.Text = "0";
                    EmpLeavetextBox.Text = "0";
                    EmpDeductionSalarytextBox.Text = "0";
                    EmpAdvanceSalarytextBox.Text = "0";
                    OtherDeductiontextBox.Text = "0";
                    AllowancetextBox.Text = "0";
                    EmpNetSalarytextBox.Text = "0";
                    EmpSalaryDatedateTimePicker.Text = "";




                }

                

            }
            catch
            {
               MessageBox.Show("Click on any cell not Column");
            }
        }

        private void EmplSalaryMonthcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select sum(MonthlyFee) from Lingo$ left join StudentFee on Lingo$.Student_Id=StudentFee.AdmissionId where Teacher='" + SalEmpNametextBox.Text+"' and FeeMonth='"+EmplSalaryMonthcomboBox.Text+"'", con);
                int RevenueSalary = Convert.ToInt32(cmd.ExecuteScalar());
                EmpRevenuetextBox.Text = RevenueSalary.ToString();
                con.Close();
            }

            catch
            {
                MessageBox.Show("Salary not avaible due to Unpaid Student");
            }




        }

        private void EmpPerctextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (EmpPerctextBox.Text.Length > 0)
                {

                    EmpPreviousSalarytextBox.Text = (Convert.ToInt32(EmpRevenuetextBox.Text) * Convert.ToInt32(EmpPerctextBox.Text) / 100).ToString();

                }
            }
            catch
            {
                MessageBox.Show("Enter Only Digit Number.");
            }
        }

        private void EmpAdvanceSalarytextBox_TextChanged(object sender, EventArgs e)
        {
            try { 
            if (EmpAdvanceSalarytextBox.Text.Length > 0)
            {
                    EmpNetSalarytextBox.Text = (Convert.ToInt32(EmpPreviousSalarytextBox.Text) - Convert.ToInt32(EmpDeductionSalarytextBox.Text) - Convert.ToInt32(EmpAdvanceSalarytextBox.Text) - Convert.ToInt32(OtherDeductiontextBox.Text) + Convert.ToInt32(AllowancetextBox.Text)).ToString();
                }

            }
            catch
            {
                MessageBox.Show("Enter Only Digit Number.");
            }
        }

        private void EmpSalaryYearcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select sum(MonthlyFee) from Lingo$ left join StudentFee on Lingo$.Student_Id=StudentFee.AdmissionId where Teacher='" + SalEmpNametextBox.Text + "' and FeeMonth='" + EmplSalaryMonthcomboBox.Text + "' and Year='"+EmpSalaryYearcomboBox.Text+"'", con);
                int RevenueSalary = Convert.ToInt32(cmd.ExecuteScalar());
                EmpRevenuetextBox.Text = RevenueSalary.ToString();
            }

            catch
            {
               MessageBox.Show("Salary not avaible due to Unpaid Student");
            }
        }

        private void EmpNametextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select sum(MonthlyFee) from Lingo$ left join StudentFee on Lingo$.Student_Id=StudentFee.AdmissionId where Teacher='"+SalEmpNametextBox.Text+"'", con);
                int RevenueSalary = Convert.ToInt32(cmd.ExecuteScalar());
                EmpRevenuetextBox.Text = RevenueSalary.ToString();
            }

            catch
            {
               
            }
        }

        private void EmpRevenuetextBox_TextChanged(object sender, EventArgs e)
        {
            try { 
            if (EmpRevenuetextBox.Text.Length > 0)
            {

                EmpPreviousSalarytextBox.Text = (Convert.ToInt32(EmpRevenuetextBox.Text) * Convert.ToInt32(EmpPerctextBox.Text) / 100).ToString();

            }
            }
            catch
            {
                MessageBox.Show("Enter Only Digit Number.");
            }
        }

        private void EmpPreviousSalarytextBox_TextChanged(object sender, EventArgs e)
        {
            try { 

            if (EmpPreviousSalarytextBox.Text.Length > 0)
            {
                EmpNetSalarytextBox.Text = (Convert.ToInt32(EmpPreviousSalarytextBox.Text) - Convert.ToInt32(EmpAdvanceSalarytextBox.Text)).ToString();
            }

            }
            catch
            {
                MessageBox.Show("Enter Only Digit Number.");
            }
        }

        private void EmpWorkingDaystextBox_TextChanged(object sender, EventArgs e)
        {

            try
            {

                if (EmpWorkingDaystextBox.Text.Length > 0)
                {
                   EmpPerDaySalarytextBox.Text = (Convert.ToInt32(EmpPreviousSalarytextBox.Text) / Convert.ToInt32(EmpWorkingDaystextBox.Text)).ToString();
               }
 
            }
            catch
            {
                MessageBox.Show("Enter Only Digit Number.");
            }


        }

        private void EmpLeavetextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (EmpLeavetextBox.Text.Length > 0)
                {
                    EmpDeductionSalarytextBox.Text = (Convert.ToInt32(EmpPerDaySalarytextBox.Text) * Convert.ToInt32(EmpLeavetextBox.Text)).ToString();
                }

            }
            catch
            {
                MessageBox.Show("Enter Only Digit Number.");
            }
        }

        private void EmpPerDaySalarytextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (EmpLeavetextBox.Text.Length > 0)
            {
                EmpDeductionSalarytextBox.Text = (Convert.ToInt32(EmpPerDaySalarytextBox.Text) * Convert.ToInt32(EmpLeavetextBox.Text)).ToString();
            }

            }
            catch
            {
                MessageBox.Show("Enter Only Digit Number.");
            }
        }

        private void EmpDeductionSalarytextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (EmpDeductionSalarytextBox.Text.Length > 0)
                {
                    EmpNetSalarytextBox.Text = (Convert.ToInt32(EmpPreviousSalarytextBox.Text) - Convert.ToInt32(EmpDeductionSalarytextBox.Text) - Convert.ToInt32(EmpAdvanceSalarytextBox.Text) - Convert.ToInt32(OtherDeductiontextBox.Text) + Convert.ToInt32(AllowancetextBox.Text)).ToString();
                }

            }
            catch
            {
                MessageBox.Show("Enter Only Digit Number.");
            }
        }

        private void OtherDeductiontextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (OtherDeductiontextBox.Text.Length > 0)
                {
                    EmpNetSalarytextBox.Text = (Convert.ToInt32(EmpPreviousSalarytextBox.Text) - Convert.ToInt32(EmpDeductionSalarytextBox.Text) - Convert.ToInt32(EmpAdvanceSalarytextBox.Text) - Convert.ToInt32(OtherDeductiontextBox.Text) + Convert.ToInt32(AllowancetextBox.Text)).ToString();
                }

            }
            catch
            {
                MessageBox.Show("Enter Only Digit Number.");
            }
        }

        private void AllowancetextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (AllowancetextBox.Text.Length > 0)
                {
                    EmpNetSalarytextBox.Text = (Convert.ToInt32(EmpPreviousSalarytextBox.Text) - Convert.ToInt32(EmpDeductionSalarytextBox.Text) - Convert.ToInt32(EmpAdvanceSalarytextBox.Text) - Convert.ToInt32(OtherDeductiontextBox.Text) + Convert.ToInt32(AllowancetextBox.Text)).ToString();
                }

            }
            catch
            {
                MessageBox.Show("Enter Only Digit Number.");
            }
        }

        private void EmplSavebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SalEmpNametextBox.Text == "" && EmpSalaryDatedateTimePicker.Text=="")
                {
                    MessageBox.Show("Enter the employee name and salary date ");
                }

                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into EmployeeSalary(EmployId,SalaryMonth,SalaryYear,EmployRevenue,Perc,EmplSalary,WorkingDays,SalaryPerday,Leave,DeductionSalary,AdvanceSalary,OtherDeduction,Allowance,NerSalary,SalaryDate)values('"+EmpIdtextBox.Text+ "','"+EmplSalaryMonthcomboBox.Text+ "','"+EmpSalaryYearcomboBox.Text+ "','"+EmpRevenuetextBox.Text+ "','"+EmpPerctextBox.Text+ "','"+EmpPreviousSalarytextBox.Text+ "','"+EmpWorkingDaystextBox.Text+ "','"+EmpPerDaySalarytextBox.Text+ "','"+EmpLeavetextBox.Text+ "','"+EmpDeductionSalarytextBox.Text+ "','"+EmpAdvanceSalarytextBox.Text+ "','"+OtherDeductiontextBox.Text+ "','"+AllowancetextBox.Text+ "','"+EmpNetSalarytextBox.Text+ "','"+EmpSalaryDatedateTimePicker.Text+"')", con);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sdaGrid = new SqlDataAdapter("select EmplTable.Id,EmployeeSalary.Id,EmployId,EmployName,SalaryMonth,SalaryYear,EmployRevenue,Perc,EmplSalary,WorkingDays,SalaryPerday,Leave,DeductionSalary,AdvanceSalary,OtherDeduction,Allowance,NerSalary,SalaryDate from EmplTable left join EmployeeSalary on EmplTable.Id=EmployeeSalary.EmployId", con);
                    DataTable dtGrid = new DataTable();
                    sdaGrid.Fill(dtGrid);
                    dataGridView1.DataSource = dtGrid;
                    con.Close();
                    MessageBox.Show("Saved");


                    EmpIdtextBox.Text = "";
                    SalEmpNametextBox.Text = "";
                    EmplSalaryMonthcomboBox.Text = "";
                    EmpSalaryYearcomboBox.Text = "";
                    EmpRevenuetextBox.Text = "0";
                    EmpPerctextBox.Text = "0";
                    EmpPreviousSalarytextBox.Text = "0";
                    EmpWorkingDaystextBox.Text = "0";
                    EmpPerDaySalarytextBox.Text = "0";
                    EmpLeavetextBox.Text = "0";
                    EmpDeductionSalarytextBox.Text = "0";
                    EmpAdvanceSalarytextBox.Text = "0";
                    OtherDeductiontextBox.Text = "0";
                    AllowancetextBox.Text = "0";
                    EmpNetSalarytextBox.Text = "0";
                    EmpSalaryDatedateTimePicker.Text = "";

                    int sum = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["NerSalary"].Value != DBNull.Value)
                        {
                            sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["NerSalary"].Value);
                        }
                        TotalSalarylabel.Text = sum.ToString();
                    }


                }
            }
            catch
            {

                MessageBox.Show("Cant Save");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void EmplUpdatebutton_Click(object sender, EventArgs e)
        {
           
        }

        private void EmpDeletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmplSalaryMonthcomboBox.Text=="" && EmpSalaryYearcomboBox.Text=="")
                {
                    MessageBox.Show("select month and year then delete");
                }

                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete EmployeeSalary where EmployId='" + EmpIdtextBox.Text + "' and SalaryMonth='" + EmplSalaryMonthcomboBox.Text + "' and SalaryYear='" + EmpSalaryYearcomboBox.Text + "' ", con);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sdaGrid = new SqlDataAdapter("select EmplTable.Id,EmployeeSalary.Id,EmployId,EmployName,SalaryMonth,SalaryYear,EmployRevenue,Perc,EmplSalary,WorkingDays,SalaryPerday,Leave,DeductionSalary,AdvanceSalary,OtherDeduction,Allowance,NerSalary,SalaryDate from EmplTable left join EmployeeSalary on EmplTable.Id=EmployeeSalary.EmployId", con);
                    DataTable dtGrid = new DataTable();
                    sdaGrid.Fill(dtGrid);
                    dataGridView1.DataSource = dtGrid;
                    con.Close();
                    MessageBox.Show("Deleted");

                    EmpIdtextBox.Text = "";
                    SalEmpNametextBox.Text = "";
                    EmplSalaryMonthcomboBox.Text = "";
                    EmpSalaryYearcomboBox.Text = "";
                    EmpRevenuetextBox.Text = "0";
                    EmpPerctextBox.Text = "0";
                    EmpPreviousSalarytextBox.Text = "0";
                    EmpWorkingDaystextBox.Text = "0";
                    EmpPerDaySalarytextBox.Text = "0";
                    EmpLeavetextBox.Text = "0";
                    EmpDeductionSalarytextBox.Text = "0";
                    EmpAdvanceSalarytextBox.Text = "0";
                    OtherDeductiontextBox.Text = "0";
                    AllowancetextBox.Text = "0";
                    EmpNetSalarytextBox.Text = "0";
                    EmpSalaryDatedateTimePicker.Text = "";

                    int sum = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["NerSalary"].Value != DBNull.Value)
                        {
                            sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["NerSalary"].Value);
                        }
                        TotalSalarylabel.Text = sum.ToString();
                    }


                }
            }
            catch
            {
                MessageBox.Show("cant Delete");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select EmplTable.Id,EmployeeSalary.Id,EmployId,EmployName,SalaryMonth,SalaryYear,EmployRevenue,Perc,EmplSalary,WorkingDays,SalaryPerday,Leave,DeductionSalary,AdvanceSalary,OtherDeduction,Allowance,NerSalary,SalaryDate from EmplTable left join EmployeeSalary on EmplTable.Id=EmployeeSalary.EmployId where EmployName like'%" + textBox1.Text+"%' or SalaryMonth like '%"+ textBox1.Text + "%'", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;

            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["NerSalary"].Value != DBNull.Value)
                {
                    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["NerSalary"].Value);
                }
                TotalSalarylabel.Text = sum.ToString();
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

        private void StartdateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            StartdateTimePicker2.CustomFormat = "dd-MMM-yyy";

            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select EmplTable.Id,EmployId,EmployName,SalaryMonth,SalaryYear,EmployRevenue,Perc,EmplSalary,WorkingDays,SalaryPerday,Leave,DeductionSalary,AdvanceSalary,OtherDeduction,Allowance,NerSalary,SalaryDate from EmplTable left join EmployeeSalary on EmplTable.Id=EmployeeSalary.EmployId where SalaryDate between '"+StartdateTimePicker2.Text+"' and '"+EnddateTimePicker1.Text+"'", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;

            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["NerSalary"].Value != DBNull.Value)
                {
                    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["NerSalary"].Value);
                }
                TotalSalarylabel.Text = sum.ToString();
            }
        }

        private void EnddateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           EnddateTimePicker1.CustomFormat = "dd-MMM-yyy";

            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select EmplTable.Id,EmployId,EmployName,SalaryMonth,SalaryYear,EmployRevenue,Perc,EmplSalary,WorkingDays,SalaryPerday,Leave,DeductionSalary,AdvanceSalary,OtherDeduction,Allowance,NerSalary,SalaryDate from EmplTable left join EmployeeSalary on EmplTable.Id=EmployeeSalary.EmployId where SalaryDate between '" + StartdateTimePicker2.Text + "' and '" + EnddateTimePicker1.Text + "'", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;

            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["NerSalary"].Value != DBNull.Value)
                {
                    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["NerSalary"].Value);
                }
                TotalSalarylabel.Text = sum.ToString();
            }
        }
    }
}

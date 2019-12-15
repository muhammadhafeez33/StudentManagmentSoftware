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
    public partial class ProftOrLossForm : Main_Form
    {
        public ProftOrLossForm()
        {
            InitializeComponent();
        }

        private void ExpFromdateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ExpFromdateTimePicker.CustomFormat = "dd-MMM-yyy";

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select Sum(TotalFee) from StudentFee where PaymentDate between '" + ExpFromdateTimePicker.Text + "' and '" + ExpTodateTimePicker.Text + "'", con);
                int TotalIncome = Convert.ToInt32(cmd.ExecuteScalar());
                DateIncometextBox.Text = TotalIncome.ToString();
                con.Close();
            }
            catch
            {
                DateIncometextBox.Text = "0";

            }

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select Sum(TotalAmount) from BookCertificate where DateOfIssue between '" + ExpFromdateTimePicker.Text + "' and '" + ExpTodateTimePicker.Text + "'", con);
                int TotalIncome = Convert.ToInt32(cmd.ExecuteScalar());
                DailyBookCertificatetextBox.Text = TotalIncome.ToString();
                con.Close();
            }
            catch
            {
                DailyBookCertificatetextBox.Text = "0";

            }

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmdExp = new SqlCommand("select Sum(TotalExpense) from Expense where [Date] between '" + ExpFromdateTimePicker.Text + "' and '" + ExpTodateTimePicker.Text + "'", con);
                int TotalExp = Convert.ToInt32(cmdExp.ExecuteScalar());
                DateExpensetextBox.Text = TotalExp.ToString();
                con.Close();
            }

            catch
            {
                DateExpensetextBox.Text = "0";

            }
        }

        private void ExpTodateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ExpTodateTimePicker.CustomFormat= "dd-MMM-yyy";
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select Sum(TotalFee) from StudentFee where PaymentDate between '" + ExpFromdateTimePicker.Text + "' and '" + ExpTodateTimePicker.Text + "'", con);
                int TotalIncome = Convert.ToInt32(cmd.ExecuteScalar());
                DateIncometextBox.Text = TotalIncome.ToString();
                con.Close();
            }
            catch
            {
                DateIncometextBox.Text = "0";

            }

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select Sum(TotalAmount) from BookCertificate where DateOfIssue between '" + ExpFromdateTimePicker.Text + "' and '" + ExpTodateTimePicker.Text + "'", con);
                int TotalIncome = Convert.ToInt32(cmd.ExecuteScalar());
                DailyBookCertificatetextBox.Text = TotalIncome.ToString();
                con.Close();
            }
            catch
            {
                DailyBookCertificatetextBox.Text = "0";

            }


            try
            { 
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmdExp = new SqlCommand("select Sum(TotalExpense) from Expense where [Date] between '" + ExpFromdateTimePicker.Text + "' and '" + ExpTodateTimePicker.Text + "'", con);
            int TotalExp = Convert.ToInt32(cmdExp.ExecuteScalar());
            DateExpensetextBox.Text = TotalExp.ToString();
            con.Close();
            }

            catch
            {
               DateExpensetextBox.Text = "0";

            }

        }

        private void DateIncometextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (DateIncometextBox.TextLength > 0)
                {
                    DateBalancetextBox.Text = (Convert.ToInt32(DateIncometextBox.Text)+ Convert.ToInt32(DailyBookCertificatetextBox.Text) - Convert.ToInt32(DateExpensetextBox.Text)).ToString();
                }

                if (Convert.ToInt32(DateBalancetextBox.Text) >= 0)
                {
                    ProfitOrLosstextBox.Text = "Profit";
                }
                else
                {
                    ProfitOrLosstextBox.Text = "Loss";
                }
            }
            catch
            {
            }
        }

        private void DateExpensetextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (DateExpensetextBox.TextLength > 0)
                {
                    DateBalancetextBox.Text = (Convert.ToInt32(DateIncometextBox.Text) + Convert.ToInt32(DailyBookCertificatetextBox.Text) - Convert.ToInt32(DateExpensetextBox.Text)).ToString();
                }

                if (Convert.ToInt32(DateBalancetextBox.Text) >= 0)
                {
                    ProfitOrLosstextBox.Text = "Profit";
                }
                else
                {
                    ProfitOrLosstextBox.Text = "Loss";
                }
            }
            catch
            {
            }
        }

        private void DateBalancetextBox_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(DateBalancetextBox.Text) >= 0)
            {
                ProfitOrLosstextBox.Text = "Profit";
            }
            else
            {
                ProfitOrLosstextBox.Text = "Loss";
            }
        }

        private void ProftOrLossForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmd3 = new SqlCommand("select Year from StudentFee group by Year", con);
            cmd3.ExecuteNonQuery();
            SqlDataAdapter sda3 = new SqlDataAdapter(cmd3);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);

            foreach (DataRow dr in dt3.Rows)
            {
                BalanceSelectYearcomboBox.Items.Add(dr[0]);

            }

            con.Close();

            con.Open();
            SqlCommand cmdBalance = new SqlCommand("select * from BalanceSheet", con);
            cmdBalance.ExecuteNonQuery();
            SqlDataAdapter sdaBalance = new SqlDataAdapter(cmdBalance);
            DataTable dtBalance = new DataTable();
            sdaBalance.Fill(dtBalance);
            con.Close();
            dataGridView1.DataSource = dtBalance;
        }

        private void MonthlyIncometextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (MonthlyIncometextBox.TextLength > 0)
                {
                    MonthlyBalancetextBox.Text = (Convert.ToInt32(MonthlyIncometextBox.Text) + Convert.ToInt32(MonthlyBookOrCertitextBox.Text) - Convert.ToInt32(MonthlyExpensetextBox.Text)- Convert.ToInt32(MonthlySalaryExptextBox.Text)).ToString();
                }

                if (Convert.ToInt32(MonthlyBalancetextBox.Text) >= 0)
                {
                    MonthlyProfitOrlosstextBox.Text = "Profit";
                }
                else
                {
                    MonthlyProfitOrlosstextBox.Text = "Loss";
                }
            }
            catch
            {
            }
        }

        private void MonthlyExpensetextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (MonthlyExpensetextBox.TextLength > 0)
                {
                    MonthlyBalancetextBox.Text = (Convert.ToInt32(MonthlyIncometextBox.Text) + Convert.ToInt32(MonthlyBookOrCertitextBox.Text) - Convert.ToInt32(MonthlyExpensetextBox.Text) - Convert.ToInt32(MonthlySalaryExptextBox.Text)).ToString();
                }

                if (Convert.ToInt32(MonthlyBalancetextBox.Text) >= 0)
                {
                    MonthlyProfitOrlosstextBox.Text = "Profit";
                }
                else
                {
                    MonthlyProfitOrlosstextBox.Text = "Loss";
                }
            }
            catch
            {
            }
        }

        private void MonthlySalaryExptextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (MonthlySalaryExptextBox.TextLength > 0)
                {
                    MonthlyBalancetextBox.Text = (Convert.ToInt32(MonthlyIncometextBox.Text) + Convert.ToInt32(MonthlyBookOrCertitextBox.Text) - Convert.ToInt32(MonthlyExpensetextBox.Text) - Convert.ToInt32(MonthlySalaryExptextBox.Text)).ToString();
                }

                if (Convert.ToInt32(MonthlyBalancetextBox.Text) >= 0)
                {
                    MonthlyProfitOrlosstextBox.Text = "Profit";
                }
                else
                {
                    MonthlyProfitOrlosstextBox.Text = "Loss";
                }
            }
            catch
            {
            }
        }

        private void MonthlyBalancetextBox_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(MonthlyBalancetextBox.Text) >= 0)
            {
                MonthlyProfitOrlosstextBox.Text = "Profit";
            }
            else
            {
                MonthlyProfitOrlosstextBox.Text = "Loss";
            }
        }

        private void BalanceSelectMonthcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select Sum(TotalFee) from StudentFee where FeeMonth='"+BalanceSelectMonthcomboBox.Text+"'", con);
                int TotalIncome = Convert.ToInt32(cmd.ExecuteScalar());
                MonthlyIncometextBox.Text = TotalIncome.ToString();
                con.Close();
            }
            catch
            {
                MonthlyIncometextBox.Text = "0";

            }

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select Sum(TotalAmount) from BookCertificate where MonthName='" + BalanceSelectMonthcomboBox.Text + "'", con);
                int TotalIncome = Convert.ToInt32(cmd.ExecuteScalar());
                MonthlyBookOrCertitextBox.Text = TotalIncome.ToString();
                con.Close();
            }
            catch
            {
                MonthlyBookOrCertitextBox.Text = "0";

            }

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmdExp = new SqlCommand("select Sum(TotalExpense) from Expense where ExpMonth='" + BalanceSelectMonthcomboBox.Text + "'", con);
                int TotalExp = Convert.ToInt32(cmdExp.ExecuteScalar());
                MonthlyExpensetextBox.Text = TotalExp.ToString();
                con.Close();
            }

            catch
            {
                MonthlyExpensetextBox.Text = "0";

            }

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmdExp = new SqlCommand("select SUM(NerSalary) from EmployeeSalary where SalaryMonth='"+BalanceSelectMonthcomboBox.Text+"'", con);
                int TotalExp = Convert.ToInt32(cmdExp.ExecuteScalar());
                MonthlySalaryExptextBox.Text = TotalExp.ToString();
                con.Close();
            }

            catch
            {
                MonthlySalaryExptextBox.Text = "0";

            }
        }

        private void BalanceSelectYearcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select Sum(TotalFee) from StudentFee where FeeMonth='" + BalanceSelectMonthcomboBox.Text + "' and Year='"+BalanceSelectYearcomboBox.Text+"'", con);
                int TotalIncome = Convert.ToInt32(cmd.ExecuteScalar());
                MonthlyIncometextBox.Text = TotalIncome.ToString();
                con.Close();
            }
            catch
            {
                MonthlyIncometextBox.Text = "0";

            }

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select Sum(TotalAmount) from BookCertificate where MonthName='" + BalanceSelectMonthcomboBox.Text + "' and YearName='" + BalanceSelectYearcomboBox.Text + "'", con);
                int TotalIncome = Convert.ToInt32(cmd.ExecuteScalar());
                MonthlyBookOrCertitextBox.Text = TotalIncome.ToString();
                con.Close();
            }
            catch
            {
                MonthlyBookOrCertitextBox.Text = "0";

            }

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmdExp = new SqlCommand("select Sum(TotalExpense) from Expense where ExpMonth='" + BalanceSelectMonthcomboBox.Text + "' and ExpYear='"+BalanceSelectYearcomboBox.Text+"'", con);
                int TotalExp = Convert.ToInt32(cmdExp.ExecuteScalar());
                MonthlyExpensetextBox.Text = TotalExp.ToString();
                con.Close();
            }

            catch
            {
                MonthlyExpensetextBox.Text = "0";

            }

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmdExp = new SqlCommand("select SUM(NerSalary) from EmployeeSalary where SalaryMonth='" + BalanceSelectMonthcomboBox.Text + "'and SalaryYear='"+BalanceSelectYearcomboBox.Text+"'", con);
                int TotalExp = Convert.ToInt32(cmdExp.ExecuteScalar());
                MonthlySalaryExptextBox.Text = TotalExp.ToString();
                con.Close();
            }

            catch
            {
                MonthlySalaryExptextBox.Text = "0";

            }
        }
        //save button
        private void button5_Click(object sender, EventArgs e)
        {
            if (BalanceSelectMonthcomboBox.Text == "" && BalanceSelectYearcomboBox.Text == "")
            {
                MessageBox.Show("select month and year");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into BalanceSheet(MonthName,YearName,Income,BookOrCertiIncome,Expense,SalaryExpense,Balance,ProfitOrLoss)values('" + BalanceSelectMonthcomboBox.Text + "','" + BalanceSelectYearcomboBox.Text + "','" + MonthlyIncometextBox.Text + "','"+MonthlyBookOrCertitextBox.Text+"','" + MonthlyExpensetextBox.Text + "','" + MonthlySalaryExptextBox.Text + "','" + MonthlyBalancetextBox.Text + "','" + MonthlyProfitOrlosstextBox.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sdaGrid = new SqlDataAdapter("select * from BalanceSheet", con);
                    DataTable dtGrid = new DataTable();
                    sdaGrid.Fill(dtGrid);
                    dataGridView1.DataSource = dtGrid;
                    con.Close();
                    MessageBox.Show("Saved");

                    BalanceSelectMonthcomboBox.Text = "";
                    BalanceSelectYearcomboBox.Text = "";
                    MonthlyIncometextBox.Text = "0";
                    MonthlyExpensetextBox.Text = "0";
                    MonthlySalaryExptextBox.Text = "0";
                    MonthlyBalancetextBox.Text = "0";
                    MonthlyProfitOrlosstextBox.Text = "";
                    MonthlyBookOrCertitextBox.Text = "0";

                }

                catch
                {
                    MessageBox.Show("Can't Save");
                }
            }
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (BalanceSelectMonthcomboBox.Text == "" && BalanceSelectYearcomboBox.Text == "")
            {
                MessageBox.Show("select month and year");
            }
            else
            { 
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("delete BalanceSheet where Id='"+ProfitOrLossIdtextBox.Text+"' and MonthName='"+BalanceSelectMonthcomboBox.Text+"' and YearName='"+BalanceSelectYearcomboBox.Text+"'", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sdaGrid = new SqlDataAdapter("select * from BalanceSheet", con);
                DataTable dtGrid = new DataTable();
                sdaGrid.Fill(dtGrid);
                dataGridView1.DataSource = dtGrid;
                con.Close();
                MessageBox.Show("Deleted");

                    BalanceSelectMonthcomboBox.Text = "";
                    BalanceSelectYearcomboBox.Text = "";
                    MonthlyIncometextBox.Text = "0";
                    MonthlyExpensetextBox.Text = "0";
                    MonthlySalaryExptextBox.Text = "0";
                    MonthlyBalancetextBox.Text = "0";
                    MonthlyProfitOrlosstextBox.Text = "";
                    MonthlyBookOrCertitextBox.Text = "0";

                }

            catch
            {
                MessageBox.Show("Can't delete");
            }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmdBalance = new SqlCommand("select * from BalanceSheet", con);
            cmdBalance.ExecuteNonQuery();
            SqlDataAdapter sdaBalance = new SqlDataAdapter(cmdBalance);
            DataTable dtBalance = new DataTable();
            sdaBalance.Fill(dtBalance);
            con.Close();
            dataGridView1.DataSource = dtBalance;
        }

        private void BalanceSearchingtextBox_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmdBalance = new SqlCommand("select * from BalanceSheet where MonthName like '%"+BalanceSearchingtextBox.Text+ "%' or YearName like '%"+ BalanceSearchingtextBox.Text + "%'", con);
            cmdBalance.ExecuteNonQuery();
            SqlDataAdapter sdaBalance = new SqlDataAdapter(cmdBalance);
            DataTable dtBalance = new DataTable();
            sdaBalance.Fill(dtBalance);
            con.Close();
            dataGridView1.DataSource = dtBalance;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                  

                    dataGridView1.CurrentRow.Selected = true;
                    ProfitOrLossIdtextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
                    BalanceSelectMonthcomboBox.Text = dataGridView1.Rows[e.RowIndex].Cells["MonthName"].FormattedValue.ToString();
                    BalanceSelectYearcomboBox.Text = dataGridView1.Rows[e.RowIndex].Cells["YearName"].FormattedValue.ToString();
                    MonthlyIncometextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Income"].FormattedValue.ToString();
                    MonthlyBookOrCertitextBox.Text= dataGridView1.Rows[e.RowIndex].Cells["BookOrCertiIncome"].FormattedValue.ToString();
                    MonthlyExpensetextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Expense"].FormattedValue.ToString();
                    MonthlySalaryExptextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["SalaryExpense"].FormattedValue.ToString();
                    MonthlyBalancetextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Balance"].FormattedValue.ToString();
                    MonthlyProfitOrlosstextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["ProfitOrLoss"].FormattedValue.ToString();
                }


            }
            catch
            {
                MessageBox.Show("Click on any cell not Column");
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (MonthlyBookOrCertitextBox.TextLength > 0)
                {
                    MonthlyBalancetextBox.Text = (Convert.ToInt32(MonthlyIncometextBox.Text) + Convert.ToInt32(MonthlyBookOrCertitextBox.Text) - Convert.ToInt32(MonthlyExpensetextBox.Text)).ToString();
                }

                if (Convert.ToInt32(DateBalancetextBox.Text) >= 0)
                {
                    ProfitOrLosstextBox.Text = "Profit";
                }
                else
                {
                    ProfitOrLosstextBox.Text = "Loss";
                }
            }
            catch
            {
            }
        }

        private void DailyBookCertificatetextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (DailyBookCertificatetextBox.TextLength > 0)
                {
                    DateBalancetextBox.Text = (Convert.ToInt32(DateIncometextBox.Text) + Convert.ToInt32(DailyBookCertificatetextBox.Text) - Convert.ToInt32(DateExpensetextBox.Text)).ToString();
                }

                if (Convert.ToInt32(DateBalancetextBox.Text) >= 0)
                {
                    ProfitOrLosstextBox.Text = "Profit";
                }
                else
                {
                    ProfitOrLosstextBox.Text = "Loss";
                }
            }
            catch
            {
            }
        }

        private void button6_Click(object sender, EventArgs e)
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

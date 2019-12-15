using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lingo_Application
{
    public partial class DailyExpenseReportForm : Main_Form
    {
        ReportDocument Crystal = new ReportDocument();
        public DailyExpenseReportForm()
        {
            InitializeComponent();
        }

        private void ExpFromdateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ExpFromdateTimePicker.CustomFormat = "dd-MMM-yyy";

        }

        private void ExpTodateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ExpTodateTimePicker.CustomFormat = "dd-MMM-yyy";

        }

        private void ReportViewbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Expense where [Date] between '" + ExpFromdateTimePicker.Text + "' and '" + ExpTodateTimePicker.Text + "'", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sdaGrid = new SqlDataAdapter(cmd);
            DataTable dtGrid = new DataTable();
            sdaGrid.Fill(dtGrid);
            Crystal.Load(@"D:\Lingo Software\Lingo_Application\CrystalDailExpense.rpt");
            Crystal.SetDataSource(dtGrid);
            crystalReportViewer1.ReportSource = Crystal;
            con.Close();
        }
    }
}

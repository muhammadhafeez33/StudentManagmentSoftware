using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lingo_Application
{
    public partial class UnpaidStudentForm : Main_Form
    {
        ReportDocument Crystal = new ReportDocument();
        public UnpaidStudentForm()
        {
            InitializeComponent();
        }

       
        private void UnpaidStudentForm_Load(object sender, EventArgs e)
        {
           
        }

        private void UnpaidMonthcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PaidUnpaidcomboBox.SelectedItem.ToString() == "Paid")

            {

                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select Branch_Code,Student_Id,Student_Name,Department,Program,Teacher,Timing,Adm_Date,Due_Date from Lingo$ where StudentStatus='Active' and DATEDIFF(DAY,Due_Date,GETDATE())<30", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Crystal.Load(@"D:\Lingo Software\Lingo_Application\CrystalReportPaidUnpaid.rpt");
                Crystal.SetDataSource(dt);
                crystalReportViewer1.ReportSource = Crystal;
                con.Close();
              
                
            }
            else if (PaidUnpaidcomboBox.SelectedItem.ToString() == "Unpaid")
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select Branch_Code,Student_Id,Student_Name,Department,Program,Teacher,Timing,Adm_Date,Due_Date,DATEDIFF(DAY,Due_Date,GETDATE()) as UnpaidDay,DATEDIFF(MONTH,Due_Date,GETDATE()) as UnpaidMonth from Lingo$ where StudentStatus='Active' and DATEDIFF(DAY,Due_Date,GETDATE())>30 ", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Crystal.Load(@"D:\Lingo Software\Lingo_Application\CrystalReportPaidUnpaid.rpt");
                Crystal.SetDataSource(dt);
                crystalReportViewer1.ReportSource = Crystal;
                con.Close();
                       



            }
            
            else
            {
                MessageBox.Show("Select Paid and Unpaid Student");
            }

            
        }

        private void Searchingbutton_Click(object sender, EventArgs e)
        {
            if (PaidUnpaidcomboBox.SelectedItem.ToString() == "Paid")

            {

                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select Branch_Code,Student_Id,Student_Name,Department,Program,Teacher,Timing,Adm_Date,Due_Date from Lingo$ where StudentStatus='Active' and DATEDIFF(DAY,Due_Date,GETDATE())<30 and Student_Name like '%" + PaidUnpaidSearchingtextBox.Text + "%' or Department like '%" + PaidUnpaidSearchingtextBox.Text + "%' or Program like '%" + PaidUnpaidSearchingtextBox.Text + "%' or Teacher like '%" + PaidUnpaidSearchingtextBox.Text + "%'", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Crystal.Load(@"D:\Lingo Software\Lingo_Application\CrystalReportPaidUnpaid.rpt");
                Crystal.SetDataSource(dt);
                crystalReportViewer1.ReportSource = Crystal;
                con.Close();

            }
            else if (PaidUnpaidcomboBox.SelectedItem.ToString() == "Unpaid")
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select Branch_Code,Student_Id,Student_Name,Department,Program,Teacher,Timing,Adm_Date,Due_Date,DATEDIFF(DAY,Due_Date,GETDATE()) as UnpaidDay,DATEDIFF(MONTH,Due_Date,GETDATE()) as UnpaidMonth from Lingo$ where StudentStatus='Active' and DATEDIFF(DAY,Due_Date,GETDATE())>30 and Student_Name like '%" + PaidUnpaidSearchingtextBox.Text + "%' or Department like '%" + PaidUnpaidSearchingtextBox.Text + "%' or Program like '%" + PaidUnpaidSearchingtextBox.Text + "%' or Teacher like '%" + PaidUnpaidSearchingtextBox.Text + "%' ", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Crystal.Load(@"D:\Lingo Software\Lingo_Application\CrystalReportPaidUnpaid.rpt");
                Crystal.SetDataSource(dt);
                crystalReportViewer1.ReportSource = Crystal;
                con.Close();
            }

            else
            {
                MessageBox.Show("Select Paid and Unpaid Student");
            }
        }
    }
    }
    


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
    public partial class AllStatusForm : Main_Form
    {
        public AllStatusForm()
        {
            InitializeComponent();
        }

        private void AllStatusForm_Load(object sender, EventArgs e)
        {
            Datelabel.Text = DateTime.Now.ToString("dd-MMM-yyy");
            SqlConnection con1 = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con1.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT Count(Student_Id) from Lingo$", con1);
            try
            {
                var a1 = cmd1.ExecuteScalar();
                TotalStudentslabel.Text = a1.ToString();
                con1.Close();
            }
            catch
            {

            }

            
            con1.Open();
            SqlCommand cmdActive = new SqlCommand("SELECT Count(Student_Id) from Lingo$ where StudentStatus='Active'", con1);
            try
            {
                var a1 = cmdActive.ExecuteScalar();
                TotalActiveStudentslabel.Text = a1.ToString();
                con1.Close();
            }
            catch
            {

            }

            con1.Open();
            SqlCommand cmdInactive = new SqlCommand("SELECT Count(Student_Id) from Lingo$ where StudentStatus='Inactive'", con1);
            try
            {
                var a1 = cmdInactive.ExecuteScalar();
                TotalInActiveStudentslabel.Text = a1.ToString();
                con1.Close();
            }
            catch
            {

            }

            con1.Open();
            SqlCommand cmdComplete = new SqlCommand("SELECT Count(Student_Id) from Lingo$ where StudentStatus='Completed'", con1);
            try
            {
                var a1 = cmdComplete.ExecuteScalar();
                TotalCompleteStuentslabel.Text = a1.ToString();
                con1.Close();
            }
            catch
            {

            }

            con1.Open();
            SqlCommand cmdNew = new SqlCommand("select Count(*)  from Lingo$ where  MONTH(GETDATE())=MONTH(Adm_Date) and YEAR(GETDATE())=YEAR(Adm_Date)", con1);
            try
            {
                var aNew = cmdNew.ExecuteScalar();
                Newadmlabel.Text = aNew.ToString();
                con1.Close();
            }
            catch
            {
                Newadmlabel.Text = "0";
            }

            con1.Open();
            SqlCommand cmdUnapid = new SqlCommand("select Count(Student_Id) from Lingo$ where StudentStatus='Active' and DATEDIFF(DAY,Due_Date,GETDATE())>30", con1);
            try
            {
                var a1 = cmdUnapid.ExecuteScalar();
                TotalUnpaidStudentlabel.Text = a1.ToString();
                con1.Close();
            }
            catch
            {

            }

            con1.Open();
            SqlCommand cmdPaid = new SqlCommand("select Count(Student_Id) from Lingo$ where StudentStatus='Active' and DATEDIFF(DAY,Due_Date,GETDATE())<30", con1);
            try
            {
                var a1 = cmdPaid.ExecuteScalar();
                TotalPaidStudentslabel.Text = a1.ToString();
                con1.Close();
            }
            catch
            {

            }

            con1.Open();
            SqlCommand cmdRevenue = new SqlCommand("select SUM(TotalFee) from StudentFee where PaymentDate='"+Datelabel.Text+"'", con1);
            try
            {
                var a1 = cmdRevenue.ExecuteScalar();
                TotalRevenuelabel.Text = a1.ToString();
                con1.Close();

                con1.Open();
                SqlCommand cmdBookOrCert = new SqlCommand("select SUM(TotalAmount) from BookCertificate where DateOfIssue='" + Datelabel.Text + "'", con1);

                var aBookOrCert = cmdBookOrCert.ExecuteScalar();
                DailyBookOrCertlabel.Text = aBookOrCert.ToString();
                con1.Close();

                con1.Open();
                SqlCommand cmdExpene = new SqlCommand("select SUM(TotalExpense) from Expense where Date='" + Datelabel.Text + "'", con1);

                var a2 = cmdExpene.ExecuteScalar();
                TotalExpenselabel.Text = a2.ToString();
                con1.Close();

                con1.Open();
                SqlCommand cmdSalaryExp = new SqlCommand("select SUM(NerSalary) from EmployeeSalary where SalaryDate='" + Datelabel.Text + "'", con1);

                var a3 = cmdSalaryExp.ExecuteScalar();
                TotalSalaryExpenselabel.Text = a3.ToString();
                con1.Close();

                ProfitOrLosslabel.Text = (Convert.ToInt32(TotalRevenuelabel.Text)+ Convert.ToInt32(DailyBookOrCertlabel.Text)- Convert.ToInt32(TotalExpenselabel.Text)).ToString();

            }
            catch
            {
                try
                {
                    ProfitOrLosslabel.Text = (Convert.ToInt32(TotalRevenuelabel.Text) - Convert.ToInt32(TotalExpenselabel.Text)).ToString();
                }
                catch
                {
                }
                }
            con1.Close();

            con1.Open();
            SqlCommand cmdTotalBalance = new SqlCommand("select SUM(Balance) from Lingo$ left join StudentFee on Lingo$.Student_Id=StudentFee.AdmissionId where StudentStatus='Active'", con1);
            try
            {
                var a1 = cmdTotalBalance.ExecuteScalar();
                TotalStudentsBalancelabel.Text = a1.ToString();
               
            }
            
            catch
            {
            }
            con1.Close();

            con1.Open();
            SqlCommand cmdMonthRev = new SqlCommand("select sum(TotalFee) from StudentFee where  MONTH(GETDATE())=MONTH(PaymentDate) and YEAR(GETDATE())=YEAR(PaymentDate)", con1);
            try
            {
                var aMonthRev = cmdMonthRev.ExecuteScalar();
                MonthRevlabel.Text = aMonthRev.ToString();

            }

            catch
            {
            }
            con1.Close();

            con1.Open();
            SqlCommand cmdBookOrCerti = new SqlCommand("select SUM(TotalAmount) from BookCertificate where  MONTH(GETDATE())=MONTH(DateOfIssue) and YEAR(GETDATE())=YEAR(DateOfIssue)", con1);
            try
            {
                var aBookOrCerti = cmdBookOrCerti.ExecuteScalar();
                MonthlyBookCertilabel15.Text = aBookOrCerti.ToString();

            }
            catch
            {

            }
            con1.Close();

            con1.Open();
            SqlCommand cmdMonthExp = new SqlCommand("select sum(TotalExpense) from Expense where  MONTH(GETDATE())=MONTH([Date]) and YEAR(GETDATE())=YEAR([Date])", con1);
            try
            {
                var aMonthExp = cmdMonthExp.ExecuteScalar();
                MonthExplabel.Text = aMonthExp.ToString();

            }

            catch
            {
            }
            con1.Close();

            con1.Open();
            SqlCommand cmdMonthSalary = new SqlCommand("select sum(NerSalary) from EmployeeSalary where  MONTH(GETDATE())=MONTH([SalaryDate]) and YEAR(GETDATE())=YEAR([SalaryDate])", con1);
            try
            {
                var aMonthSalary = cmdMonthSalary.ExecuteScalar();
                TotalSalaryExpenselabel.Text = aMonthSalary.ToString();

                
                MonthlyProfitOrLosslabel.Text = (Convert.ToInt32(MonthRevlabel.Text) + Convert.ToInt32(MonthlyBookCertilabel15.Text) - Convert.ToInt32(MonthExplabel.Text) - Convert.ToInt32(TotalSalaryExpenselabel.Text)).ToString();
            }

            catch
            {
                try
                {
                    MonthlyProfitOrLosslabel.Text = (Convert.ToInt32(MonthRevlabel.Text) + Convert.ToInt32(MonthlyBookCertilabel15.Text) - Convert.ToInt32(MonthExplabel.Text)).ToString();
                }
                catch
                {
                }
                }
            con1.Close();

            // balance

            con1.Open();
            SqlCommand cmdAlltotal = new SqlCommand("select SUM(TotalFee) from StudentFee", con1);
            try
            {
                var aAlltotal = cmdAlltotal.ExecuteScalar();
                AllTotalFeelabel16.Text = aAlltotal.ToString();
                con1.Close();

                con1.Open();
                SqlCommand cmdAllBookOrCert = new SqlCommand("select SUM(TotalAmount) from BookCertificate", con1);

                var aAllBookOrCert = cmdAllBookOrCert.ExecuteScalar();
                AllBookOrCertilabel17.Text = aAllBookOrCert.ToString();
                con1.Close();

                con1.Open();
                SqlCommand cmdAllExpene = new SqlCommand("select SUM(TotalExpense) from Expense", con1);

                var aAll = cmdAllExpene.ExecuteScalar();
                AllTotalExplabel25.Text = aAll.ToString();
                con1.Close();

                con1.Open();
                SqlCommand cmdAllSalaryExp = new SqlCommand("select SUM(NerSalary) from EmployeeSalary", con1);

                var aAllSalaryExp = cmdAllSalaryExp.ExecuteScalar();
                AllSalaryExplabel21.Text = aAllSalaryExp.ToString();
                con1.Close();

                AllProfitOrLosslabel29.Text = (Convert.ToInt32(AllTotalFeelabel16.Text) + Convert.ToInt32(AllBookOrCertilabel17.Text) - Convert.ToInt32(AllTotalExplabel25.Text)- Convert.ToInt32(AllSalaryExplabel21.Text)).ToString();

            }
            catch
            {

            }
            con1.Close();
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd0 = new SqlCommand("select COUNT(Program) from Inquiry_Table where Program='Lingo'", con);
                int TotalInquiryLang = Convert.ToInt32(cmd0.ExecuteScalar());
                TotalInquiryLanguagelabel.Text = TotalInquiryLang.ToString();

                SqlCommand cmdLingo = new SqlCommand("select COUNT(Program) from Inquiry_Table where Program='Lingo' and Pending_Done_Cencal='Pending'", con);
                int InquiryPendingLan = Convert.ToInt32(cmdLingo.ExecuteScalar());
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
            }
            catch
            {

            }



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TotalStudentsBalancelabel_Click(object sender, EventArgs e)
        {

        }
    }
}

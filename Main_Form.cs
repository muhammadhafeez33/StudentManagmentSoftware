using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lingo_Application
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void admissionFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void AdmissionFrombutton_Click(object sender, EventArgs e)
        {
            Admission_Form s = new Admission_Form();
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CollectionForm s = new CollectionForm();
            s.Show();
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DPTTForm s = new DPTTForm();
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            InquiryForm s = new InquiryForm();
            s.Show();

        }

        private void InquiryViewbutton_Click(object sender, EventArgs e)
        {
            InquiryViewForm s = new InquiryViewForm();
            s.Show();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void StudentViewbutton_Click(object sender, EventArgs e)
        {
            //StudentViewForm s = new StudentViewForm();
            //s.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
           
        }

        private void Reportsbutton_Click(object sender, EventArgs e)
        {
            ReportForm s = new ReportForm();
            s.Show();
        }

        private void Empbutton_Click(object sender, EventArgs e)
        {
            EmployeeRegistForm s = new EmployeeRegistForm();
            s.Show();
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            EmpNewRegisterForm s = new EmpNewRegisterForm();
                s.Show();
        }

        private void Unpaidbutton_Click(object sender, EventArgs e)
        {
           PaidUnpaidView s = new PaidUnpaidView();
            s.Show();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
           
           
        }

        private void Expensebutton_Click(object sender, EventArgs e)
        {
            ExpenseForm s = new ExpenseForm();
            s.Show();
        }

        private void ProfitOrlossbutton_Click(object sender, EventArgs e)
        {
            ProftOrLossForm s = new ProftOrLossForm();
            s.Show();

        }

        private void Bankbutton_Click(object sender, EventArgs e)
        {
          
           
           
        }

        private void AllStatusbutton_Click(object sender, EventArgs e)
        {
            AllStatusForm s = new AllStatusForm();
            s.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BookCertiForm s = new BookCertiForm();
            s.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FilterRecordForm s = new FilterRecordForm();
            s.Show();
        }
    }
}

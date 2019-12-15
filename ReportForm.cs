using CrystalDecisions.CrystalReports.Engine;
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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
           
            //ReportDocument rptDoc = new ReportDocument();
            //rptDoc.Load(@"D:\Lingo Software\Lingo_Application\CrystalAdmissionAllReport.rpt");
            //crystalReportViewer1.ReportSource = rptDoc;
            //this.Controls.Add(crystalReportViewer1);
            //crystalReportViewer1.Dock = DockStyle.Fill;
            //crystalReportViewer1.RefreshReport();
        }

        private void allStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            //ReportDocument rptDoc = new ReportDocument();
            //rptDoc.Load(@"D:\Lingo Software\Lingo_Application\CrystalAdmissionAllReport.rpt");
            //crystalReportViewer1.ReportSource = rptDoc;
            //this.Controls.Add(crystalReportViewer1);
            //crystalReportViewer1.Dock = DockStyle.Fill;
            //crystalReportViewer1.RefreshReport();

        }

        private void filterDateAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ReportDocument rptDoc = new ReportDocument();
            rptDoc.Load(@"D:\Lingo Software\Lingo_Application\CrystalAdmissionReportDateTeacherFilter.rpt");
            crystalReportViewer1.ReportSource = rptDoc;
            this.Controls.Add(crystalReportViewer1);
            crystalReportViewer1.Dock = DockStyle.Fill;
            crystalReportViewer1.RefreshReport();

        }

        private void filterDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            ReportDocument rptDoc = new ReportDocument();
            rptDoc.Load(@"D:\Lingo Software\Lingo_Application\CrystalAdmissionTeacherGroupReport.rpt");
            crystalReportViewer1.ReportSource = rptDoc;
            this.Controls.Add(crystalReportViewer1);
            crystalReportViewer1.Dock = DockStyle.Fill;
            crystalReportViewer1.RefreshReport();


        }

        private void allStudentFeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            //ReportDocument rptDoc = new ReportDocument();
            //rptDoc.Load(@"D:\Lingo Software\Lingo_Application\CrystalReportFeeReport.rpt");
            //crystalReportViewer1.ReportSource = rptDoc;
            //this.Controls.Add(crystalReportViewer1);
            //crystalReportViewer1.Dock = DockStyle.Fill;
            //crystalReportViewer1.RefreshReport();

        }

        private void paidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportDocument rptDoc = new ReportDocument();
            rptDoc.Load(@"D:\Lingo Software\Lingo_Application\CrystalReportFeeReportStartEndDate.rpt");
            crystalReportViewer1.ReportSource = rptDoc;
            this.Controls.Add(crystalReportViewer1);
            crystalReportViewer1.Dock = DockStyle.Fill;
            crystalReportViewer1.Refresh();
            crystalReportViewer1.RefreshReport();
           

        }

        private void unPaidToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ReportDocument rptDoc = new ReportDocument();
            rptDoc.Load(@"D:\Lingo Software\Lingo_Application\CrystalReportFeeReportMonthDepTeachTim.rpt");
            crystalReportViewer1.ReportSource = rptDoc;
            this.Controls.Add(crystalReportViewer1);
            crystalReportViewer1.Dock = DockStyle.Fill;
            crystalReportViewer1.RefreshReport();

        }

        private void feeTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportDocument rptDoc = new ReportDocument();
            rptDoc.Load(@"D:\Lingo Software\Lingo_Application\CrystalReportFeeReportStudentStatus.rpt");
            crystalReportViewer1.ReportSource = rptDoc;
            this.Controls.Add(crystalReportViewer1);
            crystalReportViewer1.Dock = DockStyle.Fill;
            crystalReportViewer1.RefreshReport();
        }

        private void monthDepartTeacherTimingFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportDocument rptDoc = new ReportDocument();
            rptDoc.Load(@"D:\Lingo Software\Lingo_Application\CrystalReportFeeReportMonthDepartTeacherTimingFilter.rpt");
            crystalReportViewer1.ReportSource = rptDoc;
            crystalReportViewer1.Refresh();
            this.Controls.Add(crystalReportViewer1);
            crystalReportViewer1.Dock = DockStyle.Fill;
            crystalReportViewer1.RefreshReport();
        }

        private void feeGroupDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportDocument rptDoc = new ReportDocument();
            rptDoc.Load(@"D:\Lingo Software\Lingo_Application\CrystalReportFeeReportTFeeDepartment.rpt");
            crystalReportViewer1.ReportSource = rptDoc;
            this.Controls.Add(crystalReportViewer1);
            crystalReportViewer1.Dock = DockStyle.Fill;
            crystalReportViewer1.RefreshReport();
        }

        private void feeGroupTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportDocument rptDoc = new ReportDocument();
            rptDoc.Load(@"D:\Lingo Software\Lingo_Application\CrystalReportFeeReportTTeacherG.rpt");
            crystalReportViewer1.ReportSource = rptDoc;
            this.Controls.Add(crystalReportViewer1);
            crystalReportViewer1.Dock = DockStyle.Fill;
            crystalReportViewer1.RefreshReport();
        }

        private void inquiryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void salarySlipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportDocument rptDoc = new ReportDocument();
            rptDoc.Load(@"D:\Lingo Software\Lingo_Application\CrystalReportSalarySlip.rpt");
            crystalReportViewer1.ReportSource = rptDoc;
            this.Controls.Add(crystalReportViewer1);
            crystalReportViewer1.Dock = DockStyle.Fill;
            crystalReportViewer1.RefreshReport();
        }
    }
}

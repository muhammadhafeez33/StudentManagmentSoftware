using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using Excel = Microsoft.Office.Interop.Excel;



namespace Lingo_Application
{
    public partial class CollectionForm : Main_Form
    {
        ReportDocument Crystal = new ReportDocument();
        public CollectionForm()
        {
            InitializeComponent();
        }

        private void CollectionForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select Branch_Code,Student_Id,Student_Name,Department,Program,Teacher,Timing,SlipNo,AdmissionFee,MonthlyFee,TotalFee,Balance,MonthInstLums,PaymentDate,FeeMonth,Year,Due_Date from Lingo$ left join StudentFee on Lingo$.Student_Id = StudentFee.AdmissionId where StudentStatus = 'Active'", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sdaGrid = new SqlDataAdapter(cmd);
            DataTable dtGrid = new DataTable();
            sdaGrid.Fill(dtGrid);
            dataGridView1.DataSource = dtGrid;
            con.Close();

            con.Open();
            SqlCommand cmd3 = new SqlCommand("select Branch_Code from Lingo$ group by Branch_Code", con);
            SqlDataReader Reader3 = cmd3.ExecuteReader();
            AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            while (Reader3.Read())
            {
                MyCollection.Add(Reader3.GetString(0));

            }
            CollectionBranchCodetextBox.AutoCompleteCustomSource = MyCollection;
            con.Close();

            con.Open();
            SqlCommand cmd4 = new SqlCommand("select SlipNO from StudentFee group by SlipNo", con);
            SqlDataReader Reader4 = cmd4.ExecuteReader();
            AutoCompleteStringCollection MyCollectio4 = new AutoCompleteStringCollection();
            while (Reader4.Read())
            {
                MyCollectio4.Add(Reader4.GetString(0));

            }
            CollectionSlipNotextBox.AutoCompleteCustomSource = MyCollectio4;
            con.Close();

            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["TotalFee"].Value != DBNull.Value)
                {
                    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["TotalFee"].Value);
                }
                TotalPendingExpectedlabel.Text = sum.ToString();
            }

        }

        private void CollectionStudentFindbutton_Click(object sender, EventArgs e)
        {

            SqlConnection con1 = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con1.Open();
            SqlCommand cmd1 = new SqlCommand("select AdmissionId from Lingo$ left join StudentFee on Lingo$.Student_Id=StudentFee.AdmissionId where StudentStatus ='Active' and Branch_Code='" + CollectionBranchCodetextBox.Text + "' and Student_Id='" + CollectionStudentIdtextBox.Text + "'", con1);
            cmd1.ExecuteNonQuery();
            SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            con1.Close();
      

            try
            {
                if (dt1.Rows[0][0].ToString() != CollectionStudentIdtextBox.Text)
                {

                    SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from Lingo$ left join StudentFee on Lingo$.Student_Id=StudentFee.AdmissionId where StudentStatus ='Active' and Branch_Code='" + CollectionBranchCodetextBox.Text + "' and Student_Id='" + CollectionStudentIdtextBox.Text + "'", con);
                    SqlDataReader Reader = cmd.ExecuteReader();


                    while (Reader.Read())
                    {

                        CollectionStudentNametextBox.Text = Reader[3].ToString();
                        CollectionDepartmenttextBox.Text = Reader[9].ToString();
                        CollectionProgramtextBox.Text = Reader[10].ToString();
                        CollectionTeachertextBox.Text = Reader[11].ToString();
                        CollectionTimingtextBox.Text = Reader[12].ToString();
                        CollectionSlipNotextBox.Text = "";
                        CollectionAdmissiontextBox.Text = "0";
                        CollectionMonthInstLumstextBox.Text = "0";
                        CollectionTotalFeetextBox.Text = "0";
                        CollectionBalancetextBox.Text = "0";
                        CollectionFeePayIncomboBox.Text = "";
                        CollectionPaiddateTimePicker.Text = "";
                       
                       
                      

                    }
                    con.Close();
                    SqlDataAdapter sdaGrid = new SqlDataAdapter("select Branch_Code,Student_Id,Student_Name,Department,Program,Teacher,Timing,SlipNo,AdmissionFee,MonthlyFee,TotalFee,Balance,MonthInstLums,PaymentDate,FeeMonth,Year from Lingo$ left join StudentFee on Lingo$.Student_Id = StudentFee.AdmissionId where StudentStatus ='Active' and Branch_Code='" + CollectionBranchCodetextBox.Text + "' and Student_Id='" + CollectionStudentIdtextBox.Text + "'", con1);
                    DataTable dtGrid = new DataTable();
                    sdaGrid.Fill(dtGrid);
                    dataGridView1.DataSource = dtGrid;
                    


                }
                else
                {

                    SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from Lingo$ left join StudentFee on Lingo$.Student_Id=StudentFee.AdmissionId where StudentStatus ='Active' and Branch_Code='" + CollectionBranchCodetextBox.Text + "' and Student_Id='" + CollectionStudentIdtextBox.Text + "'", con);
                    SqlDataReader Reader = cmd.ExecuteReader();

                    while (Reader.Read())
                    {

                        CollectionStudentNametextBox.Text = Reader[3].ToString();
                        CollectionDepartmenttextBox.Text = Reader[9].ToString();
                        CollectionProgramtextBox.Text = Reader[10].ToString();
                        CollectionTeachertextBox.Text = Reader[11].ToString();
                        CollectionTimingtextBox.Text = Reader[12].ToString();
                        CollectionSlipNotextBox.Text = Reader[16].ToString();
                        CollectionAdmissiontextBox.Text = Reader[18].ToString();
                        CollectionMonthInstLumstextBox.Text = Reader[19].ToString();
                        CollectionTotalFeetextBox.Text = Reader[20].ToString();
                        CollectionBalancetextBox.Text = Reader[21].ToString();
                        CollectionFeePayIncomboBox.Text = Reader[22].ToString();
                        CollectionPaiddateTimePicker.Text= Reader[23].ToString();
                        FeeMonthcomboBox.Text= Reader[24].ToString();
                        FeeMonthYearcomboBox.Text= Reader[25].ToString();
                        
                       
                    }
                    con.Close();

                    SqlDataAdapter sdaGrid = new SqlDataAdapter("select Branch_Code,Student_Id,Student_Name,Department,Program,Teacher,Timing,SlipNo,AdmissionFee,MonthlyFee,TotalFee,Balance,MonthInstLums,PaymentDate,FeeMonth,Year from Lingo$ left join StudentFee on Lingo$.Student_Id = StudentFee.AdmissionId where StudentStatus ='Active' and Branch_Code='" + CollectionBranchCodetextBox.Text + "' and Student_Id='" + CollectionStudentIdtextBox.Text + "'", con1);
                    DataTable dtGrid = new DataTable();
                    sdaGrid.Fill(dtGrid);
                    dataGridView1.DataSource = dtGrid;
                    


                }
            }
            catch
            {
                MessageBox.Show(" Record not found or not active.");
            }
        }

        private void CollectionSavebutton_Click(object sender, EventArgs e)
        {

         try
            {
                if (CollectionSlipNotextBox.Text == "")
            {
                MessageBox.Show("Please enter the slip Number then press save button");
            }

                else {    
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into StudentFee(SlipNo,AdmissionId,AdmissionFee,MonthlyFee,TotalFee,Balance,MonthInstLums,PaymentDate,FeeMonth,[Year])values('"+CollectionSlipNotextBox.Text+"','"+CollectionStudentIdtextBox.Text+"','"+CollectionAdmissiontextBox.Text+"','"+CollectionMonthInstLumstextBox.Text+"','"+CollectionTotalFeetextBox.Text+"','"+CollectionBalancetextBox.Text+"','"+CollectionFeePayIncomboBox.Text+"','"+CollectionPaiddateTimePicker.Text+"','"+FeeMonthcomboBox.Text+"','"+FeeMonthYearcomboBox.Text+"')", con);
                cmd.ExecuteNonQuery();
                  
                    SqlCommand cmd1 = new SqlCommand("update Lingo$ set Due_Date='" + DueDatedateTimePicker.Text + "' where StudentStatus='Active' and Branch_Code='" + CollectionBranchCodetextBox.Text + "' and Student_Id='" + CollectionStudentIdtextBox.Text + "'", con);
                    cmd1.ExecuteNonQuery();

                    SqlDataAdapter sdaGrid = new SqlDataAdapter("select Branch_Code,Student_Id,Student_Name,Department,Program,Teacher,Timing,SlipNo,AdmissionFee,MonthlyFee,TotalFee,Balance,MonthInstLums,PaymentDate,FeeMonth,Year,Due_Date from Lingo$ left join StudentFee on Lingo$.Student_Id = StudentFee.AdmissionId where StudentStatus = 'Active' and Branch_Code = '" + CollectionBranchCodetextBox.Text + "' and Student_Id = '" + CollectionStudentIdtextBox.Text + "'", con);
                    DataTable dtGrid = new DataTable();
                    sdaGrid.Fill(dtGrid);
                    dataGridView1.DataSource = dtGrid;
                    con.Close();
                MessageBox.Show("Saved");

                CollectionStudentIdtextBox.Text = "";                   
                CollectionSlipNotextBox.Text = "";
                CollectionBranchCodetextBox.Text= "";
                CollectionStudentIdtextBox.Text = "";
                CollectionStudentNametextBox.Text = "";
                CollectionDepartmenttextBox.Text = "";
                CollectionProgramtextBox.Text = "";
                CollectionTeachertextBox.Text = "";
                CollectionTimingtextBox.Text = "";
                CollectionAdmissiontextBox.Text = "0";
                CollectionMonthInstLumstextBox.Text = "0";
                CollectionTotalFeetextBox.Text = "0";
                CollectionFeePayIncomboBox.Text = "";
                CollectionBalancetextBox.Text = "0";
                CollectionFeePayIncomboBox.Text= "";
                CollectionPaiddateTimePicker.Text = "";
                FeeMonthcomboBox.Text = "";
                FeeMonthYearcomboBox.Text = "";

                    int sum = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["TotalFee"].Value != DBNull.Value)
                        {
                            sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["TotalFee"].Value);
                        }
                        TotalPendingExpectedlabel.Text = sum.ToString();
                    }



                }
            }
          catch
            { 
            
                MessageBox.Show("Slip No Already Saved in Database");
            }

        }

        private void CollectionFeePayIncomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CollectionSlipFindbutton_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Lingo$ left join StudentFee on Lingo$.Student_Id=StudentFee.AdmissionId where StudentStatus ='Active' and SlipNo='" + CollectionSlipNotextBox.Text + "'", con);
                SqlDataReader Reader = cmd.ExecuteReader();

                while (Reader.Read())
                {
                   
                    CollectionBranchCodetextBox.Text= Reader[0].ToString();
                    CollectionStudentIdtextBox.Text= Reader[1].ToString();
                    CollectionStudentNametextBox.Text = Reader[3].ToString();
                    CollectionDepartmenttextBox.Text = Reader[9].ToString();
                    CollectionProgramtextBox.Text = Reader[10].ToString();
                    CollectionTeachertextBox.Text = Reader[11].ToString();
                    CollectionTimingtextBox.Text = Reader[12].ToString();
                    CollectionAdmissiontextBox.Text = Reader[18].ToString();
                    CollectionMonthInstLumstextBox.Text = Reader[19].ToString();
                    CollectionTotalFeetextBox.Text = Reader[20].ToString();
                    CollectionBalancetextBox.Text = Reader[21].ToString();
                    CollectionFeePayIncomboBox.Text = Reader[22].ToString();
                    CollectionPaiddateTimePicker.Text = Reader[23].ToString();
                    FeeMonthYearcomboBox.Text = Reader[24].ToString();
                    FeeMonthYearcomboBox.Text = Reader[25].ToString();
                  

            }
                con.Close();
                SqlDataAdapter sdaGrid = new SqlDataAdapter("select Branch_Code,Student_Id,Student_Name,Department,Program,Teacher,Timing,SlipNo,AdmissionFee,MonthlyFee,TotalFee,Balance,MonthInstLums,PaymentDate,FeeMonth,Year from Lingo$ left join StudentFee on Lingo$.Student_Id = StudentFee.AdmissionId where StudentStatus ='Active' and SlipNo='" + CollectionSlipNotextBox.Text + "'", con);
                DataTable dtGrid = new DataTable();
                sdaGrid.Fill(dtGrid);
                dataGridView1.DataSource = dtGrid;

            }
            catch
            {
                MessageBox.Show(" Record not found or not active.");
            }
        }

        private void CollectionClearbutton_Click(object sender, EventArgs e)
        {
            CollectionStudentIdtextBox.Text = "";
            CollectionSlipNotextBox.Text = "";
            CollectionBranchCodetextBox.Text = "";
            CollectionStudentIdtextBox.Text = "";
            CollectionStudentNametextBox.Text = "";
            CollectionDepartmenttextBox.Text = "";
            CollectionProgramtextBox.Text = "";
            CollectionTeachertextBox.Text = "";
            CollectionTimingtextBox.Text = "";
            CollectionAdmissiontextBox.Text = "0";
            CollectionMonthInstLumstextBox.Text = "0";
            CollectionTotalFeetextBox.Text = "0";
            CollectionFeePayIncomboBox.Text = "";
            CollectionBalancetextBox.Text = "0";
            CollectionFeePayIncomboBox.Text = "";
            CollectionPaiddateTimePicker.Text = "";
            FeeMonthcomboBox.Text = "";
            FeeMonthYearcomboBox.Text = "";
        }

        
        private void CollectionUpdatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CollectionSlipNotextBox.Text == "")
                {
                    MessageBox.Show("Please enter the slip number then update data");
                }

                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update StudentFee set AdmissionFee='" + CollectionAdmissiontextBox.Text + "' , MonthlyFee='" + CollectionMonthInstLumstextBox.Text + "' , TotalFee='" + CollectionTotalFeetextBox.Text + "' , Balance='" + CollectionBalancetextBox.Text + "' , MonthInstLums='" + CollectionFeePayIncomboBox.Text + "' , PaymentDate='" + CollectionPaiddateTimePicker.Text + "',FeeMonth='"+FeeMonthcomboBox.Text+"', Year='"+FeeMonthYearcomboBox.Text+"' where SlipNo='" + CollectionSlipNotextBox.Text + "'", con);
                    cmd.ExecuteNonQuery();

                    SqlCommand cmd1 = new SqlCommand("update Lingo$ set Due_Date='" + DueDatedateTimePicker.Text + "' where StudentStatus='Active' and Branch_Code='" + CollectionBranchCodetextBox.Text + "' and Student_Id='" + CollectionStudentIdtextBox.Text + "'", con);
                    cmd1.ExecuteNonQuery();

                    SqlDataAdapter sdaGrid = new SqlDataAdapter("select Branch_Code,Student_Id,Student_Name,Department,Program,Teacher,Timing,SlipNo,AdmissionFee,MonthlyFee,TotalFee,Balance,MonthInstLums,PaymentDate,FeeMonth,Year,Due_Date from Lingo$ left join StudentFee on Lingo$.Student_Id = StudentFee.AdmissionId where StudentStatus = 'Active' and Branch_Code = '" + CollectionBranchCodetextBox.Text + "' and Student_Id = '" + CollectionStudentIdtextBox.Text + "'", con);
                    DataTable dtGrid = new DataTable();
                    sdaGrid.Fill(dtGrid);
                    dataGridView1.DataSource = dtGrid;
                    con.Close();


                    MessageBox.Show("updated");

                    int sum = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["TotalFee"].Value != DBNull.Value)
                        {
                            sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["TotalFee"].Value);
                        }
                        TotalPendingExpectedlabel.Text = sum.ToString();
                    }

                }
            }
            catch
            {
                MessageBox.Show("Data not update");
            }
              }

        private void CollectionDeletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CollectionSlipNotextBox.Text == "")
                {
                    MessageBox.Show("Please enter the slip number then delete data");
                }

                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete StudentFee where SlipNo='" + CollectionSlipNotextBox.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sdaGrid = new SqlDataAdapter("select Branch_Code,Student_Id,Student_Name,Department,Program,Teacher,Timing,SlipNo,AdmissionFee,MonthlyFee,TotalFee,Balance,MonthInstLums,PaymentDate,FeeMonth,Year,Due_Date from Lingo$ left join StudentFee on Lingo$.Student_Id = StudentFee.AdmissionId where StudentStatus = 'Active' and Branch_Code = '" + CollectionBranchCodetextBox.Text + "' and Student_Id = '" + CollectionStudentIdtextBox.Text + "'", con);
                    DataTable dtGrid = new DataTable();
                    sdaGrid.Fill(dtGrid);
                    dataGridView1.DataSource = dtGrid;
                    con.Close();
                    MessageBox.Show("data deleted into database");

                    CollectionStudentIdtextBox.Text = "";
                    CollectionSlipNotextBox.Text = "";
                    CollectionBranchCodetextBox.Text = "";
                    CollectionStudentIdtextBox.Text = "";
                    CollectionStudentNametextBox.Text = "";
                    CollectionDepartmenttextBox.Text = "";
                    CollectionProgramtextBox.Text = "";
                    CollectionTeachertextBox.Text = "";
                    CollectionTimingtextBox.Text = "";
                    CollectionAdmissiontextBox.Text = "0";
                    CollectionMonthInstLumstextBox.Text = "0";
                    CollectionTotalFeetextBox.Text = "0";
                    CollectionFeePayIncomboBox.Text = "";
                    CollectionBalancetextBox.Text = "0";
                    CollectionFeePayIncomboBox.Text = "";
                    CollectionPaiddateTimePicker.Text = "";
                    FeeMonthcomboBox.Text = "";
                    FeeMonthYearcomboBox.Text = "";

                    int sum = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["TotalFee"].Value != DBNull.Value)
                        {
                            sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["TotalFee"].Value);
                        }
                        TotalPendingExpectedlabel.Text = sum.ToString();
                    }

                }
            }
            catch
            {
                MessageBox.Show("Data not delete");
            }
        }

        
        

        private void CollectionAdmissiontextBox_TextChanged(object sender, EventArgs e)
        {
           try
            { 
            if (CollectionAdmissiontextBox.Text.Length > 0)
            {
                CollectionTotalFeetextBox.Text = (Convert.ToInt32(CollectionAdmissiontextBox.Text) + Convert.ToInt32(CollectionMonthInstLumstextBox.Text)).ToString();
            }

            }
            catch
            {
                CollectionAdmissiontextBox.Text = "0";
            }
        }

        private void CollectionTotalFeetextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (CollectionTotalFeetextBox.Text.Length > 0)
            {
                CollectionTotalFeetextBox.Text = (Convert.ToInt32(CollectionAdmissiontextBox.Text) + Convert.ToInt32(CollectionMonthInstLumstextBox.Text)).ToString();
            }
            }
            catch
            {
                CollectionTotalFeetextBox.Text = "0";
            }


        }

        private void CollectionMonthInstLumstextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (CollectionMonthInstLumstextBox.Text.Length > 0)
                {
                    CollectionTotalFeetextBox.Text = (Convert.ToInt32(CollectionAdmissiontextBox.Text) + Convert.ToInt32(CollectionMonthInstLumstextBox.Text)).ToString();
                }
            }
            catch
            {
                CollectionMonthInstLumstextBox.Text = "0";
            }

        }

        private void CollectionBalancetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FeeMonthdateTimePicker_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void FeeYeardateTimePicker_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void ColSearchingtextBox_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select Branch_Code,Student_Id,Student_Name,Department,Program,Teacher,Timing,SlipNo,AdmissionFee,MonthlyFee,TotalFee,Balance,MonthInstLums,PaymentDate,FeeMonth,Year,Due_Date from Lingo$ left join StudentFee on Lingo$.Student_Id = StudentFee.AdmissionId where StudentStatus = 'Active' and Branch_Code like '%" + AdmSearchingtextBox.Text + "%' or Student_Id like'%" + AdmSearchingtextBox.Text + "%' or Student_Name like'%" + AdmSearchingtextBox.Text + "%' or Department like'%" + AdmSearchingtextBox.Text + "%' or Program like'%" + AdmSearchingtextBox.Text + "%' or Teacher like'%" + AdmSearchingtextBox.Text + "%' or SlipNO like'%" + AdmSearchingtextBox.Text + "%' or FeeMonth like'%" + AdmSearchingtextBox.Text + "%' or MonthInstLums like'%" + AdmSearchingtextBox.Text + "%'", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;

            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["TotalFee"].Value != DBNull.Value)
                {
                    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["TotalFee"].Value);
                }
                TotalPendingExpectedlabel.Text = sum.ToString();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;
                    CollectionBranchCodetextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Branch_Code"].FormattedValue.ToString();
                    CollectionStudentIdtextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Student_Id"].FormattedValue.ToString();
                    CollectionStudentNametextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Student_Name"].FormattedValue.ToString();
                    CollectionDepartmenttextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Department"].FormattedValue.ToString();
                    CollectionProgramtextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Program"].FormattedValue.ToString();
                    CollectionTeachertextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Teacher"].FormattedValue.ToString();
                    CollectionTimingtextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Timing"].FormattedValue.ToString();
                    CollectionSlipNotextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["SlipNo"].FormattedValue.ToString();
                    CollectionAdmissiontextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["AdmissionFee"].FormattedValue.ToString();
                    CollectionMonthInstLumstextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["MonthlyFee"].FormattedValue.ToString();
                    CollectionTotalFeetextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["TotalFee"].FormattedValue.ToString();
                    CollectionBalancetextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Balance"].FormattedValue.ToString();
                    CollectionFeePayIncomboBox.Text = dataGridView1.Rows[e.RowIndex].Cells["MonthInstLums"].FormattedValue.ToString();
                    CollectionPaiddateTimePicker.Text = dataGridView1.Rows[e.RowIndex].Cells["PaymentDate"].FormattedValue.ToString();
                    FeeMonthcomboBox.Text = dataGridView1.Rows[e.RowIndex].Cells["FeeMonth"].FormattedValue.ToString();
                    FeeMonthYearcomboBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Year"].FormattedValue.ToString();
                    DueDatedateTimePicker.Text= dataGridView1.Rows[e.RowIndex].Cells["Due_Date"].FormattedValue.ToString();
                   


                }

            }

            catch
            {
                MessageBox.Show("Click on any cell not column");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowAllbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select Branch_Code,Student_Id,Student_Name,Department,Program,Teacher,Timing,SlipNo,AdmissionFee,MonthlyFee,TotalFee,Balance,MonthInstLums,PaymentDate,FeeMonth,Year,Due_Date from Lingo$ left join StudentFee on Lingo$.Student_Id = StudentFee.AdmissionId where StudentStatus = 'Active'", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sdaGrid = new SqlDataAdapter(cmd);
            DataTable dtGrid = new DataTable();
            sdaGrid.Fill(dtGrid);
            dataGridView1.DataSource = dtGrid;
            con.Close();

        }

        private void DueDatedateTimePicker_ValueChanged(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

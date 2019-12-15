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
    public partial class InquiryForm : Main_Form
    {
        public InquiryForm()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void InquiryInsertbutton_Click(object sender, EventArgs e)
        {

            if (InquiryAttendantcomboBox.Text == "")
            {
                MessageBox.Show("Please Enter the Inquiry Number.");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");

                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Inquiry_Table(Inquiry_No,Inquiry_Date,Attendant,Program,Course_Name,Student_Name,Phone,Potential,Expected_Strength,Know_About,Expected_Visit_Date,Day,Comments,Teacher_Name,Demo_Class,Follow_1,Follwer_1_Name,Follower_1_Response,Follower_Date_1,Follow_2,Follwer_2_Name,Follower_2_Response,Follower_Date_2,Follow_3,Follwer_3_Name,Follower_3_Response,Follower_Date_3,Pending_Done_Cencal,Expected_Fee)values('" + InquiryNotextBox.Text + "','" + InquirydateTimePicker.Text + "','" + InquiryAttendantcomboBox.Text + "','" + InquiryProgramcomboBox.Text + "','" + InquiryCourseNamecomboBox.Text + "','" + InquiryStudentNametextBox.Text + "','" + InquiryPhonetextBox.Text + "','" + InquiryPotentialcomboBox.Text + "','" + InquiryExpectedStrengthcomboBox.Text + "','" + InquiryHowKnowcomboBox.Text + "','" + InquiryVisitdateTimePicker.Text + "','" + InquiryDaycomboBox.Text + "','" + InquiryCommentstextBox.Text + "','" + InquiryTeacherNamecomboBox.Text + "','" + InquiryDemoClasscomboBox.Text + "','" + InquiryFollow1comboBox.Text + "','" + InquiryFollowerName1comboBox.Text + "','" + InquiryResponse1comboBox.Text + "','" + Follower1dateTimePicker.Text + "','" + InquiryFollow2comboBox.Text + "','" + InquiryFollowerName2comboBox.Text + "','" + InquiryResponse2comboBox.Text + "','" + Follower2dateTimePicker.Text + "','" + InquiryFollow3comboBox.Text + "','" + InquiryFollowerName3comboBox.Text + "','" + InquiryResponse3comboBox.Text + "','" + Follower3dateTimePicker.Text + "','" + InquiryPendingDonecomboBox.Text + "','" + InquiryExpectedFeetextBox.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data inserted into Database.");


                    InquirydateTimePicker.Text = "";
                    InquiryAttendantcomboBox.Text = "";
                    InquiryProgramcomboBox.Text = "";
                    InquiryCourseNamecomboBox.Text = "";
                    InquiryStudentNametextBox.Text = "";
                    InquiryPhonetextBox.Text = "";
                    InquiryPotentialcomboBox.Text = "";
                    InquiryExpectedStrengthcomboBox.Text = "";
                    InquiryHowKnowcomboBox.Text = "";
                    InquiryVisitdateTimePicker.Text = "";
                    InquiryDaycomboBox.Text = "";
                    InquiryCommentstextBox.Text = "";
                    InquiryTeacherNamecomboBox.Text = "";
                    InquiryDemoClasscomboBox.Text = "";
                    InquiryFollow1comboBox.Text = "";
                    InquiryFollowerName1comboBox.Text = "";
                    InquiryResponse1comboBox.Text = "";
                    Follower1dateTimePicker.Text = "";
                    InquiryFollow2comboBox.Text = "";
                    InquiryFollowerName2comboBox.Text = "";
                    InquiryResponse2comboBox.Text = "";
                    Follower2dateTimePicker.Text = "";
                    InquiryFollow3comboBox.Text = "";
                    InquiryFollowerName3comboBox.Text = "";
                    InquiryResponse3comboBox.Text = "";
                    Follower3dateTimePicker.Text = "";
                    InquiryPendingDonecomboBox.Text = "";
                    InquiryExpectedFeetextBox.Text = "";
                    
                    SqlCommand cmd0 = new SqlCommand("select COUNT(Inquiry_No) from Inquiry_Table", con);
                    int TotalInquiry = Convert.ToInt32(cmd0.ExecuteScalar());
                    TotalInquirylabel.Text = TotalInquiry.ToString();

                    SqlCommand cmd1 = new SqlCommand("select COUNT(Inquiry_No) from Inquiry_Table where Pending_Done_Cencal='Pending'", con);
                    int InquiryPending = Convert.ToInt32(cmd1.ExecuteScalar());
                    InquiryPendinglabel.Text = InquiryPending.ToString();


                    SqlCommand cmd2 = new SqlCommand("select COUNT(Inquiry_No) from Inquiry_Table where Pending_Done_Cencal='Done'", con);
                    int InquiryDone = Convert.ToInt32(cmd2.ExecuteScalar());
                    InquiryDonelabel.Text = InquiryDone.ToString();

                    SqlCommand cmd3 = new SqlCommand("select COUNT(Inquiry_No) from Inquiry_Table where Pending_Done_Cencal='Cancel'", con);
                    int InquiryCancel = Convert.ToInt32(cmd3.ExecuteScalar());
                    InquiryCancellabel.Text = InquiryCancel.ToString();

                    SqlCommand cmd4 = new SqlCommand("select Max(Inquiry_No) from Inquiry_Table", con);
                    int InquiryNo = Convert.ToInt32(cmd4.ExecuteScalar());
                    InquiryNo = InquiryNo + 1;
                    InquiryNotextBox.Text = InquiryNo.ToString();


                    con.Close();


                }
                catch
                {

                    MessageBox.Show("Data already inserted in database.");
                }
            }
        }

        private void InquiryUpdatebutton_Click(object sender, EventArgs e)
        {
            try
            {


                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("update Inquiry_Table set Inquiry_Date='" + InquirydateTimePicker.Text + "',Attendant='" + InquiryAttendantcomboBox.Text + "',Program='" + InquiryProgramcomboBox.Text + "',Course_Name='" + InquiryCourseNamecomboBox.Text + "',Student_Name='" + InquiryStudentNametextBox.Text + "',Phone='" + InquiryPhonetextBox.Text + "',Potential='" + InquiryPotentialcomboBox.Text + "',Expected_Strength='" + InquiryExpectedStrengthcomboBox.Text + "',Know_About='" + InquiryHowKnowcomboBox.Text + "',Expected_Visit_Date='" + InquiryVisitdateTimePicker.Text + "',Day='" + InquiryDaycomboBox.Text + "',Comments='" + InquiryCommentstextBox.Text + "',Teacher_Name='" + InquiryTeacherNamecomboBox.Text + "',Demo_Class='" + InquiryDemoClasscomboBox.Text + "',Follow_1='" + InquiryFollow1comboBox.Text + "',Follwer_1_Name='" + InquiryFollowerName1comboBox.Text + "',Follower_1_Response='" + InquiryResponse1comboBox.Text + "',Follower_Date_1='" + Follower1dateTimePicker.Text + "',Follow_2='" + InquiryFollow2comboBox.Text + "',Follwer_2_Name='" + InquiryFollowerName2comboBox.Text + "',Follower_2_Response='" + InquiryResponse2comboBox.Text + "',Follower_Date_2='" + Follower2dateTimePicker.Text + "',Follow_3='" + InquiryFollow3comboBox.Text + "',Follwer_3_Name='" + InquiryFollowerName3comboBox.Text + "',Follower_3_Response='" + InquiryResponse3comboBox.Text + "',Follower_Date_3='" + Follower3dateTimePicker.Text + "',Pending_Done_Cencal='" + InquiryPendingDonecomboBox.Text + "',Expected_Fee='" + InquiryExpectedFeetextBox.Text + "' where Inquiry_No='" + InquiryNotextBox.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated into Database.");

                SqlCommand cmd0 = new SqlCommand("select COUNT(Inquiry_No) from Inquiry_Table", con);
                int TotalInquiry = Convert.ToInt32(cmd0.ExecuteScalar());
                TotalInquirylabel.Text = TotalInquiry.ToString();

                SqlCommand cmd1 = new SqlCommand("select COUNT(Inquiry_No) from Inquiry_Table where Pending_Done_Cencal='Pending'", con);
                int InquiryPending = Convert.ToInt32(cmd1.ExecuteScalar());
                InquiryPendinglabel.Text = InquiryPending.ToString();

                SqlCommand cmd3 = new SqlCommand("select COUNT(Inquiry_No) from Inquiry_Table where Pending_Done_Cencal='Cancel'", con);
                int InquiryCancel = Convert.ToInt32(cmd3.ExecuteScalar());
                InquiryCancellabel.Text = InquiryCancel.ToString();

                if (InquiryPendingDonecomboBox.Text == "Done")
                {
                    Admission_Form s = new Admission_Form();
                    s.Show();
                }


            }
            catch
            {
                MessageBox.Show("Data is not update.");
            }

        }

        private void InquiryFindbutton_Click(object sender, EventArgs e)
        {

            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Inquiry_Table where Inquiry_No='" + InquiryNotextBox.Text + "'", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                InquirydateTimePicker.Text = dt.Rows[0][1].ToString();
                InquiryAttendantcomboBox.Text = dt.Rows[0][2].ToString();
                InquiryProgramcomboBox.Text = dt.Rows[0][3].ToString();
                InquiryCourseNamecomboBox.Text = dt.Rows[0][4].ToString();
                InquiryStudentNametextBox.Text = dt.Rows[0][5].ToString();
                InquiryPhonetextBox.Text = dt.Rows[0][6].ToString();
                InquiryPotentialcomboBox.Text = dt.Rows[0][7].ToString();
                InquiryExpectedStrengthcomboBox.Text = dt.Rows[0][8].ToString();
                InquiryHowKnowcomboBox.Text = dt.Rows[0][9].ToString();
                InquiryVisitdateTimePicker.Text = dt.Rows[0][10].ToString();
                InquiryDaycomboBox.Text = dt.Rows[0][11].ToString();
                InquiryCommentstextBox.Text = dt.Rows[0][12].ToString();
                InquiryTeacherNamecomboBox.Text = dt.Rows[0][13].ToString();
                InquiryDemoClasscomboBox.Text = dt.Rows[0][14].ToString();
                InquiryFollow1comboBox.Text = dt.Rows[0][15].ToString();
                InquiryFollowerName1comboBox.Text = dt.Rows[0][16].ToString();
                InquiryResponse1comboBox.Text = dt.Rows[0][17].ToString();
                Follower1dateTimePicker.Text = dt.Rows[0][18].ToString();
                InquiryFollow2comboBox.Text = dt.Rows[0][19].ToString();
                InquiryFollowerName2comboBox.Text = dt.Rows[0][20].ToString();
                InquiryResponse2comboBox.Text = dt.Rows[0][21].ToString();
                Follower2dateTimePicker.Text = dt.Rows[0][22].ToString();
                InquiryFollow3comboBox.Text = dt.Rows[0][23].ToString();
                InquiryFollowerName3comboBox.Text = dt.Rows[0][24].ToString();
                InquiryResponse3comboBox.Text = dt.Rows[0][25].ToString();
                Follower3dateTimePicker.Text = dt.Rows[0][26].ToString();
                InquiryPendingDonecomboBox.Text = dt.Rows[0][27].ToString();
                InquiryExpectedFeetextBox.Text = dt.Rows[0][28].ToString();

            }
            catch
            {
                MessageBox.Show("Data is already saved or data not find");
            }


        }

        private void InquiryDaycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void InquiryVisitdateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void InquiryForm_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con.Open();

            SqlCommand cmd0 = new SqlCommand("select COUNT(Inquiry_No) from Inquiry_Table", con);
            int TotalInquiry = Convert.ToInt32(cmd0.ExecuteScalar());
            TotalInquirylabel.Text = TotalInquiry.ToString();

            SqlCommand cmd1 = new SqlCommand("select COUNT(Inquiry_No) from Inquiry_Table where Pending_Done_Cencal='Pending'", con);
            int InquiryPending = Convert.ToInt32(cmd1.ExecuteScalar());
            InquiryPendinglabel.Text = InquiryPending.ToString();


            SqlCommand cmd2 = new SqlCommand("select COUNT(Inquiry_No) from Inquiry_Table where Pending_Done_Cencal='Done'", con);
            int InquiryDone = Convert.ToInt32(cmd2.ExecuteScalar());
            InquiryDonelabel.Text = InquiryDone.ToString();

            SqlCommand cmd3 = new SqlCommand("select COUNT(Inquiry_No) from Inquiry_Table where Pending_Done_Cencal='Cancel'", con);
            int InquiryCancel = Convert.ToInt32(cmd3.ExecuteScalar());
            InquiryCancellabel.Text = InquiryCancel.ToString();



            try
            {
                SqlCommand cmd4 = new SqlCommand("select Max(Inquiry_No) from Inquiry_Table", con);
                int InquiryNo = Convert.ToInt32(cmd4.ExecuteScalar());
                InquiryNo = InquiryNo + 1;
                InquiryNotextBox.Text = InquiryNo.ToString();
                con.Close();
            }
            catch
            {
               
            }
            con.Close();

            con.Open();
            SqlCommand cmdAttend = new SqlCommand("select EmployName from EmplTable", con);
            SqlDataReader ReaderAttend = cmdAttend.ExecuteReader();
            AutoCompleteStringCollection MyCollectionAttend = new AutoCompleteStringCollection();
            while (ReaderAttend.Read())
            {
                MyCollectionAttend.Add(ReaderAttend.GetString(0));

            }
            InquiryAttendantcomboBox.AutoCompleteCustomSource = MyCollectionAttend;
            con.Close();


            con.Open();
            SqlCommand cmdDep = new SqlCommand("select * from Department", con);
            SqlDataReader ReaderDep = cmdDep.ExecuteReader();
            AutoCompleteStringCollection MyCollectionDep = new AutoCompleteStringCollection();
            while (ReaderDep.Read())
            {
                MyCollectionDep.Add(ReaderDep.GetString(1));

            }
            InquiryProgramcomboBox.AutoCompleteCustomSource = MyCollectionDep;
            con.Close();

            con.Open();
            SqlCommand cmdProg = new SqlCommand("select * from Program", con);
            SqlDataReader ReaderProg = cmdProg.ExecuteReader();
            AutoCompleteStringCollection MyCollectionProg = new AutoCompleteStringCollection();
            while (ReaderProg.Read())
            {
                MyCollectionProg.Add(ReaderProg.GetString(1));

            }
            InquiryCourseNamecomboBox.AutoCompleteCustomSource = MyCollectionProg;
            con.Close();

            con.Open();
            SqlCommand cmdEmpl = new SqlCommand("select EmployName from EmplTable", con);
            SqlDataReader ReaderEmpl = cmdEmpl.ExecuteReader();
            AutoCompleteStringCollection MyCollectionEmpl = new AutoCompleteStringCollection();
            while (ReaderEmpl.Read())
            {
                MyCollectionEmpl.Add(ReaderEmpl.GetString(0));

            }
            InquiryTeacherNamecomboBox.AutoCompleteCustomSource = MyCollectionEmpl;
            con.Close();

            con.Open();
            SqlCommand cmdTim = new SqlCommand("select * from Timing", con);
            SqlDataReader ReaderTim = cmdTim.ExecuteReader();
            AutoCompleteStringCollection MyCollectionTim = new AutoCompleteStringCollection();
            while (ReaderTim.Read())
            {
                MyCollectionTim.Add(ReaderTim.GetString(1));

            }
            InquiryDemoClasscomboBox.AutoCompleteCustomSource = MyCollectionTim;
            con.Close();





        }

        private void InquiryAttendantcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InquiryStudentNametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void InquiryProgramcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            InquiryCourseNamecomboBox.Items.Clear();
            InquiryCourseNamecomboBox.Text = "";
            InquiryTeacherNamecomboBox.Text = "";
            InquiryDemoClasscomboBox.Text = "";
            SqlConnection con2 = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con2.Open();
            SqlCommand cmd2 = new SqlCommand("select Program from Teacher_table$ where Department='" + InquiryProgramcomboBox.SelectedItem + "' group by Program", con2);
            cmd2.ExecuteNonQuery();
            SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);

            foreach (DataRow dr in dt2.Rows)
            {
                InquiryCourseNamecomboBox.Items.Add(dr[0]);

            }
        }

        private void InquiryCourseNamecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            InquiryTeacherNamecomboBox.Items.Clear();

            SqlConnection con2 = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con2.Open();
            SqlCommand cmd2 = new SqlCommand("select Teacher from Teacher_table$ where Department='" + InquiryProgramcomboBox.SelectedItem + "' and Program='" + InquiryCourseNamecomboBox.SelectedItem + "' group by Teacher", con2);
            cmd2.ExecuteNonQuery();
            SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);

            foreach (DataRow dr in dt2.Rows)
            {
                InquiryTeacherNamecomboBox.Items.Add(dr[0]);

            }
        }

        private void InquiryTeacherNamecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            InquiryDemoClasscomboBox.Items.Clear();

            SqlConnection con2 = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con2.Open();
            SqlCommand cmd2 = new SqlCommand("select Timing from Teacher_table$ where Department='" + InquiryProgramcomboBox.SelectedItem + "' and Program='" + InquiryCourseNamecomboBox.SelectedItem + "' and Teacher='" + InquiryTeacherNamecomboBox.SelectedItem + "' group by Timing", con2);
            cmd2.ExecuteNonQuery();
            SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);

            foreach (DataRow dr in dt2.Rows)
            {
                InquiryDemoClasscomboBox.Items.Add(dr[0]);

            }
        }

        private void InquiryInsertbutton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (InquiryAttendantcomboBox.Text == "")
                {
                    MessageBox.Show("Please Enter the Inquiry Number.");
                }
                else
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");

                        con.Open();
                        SqlCommand cmd = new SqlCommand("insert into Inquiry_Table(Inquiry_No,Inquiry_Date,Attendant,Program,Course_Name,Student_Name,Phone,Potential,Expected_Strength,Know_About,Expected_Visit_Date,Day,Comments,Teacher_Name,Demo_Class,Follow_1,Follwer_1_Name,Follower_1_Response,Follower_Date_1,Follow_2,Follwer_2_Name,Follower_2_Response,Follower_Date_2,Follow_3,Follwer_3_Name,Follower_3_Response,Follower_Date_3,Pending_Done_Cencal,Expected_Fee)values('" + InquiryNotextBox.Text + "','" + InquirydateTimePicker.Text + "','" + InquiryAttendantcomboBox.Text + "','" + InquiryProgramcomboBox.Text + "','" + InquiryCourseNamecomboBox.Text + "','" + InquiryStudentNametextBox.Text + "','" + InquiryPhonetextBox.Text + "','" + InquiryPotentialcomboBox.Text + "','" + InquiryExpectedStrengthcomboBox.Text + "','" + InquiryHowKnowcomboBox.Text + "','" + InquiryVisitdateTimePicker.Text + "','" + InquiryDaycomboBox.Text + "','" + InquiryCommentstextBox.Text + "','" + InquiryTeacherNamecomboBox.Text + "','" + InquiryDemoClasscomboBox.Text + "','" + InquiryFollow1comboBox.Text + "','" + InquiryFollowerName1comboBox.Text + "','" + InquiryResponse1comboBox.Text + "','" + Follower1dateTimePicker.Text + "','" + InquiryFollow2comboBox.Text + "','" + InquiryFollowerName2comboBox.Text + "','" + InquiryResponse2comboBox.Text + "','" + Follower2dateTimePicker.Text + "','" + InquiryFollow3comboBox.Text + "','" + InquiryFollowerName3comboBox.Text + "','" + InquiryResponse3comboBox.Text + "','" + Follower3dateTimePicker.Text + "','" + InquiryPendingDonecomboBox.Text + "','" + InquiryExpectedFeetextBox.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data inserted into Database.");


                        InquirydateTimePicker.Text = "";
                        InquiryAttendantcomboBox.Text = "";
                        InquiryProgramcomboBox.Text = "";
                        InquiryCourseNamecomboBox.Text = "";
                        InquiryStudentNametextBox.Text = "";
                        InquiryPhonetextBox.Text = "";
                        InquiryPotentialcomboBox.Text = "";
                        InquiryExpectedStrengthcomboBox.Text = "";
                        InquiryHowKnowcomboBox.Text = "";
                        InquiryVisitdateTimePicker.Text = "";
                        InquiryDaycomboBox.Text = "";
                        InquiryCommentstextBox.Text = "";
                        InquiryTeacherNamecomboBox.Text = "";
                        InquiryDemoClasscomboBox.Text = "";
                        InquiryFollow1comboBox.Text = "";
                        InquiryFollowerName1comboBox.Text = "";
                        InquiryResponse1comboBox.Text = "";
                        Follower1dateTimePicker.Text = "";
                        InquiryFollow2comboBox.Text = "";
                        InquiryFollowerName2comboBox.Text = "";
                        InquiryResponse2comboBox.Text = "";
                        Follower2dateTimePicker.Text = "";
                        InquiryFollow3comboBox.Text = "";
                        InquiryFollowerName3comboBox.Text = "";
                        InquiryResponse3comboBox.Text = "";
                        Follower3dateTimePicker.Text = "";
                        InquiryPendingDonecomboBox.Text = "";
                        InquiryExpectedFeetextBox.Text = "";

                        SqlCommand cmd0 = new SqlCommand("select COUNT(Inquiry_No) from Inquiry_Table", con);
                        int TotalInquiry = Convert.ToInt32(cmd0.ExecuteScalar());
                        TotalInquirylabel.Text = TotalInquiry.ToString();

                        SqlCommand cmd1 = new SqlCommand("select COUNT(Inquiry_No) from Inquiry_Table where Pending_Done_Cencal='Pending'", con);
                        int InquiryPending = Convert.ToInt32(cmd1.ExecuteScalar());
                        InquiryPendinglabel.Text = InquiryPending.ToString();


                        SqlCommand cmd2 = new SqlCommand("select COUNT(Inquiry_No) from Inquiry_Table where Pending_Done_Cencal='Done'", con);
                        int InquiryDone = Convert.ToInt32(cmd2.ExecuteScalar());
                        InquiryDonelabel.Text = InquiryDone.ToString();

                        SqlCommand cmd3 = new SqlCommand("select COUNT(Inquiry_No) from Inquiry_Table where Pending_Done_Cencal='Cancel'", con);
                        int InquiryCancel = Convert.ToInt32(cmd3.ExecuteScalar());
                        InquiryCancellabel.Text = InquiryCancel.ToString();

                        SqlCommand cmd4 = new SqlCommand("select Max(Inquiry_No) from Inquiry_Table", con);
                        int InquiryNo = Convert.ToInt32(cmd4.ExecuteScalar());
                        InquiryNo = InquiryNo + 1;
                        InquiryNotextBox.Text = InquiryNo.ToString();


                        con.Close();


                    }
                    catch
                    {

                        MessageBox.Show("Data already inserted in database.");
                    }
                }
            }

        }

        private void Follower1dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Follower1dateTimePicker.CustomFormat = "dd-MMM-yyy";
        }

        private void Follower2dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Follower2dateTimePicker.CustomFormat = "dd-MMM-yyy";
        }

        private void Follower3dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Follower3dateTimePicker.CustomFormat = "dd-MMM-yyy";
        }
    }
}    




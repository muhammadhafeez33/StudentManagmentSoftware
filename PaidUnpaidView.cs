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
    public partial class PaidUnpaidView : Main_Form
    {
        public PaidUnpaidView()
        {
            InitializeComponent();
        }

        private void PaidUnpaidcomboBox_SelectedIndexChanged(object sender, EventArgs e)
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
                dataGridView1.DataSource = dt;
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
                dataGridView1.DataSource = dt;
                con.Close();




            }

            else
            {
                MessageBox.Show("Select Paid and Unpaid Student");
            }
        }

        private void Ropertbutton_Click(object sender, EventArgs e)
        {
            UnpaidStudentForm s = new UnpaidStudentForm();
            s.Show();
        }

        private void PaidUnpaidView_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select Branch_Code,Student_Id,Student_Name,Department,Program,Teacher,Timing,Adm_Date,Due_Date,DATEDIFF(DAY,Due_Date,GETDATE()) as UnpaidDay,DATEDIFF(MONTH,Due_Date,GETDATE()) as UnpaidMonth from Lingo$ where StudentStatus='Active' and DATEDIFF(DAY,Due_Date,GETDATE())>30 ", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void PaidUnpaidSearchingtextBox_TextChanged(object sender, EventArgs e)
        {
            
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
                dataGridView1.DataSource = dt;
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
                dataGridView1.DataSource = dt;
                con.Close();
            }

            else
            {
                MessageBox.Show("Select Paid and Unpaid Student");
            }
        }
    }
}

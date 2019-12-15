using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lingo_Application
{
    public partial class DPTTForm : Main_Form
    {
        public DPTTForm()
        {
            InitializeComponent();
        }

        private void SelectTableNamecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

           
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmd;
            if (SelectTableNamecomboBox.Text == "Department")
            {
                cmd = new SqlCommand("select * from Department", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            else if (SelectTableNamecomboBox.Text == "Program")
            {
                cmd = new SqlCommand("select * from Program", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
            }
           
            else if (SelectTableNamecomboBox.Text == "Timing")
            {
                cmd = new SqlCommand("select * from Timing", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Table name is not correct");
            }

          
        }

        private void SugSavebutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmd;
            if (SuggestionTexttextBox.Text == "")
            {
                MessageBox.Show("Enter the Suggestio Text ");
            }
            else { 
            if (SelectTableNamecomboBox.Text == "Department")
            {
                cmd = new SqlCommand("insert into Department(SuggestionDepartment)values('"+SuggestionTexttextBox.Text+"')", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Department", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MessageBox.Show("Saved");
                dataGridView2.DataSource = dt;
                SuggestionTexttextBox.Text = "";
                
            }
            else if (SelectTableNamecomboBox.Text == "Program")
            {
                cmd = new SqlCommand("insert into Program(SuggestionProgram)values('" + SuggestionTexttextBox.Text + "')", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Program", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MessageBox.Show("Saved");
                dataGridView2.DataSource = dt;
                    SuggestionTexttextBox.Text = "";

                }
           else if (SelectTableNamecomboBox.Text == "Timing")
            {
                cmd = new SqlCommand("insert into Timing(SuggestionTiming)values('" + SuggestionTexttextBox.Text + "')", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Timing", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MessageBox.Show("Saved");
                dataGridView2.DataSource = dt;
                    SuggestionTexttextBox.Text = "";
                }
            else
            {
                MessageBox.Show("not save");
            }
            }
        }

        private void SugUpdatebutton_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmd;
            if (SugSNotextBox.Text == "")
            {
                MessageBox.Show("enter the id number find data then change and update ");
            }
            else
            {
                if (SelectTableNamecomboBox.Text == "Department")
                {
                    cmd = new SqlCommand("update Department set SuggestionDepartment='" + SuggestionTexttextBox.Text + "' where Id='" + SugSNotextBox.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter("select * from Department where Id='" + SugSNotextBox.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MessageBox.Show("Updated");
                    dataGridView2.DataSource = dt;
                    SuggestionTexttextBox.Text = "";

                }
                else if (SelectTableNamecomboBox.Text == "Program")
                {
                    cmd = new SqlCommand("update Program set SuggestionProgram='" + SuggestionTexttextBox.Text + "' where Id='" + SugSNotextBox.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter("select * from Program where Id='" + SugSNotextBox.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MessageBox.Show("Updated");
                    dataGridView2.DataSource = dt;
                    SuggestionTexttextBox.Text = "";

                }
                
                else if (SelectTableNamecomboBox.Text == "Timing")
                {
                    cmd = new SqlCommand("update Timing set SuggestionTiming='" + SuggestionTexttextBox.Text + "' where Id='" + SugSNotextBox.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter("select * from Timing where Id='" + SugSNotextBox.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MessageBox.Show("Updated");
                    dataGridView2.DataSource = dt;
                    SuggestionTexttextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("not Updated");
                }

            }
        }
        private void SugFindbutton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd;
                if (SelectTableNamecomboBox.Text == "Department")
                {
                    cmd = new SqlCommand("select * from Department where Id='" + SugSNotextBox.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView2.DataSource = dt;
                    SuggestionTexttextBox.Text = dt.Rows[0][1].ToString();
                }
                else if (SelectTableNamecomboBox.Text == "Program")
                {
                    cmd = new SqlCommand("select * from Program where Id='" + SugSNotextBox.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView2.DataSource = dt;
                    SuggestionTexttextBox.Text = dt.Rows[0][1].ToString();
                }
                
                else if (SelectTableNamecomboBox.Text == "Timing")
                {
                    cmd = new SqlCommand("select * from Timing where Id='" + SugSNotextBox.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView2.DataSource = dt;
                    SuggestionTexttextBox.Text = dt.Rows[0][1].ToString();
                }
                else
                {
                    MessageBox.Show("data not found");
                }
            }
            catch
            {
                MessageBox.Show("data not found");
            }

        }

        private void DPTTForm_Load(object sender, EventArgs e)
        {

        }
    }
}

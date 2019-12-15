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
    public partial class FilterRecordForm : Main_Form
    {
        public FilterRecordForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text== "Student Admission")
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Lingo$", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                dataGridView1.DataSource = dt;
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select Branch_Code,Student_Id,Student_Name,Department,Program,Teacher,Timing,SlipNo,AdmissionFee,MonthlyFee,TotalFee,Balance,MonthInstLums,PaymentDate,FeeMonth,Year,Due_Date from Lingo$ left join StudentFee on Lingo$.Student_Id = StudentFee.AdmissionId", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sdaGrid = new SqlDataAdapter(cmd);
                DataTable dtGrid = new DataTable();
                sdaGrid.Fill(dtGrid);
                dataGridView1.DataSource = dtGrid;
                con.Close();

                int sumAdm = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells["AdmissionFee"].Value != DBNull.Value)
                    {
                        sumAdm += Convert.ToInt32(dataGridView1.Rows[i].Cells["AdmissionFee"].Value);
                    }
                    AdmAmountlabel.Text = sumAdm.ToString();
                }

                int sumMonthly = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells["MonthlyFee"].Value != DBNull.Value)
                    {
                        sumMonthly += Convert.ToInt32(dataGridView1.Rows[i].Cells["MonthlyFee"].Value);
                    }
                    MonthlyAmountlabel.Text = sumMonthly.ToString();
                }


                int sumTotal = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells["TotalFee"].Value != DBNull.Value)
                    {
                        sumTotal += Convert.ToInt32(dataGridView1.Rows[i].Cells["TotalFee"].Value);
                    }
                    TotalFeeAmountlabel.Text = sumTotal.ToString();
                }

                int sumBalance= 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells["Balance"].Value != DBNull.Value)
                    {
                        sumBalance += Convert.ToInt32(dataGridView1.Rows[i].Cells["Balance"].Value);
                    }
                    BalanceAmountlabel.Text = sumBalance.ToString();
                }

            }
        }

        private void FilterRecordForm_Load(object sender, EventArgs e)
        {
           
            SqlConnection conDep = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            conDep.Open();
            SqlCommand cmdDep = new SqlCommand("select Department from Lingo$ group by Department", conDep);
            cmdDep.ExecuteNonQuery();
            SqlDataAdapter sdaDep = new SqlDataAdapter(cmdDep);
            DataTable dtDep = new DataTable();
            sdaDep.Fill(dtDep);

            foreach (DataRow dr in dtDep.Rows)
            {
                DepartmentcomboBox.Items.Add(dr[0]);

            }


        }

        private void DepartmentcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            ProgramcomboBox.Items.Clear();
            ProgramcomboBox.Text = "";
            TeachercomboBox.Items.Clear();
            TeachercomboBox.Text = "";
            TimingcomboBox.Items.Clear();
            TimingcomboBox.Text = "";

            SqlConnection conDep = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            conDep.Open();
            SqlCommand cmdDep = new SqlCommand("select Program from Lingo$ where Department='"+DepartmentcomboBox.Text+"' group by Program", conDep);
            cmdDep.ExecuteNonQuery();
            SqlDataAdapter sdaDep = new SqlDataAdapter(cmdDep);
            DataTable dtDep = new DataTable();
            sdaDep.Fill(dtDep);

            foreach (DataRow dr in dtDep.Rows)
            {
                ProgramcomboBox.Items.Add(dr[0]);

            }

            if (comboBox1.Text == "Student Admission")
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Lingo$ where StudentStatus='" + StudentStatuscomboBox.Text + "' and Department='" + DepartmentcomboBox.Text + "'", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                dataGridView1.DataSource = dt;
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select Branch_Code,Student_Id,Student_Name,Department,Program,Teacher,Timing,SlipNo,AdmissionFee,MonthlyFee,TotalFee,Balance,MonthInstLums,PaymentDate,FeeMonth,Year,Due_Date from Lingo$ left join StudentFee on Lingo$.Student_Id = StudentFee.AdmissionId where StudentStatus='" + StudentStatuscomboBox.Text + "' and Department='" + DepartmentcomboBox.Text + "'", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sdaGrid = new SqlDataAdapter(cmd);
                DataTable dtGrid = new DataTable();
                sdaGrid.Fill(dtGrid);
                dataGridView1.DataSource = dtGrid;
                con.Close();

                int sumAdm = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells["AdmissionFee"].Value != DBNull.Value)
                    {
                        sumAdm += Convert.ToInt32(dataGridView1.Rows[i].Cells["AdmissionFee"].Value);
                    }
                    AdmAmountlabel.Text = sumAdm.ToString();
                }

                int sumMonthly = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells["MonthlyFee"].Value != DBNull.Value)
                    {
                        sumMonthly += Convert.ToInt32(dataGridView1.Rows[i].Cells["MonthlyFee"].Value);
                    }
                    MonthlyAmountlabel.Text = sumMonthly.ToString();
                }


                int sumTotal = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells["TotalFee"].Value != DBNull.Value)
                    {
                        sumTotal += Convert.ToInt32(dataGridView1.Rows[i].Cells["TotalFee"].Value);
                    }
                    TotalFeeAmountlabel.Text = sumTotal.ToString();
                }

                int sumBalance = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells["Balance"].Value != DBNull.Value)
                    {
                        sumBalance += Convert.ToInt32(dataGridView1.Rows[i].Cells["Balance"].Value);
                    }
                    BalanceAmountlabel.Text = sumBalance.ToString();
                }

            }
        }

        private void ProgramcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           

            SqlConnection conDep = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            conDep.Open();
            SqlCommand cmdDep = new SqlCommand("select Teacher from Lingo$ where Department='" + DepartmentcomboBox.Text + "' and Program='"+ProgramcomboBox.Text+"' group by Teacher", conDep);
            cmdDep.ExecuteNonQuery();
            SqlDataAdapter sdaDep = new SqlDataAdapter(cmdDep);
            DataTable dtDep = new DataTable();
            sdaDep.Fill(dtDep);

            foreach (DataRow dr in dtDep.Rows)
            {
                TeachercomboBox.Items.Add(dr[0]);

            }

            if (comboBox1.Text == "Student Admission")
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Lingo$ where StudentStatus='" + StudentStatuscomboBox.Text + "' and Department='" + DepartmentcomboBox.Text + "' and Program='" + ProgramcomboBox.Text + "'", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                dataGridView1.DataSource = dt;
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select Branch_Code,Student_Id,Student_Name,Department,Program,Teacher,Timing,SlipNo,AdmissionFee,MonthlyFee,TotalFee,Balance,MonthInstLums,PaymentDate,FeeMonth,Year,Due_Date from Lingo$ left join StudentFee on Lingo$.Student_Id = StudentFee.AdmissionId where StudentStatus='" + StudentStatuscomboBox.Text + "' and Department='" + DepartmentcomboBox.Text + "' and Program='" + ProgramcomboBox.Text + "'", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sdaGrid = new SqlDataAdapter(cmd);
                DataTable dtGrid = new DataTable();
                sdaGrid.Fill(dtGrid);
                dataGridView1.DataSource = dtGrid;
                con.Close();

                int sumAdm = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells["AdmissionFee"].Value != DBNull.Value)
                    {
                        sumAdm += Convert.ToInt32(dataGridView1.Rows[i].Cells["AdmissionFee"].Value);
                    }
                    AdmAmountlabel.Text = sumAdm.ToString();
                }

                int sumMonthly = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells["MonthlyFee"].Value != DBNull.Value)
                    {
                        sumMonthly += Convert.ToInt32(dataGridView1.Rows[i].Cells["MonthlyFee"].Value);
                    }
                    MonthlyAmountlabel.Text = sumMonthly.ToString();
                }


                int sumTotal = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells["TotalFee"].Value != DBNull.Value)
                    {
                        sumTotal += Convert.ToInt32(dataGridView1.Rows[i].Cells["TotalFee"].Value);
                    }
                    TotalFeeAmountlabel.Text = sumTotal.ToString();
                }

                int sumBalance = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells["Balance"].Value != DBNull.Value)
                    {
                        sumBalance += Convert.ToInt32(dataGridView1.Rows[i].Cells["Balance"].Value);
                    }
                    BalanceAmountlabel.Text = sumBalance.ToString();
                }

            }
        }

        private void TeachercomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conDep = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            conDep.Open();
            SqlCommand cmdDep = new SqlCommand("select Timing from Lingo$ where Department='" + DepartmentcomboBox.Text + "' and Program='" + ProgramcomboBox.Text + "' and Teacher='"+TeachercomboBox.Text+"' group by Timing", conDep);
            cmdDep.ExecuteNonQuery();
            SqlDataAdapter sdaDep = new SqlDataAdapter(cmdDep);
            DataTable dtDep = new DataTable();
            sdaDep.Fill(dtDep);

            foreach (DataRow dr in dtDep.Rows)
            {
                TimingcomboBox.Items.Add(dr[0]);

            }

            if (comboBox1.Text == "Student Admission")
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Lingo$ where StudentStatus='" + StudentStatuscomboBox.Text + "' and Department='" + DepartmentcomboBox.Text + "' and Program='" + ProgramcomboBox.Text + "' and Teacher='" + TeachercomboBox.Text + "'", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                dataGridView1.DataSource = dt;
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select Branch_Code,Student_Id,Student_Name,Department,Program,Teacher,Timing,SlipNo,AdmissionFee,MonthlyFee,TotalFee,Balance,MonthInstLums,PaymentDate,FeeMonth,Year,Due_Date from Lingo$ left join StudentFee on Lingo$.Student_Id = StudentFee.AdmissionId where StudentStatus='" + StudentStatuscomboBox.Text + "' and Department='" + DepartmentcomboBox.Text + "' and Program='" + ProgramcomboBox.Text + "' and Teacher='" + TeachercomboBox.Text + "'", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sdaGrid = new SqlDataAdapter(cmd);
                DataTable dtGrid = new DataTable();
                sdaGrid.Fill(dtGrid);
                dataGridView1.DataSource = dtGrid;
                con.Close();

                int sumAdm = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells["AdmissionFee"].Value != DBNull.Value)
                    {
                        sumAdm += Convert.ToInt32(dataGridView1.Rows[i].Cells["AdmissionFee"].Value);
                    }
                    AdmAmountlabel.Text = sumAdm.ToString();
                }

                int sumMonthly = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells["MonthlyFee"].Value != DBNull.Value)
                    {
                        sumMonthly += Convert.ToInt32(dataGridView1.Rows[i].Cells["MonthlyFee"].Value);
                    }
                    MonthlyAmountlabel.Text = sumMonthly.ToString();
                }


                int sumTotal = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells["TotalFee"].Value != DBNull.Value)
                    {
                        sumTotal += Convert.ToInt32(dataGridView1.Rows[i].Cells["TotalFee"].Value);
                    }
                    TotalFeeAmountlabel.Text = sumTotal.ToString();
                }

                int sumBalance = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells["Balance"].Value != DBNull.Value)
                    {
                        sumBalance += Convert.ToInt32(dataGridView1.Rows[i].Cells["Balance"].Value);
                    }
                    BalanceAmountlabel.Text = sumBalance.ToString();
                }

            }
        }

        private void StudentStatuscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Student Admission")
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Lingo$ where StudentStatus='" + StudentStatuscomboBox.Text + "'", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                dataGridView1.DataSource = dt;
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select Branch_Code,Student_Id,Student_Name,Department,Program,Teacher,Timing,SlipNo,AdmissionFee,MonthlyFee,TotalFee,Balance,MonthInstLums,PaymentDate,FeeMonth,Year,Due_Date from Lingo$ left join StudentFee on Lingo$.Student_Id = StudentFee.AdmissionId where StudentStatus='" + StudentStatuscomboBox.Text + "'", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sdaGrid = new SqlDataAdapter(cmd);
                DataTable dtGrid = new DataTable();
                sdaGrid.Fill(dtGrid);
                dataGridView1.DataSource = dtGrid;
                con.Close();

                int sumAdm = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells["AdmissionFee"].Value != DBNull.Value)
                    {
                        sumAdm += Convert.ToInt32(dataGridView1.Rows[i].Cells["AdmissionFee"].Value);
                    }
                    AdmAmountlabel.Text = sumAdm.ToString();
                }

                int sumMonthly = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells["MonthlyFee"].Value != DBNull.Value)
                    {
                        sumMonthly += Convert.ToInt32(dataGridView1.Rows[i].Cells["MonthlyFee"].Value);
                    }
                    MonthlyAmountlabel.Text = sumMonthly.ToString();
                }


                int sumTotal = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells["TotalFee"].Value != DBNull.Value)
                    {
                        sumTotal += Convert.ToInt32(dataGridView1.Rows[i].Cells["TotalFee"].Value);
                    }
                    TotalFeeAmountlabel.Text = sumTotal.ToString();
                }

                int sumBalance = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells["Balance"].Value != DBNull.Value)
                    {
                        sumBalance += Convert.ToInt32(dataGridView1.Rows[i].Cells["Balance"].Value);
                    }
                    BalanceAmountlabel.Text = sumBalance.ToString();
                }

            }
        }

        private void TimingcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Student Admission")
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Lingo$ where StudentStatus='" + StudentStatuscomboBox.Text + "' and Department='" + DepartmentcomboBox.Text + "' and Program='" + ProgramcomboBox.Text + "' and Teacher='" + TeachercomboBox.Text + "' and Timing='" + TimingcomboBox.Text + "' ", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                dataGridView1.DataSource = dt;
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select Branch_Code,Student_Id,Student_Name,Department,Program,Teacher,Timing,SlipNo,AdmissionFee,MonthlyFee,TotalFee,Balance,MonthInstLums,PaymentDate,FeeMonth,Year,Due_Date from Lingo$ left join StudentFee on Lingo$.Student_Id = StudentFee.AdmissionId where StudentStatus='" + StudentStatuscomboBox.Text + "' and Department='" + DepartmentcomboBox.Text + "' and Program='" + ProgramcomboBox.Text + "' and Teacher='" + TeachercomboBox.Text + "' and Timing='" + TimingcomboBox.Text + "' ", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sdaGrid = new SqlDataAdapter(cmd);
                DataTable dtGrid = new DataTable();
                sdaGrid.Fill(dtGrid);
                dataGridView1.DataSource = dtGrid;
                con.Close();

                int sumAdm = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells["AdmissionFee"].Value != DBNull.Value)
                    {
                        sumAdm += Convert.ToInt32(dataGridView1.Rows[i].Cells["AdmissionFee"].Value);
                    }
                    AdmAmountlabel.Text = sumAdm.ToString();
                }

                int sumMonthly = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells["MonthlyFee"].Value != DBNull.Value)
                    {
                        sumMonthly += Convert.ToInt32(dataGridView1.Rows[i].Cells["MonthlyFee"].Value);
                    }
                    MonthlyAmountlabel.Text = sumMonthly.ToString();
                }


                int sumTotal = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells["TotalFee"].Value != DBNull.Value)
                    {
                        sumTotal += Convert.ToInt32(dataGridView1.Rows[i].Cells["TotalFee"].Value);
                    }
                    TotalFeeAmountlabel.Text = sumTotal.ToString();
                }

                int sumBalance = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells["Balance"].Value != DBNull.Value)
                    {
                        sumBalance += Convert.ToInt32(dataGridView1.Rows[i].Cells["Balance"].Value);
                    }
                    BalanceAmountlabel.Text = sumBalance.ToString();
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Student Admission")
            {

                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Lingo$ where Adm_Date between '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "'", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sdaGrid = new SqlDataAdapter(cmd);
                DataTable dtGrid = new DataTable();
                sdaGrid.Fill(dtGrid);
                dataGridView1.DataSource = dtGrid;
                con.Close();
            }
            else
            {

                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select Branch_Code,Student_Id,Student_Name,Department,Program,Teacher,Timing,SlipNo,AdmissionFee,MonthlyFee,TotalFee,Balance,MonthInstLums,PaymentDate,FeeMonth,Year,Due_Date from Lingo$ left join StudentFee on Lingo$.Student_Id = StudentFee.AdmissionId where PaymentDate between '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "'", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sdaGrid = new SqlDataAdapter(cmd);
                DataTable dtGrid = new DataTable();
                sdaGrid.Fill(dtGrid);
                dataGridView1.DataSource = dtGrid;
                con.Close();

                int sumAdm = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells["AdmissionFee"].Value != DBNull.Value)
                    {
                        sumAdm += Convert.ToInt32(dataGridView1.Rows[i].Cells["AdmissionFee"].Value);
                    }
                    AdmAmountlabel.Text = sumAdm.ToString();
                }

                int sumMonthly = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells["MonthlyFee"].Value != DBNull.Value)
                    {
                        sumMonthly += Convert.ToInt32(dataGridView1.Rows[i].Cells["MonthlyFee"].Value);
                    }
                    MonthlyAmountlabel.Text = sumMonthly.ToString();
                }


                int sumTotal = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells["TotalFee"].Value != DBNull.Value)
                    {
                        sumTotal += Convert.ToInt32(dataGridView1.Rows[i].Cells["TotalFee"].Value);
                    }
                    TotalFeeAmountlabel.Text = sumTotal.ToString();
                }

                int sumBalance = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells["Balance"].Value != DBNull.Value)
                    {
                        sumBalance += Convert.ToInt32(dataGridView1.Rows[i].Cells["Balance"].Value);
                    }
                    BalanceAmountlabel.Text = sumBalance.ToString();
                }


            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Student Admission")
            {

                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Lingo$ where Adm_Date between '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "'", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sdaGrid = new SqlDataAdapter(cmd);
                DataTable dtGrid = new DataTable();
                sdaGrid.Fill(dtGrid);
                dataGridView1.DataSource = dtGrid;
                con.Close();
            }
            else
            {

                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select Branch_Code,Student_Id,Student_Name,Department,Program,Teacher,Timing,SlipNo,AdmissionFee,MonthlyFee,TotalFee,Balance,MonthInstLums,PaymentDate,FeeMonth,Year,Due_Date from Lingo$ left join StudentFee on Lingo$.Student_Id = StudentFee.AdmissionId where PaymentDate between '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "'", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sdaGrid = new SqlDataAdapter(cmd);
                DataTable dtGrid = new DataTable();
                sdaGrid.Fill(dtGrid);
                dataGridView1.DataSource = dtGrid;
                con.Close();

                int sumAdm = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells["AdmissionFee"].Value != DBNull.Value)
                    {
                        sumAdm += Convert.ToInt32(dataGridView1.Rows[i].Cells["AdmissionFee"].Value);
                    }
                    AdmAmountlabel.Text = sumAdm.ToString();
                }

                int sumMonthly = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells["MonthlyFee"].Value != DBNull.Value)
                    {
                        sumMonthly += Convert.ToInt32(dataGridView1.Rows[i].Cells["MonthlyFee"].Value);
                    }
                    MonthlyAmountlabel.Text = sumMonthly.ToString();
                }


                int sumTotal = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells["TotalFee"].Value != DBNull.Value)
                    {
                        sumTotal += Convert.ToInt32(dataGridView1.Rows[i].Cells["TotalFee"].Value);
                    }
                    TotalFeeAmountlabel.Text = sumTotal.ToString();
                }

                int sumBalance = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    if (dataGridView1.Rows[i].Cells["Balance"].Value != DBNull.Value)
                    {
                        sumBalance += Convert.ToInt32(dataGridView1.Rows[i].Cells["Balance"].Value);
                    }
                    BalanceAmountlabel.Text = sumBalance.ToString();
                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
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

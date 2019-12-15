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
    public partial class ExpenseForm : Main_Form
    {
        public ExpenseForm()
        {
            InitializeComponent();
        }

        private void ExpenseForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Expense", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sdaGrid = new SqlDataAdapter(cmd);
            DataTable dtGrid = new DataTable();
            sdaGrid.Fill(dtGrid);
            dataGridView1.DataSource = dtGrid;
            con.Close();

            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["TotalExpense"].Value != DBNull.Value)
                {
                    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["TotalExpense"].Value);
                }
                TotalExplabel.Text = sum.ToString();
            }

            int sumMarketing = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["Marketing"].Value != DBNull.Value)
                {
                    sumMarketing += Convert.ToInt32(dataGridView1.Rows[i].Cells["Marketing"].Value);
                }
                Marklabel.Text = sumMarketing.ToString();
            }

            int sumDevelopment = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["Development"].Value != DBNull.Value)
                {
                    sumDevelopment += Convert.ToInt32(dataGridView1.Rows[i].Cells["Development"].Value);
                }
                Developlabel.Text = sumDevelopment.ToString();
            }

            int sumUtilitiesBill = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["UtilitiesBill"].Value != DBNull.Value)
                {
                    sumUtilitiesBill += Convert.ToInt32(dataGridView1.Rows[i].Cells["UtilitiesBill"].Value);
                }
                Billlabel.Text = sumUtilitiesBill.ToString();
            }

            int sumEntertainment = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["Entertainment"].Value != DBNull.Value)
                {
                    sumEntertainment += Convert.ToInt32(dataGridView1.Rows[i].Cells["Entertainment"].Value);
                }
                Entertainlabel.Text = sumEntertainment.ToString();
            }

            int sumDailyExpsence = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["DailyExpsence"].Value != DBNull.Value)
                {
                    sumDailyExpsence += Convert.ToInt32(dataGridView1.Rows[i].Cells["DailyExpsence"].Value);
                }
                DailyExplabel.Text = sumDailyExpsence.ToString();
            }


            int sumInventory = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["Inventory"].Value != DBNull.Value)
                {
                    sumInventory += Convert.ToInt32(dataGridView1.Rows[i].Cells["Inventory"].Value);
                }
                Inventorylabel.Text = sumInventory.ToString();
            }

            int sumBuildingRent = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["BuildingRent"].Value != DBNull.Value)
                {
                    sumBuildingRent += Convert.ToInt32(dataGridView1.Rows[i].Cells["BuildingRent"].Value);
                }
                Rentlabel.Text = sumBuildingRent.ToString();
            }

            int sumAmountReceivable = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["AmountReceivable"].Value != DBNull.Value)
                {
                    sumAmountReceivable += Convert.ToInt32(dataGridView1.Rows[i].Cells["AmountReceivable"].Value);
                }
                Recelabel.Text = sumAmountReceivable.ToString();
            }

            int sumBedDepts = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["BedDepts"].Value != DBNull.Value)
                {
                    sumBedDepts += Convert.ToInt32(dataGridView1.Rows[i].Cells["BedDepts"].Value);
                }
                Bedlabel.Text = sumBedDepts.ToString();
            }

            int sumTransferTo = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["TransferTo"].Value != DBNull.Value)
                {
                    sumTransferTo += Convert.ToInt32(dataGridView1.Rows[i].Cells["TransferTo"].Value);
                }
                Transferlabel.Text = sumTransferTo.ToString();
            }

            int sumOtherExp = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["OtherExp"].Value != DBNull.Value)
                {
                    sumOtherExp += Convert.ToInt32(dataGridView1.Rows[i].Cells["OtherExp"].Value);
                }
                OtherExplabel.Text = sumOtherExp.ToString();
            }

        }

        private void ExpSavebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ExpdateTimePicker.Text == "" && MonthcomboBox.Text == "" && YearcomboBox.Text == "")
                {
                    MessageBox.Show("Please select date month and year");
                }

                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Expense(ExpenseName,Date,ExpMonth,ExpYear,Marketing,Development,UtilitiesBill,Entertainment,DailyExpsence,Inventory,BuildingRent,AmountReceivable,BedDepts,TransferTo,OtherExp,TotalExpense)values('"+ExpNametextBox.Text+"','"+ExpdateTimePicker.Text+ "','"+MonthcomboBox.Text+ "','"+YearcomboBox.Text+ "','"+ExpMarketingtextBox.Text+ "','"+ExpDevelopmenttextBox.Text+ "','"+ExpUtilitiesBilltextBox.Text+ "','"+ExpEntertaimenttextBox.Text+ "','"+ExpDailytextBox.Text+ "','"+ExpInventorytextBox.Text+ "','"+ExpBuildingtextBox.Text+ "','"+ExpAmountReceivtextBox.Text+ "','"+ExpBedDeptstextBox.Text+ "','"+ExpTransferTotextBox.Text+ "','"+OtherExptextBox.Text+"','"+ExpenTotaltextBox.Text+"')", con);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sdaGrid = new SqlDataAdapter("select * from Expense", con);
                    DataTable dtGrid = new DataTable();
                    sdaGrid.Fill(dtGrid);
                    dataGridView1.DataSource = dtGrid;
                    con.Close();
                    MessageBox.Show("Saved");

                    ExpIdtextBox.Text = "";
                    ExpNametextBox.Text = "";
                    ExpdateTimePicker.Text = "";
                    MonthcomboBox.Text = "";
                    YearcomboBox.Text = "";
                    ExpMarketingtextBox.Text = "0";
                    ExpDevelopmenttextBox.Text = "0";
                    ExpUtilitiesBilltextBox.Text = "0";
                    ExpEntertaimenttextBox.Text = "0";
                    ExpDailytextBox.Text = "0";
                    ExpInventorytextBox.Text = "0";
                    ExpBuildingtextBox.Text = "0";
                    ExpAmountReceivtextBox.Text = "0";
                    ExpBedDeptstextBox.Text = "0";
                    ExpTransferTotextBox.Text = "0";
                    OtherExptextBox.Text = "0";
                    ExpenTotaltextBox.Text = "0";

                    int sum = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["TotalExpense"].Value != DBNull.Value)
                        {
                            sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["TotalExpense"].Value);
                        }
                        TotalExplabel.Text = sum.ToString();
                    }

                    int sumMarketing = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["Marketing"].Value != DBNull.Value)
                        {
                            sumMarketing += Convert.ToInt32(dataGridView1.Rows[i].Cells["Marketing"].Value);
                        }
                        Marklabel.Text = sumMarketing.ToString();
                    }

                    int sumDevelopment = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["Development"].Value != DBNull.Value)
                        {
                            sumDevelopment += Convert.ToInt32(dataGridView1.Rows[i].Cells["Development"].Value);
                        }
                        Developlabel.Text = sumDevelopment.ToString();
                    }

                    int sumUtilitiesBill = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["UtilitiesBill"].Value != DBNull.Value)
                        {
                            sumUtilitiesBill += Convert.ToInt32(dataGridView1.Rows[i].Cells["UtilitiesBill"].Value);
                        }
                        Billlabel.Text = sumUtilitiesBill.ToString();
                    }

                    int sumEntertainment = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["Entertainment"].Value != DBNull.Value)
                        {
                            sumEntertainment += Convert.ToInt32(dataGridView1.Rows[i].Cells["Entertainment"].Value);
                        }
                        Entertainlabel.Text = sumEntertainment.ToString();
                    }

                    int sumDailyExpsence = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["DailyExpsence"].Value != DBNull.Value)
                        {
                            sumDailyExpsence += Convert.ToInt32(dataGridView1.Rows[i].Cells["DailyExpsence"].Value);
                        }
                        DailyExplabel.Text = sumDailyExpsence.ToString();
                    }


                    int sumInventory = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["Inventory"].Value != DBNull.Value)
                        {
                            sumInventory += Convert.ToInt32(dataGridView1.Rows[i].Cells["Inventory"].Value);
                        }
                        Inventorylabel.Text = sumInventory.ToString();
                    }

                    int sumBuildingRent = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["BuildingRent"].Value != DBNull.Value)
                        {
                            sumBuildingRent += Convert.ToInt32(dataGridView1.Rows[i].Cells["BuildingRent"].Value);
                        }
                        Rentlabel.Text = sumBuildingRent.ToString();
                    }

                    int sumAmountReceivable = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["AmountReceivable"].Value != DBNull.Value)
                        {
                            sumAmountReceivable += Convert.ToInt32(dataGridView1.Rows[i].Cells["AmountReceivable"].Value);
                        }
                        Recelabel.Text = sumAmountReceivable.ToString();
                    }

                    int sumBedDepts = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["BedDepts"].Value != DBNull.Value)
                        {
                            sumBedDepts += Convert.ToInt32(dataGridView1.Rows[i].Cells["BedDepts"].Value);
                        }
                        Bedlabel.Text = sumBedDepts.ToString();
                    }

                    int sumTransferTo = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["TransferTo"].Value != DBNull.Value)
                        {
                            sumTransferTo += Convert.ToInt32(dataGridView1.Rows[i].Cells["TransferTo"].Value);
                        }
                        Transferlabel.Text = sumTransferTo.ToString();
                    }

                    int sumOtherExp = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["OtherExp"].Value != DBNull.Value)
                        {
                            sumOtherExp += Convert.ToInt32(dataGridView1.Rows[i].Cells["OtherExp"].Value);
                        }
                        OtherExplabel.Text = sumOtherExp.ToString();
                    }

                }
            }
            catch
            {

                MessageBox.Show("Expense saved Already.");
            }
        }

        private void ExpUpdatebutton_Click(object sender, EventArgs e)
        {

           try
            {
                if (ExpdateTimePicker.Text == "" && MonthcomboBox.Text == "" && YearcomboBox.Text == "")
                {
                    MessageBox.Show("Please select date month and year");
                }

                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update Expense set ExpenseName='" + ExpNametextBox.Text+"',Date='"+ExpdateTimePicker.Text+"',ExpMonth='"+MonthcomboBox.Text+"',ExpYear='"+YearcomboBox.Text+"',Marketing='"+ExpMarketingtextBox.Text+"',Development='"+ExpDevelopmenttextBox.Text+"',UtilitiesBill='"+ExpUtilitiesBilltextBox.Text+"',Entertainment='"+ExpEntertaimenttextBox.Text+"',DailyExpsence='"+ExpDailytextBox.Text+ "',Inventory='"+ExpInventorytextBox.Text+ "',BuildingRent='"+ExpBuildingtextBox.Text+ "',AmountReceivable='"+ExpAmountReceivtextBox.Text+ "',BedDepts='"+ExpBedDeptstextBox.Text+ "',TransferTo='"+ExpTransferTotextBox.Text+ "',OtherExp='"+OtherExptextBox.Text+"',TotalExpense='"+ExpenTotaltextBox.Text+"' where Id='"+ExpIdtextBox.Text+"'", con);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sdaGrid = new SqlDataAdapter("select * from Expense", con);
                    DataTable dtGrid = new DataTable();
                    sdaGrid.Fill(dtGrid);
                    dataGridView1.DataSource = dtGrid;
                    con.Close();
                    MessageBox.Show("Updated");

                    ExpIdtextBox.Text = "";
                    ExpNametextBox.Text = "";
                    ExpdateTimePicker.Text = "";
                    MonthcomboBox.Text = "";
                    YearcomboBox.Text = "";
                    ExpMarketingtextBox.Text = "0";
                    ExpDevelopmenttextBox.Text = "0";
                    ExpUtilitiesBilltextBox.Text = "0";
                    ExpEntertaimenttextBox.Text = "0";
                    ExpDailytextBox.Text = "0";
                    ExpInventorytextBox.Text = "0";
                    ExpBuildingtextBox.Text = "0";
                    ExpAmountReceivtextBox.Text = "0";
                    ExpBedDeptstextBox.Text = "0";
                    ExpTransferTotextBox.Text = "0";
                    OtherExptextBox.Text = "0";
                    ExpenTotaltextBox.Text = "0";

                    int sum = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["TotalExpense"].Value != DBNull.Value)
                        {
                            sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["TotalExpense"].Value);
                        }
                        TotalExplabel.Text = sum.ToString();
                    }

                    int sumMarketing = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["Marketing"].Value != DBNull.Value)
                        {
                            sumMarketing += Convert.ToInt32(dataGridView1.Rows[i].Cells["Marketing"].Value);
                        }
                        Marklabel.Text = sumMarketing.ToString();
                    }

                    int sumDevelopment = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["Development"].Value != DBNull.Value)
                        {
                            sumDevelopment += Convert.ToInt32(dataGridView1.Rows[i].Cells["Development"].Value);
                        }
                        Developlabel.Text = sumDevelopment.ToString();
                    }

                    int sumUtilitiesBill = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["UtilitiesBill"].Value != DBNull.Value)
                        {
                            sumUtilitiesBill += Convert.ToInt32(dataGridView1.Rows[i].Cells["UtilitiesBill"].Value);
                        }
                        Billlabel.Text = sumUtilitiesBill.ToString();
                    }

                    int sumEntertainment = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["Entertainment"].Value != DBNull.Value)
                        {
                            sumEntertainment += Convert.ToInt32(dataGridView1.Rows[i].Cells["Entertainment"].Value);
                        }
                        Entertainlabel.Text = sumEntertainment.ToString();
                    }

                    int sumDailyExpsence = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["DailyExpsence"].Value != DBNull.Value)
                        {
                            sumDailyExpsence += Convert.ToInt32(dataGridView1.Rows[i].Cells["DailyExpsence"].Value);
                        }
                        DailyExplabel.Text = sumDailyExpsence.ToString();
                    }


                    int sumInventory = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["Inventory"].Value != DBNull.Value)
                        {
                            sumInventory += Convert.ToInt32(dataGridView1.Rows[i].Cells["Inventory"].Value);
                        }
                        Inventorylabel.Text = sumInventory.ToString();
                    }

                    int sumBuildingRent = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["BuildingRent"].Value != DBNull.Value)
                        {
                            sumBuildingRent += Convert.ToInt32(dataGridView1.Rows[i].Cells["BuildingRent"].Value);
                        }
                        Rentlabel.Text = sumBuildingRent.ToString();
                    }

                    int sumAmountReceivable = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["AmountReceivable"].Value != DBNull.Value)
                        {
                            sumAmountReceivable += Convert.ToInt32(dataGridView1.Rows[i].Cells["AmountReceivable"].Value);
                        }
                        Recelabel.Text = sumAmountReceivable.ToString();
                    }

                    int sumBedDepts = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["BedDepts"].Value != DBNull.Value)
                        {
                            sumBedDepts += Convert.ToInt32(dataGridView1.Rows[i].Cells["BedDepts"].Value);
                        }
                        Bedlabel.Text = sumBedDepts.ToString();
                    }

                    int sumTransferTo = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["TransferTo"].Value != DBNull.Value)
                        {
                            sumTransferTo += Convert.ToInt32(dataGridView1.Rows[i].Cells["TransferTo"].Value);
                        }
                        Transferlabel.Text = sumTransferTo.ToString();
                    }

                    int sumOtherExp = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["OtherExp"].Value != DBNull.Value)
                        {
                            sumOtherExp += Convert.ToInt32(dataGridView1.Rows[i].Cells["OtherExp"].Value);
                        }
                        OtherExplabel.Text = sumOtherExp.ToString();
                    }

                }
            }
            catch
            {

                MessageBox.Show("cant Update.");
            }
        }

        private void ExpDeletebutton_Click(object sender, EventArgs e)
        {

            try
            {
                if (ExpIdtextBox.Text == "" && MonthcomboBox.Text == "" && YearcomboBox.Text == "")
                {
                    MessageBox.Show("Please select date month and year");
                }

                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete Expense where Id='"+ExpIdtextBox.Text+"'", con);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sdaGrid = new SqlDataAdapter("select * from Expense", con);
                    DataTable dtGrid = new DataTable();
                    sdaGrid.Fill(dtGrid);
                    dataGridView1.DataSource = dtGrid;
                    con.Close();
                    MessageBox.Show("Deleted");

                    ExpIdtextBox.Text = "";
                    ExpNametextBox.Text = "";
                    ExpdateTimePicker.Text = "";
                    MonthcomboBox.Text = "";
                    YearcomboBox.Text = "";
                    ExpMarketingtextBox.Text = "0";
                    ExpDevelopmenttextBox.Text = "0";
                    ExpUtilitiesBilltextBox.Text = "0";
                    ExpEntertaimenttextBox.Text = "0";
                    ExpDailytextBox.Text = "0";
                    ExpInventorytextBox.Text = "0";
                    ExpBuildingtextBox.Text = "0";
                    ExpAmountReceivtextBox.Text = "0";
                    ExpBedDeptstextBox.Text = "0";
                    ExpTransferTotextBox.Text = "0";
                    OtherExptextBox.Text = "0";
                    ExpenTotaltextBox.Text = "0";

                    int sum = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["TotalExpense"].Value != DBNull.Value)
                        {
                            sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["TotalExpense"].Value);
                        }
                        TotalExplabel.Text = sum.ToString();
                    }

                    int sumMarketing = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["Marketing"].Value != DBNull.Value)
                        {
                            sumMarketing += Convert.ToInt32(dataGridView1.Rows[i].Cells["Marketing"].Value);
                        }
                        Marklabel.Text = sumMarketing.ToString();
                    }

                    int sumDevelopment = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["Development"].Value != DBNull.Value)
                        {
                            sumDevelopment += Convert.ToInt32(dataGridView1.Rows[i].Cells["Development"].Value);
                        }
                        Developlabel.Text = sumDevelopment.ToString();
                    }

                    int sumUtilitiesBill = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["UtilitiesBill"].Value != DBNull.Value)
                        {
                            sumUtilitiesBill += Convert.ToInt32(dataGridView1.Rows[i].Cells["UtilitiesBill"].Value);
                        }
                        Billlabel.Text = sumUtilitiesBill.ToString();
                    }

                    int sumEntertainment = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["Entertainment"].Value != DBNull.Value)
                        {
                            sumEntertainment += Convert.ToInt32(dataGridView1.Rows[i].Cells["Entertainment"].Value);
                        }
                        Entertainlabel.Text = sumEntertainment.ToString();
                    }

                    int sumDailyExpsence = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["DailyExpsence"].Value != DBNull.Value)
                        {
                            sumDailyExpsence += Convert.ToInt32(dataGridView1.Rows[i].Cells["DailyExpsence"].Value);
                        }
                        DailyExplabel.Text = sumDailyExpsence.ToString();
                    }


                    int sumInventory = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["Inventory"].Value != DBNull.Value)
                        {
                            sumInventory += Convert.ToInt32(dataGridView1.Rows[i].Cells["Inventory"].Value);
                        }
                        Inventorylabel.Text = sumInventory.ToString();
                    }

                    int sumBuildingRent = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["BuildingRent"].Value != DBNull.Value)
                        {
                            sumBuildingRent += Convert.ToInt32(dataGridView1.Rows[i].Cells["BuildingRent"].Value);
                        }
                        Rentlabel.Text = sumBuildingRent.ToString();
                    }

                    int sumAmountReceivable = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["AmountReceivable"].Value != DBNull.Value)
                        {
                            sumAmountReceivable += Convert.ToInt32(dataGridView1.Rows[i].Cells["AmountReceivable"].Value);
                        }
                        Recelabel.Text = sumAmountReceivable.ToString();
                    }

                    int sumBedDepts = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["BedDepts"].Value != DBNull.Value)
                        {
                            sumBedDepts += Convert.ToInt32(dataGridView1.Rows[i].Cells["BedDepts"].Value);
                        }
                        Bedlabel.Text = sumBedDepts.ToString();
                    }

                    int sumTransferTo = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["TransferTo"].Value != DBNull.Value)
                        {
                            sumTransferTo += Convert.ToInt32(dataGridView1.Rows[i].Cells["TransferTo"].Value);
                        }
                        Transferlabel.Text = sumTransferTo.ToString();
                    }

                    int sumOtherExp = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        if (dataGridView1.Rows[i].Cells["OtherExp"].Value != DBNull.Value)
                        {
                            sumOtherExp += Convert.ToInt32(dataGridView1.Rows[i].Cells["OtherExp"].Value);
                        }
                        OtherExplabel.Text = sumOtherExp.ToString();
                    }

                }
            }
            catch
            {

                MessageBox.Show("cant Delete.");
            }
        }

        private void ExpShowAllbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Expense", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sdaGrid = new SqlDataAdapter(cmd);
            DataTable dtGrid = new DataTable();
            sdaGrid.Fill(dtGrid);
            dataGridView1.DataSource = dtGrid;
            con.Close();

            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["TotalExpense"].Value != DBNull.Value)
                {
                    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["TotalExpense"].Value);
                }
                TotalExplabel.Text = sum.ToString();
            }

            int sumMarketing = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["Marketing"].Value != DBNull.Value)
                {
                    sumMarketing += Convert.ToInt32(dataGridView1.Rows[i].Cells["Marketing"].Value);
                }
                Marklabel.Text = sumMarketing.ToString();
            }

            int sumDevelopment = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["Development"].Value != DBNull.Value)
                {
                    sumDevelopment += Convert.ToInt32(dataGridView1.Rows[i].Cells["Development"].Value);
                }
                Developlabel.Text = sumDevelopment.ToString();
            }

            int sumUtilitiesBill = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["UtilitiesBill"].Value != DBNull.Value)
                {
                    sumUtilitiesBill += Convert.ToInt32(dataGridView1.Rows[i].Cells["UtilitiesBill"].Value);
                }
                Billlabel.Text = sumUtilitiesBill.ToString();
            }

            int sumEntertainment = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["Entertainment"].Value != DBNull.Value)
                {
                    sumEntertainment += Convert.ToInt32(dataGridView1.Rows[i].Cells["Entertainment"].Value);
                }
                Entertainlabel.Text = sumEntertainment.ToString();
            }

            int sumDailyExpsence = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["DailyExpsence"].Value != DBNull.Value)
                {
                    sumDailyExpsence += Convert.ToInt32(dataGridView1.Rows[i].Cells["DailyExpsence"].Value);
                }
                DailyExplabel.Text = sumDailyExpsence.ToString();
            }


            int sumInventory = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["Inventory"].Value != DBNull.Value)
                {
                    sumInventory += Convert.ToInt32(dataGridView1.Rows[i].Cells["Inventory"].Value);
                }
                Inventorylabel.Text = sumInventory.ToString();
            }

            int sumBuildingRent = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["BuildingRent"].Value != DBNull.Value)
                {
                    sumBuildingRent += Convert.ToInt32(dataGridView1.Rows[i].Cells["BuildingRent"].Value);
                }
                Rentlabel.Text = sumBuildingRent.ToString();
            }

            int sumAmountReceivable = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["AmountReceivable"].Value != DBNull.Value)
                {
                    sumAmountReceivable += Convert.ToInt32(dataGridView1.Rows[i].Cells["AmountReceivable"].Value);
                }
                Recelabel.Text = sumAmountReceivable.ToString();
            }

            int sumBedDepts = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["BedDepts"].Value != DBNull.Value)
                {
                    sumBedDepts += Convert.ToInt32(dataGridView1.Rows[i].Cells["BedDepts"].Value);
                }
                Bedlabel.Text = sumBedDepts.ToString();
            }

            int sumTransferTo = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["TransferTo"].Value != DBNull.Value)
                {
                    sumTransferTo += Convert.ToInt32(dataGridView1.Rows[i].Cells["TransferTo"].Value);
                }
                Transferlabel.Text = sumTransferTo.ToString();
            }

            int sumOtherExp = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["OtherExp"].Value != DBNull.Value)
                {
                    sumOtherExp += Convert.ToInt32(dataGridView1.Rows[i].Cells["OtherExp"].Value);
                }
                OtherExplabel.Text = sumOtherExp.ToString();
            }
        }

        private void ExpClearbutton_Click(object sender, EventArgs e)
        {
            ExpIdtextBox.Text = "";
            ExpNametextBox.Text = "";
            ExpdateTimePicker.Text = "";
            MonthcomboBox.Text = "";
            YearcomboBox.Text = "";
            ExpMarketingtextBox.Text = "0";
            ExpDevelopmenttextBox.Text = "0";
            ExpUtilitiesBilltextBox.Text = "0";
            ExpEntertaimenttextBox.Text = "0";
            ExpDailytextBox.Text = "0";
            ExpInventorytextBox.Text = "0";
            ExpBuildingtextBox.Text = "0";
            ExpAmountReceivtextBox.Text = "0";
            ExpBedDeptstextBox.Text = "0";
            ExpTransferTotextBox.Text = "0";
            OtherExptextBox.Text = "0";
            ExpenTotaltextBox.Text = "0";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    ExpIdtextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
                    ExpNametextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["ExpenseName"].FormattedValue.ToString();
                    ExpdateTimePicker.Text = dataGridView1.Rows[e.RowIndex].Cells["Date"].FormattedValue.ToString();
                    MonthcomboBox.Text = dataGridView1.Rows[e.RowIndex].Cells["ExpMonth"].FormattedValue.ToString();
                    YearcomboBox.Text = dataGridView1.Rows[e.RowIndex].Cells["ExpYear"].FormattedValue.ToString();
                    ExpMarketingtextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Marketing"].FormattedValue.ToString();
                    ExpDevelopmenttextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Development"].FormattedValue.ToString();
                    ExpUtilitiesBilltextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["UtilitiesBill"].FormattedValue.ToString();
                    ExpEntertaimenttextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Entertainment"].FormattedValue.ToString();
                    ExpDailytextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["DailyExpsence"].FormattedValue.ToString();
                    ExpInventorytextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Inventory"].FormattedValue.ToString();
                    ExpBuildingtextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["BuildingRent"].FormattedValue.ToString();
                    ExpAmountReceivtextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["AmountReceivable"].FormattedValue.ToString();
                    ExpBedDeptstextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["BedDepts"].FormattedValue.ToString();
                    ExpTransferTotextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["TransferTo"].FormattedValue.ToString();
                    OtherExptextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["OtherExp"].FormattedValue.ToString();
                    ExpenTotaltextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["TotalExpense"].FormattedValue.ToString();



                   

                }

            }

            catch
            {
                MessageBox.Show("Click on any cell not column");
            }
        }

        private void ExpMarketingtextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ExpMarketingtextBox.TextLength > 0)
                {
                    ExpenTotaltextBox.Text = (Convert.ToInt32(ExpMarketingtextBox.Text) + Convert.ToInt32(ExpDevelopmenttextBox.Text) + Convert.ToInt32(ExpUtilitiesBilltextBox.Text) + Convert.ToInt32(ExpEntertaimenttextBox.Text) + Convert.ToInt32(ExpDailytextBox.Text) + Convert.ToInt32(ExpInventorytextBox.Text) + Convert.ToInt32(ExpBuildingtextBox.Text) + Convert.ToInt32(ExpAmountReceivtextBox.Text) + Convert.ToInt32(ExpBedDeptstextBox.Text) + Convert.ToInt32(ExpTransferTotextBox.Text)+ Convert.ToInt32(OtherExptextBox.Text)).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Enter only Number");
            }
        }

        private void ExpDevelopmenttextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ExpDevelopmenttextBox.TextLength > 0)
                {
                    ExpenTotaltextBox.Text = (Convert.ToInt32(ExpMarketingtextBox.Text) + Convert.ToInt32(ExpDevelopmenttextBox.Text) + Convert.ToInt32(ExpUtilitiesBilltextBox.Text) + Convert.ToInt32(ExpEntertaimenttextBox.Text) + Convert.ToInt32(ExpDailytextBox.Text) + Convert.ToInt32(ExpInventorytextBox.Text) + Convert.ToInt32(ExpBuildingtextBox.Text) + Convert.ToInt32(ExpAmountReceivtextBox.Text) + Convert.ToInt32(ExpBedDeptstextBox.Text) + Convert.ToInt32(ExpTransferTotextBox.Text) + Convert.ToInt32(OtherExptextBox.Text)).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Enter only Number");
            }
        }

        private void ExpUtilitiesBilltextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ExpUtilitiesBilltextBox.TextLength > 0)
                {
                    ExpenTotaltextBox.Text = (Convert.ToInt32(ExpMarketingtextBox.Text) + Convert.ToInt32(ExpDevelopmenttextBox.Text) + Convert.ToInt32(ExpUtilitiesBilltextBox.Text) + Convert.ToInt32(ExpEntertaimenttextBox.Text) + Convert.ToInt32(ExpDailytextBox.Text) + Convert.ToInt32(ExpInventorytextBox.Text) + Convert.ToInt32(ExpBuildingtextBox.Text) + Convert.ToInt32(ExpAmountReceivtextBox.Text) + Convert.ToInt32(ExpBedDeptstextBox.Text) + Convert.ToInt32(ExpTransferTotextBox.Text) + Convert.ToInt32(OtherExptextBox.Text)).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Enter only Number");
            }
        }

        private void ExpEntertaimenttextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ExpEntertaimenttextBox.TextLength > 0)
                {
                    ExpenTotaltextBox.Text = (Convert.ToInt32(ExpMarketingtextBox.Text) + Convert.ToInt32(ExpDevelopmenttextBox.Text) + Convert.ToInt32(ExpUtilitiesBilltextBox.Text) + Convert.ToInt32(ExpEntertaimenttextBox.Text) + Convert.ToInt32(ExpDailytextBox.Text) + Convert.ToInt32(ExpInventorytextBox.Text) + Convert.ToInt32(ExpBuildingtextBox.Text) + Convert.ToInt32(ExpAmountReceivtextBox.Text) + Convert.ToInt32(ExpBedDeptstextBox.Text) + Convert.ToInt32(ExpTransferTotextBox.Text) + Convert.ToInt32(OtherExptextBox.Text)).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Enter only Number");
            }
        }

        private void ExpDailytextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ExpDailytextBox.TextLength > 0)
                {
                    ExpenTotaltextBox.Text = (Convert.ToInt32(ExpMarketingtextBox.Text) + Convert.ToInt32(ExpDevelopmenttextBox.Text) + Convert.ToInt32(ExpUtilitiesBilltextBox.Text) + Convert.ToInt32(ExpEntertaimenttextBox.Text) + Convert.ToInt32(ExpDailytextBox.Text) + Convert.ToInt32(ExpInventorytextBox.Text) + Convert.ToInt32(ExpBuildingtextBox.Text) + Convert.ToInt32(ExpAmountReceivtextBox.Text) + Convert.ToInt32(ExpBedDeptstextBox.Text) + Convert.ToInt32(ExpTransferTotextBox.Text) + Convert.ToInt32(OtherExptextBox.Text)).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Enter only Number");
            }
        }

        private void ExpInventorytextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ExpInventorytextBox.TextLength > 0)
                {
                    ExpenTotaltextBox.Text = (Convert.ToInt32(ExpMarketingtextBox.Text) + Convert.ToInt32(ExpDevelopmenttextBox.Text) + Convert.ToInt32(ExpUtilitiesBilltextBox.Text) + Convert.ToInt32(ExpEntertaimenttextBox.Text) + Convert.ToInt32(ExpDailytextBox.Text) + Convert.ToInt32(ExpInventorytextBox.Text) + Convert.ToInt32(ExpBuildingtextBox.Text) + Convert.ToInt32(ExpAmountReceivtextBox.Text) + Convert.ToInt32(ExpBedDeptstextBox.Text) + Convert.ToInt32(ExpTransferTotextBox.Text) + Convert.ToInt32(OtherExptextBox.Text)).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Enter only Number");
            }
        }

        private void ExpBuildingtextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ExpBuildingtextBox.TextLength > 0)
                {
                    ExpenTotaltextBox.Text = (Convert.ToInt32(ExpMarketingtextBox.Text) + Convert.ToInt32(ExpDevelopmenttextBox.Text) + Convert.ToInt32(ExpUtilitiesBilltextBox.Text) + Convert.ToInt32(ExpEntertaimenttextBox.Text) + Convert.ToInt32(ExpDailytextBox.Text) + Convert.ToInt32(ExpInventorytextBox.Text) + Convert.ToInt32(ExpBuildingtextBox.Text) + Convert.ToInt32(ExpAmountReceivtextBox.Text) + Convert.ToInt32(ExpBedDeptstextBox.Text) + Convert.ToInt32(ExpTransferTotextBox.Text) + Convert.ToInt32(OtherExptextBox.Text)).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Enter only Number");
            }
        }

        private void ExpAmountReceivtextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ExpAmountReceivtextBox.TextLength > 0)
                {
                    ExpenTotaltextBox.Text = (Convert.ToInt32(ExpMarketingtextBox.Text) + Convert.ToInt32(ExpDevelopmenttextBox.Text) + Convert.ToInt32(ExpUtilitiesBilltextBox.Text) + Convert.ToInt32(ExpEntertaimenttextBox.Text) + Convert.ToInt32(ExpDailytextBox.Text) + Convert.ToInt32(ExpInventorytextBox.Text) + Convert.ToInt32(ExpBuildingtextBox.Text) + Convert.ToInt32(ExpAmountReceivtextBox.Text) + Convert.ToInt32(ExpBedDeptstextBox.Text) + Convert.ToInt32(ExpTransferTotextBox.Text) + Convert.ToInt32(OtherExptextBox.Text)).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Enter only Number");
            }
        }

        private void ExpBedDeptstextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ExpBedDeptstextBox.TextLength > 0)
                {
                    ExpenTotaltextBox.Text = (Convert.ToInt32(ExpMarketingtextBox.Text) + Convert.ToInt32(ExpDevelopmenttextBox.Text) + Convert.ToInt32(ExpUtilitiesBilltextBox.Text) + Convert.ToInt32(ExpEntertaimenttextBox.Text) + Convert.ToInt32(ExpDailytextBox.Text) + Convert.ToInt32(ExpInventorytextBox.Text) + Convert.ToInt32(ExpBuildingtextBox.Text) + Convert.ToInt32(ExpAmountReceivtextBox.Text) + Convert.ToInt32(ExpBedDeptstextBox.Text) + Convert.ToInt32(ExpTransferTotextBox.Text) + Convert.ToInt32(OtherExptextBox.Text)).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Enter only Number");
            }
        }

        private void ExpTransferTotextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ExpTransferTotextBox.TextLength > 0)
                {
                    ExpenTotaltextBox.Text = (Convert.ToInt32(ExpMarketingtextBox.Text) + Convert.ToInt32(ExpDevelopmenttextBox.Text) + Convert.ToInt32(ExpUtilitiesBilltextBox.Text) + Convert.ToInt32(ExpEntertaimenttextBox.Text) + Convert.ToInt32(ExpDailytextBox.Text) + Convert.ToInt32(ExpInventorytextBox.Text) + Convert.ToInt32(ExpBuildingtextBox.Text) + Convert.ToInt32(ExpAmountReceivtextBox.Text) + Convert.ToInt32(ExpBedDeptstextBox.Text) + Convert.ToInt32(ExpTransferTotextBox.Text) + Convert.ToInt32(OtherExptextBox.Text)).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Enter only Number");
            }
        }

        private void ExpFromdateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ExpFromdateTimePicker.CustomFormat = "dd-MMM-yyy";

            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Expense where [Date] between '" + ExpFromdateTimePicker.Text+ "' and '" + ExpTodateTimePicker.Text + "'", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sdaGrid = new SqlDataAdapter(cmd);
            DataTable dtGrid = new DataTable();
            sdaGrid.Fill(dtGrid);
            dataGridView1.DataSource = dtGrid;
            con.Close();

            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["TotalExpense"].Value != DBNull.Value)
                {
                    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["TotalExpense"].Value);
                }
                TotalExplabel.Text = sum.ToString();
            }

            int sumMarketing = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["Marketing"].Value != DBNull.Value)
                {
                    sumMarketing += Convert.ToInt32(dataGridView1.Rows[i].Cells["Marketing"].Value);
                }
                Marklabel.Text = sumMarketing.ToString();
            }

            int sumDevelopment = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["Development"].Value != DBNull.Value)
                {
                    sumDevelopment += Convert.ToInt32(dataGridView1.Rows[i].Cells["Development"].Value);
                }
                Developlabel.Text = sumDevelopment.ToString();
            }

            int sumUtilitiesBill = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["UtilitiesBill"].Value != DBNull.Value)
                {
                    sumUtilitiesBill += Convert.ToInt32(dataGridView1.Rows[i].Cells["UtilitiesBill"].Value);
                }
                Billlabel.Text = sumUtilitiesBill.ToString();
            }

            int sumEntertainment = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["Entertainment"].Value != DBNull.Value)
                {
                    sumEntertainment += Convert.ToInt32(dataGridView1.Rows[i].Cells["Entertainment"].Value);
                }
                Entertainlabel.Text = sumEntertainment.ToString();
            }

            int sumDailyExpsence = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["DailyExpsence"].Value != DBNull.Value)
                {
                    sumDailyExpsence += Convert.ToInt32(dataGridView1.Rows[i].Cells["DailyExpsence"].Value);
                }
                DailyExplabel.Text = sumDailyExpsence.ToString();
            }


            int sumInventory = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["Inventory"].Value != DBNull.Value)
                {
                    sumInventory += Convert.ToInt32(dataGridView1.Rows[i].Cells["Inventory"].Value);
                }
                Inventorylabel.Text = sumInventory.ToString();
            }

            int sumBuildingRent = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["BuildingRent"].Value != DBNull.Value)
                {
                    sumBuildingRent += Convert.ToInt32(dataGridView1.Rows[i].Cells["BuildingRent"].Value);
                }
                Rentlabel.Text = sumBuildingRent.ToString();
            }

            int sumAmountReceivable = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["AmountReceivable"].Value != DBNull.Value)
                {
                    sumAmountReceivable += Convert.ToInt32(dataGridView1.Rows[i].Cells["AmountReceivable"].Value);
                }
                Recelabel.Text = sumAmountReceivable.ToString();
            }

            int sumBedDepts = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["BedDepts"].Value != DBNull.Value)
                {
                    sumBedDepts += Convert.ToInt32(dataGridView1.Rows[i].Cells["BedDepts"].Value);
                }
                Bedlabel.Text = sumBedDepts.ToString();
            }

            int sumTransferTo = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["TransferTo"].Value != DBNull.Value)
                {
                    sumTransferTo += Convert.ToInt32(dataGridView1.Rows[i].Cells["TransferTo"].Value);
                }
                Transferlabel.Text = sumTransferTo.ToString();
            }

            int sumOtherExp = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["OtherExp"].Value != DBNull.Value)
                {
                    sumOtherExp += Convert.ToInt32(dataGridView1.Rows[i].Cells["OtherExp"].Value);
                }
                OtherExplabel.Text = sumOtherExp.ToString();
            }

        }

        private void ExpTodateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ExpTodateTimePicker.CustomFormat = "dd-MMM-yyy";

            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=lingo_Database;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Expense where [Date] between '" + ExpFromdateTimePicker.Text + "' and '" + ExpTodateTimePicker.Text + "'", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sdaGrid = new SqlDataAdapter(cmd);
            DataTable dtGrid = new DataTable();
            sdaGrid.Fill(dtGrid);
            dataGridView1.DataSource = dtGrid;
            con.Close();

            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["TotalExpense"].Value != DBNull.Value)
                {
                    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["TotalExpense"].Value);
                }
                TotalExplabel.Text = sum.ToString();
            }

            int sumMarketing = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["Marketing"].Value != DBNull.Value)
                {
                    sumMarketing += Convert.ToInt32(dataGridView1.Rows[i].Cells["Marketing"].Value);
                }
                Marklabel.Text = sumMarketing.ToString();
            }

            int sumDevelopment = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["Development"].Value != DBNull.Value)
                {
                    sumDevelopment += Convert.ToInt32(dataGridView1.Rows[i].Cells["Development"].Value);
                }
                Developlabel.Text = sumDevelopment.ToString();
            }

            int sumUtilitiesBill = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["UtilitiesBill"].Value != DBNull.Value)
                {
                    sumUtilitiesBill += Convert.ToInt32(dataGridView1.Rows[i].Cells["UtilitiesBill"].Value);
                }
                Billlabel.Text = sumUtilitiesBill.ToString();
            }

            int sumEntertainment = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["Entertainment"].Value != DBNull.Value)
                {
                    sumEntertainment += Convert.ToInt32(dataGridView1.Rows[i].Cells["Entertainment"].Value);
                }
                Entertainlabel.Text = sumEntertainment.ToString();
            }

            int sumDailyExpsence = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["DailyExpsence"].Value != DBNull.Value)
                {
                    sumDailyExpsence += Convert.ToInt32(dataGridView1.Rows[i].Cells["DailyExpsence"].Value);
                }
                DailyExplabel.Text = sumDailyExpsence.ToString();
            }


            int sumInventory = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["Inventory"].Value != DBNull.Value)
                {
                    sumInventory += Convert.ToInt32(dataGridView1.Rows[i].Cells["Inventory"].Value);
                }
                Inventorylabel.Text = sumInventory.ToString();
            }

            int sumBuildingRent = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["BuildingRent"].Value != DBNull.Value)
                {
                    sumBuildingRent += Convert.ToInt32(dataGridView1.Rows[i].Cells["BuildingRent"].Value);
                }
                Rentlabel.Text = sumBuildingRent.ToString();
            }

            int sumAmountReceivable = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["AmountReceivable"].Value != DBNull.Value)
                {
                    sumAmountReceivable += Convert.ToInt32(dataGridView1.Rows[i].Cells["AmountReceivable"].Value);
                }
                Recelabel.Text = sumAmountReceivable.ToString();
            }

            int sumBedDepts = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["BedDepts"].Value != DBNull.Value)
                {
                    sumBedDepts += Convert.ToInt32(dataGridView1.Rows[i].Cells["BedDepts"].Value);
                }
                Bedlabel.Text = sumBedDepts.ToString();
            }

            int sumTransferTo = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["TransferTo"].Value != DBNull.Value)
                {
                    sumTransferTo += Convert.ToInt32(dataGridView1.Rows[i].Cells["TransferTo"].Value);
                }
                Transferlabel.Text = sumTransferTo.ToString();
            }

            int sumOtherExp = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["OtherExp"].Value != DBNull.Value)
                {
                    sumOtherExp += Convert.ToInt32(dataGridView1.Rows[i].Cells["OtherExp"].Value);
                }
                OtherExplabel.Text = sumOtherExp.ToString();
            }
        }

        private void OtherExptextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (OtherExptextBox.TextLength > 0)
                {
                    {
                        ExpenTotaltextBox.Text = (Convert.ToInt32(ExpMarketingtextBox.Text) + Convert.ToInt32(ExpDevelopmenttextBox.Text) + Convert.ToInt32(ExpUtilitiesBilltextBox.Text) + Convert.ToInt32(ExpEntertaimenttextBox.Text) + Convert.ToInt32(ExpDailytextBox.Text) + Convert.ToInt32(ExpInventorytextBox.Text) + Convert.ToInt32(ExpBuildingtextBox.Text) + Convert.ToInt32(ExpAmountReceivtextBox.Text) + Convert.ToInt32(ExpBedDeptstextBox.Text) + Convert.ToInt32(ExpTransferTotextBox.Text) + Convert.ToInt32(OtherExptextBox.Text)).ToString();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Enter only Number");
            }
        }

        private void Ropertbutton_Click(object sender, EventArgs e)
        {
            DailyExpenseReportForm s = new DailyExpenseReportForm();
            s.Show();
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
    }
}

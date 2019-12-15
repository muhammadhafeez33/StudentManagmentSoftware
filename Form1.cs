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
    public partial class Login_Form : System.Windows.Forms.Form
    {
        public Login_Form()
        {
            InitializeComponent();
            this.ActiveControl = button1;
            button1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserNametextBox.Text == "admin" && PasswordtextBox.Text == "pia")
            {
                this.Hide();
                Main_Form s = new Main_Form();
                s.Show();
            }
            else
            {
                MessageBox.Show("User name password not correct.");
            }

            }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void PasswordtextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Enter(object sender, EventArgs e)
        {
           
            
        }

        private void UserNametextBox_Enter(object sender, EventArgs e)
        {
           
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (UserNametextBox.Text == "admin" && PasswordtextBox.Text == "pia")
                {
                    this.Hide();
                    Main_Form s = new Main_Form();
                    s.Show();
                }
                else
                {
                    MessageBox.Show("User name password not correct.");
                }
            }
        }
    }
    }


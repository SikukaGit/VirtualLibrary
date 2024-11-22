using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualLibrary
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm_TextChanged(object sender, EventArgs e)
        {

        }

       
        
            private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password =txtPassword.Text;

            // Simple validation 
            if (username == "admin" && password == "password")
            {
                MessageBox.Show("Login successful!");
                this.DialogResult = DialogResult.OK; // Close the login form
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

       
        
            private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
    }
    


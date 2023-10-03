using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManagerRoundTwo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MakePasswordSecret();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UsernameBox.Text == "Jacob" && PasswordBox.Text == "Admin")
            {
                // Display a message indicating successful login
                MessageBox.Show("Login successful!", "Success");

                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                // Display a message indicating incorrect login information
                MessageBox.Show("Incorrect username or password. Please try again.", "Error");

                // Clear the username field
                UsernameBox.Clear();
                // Clear the password field
                PasswordBox.Clear();
            }
        }

        private void MakePasswordSecret()
        {
            // Set to no text.
            PasswordBox.Text = "";
            // The password character is an asterisk.
            PasswordBox.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            PasswordBox.MaxLength = 14;
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
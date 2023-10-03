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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            GeneratePasswordTextBox.ReadOnly = true;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show(); // this is for logout button
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
  
        }

        private void GeneratePasswordButton_Click(object sender, EventArgs e)
        {
            Random randLengnth = new Random();
            int len = randLengnth.Next(8, 15);

            const string ValidChar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            StringBuilder result = new StringBuilder();
            Random rand = new Random();

            if (rand.Next(1, 10) == 1) //if rand num is 1 then...
            {
                GeneratePasswordTextBox.Text = "Y0u_@re_w0rthl3ss.";
                return;
            }

            while (0 < len--) //while password is less than len keep adding more charcters
            {
                result.Append(ValidChar[rand.Next(ValidChar.Length)]);
            }

            GeneratePasswordTextBox.Text = result.ToString();
        }

        private void GeneratePasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SavePasswordButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void GeneratePasswordButton_Click_1(object sender, EventArgs e)
        {
            Random randLengnth = new Random();
            int len = randLengnth.Next(8, 15);

            const string ValidChar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            StringBuilder result = new StringBuilder();
            Random rand = new Random();

            if (rand.Next(1, 10) == 1) //if rand num is 1 then...
            {
                GeneratePasswordTextBox.Text = "Y0u_@re_w0rthl3ss.";
                return;
            }

            while (0 < len--) //while password is less than len keep adding more charcters
            {
                result.Append(ValidChar[rand.Next(ValidChar.Length)]);
            }

            GeneratePasswordTextBox.Text = result.ToString();
        }
    }
}

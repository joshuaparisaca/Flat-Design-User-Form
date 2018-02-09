using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using peopleLibrary;
using Npgsql;

namespace personProject
{
    public partial class Form1 : Form
    {
        peopleData peopleMethods = new peopleData();

        public Form1()
        {
            InitializeComponent();
            //Add Class Library(.NET Framework)
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Password")
            {
                passwordTextBox.Text = "";
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
            {
                passwordTextBox.Text = "Password";
                passwordTextBox.UseSystemPasswordChar = false;
            }
        }

        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "Username")
            {
                usernameTextBox.Text = "";
            }
        }

        private void usernameTextBox_Leave(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "")
            {
                usernameTextBox.Text = "Username";
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            loginButton.Focus();
        }

        private void forgotPasswordButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //SET to URL to own website
            Process.Start("http://www.google.com");
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (peopleMethods.loginButton(username, password) == true)
            {
                userLogin x = new userLogin();
                x.email = username;
                x.password = password;
                //this.Hide();
                x.ShowDialog();
            }
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            var createUser = new createUser();
            //this.Hide();
            createUser.ShowDialog();
        }

        private void usernameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ') e.Handled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

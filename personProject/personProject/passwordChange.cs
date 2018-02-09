using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using peopleLibrary;
using Npgsql;

namespace personProject
{
    public partial class passwordChange : Form
    {
        public string email { get; set; }

        peopleData peopleMethod = new peopleData(); // HIDE FORMM 1 SOMEHOW

        public passwordChange()
        {
            InitializeComponent();
            oldPasswordInput.UseSystemPasswordChar = true;
            newPasswordInput.UseSystemPasswordChar = true;
            confirmPasswordInput.UseSystemPasswordChar = true;
        }

        private void showPasswordCheckBox_Click(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked)
            {
                oldPasswordInput.UseSystemPasswordChar = false;
                newPasswordInput.UseSystemPasswordChar = false;
                confirmPasswordInput.UseSystemPasswordChar = false;
            }
            else
            {
                oldPasswordInput.UseSystemPasswordChar = true;
                newPasswordInput.UseSystemPasswordChar = true;
                confirmPasswordInput.UseSystemPasswordChar = true;
            }
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {

            if (confirmPasswordInput.Text == newPasswordInput.Text)
            {
                if (peopleMethod.update_password(email, oldPasswordInput.Text, newPasswordInput.Text) == true)
                {
                    Application.Restart();
                    //this.Close();
                    //Form1 x = new Form1();
                    //x.Show();
                }
            }

            else
            {
                MessageBox.Show("Passwords do not match");
            }

        }
    }
}

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
    public partial class createUser : Form
    {
        peopleData peopleMethods = new peopleData();
        
        public createUser()
        {
            InitializeComponent();
            passwordTextBox.UseSystemPasswordChar = true;
            confirmPasswordTextBox.UseSystemPasswordChar = true;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            createPersonButton.Focus();
        }

        private void createPersonButton_Click(object sender, EventArgs e)
        {
            if (loopTextBoxes() == true || createStateText.Text == "" || peopleMethods.zipCodeTest(createZipText.Text) == false) 
            {
                MessageBox.Show("Please check your fields");
            }

            else
            {
                if (passwordTextBox.Text != confirmPasswordTextBox.Text)
                {
                    MessageBox.Show("Passwords don't match");
                }

                else
                {
                    //Add person to Database
                    peopleMethods.add_person(createEmailText.Text, passwordTextBox.Text, createFirstNameText.Text, createLastNameText.Text, createAddressText.Text , createCityText.Text , createStateText.Text , createZipText.Text);
                    
                    this.Close();
                    //Form1 x = new Form1();
                    //x.Show();
                }
            }
        }

        private bool loopTextBoxes() // Leave this here because of TextBox
        {
            Boolean loopBoxes = false;

            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                if (tb.Text == "")
                {
                    loopBoxes = true;
                }
            }

            return loopBoxes;
        }

        private void createFirstNameText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ') e.Handled = true;
        }
    }
}

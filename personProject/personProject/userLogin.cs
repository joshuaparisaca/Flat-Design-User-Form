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

namespace personProject
{
    public partial class userLogin : Form //THIS FORM WILL ACCEPT USERNAME AND PASSWORD 
    {
        peopleData peopleMethods = new peopleData();

        List<String> fillTextBoxes = new List<string>();
        List<String> checkTextBoxes = new List<string>();

        public string email { get; set; }
        public string password { get; set; }

        public userLogin()
        {
            InitializeComponent();

        }

        private void userLogin_Load(object sender, EventArgs e)
        {
            foreach (var loop in peopleMethods.verify_person(email, password))
            {
                fillTextBoxes.Add(loop);
            }

            firstNameText.Text = fillTextBoxes[0];
            lastNameText.Text = fillTextBoxes[1];
            addressText.Text = fillTextBoxes[2];
            cityText.Text = fillTextBoxes[3];
            stateText.Text = fillTextBoxes[4];
            zipText.Text = fillTextBoxes[5];
            
            
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

        private void updateButton_Click(object sender, EventArgs e)
        {
            checkTextBoxes.Add(firstNameText.Text);
            checkTextBoxes.Add(lastNameText.Text);
            checkTextBoxes.Add(addressText.Text);
            checkTextBoxes.Add(cityText.Text);
            checkTextBoxes.Add(stateText.Text);
            checkTextBoxes.Add(zipText.Text);

            if (loopTextBoxes() == true || stateText.Text == ""  || peopleMethods.zipCodeTest(zipText.Text) == false)
            {
                MessageBox.Show("Please check your fields");
            }
            else if(checkTextBoxes.SequenceEqual(fillTextBoxes))
            {
                MessageBox.Show("Nothing was changed");
            }
            else
            {
                peopleMethods.update_person(email, firstNameText.Text, lastNameText.Text, addressText.Text, cityText.Text, stateText.Text, zipText.Text);
            }
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            passwordChange x = new passwordChange();
            x.email = email;
            x.ShowDialog();
        }
    }
}

using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace peopleLibrary
{
    public class peopleData
    {
        List<String> person = new List<String>();
        
        public bool loginButton(String username, String password) //Change back to void
        {
            if (username == "Username" || password == "Password")
            {
                System.Windows.Forms.MessageBox.Show("Enter both Username or Password");
                return false;
            }
            else
            {
                //Postgres log in
                if (verify_person(username, password).Any()) //..Any() Will check if list has any contents.
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        public void createButton(String username, String password, String firstName, String lastName, String address, String city, String states, String zipcode)
        {
            string prefix = "@";
            string suffix = ".com";
            string pattern = string.Format("{0}.*{1}", prefix, suffix);
            bool emailCheck = Regex.IsMatch(username, pattern);

            if (emailCheck ==  false || Regex.IsMatch(username, @"\s") || username == "@.com")
            {
                MessageBox.Show("Please enter a proper email");
            }

            else if (Regex.IsMatch(firstName, @"\s"))
            {
                MessageBox.Show("First name cant have any spaces");
            }
            
            else
            {
                add_person( username, password, firstName, lastName, address, city, states, zipcode);
            }
        }

        public void add_person(String username, String password, String firstName, String lastName, String address, String city, String states, String zipcode)
        {
            NpgsqlConnection connection = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                                    "Password=Parisaca11;Database=peopleDatabase;");
            connection.Open();

            try
            {
                string sql3 = "add_person";
                NpgsqlCommand pgcom = new NpgsqlCommand(sql3, connection);
                pgcom.CommandType = CommandType.StoredProcedure;

                pgcom.Parameters.AddWithValue("@email", username);
                pgcom.Parameters.AddWithValue("@hashedpassword", hashPassword(password)); //Method goes here
                pgcom.Parameters.AddWithValue("@firstname", firstName);
                pgcom.Parameters.AddWithValue("@lastname", lastName);
                pgcom.Parameters.AddWithValue("@address", address);
                pgcom.Parameters.AddWithValue("@city", city);
                pgcom.Parameters.AddWithValue("@states", states);
                pgcom.Parameters.AddWithValue("@zipcode", zipcode);

                NpgsqlDataReader dr = pgcom.ExecuteReader();

                MessageBox.Show("Record created");
            }
            catch(NpgsqlException e)
            {
                MessageBox.Show("This email already exists");
            }

            connection.Close();
        }

        public List<String> verify_person(String username, String password) 
        {
            NpgsqlConnection connection = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                                "Password=Parisaca11;Database=peopleDatabase;");
            connection.Open();
            try
            {
                string sql3 = "verify_person";
                NpgsqlCommand pgcom = new NpgsqlCommand(sql3, connection);
                pgcom.CommandType = CommandType.StoredProcedure;

                pgcom.Parameters.AddWithValue("@email", username);
                pgcom.Parameters.AddWithValue("@hashedpassword", hashPassword(password)); //Method goes here

                NpgsqlDataReader pgreader = pgcom.ExecuteReader();

                while (pgreader.Read()) //THIS DETERMINES IF AN ERROR OCCURS!~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~``
                {
                    person.Add(pgreader.GetString(2)); //2 = Firstname
                    person.Add(pgreader.GetString(3));
                    person.Add(pgreader.GetString(4));
                    person.Add(pgreader.GetString(5));
                    person.Add(pgreader.GetString(6));
                    person.Add(pgreader.GetString(7)); //7 = ZipCode
                }
            }

            catch (InvalidCastException)
            {
                MessageBox.Show("Please check your login information.");
            }
            connection.Close();

            return person;
        }

        public bool update_password(String username, String oldpassword, String newpassword)
        {
            NpgsqlConnection connection = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                            "Password=Parisaca11;Database=peopleDatabase;");
            connection.Open();

            try
            {
                string sql3 = "update_Password";
                NpgsqlCommand pgcom = new NpgsqlCommand(sql3, connection);
                pgcom.CommandType = CommandType.StoredProcedure;

                pgcom.Parameters.AddWithValue("@username", username);
                pgcom.Parameters.AddWithValue("@oldpassword", hashPassword(oldpassword));
                pgcom.Parameters.AddWithValue("@newpassword", hashPassword(newpassword));

                NpgsqlDataReader pgreader = pgcom.ExecuteReader();

                while (pgreader.Read()) //THIS DETERMINES IF AN ERROR OCCURS!~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~``
                {
                    pgreader.GetString(1);
                }

                MessageBox.Show("Password has been changed");
                connection.Close();
                return true;
            }

            catch (InvalidCastException e)
            {
                MessageBox.Show("You entered the wrong password");
                connection.Close();
                return false;
            }
            
        }

        public void update_person(String username, String firstName, String lastName, String address, String city, String states, String zipcode)
        {
            NpgsqlConnection connection = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" +
                            "Password=Parisaca11;Database=peopleDatabase;");
            connection.Open();

            string sql3 = "update_person";
            NpgsqlCommand pgcom = new NpgsqlCommand(sql3, connection);
            pgcom.CommandType = CommandType.StoredProcedure;

            pgcom.Parameters.AddWithValue("@username", username);
            pgcom.Parameters.AddWithValue("@firstName", firstName);
            pgcom.Parameters.AddWithValue("@lastName", lastName);
            pgcom.Parameters.AddWithValue("@Address", address);
            pgcom.Parameters.AddWithValue("@City", city);
            pgcom.Parameters.AddWithValue("@States", states);
            pgcom.Parameters.AddWithValue("@zipCode", zipcode);


            NpgsqlDataReader pgreader = pgcom.ExecuteReader();

            while (pgreader.Read())
            {
                pgreader.GetString(1);
            }

            MessageBox.Show("Record has been updated");
            connection.Close();
        }
        
        public string hashPassword(String password)
        {
            SHA1CryptoServiceProvider sh = new SHA1CryptoServiceProvider(); //DO the same with SHA256
            sh.ComputeHash(ASCIIEncoding.ASCII.GetBytes(password));
            byte[] re = sh.Hash;
            StringBuilder sb = new StringBuilder();

            foreach (byte b in re)
            {
                sb.Append(b.ToString("x2")); //NOT SALTED n is SHA1
            }

            String hashedPassword = sb.ToString(); //40 charachters

            return hashedPassword;
        }
        
        public bool zipCodeTest(String zipCode) 
        {
            bool allDigits = zipCode.All(char.IsDigit);

            if (zipCode.All(char.IsDigit) == true && zipCode.Length == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}

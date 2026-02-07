using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Login_Ulang
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void send_Click(object sender, EventArgs e)
        {
            String nameString = name.Text;
            String passwordString = password.Text;
            String passwordconString = passwordCom.Text;

            //Database Connection
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LoginApp;Integrated Security=True;TrustServerCertificate=True");
            //Query
            string query = "INSERT INTO LoginApp VALUES ('" + nameString + "', '" + passwordString + "', 'default')";
            string querycheck = "SELECT COUNT(*) FROM LoginApp WHERE username = @Username";

            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                SqlCommand check = new SqlCommand(querycheck, con);
                
                check.Parameters.AddWithValue("@Username", name.Text);
                con.Open();
                int count = (int)check.ExecuteScalar();


                if (string.IsNullOrEmpty(nameString))
                {
                    info.Text = "username needed";
                    return;
                }

                if (passwordString.Length < 8)
                {
                    info.Text = "password must be 8 characters";
                    return;
                }

                if (passwordconString == passwordString)
                {
                    if(count > 0)
                    {
                        MessageBox.Show("User Already Created");
                    }
                    else
                    {
                        cmd.ExecuteScalar();
                        name.Text = string.Empty;
                        password.Text = string.Empty;
                        passwordCom.Text = string.Empty;
                        info.Text = string.Empty;
                        MessageBox.Show("User Created");
                    }
                }
                else
                {
                    info.Text = "password incorrect";
                    return;
                }                
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                con.Close();
            }
        }

        private void directLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.Show();
        }
    }
}

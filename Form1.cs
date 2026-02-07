using System.Diagnostics.Eventing.Reader;
using System.DirectoryServices;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data;
using Microsoft.Identity.Client;

namespace Login_Ulang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nameString = name.Text;
            String passwordString = password.Text;
            Session.Username = nameString;
            Home home = new Home();

            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LoginApp;Integrated Security=True;TrustServerCertificate=True");

            try
            {
                string query = "SELECT role FROM LoginApp WHERE username = @username AND password = @password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", name.Text);
                cmd.Parameters.AddWithValue("@password", password.Text);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (string.IsNullOrEmpty(nameString))
                {
                    info.Text = "name and password is incorrect";
                    return;
                }

                if (passwordString.Length < 8)
                {
                    info.Text = "password must be 8 characters";
                    return;
                }

                if (dr.Read())
                {
                    string role = dr["role"].ToString();

                    Session.Role = role;

                    MessageBox.Show("Success");
                    this.Hide();
                    home.Show();
                }
                else
                {
                    info.Text = "name and password is incorrect";
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


        private void directRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register regis = new register();
            this.Hide();
            regis.Show();
        }
    }
}

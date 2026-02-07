using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.Identity.Client;
using System.Web;

namespace Login_Ulang
{
    public partial class Home : Form
    {
        public Form1 formScript;
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LoginApp;Integrated Security=True;TrustServerCertificate=True");
        string query = "SELECT * FROM LoginApp";
        DataTable dt = new DataTable();

        public Home()
        {
            InitializeComponent();
            greeting.Text = "Hello" + " " + Session.Username;
            LoadData();
        }

        private void LoadData()
        {
            if (dt != null)
            {
                dt.Clear();
            }

            SqlDataAdapter cmd = new SqlDataAdapter(query, con);
            cmd.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ForeColor = Color.Black;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            if (Session.Role.Trim().Equals("admin", StringComparison.OrdinalIgnoreCase))
            {
                dataGridView1.Visible = true;
                savebtn.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                txtId.Visible = true;
                txtPass.Visible = true;
                txtRole.Visible = true;
                MessageBox.Show("You are Admin");
            }
            else if (Session.Role.Trim().Equals("owner", StringComparison.OrdinalIgnoreCase))
            {
                dataGridView1.Visible = true;
                savebtn.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                txtId.Visible = true;
                txtPass.Visible = true;
                txtRole.Visible = true;
                MessageBox.Show("You are Owner");
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE LoginApp SET password = @password, role = @role WHERE id = @id";
            SqlCommand cmd = new SqlCommand(updateQuery, con);
            
            cmd.Parameters.AddWithValue("@id", txtId.Text);
            cmd.Parameters.AddWithValue("@password", txtPass.Text);
            cmd.Parameters.AddWithValue("@role", txtRole.Text);

            if (txtId.Text == "")
            {
                MessageBox.Show("No data to search");
                return;
            }

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Changed & Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
            finally
            {
                con.Close();
                LoadData();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtId.Text = dataGridView1.Rows[e.RowIndex].Cells["username"].Value.ToString();
                txtPass.Text = dataGridView1.Rows[e.RowIndex].Cells["password"].Value.ToString();
                txtRole.Text = dataGridView1.Rows[e.RowIndex].Cells["role"].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
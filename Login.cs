using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace EramusManager
{

    public partial class Login : Form
    {
        
        public Login()
        {

            InitializeComponent();

            

        }

     
            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Registo = new Registo();
            Registo.Closed += (s, args) => this.Close();
            Registo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = "Server=tcp:eramusmanager.database.windows.net,1433;Initial Catalog=eramusmanagerdb;Persist Security Info=False;User ID=eramusmanager;Password=ispgprojSAD!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(builder.ConnectionString);
            //SqlConnection sqlConn = new SqlConnection(connectionString);

            string em = email.Text;
            string pass = password.Text;

            connection.Open();
            String sql = "SELECT * FROM Users where email='" + email.Text + "' AND password='" + password.Text + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            //cmd = new SqlCommand();
            //sqlConn.Open();
            //cmd.Connection = sqlConn;
            //cmd.CommandText = "SELECT * FROM Users where email='" + email.Text + "' AND password='" + password.Text + "'";
            //dr = cmd.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Login sucess");

                this.Hide();
                Form Welcome = new Welcome();
                Welcome.Closed += (s, args) => this.Close();
                Welcome.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login please check email and password");
                email.Text = "";
                password.Text = "";
                email.Focus();
            }
            

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

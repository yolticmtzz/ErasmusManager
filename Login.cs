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

         String UserID = null;

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

            string em = email.Text;
            string pass = password.Text;

            connection.Open();
            String sql = "SELECT * FROM Users where email='" + email.Text + "' AND password='" + password.Text + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
                {
                    MessageBox.Show("Login sucess");
                    connection.Close();
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

            connection.Open();
            String GetUserID = "SELECT userId FROM Users where email='" + email.Text + "' ";
            SqlCommand cmd = new SqlCommand(GetUserID, connection);
            SqlDataReader re = cmd.ExecuteReader();

            while (re.Read())
            {
                Properties.Settings.Default.UserID = re["userId"].ToString();

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

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

    public partial class Registo : Form
    {
       
        public Registo()
        {         
            InitializeComponent();
            
        }

 
        private void button1_Click(object sender, EventArgs e)
        {

            //CONEXÃO BASE DE DADOS
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = "Server=tcp:eramusmanager.database.windows.net,1433;Initial Catalog=eramusmanagerdb;Persist Security Info=False;User ID=eramusmanager;Password=ispgprojSAD!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(builder.ConnectionString);

            if (username.Text == "" && email.Text == "" && password.Text == "" && confirmpass.Text == "") //Verificação se estão campos vazios
            {
                MessageBox.Show("Username, Email and Password fields are empty", "Registration Failed",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (password.Text == confirmpass.Text) 
            {
                connection.Open();
                String sql = "INSERT INTO Users VALUES('" + email.Text + "', '" + username.Text + "', '" + password.Text + "', '" + institution.Text + "')";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                
                username.Text = "";
                email.Text = "";
                password.Text = "";
                confirmpass.Text = "";
                institution.Text = "";

                MessageBox.Show("Your Account has been successfully created", "Registration Success", MessageBoxButtons.OK,MessageBoxIcon.Information);


                this.Hide();
                Form Login = new Login();
                Login.Closed += (s, args) => this.Close();
                Login.Show();

            }
            else
            {
                MessageBox.Show("Passwords does not match", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password.Text = "";
                confirmpass.Text = "";
                password.Focus();
            }
        }

            private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Registo_Load(object sender, EventArgs e)
        {
            

        
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Login = new Login();
            Login.Closed += (s, args) => this.Close();
            Login.Show();
        }
    }
}

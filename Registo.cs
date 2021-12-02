using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //ALTERAR CONEÇÃO PARA FUNCIONAR 
            System.Data.SqlClient.SqlConnection sqlConnection1 = new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\heldermartins\Desktop\ErasmusMananger\ErasmusManager\emdb.mdf;Integrated Security=True");

            if (username.Text == "" && email.Text == "" && password.Text == "" && confirmpass.Text == "")
            {
                MessageBox.Show("Username, Email and Password fields are empty", "Registration Failed",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (password.Text == confirmpass.Text)
            {
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO Users VALUES ('" + email.Text + "','" + username.Text + "','" + password.Text + "')";
                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();
                cmd.ExecuteNonQuery();
                sqlConnection1.Close();

                username.Text = "";
                email.Text = "";
                password.Text = "";
                confirmpass.Text = "";

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

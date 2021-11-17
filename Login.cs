using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EramusManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        System.Data.SqlClient.SqlConnection sqlConnection1 = new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Helder\Faculdade\SAD\Trabalho\ErasmusManager\emdb.mdf;Integrated Security=True");


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

            sqlConnection1.Open();
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT INTO Users VALUES ('" + email.Text + "','" + password.Text + "')";

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();

            //COMPLETAR
            

            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

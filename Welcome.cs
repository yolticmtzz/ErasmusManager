using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EramusManager
{
    public partial class Welcome : Form
    {

        

        public Welcome()
        {
            

            InitializeComponent();

        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            Registo GetUsername = new Registo();
            
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.ConnectionString = "Server=tcp:eramusmanager.database.windows.net,1433;Initial Catalog=eramusmanagerdb;Persist Security Info=False;User ID=eramusmanager;Password=ispgprojSAD!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                SqlConnection connection = new SqlConnection(builder.ConnectionString);

                connection.Open();
                String sql = "SELECT username FROM Users WHERE username='" + GetUsername.username.Text + "' ";
                Console.WriteLine(sql);

                //string strUsrNm = Convert.ToString(sql);
                //label3.Text = strUsrNm;
              
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form NovoProjeto = new NovoProjeto();
            NovoProjeto.Closed += (s, args) => this.Close();
            NovoProjeto.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

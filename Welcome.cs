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

        SqlCommand cmd;
        SqlDataReader dr;
        string connectionString = " Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = D:\\Helder\\Faculdade\\SAD\\Trabalho\\ErasmusManager\\emdb.mdf; Integrated Security = True";

        public Welcome()
        {
            

            InitializeComponent();

        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            Registo GetUsername = new Registo();
            try
            {
                SqlConnection sqlConn = new SqlConnection(connectionString);
                using (sqlConn)
                {
                    sqlConn.Open();
                    string query = "SELECT username FROM Users WHERE username='" + GetUsername.username.Text + "' ";
                    SqlCommand cmd = new SqlCommand(query, sqlConn);
                    string strUsrNm = Convert.ToString(cmd.ExecuteScalar());
                    label3.Text = strUsrNm;
                }
            }
            catch
            {
            }
            finally
            {

            }
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

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

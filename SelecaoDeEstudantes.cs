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
    public partial class SelecaoDeEstudantes : Form
    {
        public SelecaoDeEstudantes()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SelecaoDeEstudantes_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = "Server=tcp:eramusmanager.database.windows.net,1433;Initial Catalog=eramusmanagerdb;Persist Security Info=False;User ID=eramusmanager;Password=ispgprojSAD!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(builder.ConnectionString);


            connection.Open();
            String mp = "SELECT studentName FROM Students WHERE studentId = 12";
            SqlCommand MPcommand = new SqlCommand(mp, connection);
            SqlDataReader MPreader = MPcommand.ExecuteReader();


            while (MPreader.Read())
            {
                labelnomedoaluno.Text = MPreader.GetString(0);
            }

            connection.Close();

            connection.Open();
            String mp1 = "SELECT studyFieldReq FROM DetailsReq WHERE detailsId = (SELECT max(detailsId) FROM DetailsReq WHERE projectId = ('" + Properties.Settings.Default.projectId + "')) ";
            SqlCommand MPcommand1 = new SqlCommand(mp1, connection);
            SqlDataReader MPreader1 = MPcommand1.ExecuteReader();


            while (MPreader1.Read())
            {
                labelperguntaareastring.Text = "O estudante tem experiência na área de " + MPreader1.GetString(0) + "?";
            }

            connection.Close();
        }

        private void niveldefluente_Scroll(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = "Server=tcp:eramusmanager.database.windows.net,1433;Initial Catalog=eramusmanagerdb;Persist Security Info=False;User ID=eramusmanager;Password=ispgprojSAD!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(builder.ConnectionString);


            
        }

        private void radioButtonSIM_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonNAO_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonINGLES_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}

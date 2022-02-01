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
    public partial class NovoProjeto : Form
    {
        public NovoProjeto()
        {
            InitializeComponent();
        }

        String projectId = null;

        private void NovoProjeto_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = "Server=tcp:eramusmanager.database.windows.net,1433;Initial Catalog=eramusmanagerdb;Persist Security Info=False;User ID=eramusmanager;Password=ispgprojSAD!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(builder.ConnectionString);

            //Mostrar Parceiros
            connection.Open();
            String mp = "SELECT username FROM Users";
            SqlCommand MPcommand = new SqlCommand(mp, connection);
            SqlDataReader MPreader = MPcommand.ExecuteReader();

            while ( MPreader.Read())
            {
                comboparceiros.Items.Add(MPreader.GetString(0));
            }


            label4.Visible = false;
            panel1.Visible = false;
            estadolabel.Visible = false;

            test.Text = Properties.Settings.Default.UserID;
            connection.Close();
        }

        private void criarprojetobtt_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = "Server=tcp:eramusmanager.database.windows.net,1433;Initial Catalog=eramusmanagerdb;Persist Security Info=False;User ID=eramusmanager;Password=ispgprojSAD!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(builder.ConnectionString);

            if (nomedoprojeto.Text == "")
            {
                MessageBox.Show("Empty or Invalid Project Name", "Create New Project Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                

                connection.Open();
                //GUARDAR O PROJETO
                String sql = "INSERT INTO Projects VALUES('" + nomedoprojeto.Text + "' , '" + estadolabel.Text + "', '" + Properties.Settings.Default.UserID + "' , '" + comboparceiros.Text + "')";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                connection.Close();
  
                connection.Open();
                String GetProjectID = "SELECT projectId FROM Projects where projectName='" + nomedoprojeto.Text + "' ";
                SqlCommand cmd = new SqlCommand(GetProjectID, connection);
                SqlDataReader re = cmd.ExecuteReader();

                while (re.Read())
                {
                    Properties.Settings.Default.projectId = re["projectId"].ToString();
                }

                boxDebugPID.Text = Properties.Settings.Default.projectId;
                connection.Close();

                nomedoprojeto.Text = "";

                MessageBox.Show("Project has been successfully created", "New Project Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form CriteriosDesej = new CriteriosDesej();
                CriteriosDesej.Closed += (s, args) => this.Close();
                CriteriosDesej.Show();
            }

            

        }

        private void comboparceiros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nomedoprojeto_TextChanged(object sender, EventArgs e)
        {
            if (nomedoprojeto.Text == "")
            {
                label4.Visible = false;
                panel1.Visible = false;
                estadolabel.Visible = false;
            } else
            {
                label4.Visible = true;
                panel1.Visible = true;
                estadolabel.Visible = true;
            }
        }

        private void test_Click(object sender, EventArgs e)
        {

        }
    }
}
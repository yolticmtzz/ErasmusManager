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
    public partial class EditarProjeto : Form
    {
        public EditarProjeto()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            statustext.Visible = false;
            textstatus.Visible = false;
            panelstatus.Visible = false;
            finishedtext.Visible = false;
            finishedpanel.Visible = false;

            Form Simulacao = new Simulacao();
            Simulacao.Closed += (s, args) => this.Close();
            Simulacao.Show();


            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = "Server=tcp:eramusmanager.database.windows.net,1433;Initial Catalog=eramusmanagerdb;Persist Security Info=False;User ID=eramusmanager;Password=ispgprojSAD!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(builder.ConnectionString);

            connection.Open();

            connection.Close();


            //Mostrar Projetos
            connection.Open();
            String mp = "SELECT projectName FROM Projects WHERE userId = ('" + Properties.Settings.Default.UserID + "' )";
            SqlCommand MPcommand = new SqlCommand(mp, connection);
            SqlDataReader MPreader = MPcommand.ExecuteReader();

            while (MPreader.Read())
            {
                comboNomeProjeto.Items.Add(MPreader.GetString(0));

            }
            connection.Close();

            //Mostrar Parceiros
            connection.Open();
            String ShowPart = "SELECT username FROM Users";
            SqlCommand ShowPartcommand = new SqlCommand(ShowPart, connection);
            SqlDataReader ShowPartreader = ShowPartcommand.ExecuteReader();

            while (ShowPartreader.Read())
            {
                comboparterns.Items.Add(ShowPartreader.GetString(0));

            }

            connection.Close();     

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void newname_TextChanged(object sender, EventArgs e)
        {

        }

        private void criarprojetobtt_Click(object sender, EventArgs e)
        {
            Boolean terminar = false;
            String status = "Finished";

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = "Server=tcp:eramusmanager.database.windows.net,1433;Initial Catalog=eramusmanagerdb;Persist Security Info=False;User ID=eramusmanager;Password=ispgprojSAD!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(builder.ConnectionString);

            if (comboparterns.Text == "" && comboNomeProjeto.Text == "")
            {
                MessageBox.Show("Empty or Invalid Data", "Edit Project Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (terminar = finishcheck.Checked)
                {
                    //GUARDAR NOVO PROJECTO
                    connection.Open();
                    String GNewProject = "UPDATE Projects SET projectName = ('" + newname.Text + "' ) , username = ('" + comboparterns.Text + "'), status = ('" + status +"') WHERE projectName = ('" + comboNomeProjeto.Text + "') AND userId = ('" + Properties.Settings.Default.UserID + "' )";
                    SqlCommand GNewProjectcommand = new SqlCommand(GNewProject, connection);
                    SqlDataReader GNewProjectreader = GNewProjectcommand.ExecuteReader();
                    connection.Close();
                }
                else
                {
                    //GUARDAR NOVO PROJECTO
                    connection.Open();
                    String GNewProject = "UPDATE Projects SET projectName = ('" + newname.Text + "' ) , username = ('" + comboparterns.Text + "') WHERE projectName = ('" + comboNomeProjeto.Text + "') AND userId = ('" + Properties.Settings.Default.UserID + "' )";
                    SqlCommand GNewProjectcommand = new SqlCommand(GNewProject, connection);
                    SqlDataReader GNewProjectreader = GNewProjectcommand.ExecuteReader();
                    connection.Close();

                    connection.Open();
                    String GetProjectID = "SELECT projectId FROM Projects where projectName='" + comboNomeProjeto.Text + "' ";
                    SqlCommand cmd = new SqlCommand(GetProjectID, connection);
                    SqlDataReader re = cmd.ExecuteReader();

                    while (re.Read())
                    {
                        Properties.Settings.Default.projectId = re["projectId"].ToString();
                    }

                    boxDebugPID.Text = Properties.Settings.Default.projectId;
                    connection.Close();

                }


                finishcheck.Checked = false;
                newname.Text = "";
                comboNomeProjeto.Text = "";
                comboparterns.Text = "";

                MessageBox.Show("Project has been successfully edited", "Edit Project Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form CriteriosDesejEdit = new CriteriosDesejEdit();
                CriteriosDesejEdit.Closed += (s, args) => this.Close();
                CriteriosDesejEdit.Show();
            }
        }

        private void comboNomeProjeto_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = "Server=tcp:eramusmanager.database.windows.net,1433;Initial Catalog=eramusmanagerdb;Persist Security Info=False;User ID=eramusmanager;Password=ispgprojSAD!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(builder.ConnectionString);

            //GET PARTNER FOR EDIT PROJECT
            connection.Open();
            String GetPartner4comb = "SELECT username FROM Projects WHERE projectName = ('" + comboNomeProjeto.Text+ "')";
            SqlCommand GetPartner4combtcommand = new SqlCommand(GetPartner4comb, connection);
            SqlDataReader GetPartner4reader = GetPartner4combtcommand.ExecuteReader();

            while (GetPartner4reader.Read())
            {
                comboparterns.Text = GetPartner4reader["username"].ToString();
            }

            Object selectedItem = comboNomeProjeto.SelectedItem;
            newname.Text = selectedItem.ToString();
            connection.Close();

            //GET Status
            connection.Open();
            String status = "SELECT status FROM Projects WHERE projectName = ('" + comboNomeProjeto.Text + "')";
            SqlCommand statuscommand = new SqlCommand(status, connection);
            SqlDataReader statusreader = statuscommand.ExecuteReader();

            while (statusreader.Read())
            {
                textstatus.Text = statusreader["status"].ToString();

                if (textstatus.Text == "In Progress")
                {
                    statustext.Visible = true;
                    textstatus.Visible = true;
                    panelstatus.Visible = true;
                    finishedtext.Visible = false;
                    finishedpanel.Visible = false;
                    finishcheck.Visible = true;
                    label4.Visible = true;
                    
                }
                else
                {
                    textstatus.Visible = false;
                    panelstatus.Visible = false;
                    statustext.Visible = true;
                    finishedtext.Visible = true;
                    finishedpanel.Visible = true;
                    label4.Visible = false;
                    finishcheck.Visible = false;
                }
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void comboparterns_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

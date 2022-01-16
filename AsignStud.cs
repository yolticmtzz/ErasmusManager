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
    public partial class AsignStud : Form
    {
        public AsignStud()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboNomeProjeto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selectedItem = comboStudentName.SelectedItem;
            studentName.Text = selectedItem.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AsignStud_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            debugPID.Visible = false;

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = "Server=tcp:eramusmanager.database.windows.net,1433;Initial Catalog=eramusmanagerdb;Persist Security Info=False;User ID=eramusmanager;Password=ispgprojSAD!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(builder.ConnectionString);

            connection.Open();

            connection.Close();

            //GET STUDENT NAME 
            connection.Open();
            String GetStudent4comb = "SELECT studentName FROM Students";
            SqlCommand GetStudent4combtcommand = new SqlCommand(GetStudent4comb, connection);
            SqlDataReader GetStudent4reader = GetStudent4combtcommand.ExecuteReader();

            while (GetStudent4reader.Read())
            {
                comboStudentName.Items.Add(GetStudent4reader.GetString(0));
            }
            connection.Close();

            //GET PROJECT NAME 
            connection.Open();
            String GetProject4comb = "SELECT projectName FROM Projects";
            SqlCommand GetProject4combtcommand = new SqlCommand(GetProject4comb, connection);
            SqlDataReader GetProject4reader = GetProject4combtcommand.ExecuteReader();

            while (GetProject4reader.Read())
            {
                comboProjectName.Items.Add(GetProject4reader.GetString(0));
            }
            connection.Close();

           

        }

        private void comboProjectName_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = "Server=tcp:eramusmanager.database.windows.net,1433;Initial Catalog=eramusmanagerdb;Persist Security Info=False;User ID=eramusmanager;Password=ispgprojSAD!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(builder.ConnectionString);
            

            //DEBUG PROJECT ID 
            connection.Open();
            String debug = "SELECT projectId FROM Projects WHERE projectName = ('" + comboProjectName.Text + "')";
            SqlCommand debugcommand = new SqlCommand(debug, connection);
            SqlDataReader debugreader = debugcommand.ExecuteReader();

            while (debugreader.Read())
            {
                debugPID.Text = debugreader["projectId"].ToString();
                Properties.Settings.Default.projectId = debugreader["projectId"].ToString();
            }

            Object selectedItem = comboProjectName.SelectedItem;
            ProjectName.Text = selectedItem.ToString();
            connection.Close();
        }

        private void criarprojetobtt_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = "Server=tcp:eramusmanager.database.windows.net,1433;Initial Catalog=eramusmanagerdb;Persist Security Info=False;User ID=eramusmanager;Password=ispgprojSAD!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(builder.ConnectionString);
            int studentId = 0;
            int countRows = 0;

            if (comboProjectName.Text == "" && comboStudentName.Text == "")
            {
                MessageBox.Show("Empty or Invalid Data", "Assign Student Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //SAVE STUDENT TO PROJECT
                connection.Open();
                String GNewProject = "UPDATE Students SET projectId = ('" + debugPID.Text + "') WHERE studentName = ('" + comboStudentName.Text + "')";
                SqlCommand GNewProjectcommand = new SqlCommand(GNewProject, connection);
                SqlDataReader GNewProjectreader = GNewProjectcommand.ExecuteReader();
                connection.Close();
            }

            

            connection.Open();
            String GNewProject2 = "SELECT studentId FROM Students WHERE projectId = ('" + debugPID.Text + "') AND studentName = ('"+ comboStudentName.Text +"')";
            SqlCommand GNewProjectcommand2 = new SqlCommand(GNewProject2, connection);
            SqlDataReader GNewProjectreader2 = GNewProjectcommand2.ExecuteReader();
            
            while (GNewProjectreader2.Read())
            {
                studentId = GNewProjectreader2.GetInt32(0);
            }
            connection.Close();

            connection.Open();
            String GNewProject1 = "SELECT COUNT(languageId) FROM Languages WHERE studentId = ('" + studentId + "') ";
            SqlCommand GNewProjectcommand1 = new SqlCommand(GNewProject1, connection);
            SqlDataReader GNewProjectreader1 = GNewProjectcommand1.ExecuteReader();

            while (GNewProjectreader1.Read())
            {
                countRows = GNewProjectreader1.GetInt32(0);
            }

            connection.Close();

            if(countRows == 0)
            {
                connection.Open();
                String GNewProject11 = "INSERT INTO Languages VALUES('ingles', '" + 0 + "', '" + studentId + "' )  ";
                SqlCommand GNewProjectcommand11 = new SqlCommand(GNewProject11, connection);
                SqlDataReader GNewProjectreader11 = GNewProjectcommand11.ExecuteReader();
                connection.Close();

                connection.Open();
                String GNewProject21 = "INSERT INTO Languages VALUES('espanhol', '" + 0 + "', '" + studentId + "' )  ";
                SqlCommand GNewProjectcommand21 = new SqlCommand(GNewProject21, connection);
                SqlDataReader GNewProjectreader21 = GNewProjectcommand21.ExecuteReader();
                connection.Close();

                connection.Open();
                String GNewProject31 = "INSERT INTO Languages VALUES('frances', '" + 0 + "', '" + studentId + "' )  ";
                SqlCommand GNewProjectcommand31 = new SqlCommand(GNewProject31, connection);
                SqlDataReader GNewProjectreader31 = GNewProjectcommand31.ExecuteReader();
                connection.Close();

                connection.Open();
                String GNewProject41 = "INSERT INTO Languages VALUES('italiano', '" + 0 + "', '" + studentId + "' )  ";
                SqlCommand GNewProjectcommand41 = new SqlCommand(GNewProject41, connection);
                SqlDataReader GNewProjectreader41 = GNewProjectcommand41.ExecuteReader();
                connection.Close();

                connection.Open();
                String GNewProject51 = "INSERT INTO Languages VALUES('alemao', '" + 0 + "', '" + studentId + "' )  ";
                SqlCommand GNewProjectcommand51 = new SqlCommand(GNewProject51, connection);
                SqlDataReader GNewProjectreader51 = GNewProjectcommand51.ExecuteReader();
                connection.Close();


            }

            comboStudentName.Text = "";
            comboProjectName.Text = "";
            ProjectName.Text = "";
            studentName.Text = "";

            MessageBox.Show("Student has been successfully assigned", "Assign Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form SelecaoDeEstudantes = new SelecaoDeEstudantes();
            SelecaoDeEstudantes.Closed += (s, args) => this.Close();
            SelecaoDeEstudantes.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

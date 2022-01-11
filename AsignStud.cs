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

            comboStudentName.Text = "";
            comboProjectName.Text = "";
            ProjectName.Text = "";
            studentName.Text = "";

            MessageBox.Show("Student has been successfully assigned", "Assign Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

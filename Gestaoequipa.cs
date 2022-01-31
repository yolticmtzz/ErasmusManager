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
    public partial class Gestaoequipa : Form
    {
        public Gestaoequipa()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Gestaoequipa_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = "Server=tcp:eramusmanager.database.windows.net,1433;Initial Catalog=eramusmanagerdb;Persist Security Info=False;User ID=eramusmanager;Password=ispgprojSAD!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(builder.ConnectionString);

            //GET PROJECT NAME 
            connection.Open();
            String GetProject4comb = "SELECT projectName FROM Projects";
            SqlCommand GetProject4combtcommand = new SqlCommand(GetProject4comb, connection);
            SqlDataReader GetProject4reader = GetProject4combtcommand.ExecuteReader();

            while (GetProject4reader.Read())
            {
                comboprojectos.Items.Add(GetProject4reader.GetString(0));
            }
            connection.Close();
        }

        private void criarprojetobtt_Click(object sender, EventArgs e)
        {
            
        }

        private void comboprojectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = "Server=tcp:eramusmanager.database.windows.net,1433;Initial Catalog=eramusmanagerdb;Persist Security Info=False;User ID=eramusmanager;Password=ispgprojSAD!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(builder.ConnectionString);

            //GET PROJECT ID
            connection.Open();
            String GetProjectID = "SELECT projectId FROM Projects WHERE projectName = ('" + comboprojectos.Text + "')";
            SqlCommand GetProjectIDcommand = new SqlCommand(GetProjectID, connection);
            SqlDataReader GetProjectIDreader = GetProjectIDcommand.ExecuteReader();

            while (GetProjectIDreader.Read())
            {
                Properties.Settings.Default.projectId = GetProjectIDreader["projectId"].ToString();
            }

            debugPID.Text = Properties.Settings.Default.projectId;

            connection.Close();

            //GET STUDENT ID
            connection.Open();
            String GetStudentId = "SELECT studentId FROM Students WHERE projectId = ('" + debugPID.Text + "')";
            SqlCommand GetStudentIdcommand = new SqlCommand(GetStudentId, connection);
            SqlDataReader GetStudentIdreader = GetStudentIdcommand.ExecuteReader();

            while (GetStudentIdreader.Read())
            {
                Properties.Settings.Default.studentId = GetStudentIdreader["studentId"].ToString();
            }

            debug2.Text = Properties.Settings.Default.studentId;

            connection.Close();

            //GET STUDENT NAME
            connection.Open();
            String GetStdName = "SELECT studentName FROM Students WHERE projectId = ('" + debugPID.Text + "')";
            SqlCommand GetStdNamecommand = new SqlCommand(GetStdName, connection);
            SqlDataReader GetStdNamereader = GetStdNamecommand.ExecuteReader();

            while (GetStdNamereader.Read())
            {
                listanomes.Items.Add(GetStdNamereader.GetString(0));
            }
            connection.Close();

            //GET ATRIB1
            connection.Open();
            String GetAtrib1 = "SELECT langName FROM Languages WHERE studentId = ('" + debug2.Text + "')";
            SqlCommand GetAtrib1command = new SqlCommand(GetAtrib1, connection);
            SqlDataReader GetAtrib1reader = GetAtrib1command.ExecuteReader();

            while (GetAtrib1reader.Read())
            {
                listatrib1.Items.Add(GetAtrib1reader.GetString(0));
            }
            connection.Close();

            //GET ATRIB2
            connection.Open();
            String GetAtrib2 = "SELECT evaluationLang FROM Languages WHERE studentId = ('" + debug2.Text + "')";
            SqlCommand GetAtrib2command = new SqlCommand(GetAtrib2, connection);
            SqlDataReader GetAtrib2reader = GetAtrib2command.ExecuteReader();

            while (GetAtrib2reader.Read())
            {
                listatrib2.Items.Add(GetAtrib2reader.GetInt32(0));
            }
            connection.Close();

            //GET ATRIB3
            connection.Open();
            String GetAtrib3 = "SELECT type FROM Languages WHERE studentId = ('" + debug2.Text + "')";
            SqlCommand GetAtrib3command = new SqlCommand(GetAtrib3, connection);
            SqlDataReader GetAtrib3reader = GetAtrib3command.ExecuteReader();

            while (GetAtrib3reader.Read())
            {
                listatrib3.Items.Add(GetAtrib3reader.GetString(0));
            }
            connection.Close();

        }
    }
}

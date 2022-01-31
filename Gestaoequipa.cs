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
        List<string> langs = new List<string>();
        List<string> studentId = new List<string>();
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
            Form Simulacao = new Simulacao();
            Simulacao.Closed += (s, args) => this.Close();
            Simulacao.Show();
        }

        private void comboprojectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = "Server=tcp:eramusmanager.database.windows.net,1433;Initial Catalog=eramusmanagerdb;Persist Security Info=False;User ID=eramusmanager;Password=ispgprojSAD!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(builder.ConnectionString);

            listanomes.Items.Clear();
            listatrib1.Items.Clear();
            listatrib2.Items.Clear();
            listatrib3.Items.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";

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

            connection.Open();
            String GetProject43comb = "SELECT studyFieldReq FROM DetailsReq WHERE projectId = ('" + Properties.Settings.Default.projectId +"')";
            SqlCommand GetProject43combtcommand = new SqlCommand(GetProject43comb, connection);
            SqlDataReader GetProject43reader = GetProject43combtcommand.ExecuteReader();

            while (GetProject43reader.Read())
            {
                if(GetProject43reader.GetString(0) != "SM")
                {
                    langs.Add(GetProject43reader.GetString(0));
                }
                
            }
            connection.Close();

            foreach(string lang in langs)
            {
                Console.WriteLine(lang);
            }

            if (langs.Count >= 1)
            {
                textBox2.Text = langs[0];
            }
            if(langs.Count >= 2)
            {
                textBox3.Text = langs[1];
            }
            if(langs.Count >= 3)
            {
                textBox4.Text = langs[2];
            }
            if (langs.Count >= 4)
            {
                textBox6.Text = langs[3];
            }
            if (langs.Count >= 5)
            {
                textBox5.Text = langs[4];
            }
            if (langs.Count == 6)
            {
                textBox7.Text = langs[5];
            }

            

            //GET STUDENT ID
            connection.Open();
            String GetStudentId = "SELECT studentId FROM Students WHERE projectId = ('" + debugPID.Text + "')";
            SqlCommand GetStudentIdcommand = new SqlCommand(GetStudentId, connection);
            SqlDataReader GetStudentIdreader = GetStudentIdcommand.ExecuteReader();

            while (GetStudentIdreader.Read())
            {
                Properties.Settings.Default.studentId = GetStudentIdreader["studentId"].ToString();
                studentId.Add(GetStudentIdreader["studentId"].ToString());
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
            foreach (string id in studentId)
            {
                connection.Open();
                String GetAtrib1 = "SELECT evaluationLang FROM Languages WHERE studentId = ('" + id + "') AND langName = ('" + langs[0] +"')";
                SqlCommand GetAtrib1command = new SqlCommand(GetAtrib1, connection);
                SqlDataReader GetAtrib1reader = GetAtrib1command.ExecuteReader();

                while (GetAtrib1reader.Read())
                {
                    listatrib1.Items.Add(Convert.ToString(GetAtrib1reader.GetInt32(0)));
                }
                connection.Close();
            }

            //GET ATRIB2
            foreach (string id in studentId)
            {
                connection.Open();
                String GetAtrib1 = "SELECT evaluationLang FROM Languages WHERE studentId = ('" + id + "') AND langName = ('" + langs[1] + "')";
                SqlCommand GetAtrib1command = new SqlCommand(GetAtrib1, connection);
                SqlDataReader GetAtrib1reader = GetAtrib1command.ExecuteReader();

                while (GetAtrib1reader.Read())
                {
                    listatrib2.Items.Add(Convert.ToString(GetAtrib1reader.GetInt32(0)));
                }
                connection.Close();
            }

            //GET ATRIB3
            foreach (string id in studentId)
            {
                connection.Open();
                String GetAtrib1 = "SELECT evaluationLang FROM Languages WHERE studentId = ('" + id + "') AND langName = ('" + langs[2] + "')";
                SqlCommand GetAtrib1command = new SqlCommand(GetAtrib1, connection);
                SqlDataReader GetAtrib1reader = GetAtrib1command.ExecuteReader();

                while (GetAtrib1reader.Read())
                {
                    listatrib3.Items.Add(Convert.ToString(GetAtrib1reader.GetInt32(0)));
                }
                connection.Close();
            }

            foreach (string id in studentId)
            {
                connection.Open();
                String GetAtrib1 = "SELECT evaluationLang FROM Languages WHERE studentId = ('" + id + "') AND langName = ('" + langs[3] + "')";
                SqlCommand GetAtrib1command = new SqlCommand(GetAtrib1, connection);
                SqlDataReader GetAtrib1reader = GetAtrib1command.ExecuteReader();

                while (GetAtrib1reader.Read())
                {
                    listBox3.Items.Add(Convert.ToString(GetAtrib1reader.GetInt32(0)));
                }
                connection.Close();
            }

            foreach (string id in studentId)
            {
                connection.Open();
                String GetAtrib1 = "SELECT evaluationLang FROM Languages WHERE studentId = ('" + id + "') AND langName = ('" + langs[4] + "')";
                SqlCommand GetAtrib1command = new SqlCommand(GetAtrib1, connection);
                SqlDataReader GetAtrib1reader = GetAtrib1command.ExecuteReader();

                while (GetAtrib1reader.Read())
                {
                    listBox2.Items.Add(Convert.ToString(GetAtrib1reader.GetInt32(0)));
                }
                connection.Close();
            }

            foreach (string id in studentId)
            {
                connection.Open();
                String GetAtrib1 = "SELECT evaluationLang FROM Languages WHERE studentId = ('" + id + "') AND langName = ('" + langs[5] + "')";
                SqlCommand GetAtrib1command = new SqlCommand(GetAtrib1, connection);
                SqlDataReader GetAtrib1reader = GetAtrib1command.ExecuteReader();

                while (GetAtrib1reader.Read())
                {
                    listBox1.Items.Add(Convert.ToString(GetAtrib1reader.GetInt32(0)));
                }
                connection.Close();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

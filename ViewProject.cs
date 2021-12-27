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
    public partial class ViewProject : Form
    {
        public ViewProject()
        {
            InitializeComponent();
        }

        private void ViewProject_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = "Server=tcp:eramusmanager.database.windows.net,1433;Initial Catalog=eramusmanagerdb;Persist Security Info=False;User ID=eramusmanager;Password=ispgprojSAD!;MultipleActiveResultSets=True;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(builder.ConnectionString);

            connection.Open();
            //Mostrar Projetos
            String pid = "SELECT projectId FROM Projects WHERE userId='" + Properties.Settings.Default.UserID + "' ";
            SqlCommand pidcommand = new SqlCommand(pid, connection);
            SqlDataReader pidreader = pidcommand.ExecuteReader();

            String pname = "SELECT projectName FROM Projects WHERE userId='" + Properties.Settings.Default.UserID + "' ";
            SqlCommand pnamecommand = new SqlCommand(pname, connection);
            SqlDataReader pnamereader = pnamecommand.ExecuteReader();

            String status = "SELECT status FROM Projects WHERE userId='" + Properties.Settings.Default.UserID + "' ";
            SqlCommand statuscommand = new SqlCommand(status, connection);
            SqlDataReader statusreader = statuscommand.ExecuteReader();


            while (pidreader.Read() && pnamereader.Read() && statusreader.Read())
            {
                listBox1.Items.Add(pidreader.GetInt32(0));
                listBox2.Items.Add(pnamereader.GetString(0));
                listBox3.Items.Add(statusreader.GetString(0));
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

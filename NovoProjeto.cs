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
    public partial class NovoProjeto: Form
    {
        public NovoProjeto()
        {
            InitializeComponent();
        }

        private void NovoProjeto_Load(object sender, EventArgs e)
        {

        }

        private void criarprojetobtt_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = "Server=tcp:eramusmanager.database.windows.net,1433;Initial Catalog=eramusmanagerdb;Persist Security Info=False;User ID=eramusmanager;Password=ispgprojSAD!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(builder.ConnectionString);

            if (nomedoprojeto.Text == "" )
            {
                MessageBox.Show("Empty or Invalid Project Name", "Create New Project Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else
            {
                //connection.Open();
                //String sql = "INSERT INTO Projects VALUES('" + nomedoprojeto.Text + "' '" + useriD.Text + "')";
                //SqlCommand command = new SqlCommand(sql, connection);
                //SqlDataReader reader = command.ExecuteReader();

                //nomedoprojeto.Text = "";

                MessageBox.Show("Project has been successfully created", "New Project Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}

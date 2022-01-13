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
    public partial class CriteriosDesej : Form
    {
        Boolean edit = false;
        public CriteriosDesej()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    

        private void comboparceiros_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelcomunicacaoling_Click(object sender, EventArgs e)
        {

        }

        private void labellingua2parte_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CriteriosDesej_Load(object sender, EventArgs e)
        {

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = "Server=tcp:eramusmanager.database.windows.net,1433;Initial Catalog=eramusmanagerdb;Persist Security Info=False;User ID=eramusmanager;Password=ispgprojSAD!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(builder.ConnectionString);
            connection.Open();

            debugPID.Text = Properties.Settings.Default.projectId;

            autonomia.Items.Add("Sim");
            autonomia.Items.Add("Não");

            for (int i = 0; i < 11; i++)
            {
                linguas.Items.Add(i);
                comboBox1.Items.Add(i);
                comboBox2.Items.Add(i);
                comboBox3.Items.Add(i);
                nivelaceitavel.Items.Add(i);
                nivelaceitavellingua.Items.Add(i);
            }

            string[] areas = {"Formação de Professores/Formadores e Ciências da Educação",
                        "Artes",
                        "Humanidades",
                        "Ciências Sociais e do Comportamento",
                        "Informação e Jornalismo",
                        "Ciências Empresariais",
                        "Direito",
                        "Ciências da Vida",
                        "Ciências Físicas",
                        "Matemática e Estatística",
                        "Informática",
                        "Engenharia e Técnicas Afins",
                        "Indústrias Transformadoras",
                        "Arquitetura e Construção",
                        "Agricultura, Silvicultura e Pescas",
                        "Ciências Veterinárias",
                        "Saúde",
                        "Serviços Sociais",
                        "Serviços Pessoais",
                        "Serviços de Transporte",
                        "Proteção do Ambiente",
                        "Serviços de Segurança"
                };

            for (int i = 0; i < areas.Length; i++)
            {
                areadeespecializacao.Items.Add(areas[i]);
            }
            connection.Close();

            connection.Open();
            String mp = "SELECT COUNT(1) FROM Requirements WHERE projectId = ('" + Properties.Settings.Default.projectId + "' )";
            SqlCommand MPcommand = new SqlCommand(mp, connection);
            SqlDataReader MPreader = MPcommand.ExecuteReader();

            if (MPreader.HasRows)
            {
                edit = true;
            }
            else
            {
                edit = false;
            }

            connection.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void labelarea2parte_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int autonomy = 0;
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = "Server=tcp:eramusmanager.database.windows.net,1433;Initial Catalog=eramusmanagerdb;Persist Security Info=False;User ID=eramusmanager;Password=ispgprojSAD!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(builder.ConnectionString);

            if(autonomia.SelectedItem.ToString() == "Sim")
            {
                autonomy = 1;
            }

            if (edit)
            {
                connection.Open();
                String GNewProject8 = "UPDATE Requirements SET autonomyReq = ('" + autonomy + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') ";
                SqlCommand GNewProjectcommand8 = new SqlCommand(GNewProject8, connection);
                SqlDataReader GNewProjectreader8 = GNewProjectcommand8.ExecuteReader();
                connection.Close();

                connection.Open();
                String mp1 = "Select * FROM DetailsReq WHERE projectId = ('" + Properties.Settings.Default.projectId + "') ";
                SqlCommand MPcommand1 = new SqlCommand(mp1, connection);
                SqlDataReader MPreader1 = MPcommand1.ExecuteReader();

                while (MPreader1.Read())
                {
                    if (MPreader1.GetString(1) == "ingles")
                    {
                        String GNewProject5 = "UPDATE DetailsReq SET fieldEvaluation = ('" + linguas.SelectedItem + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') ";
                        SqlCommand GNewProjectcommand5 = new SqlCommand(GNewProject5, connection);
                        SqlDataReader GNewProjectreader5 = GNewProjectcommand5.ExecuteReader();
                    }
                    else if (MPreader1.GetString(1) == "espanhol")
                    {
                        String GNewProject6 = "UPDATE DetailsReq SET fieldEvaluation = ('" + nivelaceitavellingua.SelectedItem + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') ";
                        SqlCommand GNewProjectcommand6 = new SqlCommand(GNewProject6, connection);
                        SqlDataReader GNewProjectreader6 = GNewProjectcommand6.ExecuteReader();
                    }
                    else if (MPreader1.GetString(1) == "frances")
                    {
                        String GNewProject2 = "UPDATE DetailsReq SET fieldEvaluation = ('" + comboBox1.SelectedItem + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') ";
                        SqlCommand GNewProjectcommand2 = new SqlCommand(GNewProject2, connection);
                        SqlDataReader GNewProjectreader1 = GNewProjectcommand2.ExecuteReader();
                    }
                    else if (MPreader1.GetString(1) == "italiano")
                    {
                        String GNewProject3 = "UPDATE DetailsReq SET fieldEvaluation = ('" + comboBox2.SelectedItem + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') ";
                        SqlCommand GNewProjectcommand3 = new SqlCommand(GNewProject3, connection);
                        SqlDataReader GNewProjectreader1 = GNewProjectcommand3.ExecuteReader();
                    }
                    else if (MPreader1.GetString(1) == "alemao")
                    {
                        String GNewProject4 = "UPDATE DetailsReq SET fieldEvaluation = ('" + comboBox3.SelectedItem + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') ";
                        SqlCommand GNewProjectcommand4 = new SqlCommand(GNewProject4, connection);
                        SqlDataReader GNewProjectreader4 = GNewProjectcommand4.ExecuteReader();
                    }
                    else
                    {
                        String GNewProject7 = "UPDATE DetailsReq SET studyFieldReq =  ('" + areadeespecializacao.SelectedItem + "' )  andevaluationReq = ('" + nivelaceitavel.SelectedItem.ToString() + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') ";
                        SqlCommand GNewProjectcommand7 = new SqlCommand(GNewProject7, connection);
                        SqlDataReader GNewProjectreader7 = GNewProjectcommand7.ExecuteReader();
                    }

                }
            }
            else
            {
                connection.Open();
                String GNewProject10 = "INSERT INTO Requirements VALUES('" + Properties.Settings.Default.projectId + "', '" + autonomy + "' )  ";
                SqlCommand GNewProjectcommand10 = new SqlCommand(GNewProject10, connection);
                SqlDataReader GNewProjectreader10 = GNewProjectcommand10.ExecuteReader();

                String GNewProject11 = "INSERT INTO DetailsReq VALUES('ingles', '" + linguas.SelectedItem + "', '" + Properties.Settings.Default.projectId + "' )  ";
                SqlCommand GNewProjectcommand11 = new SqlCommand(GNewProject11, connection);
                SqlDataReader GNewProjectreader11 = GNewProjectcommand11.ExecuteReader();

                String GNewProject12 = "INSERT INTO DetailsReq VALUES('espanhol', '" + nivelaceitavellingua.SelectedItem + "', '" + Properties.Settings.Default.projectId + "' )  ";
                SqlCommand GNewProjectcommand12 = new SqlCommand(GNewProject12, connection);
                SqlDataReader GNewProjectreader12 = GNewProjectcommand12.ExecuteReader();

                String GNewProject13 = "INSERT INTO DetailsReq VALUES('frances', '" + comboBox1.SelectedItem + "', '" + Properties.Settings.Default.projectId + "' )  ";
                SqlCommand GNewProjectcommand13 = new SqlCommand(GNewProject13, connection);
                SqlDataReader GNewProjectreader13 = GNewProjectcommand13.ExecuteReader();

                String GNewProject14 = "INSERT INTO DetailsReq VALUES('italiano', '" + comboBox2.SelectedItem + "', '" + Properties.Settings.Default.projectId + "' )  ";
                SqlCommand GNewProjectcommand14 = new SqlCommand(GNewProject14, connection);
                SqlDataReader GNewProjectreader14 = GNewProjectcommand14.ExecuteReader();

                String GNewProject15 = "INSERT INTO DetailsReq VALUES('alemao', '" + comboBox3.SelectedItem + "', '" + Properties.Settings.Default.projectId + "' )  ";
                SqlCommand GNewProjectcommand15 = new SqlCommand(GNewProject15, connection);
                SqlDataReader GNewProjectreader15 = GNewProjectcommand15.ExecuteReader();

                String GNewProject16 = "INSERT INTO DetailsReq VALUES('" + areadeespecializacao.SelectedItem + "', '" + nivelaceitavel.SelectedItem + "' , '" + Properties.Settings.Default.projectId + "' )  ";
                SqlCommand GNewProjectcommand16 = new SqlCommand(GNewProject16, connection);
                SqlDataReader GNewProjectreader16 = GNewProjectcommand16.ExecuteReader();

                MessageBox.Show("Criteria successfully assigned ", "Criteria Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            connection.Close();

        }
    }
}

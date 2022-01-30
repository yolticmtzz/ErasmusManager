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
        //Boolean edit = false;
        Point ponto = new Point(125, 173);
        int count, countAs = 0;
        List<string> linguasList = new List<string>();
        List<string> fieldsList = new List<string>();
        
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
            if (linguas.SelectedIndex != -1)
            {
                count += 1;
                if (count == 1)
                {
                    labellingua2parte.Text = "" + linguas.SelectedItem + "";
                    labellingua2parte.Visible = true;
                    nivelaceitavellingua.Visible = true;
                    linguasList.Add("" + linguas.SelectedItem + "");
                    labellingua2parte.Location = ponto;
                    nivelaceitavellingua.Location = new Point(ponto.X, ponto.Y + labellingua2parte.Height);
                    ponto = new Point(ponto.X, ponto.Y + labellingua2parte.Height + nivelaceitavellingua.Height + 20);
                }
                else if (count == 2)
                {
                    label2.Text = "" + linguas.SelectedItem + "";
                    label2.Visible = true;
                    comboBox1.Visible = true;
                    linguasList.Add("" + linguas.SelectedItem + "");
                    label2.Location = ponto;
                    comboBox1.Location = new Point(ponto.X, ponto.Y + label2.Height);
                    ponto = new Point(ponto.X, ponto.Y + label2.Height + comboBox1.Height + 20);
                }
                else if (count == 3)
                {
                    label3.Text = "" + linguas.SelectedItem + "";
                    label3.Visible = true;
                    comboBox2.Visible = true;
                    linguasList.Add("" + linguas.SelectedItem + "");
                    label3.Location = ponto;
                    comboBox2.Location = new Point(ponto.X, ponto.Y + label3.Height);
                    ponto = new Point(ponto.X, ponto.Y + label3.Height + comboBox2.Height + 20);
                }
                else
                {
                    countAs = 0;
                }
            }
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


            

            for (int i = 0; i < 11; i++)
            {
                comboBox1.Items.Add(i);
                comboBox2.Items.Add(i);
                //comboBox3.Items.Add(i);
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
                        "Eletrónica",
                        "Mecânica",
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

            /*if (MPreader.HasRows)
            {
                edit = true;
            }
            else
            {
                edit = false;
            }*/

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
            
            

            //if (edit)
            //{
            /* Update aos critérios cuidado com dados nulos vindos das comboBox
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

               }*/
            //}
            //else
            //{
                connection.Open();
                String GNewProject10 = "INSERT INTO Requirements VALUES('" + Properties.Settings.Default.projectId + "', '" + autonomy + "' )  ";
                SqlCommand GNewProjectcommand10 = new SqlCommand(GNewProject10, connection);
                SqlDataReader GNewProjectreader10 = GNewProjectcommand10.ExecuteReader();
                connection.Close();

            
                

            if (nivelaceitavellingua.SelectedIndex == -1)
            {
                if(linguasList.Count >= 1)
                {
                    connection.Open();
                    String GNewProject12 = "INSERT INTO DetailsReq VALUES('" + linguasList[0] + "', '" + 0 + "', 'LN','" + Properties.Settings.Default.projectId + "' )  ";
                    SqlCommand GNewProjectcommand12 = new SqlCommand(GNewProject12, connection);
                    SqlDataReader GNewProjectreader12 = GNewProjectcommand12.ExecuteReader();
                    connection.Close();
                }
                else
                {
                    connection.Open();
                    String GNewProject12 = "INSERT INTO DetailsReq VALUES('SM', '" + 0 + "', 'LN','" + Properties.Settings.Default.projectId + "' )  ";
                    SqlCommand GNewProjectcommand12 = new SqlCommand(GNewProject12, connection);
                    SqlDataReader GNewProjectreader12 = GNewProjectcommand12.ExecuteReader();
                    connection.Close();
                }
            }
            else
            {
                if (linguasList.Count >= 1)
                {
                    connection.Open();
                    String GNewProject12 = "INSERT INTO DetailsReq VALUES('" + linguasList[0] + "', '" + nivelaceitavellingua.SelectedItem + "', 'LN','" + Properties.Settings.Default.projectId + "' )  ";
                    SqlCommand GNewProjectcommand12 = new SqlCommand(GNewProject12, connection);
                    SqlDataReader GNewProjectreader12 = GNewProjectcommand12.ExecuteReader();
                    connection.Close();
                }
                else
                {
                    connection.Open();
                    String GNewProject12 = "INSERT INTO DetailsReq VALUES('SM', '" + 0 + "', 'LN','" + Properties.Settings.Default.projectId + "' )  ";
                    SqlCommand GNewProjectcommand12 = new SqlCommand(GNewProject12, connection);
                    SqlDataReader GNewProjectreader12 = GNewProjectcommand12.ExecuteReader();
                    connection.Close();
                }
            }
                

            if (comboBox1.SelectedIndex == -1)
            {
                if (linguasList.Count >= 2)
                {
                    connection.Open();
                    String GNewProject13 = "INSERT INTO DetailsReq VALUES('" + linguasList[1] + "', '" + 0 + "', 'LN','" + Properties.Settings.Default.projectId + "' )  ";
                    SqlCommand GNewProjectcommand13 = new SqlCommand(GNewProject13, connection);
                    SqlDataReader GNewProjectreader13 = GNewProjectcommand13.ExecuteReader();
                    connection.Close();
                }
                else
                {
                    connection.Open();
                    String GNewProject13 = "INSERT INTO DetailsReq VALUES('SM', '" + 0 + "', 'LN','" + Properties.Settings.Default.projectId + "' )  ";
                    SqlCommand GNewProjectcommand13 = new SqlCommand(GNewProject13, connection);
                    SqlDataReader GNewProjectreader13 = GNewProjectcommand13.ExecuteReader();
                    connection.Close();
                }
            }
            else
            {
                if (linguasList.Count >= 2)
                {
                    connection.Open();
                    String GNewProject13 = "INSERT INTO DetailsReq VALUES('" + linguasList[1] + "', '" + comboBox1.SelectedItem + "', 'LN','" + Properties.Settings.Default.projectId + "' )  ";
                    SqlCommand GNewProjectcommand13 = new SqlCommand(GNewProject13, connection);
                    SqlDataReader GNewProjectreader13 = GNewProjectcommand13.ExecuteReader();
                    connection.Close();
                } else
                {
                    connection.Open();
                    String GNewProject13 = "INSERT INTO DetailsReq VALUES('SM', '" + comboBox1.SelectedItem + "', 'LN','" + Properties.Settings.Default.projectId + "' )  ";
                    SqlCommand GNewProjectcommand13 = new SqlCommand(GNewProject13, connection);
                    SqlDataReader GNewProjectreader13 = GNewProjectcommand13.ExecuteReader();
                    connection.Close();
                }
            }
                
            if (comboBox2.SelectedIndex == -1)
            {
                if (linguasList.Count == 3)
                {
                    connection.Open();
                    String GNewProject14 = "INSERT INTO DetailsReq VALUES('" + linguasList[2] + "', '" + 0 + "', 'LN','" + Properties.Settings.Default.projectId + "' )  ";
                    SqlCommand GNewProjectcommand14 = new SqlCommand(GNewProject14, connection);
                    SqlDataReader GNewProjectreader14 = GNewProjectcommand14.ExecuteReader();
                    connection.Close();
                } else
                {
                    connection.Open();
                    String GNewProject14 = "INSERT INTO DetailsReq VALUES('SM', '" + 0 + "', 'LN','" + Properties.Settings.Default.projectId + "' )  ";
                    SqlCommand GNewProjectcommand14 = new SqlCommand(GNewProject14, connection);
                    SqlDataReader GNewProjectreader14 = GNewProjectcommand14.ExecuteReader();
                    connection.Close();
                }
            }
            else
            {
                if (linguasList.Count == 3)
                {
                    connection.Open();
                    String GNewProject14 = "INSERT INTO DetailsReq VALUES('" + linguasList[2] + "', '" + comboBox2.SelectedItem + "', 'LN','" + Properties.Settings.Default.projectId + "' )  ";
                    SqlCommand GNewProjectcommand14 = new SqlCommand(GNewProject14, connection);
                    SqlDataReader GNewProjectreader14 = GNewProjectcommand14.ExecuteReader();
                    connection.Close();
                }
                else
                {
                    connection.Open();
                    String GNewProject14 = "INSERT INTO DetailsReq VALUES('SM', '" + comboBox2.SelectedItem + "', 'LN','" + Properties.Settings.Default.projectId + "' )  ";
                    SqlCommand GNewProjectcommand14 = new SqlCommand(GNewProject14, connection);
                    SqlDataReader GNewProjectreader14 = GNewProjectcommand14.ExecuteReader();
                    connection.Close();
                }
            }

            if (nivelaceitavel.SelectedIndex == -1)
            {
                if (fieldsList.Count >= 1)
                {
                    connection.Open();
                    String GNewProject12 = "INSERT INTO DetailsReq VALUES('" + fieldsList[0] + "', '" + 0 + "', 'AS','" + Properties.Settings.Default.projectId + "' )  ";
                    SqlCommand GNewProjectcommand12 = new SqlCommand(GNewProject12, connection);
                    SqlDataReader GNewProjectreader12 = GNewProjectcommand12.ExecuteReader();
                    connection.Close();
                }
                else
                {
                    connection.Open();
                    String GNewProject12 = "INSERT INTO DetailsReq VALUES('SM', '" + 0 + "', 'AS','" + Properties.Settings.Default.projectId + "' )  ";
                    SqlCommand GNewProjectcommand12 = new SqlCommand(GNewProject12, connection);
                    SqlDataReader GNewProjectreader12 = GNewProjectcommand12.ExecuteReader();
                    connection.Close();
                }
            }
            else
            {
                if (fieldsList.Count >= 1)
                {
                    connection.Open();
                    String GNewProject12 = "INSERT INTO DetailsReq VALUES('" + fieldsList[0] + "', '" + nivelaceitavel.SelectedIndex + "', 'AS','" + Properties.Settings.Default.projectId + "' )  ";
                    SqlCommand GNewProjectcommand12 = new SqlCommand(GNewProject12, connection);
                    SqlDataReader GNewProjectreader12 = GNewProjectcommand12.ExecuteReader();
                    connection.Close();
                }
                else
                {
                    connection.Open();
                    String GNewProject12 = "INSERT INTO DetailsReq VALUES('SM', '" + 0 + "', 'AS','" + Properties.Settings.Default.projectId + "' )  ";
                    SqlCommand GNewProjectcommand12 = new SqlCommand(GNewProject12, connection);
                    SqlDataReader GNewProjectreader12 = GNewProjectcommand12.ExecuteReader();
                    connection.Close();
                }
            }


            if (comboBox3.SelectedIndex == -1)
            {
                if (fieldsList.Count >= 2)
                {
                    connection.Open();
                    String GNewProject13 = "INSERT INTO DetailsReq VALUES('" + fieldsList[1] + "', '" + 0 + "', 'AS','" + Properties.Settings.Default.projectId + "' )  ";
                    SqlCommand GNewProjectcommand13 = new SqlCommand(GNewProject13, connection);
                    SqlDataReader GNewProjectreader13 = GNewProjectcommand13.ExecuteReader();
                    connection.Close();
                }
                else
                {
                    connection.Open();
                    String GNewProject13 = "INSERT INTO DetailsReq VALUES('SM', '" + 0 + "', 'AS','" + Properties.Settings.Default.projectId + "' )  ";
                    SqlCommand GNewProjectcommand13 = new SqlCommand(GNewProject13, connection);
                    SqlDataReader GNewProjectreader13 = GNewProjectcommand13.ExecuteReader();
                    connection.Close();
                }
            }
            else
            {
                if (fieldsList.Count >= 2)
                {
                    connection.Open();
                    String GNewProject13 = "INSERT INTO DetailsReq VALUES('" + fieldsList[1] + "', '" + comboBox3.SelectedIndex + "', 'AS','" + Properties.Settings.Default.projectId + "' )  ";
                    SqlCommand GNewProjectcommand13 = new SqlCommand(GNewProject13, connection);
                    SqlDataReader GNewProjectreader13 = GNewProjectcommand13.ExecuteReader();
                    connection.Close();
                }
                else
                {
                    connection.Open();
                    String GNewProject13 = "INSERT INTO DetailsReq VALUES('SM', '" + comboBox3.SelectedIndex + "', 'AS','" + Properties.Settings.Default.projectId + "' )  ";
                    SqlCommand GNewProjectcommand13 = new SqlCommand(GNewProject13, connection);
                    SqlDataReader GNewProjectreader13 = GNewProjectcommand13.ExecuteReader();
                    connection.Close();
                }
            }

            if (comboBox4.SelectedIndex == -1)
            {
                if (fieldsList.Count == 3)
                {
                    connection.Open();
                    String GNewProject14 = "INSERT INTO DetailsReq VALUES('" + fieldsList[2] + "', '" + 0 + "', 'AS','" + Properties.Settings.Default.projectId + "' )  ";
                    SqlCommand GNewProjectcommand14 = new SqlCommand(GNewProject14, connection);
                    SqlDataReader GNewProjectreader14 = GNewProjectcommand14.ExecuteReader();
                    connection.Close();
                }
                else
                {
                    connection.Open();
                    String GNewProject14 = "INSERT INTO DetailsReq VALUES('SM', '" + 0 + "', 'AS','" + Properties.Settings.Default.projectId + "' )  ";
                    SqlCommand GNewProjectcommand14 = new SqlCommand(GNewProject14, connection);
                    SqlDataReader GNewProjectreader14 = GNewProjectcommand14.ExecuteReader();
                    connection.Close();
                }
            }
            else
            {
                if (fieldsList.Count == 3)
                {
                    connection.Open();
                    String GNewProject14 = "INSERT INTO DetailsReq VALUES('" + fieldsList[2] + "', '" + comboBox4.SelectedIndex + "', 'AS','" + Properties.Settings.Default.projectId + "' )  ";
                    SqlCommand GNewProjectcommand14 = new SqlCommand(GNewProject14, connection);
                    SqlDataReader GNewProjectreader14 = GNewProjectcommand14.ExecuteReader();
                    connection.Close();
                }
                else
                {
                    connection.Open();
                    String GNewProject14 = "INSERT INTO DetailsReq VALUES('SM', '" + comboBox4.SelectedIndex + "', 'AS','" + Properties.Settings.Default.projectId + "' )  ";
                    SqlCommand GNewProjectcommand14 = new SqlCommand(GNewProject14, connection);
                    SqlDataReader GNewProjectreader14 = GNewProjectcommand14.ExecuteReader();
                    connection.Close();
                }
            }

            /*if (areadeespecializacao.SelectedIndex == -1 || nivelaceitavel.SelectedIndex == -1)
            {
                connection.Open();
                String GNewProject16 = "INSERT INTO DetailsReq VALUES('SA', '" + 0 + "' , 'AS','" + Properties.Settings.Default.projectId + "' )  ";
                SqlCommand GNewProjectcommand16 = new SqlCommand(GNewProject16, connection);
                SqlDataReader GNewProjectreader16 = GNewProjectcommand16.ExecuteReader();
                connection.Close();
            }
            else
            {
                connection.Open();
                String GNewProject16 = "INSERT INTO DetailsReq VALUES('" + areadeespecializacao.SelectedItem + "', '" + nivelaceitavel.SelectedItem + "' , 'AS','" + Properties.Settings.Default.projectId + "' )  ";
                SqlCommand GNewProjectcommand16 = new SqlCommand(GNewProject16, connection);
                SqlDataReader GNewProjectreader16 = GNewProjectcommand16.ExecuteReader();
                connection.Close();
            }*/
                

                MessageBox.Show("Criteria successfully assigned ", "Criteria Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}

            //connection.Close();

        }

        private void areadeespecializacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (areadeespecializacao.SelectedIndex != -1)
            {
                countAs += 1;
                if (countAs == 1)
                {
                    labelarea2parte.Text = "" + areadeespecializacao.SelectedItem + "";
                    labelarea2parte.Visible = true;
                    nivelaceitavel.Visible = true;
                    fieldsList.Add("" + areadeespecializacao.SelectedItem + "");
                    labelarea2parte.Location = ponto;
                    nivelaceitavel.Location = new Point(ponto.X, ponto.Y + labelarea2parte.Height);
                    ponto = new Point(ponto.X, ponto.Y + labelarea2parte.Height + nivelaceitavel.Height + 20);
                }
                else if (countAs == 2)
                {
                    label4.Text = "" + areadeespecializacao.SelectedItem + "";
                    label4.Visible = true;
                    comboBox3.Visible = true;
                    fieldsList.Add("" + areadeespecializacao.SelectedItem + "");
                    label4.Location = ponto;
                    comboBox3.Location = new Point(ponto.X, ponto.Y + label4.Height);
                    ponto = new Point(ponto.X, ponto.Y + label4.Height + comboBox3.Height + 20);
                }
                else if (countAs == 3)
                {
                    label5.Text = "" + areadeespecializacao.SelectedItem + "";
                    label5.Visible = true;
                    comboBox4.Visible = true;
                    fieldsList.Add("" + areadeespecializacao.SelectedItem + "");
                    label5.Location = ponto;
                    comboBox4.Location = new Point(ponto.X, ponto.Y + label5.Height);
                    ponto = new Point(ponto.X, ponto.Y + label5.Height + comboBox4.Height + 20);
                }
            }
            else
            {
                countAs = 0;
            }
        }
    }
}

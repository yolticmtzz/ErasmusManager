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
    public partial class CriteriosDesejEdit : Form
    {
        //Boolean edit = false;
        List<string> linguasList = new List<string>();
        List<string> oldList = new List<string>();
        int count = 0;
        public CriteriosDesejEdit()
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
                    linguasList[0] = "" + linguas.SelectedItem + "";
                }
                else if (count == 2)
                {
                    label2.Text = "" + linguas.SelectedItem + "";
                    label2.Visible = true;
                    comboBox1.Visible = true;
                    linguasList[1] = "" + linguas.SelectedItem + "";
                }
                else if (count == 3)
                {
                    label3.Text = "" + linguas.SelectedItem + "";
                    label3.Visible = true;
                    comboBox2.Visible = true;
                    linguasList[2] = "" + linguas.SelectedItem + "";
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
            String GNewProject16 = "SELECT studyFieldReq FROM DetailsReq WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND type = 'LN' ";
            SqlCommand GNewProjectcommand16 = new SqlCommand(GNewProject16, connection);
            SqlDataReader GNewProjectreader16 = GNewProjectcommand16.ExecuteReader();

            while (GNewProjectreader16.Read())
            {
                linguasList.Add(GNewProjectreader16.GetString(0));
                oldList.Add(GNewProjectreader16.GetString(0));
            }

            connection.Close();

            debugPID2.Text = Properties.Settings.Default.projectId;

            autonomia.Items.Add("Sim");
            autonomia.Items.Add("Não");

            for (int i = 0; i < 11; i++)
            {
                comboBox1.Items.Add(i);
                comboBox2.Items.Add(i);
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

            /*if (MPreader.HasRows)
            {
                edit = true;
            }
            else
            {
                edit = false;
            }*/

            connection.Close();

            if(linguasList[0] != "SM")
            {
                labellingua2parte.Text = linguasList[0];
                labellingua2parte.Visible = true;
                nivelaceitavellingua.Visible = true;
            }

            if(linguasList[1] != "Sm")
            {
                label2.Text = linguasList[1];
                label2.Visible = true;
                comboBox1.Visible = true;
            }
            if(linguasList[2] != "SM")
            {
                label3.Text = linguasList[2];
                label3.Visible = true;
                comboBox2.Visible = true;
            }
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
            int areaId = 0;

            List<string> fieldList = new List<string>();

            if (autonomia.SelectedIndex == -1){
                autonomy = 0;
            } else
            {
                if (autonomia.SelectedItem.ToString() == "Sim")
                {
                    autonomy = 1;
                }
            }


            //if (edit)
            //{
            // Update aos critérios cuidado com dados nulos vindos das comboBox
               connection.Open();
               String GNewProject8 = "UPDATE Requirements SET autonomyReq = ('" + autonomy + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') ";
               SqlCommand GNewProjectcommand8 = new SqlCommand(GNewProject8, connection);
               SqlDataReader GNewProjectreader8 = GNewProjectcommand8.ExecuteReader();
               connection.Close();

                /*connection.Open();
                String GNewProject48 = "SELECT detailsId FROM DetailsReq WHERE detailsId = (SELECT max(detailsId) FROM DetailsReq WHERE projectId = ('" + Properties.Settings.Default.projectId + "')) ";
                SqlCommand GNewProjectcommand48 = new SqlCommand(GNewProject48, connection);
                SqlDataReader GNewProjectreader48 = GNewProjectcommand48.ExecuteReader();
                areaId = GNewProjectreader48["detailsId"].ToString();
                connection.Close();*/

                connection.Open();
                String mp1 = "SELECT * FROM DetailsReq WHERE detailsId = (SELECT max(detailsId) FROM DetailsReq WHERE projectId = ('" + Properties.Settings.Default.projectId + "')) ";
                SqlCommand MPcommand1 = new SqlCommand(mp1, connection);
                SqlDataReader MPreader1 = MPcommand1.ExecuteReader();
                while (MPreader1.Read())
                {
                    areaId = MPreader1.GetInt32(0);
                }
                connection.Close();

            if (nivelaceitavellingua.SelectedIndex == -1)
            {
                if (linguasList.Count >= 1)
                {
                    connection.Open();
                    String GNewProject5 = "UPDATE DetailsReq SET studyFieldReq = ('" + linguasList[0] + "'), fieldEvaluation = ('" + 0 + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND studyFieldReq = ('"+ oldList[0] +"') ";
                    SqlCommand GNewProjectcommand5 = new SqlCommand(GNewProject5, connection);
                    SqlDataReader GNewProjectreader5 = GNewProjectcommand5.ExecuteReader();
                    connection.Close();
                }
                else
                {
                    connection.Open();
                    String GNewProject5 = "UPDATE DetailsReq SET studyFieldReq = ('SM'), fieldEvaluation = ('" + 0 + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND studyFieldReq = ('" + oldList[0] + "') ";
                    SqlCommand GNewProjectcommand5 = new SqlCommand(GNewProject5, connection);
                    SqlDataReader GNewProjectreader5 = GNewProjectcommand5.ExecuteReader();
                    connection.Close();
                }
            }
            else
            {
                if (linguasList.Count >= 1)
                {
                    connection.Open();
                    String GNewProject5 = "UPDATE DetailsReq SET studyFieldReq = ('" + linguasList[0] + "'), fieldEvaluation = ('" + nivelaceitavellingua.SelectedItem + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND studyFieldReq = ('" + oldList[0] + "')  ";
                    SqlCommand GNewProjectcommand5 = new SqlCommand(GNewProject5, connection);
                    SqlDataReader GNewProjectreader5 = GNewProjectcommand5.ExecuteReader();
                    connection.Close();
                }
                else
                {
                    connection.Open();
                    String GNewProject5 = "UPDATE DetailsReq SET studyFieldReq = ('SM'), fieldEvaluation = ('" + 0 + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND studyFieldReq = ('" + oldList[0] + "')  ";
                    SqlCommand GNewProjectcommand5 = new SqlCommand(GNewProject5, connection);
                    SqlDataReader GNewProjectreader5 = GNewProjectcommand5.ExecuteReader();
                    connection.Close();
                }
            }


            if (comboBox1.SelectedIndex == -1)
            {
                if (linguasList.Count >= 2)
                {
                    connection.Open();
                    String GNewProject13 = "UPDATE DetailsReq SET studyFieldReq = ('" + linguasList[1] + "'), fieldEvaluation = ('" + 0 + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND studyFieldReq = ('" + oldList[1] + "') ";
                    SqlCommand GNewProjectcommand13 = new SqlCommand(GNewProject13, connection);
                    SqlDataReader GNewProjectreader13 = GNewProjectcommand13.ExecuteReader();
                    connection.Close();
                }
                else
                {
                    connection.Open();
                    String GNewProject13 = "UPDATE DetailsReq SET studyFieldReq = ('SM'), fieldEvaluation = ('" + 0 + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND studyFieldReq = ('" + oldList[1] + "')";
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
                    String GNewProject13 = "UPDATE DetailsReq SET studyFieldReq = ('" + linguasList[1] + "'), fieldEvaluation = ('" + comboBox1.SelectedItem + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND studyFieldReq = ('" + oldList[1] + "')  ";
                    SqlCommand GNewProjectcommand13 = new SqlCommand(GNewProject13, connection);
                    SqlDataReader GNewProjectreader13 = GNewProjectcommand13.ExecuteReader();
                    connection.Close();
                }
                else
                {
                    connection.Open();
                    String GNewProject13 = "UPDATE DetailsReq SET studyFieldReq = ('SM'), fieldEvaluation = ('" + 0 + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND studyFieldReq = ('" + oldList[1] + "')  ";
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
                    String GNewProject14 = "UPDATE DetailsReq SET studyFieldReq = ('" + linguasList[2] + "'), fieldEvaluation = ('" + 0 + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND studyFieldReq = ('" + oldList[2] + "') ";
                    SqlCommand GNewProjectcommand14 = new SqlCommand(GNewProject14, connection);
                    SqlDataReader GNewProjectreader14 = GNewProjectcommand14.ExecuteReader();
                    connection.Close();
                }
                else
                {
                    connection.Open();
                    String GNewProject14 = "UPDATE DetailsReq SET studyFieldReq = ('SM'), fieldEvaluation = ('" + 0 + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND studyFieldReq = ('" + oldList[2] + "')  ";
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
                    String GNewProject14 = "UPDATE DetailsReq SET studyFieldReq = ('" + linguasList[2] + "'), fieldEvaluation = ('" + comboBox2.SelectedItem + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND studyFieldReq = ('" + oldList[2] + "')  ";
                    SqlCommand GNewProjectcommand14 = new SqlCommand(GNewProject14, connection);
                    SqlDataReader GNewProjectreader14 = GNewProjectcommand14.ExecuteReader();
                    connection.Close();
                }
                else
                {
                    connection.Open();
                    String GNewProject14 = "UPDATE DetailsReq SET studyFieldReq = ('SM'), fieldEvaluation = ('" + 0 + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND studyFieldReq = ('" + oldList[2] + "')  ";
                    SqlCommand GNewProjectcommand14 = new SqlCommand(GNewProject14, connection);
                    SqlDataReader GNewProjectreader14 = GNewProjectcommand14.ExecuteReader();
                    connection.Close();
                }
            }



            if (areadeespecializacao.SelectedIndex == -1 || nivelaceitavel.SelectedIndex == -1)
            {
                connection.Open();
                String GNewProject7 = "UPDATE DetailsReq SET studyFieldReq =  ('SA' ), fieldEvaluation = ('" + 0 + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND type = ('AS')";
                SqlCommand GNewProjectcommand7 = new SqlCommand(GNewProject7, connection);
                SqlDataReader GNewProjectreader7 = GNewProjectcommand7.ExecuteReader();
                connection.Close();
            }
            else
            {
                connection.Open();
                String GNewProject7 = "UPDATE DetailsReq SET studyFieldReq =  ('" + areadeespecializacao.SelectedItem + "' ), fieldEvaluation = ('" + nivelaceitavel.SelectedItem.ToString() + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND type = ('AS')";
                SqlCommand GNewProjectcommand7 = new SqlCommand(GNewProject7, connection);
                SqlDataReader GNewProjectreader7 = GNewProjectcommand7.ExecuteReader();
                connection.Close();
            }

            MessageBox.Show("Criteria successfully updated ", "Criteria Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
                
            //}
            //else
            //{
            /* connection.Open();
             String GNewProject10 = "INSERT INTO Requirements VALUES('" + Properties.Settings.Default.projectId + "', '" + autonomy + "' )  ";
             SqlCommand GNewProjectcommand10 = new SqlCommand(GNewProject10, connection);
             SqlDataReader GNewProjectreader10 = GNewProjectcommand10.ExecuteReader();
             connection.Close();

         if(linguas.SelectedIndex == -1)
         {
             connection.Open();
             String GNewProject11 = "INSERT INTO DetailsReq VALUES('ingles', '" + 0 + "', '" + Properties.Settings.Default.projectId + "' )  ";
             SqlCommand GNewProjectcommand11 = new SqlCommand(GNewProject11, connection);
             SqlDataReader GNewProjectreader11 = GNewProjectcommand11.ExecuteReader();
             connection.Close();
         } else
         {
             connection.Open();
             String GNewProject11 = "INSERT INTO DetailsReq VALUES('ingles', '" + linguas.SelectedItem + "', '" + Properties.Settings.Default.projectId + "' )  ";
             SqlCommand GNewProjectcommand11 = new SqlCommand(GNewProject11, connection);
             SqlDataReader GNewProjectreader11 = GNewProjectcommand11.ExecuteReader();
             connection.Close();
         }


         if (nivelaceitavellingua.SelectedIndex == -1)
         {
             connection.Open();
             String GNewProject12 = "INSERT INTO DetailsReq VALUES('espanhol', '" + 0 + "', '" + Properties.Settings.Default.projectId + "' )  ";
             SqlCommand GNewProjectcommand12 = new SqlCommand(GNewProject12, connection);
             SqlDataReader GNewProjectreader12 = GNewProjectcommand12.ExecuteReader();
             connection.Close();
         }
         else
         {
             connection.Open();
             String GNewProject12 = "INSERT INTO DetailsReq VALUES('espanhol', '" + nivelaceitavellingua.SelectedItem + "', '" + Properties.Settings.Default.projectId + "' )  ";
             SqlCommand GNewProjectcommand12 = new SqlCommand(GNewProject12, connection);
             SqlDataReader GNewProjectreader12 = GNewProjectcommand12.ExecuteReader();
             connection.Close();
         }


         if (comboBox1.SelectedIndex == -1)
         {
             connection.Open();
             String GNewProject13 = "INSERT INTO DetailsReq VALUES('frances', '" + 0 + "', '" + Properties.Settings.Default.projectId + "' )  ";
             SqlCommand GNewProjectcommand13 = new SqlCommand(GNewProject13, connection);
             SqlDataReader GNewProjectreader13 = GNewProjectcommand13.ExecuteReader();
             connection.Close();
         }
         else
         {
             connection.Open();
             String GNewProject13 = "INSERT INTO DetailsReq VALUES('frances', '" + comboBox1.SelectedItem + "', '" + Properties.Settings.Default.projectId + "' )  ";
             SqlCommand GNewProjectcommand13 = new SqlCommand(GNewProject13, connection);
             SqlDataReader GNewProjectreader13 = GNewProjectcommand13.ExecuteReader();
             connection.Close();
         }

         if (comboBox2.SelectedIndex == -1)
         {
             connection.Open();
             String GNewProject14 = "INSERT INTO DetailsReq VALUES('italiano', '" + 0 + "', '" + Properties.Settings.Default.projectId + "' )  ";
             SqlCommand GNewProjectcommand14 = new SqlCommand(GNewProject14, connection);
             SqlDataReader GNewProjectreader14 = GNewProjectcommand14.ExecuteReader();
             connection.Close();
         }
         else
         {
             connection.Open();
             String GNewProject14 = "INSERT INTO DetailsReq VALUES('italiano', '" + comboBox2.SelectedItem + "', '" + Properties.Settings.Default.projectId + "' )  ";
             SqlCommand GNewProjectcommand14 = new SqlCommand(GNewProject14, connection);
             SqlDataReader GNewProjectreader14 = GNewProjectcommand14.ExecuteReader();
             connection.Close();
         }

         if (comboBox3.SelectedIndex == -1)
         {
             connection.Open();
             String GNewProject15 = "INSERT INTO DetailsReq VALUES('alemao', '" + 0 + "', '" + Properties.Settings.Default.projectId + "' )  ";
             SqlCommand GNewProjectcommand15 = new SqlCommand(GNewProject15, connection);
             SqlDataReader GNewProjectreader15 = GNewProjectcommand15.ExecuteReader();
             connection.Close();
         }
         else
         {
             connection.Open();
             String GNewProject15 = "INSERT INTO DetailsReq VALUES('alemao', '" + comboBox3.SelectedItem + "', '" + Properties.Settings.Default.projectId + "' )  ";
             SqlCommand GNewProjectcommand15 = new SqlCommand(GNewProject15, connection);
             SqlDataReader GNewProjectreader15 = GNewProjectcommand15.ExecuteReader();
             connection.Close();
         }

         if (areadeespecializacao.SelectedIndex == -1 || nivelaceitavel.SelectedIndex == -1)
         {
             connection.Open();
             String GNewProject16 = "INSERT INTO DetailsReq VALUES('Sem área de especialização', '" + 0 + "' , '" + Properties.Settings.Default.projectId + "' )  ";
             SqlCommand GNewProjectcommand16 = new SqlCommand(GNewProject16, connection);
             SqlDataReader GNewProjectreader16 = GNewProjectcommand16.ExecuteReader();
             connection.Close();
         }
         else
         {
             connection.Open();
             String GNewProject16 = "INSERT INTO DetailsReq VALUES('" + areadeespecializacao.SelectedItem + "', '" + nivelaceitavel.SelectedItem + "' , '" + Properties.Settings.Default.projectId + "' )  ";
             SqlCommand GNewProjectcommand16 = new SqlCommand(GNewProject16, connection);
             SqlDataReader GNewProjectreader16 = GNewProjectcommand16.ExecuteReader();
             connection.Close();
         }


             MessageBox.Show("Criteria successfully assigned ", "Criteria Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

         //}*/

            //connection.Close();

        }
    }
}

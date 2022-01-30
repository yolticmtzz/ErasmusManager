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
        Point ponto = new Point(134, 209);
        //Point ponto2 = new Point(134, 209);
        List<string> linguasList = new List<string>();
        List<string> oldList = new List<string>();
        List<string> fieldsList = new List<string>();
        List<string> fieldOldList = new List<string>();
        int count, countAs = 0;
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
                    button1.Visible = true;
                    linguasList[0] = "" + linguas.SelectedItem + "";
                    
                    /*if(ponto2.Y < ponto.Y)
                    {
                        ponto = new Point(ponto.X, ponto.Y + 40);
                        labellingua2parte.Location = ponto;
                        nivelaceitavellingua.Location = new Point(ponto.X, ponto.Y + labellingua2parte.Height);
                        ponto = new Point(ponto.X, ponto.Y + labellingua2parte.Height + nivelaceitavellingua.Height + 20);
                    } else
                    {*/
                    labellingua2parte.Location = ponto;
                    nivelaceitavellingua.Location = new Point(ponto.X, ponto.Y + labellingua2parte.Height);
                    button1.Location = new Point(button1.Location.X, ponto.Y + labellingua2parte.Height);
                    ponto = new Point(ponto.X, ponto.Y + labellingua2parte.Height + nivelaceitavellingua.Height + 20);
                    //}
                }
                else if (count == 2)
                {
                    label2.Text = "" + linguas.SelectedItem + "";
                    label2.Visible = true;
                    comboBox1.Visible = true;
                    button3.Visible = true;
                    linguasList[1] = "" + linguas.SelectedItem + "";
                    /*if (ponto2.Y < ponto.Y)
                    {*/
                        ponto = new Point(ponto.X, ponto.Y + 40);
                        label2.Location = ponto;
                        comboBox1.Location = new Point(ponto.X, ponto.Y + label2.Height);
                        ponto = new Point(ponto.X, ponto.Y + label2.Height + comboBox1.Height + 20);
                    /*}
                    else
                    {*/
                    label2.Location = ponto;
                    comboBox1.Location = new Point(ponto.X, ponto.Y + label2.Height);
                    button3.Location = new Point(button3.Location.X, ponto.Y + label2.Height);
                    ponto = new Point(ponto.X, ponto.Y + label2.Height + comboBox1.Height + 20);
                    //}

                }
                else if (count == 3)
                {
                    label3.Text = "" + linguas.SelectedItem + "";
                    label3.Visible = true;
                    comboBox2.Visible = true;
                    button4.Visible = true;
                    linguasList[2] = "" + linguas.SelectedItem + "";
                    /*if (ponto2.Y < ponto.Y)
                    {*/
                        ponto = new Point(ponto.X, ponto.Y + 40);
                        label3.Location = ponto;
                        comboBox2.Location = new Point(ponto.X, ponto.Y + label3.Height);
                        ponto = new Point(ponto.X, ponto.Y + label3.Height + comboBox2.Height + 20);
                    /*}
                    else
                    {*/
                    label3.Location = ponto;
                    comboBox2.Location = new Point(ponto.X, ponto.Y + label3.Height);
                    button4.Location = new Point(button4.Location.X, ponto.Y + label3.Height);
                    ponto = new Point(ponto.X, ponto.Y + label3.Height + comboBox2.Height + 20);
                    //}
                }
                else
                {
                    //countAs = 0;
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

            connection.Open();
            String GNewProject17 = "SELECT studyFieldReq FROM DetailsReq WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND type = 'AS' ";
            SqlCommand GNewProjectcommand17 = new SqlCommand(GNewProject17, connection);
            SqlDataReader GNewProjectreader17 = GNewProjectcommand17.ExecuteReader();

            while (GNewProjectreader17.Read())
            {
                fieldsList.Add(GNewProjectreader17.GetString(0));
                fieldOldList.Add(GNewProjectreader17.GetString(0));
            }

            connection.Close();

            debugPID2.Text = Properties.Settings.Default.projectId;

            

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
                        "Eletrónica",
                        "Mecânica",
                        "Turismo",
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
                labellingua2parte.Location = ponto;
                button1.Visible = true;
                nivelaceitavel.Location = new Point(ponto.X, ponto.Y + labellingua2parte.Height);
                button1.Location = new Point(button1.Location.X, ponto.Y + labellingua2parte.Height);
                ponto = new Point(ponto.X, ponto.Y + labellingua2parte.Height + nivelaceitavel.Height + 20);
                count = 1;
            }

            if(linguasList[1] != "SM")
            {
                label2.Text = linguasList[1];
                label2.Visible = true;
                comboBox1.Visible = true;
                label2.Location = ponto;
                button3.Visible = true;
                comboBox1.Location = new Point(ponto.X, ponto.Y + label2.Height);
                button3.Location = new Point(button3.Location.X, ponto.Y + label2.Height);
                ponto = new Point(ponto.X, ponto.Y + label2.Height + comboBox1.Height + 20);
                count = 2;
            }
            if(linguasList[2] != "SM")
            {
                label3.Text = linguasList[2];
                label3.Visible = true;
                comboBox2.Visible = true;
                label3.Location = ponto;
                button4.Visible = true;
                comboBox2.Location = new Point(ponto.X, ponto.Y + label3.Height);
                button4.Location = new Point(button4.Location.X, ponto.Y + label3.Height);
                ponto = new Point(ponto.X, ponto.Y + label3.Height + comboBox2.Height + 20);      
                count = 3;
            }

            if (fieldsList[0] != "SM")
            {
                labelarea2parte.Text = "" + fieldsList[0] + "";
                //Console.WriteLine(fieldsList[0]);
                labelarea2parte.Visible = true;
                nivelaceitavel.Visible = true;
                button5.Visible = true;
                labelarea2parte.Location = ponto;
                nivelaceitavel.Location = new Point(ponto.X, ponto.Y + labelarea2parte.Height);
                button5.Location = new Point(button5.Location.X, ponto.Y + labelarea2parte.Height);
                ponto = new Point(ponto.X, ponto.Y + labellingua2parte.Height + nivelaceitavel.Height + 20);
                //fieldsList[0] = "" + areadeespecializacao.SelectedItem + "";
                countAs = 1;
            }
            if (fieldsList[1] != "SM")
            {
                label4.Text = "" + fieldsList[1] + "";
                label4.Visible = true;
                comboBox3.Visible = true;
                button6.Visible = true;
                label4.Location = ponto;
                comboBox3.Location = new Point(ponto.X, ponto.Y + label4.Height);
                button6.Location = new Point(button6.Location.X, ponto.Y + label4.Height);
                ponto = new Point(ponto.X, ponto.Y + label4.Height + comboBox3.Height + 20);
                //fieldsList[1] = "" + areadeespecializacao.SelectedItem + "";
                countAs = 2;
            }
            if (fieldsList[2] != "SM")
            {
                label5.Text = "" + fieldsList[2] + "";
                label5.Visible = true;
                comboBox4.Visible = true;
                button7.Visible = true;
                label5.Location = ponto;
                comboBox4.Location = new Point(ponto.X, ponto.Y + label5.Height);
                button7.Location = new Point(button7.Location.X, ponto.Y + label5.Height);
                ponto = new Point(ponto.X, ponto.Y + label5.Height + comboBox4.Height + 20);
                //fieldsList[2] = "" + areadeespecializacao.SelectedItem + "";
                countAs = 3;
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

           


            //if (edit)
            //{
            // Update aos critérios cuidado com dados nulos vindos das comboBox
               /*connection.Open();
               String GNewProject8 = "UPDATE Requirements SET autonomyReq = ('" + autonomy + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') ";
               SqlCommand GNewProjectcommand8 = new SqlCommand(GNewProject8, connection);
               SqlDataReader GNewProjectreader8 = GNewProjectcommand8.ExecuteReader();
               connection.Close();*/

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
                    String GNewProject5 = "UPDATE DetailsReq SET studyFieldReq = ('" + linguasList[0] + "'), fieldEvaluation = ('" + 0 + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND studyFieldReq = ('"+ oldList[0] + "') AND type = 'LN' ";
                    SqlCommand GNewProjectcommand5 = new SqlCommand(GNewProject5, connection);
                    SqlDataReader GNewProjectreader5 = GNewProjectcommand5.ExecuteReader();
                    connection.Close();
                }
                else
                {
                    connection.Open();
                    String GNewProject5 = "UPDATE DetailsReq SET studyFieldReq = ('SM'), fieldEvaluation = ('" + 0 + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND studyFieldReq = ('" + oldList[0] + "') AND type = 'LN' ";
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
                    String GNewProject5 = "UPDATE DetailsReq SET studyFieldReq = ('" + linguasList[0] + "'), fieldEvaluation = ('" + nivelaceitavellingua.SelectedItem + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND studyFieldReq = ('" + oldList[0] + "') AND type = 'LN' ";
                    SqlCommand GNewProjectcommand5 = new SqlCommand(GNewProject5, connection);
                    SqlDataReader GNewProjectreader5 = GNewProjectcommand5.ExecuteReader();
                    connection.Close();
                }
                else
                {
                    connection.Open();
                    String GNewProject5 = "UPDATE DetailsReq SET studyFieldReq = ('SM'), fieldEvaluation = ('" + 0 + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND studyFieldReq = ('" + oldList[0] + "') AND type = 'LN' ";
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
                    String GNewProject13 = "UPDATE DetailsReq SET studyFieldReq = ('" + linguasList[1] + "'), fieldEvaluation = ('" + 0 + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND studyFieldReq = ('" + oldList[1] + "') AND type = 'LN' ";
                    SqlCommand GNewProjectcommand13 = new SqlCommand(GNewProject13, connection);
                    SqlDataReader GNewProjectreader13 = GNewProjectcommand13.ExecuteReader();
                    connection.Close();
                }
                else
                {
                    connection.Open();
                    String GNewProject13 = "UPDATE DetailsReq SET studyFieldReq = ('SM'), fieldEvaluation = ('" + 0 + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND studyFieldReq = ('" + oldList[1] + "') AND type = 'LN'";
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
                    String GNewProject13 = "UPDATE DetailsReq SET studyFieldReq = ('" + linguasList[1] + "'), fieldEvaluation = ('" + comboBox1.SelectedIndex + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND studyFieldReq = ('" + oldList[1] + "') AND type = 'LN' ";
                    SqlCommand GNewProjectcommand13 = new SqlCommand(GNewProject13, connection);
                    SqlDataReader GNewProjectreader13 = GNewProjectcommand13.ExecuteReader();
                    connection.Close();
                }
                else
                {
                    connection.Open();
                    String GNewProject13 = "UPDATE DetailsReq SET studyFieldReq = ('SM'), fieldEvaluation = ('" + 0 + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND studyFieldReq = ('" + oldList[1] + "') AND type = 'LN' ";
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
                    String GNewProject14 = "UPDATE DetailsReq SET studyFieldReq = ('" + linguasList[2] + "'), fieldEvaluation = ('" + 0 + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND studyFieldReq = ('" + oldList[2] + "') AND type = 'LN'";
                    SqlCommand GNewProjectcommand14 = new SqlCommand(GNewProject14, connection);
                    SqlDataReader GNewProjectreader14 = GNewProjectcommand14.ExecuteReader();
                    connection.Close();
                }
                else
                {
                    connection.Open();
                    String GNewProject14 = "UPDATE DetailsReq SET studyFieldReq = ('SM'), fieldEvaluation = ('" + 0 + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND studyFieldReq = ('" + oldList[2] + " AND type = 'LN'')  ";
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
                    String GNewProject14 = "UPDATE DetailsReq SET studyFieldReq = ('" + linguasList[2] + "'), fieldEvaluation = ('" + comboBox2.SelectedItem + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND studyFieldReq = ('" + oldList[2] + "') AND type = 'LN' ";
                    SqlCommand GNewProjectcommand14 = new SqlCommand(GNewProject14, connection);
                    SqlDataReader GNewProjectreader14 = GNewProjectcommand14.ExecuteReader();
                    connection.Close();
                }
                else
                {
                    connection.Open();
                    String GNewProject14 = "UPDATE DetailsReq SET studyFieldReq = ('SM'), fieldEvaluation = ('" + 0 + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND studyFieldReq = ('" + oldList[2] + "') AND type = 'LN' ";
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
                    String GNewProject55 = "UPDATE DetailsReq SET studyFieldReq = ('" + fieldsList[0] + "'), fieldEvaluation = ('" + 0 + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND studyFieldReq = ('"+ fieldOldList[0] + "') AND type = 'AS' ";
                    SqlCommand GNewProjectcommand55 = new SqlCommand(GNewProject55, connection);
                    SqlDataReader GNewProjectreader55 = GNewProjectcommand55.ExecuteReader();
                    connection.Close();
                }
                else
                {
                    connection.Open();
                    String GNewProject55 = "UPDATE DetailsReq SET studyFieldReq = ('SM'), fieldEvaluation = ('" + 0 + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND studyFieldReq = ('" + fieldOldList[0] + "') AND type = 'AS' ";
                    SqlCommand GNewProjectcommand55 = new SqlCommand(GNewProject55, connection);
                    SqlDataReader GNewProjectreader55 = GNewProjectcommand55.ExecuteReader();
                    connection.Close();
                }
            }
            else
            {
                if (fieldsList.Count >= 1)
                {
                    connection.Open();
                    String GNewProject55 = "UPDATE DetailsReq SET studyFieldReq = ('" + fieldsList[0] + "'), fieldEvaluation = ('" + nivelaceitavel.SelectedIndex + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND studyFieldReq = ('" + fieldOldList[0] + "')  AND type = 'AS'  ";
                    SqlCommand GNewProjectcommand55 = new SqlCommand(GNewProject55, connection);
                    SqlDataReader GNewProjectreader55 = GNewProjectcommand55.ExecuteReader();
                    connection.Close();
                }
                else
                {
                    connection.Open();
                    String GNewProject55 = "UPDATE DetailsReq SET studyFieldReq = ('SM'), fieldEvaluation = ('" + 0 + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND studyFieldReq = ('" + fieldOldList[0] + "')  AND type = 'AS'  ";
                    SqlCommand GNewProjectcommand55 = new SqlCommand(GNewProject55, connection);
                    SqlDataReader GNewProjectreader55 = GNewProjectcommand55.ExecuteReader();
                    connection.Close();
                }
            }


            if (comboBox3.SelectedIndex == -1)
            {
                if (fieldsList.Count >= 2)
                {
                    connection.Open();
                    String GNewProject153 = "UPDATE DetailsReq SET studyFieldReq = ('" + fieldsList[1] + "'), fieldEvaluation = ('" + 0 + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND studyFieldReq = ('" + fieldOldList[1] + "')  AND type = 'AS' ";
                    SqlCommand GNewProjectcommand153 = new SqlCommand(GNewProject153, connection);
                    SqlDataReader GNewProjectreader153 = GNewProjectcommand153.ExecuteReader();
                    connection.Close();
                }
                else
                {
                    connection.Open();
                    String GNewProject153 = "UPDATE DetailsReq SET studyFieldReq = ('SM'), fieldEvaluation = ('" + 0 + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND studyFieldReq = ('" + fieldOldList[1] + "') AND type = 'AS' ";
                    SqlCommand GNewProjectcommand153 = new SqlCommand(GNewProject153, connection);
                    SqlDataReader GNewProjectreader153 = GNewProjectcommand153.ExecuteReader();
                    connection.Close();
                }
            }
            else
            {
                if (fieldsList.Count >= 2)
                {
                    connection.Open();
                    String GNewProject153 = "UPDATE DetailsReq SET studyFieldReq = ('" + fieldsList[1] + "'), fieldEvaluation = ('" + comboBox1.SelectedIndex + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND studyFieldReq = ('" + fieldOldList[1] + "')  AND type = 'AS'  ";
                    SqlCommand GNewProjectcommand153 = new SqlCommand(GNewProject153, connection);
                    SqlDataReader GNewProjectreader153 = GNewProjectcommand153.ExecuteReader();
                    connection.Close();
                }
                else
                {
                    connection.Open();
                    String GNewProject153 = "UPDATE DetailsReq SET studyFieldReq = ('SM'), fieldEvaluation = ('" + 0 + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND studyFieldReq = ('" + fieldOldList[1] + "')  AND type = 'AS'  ";
                    SqlCommand GNewProjectcommand153 = new SqlCommand(GNewProject153, connection);
                    SqlDataReader GNewProjectreader153 = GNewProjectcommand153.ExecuteReader();
                    connection.Close();
                }
            }

            if (comboBox4.SelectedIndex == -1)
            {
                if (fieldsList.Count == 3)
                {
                    connection.Open();
                    String GNewProject154 = "UPDATE DetailsReq SET studyFieldReq = ('" + fieldsList[2] + "'), fieldEvaluation = ('" + 0 + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND studyFieldReq = ('" + fieldOldList[2] + "') AND type = 'AS'  ";
                    SqlCommand GNewProjectcommand154 = new SqlCommand(GNewProject154, connection);
                    SqlDataReader GNewProjectreader154 = GNewProjectcommand154.ExecuteReader();
                    connection.Close();
                }
                else
                {
                    connection.Open();
                    String GNewProject154 = "UPDATE DetailsReq SET studyFieldReq = ('SM'), fieldEvaluation = ('" + 0 + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND studyFieldReq = ('" + fieldOldList[2] + "')  AND type = 'AS'  ";
                    SqlCommand GNewProjectcommand154 = new SqlCommand(GNewProject154, connection);
                    SqlDataReader GNewProjectreader154 = GNewProjectcommand154.ExecuteReader();
                    connection.Close();
                }
            }
            else
            {
                if (fieldsList.Count == 3)
                {
                    connection.Open();
                    String GNewProject154 = "UPDATE DetailsReq SET studyFieldReq = ('" + fieldsList[2] + "'), fieldEvaluation = ('" + comboBox4.SelectedIndex + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND studyFieldReq = ('" + fieldOldList[2] + "')  AND type = 'AS'  ";
                    SqlCommand GNewProjectcommand154 = new SqlCommand(GNewProject154, connection);
                    SqlDataReader GNewProjectreader154 = GNewProjectcommand154.ExecuteReader();
                    connection.Close();
                }
                else
                {
                    connection.Open();
                    String GNewProject154 = "UPDATE DetailsReq SET studyFieldReq = ('SM'), fieldEvaluation = ('" + 0 + "' ) WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND studyFieldReq = ('" + fieldOldList[2] + "')  AND type = 'AS'  ";
                    SqlCommand GNewProjectcommand154 = new SqlCommand(GNewProject154, connection);
                    SqlDataReader GNewProjectreader154 = GNewProjectcommand154.ExecuteReader();
                    connection.Close();
                }
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

        private void button5_Click(object sender, EventArgs e)
        {
            fieldsList[0] = "SM";
            labelarea2parte.Visible = false;
            nivelaceitavel.Visible = false;
            button5.Visible = false;
            ponto = labelarea2parte.Location;
            countAs = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fieldsList[1] = "SM";
            label4.Visible = false;
            comboBox3.Visible = false;
            button6.Visible = false;
            ponto = label4.Location;
            countAs = 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fieldsList[2] = "SM";
            label5.Visible = false;
            comboBox4.Visible = false;
            button7.Visible = false;
            ponto = label5.Location;
            countAs = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            linguasList[0] = "SM";
            labellingua2parte.Visible = false;
            nivelaceitavellingua.Visible = false;
            button1.Visible = false;
            ponto = labellingua2parte.Location;
            count = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            linguasList[1] = "SM";
            label2.Visible = false;
            comboBox1.Visible = false;
            button3.Visible = false;
            ponto = label2.Location;
            count = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            linguasList[2] = "SM";
            label3.Visible = false;
            comboBox2.Visible = false;
            button4.Visible = false;
            ponto = label3.Location;
            count = 2;
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
                    button5.Visible = true;
                    fieldsList[0] = "" + areadeespecializacao.SelectedItem + "";
                    /*if (ponto2.Y < ponto.Y)
                    {
                        ponto = new Point(ponto.X, ponto.Y + 40);
                        labelarea2parte.Location = ponto;
                        nivelaceitavel.Location = new Point(ponto.X, ponto.Y + labelarea2parte.Height);
                        ponto = new Point(ponto.X, ponto.Y + labelarea2parte.Height + nivelaceitavel.Height + 20);
                    }
                    else
                    {*/
                    labelarea2parte.Location = ponto;
                    nivelaceitavel.Location = new Point(ponto.X, ponto.Y + labelarea2parte.Height);
                    button5.Location = new Point(button5.Location.X, ponto.Y + labelarea2parte.Height);
                    ponto = new Point(ponto.X, ponto.Y + labelarea2parte.Height + nivelaceitavel.Height + 20);
                    //}
                }
                else if (countAs == 2)
                {
                    label4.Text = "" + areadeespecializacao.SelectedItem + "";
                    label4.Visible = true;
                    comboBox3.Visible = true;
                    fieldsList[1] = "" + areadeespecializacao.SelectedItem + "";
                    button6.Visible = true;
                    /*if (ponto2.Y < ponto.Y)
                    {
                        ponto = new Point(ponto.X, ponto.Y + 40);
                        label4.Location = ponto;
                        comboBox3.Location = new Point(ponto.X, ponto.Y + label4.Height);
                        ponto = new Point(ponto.X, ponto.Y + label4.Height + comboBox3.Height + 20);
                    }
                    else
                    {*/
                    label4.Location = ponto;
                    comboBox3.Location = new Point(ponto.X, ponto.Y + label4.Height);
                    button6.Location = new Point(button6.Location.X, ponto.Y + label4.Height);
                    ponto = new Point(ponto.X, ponto.Y + label4.Height + comboBox3.Height + 20);
                    //}
                }
                else if (countAs == 3)
                {
                    label5.Text = "" + areadeespecializacao.SelectedItem + "";
                    label5.Visible = true;
                    comboBox4.Visible = true;
                    button7.Visible = true;
                    fieldsList[2] = "" + areadeespecializacao.SelectedItem + "";
                    /*if (ponto2.Y < ponto.Y)
                    {
                        ponto = new Point(ponto.X, ponto.Y + 40);
                        label5.Location = ponto;
                        comboBox4.Location = new Point(ponto.X, ponto.Y + label5.Height);
                        ponto = new Point(ponto.X, ponto.Y + label5.Height + comboBox4.Height + 20);
                    }
                    else
                    {*/
                    label5.Location = ponto;
                    comboBox4.Location = new Point(ponto.X, ponto.Y + label5.Height);
                    button7.Location = new Point(button7.Location.X, ponto.Y + label5.Height);
                    ponto = new Point(ponto.X, ponto.Y + label5.Height + comboBox4.Height + 20);
                    //}
                }
                else
                {
                    //countAs = 0;
                }
            }
        }
    }
}

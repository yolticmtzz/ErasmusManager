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
    public partial class SelecaoDeEstudantes : Form
    {
        Point ponto = new Point(142, 77);
        int autonomy, l1, l2, l3, evalTec, evalTec1, evalTec2 = 0;
        String field = "";
        List<string> linguasList = new List<string>();
        List<string> fieldsList = new List<string>();
        public SelecaoDeEstudantes()
        {
            InitializeComponent();

        }

        String studentId = null;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SelecaoDeEstudantes_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = "Server=tcp:eramusmanager.database.windows.net,1433;Initial Catalog=eramusmanagerdb;Persist Security Info=False;User ID=eramusmanager;Password=ispgprojSAD!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(builder.ConnectionString);

            DebugStudentId.Text = Properties.Settings.Default.studentId;


            connection.Open();
            String mp = "SELECT studentName FROM Students WHERE studentId = ('" + Properties.Settings.Default.studentId + "')";
            SqlCommand MPcommand = new SqlCommand(mp, connection);
            SqlDataReader MPreader = MPcommand.ExecuteReader();


            while (MPreader.Read())
            {
                label8.Text = MPreader.GetString(0);
            }

            connection.Close();

            connection.Open();
            String mp1 = "SELECT studyFieldReq FROM DetailsReq WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND type = 'AS' ";
            SqlCommand MPcommand1 = new SqlCommand(mp1, connection);
            SqlDataReader MPreader1 = MPcommand1.ExecuteReader();


            while (MPreader1.Read())
            {
                labelperguntaareastring.Text = "O estudante tem experiência na área de " + MPreader1.GetString(0) + "?";
                field = MPreader1.GetString(0);
            }

            connection.Close();

            connection.Open();
            String GNewProject16 = "SELECT studyFieldReq FROM DetailsReq WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND type = 'LN' ";
            SqlCommand GNewProjectcommand16 = new SqlCommand(GNewProject16, connection);
            SqlDataReader GNewProjectreader16 = GNewProjectcommand16.ExecuteReader();

            while (GNewProjectreader16.Read())
            {
                linguasList.Add(GNewProjectreader16.GetString(0));
            }

            connection.Close();

            connection.Open();
            String GNewProject17 = "SELECT studyFieldReq FROM DetailsReq WHERE projectId = ('" + Properties.Settings.Default.projectId + "') AND type = 'AS' ";
            SqlCommand GNewProjectcommand17 = new SqlCommand(GNewProject17, connection);
            SqlDataReader GNewProjectreader17 = GNewProjectcommand17.ExecuteReader();

            while (GNewProjectreader17.Read())
            {
                fieldsList.Add(GNewProjectreader17.GetString(0));
            }

            connection.Close();

            if (linguasList[0] != "SM")
            {
                label2.Text = "O estudante tem conhecimento de " + linguasList[0] + ", em que seguinte nivel? ";
                label2.Visible = true;
                groupBox4.Visible = true;
                label2.Location = ponto;
                groupBox4.Location = new Point(ponto.X, ponto.Y + label2.Height);
                ponto = new Point(ponto.X, ponto.Y + label2.Height + groupBox4.Height + 20);
            }

            if (linguasList[1] != "Sm")
            {
                label4.Text = "O estudante tem conhecimento de " + linguasList[1] + ", em que seguinte nivel? ";
                label4.Visible = true;
                groupBox10.Visible = true;
                label4.Location = ponto;
                groupBox10.Location = new Point(ponto.X, ponto.Y + label4.Height);
                ponto = new Point(ponto.X, ponto.Y + label4.Height + groupBox10.Height + 20);
            }
            if (linguasList[2] != "SM")
            {
                label5.Text = "O estudante tem conhecimento de " + linguasList[2] + ", em que seguinte nivel? ";
                label5.Visible = true;
                groupBox5.Visible = true;
                label5.Location = ponto;
                groupBox10.Location = new Point(ponto.X, ponto.Y + label5.Height);
                ponto = new Point(ponto.X, ponto.Y + label5.Height + groupBox10.Height + 20);
            }


            if (fieldsList[0] != "SM")
            {
                labelperguntaareastring.Text = "O estudante tem experiência na área de " + fieldsList[0] + " ? ";
                labelrealizarprojeto.Text = "O estudante já realizou algum projeto nesta área (" + fieldsList[0] +") ?";
                labelperguntaareastring.Visible = true;
                labelrealizarprojeto.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                labelperguntaareastring.Location = ponto;
                groupBox2.Location = new Point(ponto.X, ponto.Y + labelperguntaareastring.Height);
                labelrealizarprojeto.Location = new Point(ponto.X, ponto.Y + labelperguntaareastring.Height + groupBox2.Height + 20);
                groupBox3.Location = new Point(ponto.X, ponto.Y + labelperguntaareastring.Height + groupBox2.Height + 20 + labelrealizarprojeto.Height);
                ponto = new Point(ponto.X, ponto.Y + labelperguntaareastring.Height + groupBox2.Height + 20 + labelrealizarprojeto.Height + groupBox3.Height + 20);
            }

            if (fieldsList[1] != "SM")
            {
                label6.Text = "O estudante tem experiência na área de " + fieldsList[1] + " ? ";
                label1.Text = "O estudante já realizou algum projeto nesta área (" + fieldsList[1] + ") ?";
                label6.Visible = true;
                label1.Visible = true;
                groupBox7.Visible = true;
                groupBox1.Visible = true;
                label6.Location = ponto;
                groupBox7.Location = new Point(ponto.X, ponto.Y + label6.Height);
                label1.Location = new Point(ponto.X, ponto.Y + label6.Height + groupBox7.Height + 20);
                groupBox1.Location = new Point(ponto.X, ponto.Y + label6.Height + groupBox7.Height + 20 + label1.Height);
                ponto = new Point(ponto.X, ponto.Y + label6.Height + groupBox7.Height + 20 + label1.Height + groupBox1.Height + 20);
            }
            if (fieldsList[2] != "SM")
            {
                label9.Text = "O estudante tem experiência na área de " + fieldsList[2] + " ? ";
                label7.Text = "O estudante já realizou algum projeto nesta área (" + fieldsList[2] + ") ?";
                label9.Visible = true;
                label7.Visible = true;
                groupBox9.Visible = true;
                groupBox8.Visible = true;
                label9.Location = ponto;
                groupBox9.Location = new Point(ponto.X, ponto.Y + label9.Height);
                label7.Location = new Point(ponto.X, ponto.Y + label9.Height + groupBox9.Height + 20);
                groupBox8.Location = new Point(ponto.X, ponto.Y + label9.Height + groupBox9.Height + 20 + label7.Height);
                ponto = new Point(ponto.X, ponto.Y + label9.Height + groupBox9.Height + 20 + label7.Height + groupBox8.Height + 20);
            }
        }

        private void niveldefluente_Scroll(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                if (evalTec <= 5)
                {
                    evalTec += 5;
                }
                else
                {
                    evalTec += 2;
                }
            }
            else
            {
                /*if (evalTec >= 5)
                {
                    evalTec -= 5;
                }
                else
                {
                    evalTec -= 2;
                }*/
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                if (evalTec <= 5)
                {
                    evalTec += 5;
                }
                else
                {
                    evalTec += 2;
                }
            }
            else
            {
               /* if (evalTec >= 5)
                {
                    evalTec -= 5;
                }
                else
                {
                    evalTec -= 2;
                }*/
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = "Server=tcp:eramusmanager.database.windows.net,1433;Initial Catalog=eramusmanagerdb;Persist Security Info=False;User ID=eramusmanager;Password=ispgprojSAD!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(builder.ConnectionString);

            if (evalTec > 10)
            {
                evalTec = 10;
            }
            else if (evalTec < 0)
            {
                evalTec = 0;
            }

            if (evalTec1 > 10)
            {
                evalTec1 = 10;
            }
            else if (evalTec1 < 0)
            {
                evalTec1 = 0;
            }
            if (evalTec2 > 10)
            {
                evalTec2 = 10;
            }

            else if (evalTec2 < 0)
            {
                evalTec2 = 0;
            }


            /*connection.Open();
            String mp = "Update Students SET autonomy = ('" + autonomy + "'), studyField = ('" + field +"'), fieldEvaluation = ('" + evalTec + "') WHERE studentId = ('" + Properties.Settings.Default.studentId + "')";
            SqlCommand MPcommand = new SqlCommand(mp, connection);
            SqlDataReader MPreader = MPcommand.ExecuteReader();
            connection.Close();*/

            connection.Open();
            String GNewProject3 = "UPDATE Languages SET evaluationLang = ('" + l1 + "' ) WHERE studentId = ('" + Properties.Settings.Default.studentId + "') AND langName = ('" + linguasList[0] + "') ";
            SqlCommand GNewProjectcommand3 = new SqlCommand(GNewProject3, connection);
            SqlDataReader GNewProjectreader3 = GNewProjectcommand3.ExecuteReader();
            connection.Close();

            connection.Open();
            String GNewProject4 = "UPDATE Languages SET evaluationLang = ('" + l2 + "' ) WHERE studentId = ('" + Properties.Settings.Default.studentId + "') AND langName = ('" + linguasList[1] + "') ";
            SqlCommand GNewProjectcommand4 = new SqlCommand(GNewProject4, connection);
            SqlDataReader GNewProjectreader4 = GNewProjectcommand4.ExecuteReader();
            connection.Close();

            connection.Open();
            String GNewProject5 = "UPDATE Languages SET evaluationLang = ('" + l3 + "' ) WHERE studentId = ('" + Properties.Settings.Default.studentId + "') AND langName = ('" + linguasList[2] + "') ";
            SqlCommand GNewProjectcommand5 = new SqlCommand(GNewProject5, connection);
            SqlDataReader GNewProjectreader5 = GNewProjectcommand5.ExecuteReader();
            connection.Close();

            connection.Open();
            String GNewProject43 = "UPDATE Languages SET evaluationLang = ('" + evalTec + "' ) WHERE studentId = ('" + Properties.Settings.Default.studentId + "') AND langName = ('" + fieldsList[0] + "') ";
            SqlCommand GNewProjectcommand43 = new SqlCommand(GNewProject43, connection);
            SqlDataReader GNewProjectreader43 = GNewProjectcommand43.ExecuteReader();
            connection.Close();

            connection.Open();
            String GNewProject44 = "UPDATE Languages SET evaluationLang = ('" + evalTec1 + "' ) WHERE studentId = ('" + Properties.Settings.Default.studentId + "') AND langName = ('" + fieldsList[1] + "') ";
            SqlCommand GNewProjectcommand44 = new SqlCommand(GNewProject44, connection);
            SqlDataReader GNewProjectreader44 = GNewProjectcommand44.ExecuteReader();
            connection.Close();

            connection.Open();
            String GNewProject45 = "UPDATE Languages SET evaluationLang = ('" + evalTec2 + "' ) WHERE studentId = ('" + Properties.Settings.Default.studentId + "') AND langName = ('" + fieldsList[2] + "') ";
            SqlCommand GNewProjectcommand45 = new SqlCommand(GNewProject45, connection);
            SqlDataReader GNewProjectreader45 = GNewProjectcommand45.ExecuteReader();
            connection.Close();

            MessageBox.Show("Attributes successfully updated ", "Attributes Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        

        private void radioButtonINGLES_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            List<Control> radioButtons = new List<Control>();
            RadioButton radio1 = new RadioButton();
            RadioButton radio2 = new RadioButton();
            RadioButton radio3 = new RadioButton();
            RadioButton radio4 = new RadioButton();
            radio1.Text = "Não fluente.";
            radio2.Text = "Fluente, mas com problemas na escrita.";
            radio3.Text = "Fluente, mas com problemas no discurso.";
            radio4.Text = "Fluente.";
            Label question = new Label();
            question.Font = new Font("Microsoft Sans Serif", 13);
            question.Text = "O estudante tem conhecimento de espanhol, em que seguinte nivel?";
            question.Location = new Point(ponto.X, ponto.Y + 10);
            question.Size = new Size(590, 22);
            var location = new Point(6, 5);
            
            

            radio1.Location = location;
            radio2.Location = new Point(location.X, location.Y + radio1.Height);
            radio3.Location = new Point(radio2.Location.X, radio2.Location.Y + radio2.Height);
            radio4.Location = new Point(radio3.Location.X, radio3.Location.Y + radio3.Height);

            radio1.Font = new Font("Microsoft Sans Serif", 11);
            radio2.Font = new Font("Microsoft Sans Serif", 11);
            radio3.Font = new Font("Microsoft Sans Serif", 11);
            radio4.Font = new Font("Microsoft Sans Serif", 11);

            GroupBox group = new GroupBox();
            group.Controls.Add(radio1);
            group.Controls.Add(radio2);
            group.Controls.Add(radio3);
            group.Controls.Add(radio4);
            group.Size = new Size(radio3.Width + radio4.Width, radio1.Height + radio2.Height + radio3.Height + radio4.Height);
            group.Location = new Point(question.Location.X, question.Location.Y + question.Height);
            ponto = new Point(ponto.X, group.Location.Y);

            button1.Location = new Point(group.Location.X, group.Location.Y + group.Height + 10);

            this.Controls.Add(question);
            this.Controls.Add(group);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            List<Control> radioButtons = new List<Control>();
            RadioButton radio1 = new RadioButton();
            RadioButton radio2 = new RadioButton();
            RadioButton radio3 = new RadioButton();
            RadioButton radio4 = new RadioButton();
            radio1.Text = "Não fluente.";
            radio2.Text = "Fluente, mas com problemas na escrita.";
            radio3.Text = "Fluente, mas com problemas no discurso.";
            radio4.Text = "Fluente.";
            Label question = new Label();
            question.Font = new Font("Microsoft Sans Serif", 13);
            question.Text = "O estudante tem conhecimento de francês, em que seguinte nivel?";
            question.Location = new Point(ponto.X, ponto.Y + 10);
            question.Size = new Size(590, 22);
            var location = new Point(6, 5);
            

            radio1.Location = location;
            radio2.Location = new Point(location.X, location.Y + radio1.Height);
            radio3.Location = new Point(radio2.Location.X, radio2.Location.Y + radio2.Height);
            radio4.Location = new Point(radio3.Location.X, radio3.Location.Y + radio3.Height);

            radio1.Font = new Font("Microsoft Sans Serif", 11);
            radio2.Font = new Font("Microsoft Sans Serif", 11);
            radio3.Font = new Font("Microsoft Sans Serif", 11);
            radio4.Font = new Font("Microsoft Sans Serif", 11);

            GroupBox group = new GroupBox();
            group.Controls.Add(radio1);
            group.Controls.Add(radio2);
            group.Controls.Add(radio3);
            group.Controls.Add(radio4);
            group.Size = new Size(radio3.Width + radio4.Width, radio1.Height + radio2.Height + radio3.Height + radio4.Height);
            group.Location = new Point(question.Location.X, question.Location.Y + question.Height);
            ponto = new Point(ponto.X, group.Location.Y);

            button1.Location = new Point(group.Location.X, group.Location.Y + group.Height + 10);

            this.Controls.Add(question);
            this.Controls.Add(group);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            List<Control> radioButtons = new List<Control>();
            RadioButton radio1 = new RadioButton();
            RadioButton radio2 = new RadioButton();
            RadioButton radio3 = new RadioButton();
            RadioButton radio4 = new RadioButton();
            radio1.Text = "Não fluente.";
            radio2.Text = "Fluente, mas com problemas na escrita.";
            radio3.Text = "Fluente, mas com problemas no discurso.";
            radio4.Text = "Fluente.";
            Label question = new Label();
            question.Font = new Font("Microsoft Sans Serif", 13);
            question.Text = "O estudante tem conhecimento de alemão, em que seguinte nivel?";
            question.Location = new Point(ponto.X, ponto.Y + 10);
            question.Size = new Size(590, 22);
            var location = new Point(6, 5);
            

            radio1.Location = location;
            radio2.Location = new Point(location.X, location.Y + radio1.Height);
            radio3.Location = new Point(radio2.Location.X, radio2.Location.Y + radio2.Height);
            radio4.Location = new Point(radio3.Location.X, radio3.Location.Y + radio3.Height);

            radio1.Font = new Font("Microsoft Sans Serif", 11);
            radio2.Font = new Font("Microsoft Sans Serif", 11);
            radio3.Font = new Font("Microsoft Sans Serif", 11);
            radio4.Font = new Font("Microsoft Sans Serif", 11);

            GroupBox group = new GroupBox();
            group.Controls.Add(radio1);
            group.Controls.Add(radio2);
            group.Controls.Add(radio3);
            group.Controls.Add(radio4);
            group.Size = new Size(radio3.Width + radio4.Width, radio1.Height + radio2.Height + radio3.Height + radio4.Height);
            group.Location = new Point(question.Location.X, question.Location.Y + question.Height);
            ponto = new Point(ponto.X, group.Location.Y);

            button1.Location = new Point(group.Location.X, group.Location.Y + group.Height + 10);

            this.Controls.Add(question);
            this.Controls.Add(group);
        }

        private void radioButtonSim2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSim2.Checked == true)
            {
                if (evalTec <= 5)
                {
                    evalTec += 5;
                }
                else
                {
                    evalTec += 2;
                }
            }
            else
            {
                /*if (evalTec >= 5)
                {
                    evalTec -= 5;
                }
                else
                {
                    evalTec -= 2;
                }*/
            }
        }

        private void radioButtonNao2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNao2.Checked == true)
            {
                if (evalTec <= 5)
                {
                    evalTec -= 5;
                }
                else
                {
                    evalTec -= 2;
                }
            }
            else
            {
                /*if (evalTec >= 5)
                {
                    evalTec += 5;
                }
                else
                {
                    evalTec += 2;
                }*/
            }
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                l1 = 2;
            }
            else
            {
                
            }
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                l1 = 6;
            }
            else
            {

            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                l2 = 0;
            }
            else
            {

            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true)
            {
                l2 = 3;
            }
            else
            {

            }
        }

        private void radioButton6_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                l2 = 6;
            }
            else
            {

            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                l2 = 10;
            }
            else
            {

            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked == true)
            {
                l3 = 0;
            }
            else
            {

            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12.Checked == true)
            {
                l3 = 3;
            }
            else
            {

            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
            {
                l3 = 6;
            }
            else
            {

            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                l3 = 10;
            }
            else
            {

            }
        }

     
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            List<Control> radioButtons = new List<Control>();
            RadioButton radio1 = new RadioButton();
            RadioButton radio2 = new RadioButton();
            RadioButton radio3 = new RadioButton();
            RadioButton radio4 = new RadioButton();
            radio1.Text = "Não fluente.";
            radio2.Text = "Fluente, mas com problemas na escrita.";
            radio3.Text = "Fluente, mas com problemas no discurso.";
            radio4.Text = "Fluente.";
            Label question = new Label();
            question.Font = new Font("Microsoft Sans Serif", 13);
            question.Text = "O estudante tem conhecimento de inglês, em que seguinte nivel?";
            question.Location = new Point(ponto.X, ponto.Y + 10);
            question.Size = new Size(590, 22);
            var location = new Point(6, 5);
            

            radio1.Location = location;
            radio2.Location = new Point(location.X, location.Y + radio1.Height);
            radio3.Location = new Point(radio2.Location.X, radio2.Location.Y + radio2.Height);
            radio4.Location = new Point(radio3.Location.X, radio3.Location.Y + radio3.Height);

            radio1.Font = new Font("Microsoft Sans Serif", 11);
            radio2.Font = new Font("Microsoft Sans Serif", 11);
            radio3.Font = new Font("Microsoft Sans Serif", 11);
            radio4.Font = new Font("Microsoft Sans Serif", 11);

            GroupBox group = new GroupBox();
            group.Controls.Add(radio1);
            group.Controls.Add(radio2);
            group.Controls.Add(radio3);
            group.Controls.Add(radio4);
            group.Size = new Size(radio3.Width + radio4.Width, radio1.Height + radio2.Height + radio3.Height + radio4.Height);
            group.Location = new Point(question.Location.X, question.Location.Y + question.Height);
            ponto = new Point(ponto.X, group.Location.Y);

            button1.Location = new Point(group.Location.X, group.Location.Y + group.Height + 10);

            this.Controls.Add(question);
            this.Controls.Add(group);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton15.Checked == true)
            {
                if (evalTec1 <= 5)
                {
                    evalTec1 += 5;
                }
                else
                {
                    evalTec1 += 2;
                }
            }
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton13.Checked == true)
            {
                if (evalTec1 <= 5)
                {
                    evalTec1 += 5;
                }
                else
                {
                    evalTec1 += 2;
                }
            }
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton19.Checked == true)
            {
                if (evalTec2 <= 5)
                {
                    evalTec2 += 5;
                }
                else
                {
                    evalTec2 += 2;
                }
            }
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton17.Checked == true)
            {
                if (evalTec2 <= 5)
                {
                    evalTec2 += 5;
                }
                else
                {
                    evalTec2 += 2;
                }
            }
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton16.Checked == true)
            {
                if (evalTec1 <= 5)
                {
                    evalTec1 -= 5;
                }
                else
                {
                    evalTec1 -= 2;
                }
            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton14.Checked == true)
            {
                if (evalTec1 <= 5)
                {
                    evalTec1 -= 5;
                }
                else
                {
                    evalTec1 -= 2;
                }
            }
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton20.Checked == true)
            {
                if (evalTec2 <= 5)
                {
                    evalTec2 -= 5;
                }
                else
                {
                    evalTec2 -= 2;
                }
            }
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton18.Checked == true)
            {
                if (evalTec2 <= 5)
                {
                    evalTec2 -= 5;
                }
                else
                {
                    evalTec2 -= 2;
                }
            }
        }

        private void radioButton11_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton11.Checked == true)
            {
                l1 = 0;
            }
            else
            {

            }
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton21.Checked == true)
            {
                l1 = 8;
            }
            else
            {

            }
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton22.Checked == true)
            {
                l1 = 10;
            }
            else
            {

            }
        }

        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton27.Checked == true)
            {
                l2 = 1;
            }
            else
            {

            }
        }

        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton28.Checked == true)
            {
                l2 = 2;
            }
            else
            {

            }
        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton26.Checked == true)
            {
                l2 = 4;
            }
            else
            {

            }
        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton25.Checked == true)
            {
                l2 = 6;
            }
            else
            {

            }
        }

        private void radioButton12_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton12.Checked == true)
            {
                l2 = 0;
            }
            else
            {

            }
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton24.Checked == true)
            {
                l2 = 8;
            }
            else
            {

            }
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton23.Checked == true)
            {
                l2 = 10;
            }
            else
            {

            }
        }

        private void radioButton9_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                l3 = 1;
            }
            else
            {

            }
        }

        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton29.Checked == true)
            {
                l3 = 0;
            }
            else
            {

            }
        }

        private void radioButton10_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
            {
                l3 = 2;
            }
            else
            {

            }
        }

        private void radioButton8_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true)
            {
                l3 = 4;
            }
            else
            {

            }
        }

        private void radioButton7_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                l3 = 6;
            }
            else
            {

            }
        }

        private void radioButton6_CheckedChanged_2(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                l3 = 8;
            }
            else
            {

            }
        }

        private void radioButton5_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                l3 = 10;
            }
            else
            {

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            List<Control> radioButtons = new List<Control>();
            RadioButton radio1 = new RadioButton();
            RadioButton radio2 = new RadioButton();
            RadioButton radio3 = new RadioButton();
            RadioButton radio4 = new RadioButton();
            radio1.Text = "Não fluente.";
            radio2.Text = "Fluente, mas com problemas na escrita.";
            radio3.Text = "Fluente, mas com problemas no discurso.";
            radio4.Text = "Fluente.";
            Label question = new Label();
            question.Font = new Font("Microsoft Sans Serif", 13);
            question.Text = "O estudante tem conhecimento de italiano, em que seguinte nivel?";
            question.Location = new Point(ponto.X, ponto.Y + 10);
            question.Size = new Size(590, 22);
            var location = new Point(6, 5);
            

            radio1.Location = location;
            radio2.Location = new Point(location.X, location.Y + radio1.Height);
            radio3.Location = new Point(radio2.Location.X, radio2.Location.Y + radio2.Height);
            radio4.Location = new Point(radio3.Location.X, radio3.Location.Y + radio3.Height);

            radio1.Font = new Font("Microsoft Sans Serif", 11);
            radio2.Font = new Font("Microsoft Sans Serif", 11);
            radio3.Font = new Font("Microsoft Sans Serif", 11);
            radio4.Font = new Font("Microsoft Sans Serif", 11);

            GroupBox group = new GroupBox();
            group.Controls.Add(radio1);
            group.Controls.Add(radio2);
            group.Controls.Add(radio3);
            group.Controls.Add(radio4);
            group.Size = new Size(radio3.Width + radio4.Width, radio1.Height + radio2.Height + radio3.Height + radio4.Height);
            group.Location = new Point(question.Location.X, question.Location.Y + question.Height);
            group.Margin = new Padding(100);
            ponto = new Point(ponto.X, group.Location.Y);

            button1.Location = new Point(group.Location.X, group.Location.Y + group.Height + 10);

            this.Controls.Add(question);
            this.Controls.Add(group);
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                l1 = 4;
            }
            else
            {

            }
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                l1 = 1;
            }
            else
            {
                
            }
        }
    }
}

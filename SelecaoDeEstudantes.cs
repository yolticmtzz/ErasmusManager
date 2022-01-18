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
        Point ponto = new Point(142, 560);
        int autonomy, en, es, fr, it, al, evalTec = 0;
        String field = "";

        public SelecaoDeEstudantes()
        {
            InitializeComponent();

        }

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


            connection.Open();
            String mp = "SELECT studentName FROM Students WHERE studentId = 12";
            SqlCommand MPcommand = new SqlCommand(mp, connection);
            SqlDataReader MPreader = MPcommand.ExecuteReader();


            while (MPreader.Read())
            {
                labelnomedoaluno.Text = MPreader.GetString(0);
            }

            connection.Close();

            connection.Open();
            String mp1 = "SELECT studyFieldReq FROM DetailsReq WHERE detailsId = (SELECT max(detailsId) FROM DetailsReq WHERE projectId = ('" + Properties.Settings.Default.projectId + "')) ";
            SqlCommand MPcommand1 = new SqlCommand(mp1, connection);
            SqlDataReader MPreader1 = MPcommand1.ExecuteReader();


            while (MPreader1.Read())
            {
                labelperguntaareastring.Text = "O estudante tem experiência na área de " + MPreader1.GetString(0) + "?";
                field = MPreader1.GetString(0);
            }

            connection.Close();

            label2.Text = "O estudante tem conhecimento de inglês, em que seguinte nivel? ";
            label4.Text = "O estudante tem conhecimento de espanhol, em que seguinte nivel? ";
            label5.Text = "O estudante tem conhecimento de francês, em que seguinte nivel? ";
            label6.Text = "O estudante tem conhecimento de italiano, em que seguinte nivel? ";
            label7.Text = "O estudante tem conhecimento de alemão, em que seguinte nivel? ";
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

            connection.Open();
            String mp = "Update Students SET autonomy = ('" + autonomy + "'), studyField = ('" + field +"'), fieldEvaluation = ('" + evalTec + "') WHERE studentId = 12";
            SqlCommand MPcommand = new SqlCommand(mp, connection);
            SqlDataReader MPreader = MPcommand.ExecuteReader();
            connection.Close();

            connection.Open();
            String GNewProject3 = "UPDATE Languages SET evaluationLang = ('" + en + "' ) WHERE studentId = ('" + 12 + "') AND langName = 'ingles' ";
            SqlCommand GNewProjectcommand3 = new SqlCommand(GNewProject3, connection);
            SqlDataReader GNewProjectreader3 = GNewProjectcommand3.ExecuteReader();
            connection.Close();

            connection.Open();
            String GNewProject4 = "UPDATE Languages SET evaluationLang = ('" + es + "' ) WHERE studentId = ('" + 12 + "') AND langName = 'espanhol' ";
            SqlCommand GNewProjectcommand4 = new SqlCommand(GNewProject4, connection);
            SqlDataReader GNewProjectreader4 = GNewProjectcommand4.ExecuteReader();
            connection.Close();

            connection.Open();
            String GNewProject5 = "UPDATE Languages SET evaluationLang = ('" + fr + "' ) WHERE studentId = ('" + 12 + "') AND langName = 'frances' ";
            SqlCommand GNewProjectcommand5 = new SqlCommand(GNewProject5, connection);
            SqlDataReader GNewProjectreader5 = GNewProjectcommand5.ExecuteReader();
            connection.Close();

            connection.Open();
            String GNewProject6 = "UPDATE Languages SET evaluationLang = ('" + it + "' ) WHERE studentId = ('" + 12 + "') AND langName = 'italiano' ";
            SqlCommand GNewProjectcommand6 = new SqlCommand(GNewProject6, connection);
            SqlDataReader GNewProjectreader6 = GNewProjectcommand6.ExecuteReader();
            connection.Close();

            connection.Open();
            String GNewProject7 = "UPDATE Languages SET evaluationLang = ('" + al + "' ) WHERE studentId = ('" + 12 + "') AND langName = 'alemao' ";
            SqlCommand GNewProjectcommand7 = new SqlCommand(GNewProject7, connection);
            SqlDataReader GNewProjectreader7 = GNewProjectcommand7.ExecuteReader();
            connection.Close();
        }

        private void radioButtonSIM_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonSIM.Checked == true)
            {
                autonomy = 1;
                if(evalTec <= 8)
                {
                    evalTec += 2;
                }
            }
            else
            {
               /* autonomy = 0;
                if(evalTec >= 2)
                {
                    evalTec -= 2;
                }*/
            }
        }

        private void radioButtonNAO_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNAO.Checked == true)
            {
                autonomy = 0;
                if (evalTec >= 2)
                {
                    evalTec -= 2;
                }
            }
            else
            {
                /*autonomy = 1;
                if (evalTec <= 8)
                {
                    evalTec += 2;
                }*/
            }
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
                en = 3;
            }
            else
            {
                
            }
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                en = 10;
            }
            else
            {

            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                es = 0;
            }
            else
            {

            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true)
            {
                es = 3;
            }
            else
            {

            }
        }

        private void radioButton6_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                es = 6;
            }
            else
            {

            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                es = 10;
            }
            else
            {

            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked == true)
            {
                fr = 0;
            }
            else
            {

            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12.Checked == true)
            {
                fr = 3;
            }
            else
            {

            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
            {
                fr = 6;
            }
            else
            {

            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                fr = 10;
            }
            else
            {

            }
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton15.Checked == true)
            {
                it = 0;
            }
            else
            {

            }
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton16.Checked == true)
            {
                it = 3;
            }
            else
            {

            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton14.Checked == true)
            {
                it = 6;
            }
            else
            {

            }
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton13.Checked == true)
            {
                it = 10;
            }
            else
            {

            }
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton19.Checked == true)
            {
                al = 0;
            }
            else
            {

            }
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton20.Checked == true)
            {
                al = 3;
            }
            else
            {

            }
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton18.Checked == true)
            {
                al = 6;
            }
            else
            {

            }
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                al = 10;
            }
            else
            {

            }
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
                en = 6;
            }
            else
            {

            }
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                en = 0;
            }
            else
            {
                
            }
        }
    }
}

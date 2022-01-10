using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;
using System.IO;



namespace EramusManager
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            Design();
            
        }
        
        private void Design ()
        {
            projetospanel.Visible = false;
            studpanel.Visible = false;
        }

        private void hideSubMenu ()
        {
            if (projetospanel.Visible == true)
                projetospanel.Visible = false;

            if (studpanel.Visible == true)
                studpanel.Visible = false;
        }


        private void showSubMenu (Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = "Server=tcp:eramusmanager.database.windows.net,1433;Initial Catalog=eramusmanagerdb;Persist Security Info=False;User ID=eramusmanager;Password=ispgprojSAD!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(builder.ConnectionString);

          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form NovoProjeto = new NovoProjeto();
            NovoProjeto.Closed += (s, args) => this.Close();
            NovoProjeto.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            showSubMenu(projetospanel);
        }

        private void btnnp_Click(object sender, EventArgs e)
        {
            openChildForm(new NovoProjeto());
            hideSubMenu();
        }

        private Form activeForm = null;
        private void openChildForm (Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm ;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            ChildPannel.Controls.Add(childForm);
            ChildPannel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChildPannel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void butviewp_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewProject());
            hideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new EditarProjeto());
            hideSubMenu();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            showSubMenu(studpanel);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = "Server=tcp:eramusmanager.database.windows.net,1433;Initial Catalog=eramusmanagerdb;Persist Security Info=False;User ID=eramusmanager;Password=ispgprojSAD!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(builder.ConnectionString);
            SqlDataAdapter adpter = new SqlDataAdapter();

            DataSet ds = new DataSet();
            XmlReader xmlFile;
            string sql = null;
            Boolean verificar = false;

            int studentId = 0;
            string studentName = null;
            ds.ReadXml("students.xml");

            int i = 0;
            connection.Open();

            for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                studentName = ds.Tables[0].Rows[i].ItemArray[1].ToString();

                String student = "INSERT INTO Students (studentName) VALUES('" + studentName + "')";
                SqlCommand command = new SqlCommand(student, connection);
                adpter.InsertCommand = command;
                adpter.InsertCommand.ExecuteNonQuery();
                verificar = true;
            }
            connection.Close();
            MessageBox.Show("Completed");

            if (verificar = true)
            {
                button4.Enabled = false;
            }

        }
    }
}

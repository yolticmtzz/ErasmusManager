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
using System.IO;


namespace EramusManager
{
    

    public partial class Simulacao : Form
    {
        Point ponto = new Point(142, 560);
        int[,] valuesCSV;
        //string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";
        //string download = Environment.GetEnvironmentVariable("USERPROFILE")+@"\"+"Downloads";
        //string strFilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads\testfile.csv";
        StringBuilder sbOutput = new StringBuilder();
        StringBuilder sbOutput2 = new StringBuilder();
        List<string> codeList = new List<string>();
        string projectId = Properties.Settings.Default.projectId;

        public class MyGridValues
        {
            public string Name { get; set; }

            public string Area { get; set; }

        }

        public class AHP
        {

            public double[,] initialize_matrix(double[] p, int n)
            {
                double[,] a = new double[n, n];
                int k = 0;
                for (int i = 0; i < n; i++)
                {
                    

                    for (int j = 0; j < n; j++)
                    {
                        if (i == j)
                        {
                            a[i, j] = 1;
                        }
                            
                        else if (i < j)
                        {
                            a[i, j] = p[k];
                            
                            k++;
                        }

                        else if (i > j)
                        {
                            a[i, j] = 1 / a[j, i];
                        }
                            
                    }
                }
                return a;
            }

            public double[] show_matrix(double[,] b, int n)
            {
                //display the elements of the matrix a
                double[] matrix = new double[n];
                Console.WriteLine("\nThe matrix a is:");
                Label label1 = new Label();
                label1.Text = "The matrix a is:";
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.WriteLine(b[i, j] + "    ");
                        //Label label2 = new Label();
                        //label2.Text = "" + b[i, j] + "";
                    }
                    Console.WriteLine();
                }

                double[] column = new double[n];
                for (int j = 0; j < n; j++)
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (column[j] != null)
                        {
                            column[j] = column[j] + b[i, j];
                        }
                        else
                        {
                            column[j] = b[i, j];
                        }
                    }

                }

                double[,] matrixColumn = new double[n, n];
                for (int j = 0; j < n; j++)
                {
                    for (int i = 0; i < n; i++)
                    {
                        matrixColumn[i, j] = b[i, j] / column[j];
                    }

                }

                //Obtained the number of lines
                double[] line = new double[n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (line[i] != null)
                        {
                            line[i] = line[i] + matrixColumn[i, j];
                        }
                        else
                        {
                            line[i] = matrixColumn[i, j];
                        }
                    }

                }

                //Working through the characteristic vector
                double[] w = new double[n];
                double sum = 0.0;
                for (int i = 0; i < n; i++)
                {
                    sum = sum + line[i];
                }
                for (int i = 0; i < n; i++)
                {
                    w[i] = line[i] / sum;                    //Feature vector
                }
                double[] bw = new double[n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (bw[i] != null)
                        {
                            bw[i] = bw[i] + b[i, j] * w[j];
                        }
                        else
                        {
                            bw[i] = b[i, j] * w[j];
                        }
                    }
                }
                double sumR = 0.0;                        //Maximum characteristics and r
                for (int i = 0; i < n; i++)
                {
                    sumR = sumR + bw[i] / (n * w[i]);
                }
                double ci = (sumR - n) / (n - 1);                //Matrix consistency indicator
              
                Console.WriteLine("Computing Matrix Consistency Indicator " + ci);

                //Output feature vector
                for (int i = 0; i < n; i++)
                {
                    //Label label4 = new Label();
                    //label4.Text = "Feature" + i + "weight:" + w[i];
                    Console.WriteLine("Feature" + i + "weight:" + w[i]);
                    matrix[i] = w[i];
                }

                return matrix;
            }

        }
        public Simulacao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Simulacao_Load(object sender, EventArgs e)
        {
            AHP ahp = new AHP();

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

            string[] linguas = {
                "Inglês",
                "Espanhol",
                "Francês",
                "Italiano",
                "Alemão",
            };

            int n;
            int studentsCount = 0;
            int NUMBER_COMPARISON;
            List<string> fieldList = new List<string>();
            List<double> evalList = new List<double>();
            int count = 0;
            //Scanner keyboard = new Scanner(System.in);
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = "Server=tcp:eramusmanager.database.windows.net,1433;Initial Catalog=eramusmanagerdb;Persist Security Info=False;User ID=eramusmanager;Password=ispgprojSAD!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection connection = new SqlConnection(builder.ConnectionString);

            connection.Open();
            String GNewProject156 = "SELECT Count(*) FROM Students WHERE projectId = ('"+ projectId +"') ";
            SqlCommand GNewProjectcommand156 = new SqlCommand(GNewProject156, connection);
            SqlDataReader GNewProjectreader156 = GNewProjectcommand156.ExecuteReader();

            while (GNewProjectreader156.Read())
            {
                studentsCount = GNewProjectreader156.GetInt32(0);
            }

            connection.Close();

            connection.Open();
            String GNewProject16 = "SELECT studyFieldReq, fieldEvaluation FROM DetailsReq WHERE projectId = ('" + projectId + "') ";
            SqlCommand GNewProjectcommand16 = new SqlCommand(GNewProject16, connection);
            SqlDataReader GNewProjectreader16 = GNewProjectcommand16.ExecuteReader();

            while (GNewProjectreader16.Read())
            {
                if (GNewProjectreader16["studyFieldReq"].ToString() != "SM")
                {
                    fieldList.Add(GNewProjectreader16["studyFieldReq"].ToString());
                    evalList.Add(Convert.ToDouble(GNewProjectreader16["fieldEvaluation"]));
                }

            }

            connection.Close();
            /*foreach(int eval in evalList)
            {
                Console.WriteLine(eval);
            }*/
            
           
            //StringBuilder sbOutput = new StringBuilder();

            List<string> csvHeader = fieldList;




            for (int i = 0; i < csvHeader.Count; i++)
            { 
                if (i == 0)
                {
                    sbOutput.Append("  ; ");
                    sbOutput.Append(csvHeader[0] + "; ");
                    
                }
                else
                {
                    sbOutput.Append(csvHeader[i] + "; ");
                }
            }
            //sbOutput.AppendLine();

            // Create and write the csv file
            //File.WriteAllText(strFilePath, sbOutput.ToString());

            // To append more lines to the csv file
            //File.AppendAllText(strFilePath, sbOutput.ToString());

            foreach (string field in fieldList)
            {
                if (field != "SM")
                {
                    count += 1;
                }
            }

            n = count;

            NUMBER_COMPARISON = (n * n - n) / 2;

            double[,] endlessMatrix = new double[studentsCount+1, n];
            valuesCSV = new int[studentsCount, n+1];
            double[,] a = new double[n, n];
            double[,] res = new double[n, n];
            String[] criteria = new String[n];
            double[] p = new double[NUMBER_COMPARISON];//used to hold the values of comparisons
            Console.WriteLine("Criteria: " + n + " Comparasions: " + NUMBER_COMPARISON + " evalList.Count: " + evalList.Count);
            //Console.WriteLine("Enter the criteria:");
            for (int i = 0; i < n; i++)
            {
                //Console.WriteLine("Criterion " + (i + 1) + ":");
                if (fieldList[i] != "SM")
                {
                    criteria[i] = fieldList[i];
                }

            }

            

            Console.WriteLine("Enter the comparison");
            int m = 0;
            double num = 0.0;
            double[] resultsCriteria = new double[n];
            //string write = "";
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    Console.WriteLine("Compare " + criteria[i] + " with " + criteria[j] + ":");
                    if (evalList[i] > evalList[j])
                    {
                        //Console.WriteLine(evalList[i] + " " + evalList[j]);
                        num = evalList[i] - evalList[j];
                        //Console.WriteLine(num);
                        if (num == Convert.ToDouble(1))
                        {
                            p[m] = 2.0;
                            Console.WriteLine(m);
                            m++;
                        }
                        else
                        {
                            p[m] = num;
                            Console.WriteLine(m);
                            m++;
                        }


                    }
                    else if (evalList[i] < evalList[j])
                    {
                        num = evalList[j] - evalList[i];
                        Console.WriteLine(num);
                        if (num == Convert.ToDouble(1))
                        {
                            p[m] = (double)1 / (double)2;
                            Console.WriteLine(p[m]);
                            m++;
                        }
                        else
                        {
                            p[m] = (double)1 / (double)num;
                            Console.WriteLine(m);
                            m++;
                        }
                    }
                    else
                    {
                        p[m] = 1.0;
                        Console.WriteLine(m);
                        m++;
                    }
                    //write = Console.ReadLine();
                    //p[m] = Convert.ToDouble(write);
                    //m++;
                }
            }
            foreach (double p1 in p)
            {
                Console.WriteLine(p1);
            }

            a = ahp.initialize_matrix(p, n);
            resultsCriteria = ahp.show_matrix(a, n);

            for(int i = 0; i < n; i++)
            {
                endlessMatrix[0, i] = resultsCriteria[i];
            }

            

            evalList.Clear();
            List<string> nameList = new List<string>();
            int countNames = 0;

            connection.Open();
            String GNewProject17 = "SELECT studentId FROM Students WHERE projectId = ('" + projectId + "') ";
            SqlCommand GNewProjectcommand17 = new SqlCommand(GNewProject17, connection);
            SqlDataReader GNewProjectreader17 = GNewProjectcommand17.ExecuteReader();

            while (GNewProjectreader17.Read())
            {
                nameList.Add(GNewProjectreader17["studentId"].ToString());
            }

            connection.Close();

            foreach(string id in nameList)
            {
                Console.WriteLine(id);
            }

            
            foreach (string field in nameList)
            {
                if (field != "SM")
                {
                    countNames += 1;
                }
            }

            for (int i = 0; i < count; i++)
            {
                if (fieldList[i] != "SM")
                {

                    for(int o = 0; o < nameList.Count; o++ )
                    {
                        connection.Open();
                        Console.WriteLine(nameList[o] + " " + fieldList[i]);
                        String GNewProject18 = "SELECT evaluationLang FROM Languages WHERE studentId = ('" + nameList[o] + "') AND langName = ('" + fieldList[i] + "')";
                        SqlCommand GNewProjectcommand18 = new SqlCommand(GNewProject18, connection);
                        SqlDataReader GNewProjectreader18 = GNewProjectcommand18.ExecuteReader();

                        while (GNewProjectreader18.Read())
                        {
                            evalList.Add(Convert.ToDouble(GNewProjectreader18["evaluationLang"]));
                        }

                        connection.Close();
                    }

                    //evalList.ForEach(Console.WriteLine);
                    n = countNames;
                    //nameList.ForEach(Console.WriteLine);
                    int NUMBER_COMPARISON1 = (n * n - n) / 2;
                    //Console.WriteLine(NUMBER_COMPARISON1);

                    foreach (string id in nameList)
                    {
                        Console.WriteLine(id);
                    }

                    double[] results = new double[n];
                    double[,] a1 = new double[n, n];
                    double[,] res1 = new double[n, n];
                    String[] criteria1 = new String[n];
                    double[] p1 = new double[NUMBER_COMPARISON1];//used to hold the values of comparisons

                    //Console.WriteLine("Enter the criteria:");
                    for (int l = 0; l < n; l++)
                    {
                        
                        criteria1[l] = nameList[l];
                        

                    }

                    Console.WriteLine("Criteria: " + n + " Comparasions: " + NUMBER_COMPARISON1 + " evalList.Count: " + evalList.Count);

                    Console.WriteLine("Enter the comparison");
                    int m1 = 0;
                    double num1 = 0.0;
                    //string write = "";
                    for (int k = 0; k < evalList.Count; k++)
                    {
                        for (int j = k + 1; j < evalList.Count; j++)
                        {
                            Console.WriteLine("Compare " + criteria1[k] + " with " + criteria1[j] + ":");
                            //Console.WriteLine(evalList[k] + " " + evalList[j]);
                            if (evalList[k] > evalList[j])
                            {
                                //Console.WriteLine(evalList[k] + " " + evalList[j]);
                                num1 = evalList[k] - evalList[j];
                                //Console.WriteLine(num1);
                                if (num1 == Convert.ToDouble(1))
                                {
                                    p1[m1] = 2.0;
                                    Console.WriteLine(p1[m1]);
                                    m1++;
                                }
                                else if (num1 == Convert.ToDouble(10))
                                {
                                    p1[m1] = 9.0;
                                    Console.WriteLine(p1[m1]);
                                    m1++;
                                }
                                else if (num1 == Convert.ToDouble(0))
                                {
                                    p1[m1] = 1.0;
                                    Console.WriteLine(p1[m1]);
                                    m1++;
                                }
                                else
                                {
                                    p1[m1] = num1;
                                    Console.WriteLine(p1[m1]);
                                    m1++;
                                }
                            }
                            else if (evalList[k] < evalList[j])
                            {
                                num1 = evalList[j] - evalList[k];
                                //Console.WriteLine(num1);
                                if (num1 == Convert.ToDouble(1))
                                {
                                    p1[m1] = (double)1 / (double)2;
                                    Console.Write(1 / 2);
                                    Console.WriteLine(p1[m1]);
                                    m1++;
                                }
                                else if (num1 == Convert.ToDouble(10))
                                {
                                    p1[m1] = (double)1 / (double)9;
                                    Console.WriteLine(p1[m1]);
                                    m1++;
                                }
                                else if (num1 == Convert.ToDouble(0))
                                {
                                    p1[m1] = 1.0;
                                    Console.WriteLine(p1[m1]);
                                    m1++;
                                }
                                else
                                {
                                    p1[m1] = (double)1 / (double)num1;
                                    Console.WriteLine(p1[m1]);
                                    m1++;
                                }
                                //Console.WriteLine(m1);
                            }
                            else
                            {
                                p1[m1] = 1.0;
                                Console.WriteLine(p1[m1]);
                                m1++;
                            }
                            //write = Console.ReadLine();
                            //p[m] = Convert.ToDouble(write);
                            //m++;
                        }
                    }
                    foreach (double p2 in p1)
                    {
                        Console.WriteLine(p2);
                    }

                    a1 = ahp.initialize_matrix(p1, n);
                    results = ahp.show_matrix(a1, n);

                    for(int v = 1; v < studentsCount + 1; v++)
                    {
                        endlessMatrix[v, i] = results[v - 1];
                    }

                    
                                       


                    /*foreach (string id in nameList)
                    {
                        Console.WriteLine(id);
                    }*/

                    evalList.Clear();
                    //studentNames.Clear();
                }
            }

            double[] weights = new double[studentsCount];
            double weightFinal = 0.0;
            for(int i = 1; i < studentsCount + 1; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    //Console.WriteLine(endlessMatrix[i, j]);
                    
                       weightFinal += endlessMatrix[i, j] * endlessMatrix[0, j];
                                        
                }
                weights[i-1] = weightFinal;
                weightFinal = 0.0;
                Console.WriteLine();
            }

            Console.WriteLine();
            for(int i = 0; i < studentsCount; i++)
            {
                Console.WriteLine("Line" + i +  " : "); 
                Console.WriteLine(weights[i]);
            }
            List<string> studentNames = new List<string>();
            List<string> ids = new List<string>();

            nameList.ForEach((item) =>
            {
                ids.Add((string)item.Clone());
            });

            for (int o = 0; o < nameList.Count; o++)
            {
                connection.Open();
                String GNewProject177 = "SELECT studentName FROM Students WHERE studentId = ('" + ids[o] + "') ";
                SqlCommand GNewProjectcommand177 = new SqlCommand(GNewProject177, connection);
                SqlDataReader GNewProjectreader177 = GNewProjectcommand177.ExecuteReader();

                while (GNewProjectreader177.Read())
                {
                    studentNames.Add(GNewProjectreader177["studentName"].ToString());

                }

                connection.Close();
            }

            foreach (string name in studentNames)
            {
                //Console.WriteLine(name);
            }

            double[] rest = (double[])weights.Clone();
            int t;
            string at, pr;
            double atual;
            for (int o = 1; o < rest.Length; o++)
            {
                atual = rest[o];
                at = studentNames[o];
                pr = ids[o];
                t = o;
                while ((t > 0) && (rest[t - 1] < atual))
                {
                    rest[t] = rest[t - 1];
                    studentNames[t] = studentNames[t - 1];
                    ids[t] = ids[t - 1];
                    t = t - 1;
                }
                rest[t] = atual;
                studentNames[t] = at;
                ids[t] = pr;
            }

            foreach(double v in rest)
            {
                Console.WriteLine(v);
            }

            int countId = 0;
            int lengthCode = ids.Count / 3 * 2;
            Console.WriteLine(lengthCode);
            foreach (string id in ids)
            {
                if (countId < lengthCode)
                {
                    codeList.Add(id);
                    countId++;
                }
            }


            foreach (string name in studentNames)
            {
                Console.WriteLine(name);
            }

            List<string> noDuplicatesList = codeList.Distinct().ToList();

            /*for (int o = 0; o < codeList.Count; o++)
            {
                Console.WriteLine(codeList[o]);
                for (int k = o + 1; k < codeList.Count; k++)
                {
                    
                    if (codeList[o] == codeList[k])
                    {
                        codeList.RemoveAt(k);
                    }
                }
            }*/

            List<string> selectedNames = new List<string>();
            List<string> areasSelected = new List<string>();
            for (int o = 0; o < noDuplicatesList.Count; o++)
            {
                connection.Open();
                String GNewProject177 = "SELECT studentName, studyField FROM Students WHERE studentId = ('" + noDuplicatesList[o] + "') ";
                SqlCommand GNewProjectcommand177 = new SqlCommand(GNewProject177, connection);
                SqlDataReader GNewProjectreader177 = GNewProjectcommand177.ExecuteReader();

                while (GNewProjectreader177.Read())
                {
                    selectedNames.Add(GNewProjectreader177["studentName"].ToString());
                    areasSelected.Add(GNewProjectreader177["studyField"].ToString());
                    //Console.WriteLine(selectedNames.Count);
                }

                connection.Close();
            }


            int[,] secValuesCsv = new int[studentsCount, n];
            for (int o = 0; o < noDuplicatesList.Count; o++)
            {
                for (int k = 0; k < fieldList.Count; k++)
                {
                    connection.Open();
                    String GNewProject187 = "SELECT evaluationLang FROM languages WHERE studentId = ('" + noDuplicatesList[o] + "') AND langName = ('" + fieldList[k] + "') ";
                    SqlCommand GNewProjectcommand187 = new SqlCommand(GNewProject187, connection);
                    SqlDataReader GNewProjectreader187 = GNewProjectcommand187.ExecuteReader();

                    while (GNewProjectreader187.Read())
                    {
                        secValuesCsv[o, k] = GNewProjectreader187.GetInt32(0);
                        //Console.WriteLine(GNewProjectreader187.GetInt32(0));
                    }

                    connection.Close();
                }
            }

            for(int i = 0; i < studentsCount; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write(secValuesCsv[i, j]);
                }
                Console.WriteLine();
            }


            for (int o = 0; o < noDuplicatesList.Count; o++)
            {
                //sbOutput2.Append("  ; ");
                sbOutput2.AppendLine();
                sbOutput2.Append(selectedNames[o] + "; ");
                for (int k = 0; k < fieldList.Count; k++)
                {
                    sbOutput2.Append(secValuesCsv[o, k] + "; ");
                }
                //sbOutput.AppendLine();
            }
            List<MyGridValues> list = new List<MyGridValues>();
            int jk = 0;
            foreach (string name in selectedNames)
            {
                list.Add(new MyGridValues { Name = name, Area = areasSelected[jk] });
                jk++;
            }

            dataGridView1.DataSource = list;
            
            //File.AppendAllText(strFilePath, sbOutput2.ToString());
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            label3.Visible = true;
            if (textBox1.Text != "")
            {
                string strFilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads\" + textBox1.Text + ".csv";
                File.WriteAllText(strFilePath, sbOutput.ToString());
                File.AppendAllText(strFilePath, sbOutput2.ToString());
                MessageBox.Show("Project has been exported at Downloads folder " + textBox1.Text + ".csv", "Edit Project Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
    }
}

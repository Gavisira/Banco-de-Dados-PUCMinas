using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;



namespace Banco
{
    public partial class Form1 : Form
    {
        public static int tipo = 1;
        public static string dados = "server=localhost;user id=root;database=new_schema;password=14fev1997";
        public static MySqlCommand cmd;
        public static int idProf = 15;
        public static int idMat = 15;
        public static int idCurso = 3;



        public Form1()
        {
            InitializeComponent();

        }





        private void Form1_Load(object sender, EventArgs e)
        {
            this.labelSal.Visible = true;
            this.textSal.Visible = true;
            this.labelDds.Visible = false;
            this.boxDds.Visible = false;
            this.labelHorario.Visible = false;
            this.boxHorario.Visible = false;
            this.labelId.Visible = false;
            this.boxIdRes.Visible = false;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (tipo)
            {
                case 1:
                    using (MySqlConnection con = new MySqlConnection(dados))
                    {
                        using (MySqlCommand cmd = new MySqlCommand("INSERT INTO Prof VALUES(" + idProf + ",'" + boxNome.Text + "'," + textSal.Text + ");", con))
                        {
                            con.Open();
                            MySqlDataReader reader = cmd.ExecuteReader();
                            MessageBox.Show("Dados Adicionados com sucesso");
                            con.Close();
                            break;
                        }
                    }
                case 2:
                    using (MySqlConnection con = new MySqlConnection(dados))
                    {
                        using (MySqlCommand cmd = new MySqlCommand("INSERT INTO Mat VALUES(" + idMat + ",'" + boxDds.Text + "'," + boxHorario.Text + ",'" + boxNome.Text + "'," + boxIdRes.Text + ");", con))
                        {
                            con.Open();
                            MySqlDataReader reader = cmd.ExecuteReader();
                            MessageBox.Show("Dados Adicionados com sucesso");
                            con.Close();
                            break;
                        }
                    }
                case 3:
                    using (MySqlConnection con = new MySqlConnection(dados))
                    {
                        using (MySqlCommand cmd = new MySqlCommand("INSERT INTO Curso VALUES(" + idCurso + ",'" + boxNome.Text + "');", con))
                        {
                            con.Open();
                            MySqlDataReader reader = cmd.ExecuteReader();
                            MessageBox.Show("Dados Adicionados com sucesso");
                            con.Close();
                            break;
                        }
                    }





            }




        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.labelSal.Visible = true;
            this.textSal.Visible = true;
            this.labelDds.Visible = false;
            this.boxDds.Visible = false;
            this.labelHorario.Visible = false;
            this.boxHorario.Visible = false;
            this.labelId.Visible = false;
            this.boxIdRes.Visible = false;
            tipo = 1;
        }

        private void radioMateria_CheckedChanged(object sender, EventArgs e)
        {
            this.labelDds.Visible = true;
            this.boxDds.Visible = true;
            this.labelHorario.Visible = true;
            this.boxHorario.Visible = true;
            this.labelId.Visible = true;
            this.boxIdRes.Visible = true;
            this.labelSal.Visible = false;
            this.textSal.Visible = false;
            tipo = 2;
        }

        private void radioCurso_CheckedChanged(object sender, EventArgs e)
        {
            this.labelDds.Visible = false;
            this.boxDds.Visible = false;
            this.labelHorario.Visible = false;
            this.boxHorario.Visible = false;
            this.labelId.Visible = false;
            this.boxIdRes.Visible = false;
            this.labelSal.Visible = false;
            this.textSal.Visible = false;
            tipo = 3;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonConsultaTodos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = PegarDados(tipo);
        }

        private DataTable PegarDados(int valor)
        {


            DataTable nova = new DataTable();
            string command;
            switch (valor)
            {
                case 1:
                    command = "SELECT * FROM Prof";
                    break;

                case 2:
                    command = "SELECT * FROM Mat";
                    break;
                case 3:
                    command = "SELECT * FROM Curso";
                    break;
                default:
                    command = "";
                    break;
            }

            using (MySqlConnection con = new MySqlConnection(dados))
            {
                using (MySqlCommand cmd = new MySqlCommand(command + " ORDER BY 1", con))
                {
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    nova.Load(reader);
                    con.Close();
                }
            }


            return nova;
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {

            switch (tipo)
            {
                case 1:
                    using (MySqlConnection con = new MySqlConnection(dados))
                    {
                        using (MySqlCommand cmd = new MySqlCommand("DELETE FROM Prof WHERE Prof.Matricula =" + textId.Text + ";", con))
                        {
                            con.Open();
                            MySqlDataReader reader = cmd.ExecuteReader();
                            MessageBox.Show("Deletado com Sucesso");
                            con.Close();
                            break;
                        }
                    }
                case 2:
                    using (MySqlConnection con = new MySqlConnection(dados))
                    {
                        using (MySqlCommand cmd = new MySqlCommand("DELETE FROM Mat WHERE Mat.IdMat = " + textId.Text + ";", con))
                        {
                            con.Open();
                            MySqlDataReader reader = cmd.ExecuteReader();
                            MessageBox.Show("Deletado com Sucesso");
                            con.Close();
                            break;
                        }
                    }
                case 3:
                    using (MySqlConnection con = new MySqlConnection(dados))
                    {
                        using (MySqlCommand cmd = new MySqlCommand("DELETE FROM Curso WHERE Curso.IdDisc = " + textId.Text + ";", con))
                        {
                            con.Open();
                            MySqlDataReader reader = cmd.ExecuteReader();
                            MessageBox.Show("Deletado com Sucesso");
                            con.Close();
                            break;
                        }
                    }
            }
        }

        private void buttonConsulta_Click(object sender, EventArgs e)
        {
            DataTable nova = new DataTable();
            switch (tipo)
            {
                case 1:
                    using (MySqlConnection con = new MySqlConnection(dados))
                    {
                        using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Prof WHERE Prof.Matricula =" + textId.Text + ";", con))
                        {
                            con.Open();
                            MySqlDataReader reader = cmd.ExecuteReader();
                            nova.Load(reader);
                            dataGridView1.DataSource = nova;
                            con.Close();
                            break;
                        }
                    }
                case 2:
                    using (MySqlConnection con = new MySqlConnection(dados))
                    {
                        using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Mat WHERE Mat.IdMat = " + textId.Text + ";", con))
                        {
                            con.Open();
                            MySqlDataReader reader = cmd.ExecuteReader();
                            nova.Load(reader);
                            dataGridView1.DataSource = nova;
                            con.Close();
                            break;
                        }
                    }
                case 3:
                    using (MySqlConnection con = new MySqlConnection(dados))
                    {
                        using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Curso WHERE Curso.IdDisc = " + textId.Text + ";", con))
                        {
                            con.Open();
                            MySqlDataReader reader = cmd.ExecuteReader();
                            nova.Load(reader);
                            dataGridView1.DataSource = nova;
                            con.Close();
                            break;
                        }
                    }
            }
        }
} }


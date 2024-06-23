using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace FilmotecaNovo
{
    public partial class Registro : Form
    {
        Filmoteca filmoteca;

        public Registro(Filmoteca _filmoteca)
        {
            InitializeComponent();

            filmoteca = _filmoteca;

           
        }
        private void LimparForm()
        {
            txConsultar.Clear();

            txTitulo.Clear();
            txNacionalidade.Clear();
            txFormato.Clear();
            txGenero.Clear();
            txAvaliacao.Clear();
            txDiretor.Clear();

            dtLanc.Value = DateTime.Now;

            cbGenero.Text = "";
            cbAvaliacao.Text = "";
            cbDiretor.Text = "";
            cbFormato.Text = "";
           
        }

        private void Registro_FormClosing(object sender, FormClosingEventArgs e)
        {
            filmoteca.btCinema.Visible = true;
            filmoteca.btPipoca.Visible = true;
            filmoteca.pictureBox1.Visible = true;
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'filmotecaDataSet.Avaliacoes' table. You can move, or remove it, as needed.
            this.avaliacoesTableAdapter.Fill(this.filmotecaDataSet.Avaliacoes);
            // TODO: This line of code loads data into the 'filmotecaDataSet.Tipos' table. You can move, or remove it, as needed.
            this.tiposTableAdapter.Fill(this.filmotecaDataSet.Tipos);
            // TODO: This line of code loads data into the 'filmotecaDataSet.Diretores' table. You can move, or remove it, as needed.
            this.diretoresTableAdapter.Fill(this.filmotecaDataSet.Diretores);
            // TODO: This line of code loads data into the 'filmotecaDataSet.Midias' table. You can move, or remove it, as needed.
            this.midiasTableAdapter.Fill(this.filmotecaDataSet.Midias);
            // TODO: This line of code loads data into the 'filmotecaDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.filmotecaDataSet.Generos);

            LimparForm();

        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            SqlCommand comm = null;
            bool bOK = true;

            // Prepara a string de conexão com o banco de dados
            string connectionString = Properties.Settings.Default.FilmotecaConnectionString;

            //  Criar uma conexão com o banco de dados
            conn = new SqlConnection(connectionString);

            // Criar o comando SQL para inserção dos dados na tabela Tipos
            comm = new SqlCommand(
                "INSERT INTO Midias (Título, Data_Lancamento, Nacionalidade, ID_Genero, " +
                "ID_Diretor, ID_Avaliacao, ID_Tipo) " +
                "VALUES (@Título, @Data_Lancamento, @Nacionalidade, @IDG, @IDD, @IDA, @IDT)", conn);

            comm.Parameters.Add("@Título", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Título"].Value = txTitulo.Text;

            comm.Parameters.Add("@Data_Lancamento", System.Data.SqlDbType.Date);
            comm.Parameters["@Data_Lancamento"].Value = dtLanc.Value.ToShortDateString();

            comm.Parameters.Add("@Nacionalidade", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Nacionalidade"].Value = txNacionalidade.Text;

            comm.Parameters.Add("@IDG", System.Data.SqlDbType.Int);
            comm.Parameters["@IDG"].Value = Convert.ToInt32(txGenero.Text);

            comm.Parameters.Add("@IDD", System.Data.SqlDbType.Int);
            comm.Parameters["@IDD"].Value = Convert.ToInt32(txDiretor.Text);

            comm.Parameters.Add("@IDA", System.Data.SqlDbType.Int);
            comm.Parameters["@IDA"].Value = Convert.ToInt32(txAvaliacao.Text);

            comm.Parameters.Add("@IDT", System.Data.SqlDbType.Int);
            comm.Parameters["@IDT"].Value = Convert.ToInt32(txFormato.Text);

            try
            {
                // Tenta abrir uma conexão com o BD
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {
                    bOK = false;

                    MessageBox.Show(error.Message,
                        "Erro ao tentar abrir uma conexão com o Banco de Dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                // Tenta executar o comando SQL
                try
                {
                    comm.ExecuteNonQuery();
                }
                catch (Exception error)
                {
                    bOK = false;

                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch { }
            finally
            {
                conn.Close(); // Fecha a conexão com o BD
            }

            if (bOK == true)
            {
                MessageBox.Show("Mídia Cadastrada!",
                        "INSERT",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                //Limpar o Form
                LimparForm();
                //Atualiza o Grid
                this.midiasTableAdapter.Fill(this.filmotecaDataSet.Midias);
            }
        }

        private void btPipoca_Click(object sender, EventArgs e)
        {
            if (txConsultar.Text == "")
            {
                MessageBox.Show("Digite a mídia que deseja pesquisar!",
                            "CONSULTAR",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }
            else
            {
                SqlConnection conn = null;
                SqlCommand comm = null;
                SqlDataReader reader = null;
                bool bOK = true;

                // Prepara a string de conexão com o banco de dados
                string connectionString = Properties.Settings.Default.FilmotecaConnectionString;

                //  Criar uma conexão com o banco de dados
                conn = new SqlConnection(connectionString);

                // Criar o comando SQL para pesquisa dos dados na tabela Tipos
                comm = new SqlCommand(
                   "SELECT Midias.Título, Midias.Data_Lancamento, Midias.Nacionalidade, Midias.ID_Genero, " +
                   "Midias.ID_Diretor, Midias.ID_Avaliacao, Midias.ID_Tipo, Generos.Nome_Genero, " +
                   "Diretores.Nome_Diretor, Avaliacoes.Descricao, Tipos.Nome_Tipo " +
                   "FROM Midias " +
                   "INNER JOIN Generos ON Midias.ID_Genero = Generos.ID_Genero " +
                   "INNER JOIN Diretores ON Midias.ID_Diretor = Diretores.ID_Diretor " +
                   "INNER JOIN Avaliacoes ON Midias.ID_Avaliacao = Avaliacoes.ID_Avaliacao " +
                   "INNER JOIN Tipos ON Midias.ID_Tipo = Tipos.ID_Tipo " +
                   "AND Midias.Título = @Titulo", conn);

                comm.Parameters.Add("@Titulo", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@Titulo"].Value = txConsultar.Text;


                try
                {
                    // Tenta abrir uma conexão com o BD
                    try
                    {
                        conn.Open();
                    }
                    catch (Exception error)
                    {
                        bOK = false;

                        MessageBox.Show(error.Message,
                            "Erro ao tentar abrir uma conexão com o Banco de Dados",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                    // Tenta executar o comando SQL
                    try
                    {
                        reader = comm.ExecuteReader();

                        if (reader.Read())
                        {
                            MessageBox.Show("Essa mídia já está cadastrada!",
                            "SELECT",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                            
                            dtLanc.Value = Convert.ToDateTime(reader["Data_Lancamento"].ToString());
                            cbDiretor.Text = reader["Nome_Diretor"].ToString();
                            cbFormato.Text = reader["Nome_Tipo"].ToString();
                            txNacionalidade.Text = reader["Nacionalidade"].ToString();
                            cbGenero.Text = reader["Nome_Genero"].ToString();
                            txTitulo.Text = reader["Título"].ToString();
                            cbAvaliacao.Text = reader["Descricao"].ToString();
                            txAvaliacao.Text = reader["ID_Avaliacao"].ToString();
                            txDiretor.Text = reader["ID_Diretor"].ToString();
                            txFormato.Text = reader["ID_Tipo"].ToString();
                            txGenero.Text = reader["ID_Genero"].ToString();

                        }
                        else
                        {
                            MessageBox.Show("Mídia não Cadastrada!",
                            "SELECT",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                            //Limpar o Form
                            LimparForm();
                        }

                        reader.Close();
                    }
                    catch (Exception error)
                    {
                        bOK = false;

                        MessageBox.Show(error.Message,
                            "Erro ao tentar executar o comando SQL",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                catch { }
                finally
                {
                    conn.Close(); // Fecha a conexão com o BD
                }
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            LimparForm();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            SqlCommand comm = null;
            bool bOK = true;

            // Prepara a string de conexão com o banco de dados
            string connectionString = Properties.Settings.Default.FilmotecaConnectionString;

            //  Criar uma conexão com o banco de dados
            conn = new SqlConnection(connectionString);

            // Criar o comando SQL para inserção dos dados na tabela Clientes
            comm = new SqlCommand(
                "UPDATE Midias SET Título=@Titulo, Data_Lancamento=@Data_Lancamento, " +
                "Nacionalidade=@Nacionalidade, ID_Genero=@IDG, ID_Diretor=@IDD, " +
                "ID_Avaliacao=@IDA, ID_Tipo=@IDt " +
                "WHERE Título = @NomeTipoAlt", conn);

            comm.Parameters.Add("@NomeTipoAlt", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@NomeTipoAlt"].Value = txConsultar.Text;

            comm.Parameters.Add("@Titulo", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Titulo"].Value = txTitulo.Text;

            comm.Parameters.Add("@Data_Lancamento", System.Data.SqlDbType.Date);
            comm.Parameters["@Data_Lancamento"].Value = dtLanc.Value.ToShortDateString();

            comm.Parameters.Add("@Nacionalidade", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Nacionalidade"].Value = txNacionalidade.Text;

            comm.Parameters.Add("@IDG", System.Data.SqlDbType.Int);
            comm.Parameters["@IDG"].Value = Convert.ToInt32(txGenero.Text);

            comm.Parameters.Add("@IDD", System.Data.SqlDbType.Int);
            comm.Parameters["@IDD"].Value = Convert.ToInt32(txDiretor.Text);

            comm.Parameters.Add("@IDA", System.Data.SqlDbType.Int);
            comm.Parameters["@IDA"].Value = Convert.ToInt32(txAvaliacao.Text);

            comm.Parameters.Add("@IDT", System.Data.SqlDbType.Int);
            comm.Parameters["@IDT"].Value = Convert.ToInt32(txFormato.Text);

            try
            {
                // Tenta abrir uma conexão com o BD
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {
                    bOK = false;

                    MessageBox.Show(error.Message,
                        "Erro ao tentar abrir uma conexão com o Banco de Dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                // Tenta executar o comando SQL
                try
                {
                    comm.ExecuteNonQuery();
                }
                catch (Exception error)
                {
                    bOK = false;

                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch { }
            finally
            {
                conn.Close(); // Fecha a conexão com o BD
            }

            if (bOK == true)
            {
                MessageBox.Show("Mídia Alterada com sucesso!",
                        "UPDATE",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                //Limpar o Form
                LimparForm();
                //Atualiza o Grid
                this.midiasTableAdapter.Fill(this.filmotecaDataSet.Midias);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            SqlCommand comm = null;
            bool bOK = true;

            // Prepara a string de conexão com o banco de dados
            string connectionString = Properties.Settings.Default.FilmotecaConnectionString;

            //  Criar uma conexão com o banco de dados
            conn = new SqlConnection(connectionString);

            // Criar o comando SQL para inserção dos dados na tabela Clientes
            comm = new SqlCommand(
                "DELETE FROM Midias WHERE Título = @NomeTipoExc", conn);

            comm.Parameters.Add("@NomeTipoExc", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@NomeTipoExc"].Value = txConsultar.Text;

            try
            {
                // Tenta abrir uma conexão com o BD
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {
                    bOK = false;

                    MessageBox.Show(error.Message,
                        "Erro ao tentar abrir uma conexão com o Banco de Dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                // Tenta executar o comando SQL
                try
                {
                    comm.ExecuteNonQuery();

                }
                catch (Exception error)
                {
                    bOK = false;

                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch { }
            finally
            {
                conn.Close(); // Fecha a conexão com o BD

                if (bOK == true)
                {
                    MessageBox.Show("Mídia Excluída!",
                            "DELETE",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    //Limpar o Form
                    LimparForm();
                    //Atualiza o Grid
                    this.midiasTableAdapter.Fill(this.filmotecaDataSet.Midias);
                }
            }
        }
    }
}

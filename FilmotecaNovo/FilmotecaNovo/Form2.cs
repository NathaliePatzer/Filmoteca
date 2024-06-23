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
    public partial class Cadastro : Form
    {
        Filmoteca filmoteca;

        public Cadastro(Filmoteca _filmoteca)
        {
            InitializeComponent();

            filmoteca = _filmoteca;
        }
        private void LimparForm()
        {
            txNomeTipo.Clear();
            txPesqMidia.Clear();
            txNomeDiretor.Clear();
            txPesqDir.Clear();
            txNomeGenero.Clear();
            txPesqGen.Clear();
        }

        private void Cadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            filmoteca.btCinema.Visible = true;
            filmoteca.btPipoca.Visible = true;
            filmoteca.pictureBox1.Visible = true;
        }

        // INICIO MIDIA

        private void btAdMidia_Click(object sender, EventArgs e)
        {
            //VERIFICACAO
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
               "SELECT Tipos.Nome_Tipo " +
               "FROM Tipos " +
               "WHERE Nome_Tipo = @NomeTipo", conn);

            comm.Parameters.Add("@NomeTipo", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@NomeTipo"].Value = txNomeTipo.Text;

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
                        MessageBox.Show("Essa mídia já está cadastrada, por favor, escolha outro nome!",
                        "SELECT",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        LimparForm();

                    }
                    else
                    {
                        //ADICIONAR
                        
                        //  Criar uma conexão com o banco de dados
                        conn = new SqlConnection(connectionString);

                        // Criar o comando SQL para inserção dos dados na tabela Tipos
                        comm = new SqlCommand(
                            "INSERT INTO Tipos (Nome_Tipo) " +
                            "VALUES (@NomeTipo)", conn);

                        comm.Parameters.Add("@NomeTipo", System.Data.SqlDbType.NVarChar);
                        comm.Parameters["@NomeTipo"].Value = txNomeTipo.Text;

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
                        }
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
      
        private void btCons_Click(object sender, EventArgs e)
        {
            if (txPesqMidia.Text == "")
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
                   "SELECT Tipos.Nome_Tipo " +
                   "FROM Tipos " +
                   "WHERE Nome_Tipo = @NomeTipo", conn);

                comm.Parameters.Add("@NomeTipo", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@NomeTipo"].Value = txPesqMidia.Text;

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

                            txNomeTipo.Text = reader["Nome_Tipo"].ToString();

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

        private void btAltMidia_Click(object sender, EventArgs e)
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
                "UPDATE Tipos SET Nome_Tipo=@NomeTipo " +
                "WHERE Nome_Tipo = @NomeTipoAlt", conn);

            comm.Parameters.Add("@NomeTipo", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@NomeTipo"].Value = txNomeTipo.Text;

            comm.Parameters.Add("@NomeTipoAlt", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@NomeTipoAlt"].Value = txPesqMidia.Text;

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
            }
        }

        private void btExcMidia_Click(object sender, EventArgs e)
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
                "DELETE FROM Tipos WHERE Nome_Tipo = @NomeTipoExc", conn);

            comm.Parameters.Add("@NomeTipoExc", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@NomeTipoExc"].Value = txPesqMidia.Text;

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
                }
            }
        }

        // FIM MIDIA

        // INICIO GENERO

        private void btAdGenero_Click(object sender, EventArgs e)
        {
            //VERIFICACAO
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
               "SELECT Generos.Nome_Genero " +
               "FROM Generos " +
               "WHERE Nome_Genero = @NomeGenero", conn);

            comm.Parameters.Add("@NomeGenero", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@NomeGenero"].Value = txNomeGenero.Text;

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
                        MessageBox.Show("Esse gênero já está cadastrado, por favor, escolha outro nome!",
                        "SELECT",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        LimparForm();

                    }
                    else
                    {
                        //ADICIONAR                     

                        //  Criar uma conexão com o banco de dados
                        conn = new SqlConnection(connectionString);

                        // Criar o comando SQL para inserção dos dados na tabela Tipos
                        comm = new SqlCommand(
                            "INSERT INTO Generos (Nome_Genero) " +
                            "VALUES (@NomeGenero)", conn);

                        comm.Parameters.Add("@NomeGenero", System.Data.SqlDbType.NVarChar);
                        comm.Parameters["@NomeGenero"].Value = txNomeGenero.Text;

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
                            MessageBox.Show("Gênero Cadastrado!",
                                    "INSERT",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                            //Limpar o Form
                            LimparForm();
                        }
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

        private void btConsG_Click(object sender, EventArgs e)
        {
            if (txPesqGen.Text == "")
            {
                MessageBox.Show("Digite o gênero que deseja pesquisar!",
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
                   "SELECT Generos.Nome_Genero " +
                   "FROM Generos " +
                   "WHERE Nome_Genero = @NomeGenero", conn);

                comm.Parameters.Add("@NomeGenero", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@NomeGenero"].Value = txPesqGen.Text;

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
                            MessageBox.Show("Esse gênero já está cadastrado!",
                            "SELECT",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                            txNomeGenero.Text = reader["Nome_Genero"].ToString();

                        }
                        else
                        {
                            MessageBox.Show("Gênero não Cadastrado!",
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

        private void btAltGenero_Click(object sender, EventArgs e)
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
                "UPDATE Generos SET Nome_Genero=@NomeGenero " +
                "WHERE Nome_Genero = @NomeGeneroAlt", conn);

            comm.Parameters.Add("@NomeGenero", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@NomeGenero"].Value = txNomeGenero.Text;

            comm.Parameters.Add("@NomeGeneroAlt", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@NomeGeneroAlt"].Value = txPesqGen.Text;

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
                MessageBox.Show("Gênero Alterado com sucesso!",
                        "UPDATE",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                //Limpar o Form
                LimparForm();
            }
        }

        private void btExcGenero_Click(object sender, EventArgs e)
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
                "DELETE FROM Generos WHERE Nome_Genero = @NomeGeneroExc", conn);

            comm.Parameters.Add("@NomeGeneroExc", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@NomeGeneroExc"].Value = txPesqGen.Text;

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
                    MessageBox.Show("Gênero Excluído!",
                            "DELETE",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    //Limpar o Form
                    LimparForm();
                }
            }
        }

        // FIM GENERO

        // INICIO DIRETOR

        private void btAdDiretor_Click(object sender, EventArgs e)
        {
            //VERIFICACAO
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
               "SELECT Diretores.Nome_Diretor " +
               "FROM Diretores " +
               "WHERE Nome_Diretor = @NomeDiretor", conn);

            comm.Parameters.Add("@NomeDiretor", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@NomeDiretor"].Value = txNomeDiretor.Text;

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
                        MessageBox.Show("Esse diretor já está cadastrado, por favor, escolha outro nome!",
                        "SELECT",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        LimparForm();

                    }
                    else
                    {
                        //ADICIONAR
                        
                        //  Criar uma conexão com o banco de dados
                        conn = new SqlConnection(connectionString);

                        // Criar o comando SQL para inserção dos dados na tabela Tipos
                        comm = new SqlCommand(
                            "INSERT INTO Diretores (Nome_Diretor) " +
                            "VALUES (@NomeDiretor)", conn);

                        comm.Parameters.Add("@NomeDiretor", System.Data.SqlDbType.NVarChar);
                        comm.Parameters["@NomeDiretor"].Value = txNomeDiretor.Text;

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
                            MessageBox.Show("Diretor Cadastrado!",
                                    "INSERT",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                            //Limpar o Form
                            LimparForm();
                        }
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
      
        private void btConsD_Click(object sender, EventArgs e)
        {
            if (txPesqDir.Text == "")
            {
                MessageBox.Show("Digite o diretor que deseja pesquisar!",
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
                   "SELECT Diretores.Nome_Diretor " +
                   "FROM Diretores " +
                   "WHERE Nome_Diretor = @NomeDiretor", conn);

                comm.Parameters.Add("@NomeDiretor", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@NomeDiretor"].Value = txPesqDir.Text;

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
                            MessageBox.Show("Esse diretor já está cadastrado!",
                            "SELECT",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                            txNomeDiretor.Text = reader["Nome_Diretor"].ToString();

                        }
                        else
                        {
                            MessageBox.Show("Diretor não Cadastrado!",
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

        private void btAltDiretor_Click(object sender, EventArgs e)
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
                "UPDATE Diretores SET Nome_Diretor=@NomeDiretor " +
                "WHERE Nome_Diretor = @NomeDiretorAlt", conn);

            comm.Parameters.Add("@NomeDiretor", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@NomeDiretor"].Value = txNomeDiretor.Text;

            comm.Parameters.Add("@NomeDiretorAlt", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@NomeDiretorAlt"].Value = txPesqDir.Text;

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
                MessageBox.Show("Diretor Alterado com sucesso!",
                        "UPDATE",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                //Limpar o Form
                LimparForm();
            }
        }

        private void btExcDiretor_Click(object sender, EventArgs e)
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
                "DELETE FROM Diretores WHERE Nome_Diretor = @NomeDiretorExc", conn);

            comm.Parameters.Add("@NomeDiretorExc", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@NomeDiretorExc"].Value = txPesqDir.Text;

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
                    MessageBox.Show("Diretor Excluído!",
                            "DELETE",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    //Limpar o Form
                    LimparForm();
                }
            }
        }

        // FIM DIRETOR

        private void btLimpar_Click(object sender, EventArgs e)
        {
            LimparForm();
        }
        
    }
}

    


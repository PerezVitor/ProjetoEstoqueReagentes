using System;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoPOO.Classes
{
    class ClsUsuario : AbsCrud
    {
        private int mID;
        private string mNome;
        private string mSenha;
        private string mEmail;
        private char mTipo;

        public string erro;

        public char Tipo { get => mTipo; set => mTipo = value; }
        public string Nome { get => mNome; set => mNome = value; }
        public string Senha { get => mSenha; set => mSenha = value; }
        public string Email { get => mEmail; set => mEmail = value; }
        public int ID { get => mID; set => mID = value; }

        public bool Autenticar()
        {
            ClsConexao conexao = new ClsConexao();
            SqlCommand sqlCommand = new SqlCommand();
            SqlDataReader dataReader;
            bool resposta = false;

            try
            {
                conexao.conectar();
                sqlCommand.CommandText = "SP_AUTENTICAR_USUARIO";
                sqlCommand.Connection = conexao.sqlConnection;
                sqlCommand.Parameters.AddWithValue("@DS_NOME", mNome);
                sqlCommand.Parameters.AddWithValue("@DS_SENHA", mSenha);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    mID = Convert.ToInt32(dataReader["ID_USUARIO"].ToString());
                    mTipo = char.Parse(dataReader["DS_TIPO"].ToString());
                    mEmail = dataReader["DS_EMAIL"].ToString();
                    resposta = true;
                }
                dataReader.Close();
                conexao.desconectar();
                return resposta;
            }
            catch (Exception e)
            {
                erro = e.Message;
                return resposta;
            }
        }

        public override bool Alterar()
        {
            ClsConexao conexao = new ClsConexao();
            SqlCommand sqlCommand = new SqlCommand();
            SqlDataReader dataReader;
            bool resposta = false;

            try
            {
                conexao.conectar();
                sqlCommand.CommandText = "SP_ALTERACAO_USUARIO";
                sqlCommand.Connection = conexao.sqlConnection;                
                sqlCommand.Parameters.AddWithValue("@ID_USUARIO", mID);
                sqlCommand.Parameters.AddWithValue("@DS_NOME", mNome);
                sqlCommand.Parameters.AddWithValue("@DS_SENHA", mSenha);
                sqlCommand.Parameters.AddWithValue("@DS_EMAIL", mEmail);
                sqlCommand.Parameters.AddWithValue("@DS_TIPO", mTipo);

                sqlCommand.CommandType = CommandType.StoredProcedure;
                dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    if (dataReader[0].ToString() != null)
                    {
                        resposta = true;
                    }
                }
                dataReader.Close();
                conexao.desconectar();
                return resposta;
            }
            catch (Exception e)
            {
                erro = e.Message;
                return resposta;
            }
        }

        public override bool Cadastrar()
        {
            ClsConexao conexao = new ClsConexao();
            SqlCommand sqlCommand = new SqlCommand();
            SqlDataReader dataReader;
            bool resposta = false;

            try
            {
                conexao.conectar();
                sqlCommand.CommandText = "SP_CADASTRO_USUARIO";
                sqlCommand.Connection = conexao.sqlConnection;
                sqlCommand.Parameters.AddWithValue("@DS_NOME", mNome);
                sqlCommand.Parameters.AddWithValue("@DS_SENHA", mSenha);
                sqlCommand.Parameters.AddWithValue("@DS_EMAIL", mEmail);
                sqlCommand.Parameters.AddWithValue("@DS_TIPO", mTipo);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                dataReader = sqlCommand.ExecuteReader();

                if (dataReader.Read())
                {
                    if (dataReader[0].ToString() != null)
                    {
                        resposta = true;
                    }
                }
                dataReader.Close();
                conexao.desconectar();
                return resposta;
            }
            catch (Exception e)
            {
                erro = e.Message;
                return false;
            }
        }

        public override DataSet Consultar()
        {
            ClsConexao conexao = new ClsConexao();
            SqlCommand sqlCommand = new SqlCommand();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();

            try
            {
                conexao.conectar();
                sqlCommand.CommandText = "SP_CONSULTA_USUARIOS";
                sqlCommand.Connection = conexao.sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@DS_NOME", mNome);
                dataAdapter.SelectCommand = sqlCommand;
                dataAdapter.Fill(dataSet);

                conexao.desconectar();
                return dataSet;
            }
            catch (Exception e)
            {
                erro = e.Message;
                return null;
            }
        }

        public override bool Excluir()
        {
            ClsConexao conexao = new ClsConexao();
            SqlCommand sqlCommand = new SqlCommand();
            SqlDataReader dataReader;
            bool resposta = false;
            try
            {
                conexao.conectar();
                sqlCommand.Connection = conexao.sqlConnection;
                sqlCommand.CommandText = "SP_EXCLUSAO_USUARIO";
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@ID_USUARIO", mID);
                dataReader = sqlCommand.ExecuteReader();
                if (dataReader.Read())
                {
                    if (dataReader[0].ToString() != null)
                    {
                        resposta = true;
                    }
                }

                conexao.desconectar();
                dataReader.Close();
                return resposta;
            }
            catch (Exception e)
            {
                erro = e.Message;
                return resposta;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOO.Classes
{
    class ClsEmprestimo : AbsCrud
    {
        private int mID;
        private int mID_Usuario;
        private int mID_Reagente;
        private double mPeso;

        public string erro;
        public string nomeReagente;

        public int ID { get => mID; set => mID = value; }
        public int ID_Usuario { get => mID_Usuario; set => mID_Usuario = value; }
        public int ID_Reagente { get => mID_Reagente; set => mID_Reagente = value; }
        public double Peso { get => mPeso; set => mPeso = value; }

        public override bool Alterar()
        {
            ClsConexao conexao = new ClsConexao();
            SqlCommand sqlCommand = new SqlCommand();
            SqlDataReader dataReader;
            bool resposta = false;

            try
            {
                conexao.conectar();
                sqlCommand.CommandText = "SP_ALTERACAO_EMPRESTIMO";
                sqlCommand.Connection = conexao.sqlConnection;
                sqlCommand.Parameters.AddWithValue("@ID_EMPRESTIMO", mID);
                sqlCommand.Parameters.AddWithValue("@ID_USUARIO", mID_Usuario);
                sqlCommand.Parameters.AddWithValue("@ID_REAGENTE", mID_Reagente);
                sqlCommand.Parameters.AddWithValue("@QT_PESO", mPeso);

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
                sqlCommand.CommandText = "SP_CADASTRO_EMPRESTIMO";
                sqlCommand.Connection = conexao.sqlConnection;
                sqlCommand.Parameters.AddWithValue("@ID_USUARIO", mID_Usuario);
                sqlCommand.Parameters.AddWithValue("@ID_REAGENTE", mID_Reagente);
                sqlCommand.Parameters.AddWithValue("@QT_PESO", mPeso);
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
                sqlCommand.CommandText = "SP_CONSULTA_EMPRESTIMO";
                sqlCommand.Connection = conexao.sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@NM_DESCRICAO", nomeReagente);
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
                sqlCommand.CommandText = "SP_EXCLUSAO_EMPRESTIMO";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@ID_EMPRESTIMO", mID);
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

        public bool EmprestimoReagente(ClsReagente reagente)
        {
            ClsConexao conexao = new ClsConexao();
            SqlCommand sqlCommand = new SqlCommand();
            SqlDataReader dataReader;
            bool resposta = false;

            try
            {
                conexao.conectar();
                sqlCommand.CommandText = "SP_EMPRESTIMO_REAGENTE";
                sqlCommand.Connection = conexao.sqlConnection;
                sqlCommand.Parameters.AddWithValue("@ID_REAGENTE", reagente.ID);
                sqlCommand.Parameters.AddWithValue("@QT_PESO", reagente.QuantidadePeso);

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

        public bool ExclusaoEmprestimo(ClsReagente reagente)
        {
            ClsConexao conexao = new ClsConexao();
            SqlCommand sqlCommand = new SqlCommand();
            SqlDataReader dataReader;
            bool resposta = false;

            try
            {
                conexao.conectar();
                sqlCommand.CommandText = "SP_EXCLUSAO_EMPRESTIMO_REAGENTE";
                sqlCommand.Connection = conexao.sqlConnection;
                sqlCommand.Parameters.AddWithValue("@ID_REAGENTE", reagente.ID);
                sqlCommand.Parameters.AddWithValue("@QT_PESO", reagente.QuantidadePeso);

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

        public DataSet Relatorio(DateTime inicio, DateTime fim)
        {
            ClsConexao conexao = new ClsConexao();
            SqlCommand sqlCommand = new SqlCommand();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();

            try
            {
                conexao.conectar();
                sqlCommand.CommandText = "SP_RELATORIO_EMPRESTIMO";
                sqlCommand.Connection = conexao.sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@DT_INICIO", inicio.Date);
                sqlCommand.Parameters.AddWithValue("@DT_FIM", fim.Date);
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

        public DataSet ConsultarEspecifico()
        {
            ClsConexao conexao = new ClsConexao();
            SqlCommand sqlCommand = new SqlCommand();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();

            try
            {
                conexao.conectar();
                sqlCommand.CommandText = "SP_CONSULTA_EMPRESTIMO_ESPECIFICO";
                sqlCommand.Connection = conexao.sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@ID_EMPRESTIMO", ID);
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
    }
}

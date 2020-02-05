using System;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoPOO.Classes
{
    class ClsReagente : AbsCrud
    {
        private int mID;
        private string mDescricao;
        private string mCodigoInterno;
        private string mNumeroCas;
        private double mQuantidadePeso;
        private string mUnidadeMedida;
        private string mObs;

        public string erro;

        public int ID { get => mID; set => mID = value; }
        public string Descricao { get => mDescricao; set => mDescricao = value; }
        public string CodigoInterno { get => mCodigoInterno; set => mCodigoInterno = value; }
        public string NumeroCas { get => mNumeroCas; set => mNumeroCas = value; }
        public double QuantidadePeso { get => mQuantidadePeso; set => mQuantidadePeso = value; }
        public string UnidadeMedida { get => mUnidadeMedida; set => mUnidadeMedida = value; }
        public string Obs { get => mObs; set => mObs = value; }

        public override bool Alterar()
        {
            ClsConexao conexao = new ClsConexao();
            SqlCommand sqlCommand = new SqlCommand();
            SqlDataReader dataReader;
            bool resposta = false;

            try
            {
                conexao.conectar();
                sqlCommand.CommandText = "SP_ALTERACAO_REAGENTE";
                sqlCommand.Connection = conexao.sqlConnection;
                sqlCommand.Parameters.AddWithValue("@ID_REAGENTE", mID);
                sqlCommand.Parameters.AddWithValue("@NM_DESCRICAO", mDescricao);
                sqlCommand.Parameters.AddWithValue("@CD_INTERNO", mCodigoInterno);
                sqlCommand.Parameters.AddWithValue("@NR_CAS", mNumeroCas);
                sqlCommand.Parameters.AddWithValue("@QT_PESO", mQuantidadePeso);
                sqlCommand.Parameters.AddWithValue("@UN_MEDIDA", mUnidadeMedida);
                sqlCommand.Parameters.AddWithValue("@DS_OBS", mObs);

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
                sqlCommand.CommandText = "SP_CADASTRO_REAGENTE";
                sqlCommand.Connection = conexao.sqlConnection;
                sqlCommand.Parameters.AddWithValue("@NM_DESCRICAO", mDescricao);
                sqlCommand.Parameters.AddWithValue("@CD_INTERNO", mCodigoInterno);
                sqlCommand.Parameters.AddWithValue("@NR_CAS", mNumeroCas);
                sqlCommand.Parameters.AddWithValue("@QT_PESO", mQuantidadePeso);
                sqlCommand.Parameters.AddWithValue("@UN_MEDIDA", mUnidadeMedida);
                sqlCommand.Parameters.AddWithValue("@DS_OBS", mObs);
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
                sqlCommand.CommandText = "SP_CONSULTA_REAGENTE";
                sqlCommand.Connection = conexao.sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@NM_DESCRICAO", mDescricao);
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
                sqlCommand.CommandText = "SP_EXCLUSAO_REAGENTE";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@ID_REAGENTE", mID);
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

        public DataSet Consultar(int ID)
        {
            ClsConexao conexao = new ClsConexao();
            SqlCommand sqlCommand = new SqlCommand();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();

            try
            {
                conexao.conectar();
                sqlCommand.CommandText = "SP_CONSULTA_REAGENTE_ESPECIFICO";
                sqlCommand.Connection = conexao.sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@ID_REAGENTE", ID);
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

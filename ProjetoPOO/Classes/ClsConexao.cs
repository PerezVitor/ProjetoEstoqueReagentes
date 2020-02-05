using System.Data.SqlClient;

namespace ProjetoPOO
{
    class ClsConexao
    {
        public SqlConnection sqlConnection = new SqlConnection();

        public void conectar()
        {
            sqlConnection.ConnectionString = Properties.Settings.Default.ConnectionString;
            sqlConnection.Open();
        }

        public void desconectar()
        {
            sqlConnection.Close();
        }
    }
}

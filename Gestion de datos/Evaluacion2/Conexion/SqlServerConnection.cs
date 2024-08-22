using System.Data.SqlClient;

namespace Evaluacion2.Conexion
{
    public class SqlServerConnection : IConnection
    {
        private SqlConnection _connection;
        private readonly string _connectionString;

        public SqlServerConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Connect()
        {
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
        }

        public void Disconnect()
        {
            _connection.Close();
        }
    }
}

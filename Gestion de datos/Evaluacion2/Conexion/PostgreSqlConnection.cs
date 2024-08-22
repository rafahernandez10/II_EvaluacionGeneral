using Npgsql;

namespace Evaluacion2.Conexion
{
    public class PostgreSqlConnection : IConnection
    {
        private NpgsqlConnection _connection;
        private readonly string _connectionString;

        public PostgreSqlConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Connect()
        {
            _connection = new NpgsqlConnection(_connectionString);
            _connection.Open();
        }

        public void Disconnect()
        {
            _connection.Close();
        }
    }
}

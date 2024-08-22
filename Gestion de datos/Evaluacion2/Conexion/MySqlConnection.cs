using MySql.Data.MySqlClient;

namespace Evaluacion2.Conexion
{
    public class MySqlDbConnection : IConnection
    {
        private MySqlConnection _connection;
        private readonly string _connectionString;

        public MySqlDbConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Connect()
        {
            _connection = new MySqlConnection(_connectionString);
            _connection.Open();
        }

        public void Disconnect()
        {
            _connection.Close();
        }
    }
}

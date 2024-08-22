namespace Evaluacion2.Conexion
{
    public enum DatabaseType
    {
        SqlServer,
        PostgreSql,
        MySql
    }

    public class ConnectionFactory
    {
        public static IConnection CreateConnection(DatabaseType dbType, string connectionString)
        {
            return dbType switch
            {
                DatabaseType.SqlServer => new SqlServerConnection(connectionString),
                DatabaseType.PostgreSql => new PostgreSqlConnection(connectionString),
                DatabaseType.MySql => new MySqlDbConnection(connectionString),
                _ => throw new ArgumentException("Invalid database type"),
            };
        }
    }
}

using Evaluacion2.Conexion;

namespace Evaluacion2.Data.Usuario
{
    public static class UsuarioRepositoryFactory
    {
        public static IUsuarioRepository CreateRepository(DatabaseType dbType, string connectionString)
        {
            return dbType switch
            {
                DatabaseType.SqlServer => new UsuarioRepositorySqlServer(connectionString),
                DatabaseType.PostgreSql => new UsuarioRepositoryPostgreSql(connectionString), // Implementar esta clase
                DatabaseType.MySql => new UsuarioRepositoryMySql(connectionString), // Implementar esta clase
                _ => throw new ArgumentException("Invalid database type"),
            };
        }
    }
}

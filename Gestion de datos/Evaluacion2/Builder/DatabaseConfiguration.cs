using Evaluacion2.Conexion;

namespace Evaluacion2.Builder
{
    public class DatabaseConfiguration
    {
        public DatabaseType DatabaseType { get; set; }
        public string ConnectionString { get; set; }

        public DatabaseConfiguration()
        {
            // Valores por defecto
            DatabaseType = DatabaseType.SqlServer;
            ConnectionString = "Default SQL Server Connection String";
        }
    }
}

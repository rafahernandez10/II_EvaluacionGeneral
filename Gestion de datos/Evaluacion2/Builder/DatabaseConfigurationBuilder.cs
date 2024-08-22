using Evaluacion2.Conexion;

namespace Evaluacion2.Builder
{
    public class DatabaseConfigurationBuilder
    {
        private DatabaseConfiguration _configuration;

        public DatabaseConfigurationBuilder()
        {
            _configuration = new DatabaseConfiguration();
        }

        public DatabaseConfigurationBuilder SetDatabaseType(DatabaseType databaseType)
        {
            _configuration.DatabaseType = databaseType;
            return this;
        }

        public DatabaseConfigurationBuilder SetConnectionString(string connectionString)
        {
            _configuration.ConnectionString = connectionString;
            return this;
        }

        public DatabaseConfiguration Build()
        {
            return _configuration;
        }
    }
}

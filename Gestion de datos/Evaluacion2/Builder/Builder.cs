using Evaluacion2.Builder;
namespace Evaluacion2.Builder
{
    public class Builder
    {
        
            private readonly Product _build;

            public Builder()
            {
                _build = new Product(); 
            }

            public Builder UseMSSql()
            {
                _build.MotorBaseDatos = "MSSql";
                _build.CadenaConexion = "conexionMSSql";
                _build.Puerto = 1433;
                return this;
            }

            public Builder UsePgSql()
            {
                _build.MotorBaseDatos = "PgSql";
                _build.CadenaConexion = "conexionPgSql";
                _build.Puerto = 5432;
                return this;
            }

            public Builder UseMySql()
            {
                _build.MotorBaseDatos = "MySql";
                _build.CadenaConexion = "conexionMySql";
                _build.Puerto = 3306;
                return this;
            }

            public Builder SetServidor(string servidor)
            {
                _build.Servidor = servidor;
                return this;
            }

            public Builder SetBaseDatos(string baseDatos)
            {
                _build.BaseDatos = baseDatos;
                return this;
            }

            public Builder SetUsuario(string usuario)
            {
                _build.Usuario = usuario;
                return this;
            }

            public Builder SetContrasena(string contrasena)
            {
                _build.Contraseña = contrasena;
                return this;
            }

            public Product Build()
            {
                return _build;
            }
        }

    
}

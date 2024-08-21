namespace Evaluacion2.Builder
{
    internal class Director
    {
        public void UseMSSql(Builder _build)
        {
            _build.UseMSSql()
                .SetBaseDatos("NombreX");
        }
        public void UseMySql(Builder _build)
        {
            _build.UseMySql()
                .SetServidor("NombreX");
        }

        public void usePgSql(Builder _build)
        {
            _build.UsePgSql()
                .SetUsuario("Juan")
                .SetContrasena("123");
        }


    }
}

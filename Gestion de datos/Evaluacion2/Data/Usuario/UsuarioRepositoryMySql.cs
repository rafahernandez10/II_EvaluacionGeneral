using Evaluacion2.Models;
using MySql.Data.MySqlClient;

namespace Evaluacion2.Data.Usuario
{
    public class UsuarioRepositoryMySql : IUsuarioRepository
    {
        private readonly string _connectionString;

        public UsuarioRepositoryMySql(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<UsuarioModel> GetAll()
        {
            var usuarios = new List<UsuarioModel>();

            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("SELECT * FROM Usuarios", connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        usuarios.Add(new UsuarioModel
                        {
                            Id = reader.GetInt32(0),
                            NombreDeUsuario = reader.GetString(1),
                            NombreCompleto = reader.GetString(2),
                            Edad = reader.GetInt32(3),
                            Correo = reader.GetString(4)
                        });
                    }
                }
            }

            return usuarios;
        }

        public UsuarioModel GetById(int id)
        {
            UsuarioModel usuario = null;

            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("SELECT * FROM Usuarios WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        usuario = new UsuarioModel
                        {
                            Id = reader.GetInt32(0),
                            NombreDeUsuario = reader.GetString(1),
                            NombreCompleto = reader.GetString(2),
                            Edad = reader.GetInt32(3),
                            Correo = reader.GetString(4)
                        };
                    }
                }
            }

            return usuario;
        }

        public void Add(UsuarioModel usuario)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand(
                    "INSERT INTO Usuarios (NombreUsuario, NombreCompleto, Edad, Correo) VALUES (@NombreUsuario, @NombreCompleto, @Edad, @Correo)",
                    connection);
                command.Parameters.AddWithValue("@NombreUsuario", usuario.NombreDeUsuario);
                command.Parameters.AddWithValue("@NombreCompleto", usuario.NombreCompleto);
                command.Parameters.AddWithValue("@Edad", usuario.Edad);
                command.Parameters.AddWithValue("@Correo", usuario.Correo);

                command.ExecuteNonQuery();
            }
        }

        public void Update(UsuarioModel usuario)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand(
                    "UPDATE Usuarios SET NombreUsuario = @NombreUsuario, NombreCompleto = @NombreCompleto, Edad = @Edad, Correo = @Correo WHERE Id = @Id",
                    connection);
                command.Parameters.AddWithValue("@Id", usuario.Id);
                command.Parameters.AddWithValue("@NombreUsuario", usuario.NombreDeUsuario);
                command.Parameters.AddWithValue("@NombreCompleto", usuario.NombreCompleto);
                command.Parameters.AddWithValue("@Edad", usuario.Edad);
                command.Parameters.AddWithValue("@Correo", usuario.Correo);

                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("DELETE FROM Usuarios WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                command.ExecuteNonQuery();
            }
        }
    }
}

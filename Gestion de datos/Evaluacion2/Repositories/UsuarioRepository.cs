using Evaluacion2.Models;
using System.Data.SqlClient;

namespace Evaluacion2.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly SqlConnection _connection;
    }
    public IEnumerable<UsuarioModel> GetAll()
    {
        // Lógica para obtener todos los usuarios
    }

    public UsuarioModel GetById(int id)
    {
        // Lógica para obtener un usuario por ID
    }

    public void Add(UsuarioModel usuario)
    {
        // Lógica para agregar un nuevo usuario
    }

    public void Update(UsuarioModel usuario)
    {
        // Lógica para actualizar un usuario existente
    }

    public void Delete(int id)
    {
        // Lógica para eliminar un usuario
    }
}
}

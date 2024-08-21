using Evaluacion2.Models;

namespace Evaluacion2.Repositories
{
    public interface IUsuarioRepository
    {
        IEnumerable<UsuarioModel> GetAll();
        UsuarioModel GetById(int id);
        void Add(UsuarioModel usuario);
        void Update(UsuarioModel usuario);
        void Delete(int id);


    }
}

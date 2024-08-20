using Evaluacion2.Models;
namespace Evaluacion2.Services
{
    public interface IUsuarioRepository
    {
        IUsuarioRepository GetById(int id);
        void Add(IUsuarioRepository _usuariorepository);
        void Update(IUsuarioRepository _usuariorepository);
        void Delete(int id);
    }
}

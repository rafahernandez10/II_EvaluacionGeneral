using Evaluacion2.Models;

namespace Evaluacion2.Data.Rol
{
    public interface IRolRepository
    {
        IEnumerable<RolesModel> GetAll();
        RolesModel GetById(int id);
        void Add(RolesModel rol);
        void Update(RolesModel rol);
        void Delete(int id);
    }
}

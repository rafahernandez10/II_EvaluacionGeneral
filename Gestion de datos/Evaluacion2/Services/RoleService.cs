using System.Data;
using Evaluacion2.Models;
using Evaluacion2.Repositories;

namespace Evaluacion2.Services
{
    public class RoleService
    {
        private readonly IRolRepository _roleRepository;

        public RoleService(IRolRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public IEnumerable<RolesModel> GetAll()
        {
            return _roleRepository.GetAll();
        }

        public RolesModel GetById(int id)
        {
            return _roleRepository.GetById(id);
        }

        public void Add(RolesModel role)
        {
            _roleRepository.Add(role);
        }

        public void Update(RolesModel role)
        {
            _roleRepository.Update(role);
        }

        public void Delete(int id)
        {
            _roleRepository.Delete(id);
        }
    }
}

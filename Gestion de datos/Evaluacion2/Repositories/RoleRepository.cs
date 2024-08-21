using Evaluacion2.Data;
using Evaluacion2.Models;
using System.Data;

namespace Evaluacion2.Repositories
{
    public class RoleRepository : IRolRepository
    {
        private readonly AppDbContext _context;

        public RoleRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<RolesModel> GetAll()
        {
            return _context.Roles.ToList();
        }
        public RolesModel GetById(int id)
        {
            return _context.Roles.Find(id);
        }

        public void Add(RolesModel role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();
        }

        public void Update(RolesModel role)
        {
            _context.Roles.Update(role);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var role = _context.Roles.Find(id);
            if (role != null)
            {
                _context.Roles.Remove(role);
                _context.SaveChanges();
            }
        }
    }
}

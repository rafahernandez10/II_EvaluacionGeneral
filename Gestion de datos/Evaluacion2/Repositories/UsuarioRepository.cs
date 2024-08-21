using Evaluacion2.Data;
using Evaluacion2.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace Evaluacion2.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AppDbContext _context;

    public UsuarioRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<UsuarioModel> GetAll()
        {
            return _context.Usuarios.Include(u => u.Role).ToList();
        }

        public UsuarioModel GetById(int id)
        {
            return _context.Usuarios.Include(u => u.Role).FirstOrDefault(u => u.RoleId == id);
        }

        public void Add(UsuarioModel usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public void Update(UsuarioModel usuario)
        {
            _context.Usuarios.Update(usuario);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var user = _context.Usuarios.Find(id);
            if (user != null)
            {
                _context.Usuarios.Remove(user);
                _context.SaveChanges();
            }
        }
    }
}


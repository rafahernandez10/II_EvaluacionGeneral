using Evaluacion2.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Evaluacion2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<RolesModel> Roles { get; set; }

    }
}

using System.Data;

namespace Evaluacion2.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string NombreDeUsuario {get; set;}
        public string NombreCompleto {get; set;}
        public int Edad { get; set;}
        public string Correo { get; set;}
        public int RoleId { get; set; }
        public RolesModel Role { get; set; }
    }
}

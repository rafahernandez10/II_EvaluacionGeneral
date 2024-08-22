using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Evaluacion2.Models
{
    public class RolesModel
    {
        public int Id { get; set; }
        public string Nombre {  get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
    }
}

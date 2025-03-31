using Domain.Common;
using Domain.Entities;

namespace Domain.AggregateRoots
{
    public class Empresa: AggregateRoot
    {
        public string Nombre { get; set; }
        public string Rtn { get; set; }
        public string Correo { get; set; }
        public string CasaMatriz { get; set; }
        public string Telefono { get; set; }

        public List<Sucursal> Sucursal { get; set; } = new();
    }
}
using Domain.Common;

namespace Domain.Entities
{
    public class Empresa: AggregateRoot
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Rtn { get; set; }
        public string Correo { get; set; }
        public string CasaMatriz { get; set; }
        public string Telefono { get; set; }
    }
}
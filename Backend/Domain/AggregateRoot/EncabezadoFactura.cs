using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Common;

namespace Domain.Entities
{
    class EncabezadoFactura: AggregateRoot
    {
        public int IdUsuario { get; set; }
        public int IdReserva { get; set; }
        public int IdEmpresa { get; set; }
        public DateTime FechaFactura { get; set; }
        public string NumFactura { get; set; }
        public bool Exonerado { get; set; }
        public int IdResolucion { get; set; }

        // Propiedades de navegación
        public Usuario Usuario { get; set; }
        public Reserva Reserva { get; set; }
        public Empresa Empresa { get; set; }
        public Resolucion Resolucion { get; set; }
        public ICollection<DetalleFactura> Detalles { get; set; } = new List<DetalleFactura>();

    }
}

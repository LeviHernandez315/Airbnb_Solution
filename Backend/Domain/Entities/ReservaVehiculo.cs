using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.AggregateRoots;
using Domain.Common;

namespace Domain.Entities
{
    public class ReservaVehiculo : Entity
    {
 
        public int IdVehiculo { get; set; }
        public int IdReserva { get; set; }
        public decimal PrecioVehiculo { get; set; }
        public decimal ImpuestoVehiculo { get; set; }

        public Reserva? Reserva { get; set; }
        public Vehiculo? Vehiculo { get; set; }
    }

}

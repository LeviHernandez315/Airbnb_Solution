using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Common;

namespace Domain.Entities
{
    public class PuestoTrabajo:EntityCatalog
    {
        public int IdArea { get; set; }
        public AreaTrabajo? Area { get; set; }
    }
}

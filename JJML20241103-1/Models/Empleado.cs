using System;
using System.Collections.Generic;

namespace JJML20241103_1.Models
{
    public partial class Empleado
    {
        public Empleado()
        {
            ReferenciasPersonales = new HashSet<ReferenciasPersonale>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public int? Edad { get; set; }
        public string? Cargo { get; set; }
        public DateTime FechaContratacion { get; set; }

        public virtual ICollection<ReferenciasPersonale> ReferenciasPersonales { get; set; }
    }
}

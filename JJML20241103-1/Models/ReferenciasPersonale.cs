using System;
using System.Collections.Generic;

namespace JJML20241103_1.Models
{
    public partial class ReferenciasPersonale
    {
        public int Id { get; set; }
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string? Relacion { get; set; }
        public string? Telefono { get; set; }

        public virtual Empleado Empleado { get; set; } = null!;
    }
}

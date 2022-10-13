using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoSGAIE.Models
{
    public partial class Periodo
    {
        public Periodo()
        {
            Clases = new HashSet<Clase>();
        }

        public int IdPeriodo { get; set; }
        public string Nombre { get; set; }
        public short FechaInicio { get; set; }
        public short FechaFin { get; set; }

        public virtual ICollection<Clase> Clases { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoSGAIE.Models
{
    public partial class Carrera
    {
        public Carrera()
        {
            Materia = new HashSet<Materium>();
        }

        public int IdCarrera { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCreado { get; set; }
        public bool EstadoCarrera { get; set; }

        public virtual ICollection<Materium> Materia { get; set; }
    }
}

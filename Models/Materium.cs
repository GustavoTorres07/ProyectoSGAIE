using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoSGAIE.Models
{
    public partial class Materium
    {
        public Materium()
        {
            Clases = new HashSet<Clase>();
        }

        public int IdMateria { get; set; }
        public int IdCarrera { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCreado { get; set; }
        public bool EstadoMateria { get; set; }

        public virtual Carrera IdCarreraNavigation { get; set; }
        public virtual ICollection<Clase> Clases { get; set; }
    }
}

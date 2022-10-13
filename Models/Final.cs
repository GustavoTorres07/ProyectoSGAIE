using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoSGAIE.Models
{
    public partial class Final
    {
        public Final()
        {
            Calificacions = new HashSet<Calificacion>();
        }

        public int IdFinal { get; set; }
        public int NotaFinal { get; set; }
        public DateTime FechaFinal { get; set; }

        public virtual ICollection<Calificacion> Calificacions { get; set; }
    }
}

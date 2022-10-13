using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoSGAIE.Models
{
    public partial class Cursadum
    {
        public Cursadum()
        {
            Calificacions = new HashSet<Calificacion>();
        }

        public int IdCursada { get; set; }
        public int NotaCursada { get; set; }
        public DateTime FechaCursada { get; set; }

        public virtual ICollection<Calificacion> Calificacions { get; set; }
    }
}

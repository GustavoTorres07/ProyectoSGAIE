using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoSGAIE.Models
{
    public partial class Parcial
    {
        public Parcial()
        {
            Calificacions = new HashSet<Calificacion>();
        }

        public int IdParcial { get; set; }
        public int NotaParcial { get; set; }
        public DateTime FechaParcial { get; set; }

        public virtual ICollection<Calificacion> Calificacions { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoSGAIE.Models
{
    public partial class Dium
    {
        public Dium()
        {
            Horarios = new HashSet<Horario>();
        }

        public int IdDia { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Horario> Horarios { get; set; }
    }
}

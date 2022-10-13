using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoSGAIE.Models
{
    public partial class Calificacion
    {
        public int IdCalificacion { get; set; }
        public int IdParcial { get; set; }
        public int IdCursada { get; set; }
        public int IdFinal { get; set; }

        public virtual Cursadum IdCursadaNavigation { get; set; }
        public virtual Final IdFinalNavigation { get; set; }
        public virtual Parcial IdParcialNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoSGAIE.Models
{
    public partial class AlumnoClase
    {
        public int IdAlumno { get; set; }
        public int IdPeriodo { get; set; }
        public int IdClase { get; set; }
        public int IdCalificacion { get; set; }

        public virtual Alumno IdAlumnoNavigation { get; set; }
        public virtual Calificacion IdCalificacionNavigation { get; set; }
        public virtual Clase IdClaseNavigation { get; set; }
        public virtual Periodo IdPeriodoNavigation { get; set; }
    }
}

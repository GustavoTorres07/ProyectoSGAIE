using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoSGAIE.Models
{
    public partial class Clase
    {
        public int IdClase { get; set; }
        public int IdMateria { get; set; }
        public int IdProfesor { get; set; }
        public int IdPeriodo { get; set; }
        public int CantidadAlumnos { get; set; }

        public virtual Materium IdMateriaNavigation { get; set; }
        public virtual Periodo IdPeriodoNavigation { get; set; }
        public virtual Profesor IdProfesorNavigation { get; set; }
    }
}

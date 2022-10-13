using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoSGAIE.Models
{
    public partial class Alumno
    {
        public int IdAlumno { get; set; }
        public int IdUsuario { get; set; }
        public string CondicionAlumno { get; set; }
        public bool EstadoAlumno { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}

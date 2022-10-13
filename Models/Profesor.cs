using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoSGAIE.Models
{
    public partial class Profesor
    {
        public Profesor()
        {
            Clases = new HashSet<Clase>();
        }

        public int IdProfesor { get; set; }
        public int IdUsuario { get; set; }
        public string CondicionProfesor { get; set; }
        public bool EstadoProfesor { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<Clase> Clases { get; set; }
    }
}

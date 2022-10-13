using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoSGAIE.Models
{
    public partial class Auxiliar
    {
        public int IdAuxiliar { get; set; }
        public int IdUsuario { get; set; }
        public bool EstadoAuxiliar { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}

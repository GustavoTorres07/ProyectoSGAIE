using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoSGAIE.Models
{
    public partial class Localidad
    {
        public int IdLocalidad { get; set; }
        public int IdProvincia { get; set; }
        public string Nombre { get; set; }
        public int CodPostal { get; set; }

        public virtual Provincium IdProvinciaNavigation { get; set; }
    }
}

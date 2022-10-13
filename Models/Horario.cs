using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoSGAIE.Models
{
    public partial class Horario
    {
        public int IdHorario { get; set; }
        public int IdDia { get; set; }
        public TimeSpan IdClase { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }

        public virtual Dium IdDiaNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoSGAIE.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Alumnos = new HashSet<Alumno>();
            Auxiliars = new HashSet<Auxiliar>();
            Profesors = new HashSet<Profesor>();
        }

        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public string Sexo { get; set; }
        public string DireccionHogar { get; set; }
        public int Telefono { get; set; }
        public string Rol { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CorreoElectronico { get; set; }
        public int Clave { get; set; }

        public virtual ICollection<Alumno> Alumnos { get; set; }
        public virtual ICollection<Auxiliar> Auxiliars { get; set; }
        public virtual ICollection<Profesor> Profesors { get; set; }
    }
}

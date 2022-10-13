using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ProyectoSGAIE.Models
{
    public partial class dbinstitutoContext : DbContext
    {
        public dbinstitutoContext()
        {
        }

        public dbinstitutoContext(DbContextOptions<dbinstitutoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Alumno> Alumnos { get; set; }
        public virtual DbSet<AlumnoClase> AlumnoClases { get; set; }
        public virtual DbSet<Auxiliar> Auxiliars { get; set; }
        public virtual DbSet<Calificacion> Calificacions { get; set; }
        public virtual DbSet<Carrera> Carreras { get; set; }
        public virtual DbSet<Clase> Clases { get; set; }
        public virtual DbSet<Cursadum> Cursada { get; set; }
        public virtual DbSet<Dium> Dia { get; set; }
        public virtual DbSet<Final> Finals { get; set; }
        public virtual DbSet<Horario> Horarios { get; set; }
        public virtual DbSet<Localidad> Localidads { get; set; }
        public virtual DbSet<Materium> Materia { get; set; }
        public virtual DbSet<Parcial> Parcials { get; set; }
        public virtual DbSet<Periodo> Periodos { get; set; }
        public virtual DbSet<Profesor> Profesors { get; set; }
        public virtual DbSet<Provincium> Provincia { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("server=localhost; port=3307; database=dbinstituto; user=root; password=''");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>(entity =>
            {
                entity.HasKey(e => e.IdAlumno)
                    .HasName("PRIMARY");

                entity.ToTable("alumno");

                entity.HasIndex(e => e.IdUsuario, "id_usuario");

                entity.Property(e => e.IdAlumno)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_alumno");

                entity.Property(e => e.CondicionAlumno)
                    .IsRequired()
                    .HasColumnType("enum('regular','irregular','egresado')")
                    .HasColumnName("condicion_alumno");

                entity.Property(e => e.EstadoAlumno).HasColumnName("estado_alumno");

                entity.Property(e => e.IdUsuario)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_usuario");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Alumnos)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("alumno_ibfk_1");
            });

            modelBuilder.Entity<AlumnoClase>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("alumno_clase");

                entity.HasIndex(e => e.IdAlumno, "id_alumno");

                entity.HasIndex(e => e.IdCalificacion, "id_calificacion");

                entity.HasIndex(e => e.IdClase, "id_clase");

                entity.HasIndex(e => e.IdPeriodo, "id_periodo");

                entity.Property(e => e.IdAlumno)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_alumno");

                entity.Property(e => e.IdCalificacion)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_calificacion");

                entity.Property(e => e.IdClase)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_clase");

                entity.Property(e => e.IdPeriodo)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_periodo");

                entity.HasOne(d => d.IdAlumnoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdAlumno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("alumno_clase_ibfk_1");

                entity.HasOne(d => d.IdCalificacionNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdCalificacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("alumno_clase_ibfk_4");

                entity.HasOne(d => d.IdClaseNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdClase)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("alumno_clase_ibfk_3");

                entity.HasOne(d => d.IdPeriodoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdPeriodo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("alumno_clase_ibfk_2");
            });

            modelBuilder.Entity<Auxiliar>(entity =>
            {
                entity.HasKey(e => e.IdAuxiliar)
                    .HasName("PRIMARY");

                entity.ToTable("auxiliar");

                entity.HasIndex(e => e.IdUsuario, "id_usuario");

                entity.Property(e => e.IdAuxiliar)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_auxiliar");

                entity.Property(e => e.EstadoAuxiliar).HasColumnName("estado_auxiliar");

                entity.Property(e => e.IdUsuario)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_usuario");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Auxiliars)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auxiliar_ibfk_1");
            });

            modelBuilder.Entity<Calificacion>(entity =>
            {
                entity.HasKey(e => e.IdCalificacion)
                    .HasName("PRIMARY");

                entity.ToTable("calificacion");

                entity.HasIndex(e => e.IdCursada, "id_cursada");

                entity.HasIndex(e => e.IdFinal, "id_final");

                entity.HasIndex(e => e.IdParcial, "id_parcial");

                entity.Property(e => e.IdCalificacion)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_calificacion");

                entity.Property(e => e.IdCursada)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_cursada");

                entity.Property(e => e.IdFinal)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_final");

                entity.Property(e => e.IdParcial)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_parcial");

                entity.HasOne(d => d.IdCursadaNavigation)
                    .WithMany(p => p.Calificacions)
                    .HasForeignKey(d => d.IdCursada)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("calificacion_ibfk_1");

                entity.HasOne(d => d.IdFinalNavigation)
                    .WithMany(p => p.Calificacions)
                    .HasForeignKey(d => d.IdFinal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("calificacion_ibfk_3");

                entity.HasOne(d => d.IdParcialNavigation)
                    .WithMany(p => p.Calificacions)
                    .HasForeignKey(d => d.IdParcial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("calificacion_ibfk_2");
            });

            modelBuilder.Entity<Carrera>(entity =>
            {
                entity.HasKey(e => e.IdCarrera)
                    .HasName("PRIMARY");

                entity.ToTable("carrera");

                entity.Property(e => e.IdCarrera)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_carrera");

                entity.Property(e => e.EstadoCarrera).HasColumnName("estado_carrera");

                entity.Property(e => e.FechaCreado)
                    .HasColumnType("date")
                    .HasColumnName("fecha_creado");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Clase>(entity =>
            {
                entity.HasKey(e => e.IdClase)
                    .HasName("PRIMARY");

                entity.ToTable("clase");

                entity.HasIndex(e => e.IdMateria, "id_materia");

                entity.HasIndex(e => e.IdPeriodo, "id_periodo");

                entity.HasIndex(e => e.IdProfesor, "id_profesor");

                entity.Property(e => e.IdClase)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_clase");

                entity.Property(e => e.CantidadAlumnos)
                    .HasColumnType("int(11)")
                    .HasColumnName("cantidad_alumnos");

                entity.Property(e => e.IdMateria)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_materia");

                entity.Property(e => e.IdPeriodo)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_periodo");

                entity.Property(e => e.IdProfesor)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_profesor");

                entity.HasOne(d => d.IdMateriaNavigation)
                    .WithMany(p => p.Clases)
                    .HasForeignKey(d => d.IdMateria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("clase_ibfk_3");

                entity.HasOne(d => d.IdPeriodoNavigation)
                    .WithMany(p => p.Clases)
                    .HasForeignKey(d => d.IdPeriodo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("clase_ibfk_2");

                entity.HasOne(d => d.IdProfesorNavigation)
                    .WithMany(p => p.Clases)
                    .HasForeignKey(d => d.IdProfesor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("clase_ibfk_1");
            });

            modelBuilder.Entity<Cursadum>(entity =>
            {
                entity.HasKey(e => e.IdCursada)
                    .HasName("PRIMARY");

                entity.ToTable("cursada");

                entity.Property(e => e.IdCursada)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_cursada");

                entity.Property(e => e.FechaCursada)
                    .HasColumnType("date")
                    .HasColumnName("fecha_cursada");

                entity.Property(e => e.NotaCursada)
                    .HasColumnType("int(11)")
                    .HasColumnName("nota_cursada");
            });

            modelBuilder.Entity<Dium>(entity =>
            {
                entity.HasKey(e => e.IdDia)
                    .HasName("PRIMARY");

                entity.ToTable("dia");

                entity.Property(e => e.IdDia)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_dia");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Final>(entity =>
            {
                entity.HasKey(e => e.IdFinal)
                    .HasName("PRIMARY");

                entity.ToTable("final");

                entity.Property(e => e.IdFinal)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_final");

                entity.Property(e => e.FechaFinal)
                    .HasColumnType("date")
                    .HasColumnName("fecha_final");

                entity.Property(e => e.NotaFinal)
                    .HasColumnType("int(11)")
                    .HasColumnName("nota_final");
            });

            modelBuilder.Entity<Horario>(entity =>
            {
                entity.HasKey(e => e.IdHorario)
                    .HasName("PRIMARY");

                entity.ToTable("horario");

                entity.HasIndex(e => e.IdClase, "id_clase");

                entity.HasIndex(e => e.IdDia, "id_dia");

                entity.Property(e => e.IdHorario)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_horario");

                entity.Property(e => e.HoraFin).HasColumnName("hora_fin");

                entity.Property(e => e.HoraInicio).HasColumnName("hora_inicio");

                entity.Property(e => e.IdClase).HasColumnName("id_clase");

                entity.Property(e => e.IdDia)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_dia");

                entity.HasOne(d => d.IdDiaNavigation)
                    .WithMany(p => p.Horarios)
                    .HasForeignKey(d => d.IdDia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("horario_ibfk_1");
            });

            modelBuilder.Entity<Localidad>(entity =>
            {
                entity.HasKey(e => e.IdLocalidad)
                    .HasName("PRIMARY");

                entity.ToTable("localidad");

                entity.HasIndex(e => e.IdProvincia, "id_provincia");

                entity.Property(e => e.IdLocalidad)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_localidad");

                entity.Property(e => e.CodPostal)
                    .HasColumnType("int(11)")
                    .HasColumnName("cod_postal");

                entity.Property(e => e.IdProvincia)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_provincia");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.IdProvinciaNavigation)
                    .WithMany(p => p.Localidads)
                    .HasForeignKey(d => d.IdProvincia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("localidad_ibfk_1");
            });

            modelBuilder.Entity<Materium>(entity =>
            {
                entity.HasKey(e => e.IdMateria)
                    .HasName("PRIMARY");

                entity.ToTable("materia");

                entity.HasIndex(e => e.IdCarrera, "id_carrera");

                entity.Property(e => e.IdMateria)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_materia");

                entity.Property(e => e.EstadoMateria).HasColumnName("estado_materia");

                entity.Property(e => e.FechaCreado)
                    .HasColumnType("date")
                    .HasColumnName("fecha_creado");

                entity.Property(e => e.IdCarrera)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_carrera");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.IdCarreraNavigation)
                    .WithMany(p => p.Materia)
                    .HasForeignKey(d => d.IdCarrera)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("materia_ibfk_1");
            });

            modelBuilder.Entity<Parcial>(entity =>
            {
                entity.HasKey(e => e.IdParcial)
                    .HasName("PRIMARY");

                entity.ToTable("parcial");

                entity.Property(e => e.IdParcial)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_parcial");

                entity.Property(e => e.FechaParcial)
                    .HasColumnType("date")
                    .HasColumnName("fecha_parcial");

                entity.Property(e => e.NotaParcial)
                    .HasColumnType("int(11)")
                    .HasColumnName("nota_parcial");
            });

            modelBuilder.Entity<Periodo>(entity =>
            {
                entity.HasKey(e => e.IdPeriodo)
                    .HasName("PRIMARY");

                entity.ToTable("periodo");

                entity.Property(e => e.IdPeriodo)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_periodo");

                entity.Property(e => e.FechaFin)
                    .HasColumnType("year(4)")
                    .HasColumnName("fecha_fin");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("year(4)")
                    .HasColumnName("fecha_inicio");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Profesor>(entity =>
            {
                entity.HasKey(e => e.IdProfesor)
                    .HasName("PRIMARY");

                entity.ToTable("profesor");

                entity.HasIndex(e => e.IdUsuario, "id_usuario");

                entity.Property(e => e.IdProfesor)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_profesor");

                entity.Property(e => e.CondicionProfesor)
                    .IsRequired()
                    .HasColumnType("enum('Titular','Suplente')")
                    .HasColumnName("condicion_profesor");

                entity.Property(e => e.EstadoProfesor).HasColumnName("estado_profesor");

                entity.Property(e => e.IdUsuario)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_usuario");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Profesors)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("profesor_ibfk_1");
            });

            modelBuilder.Entity<Provincium>(entity =>
            {
                entity.HasKey(e => e.IdProvincia)
                    .HasName("PRIMARY");

                entity.ToTable("provincia");

                entity.Property(e => e.IdProvincia)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_provincia");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PRIMARY");

                entity.ToTable("usuario");

                entity.Property(e => e.IdUsuario)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_usuario");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("apellido");

                entity.Property(e => e.Clave)
                    .HasColumnType("int(11)")
                    .HasColumnName("clave");

                entity.Property(e => e.CorreoElectronico)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("correo_electronico");

                entity.Property(e => e.DireccionHogar)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("direccion_hogar");

                entity.Property(e => e.Dni)
                    .HasColumnType("int(11)")
                    .HasColumnName("dni");

                entity.Property(e => e.FechaRegistro).HasColumnName("fecha_registro");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("nombre");

                entity.Property(e => e.Rol)
                    .IsRequired()
                    .HasColumnType("enum('Adiministrador','Auxiliar','Profesor')")
                    .HasColumnName("rol");

                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasColumnType("enum('Femenino','Masculino','X')")
                    .HasColumnName("sexo");

                entity.Property(e => e.Telefono)
                    .HasColumnType("int(11)")
                    .HasColumnName("telefono");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

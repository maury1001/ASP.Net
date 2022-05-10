using Microsoft.EntityFrameworkCore;

namespace HolaMundoMVC.Models
{
    public class EscuelaContext:DbContext
    {
        public DbSet<Escuela> Escuelas {get;set;}
        public DbSet<Asignatura> Asignaturas {get;set;}
        public DbSet<Alumno> Alumnos {get;set;}
        public DbSet<Curso> Cursos {get;set;}
        public DbSet<Evaluacion> Evaluaciones {get;set;}


        public EscuelaContext(DbContextOptions<EscuelaContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var escuela = new Escuela();
            escuela.AñoDeCreacion = 2005;
            escuela.ID = Guid.NewGuid().ToString();
            escuela.Nombre = "UNTDF";
            escuela.Direccion = "Av. Siempre viva";
            escuela.Ciudad = "Ushuaia";
            escuela.Pais = "Argentina";
            escuela.TipoEscuela = TiposEscuela.Secundaria;

            modelBuilder.Entity<Escuela>().HasData(escuela);

            modelBuilder.Entity<Asignatura>().HasData(   
                new Asignatura{Nombre="Matemáticas",ID = Guid.NewGuid().ToString()},
                new Asignatura{Nombre="Educación Física",ID = Guid.NewGuid().ToString()},
                new Asignatura{Nombre="Castellano",ID = Guid.NewGuid().ToString()},
                new Asignatura{Nombre="Programación",ID = Guid.NewGuid().ToString()}
                );

            modelBuilder.Entity<Alumno>().HasData(GenerarAlumnos().ToArray());
           
        }

        private List<Alumno> GenerarAlumnos()
        {
            string[] primerNombre = {"Adrian","Sonia","Sebastian"};
            string[] segundoNombre = {"Mauricio","Beatriz","Nicolas"};
            string[] apellido = {"Allaman","Bagnoud","Rober"};

            var listaAlumnos = from n1 in primerNombre
                               from n2 in segundoNombre
                               from a1 in apellido
                               select new Alumno{Nombre = $"{n1} {n2} {a1}",
                                                 ID = Guid.NewGuid().ToString()};
            return listaAlumnos.OrderBy((al)=>al.ID).ToList();
        }    


    }
}
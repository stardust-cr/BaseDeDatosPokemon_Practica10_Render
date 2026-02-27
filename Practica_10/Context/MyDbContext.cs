using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;

namespace Practica_10.Context
{
    public class MyDbContext: DbContext
    {
        //Establecemos el motor de la base de datos
        //especificando su cadena de conexión
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Con esto estamos utilizando ApiFluent y le estamos diciendo que la entidad
            //Estudiante curso va a tener una clave primaria compuesta por CursoId y EstudianteId
            modelBuilder.Entity<Pokemon_Movimiento>().HasKey(a => new {a.NumMovimiento,a.NumPokemon});
            modelBuilder.Entity<Consola>().HasKey(a => new { a.ConsolaNumero });
            modelBuilder.Entity<Jugador>().HasKey(a => new { a.NumeroJugador });
            modelBuilder.Entity<Movimiento>().HasKey(a => new { a.NumeroMovimiento });
            modelBuilder.Entity<Pokemon>().HasKey(a => new { a.NumeroPokemon });
            modelBuilder.Entity<Consola>().HasOne(c => c.Jugador).WithOne(b => b.Consola).HasForeignKey<Consola>(c => c.JugadorId);
            //Cuidador:Animal=>N:N
            ////Establezco las claves de la clase AnimalCuidador.
            modelBuilder.Entity<Pokemon_Movimiento>().HasOne(pm=>pm.Pokemon).WithMany(p=>p.Pokemon_Movimientos).HasForeignKey(pm=>pm.NumPokemon).OnDelete(DeleteBehavior.Cascade);
             modelBuilder.Entity<Pokemon_Movimiento>().HasOne(pm=>pm.Movimiento).WithMany(p=>p.Pokemon_Movimientos).HasForeignKey(pm=>pm.NumMovimiento).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Jugador>().HasMany(w=>w.Pokemones).WithOne(w=>w.Jugador)
                .HasForeignKey(w=>w.JugadorId)
                .OnDelete(DeleteBehavior.Cascade);
        }

        //creamos una tabla llamada Estudiantes
        //a partir de nuestra clase Estudiante
        public DbSet<Jugador> Jugadores { get; set; }

        //creamos una tabla llamada Direcciones
        //a partir de nuestra clase Direccion
        public DbSet<Consola> Consolas { get; set; }

        //creamos una tabla llamada Institutos
        //a partir de nuestra clase Instituto
        public DbSet<Pokemon> Pokemones { get; set; }

        //creamos una tabla llamada Cursos
        //a partir de nuestra clase Curso
        public DbSet<Movimiento> Movimientos { get; set; }

        //creamos una tabla llamada EstudiantesCursos
        //a partir de nuestra clase EstudianteCurso
        public DbSet<Pokemon_Movimiento> Pokemon_Movimientos { get; set; }
    }
}


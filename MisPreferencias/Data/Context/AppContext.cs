using Microsoft.EntityFrameworkCore;

namespace MisPreferencias.Models.Context
{
    public class AppContext : DbContext
    {
        public DbSet<Pelicula> Peliculas { get; set; }
        protected readonly IConfiguration Configuration;

        public AppContext()
        {

        }
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {

            if (!optionsBuilder.IsConfigured)

            {

                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=DemoDB;Integrated Security=True;");

            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Pelicula>(entity =>

            {

                entity.ToTable("Peliculas");

                entity.Property(e => e.Nombre)

                    .HasMaxLength(50)

                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)

                    .HasMaxLength(50)

                    .IsUnicode(false);

                entity.Property(e => e.Puntaje)

                    .HasMaxLength(50)

                    .IsUnicode(false);

            });

            OnModelCreatingPartial(modelBuilder);

        }
        private void OnModelCreatingPartial(ModelBuilder modelBuilder) { }
    }
}


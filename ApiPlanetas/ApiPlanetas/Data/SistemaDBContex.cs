using ApiPlanetas.Data.Map;
using ApiPlanetas.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiPlanetas.Data
{
    public class SistemaDBContex : DbContext
    {

        public SistemaDBContex(DbContextOptions<SistemaDBContex> options) : base(options) { }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<PlanetaModel> Planetas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new PlanetaMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}

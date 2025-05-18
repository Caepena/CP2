using CP2.Domain.Entity;
using CP2.Infrastructure.Mappings;
using Microsoft.EntityFrameworkCore;

namespace CP2.Infrastructure.Context
{
    public class MottuContext(DbContextOptions<MottuContext> options) : DbContext(options)
    {
        public DbSet<Moto> Motos { get; set; }

        public DbSet<Garagem> Garagens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MotoMapping());

            modelBuilder.ApplyConfiguration(new GaragemMapping());

            modelBuilder.Entity<Garagem>()
                .HasMany(g => g.Motos)
                .WithOne()
                .HasForeignKey(m => m.IdGaragem)
                .IsRequired();


            base.OnModelCreating(modelBuilder);
        }
    }
}

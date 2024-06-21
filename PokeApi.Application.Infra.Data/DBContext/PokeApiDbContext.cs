using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using PokeApi.Application.Abstraction.Domain.DTO;


namespace PokeApi.Application.Infra.Data.DBContext
{
    public class PokeApiDbContext : DbContext
    {

        public static string Schema => "PokeApiDb";
        public DbSet<PlayerDTO> PlayerDTO { get; set; }
        public DbSet<PokeDTO> PokeDto { get; set; }

        public PokeApiDbContext(DbContextOptions<PokeApiDbContext> options)
        : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            modelBuilder.Entity<PlayerDTO>().Property(x => x.Id).HasDefaultValue("NEWID()");
            modelBuilder.Entity<PokeDTO>().Property(x => x.Id).HasDefaultValue("NEWID()");
           



            base.OnModelCreating(modelBuilder);
        }

        public class IntegrationContextFactory : IDesignTimeDbContextFactory<PokeApiDbContext>
        {
            public PokeApiDbContext CreateDbContext(string[] args)
            {
                var optionBuilder = new DbContextOptionsBuilder<PokeApiDbContext>();

                optionBuilder.UseSqlServer("Data Source=localhost;Database=PokeApiDB;Trusted_Connection=True;Trust Server Certificate = true;");

                return new PokeApiDbContext(optionBuilder.Options);
            }
        }

    }
}

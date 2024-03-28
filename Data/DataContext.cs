global using Microsoft.EntityFrameworkCore;

namespace SuperHero.Data
{
    public class SuperHeroes : DbContext
    {
        public SuperHeroes(DbContextOptions<SuperHeroes> option) : base(option)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=MSI;Initial Catalog=SuperHeroDatabase;Integrated Security=True;Pooling=False;Encrypt=False;Trust Server Certificate=False");
        }

        
        public DbSet<SuperHeros> SuperHero { get; set; }
    }
}
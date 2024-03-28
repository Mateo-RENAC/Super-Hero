global using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }


        public DbSet<SuperHeros> SuperHero { get; set; }
    }
}
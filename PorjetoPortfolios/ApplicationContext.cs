using Microsoft.EntityFrameworkCore;
using PorjetoPortfolios.Models;


namespace PorjetoPortfolios
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ImagemDosCursos> ImagemDosCursos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ImagemDosCursos>().HasKey(t => t.Codigo);
        }
    }
}

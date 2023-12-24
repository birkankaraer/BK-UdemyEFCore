using Microsoft.EntityFrameworkCore;

namespace Concurrency.WebMVC.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        public DbSet<Product> Products { get; set; }    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //fluent api ile rowversion alanı oluşturulur. bu ikinci yöntemdir.
            modelBuilder.Entity<Product>().Property(p => p.RowVersion).IsRowVersion();
            //decimal için precision ve scale değerleri belirlenir.
            modelBuilder.Entity<Product>().Property(p => p.Price).HasPrecision(18, 2);

            base.OnModelCreating(modelBuilder);
        }


    }
}

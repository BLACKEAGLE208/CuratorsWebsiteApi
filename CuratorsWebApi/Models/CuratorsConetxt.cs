using Microsoft.EntityFrameworkCore;
//using System.Data.Entity;

namespace CuratorsWebApi.Models
{
    public class CuratorsContext : DbContext
    {
        public CuratorsContext(DbContextOptions<CuratorsContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Curator> Curators { get; set; } = null!;
        public DbSet<Faculty> Faculties { get; set; } = null!;
        public DbSet<Nfile> Nfile { get; set; } = null!;
        public DbSet<NfileType> NfileType { get; set; } = null!;
        public DbSet<NewsItem> News { get; set; } = null!;

    }
}

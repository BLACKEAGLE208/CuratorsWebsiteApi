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
        public DbSet<FileClass> Files { get; set; } = null!;

    }
}

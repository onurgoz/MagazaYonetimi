using Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Baglanti
{
    public class MagazaYonetimDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=MagazaYonetimDB;Trusted_connection=true");
        }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Urun> Urunler { get; set; }
    }
}

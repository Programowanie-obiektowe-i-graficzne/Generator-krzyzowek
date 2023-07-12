using Microsoft.EntityFrameworkCore;
using Projekt_krzyżówki.Models.MODELS;

namespace Projekt_krzyżówki.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }
        public DbSet<Krzyzowka> Krzyzowki { get; set; }
        public DbSet<Pytania> Pytania{ get; set; }
        public DbSet<Slowa> Slowa { get; set; }
        public DbSet<Uzytkownik> Uzytkownicy { get; set; }
        public DbSet<Pytania_Krzyzowki> Pytania_Krzyzowkis { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite(@"DataSource=./mydb.db");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pytania_Krzyzowki>()
                .HasKey(pk => new { pk.Id_Pytania, pk.Id_Krzyzowki });
            modelBuilder.Entity<Pytania_Krzyzowki>()
                .HasOne(p => p.Pytanie)
                .WithMany(pk => pk.ListaKrzyzowek)
                .HasForeignKey(p=>p.Id_Pytania);
            modelBuilder.Entity<Pytania_Krzyzowki>()
                .HasOne(k => k.Krzyzowka)
                .WithMany(pk => pk.ListaPytan)
                .HasForeignKey(k=>k.Id_Pytania);
        }
    }
}

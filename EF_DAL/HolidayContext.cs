using EF_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Runtime;

namespace EF_DAL
{
    public class HolidayContext : DbContext
    {
        // DbSet => Liste qui représente les différentes Tables de la db
        public DbSet<Hotel> Hotels { get => Set<Hotel>(); }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\MSSQLLocalDB;database=demoEF;integrated security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // pour ajouter des lignes dans la table hotel
            modelBuilder.Entity<Hotel>().HasData(new List<Hotel> {
                // ajouter ici les premiers hotel de votre DB
                new Hotel { 
                    Id = 1, 
                    Nom = "Ibis", 
                    Address = "Charleroi", 
                    DateDeCreation = new DateTime(1935,1,1), 
                    NbEtoiles = 2, 
                    Piscine = false 
                },
                new Hotel { 
                    Id = 2, 
                    Nom = "Hilton", 
                    Address = "Bruxelles",
                    DateDeCreation = new DateTime(1929, 12, 25), 
                    NbEtoiles = 5, 
                    Piscine = true
                }
            });
        }
    }
}

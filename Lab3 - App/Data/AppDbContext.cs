using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AppDbContext:DbContext
    {
        private string DbPath { get; set; }

        public AppDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "contacts.db");
        }

        public DbSet<ContactEntity> Contacts { get; set; }
        public DbSet<OrganizationEntity> Organizations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data source={DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactEntity>()
                .HasOne(c => c.Organization)
                .WithMany(o => o.Contacts)
                .HasForeignKey(c => c.OrganizationId);


            modelBuilder.Entity<ContactEntity>()
                .HasData(
                new OrganizationEntity()
                {
                    Id = 1,
                    Name = "WSEI",
                    Description = "Uczelnia wyższa w Krakowie"
                });

            modelBuilder.Entity<ContactEntity>()
          .HasData(
            new ContactEntity()
            {
                ContactId = 1,
                First_name = "Adam",
                Surname = "Kwasny",
                Birth_date = new DateTime(2000, 10, 10),
             
            },
            new ContactEntity()
            {
                ContactId = 2,
                First_name = "Ewa",
                Surname = "Malecka",
                Birth_date = new DateTime(1999, 8, 8),
               
            }
        );

            modelBuilder.Entity<OrganizationEntity>()
                .OwnsOne(o => o.Adres)
                .HasData(
                new
                {
                    OrganizationEntityId = 1,
                    City = "Kraków",
                    Street = "Św. Filipa 17",
                    PostalCode = "31-150"
                }
                );
        }
    }
}

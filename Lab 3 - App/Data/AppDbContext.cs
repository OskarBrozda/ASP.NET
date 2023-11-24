using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Data;

public class AppDbContext : DbContext
{
    public AppDbContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = Path.Join(path, "contacts.db");
    }

    public DbSet<ContactEntity> Contacts { get; set; }
    public DbSet<OrganizationEntity> Organizations { get; set; }

    private string DbPath { get; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite($"Data Source={DbPath}");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OrganizationEntity>()
            .OwnsOne(e => e.Address);

        modelBuilder.Entity<ContactEntity>()
            .HasOne(e => e.Organization)
            .WithMany(o => o.Contacts)
            .HasForeignKey(e => e.OrganizationId);

        modelBuilder.Entity<OrganizationEntity>()
            .HasData(
                new OrganizationEntity
                {
                    OrganizationId = 1,
                    Title = "--",
                    Nip = 0,
                    Regon = 0
                },
                new OrganizationEntity
                {
                    OrganizationId = 2,
                    Title = "WSEI",
                    Nip = 6762158990,
                    Regon = 357191420
                },
                new OrganizationEntity
                {
                    OrganizationId = 3,
                    Title = "RAKSO",
                    Nip = 1357895472,
                    Regon = 367891434
                },
                new OrganizationEntity
                {
                    OrganizationId = 4,
                    Title = "Złoty kłos",
                    Nip = 3456789091,
                    Regon = 872358792
                }
            );


        modelBuilder.Entity<ContactEntity>().HasData(
            new ContactEntity
            {
                ContactId = 1, Name = "Oskar", Surname = "Karolczyk", BirthDate = new DateTime(2007, 12, 24),
                Email = "karolos@mail.com", Phone = "123123123", Priority = Priority.High, OrganizationId = 2
            },
            new ContactEntity
            {
                ContactId = 2, Name = "Tomasz", Surname = "Murawski", BirthDate = new DateTime(2008, 08, 01),
                Email = "tmurarz@mail.com", Phone = "091912424", Priority = Priority.Normal, OrganizationId = 3
            },
            new ContactEntity
            {
                ContactId = 3, Name = "Zuzanna", Surname = "Boska", BirthDate = new DateTime(2000, 01, 19),
                Email = "boskazuzia@mail.com", Phone = "678998786", Priority = Priority.Low, OrganizationId = 3
            }
        );

        modelBuilder.Entity<OrganizationEntity>()
            .OwnsOne(e => e.Address)
            .HasData(
                new
                {
                    OrganizationEntityOrganizationId = 1, City = "none", Street = "none",
                    PostalCode = "00-000", Region = "none"
                },
                new
                {
                    OrganizationEntityOrganizationId = 2, City = "Kraków", Street = "Św. Filipa 17",
                    PostalCode = "31-150", Region = "małopolska"
                },
                new
                {
                    OrganizationEntityOrganizationId = 3, City = "Kraków", Street = "Krowoderska 45/6",
                    PostalCode = "42-400", Region = "małopolska"
                },
                new
                {
                    OrganizationEntityOrganizationId = 4, City = "Katowice", Street = "Piłsudskiego 99E",
                    PostalCode = "32-120", Region = "śląsk"
                }
            );
    }
}
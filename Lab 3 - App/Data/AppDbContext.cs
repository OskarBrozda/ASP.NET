using Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Data;

public class AppDbContext : IdentityDbContext<IdentityUser>
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
        base.OnModelCreating(modelBuilder);
        var passwordHasher = new PasswordHasher<IdentityUser>();
        
        var adminRole = new IdentityRole
            { 
                Id = Guid.NewGuid().ToString(),
                Name = "admin", 
                NormalizedName = "ADMIN"
            };
        adminRole.ConcurrencyStamp = adminRole.Id;
        
        var userRole = new IdentityRole
            { 
               Id = Guid.NewGuid().ToString(),
               Name = "user", 
               NormalizedName = "USER"
            };
        userRole.ConcurrencyStamp = userRole.Id;
        
        modelBuilder.Entity<IdentityRole>().HasData(
            adminRole,
            userRole
        );
        
        var admin = new IdentityUser
        {
            Id = Guid.NewGuid().ToString(),
            Email = "oskar@wsei.edu.pl",
            NormalizedEmail = "OSKAR@WSEI.EDU.PL",
            EmailConfirmed = true,
            UserName = "oskar",
            NormalizedUserName = "OSKAR",
        };
        
        var user = new IdentityUser
        {
            Id = Guid.NewGuid().ToString(),
            Email = "zuzia@wsei.edu.pl",
            NormalizedEmail = "ZUZIA@WSEI.EDU.PL",
            EmailConfirmed = true,
            UserName = "zuzanna",
            NormalizedUserName = "ZUZANNA",
        };
        
        admin.PasswordHash = passwordHasher.HashPassword(admin, "zaq1@WSX");
        user.PasswordHash = passwordHasher.HashPassword(user, "xsw2!QAZ");
        
        modelBuilder.Entity<IdentityUser>()
            .HasData(
            admin,
            user
        );
        
        modelBuilder.Entity<IdentityUserRole<string>>()
            .HasData(
            new IdentityUserRole<string>
            {
                RoleId = adminRole.Id, UserId = admin.Id
            },
            new IdentityUserRole<string>
            {
                RoleId = userRole.Id, UserId = user.Id
            }
        );
        
        
        
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
                    OrganizationId = 1, Title = "--", Nip = 0, Regon = 0
                },
                new OrganizationEntity
                {
                    OrganizationId = 2, Title = "WSEI", Description = "Szkoła wysza", Nip= 6762158990, Regon = 357191420
                },
                new OrganizationEntity
                {
                    OrganizationId = 3, Title = "RAKSO", Description = "Działalnośc własna", Nip = 1357895472, Regon = 367891434
                },
                new OrganizationEntity
                {
                    OrganizationId = 4, Title = "Złoty kłos", Description = "Piekarnia", Nip = 3456789091, Regon = 872358792
                }
            );


        modelBuilder.Entity<ContactEntity>().HasData(
            new ContactEntity
            {
                ContactId = 1, Name = "Oskar", Surname = "Karolczyk", BirthDate = new DateTime(2007, 12, 24),
                Email = "karolos@mail.com", Phone = "123123123", Priority = 1, OrganizationId = 2
            },
            new ContactEntity
            {
                ContactId = 2, Name = "Tomasz", Surname = "Murawski", BirthDate = new DateTime(2008, 08, 01),
                Email = "tmurarz@mail.com", Phone = "091912424", Priority = 2, OrganizationId = 3
            },
            new ContactEntity
            {
                ContactId = 3, Name = "Zuzanna", Surname = "Boska", BirthDate = new DateTime(2000, 01, 19),
                Email = "boskazuzia@mail.com", Phone = "678998786", Priority = 3, OrganizationId = 3
            }
        );

        
        modelBuilder.Entity<OrganizationEntity>()
            .OwnsOne(e => e.Address)
            .HasData(
                new
                {
                    OrganizationEntityOrganizationId = 1, City = "none", Street = "none", HomeNr = "none", PostalCode = "00-000", Region = "none", Country = "none"
                },
                new
                {
                    OrganizationEntityOrganizationId = 2, City = "Kraków", Street = "Św. Filipa", HomeNr = "17",
                    PostalCode = "31-150", Region = "Małopolska", Country = "Polska"
                },
                new
                {
                    OrganizationEntityOrganizationId = 3, City = "Kraków", Street = "Krowoderska", HomeNr = "46", ApartamentNr = 6,
                    PostalCode = "42-400", Region = "Małopolska", Country = "Polska"
                },
                new
                {
                    OrganizationEntityOrganizationId = 4, City = "Katowice", Street = "Piłsudskiego", HomeNr = "99E",
                    PostalCode = "32-120", Region = "Śląsk", Country = "Polska"
                }
            );
    }
}
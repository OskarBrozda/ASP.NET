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
    public DbSet<PhotoEntity> Photos { get; set; }
    public DbSet<AuthorEntity> Authors { get; set; }
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
        
        
        
        modelBuilder.Entity<AuthorEntity>()
            .OwnsOne(e => e.Address);

        modelBuilder.Entity<PhotoEntity>()
            .HasOne(e => e.Authors)
            .WithMany(a => a.Photos)
            .HasForeignKey(e => e.AuthorId);

        modelBuilder.Entity<AuthorEntity>()
            .HasData(
                new AuthorEntity
                {
                    AuthorId = 1, Name = "Adam", Surname = "Kwaśny", Email = "akwasny@wp.pl", Note = "student"
                },
                new AuthorEntity
                {
                    AuthorId = 2, Name = "Tomasz", Surname = "Surówka", Email = "tsur@wp.pl", Note = "praktykant"
                },
                new AuthorEntity
                {
                    AuthorId = 3, Name = "Mariola", Surname = "Lubicz", Email = "majalub@wp.pl", Note = "fotograf ślubny"
                },
                new AuthorEntity
                {
                    AuthorId = 4, Name = "Łukasz", Surname = "Radwan", Email = "lrdw@wp.pl", Note = "fotograf natury"
                }
            );


        modelBuilder.Entity<PhotoEntity>().HasData(
            new PhotoEntity
            {
                PhotoId = 1, Date_time = new DateTime(2008, 8, 1, 12, 59, 16), Description = "Pejzaż górski",
                Camera = "Nikon", AuthorId = 3, Definition = 2, Format = 4,
                PhotoUrl = "https://westerncamp.pl/wp-content/uploads/2023/10/tatry-1080x675.jpg"
            },
            new PhotoEntity
            {
                PhotoId = 2, Date_time = new DateTime(2018, 7, 11, 10, 9, 11), Description = "Sowa",
                Camera = "Canon", AuthorId = 3, Definition = 6, Format = 1,
                PhotoUrl = "https://bi.im-g.pl/im/20/19/1b/z28415520AMP,Puszczyk-zwyczajny.jpg"
            },
            new PhotoEntity
            {
                PhotoId = 3, Date_time = new DateTime(1998, 11, 11, 11, 10, 9), Description = "Znak górski",
                Camera = "Nikon", AuthorId = 1, Definition = 7, Format = 2,
                PhotoUrl =
                    "https://zieloniwpodrozy.pl/wp-content/uploads/2015/06/Zdjęcie-wykonane-o-świcie-na-Połoninie-Caryńskiej-podczas-naszej-krótkiej-wycieczki-w-Bieszczady..jpg"
            },
            new PhotoEntity
            {
                PhotoId = 4, Date_time = new DateTime(2012, 2, 07, 23, 15, 34), Description = "Śniadanie",
                Camera = "Sony", AuthorId = 4, Definition = 3, Format = 5,
                PhotoUrl = "https://szefsmaku.pl/wp-content/uploads/2019/02/sniadanie-to-podstawa.jpg"
            },
            new PhotoEntity
            {
                PhotoId = 5, Date_time = new DateTime(2000, 1, 1, 13, 10, 35), Description = "Kotek",
                Camera = "Iphone", AuthorId = 3, Definition = 4, Format = 3,
                PhotoUrl = "https://img.redro.pl/obrazy/czarny-dlugowlosy-kot-700-204992097.jpg"
            },
            new PhotoEntity
            {
                PhotoId = 6, Date_time = new DateTime(2019, 4, 9, 10, 14, 44), Description = "Szpic miniaturowy",
                Camera = "screen", AuthorId = 2, Definition = 6, Format = 2,
                PhotoUrl = "https://ocdn.eu/pulscms-transforms/1/-LUk9kqTURBXy83ZTRmYjIyNmI0YWUxZDZlZjg2OWM4ZTFjY2YxNDE5My5qcGVnk5UDzQHIzQEKzQnszQWVkwXNBLDNAqSTCaY2ZTQwMzgG3gABoTAB/marzy-ci-sie-bezproblemowy-pies-poznaj-rasy-ktore-nie-sprawia-duzo-klopotu.jpeg"
            },
            new PhotoEntity
            {
                PhotoId = 7, Date_time = new DateTime(2017, 11, 12, 2, 1, 3), Description = "College",
                Camera = "Nokia", AuthorId = 2, Definition = 2, Format = 1,
                PhotoUrl = "https://educat.study/wp-content/uploads/2023/09/4585094076_902c32b4cf_b.jpg"
            }
        );
        
        modelBuilder.Entity<AuthorEntity>()
            .OwnsOne(e => e.Address)
            .HasData(
                new
                {
                    AuthorEntityAuthorId = 1, City = "Poznań", Street = "Pomorska", HomeNr = "22",
                    PostalCode = "42-152", Region = "Wielkopolska", Country = "Polska"
                },
                new
                {
                    AuthorEntityAuthorId = 2, City = "Kraków", Street = "Św. Filipa", HomeNr = "17",
                    PostalCode = "31-150", Region = "Małopolska", Country = "Polska"
                },
                new
                {
                    AuthorEntityAuthorId = 3, City = "Kraków", Street = "Krowoderska", HomeNr = "46", ApartamentNr = 6,
                    PostalCode = "42-400", Region = "Małopolska", Country = "Polska"
                },
                new
                {
                    AuthorEntityAuthorId = 4, City = "Katowice", Street = "Piłsudskiego", HomeNr = "99E",
                    PostalCode = "32-120", Region = "Śląsk", Country = "Polska"
                }
            );
    }
}
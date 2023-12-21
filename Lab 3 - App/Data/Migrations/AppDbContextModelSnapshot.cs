﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("Data.Entities.AuthorEntity", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Note")
                        .HasColumnType("TEXT");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AuthorId");

                    b.ToTable("authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            Email = "akwasny@wp.pl",
                            Name = "Adam",
                            Note = "student",
                            Surname = "Kwaśny"
                        },
                        new
                        {
                            AuthorId = 2,
                            Email = "tsur@wp.pl",
                            Name = "Tomasz",
                            Note = "praktykant",
                            Surname = "Surówka"
                        },
                        new
                        {
                            AuthorId = 3,
                            Email = "majalub@wp.pl",
                            Name = "Mariola",
                            Note = "fotograf ślubny",
                            Surname = "Lubicz"
                        },
                        new
                        {
                            AuthorId = 4,
                            Email = "lrdw@wp.pl",
                            Name = "Łukasz",
                            Note = "fotograf natury",
                            Surname = "Radwan"
                        });
                });

            modelBuilder.Entity("Data.Entities.ContactEntity", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("BirthDate");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Note")
                        .HasColumnType("TEXT");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("TEXT");

                    b.Property<int>("Priority")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("ContactId");

                    b.HasIndex("OrganizationId");

                    b.ToTable("contacts");

                    b.HasData(
                        new
                        {
                            ContactId = 1,
                            BirthDate = new DateTime(2007, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "karolos@mail.com",
                            Name = "Oskar",
                            OrganizationId = 2,
                            Phone = "123123123",
                            Priority = 1,
                            Surname = "Karolczyk"
                        },
                        new
                        {
                            ContactId = 2,
                            BirthDate = new DateTime(2008, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "tmurarz@mail.com",
                            Name = "Tomasz",
                            OrganizationId = 3,
                            Phone = "091912424",
                            Priority = 2,
                            Surname = "Murawski"
                        },
                        new
                        {
                            ContactId = 3,
                            BirthDate = new DateTime(2000, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "boskazuzia@mail.com",
                            Name = "Zuzanna",
                            OrganizationId = 3,
                            Phone = "678998786",
                            Priority = 3,
                            Surname = "Boska"
                        });
                });

            modelBuilder.Entity("Data.Entities.OrganizationEntity", b =>
                {
                    b.Property<int>("OrganizationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<long>("Nip")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Regon")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("OrganizationId");

                    b.ToTable("organizations");

                    b.HasData(
                        new
                        {
                            OrganizationId = 1,
                            Nip = 0L,
                            Regon = 0L,
                            Title = "--"
                        },
                        new
                        {
                            OrganizationId = 2,
                            Description = "Szkoła wysza",
                            Nip = 6762158990L,
                            Regon = 357191420L,
                            Title = "WSEI"
                        },
                        new
                        {
                            OrganizationId = 3,
                            Description = "Działalnośc własna",
                            Nip = 1357895472L,
                            Regon = 367891434L,
                            Title = "RAKSO"
                        },
                        new
                        {
                            OrganizationId = 4,
                            Description = "Piekarnia",
                            Nip = 3456789091L,
                            Regon = 872358792L,
                            Title = "Złoty kłos"
                        });
                });

            modelBuilder.Entity("Data.Entities.PhotoEntity", b =>
                {
                    b.Property<int>("PhotoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AuthorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Camera")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date_time")
                        .HasColumnType("TEXT");

                    b.Property<int>("Definition")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int>("Format")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Love")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PhotoUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PhotoId");

                    b.HasIndex("AuthorId");

                    b.ToTable("photos");

                    b.HasData(
                        new
                        {
                            PhotoId = 1,
                            AuthorId = 3,
                            Camera = "Nikon",
                            Date_time = new DateTime(2008, 8, 1, 12, 59, 16, 0, DateTimeKind.Unspecified),
                            Definition = 2,
                            Description = "Pejzaż górski",
                            Format = 4,
                            Love = 345,
                            PhotoUrl = "https://westerncamp.pl/wp-content/uploads/2023/10/tatry-1080x675.jpg"
                        },
                        new
                        {
                            PhotoId = 2,
                            AuthorId = 3,
                            Camera = "Canon",
                            Date_time = new DateTime(2018, 7, 11, 10, 9, 11, 0, DateTimeKind.Unspecified),
                            Definition = 6,
                            Description = "Sowa",
                            Format = 1,
                            Love = 1234,
                            PhotoUrl = "https://bi.im-g.pl/im/20/19/1b/z28415520AMP,Puszczyk-zwyczajny.jpg"
                        },
                        new
                        {
                            PhotoId = 3,
                            AuthorId = 1,
                            Camera = "Nikon",
                            Date_time = new DateTime(1998, 11, 11, 11, 10, 9, 0, DateTimeKind.Unspecified),
                            Definition = 7,
                            Description = "Znak górski",
                            Format = 2,
                            Love = 702,
                            PhotoUrl = "https://zieloniwpodrozy.pl/wp-content/uploads/2015/06/Zdjęcie-wykonane-o-świcie-na-Połoninie-Caryńskiej-podczas-naszej-krótkiej-wycieczki-w-Bieszczady..jpg"
                        },
                        new
                        {
                            PhotoId = 4,
                            AuthorId = 4,
                            Camera = "Sony",
                            Date_time = new DateTime(2012, 2, 7, 23, 15, 34, 0, DateTimeKind.Unspecified),
                            Definition = 3,
                            Description = "Śniadanie",
                            Format = 5,
                            Love = 100,
                            PhotoUrl = "https://szefsmaku.pl/wp-content/uploads/2019/02/sniadanie-to-podstawa.jpg"
                        },
                        new
                        {
                            PhotoId = 5,
                            AuthorId = 3,
                            Camera = "Iphone",
                            Date_time = new DateTime(2000, 1, 1, 13, 10, 35, 0, DateTimeKind.Unspecified),
                            Definition = 4,
                            Description = "Kotek",
                            Format = 3,
                            Love = 98901,
                            PhotoUrl = "https://img.redro.pl/obrazy/czarny-dlugowlosy-kot-700-204992097.jpg"
                        },
                        new
                        {
                            PhotoId = 6,
                            AuthorId = 2,
                            Camera = "screen",
                            Date_time = new DateTime(2019, 4, 9, 10, 14, 44, 0, DateTimeKind.Unspecified),
                            Definition = 6,
                            Description = "Szpic miniaturowy",
                            Format = 2,
                            Love = 23467,
                            PhotoUrl = "https://ocdn.eu/pulscms-transforms/1/-LUk9kqTURBXy83ZTRmYjIyNmI0YWUxZDZlZjg2OWM4ZTFjY2YxNDE5My5qcGVnk5UDzQHIzQEKzQnszQWVkwXNBLDNAqSTCaY2ZTQwMzgG3gABoTAB/marzy-ci-sie-bezproblemowy-pies-poznaj-rasy-ktore-nie-sprawia-duzo-klopotu.jpeg"
                        },
                        new
                        {
                            PhotoId = 7,
                            AuthorId = 2,
                            Camera = "Nokia",
                            Date_time = new DateTime(2017, 11, 12, 2, 1, 3, 0, DateTimeKind.Unspecified),
                            Definition = 2,
                            Description = "College",
                            Format = 1,
                            Love = 1,
                            PhotoUrl = "https://educat.study/wp-content/uploads/2023/09/4585094076_902c32b4cf_b.jpg"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "ed192f30-9146-44cf-af35-ca747de699da",
                            ConcurrencyStamp = "ed192f30-9146-44cf-af35-ca747de699da",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "1e083dbd-f018-455e-b5b9-a309e1bd2613",
                            ConcurrencyStamp = "1e083dbd-f018-455e-b5b9-a309e1bd2613",
                            Name = "user",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "ee776100-9a00-43d9-bccc-8edae0042523",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8b32130d-2e9e-4798-990c-5c5dfbbbf249",
                            Email = "oskar@wsei.edu.pl",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "OSKAR@WSEI.EDU.PL",
                            NormalizedUserName = "OSKAR",
                            PasswordHash = "AQAAAAIAAYagAAAAEFVPNpYuo41R/1Pwg0Td4YSWcfqFzHK1YjaD79B+PvvfotB0/KsDYJEa0Ur9Qb8H7A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b5fb94a0-3b20-4de2-bd8b-8c6c17a65707",
                            TwoFactorEnabled = false,
                            UserName = "oskar"
                        },
                        new
                        {
                            Id = "61ae0669-417d-4fe3-a918-14046c99e7b7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ce3fdef7-3149-492a-9358-48a32e3d12a8",
                            Email = "zuzia@wsei.edu.pl",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ZUZIA@WSEI.EDU.PL",
                            NormalizedUserName = "ZUZANNA",
                            PasswordHash = "AQAAAAIAAYagAAAAEIFIWZDIv0J5SksClaHCn4EC+pcKurC6mm2nOPJLXmPE+knsDcIrnLLVaSgS9OvO5w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a5fec36b-1b01-48be-8537-672179d46b31",
                            TwoFactorEnabled = false,
                            UserName = "zuzanna"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "ee776100-9a00-43d9-bccc-8edae0042523",
                            RoleId = "ed192f30-9146-44cf-af35-ca747de699da"
                        },
                        new
                        {
                            UserId = "61ae0669-417d-4fe3-a918-14046c99e7b7",
                            RoleId = "1e083dbd-f018-455e-b5b9-a309e1bd2613"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Data.Entities.AuthorEntity", b =>
                {
                    b.OwnsOne("Data.Address", "Address", b1 =>
                        {
                            b1.Property<int>("AuthorEntityAuthorId")
                                .HasColumnType("INTEGER");

                            b1.Property<int?>("ApartamentNr")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("HomeNr")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("PostalCode")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("Region")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.HasKey("AuthorEntityAuthorId");

                            b1.ToTable("authors");

                            b1.WithOwner()
                                .HasForeignKey("AuthorEntityAuthorId");

                            b1.HasData(
                                new
                                {
                                    AuthorEntityAuthorId = 1,
                                    City = "Poznań",
                                    Country = "Polska",
                                    HomeNr = "22",
                                    PostalCode = "42-152",
                                    Region = "Wielkopolska",
                                    Street = "Pomorska"
                                },
                                new
                                {
                                    AuthorEntityAuthorId = 2,
                                    City = "Kraków",
                                    Country = "Polska",
                                    HomeNr = "17",
                                    PostalCode = "31-150",
                                    Region = "Małopolska",
                                    Street = "Św. Filipa"
                                },
                                new
                                {
                                    AuthorEntityAuthorId = 3,
                                    ApartamentNr = 6,
                                    City = "Kraków",
                                    Country = "Polska",
                                    HomeNr = "46",
                                    PostalCode = "42-400",
                                    Region = "Małopolska",
                                    Street = "Krowoderska"
                                },
                                new
                                {
                                    AuthorEntityAuthorId = 4,
                                    City = "Katowice",
                                    Country = "Polska",
                                    HomeNr = "99E",
                                    PostalCode = "32-120",
                                    Region = "Śląsk",
                                    Street = "Piłsudskiego"
                                });
                        });

                    b.Navigation("Address")
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Entities.ContactEntity", b =>
                {
                    b.HasOne("Data.Entities.OrganizationEntity", "Organization")
                        .WithMany("Contacts")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("Data.Entities.OrganizationEntity", b =>
                {
                    b.OwnsOne("Data.Address", "Address", b1 =>
                        {
                            b1.Property<int>("OrganizationEntityOrganizationId")
                                .HasColumnType("INTEGER");

                            b1.Property<int?>("ApartamentNr")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("HomeNr")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("PostalCode")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("Region")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.HasKey("OrganizationEntityOrganizationId");

                            b1.ToTable("organizations");

                            b1.WithOwner()
                                .HasForeignKey("OrganizationEntityOrganizationId");

                            b1.HasData(
                                new
                                {
                                    OrganizationEntityOrganizationId = 1,
                                    City = "none",
                                    Country = "none",
                                    HomeNr = "none",
                                    PostalCode = "00-000",
                                    Region = "none",
                                    Street = "none"
                                },
                                new
                                {
                                    OrganizationEntityOrganizationId = 2,
                                    City = "Kraków",
                                    Country = "Polska",
                                    HomeNr = "17",
                                    PostalCode = "31-150",
                                    Region = "Małopolska",
                                    Street = "Św. Filipa"
                                },
                                new
                                {
                                    OrganizationEntityOrganizationId = 3,
                                    ApartamentNr = 6,
                                    City = "Kraków",
                                    Country = "Polska",
                                    HomeNr = "46",
                                    PostalCode = "42-400",
                                    Region = "Małopolska",
                                    Street = "Krowoderska"
                                },
                                new
                                {
                                    OrganizationEntityOrganizationId = 4,
                                    City = "Katowice",
                                    Country = "Polska",
                                    HomeNr = "99E",
                                    PostalCode = "32-120",
                                    Region = "Śląsk",
                                    Street = "Piłsudskiego"
                                });
                        });

                    b.Navigation("Address")
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Entities.PhotoEntity", b =>
                {
                    b.HasOne("Data.Entities.AuthorEntity", "Authors")
                        .WithMany("Photos")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Authors");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Entities.AuthorEntity", b =>
                {
                    b.Navigation("Photos");
                });

            modelBuilder.Entity("Data.Entities.OrganizationEntity", b =>
                {
                    b.Navigation("Contacts");
                });
#pragma warning restore 612, 618
        }
    }
}

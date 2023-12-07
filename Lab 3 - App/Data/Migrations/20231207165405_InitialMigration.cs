﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("AspNetRoles");
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.DropTable("AspNetUsers");
            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.DropTable("authors");
            migrationBuilder.CreateTable(
                name: "authors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Surname = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Note = table.Column<string>(type: "TEXT", nullable: true),
                    Address_Street = table.Column<string>(type: "TEXT", nullable: false),
                    Address_HomeNr = table.Column<string>(type: "TEXT", nullable: false),
                    Address_ApartamentNr = table.Column<int>(type: "INTEGER", nullable: true),
                    Address_PostalCode = table.Column<string>(type: "TEXT", nullable: false),
                    Address_City = table.Column<string>(type: "TEXT", nullable: false),
                    Address_Region = table.Column<string>(type: "TEXT", nullable: false),
                    Address_Country = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_authors", x => x.AuthorId);
                });

            migrationBuilder.DropTable("organizations");
            migrationBuilder.CreateTable(
                name: "organizations",
                columns: table => new
                {
                    OrganizationId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Regon = table.Column<long>(type: "INTEGER", nullable: false),
                    Nip = table.Column<long>(type: "INTEGER", nullable: false),
                    Address_Street = table.Column<string>(type: "TEXT", nullable: false),
                    Address_HomeNr = table.Column<string>(type: "TEXT", nullable: false),
                    Address_ApartamentNr = table.Column<int>(type: "INTEGER", nullable: true),
                    Address_PostalCode = table.Column<string>(type: "TEXT", nullable: false),
                    Address_City = table.Column<string>(type: "TEXT", nullable: false),
                    Address_Region = table.Column<string>(type: "TEXT", nullable: false),
                    Address_Country = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_organizations", x => x.OrganizationId);
                });

            migrationBuilder.DropTable("AspNetRoleClaims");
            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.DropTable("AspNetUserClaims");
            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.DropTable("AspNetUserLogins");
            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.DropTable("AspNetUserRoles");
            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.DropTable("AspNetUserTokens");
            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.DropTable("photos");
            migrationBuilder.CreateTable(
                name: "photos",
                columns: table => new
                {
                    PhotoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date_time = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Camera = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Definition = table.Column<int>(type: "INTEGER", nullable: false),
                    Format = table.Column<int>(type: "INTEGER", nullable: false),
                    AuthorId = table.Column<int>(type: "INTEGER", nullable: false),
                    PhotoUrl = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_photos", x => x.PhotoId);
                    table.ForeignKey(
                        name: "FK_photos_authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.DropTable("contacts");
            migrationBuilder.CreateTable(
                name: "contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "TEXT", maxLength: 12, nullable: false),
                    Note = table.Column<string>(type: "TEXT", nullable: true),
                    Priority = table.Column<int>(type: "INTEGER", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    OrganizationId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contacts", x => x.ContactId);
                    table.ForeignKey(
                        name: "FK_contacts_organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "organizations",
                        principalColumn: "OrganizationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4eff5f6f-11d6-4a75-a2f8-e49e8bcf0fd1", "4eff5f6f-11d6-4a75-a2f8-e49e8bcf0fd1", "admin", "ADMIN" },
                    { "ee12adda-468e-4e63-9cef-48e4fbc468dd", "ee12adda-468e-4e63-9cef-48e4fbc468dd", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1c4002de-d34c-4ec9-87d4-a776ed817896", 0, "861db507-d8bf-4494-9f49-aab31a292975", "oskar@wsei.edu.pl", true, false, null, "OSKAR@WSEI.EDU.PL", "OSKAR", "AQAAAAIAAYagAAAAECp2XLyhqAaSU+wymrTffqY323d5aeknYeyHRoHDZfOs1PvC8OU6C6VmNdH8eIS08Q==", null, false, "b63cdd95-9e3b-48f6-a9a5-fc1c7c17a31d", false, "oskar" },
                    { "82afbb7b-5ad8-4151-b49a-e2f49fb4d876", 0, "f7279548-b9ba-439e-9e06-577672a13070", "zuzia@wsei.edu.pl", true, false, null, "ZUZIA@WSEI.EDU.PL", "ZUZANNA", "AQAAAAIAAYagAAAAENRLn00WvL03GlB729NejOY0pGMyn6R77vsxNhtQC+wC54ExBivAPQSRutx+lVuj0Q==", null, false, "9caf0cfb-505a-47bf-ae94-5b5952914f7b", false, "zuzanna" }
                });

            migrationBuilder.InsertData(
                table: "authors",
                columns: new[] { "AuthorId", "Email", "Name", "Note", "Surname", "Address_ApartamentNr", "Address_City", "Address_Country", "Address_HomeNr", "Address_PostalCode", "Address_Region", "Address_Street" },
                values: new object[,]
                {
                    { 1, "akwasny@wp.pl", "Adam", "student", "Kwaśny", null, "Poznań", "Polska", "22", "42-152", "Wielkopolska", "Pomorska" },
                    { 2, "tsur@wp.pl", "Tomasz", "praktykant", "Surówka", null, "Kraków", "Polska", "17", "31-150", "Małopolska", "Św. Filipa" },
                    { 3, "majalub@wp.pl", "Mariola", "fotograf ślubny", "Lubicz", 6, "Kraków", "Polska", "46", "42-400", "Małopolska", "Krowoderska" },
                    { 4, "lrdw@wp.pl", "Łukasz", "fotograf natury", "Radwan", null, "Katowice", "Polska", "99E", "32-120", "Śląsk", "Piłsudskiego" }
                });

            migrationBuilder.InsertData(
                table: "organizations",
                columns: new[] { "OrganizationId", "Description", "Nip", "Regon", "Title", "Address_ApartamentNr", "Address_City", "Address_Country", "Address_HomeNr", "Address_PostalCode", "Address_Region", "Address_Street" },
                values: new object[,]
                {
                    { 1, null, 0L, 0L, "--", null, "none", "none", "none", "00-000", "none", "none" },
                    { 2, "Szkoła wysza", 6762158990L, 357191420L, "WSEI", null, "Kraków", "Polska", "17", "31-150", "Małopolska", "Św. Filipa" },
                    { 3, "Działalnośc własna", 1357895472L, 367891434L, "RAKSO", 6, "Kraków", "Polska", "46", "42-400", "Małopolska", "Krowoderska" },
                    { 4, "Piekarnia", 3456789091L, 872358792L, "Złoty kłos", null, "Katowice", "Polska", "99E", "32-120", "Śląsk", "Piłsudskiego" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "4eff5f6f-11d6-4a75-a2f8-e49e8bcf0fd1", "1c4002de-d34c-4ec9-87d4-a776ed817896" },
                    { "ee12adda-468e-4e63-9cef-48e4fbc468dd", "82afbb7b-5ad8-4151-b49a-e2f49fb4d876" }
                });

            migrationBuilder.InsertData(
                table: "contacts",
                columns: new[] { "ContactId", "BirthDate", "Created", "Email", "Name", "Note", "OrganizationId", "Phone", "Priority", "Surname" },
                values: new object[,]
                {
                    { 1, new DateTime(2007, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "karolos@mail.com", "Oskar", null, 2, "123123123", 1, "Karolczyk" },
                    { 2, new DateTime(2008, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tmurarz@mail.com", "Tomasz", null, 3, "091912424", 2, "Murawski" },
                    { 3, new DateTime(2000, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "boskazuzia@mail.com", "Zuzanna", null, 3, "678998786", 3, "Boska" }
                });

            migrationBuilder.InsertData(
                table: "photos",
                columns: new[] { "PhotoId", "AuthorId", "Camera", "Date_time", "Definition", "Description", "Format", "PhotoUrl" },
                values: new object[,]
                {
                    { 1, 3, "Nikon", new DateTime(2008, 8, 1, 12, 59, 16, 0, DateTimeKind.Unspecified), 2, "Pejzaż górski", 4, "https://westerncamp.pl/wp-content/uploads/2023/10/tatry-1080x675.jpg" },
                    { 2, 3, "Canon", new DateTime(2018, 7, 11, 10, 9, 11, 0, DateTimeKind.Unspecified), 6, "Sowa", 1, "https://bi.im-g.pl/im/20/19/1b/z28415520AMP,Puszczyk-zwyczajny.jpg" },
                    { 3, 1, "Nikon", new DateTime(1998, 11, 11, 11, 10, 9, 0, DateTimeKind.Unspecified), 7, "Znak górski", 2, "https://zieloniwpodrozy.pl/wp-content/uploads/2015/06/Zdjęcie-wykonane-o-świcie-na-Połoninie-Caryńskiej-podczas-naszej-krótkiej-wycieczki-w-Bieszczady..jpg" },
                    { 4, 4, "Sony", new DateTime(2012, 2, 7, 23, 15, 34, 0, DateTimeKind.Unspecified), 3, "Śniadanie", 5, "https://szefsmaku.pl/wp-content/uploads/2019/02/sniadanie-to-podstawa.jpg" },
                    { 5, 3, "Iphone", new DateTime(2000, 1, 1, 13, 10, 35, 0, DateTimeKind.Unspecified), 4, "Kotek", 3, "https://img.redro.pl/obrazy/czarny-dlugowlosy-kot-700-204992097.jpg" },
                    { 6, 2, "screen", new DateTime(2019, 4, 9, 10, 14, 44, 0, DateTimeKind.Unspecified), 6, "Szpic miniaturowy", 2, "https://ocdn.eu/pulscms-transforms/1/-LUk9kqTURBXy83ZTRmYjIyNmI0YWUxZDZlZjg2OWM4ZTFjY2YxNDE5My5qcGVnk5UDzQHIzQEKzQnszQWVkwXNBLDNAqSTCaY2ZTQwMzgG3gABoTAB/marzy-ci-sie-bezproblemowy-pies-poznaj-rasy-ktore-nie-sprawia-duzo-klopotu.jpeg" },
                    { 7, 2, "Nokia", new DateTime(2017, 11, 12, 2, 1, 3, 0, DateTimeKind.Unspecified), 2, "College", 1, "https://educat.study/wp-content/uploads/2023/09/4585094076_902c32b4cf_b.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_contacts_OrganizationId",
                table: "contacts",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_photos_AuthorId",
                table: "photos",
                column: "AuthorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "contacts");

            migrationBuilder.DropTable(
                name: "photos");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "organizations");

            migrationBuilder.DropTable(
                name: "authors");
        }
    }
}

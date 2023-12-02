using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPhotoApp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d5ad53a5-c13a-4dfc-a758-58eae5f41e6a", "b0c0c2f5-a369-4738-ad43-bc100a430bd2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "96e7699b-de2b-4dba-84ee-e2aa9319e264", "c697e872-3e9a-4c46-a4c2-3db68b5ec4dd" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96e7699b-de2b-4dba-84ee-e2aa9319e264");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5ad53a5-c13a-4dfc-a758-58eae5f41e6a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0c0c2f5-a369-4738-ad43-bc100a430bd2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c697e872-3e9a-4c46-a4c2-3db68b5ec4dd");

            migrationBuilder.CreateTable(
                name: "authors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
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

            migrationBuilder.CreateTable(
                name: "photos",
                columns: table => new
                {
                    PhotoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date_time = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Camera = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    AuthorId = table.Column<int>(type: "INTEGER", maxLength: 100, nullable: false),
                    Definition = table.Column<int>(type: "INTEGER", nullable: false),
                    Format = table.Column<int>(type: "INTEGER", nullable: false)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "618853b4-2125-4dcf-be06-a9d4e7be0870", "618853b4-2125-4dcf-be06-a9d4e7be0870", "user", "USER" },
                    { "679425a5-c999-472b-8b6d-e3cabff9b9c1", "679425a5-c999-472b-8b6d-e3cabff9b9c1", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "92afaecb-02b4-422a-847c-83ad41c84597", 0, "536f4022-f5d8-4858-ae30-6f9a6b2b5724", "zuzia@wsei.edu.pl", true, false, null, "ZUZIA@WSEI.EDU.PL", "ZUZANNA", "AQAAAAIAAYagAAAAEEYUnRu6aQGyhKxrjIL20tP1Dy2vhyYCA+mzdgOHkJrrNWXPdOMdtSwFdmaWBWU5yw==", null, false, "a5fd7b0a-bb88-41cd-9778-e5ed380f5fac", false, "zuzanna" },
                    { "c6a345d1-c5cb-4d93-9f24-48c1969e098d", 0, "558ba046-5662-4589-bdaa-148c55de10c9", "oskar@wsei.edu.pl", true, false, null, "OSKAR@WSEI.EDU.PL", "OSKAR", "AQAAAAIAAYagAAAAEE/7G9pjEuf3xx5l2Okj4MKNpUOQI9ggnx/pwr+l6cA7lG9cKEQcdl3hS0BaiMeSsw==", null, false, "da5c30e9-78d0-41c7-9f12-4c935a76c6fa", false, "oskar" }
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
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "618853b4-2125-4dcf-be06-a9d4e7be0870", "92afaecb-02b4-422a-847c-83ad41c84597" },
                    { "679425a5-c999-472b-8b6d-e3cabff9b9c1", "c6a345d1-c5cb-4d93-9f24-48c1969e098d" }
                });

            migrationBuilder.InsertData(
                table: "photos",
                columns: new[] { "PhotoId", "AuthorId", "Camera", "Date_time", "Definition", "Description", "Format" },
                values: new object[,]
                {
                    { 1, 3, "Nikon", new DateTime(2008, 8, 1, 12, 59, 16, 0, DateTimeKind.Unspecified), 2, "Zdjęcie kwiatka", 4 },
                    { 2, 3, "Canon", new DateTime(2018, 7, 11, 10, 9, 11, 0, DateTimeKind.Unspecified), 6, "Zdjęcie pary młodej", 1 },
                    { 3, 1, "Nikon", new DateTime(1998, 11, 11, 11, 10, 9, 0, DateTimeKind.Unspecified), 7, "Zdjęcie Nissana GTR", 2 },
                    { 4, 4, "Sony", new DateTime(2012, 2, 7, 23, 15, 34, 0, DateTimeKind.Unspecified), 3, "Zdjęcie willi", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_photos_AuthorId",
                table: "photos",
                column: "AuthorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "photos");

            migrationBuilder.DropTable(
                name: "authors");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "618853b4-2125-4dcf-be06-a9d4e7be0870", "92afaecb-02b4-422a-847c-83ad41c84597" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "679425a5-c999-472b-8b6d-e3cabff9b9c1", "c6a345d1-c5cb-4d93-9f24-48c1969e098d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "618853b4-2125-4dcf-be06-a9d4e7be0870");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "679425a5-c999-472b-8b6d-e3cabff9b9c1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92afaecb-02b4-422a-847c-83ad41c84597");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6a345d1-c5cb-4d93-9f24-48c1969e098d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "96e7699b-de2b-4dba-84ee-e2aa9319e264", "96e7699b-de2b-4dba-84ee-e2aa9319e264", "admin", "ADMIN" },
                    { "d5ad53a5-c13a-4dfc-a758-58eae5f41e6a", "d5ad53a5-c13a-4dfc-a758-58eae5f41e6a", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b0c0c2f5-a369-4738-ad43-bc100a430bd2", 0, "ee1de59e-b31c-400b-b0d7-feee6bf956b1", "zuzia@wsei.edu.pl", true, false, null, "ZUZIA@WSEI.EDU.PL", "ZUZANNA", "AQAAAAIAAYagAAAAEN+e2GeAGXRRnbFZBt9vbS35K1aqCZAvxV+RQ3qqB+mH+dr54+KlcXAO0wdI2/poBQ==", null, false, "b0c4b22d-e575-406d-96c3-b650040114d7", false, "zuzanna" },
                    { "c697e872-3e9a-4c46-a4c2-3db68b5ec4dd", 0, "f273a700-11cf-41a1-a3c7-c8c9b5618c6e", "oskar@wsei.edu.pl", true, false, null, "OSKAR@WSEI.EDU.PL", "OSKAR", "AQAAAAIAAYagAAAAEN7SAfW6ysf50S3NmzEoRfpRSrldYIMjWZgnEOfQQbBKPZNplLEujqVZwcf5OkmhFA==", null, false, "4ac8bf29-c1ba-45ef-8058-7055883f4e9c", false, "oskar" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "d5ad53a5-c13a-4dfc-a758-58eae5f41e6a", "b0c0c2f5-a369-4738-ad43-bc100a430bd2" },
                    { "96e7699b-de2b-4dba-84ee-e2aa9319e264", "c697e872-3e9a-4c46-a4c2-3db68b5ec4dd" }
                });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "TEXT", maxLength: 12, nullable: false),
                    Note = table.Column<string>(type: "TEXT", nullable: true),
                    Priority = table.Column<int>(type: "INTEGER", nullable: false),
                    birth_date = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contacts", x => x.ContactId);
                });

            migrationBuilder.InsertData(
                table: "contacts",
                columns: new[] { "ContactId", "birth_date", "Email", "Name", "Note", "Phone", "Priority", "Surname" },
                values: new object[,]
                {
                    { 1, new DateTime(2007, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "karolos@mail.com", "Oskar", null, "123123123", 3, "Karolczyk" },
                    { 2, new DateTime(2008, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tmurarz@mail.com", "Tomasz", null, "091912424", 2, "Murawski" },
                    { 3, new DateTime(2000, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "boskazuzia@mail.com", "Zuzanna", null, "678998786", 1, "Boska" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contacts");
        }
    }
}

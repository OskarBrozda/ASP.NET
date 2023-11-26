using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentity2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d127d02-7326-47a2-9e32-235fe6c30f84");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4bcddf34-028c-482a-b81c-63d05cd629ac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b6cbfbd-3eaa-4a4c-a8dd-299d3ca4d2b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "364f857d-cdb0-41ba-96ef-5901ec178a02");

            migrationBuilder.AlterColumn<int>(
                name: "OrganizationId",
                table: "organizations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "703715d3-9c29-421f-bb86-fc3594658354", "703715d3-9c29-421f-bb86-fc3594658354", "admin", "ADMIN" },
                    { "dbee72c7-63cd-4f49-9235-3149be2686a4", "dbee72c7-63cd-4f49-9235-3149be2686a4", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "267491b2-c8a1-4088-90a9-86a3dc37203f", 0, "c4f6df59-c0c3-4aa8-acd9-3222dea53609", "oskar@wsei.edu.pl", true, false, null, "OSKAR@WSEI.EDU.PL", "OSKAR", "AQAAAAIAAYagAAAAEEme1aD9RctUzQafUSWcNV68sFP1/PlCv4wot97GDBCWF0R8ITtsfyAgNKWOFQXSkw==", null, false, "d16d891c-c3b2-47f7-b252-972f9feea3ab", false, "oskar" },
                    { "7d6b10df-0bdc-4584-8770-ee4e6e300471", 0, "0d6a18f3-dd24-48c9-83a5-13fc88e89670", "zuzia@wsei.edu.pl", true, false, null, "ZUZIA@WSEI.EDU.PL", "ZUZANNA", "AQAAAAIAAYagAAAAEKDAb9hR4tUDSoXsn3OkGE7HNVfu5JQaq/t8FdfaszPfqXGob1g+i4JkSsX1lYcr/A==", null, false, "cff4584c-4553-40d7-87d3-8bb3f7e45839", false, "zuzanna" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "703715d3-9c29-421f-bb86-fc3594658354", "267491b2-c8a1-4088-90a9-86a3dc37203f" },
                    { "dbee72c7-63cd-4f49-9235-3149be2686a4", "7d6b10df-0bdc-4584-8770-ee4e6e300471" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "703715d3-9c29-421f-bb86-fc3594658354", "267491b2-c8a1-4088-90a9-86a3dc37203f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dbee72c7-63cd-4f49-9235-3149be2686a4", "7d6b10df-0bdc-4584-8770-ee4e6e300471" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "703715d3-9c29-421f-bb86-fc3594658354");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dbee72c7-63cd-4f49-9235-3149be2686a4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "267491b2-c8a1-4088-90a9-86a3dc37203f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7d6b10df-0bdc-4584-8770-ee4e6e300471");

            migrationBuilder.AlterColumn<int>(
                name: "OrganizationId",
                table: "organizations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0d127d02-7326-47a2-9e32-235fe6c30f84", "0d127d02-7326-47a2-9e32-235fe6c30f84", "admin", "ADMIN" },
                    { "4bcddf34-028c-482a-b81c-63d05cd629ac", "4bcddf34-028c-482a-b81c-63d05cd629ac", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0b6cbfbd-3eaa-4a4c-a8dd-299d3ca4d2b8", 0, "6819375f-332b-44e6-9aeb-4e9f6843e38b", "zuzia@wsei.edu.pl", true, false, null, "ZUZIA@WSEI.EDU>PL", "ZUZIA", "AQAAAAIAAYagAAAAEPyS1XVOUkAByJDZPqGXopaozYQZzi+i9PZI0E9WKDBzNnZjeVPNKBSq/wmJkFVSAQ==", null, false, "9493a5db-8cd9-4b2e-97ab-8d004a1717c3", false, "zuzia" },
                    { "364f857d-cdb0-41ba-96ef-5901ec178a02", 0, "63f51f93-3f3b-4a89-9c94-30224638296e", "oskar@wsei.edu.pl", true, false, null, "OSKAR@WSEI.EDU>PL", "OSKAR", "AQAAAAIAAYagAAAAEDNx+uno6aHt4uB1AGKKQz0zFaBy3n7gjaRQhAXm6aTz205wzDn1rMoX2DEk8Vosgw==", null, false, "0567cf64-f122-4430-a565-c73521c858eb", false, "oskar" }
                });
        }
    }
}

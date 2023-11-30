using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class ModifyOrganization : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "organizations",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1f6be099-45e0-4179-a712-5c4d04ee91e8", "1f6be099-45e0-4179-a712-5c4d04ee91e8", "admin", "ADMIN" },
                    { "b889d5f0-254e-461d-8f41-97a0ca5101c2", "b889d5f0-254e-461d-8f41-97a0ca5101c2", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9a0cf090-49fd-476e-adcb-75637f8dfb4c", 0, "2d87e1cf-bebe-4d83-a6f1-eafb5699a9cb", "zuzia@wsei.edu.pl", true, false, null, "ZUZIA@WSEI.EDU.PL", "ZUZANNA", "AQAAAAIAAYagAAAAECBO8UGiYCAVaR6/MTKW8kjda3rmzD8OC/PrVtaLVg8L6c5/+RWOemIqDmyPNCf+vg==", null, false, "3cbb9ebc-1407-4e06-89c8-4e65091401bf", false, "zuzanna" },
                    { "a804b437-edc5-493c-8468-88ddaf4f14a7", 0, "bde71af1-dd10-4bbd-8ca5-f141ee54fca3", "oskar@wsei.edu.pl", true, false, null, "OSKAR@WSEI.EDU.PL", "OSKAR", "AQAAAAIAAYagAAAAEKKKseSdfQ+/SMD2odC73WRaB2d21uVcp2Ug9YWMPORumg/7bDQ4nrr/4smoLhnn9A==", null, false, "8072639c-da88-4900-9c75-d5272a61ca30", false, "oskar" }
                });

            migrationBuilder.UpdateData(
                table: "organizations",
                keyColumn: "OrganizationId",
                keyValue: 1,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "organizations",
                keyColumn: "OrganizationId",
                keyValue: 2,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "organizations",
                keyColumn: "OrganizationId",
                keyValue: 3,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "organizations",
                keyColumn: "OrganizationId",
                keyValue: 4,
                column: "Description",
                value: null);

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b889d5f0-254e-461d-8f41-97a0ca5101c2", "9a0cf090-49fd-476e-adcb-75637f8dfb4c" },
                    { "1f6be099-45e0-4179-a712-5c4d04ee91e8", "a804b437-edc5-493c-8468-88ddaf4f14a7" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b889d5f0-254e-461d-8f41-97a0ca5101c2", "9a0cf090-49fd-476e-adcb-75637f8dfb4c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1f6be099-45e0-4179-a712-5c4d04ee91e8", "a804b437-edc5-493c-8468-88ddaf4f14a7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f6be099-45e0-4179-a712-5c4d04ee91e8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b889d5f0-254e-461d-8f41-97a0ca5101c2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a0cf090-49fd-476e-adcb-75637f8dfb4c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a804b437-edc5-493c-8468-88ddaf4f14a7");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "organizations");

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
    }
}

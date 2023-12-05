using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class AddUrlAndPathForFiles2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "230522b5-811e-4b55-8b47-56170377e22b", "48e75e75-e18b-4a2a-91f7-a871337c0823" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6819d05d-3c07-4554-8b7e-80e76abf5886", "afeb61d0-1e29-4ad0-a12d-480b356af745" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "230522b5-811e-4b55-8b47-56170377e22b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6819d05d-3c07-4554-8b7e-80e76abf5886");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48e75e75-e18b-4a2a-91f7-a871337c0823");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afeb61d0-1e29-4ad0-a12d-480b356af745");

            migrationBuilder.AddColumn<string>(
                name: "PhotoUrl",
                table: "photos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6395590a-ce0a-4593-a3c6-205965bfe4a4", "6395590a-ce0a-4593-a3c6-205965bfe4a4", "user", "USER" },
                    { "a9a231bd-fada-4381-a52d-ac8e31c31e58", "a9a231bd-fada-4381-a52d-ac8e31c31e58", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1e293fd3-9289-4c69-a07e-13e13f64d403", 0, "6f4ce065-5015-4b7e-8e76-9f8b6a60763f", "zuzia@wsei.edu.pl", true, false, null, "ZUZIA@WSEI.EDU.PL", "ZUZANNA", "AQAAAAIAAYagAAAAEISonyOO1ortw/JSPLf6hl29cP3reuWXaXT7zXOjnQZfqgXCn+R4hOoapRBmQyphXg==", null, false, "80eacd03-6954-4935-ac29-1cf487a3e68e", false, "zuzanna" },
                    { "d976ba39-2a6b-43b1-ad5a-9b8c87fe821f", 0, "3bff8b0c-b26b-4fd6-91ee-955d00b095e4", "oskar@wsei.edu.pl", true, false, null, "OSKAR@WSEI.EDU.PL", "OSKAR", "AQAAAAIAAYagAAAAECjh/pPIP6zMgPREiQcBN2+QaMLeb1opTKd8PF1ZehlouO9OcDwZG0T66N2Sc+gtwg==", null, false, "2360883e-eaae-4e09-a285-da9d23774e86", false, "oskar" }
                });

            migrationBuilder.UpdateData(
                table: "photos",
                keyColumn: "PhotoId",
                keyValue: 1,
                column: "PhotoUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "photos",
                keyColumn: "PhotoId",
                keyValue: 2,
                column: "PhotoUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "photos",
                keyColumn: "PhotoId",
                keyValue: 3,
                column: "PhotoUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "photos",
                keyColumn: "PhotoId",
                keyValue: 4,
                column: "PhotoUrl",
                value: null);

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6395590a-ce0a-4593-a3c6-205965bfe4a4", "1e293fd3-9289-4c69-a07e-13e13f64d403" },
                    { "a9a231bd-fada-4381-a52d-ac8e31c31e58", "d976ba39-2a6b-43b1-ad5a-9b8c87fe821f" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6395590a-ce0a-4593-a3c6-205965bfe4a4", "1e293fd3-9289-4c69-a07e-13e13f64d403" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a9a231bd-fada-4381-a52d-ac8e31c31e58", "d976ba39-2a6b-43b1-ad5a-9b8c87fe821f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6395590a-ce0a-4593-a3c6-205965bfe4a4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9a231bd-fada-4381-a52d-ac8e31c31e58");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e293fd3-9289-4c69-a07e-13e13f64d403");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d976ba39-2a6b-43b1-ad5a-9b8c87fe821f");

            migrationBuilder.DropColumn(
                name: "PhotoUrl",
                table: "photos");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "230522b5-811e-4b55-8b47-56170377e22b", "230522b5-811e-4b55-8b47-56170377e22b", "user", "USER" },
                    { "6819d05d-3c07-4554-8b7e-80e76abf5886", "6819d05d-3c07-4554-8b7e-80e76abf5886", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "48e75e75-e18b-4a2a-91f7-a871337c0823", 0, "77a8cd6e-1530-49c8-b848-02ccef677e46", "zuzia@wsei.edu.pl", true, false, null, "ZUZIA@WSEI.EDU.PL", "ZUZANNA", "AQAAAAIAAYagAAAAEP71GUuKq1g4galefaUe5w6/6lQG8upQHbcjTLOkI7tFiwPuV5J+RqRCfjyWmKiZbw==", null, false, "db258c05-34c8-4a2b-ba99-276cc47e714a", false, "zuzanna" },
                    { "afeb61d0-1e29-4ad0-a12d-480b356af745", 0, "ebbfc04f-7336-4e7d-81a1-4a73a60e0376", "oskar@wsei.edu.pl", true, false, null, "OSKAR@WSEI.EDU.PL", "OSKAR", "AQAAAAIAAYagAAAAEHWLblifU1LcV1ge8fMcNvjdFWhyswWpFYTcyNS7AHKEoTlVfEWwL/lqJpHTsl73Xg==", null, false, "a0942d09-bdd5-4209-9814-100cc5219dbf", false, "oskar" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "230522b5-811e-4b55-8b47-56170377e22b", "48e75e75-e18b-4a2a-91f7-a871337c0823" },
                    { "6819d05d-3c07-4554-8b7e-80e76abf5886", "afeb61d0-1e29-4ad0-a12d-480b356af745" }
                });
        }
    }
}

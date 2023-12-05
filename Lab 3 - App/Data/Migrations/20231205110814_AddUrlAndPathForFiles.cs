using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class AddUrlAndPathForFiles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "37cf64a1-d23a-4b25-b1ca-a72d44b24a50", "6afa21ca-5106-4db9-83d3-d2f27a106fbd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6e6467db-6670-4c85-89e1-4580b32a64fc", "8c5c33cb-7d42-476e-9122-69bb88792e01" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37cf64a1-d23a-4b25-b1ca-a72d44b24a50");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e6467db-6670-4c85-89e1-4580b32a64fc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6afa21ca-5106-4db9-83d3-d2f27a106fbd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c5c33cb-7d42-476e-9122-69bb88792e01");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "37cf64a1-d23a-4b25-b1ca-a72d44b24a50", "37cf64a1-d23a-4b25-b1ca-a72d44b24a50", "admin", "ADMIN" },
                    { "6e6467db-6670-4c85-89e1-4580b32a64fc", "6e6467db-6670-4c85-89e1-4580b32a64fc", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6afa21ca-5106-4db9-83d3-d2f27a106fbd", 0, "f338820a-21fd-4418-bcdd-3ecee8bb5e2f", "oskar@wsei.edu.pl", true, false, null, "OSKAR@WSEI.EDU.PL", "OSKAR", "AQAAAAIAAYagAAAAENE+zYvY509u3t7JZgdUERqxs7PV+qQrZvogrFTNPnsngmLy2PZ94CwUM6T/7kFF5w==", null, false, "4cd8b5e3-7dc6-4dd1-9883-ccaf46bdc29b", false, "oskar" },
                    { "8c5c33cb-7d42-476e-9122-69bb88792e01", 0, "73b6d93c-1e33-41f3-ba6f-63fdf36b2795", "zuzia@wsei.edu.pl", true, false, null, "ZUZIA@WSEI.EDU.PL", "ZUZANNA", "AQAAAAIAAYagAAAAEGTC/x3eXnAJGVYPeVIvJzQLHHIRxEXb9hFRe4DV6crofXgUOdtJ/eGmdod+001kIw==", null, false, "4bb95515-8f07-4efa-88b2-86be318c85dd", false, "zuzanna" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "37cf64a1-d23a-4b25-b1ca-a72d44b24a50", "6afa21ca-5106-4db9-83d3-d2f27a106fbd" },
                    { "6e6467db-6670-4c85-89e1-4580b32a64fc", "8c5c33cb-7d42-476e-9122-69bb88792e01" }
                });
        }
    }
}

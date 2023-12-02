using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangePhotoEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "618853b4-2125-4dcf-be06-a9d4e7be0870", "92afaecb-02b4-422a-847c-83ad41c84597" },
                    { "679425a5-c999-472b-8b6d-e3cabff9b9c1", "c6a345d1-c5cb-4d93-9f24-48c1969e098d" }
                });
        }
    }
}

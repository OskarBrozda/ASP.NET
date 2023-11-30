using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "308df82f-8c3d-460b-a5a7-58f6a0fac3f5", "58f9df08-f051-4ad3-968e-d841366c2eda" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ee30b277-96f0-4739-a360-7303353c15e0", "633072c7-00db-47a3-9a6e-ac7f14534cb2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "308df82f-8c3d-460b-a5a7-58f6a0fac3f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee30b277-96f0-4739-a360-7303353c15e0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58f9df08-f051-4ad3-968e-d841366c2eda");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "633072c7-00db-47a3-9a6e-ac7f14534cb2");

            migrationBuilder.AlterColumn<int>(
                name: "OrganizationId",
                table: "organizations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "Address_ApartamentNr",
                table: "organizations",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address_HomeNr",
                table: "organizations",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.UpdateData(
                table: "organizations",
                keyColumn: "OrganizationId",
                keyValue: 1,
                columns: new[] { "Address_ApartamentNr", "Address_HomeNr" },
                values: new object[] { null, "none" });

            migrationBuilder.UpdateData(
                table: "organizations",
                keyColumn: "OrganizationId",
                keyValue: 2,
                columns: new[] { "Address_ApartamentNr", "Address_HomeNr", "Address_Street" },
                values: new object[] { null, "17", "Św. Filipa" });

            migrationBuilder.UpdateData(
                table: "organizations",
                keyColumn: "OrganizationId",
                keyValue: 3,
                columns: new[] { "Address_ApartamentNr", "Address_HomeNr", "Address_Street" },
                values: new object[] { 6, "46", "Krowoderska" });

            migrationBuilder.UpdateData(
                table: "organizations",
                keyColumn: "OrganizationId",
                keyValue: 4,
                columns: new[] { "Address_ApartamentNr", "Address_HomeNr", "Address_Street" },
                values: new object[] { null, "99E", "Piłsudskiego" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "d5ad53a5-c13a-4dfc-a758-58eae5f41e6a", "b0c0c2f5-a369-4738-ad43-bc100a430bd2" },
                    { "96e7699b-de2b-4dba-84ee-e2aa9319e264", "c697e872-3e9a-4c46-a4c2-3db68b5ec4dd" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Address_ApartamentNr",
                table: "organizations");

            migrationBuilder.DropColumn(
                name: "Address_HomeNr",
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
                    { "308df82f-8c3d-460b-a5a7-58f6a0fac3f5", "308df82f-8c3d-460b-a5a7-58f6a0fac3f5", "admin", "ADMIN" },
                    { "ee30b277-96f0-4739-a360-7303353c15e0", "ee30b277-96f0-4739-a360-7303353c15e0", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "58f9df08-f051-4ad3-968e-d841366c2eda", 0, "ccf2b0ed-6336-42fe-a0f9-581ffadbf5cc", "oskar@wsei.edu.pl", true, false, null, "OSKAR@WSEI.EDU.PL", "OSKAR", "AQAAAAIAAYagAAAAEJBNPJ8puPhm5ypWVdzJclq/+lK96kEkyyVg3lE2YMcXaNZmTfOTDfEUHvIVSFVxQg==", null, false, "5bf3d6b2-a74e-473b-a7a1-a048660e6405", false, "oskar" },
                    { "633072c7-00db-47a3-9a6e-ac7f14534cb2", 0, "7e14a48f-471d-44f4-be2a-4cf6d1d49916", "zuzia@wsei.edu.pl", true, false, null, "ZUZIA@WSEI.EDU.PL", "ZUZANNA", "AQAAAAIAAYagAAAAEOGSsA1WqatCKDl/zJhLMjpsTpt0P6lg82s3FYXpi6m9zAYrZil96fRDzMn1mA1fwQ==", null, false, "ac0d0002-f89f-49f0-8400-902f78d4066a", false, "zuzanna" }
                });

            migrationBuilder.UpdateData(
                table: "organizations",
                keyColumn: "OrganizationId",
                keyValue: 2,
                column: "Address_Street",
                value: "Św. Filipa 17");

            migrationBuilder.UpdateData(
                table: "organizations",
                keyColumn: "OrganizationId",
                keyValue: 3,
                column: "Address_Street",
                value: "Krowoderska 45/6");

            migrationBuilder.UpdateData(
                table: "organizations",
                keyColumn: "OrganizationId",
                keyValue: 4,
                column: "Address_Street",
                value: "Piłsudskiego 99E");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "308df82f-8c3d-460b-a5a7-58f6a0fac3f5", "58f9df08-f051-4ad3-968e-d841366c2eda" },
                    { "ee30b277-96f0-4739-a360-7303353c15e0", "633072c7-00db-47a3-9a6e-ac7f14534cb2" }
                });
        }
    }
}

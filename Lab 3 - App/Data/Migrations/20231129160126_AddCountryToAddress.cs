using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCountryToAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Address_Street",
                table: "organizations",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address_Region",
                table: "organizations",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address_PostalCode",
                table: "organizations",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address_City",
                table: "organizations",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrganizationId",
                table: "organizations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<string>(
                name: "Address_Country",
                table: "organizations",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

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
                keyValue: 1,
                column: "Address_Country",
                value: "none");

            migrationBuilder.UpdateData(
                table: "organizations",
                keyColumn: "OrganizationId",
                keyValue: 2,
                columns: new[] { "Address_Country", "Address_Region", "Description" },
                values: new object[] { "Polska", "Małopolska", "Szkoła wysza" });

            migrationBuilder.UpdateData(
                table: "organizations",
                keyColumn: "OrganizationId",
                keyValue: 3,
                columns: new[] { "Address_Country", "Address_Region", "Description" },
                values: new object[] { "Polska", "Małopolska", "Działalnośc własna" });

            migrationBuilder.UpdateData(
                table: "organizations",
                keyColumn: "OrganizationId",
                keyValue: 4,
                columns: new[] { "Address_Country", "Address_Region", "Description" },
                values: new object[] { "Polska", "Śląsk", "Piekarnia" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "308df82f-8c3d-460b-a5a7-58f6a0fac3f5", "58f9df08-f051-4ad3-968e-d841366c2eda" },
                    { "ee30b277-96f0-4739-a360-7303353c15e0", "633072c7-00db-47a3-9a6e-ac7f14534cb2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Address_Country",
                table: "organizations");

            migrationBuilder.AlterColumn<string>(
                name: "Address_Street",
                table: "organizations",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Address_Region",
                table: "organizations",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Address_PostalCode",
                table: "organizations",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Address_City",
                table: "organizations",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

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
                keyValue: 2,
                columns: new[] { "Description", "Address_Region" },
                values: new object[] { null, "małopolska" });

            migrationBuilder.UpdateData(
                table: "organizations",
                keyColumn: "OrganizationId",
                keyValue: 3,
                columns: new[] { "Description", "Address_Region" },
                values: new object[] { null, "małopolska" });

            migrationBuilder.UpdateData(
                table: "organizations",
                keyColumn: "OrganizationId",
                keyValue: 4,
                columns: new[] { "Description", "Address_Region" },
                values: new object[] { null, "śląsk" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b889d5f0-254e-461d-8f41-97a0ca5101c2", "9a0cf090-49fd-476e-adcb-75637f8dfb4c" },
                    { "1f6be099-45e0-4179-a712-5c4d04ee91e8", "a804b437-edc5-493c-8468-88ddaf4f14a7" }
                });
        }
    }
}

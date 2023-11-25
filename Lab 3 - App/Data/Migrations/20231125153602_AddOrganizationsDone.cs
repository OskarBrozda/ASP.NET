using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class AddOrganizationsDone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "OrganizationId",
                table: "organizations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.UpdateData(
                table: "contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "Priority",
                value: 1);

            migrationBuilder.UpdateData(
                table: "contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                column: "Priority",
                value: 3);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "OrganizationId",
                table: "organizations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.UpdateData(
                table: "contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "Priority",
                value: 3);

            migrationBuilder.UpdateData(
                table: "contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                column: "Priority",
                value: 1);
        }
    }
}

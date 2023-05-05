using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Karmaplusplus.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "Services",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceId",
                keyValue: 1,
                columns: new[] { "UserId", "ZipCode" },
                values: new object[] { "123", "98052" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceId",
                keyValue: 2,
                columns: new[] { "UserId", "ZipCode" },
                values: new object[] { "123", "98040" });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceId",
                keyValue: 3,
                columns: new[] { "UserId", "ZipCode" },
                values: new object[] { "123", "98033" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ZipCode",
                table: "Services",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceId",
                keyValue: 1,
                columns: new[] { "UserId", "ZipCode" },
                values: new object[] { null, 98052 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceId",
                keyValue: 2,
                columns: new[] { "UserId", "ZipCode" },
                values: new object[] { null, 98040 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "ServiceId",
                keyValue: 3,
                columns: new[] { "UserId", "ZipCode" },
                values: new object[] { null, 98033 });
        }
    }
}

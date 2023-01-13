using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books_Stock_Market.Data.Migrations
{
    public partial class subjectupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsChecked",
                table: "Subjects",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Administration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 29, 15, 12, 19, 227, DateTimeKind.Utc).AddTicks(3433), new DateTime(2022, 12, 29, 15, 12, 19, 227, DateTimeKind.Utc).AddTicks(3434) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 29, 15, 12, 19, 227, DateTimeKind.Utc).AddTicks(3391), new DateTime(2022, 12, 29, 15, 12, 19, 227, DateTimeKind.Utc).AddTicks(3393) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 29, 15, 12, 19, 227, DateTimeKind.Utc).AddTicks(3411), new DateTime(2022, 12, 29, 15, 12, 19, 227, DateTimeKind.Utc).AddTicks(3411) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 29, 15, 12, 19, 227, DateTimeKind.Utc).AddTicks(3417), new DateTime(2022, 12, 29, 15, 12, 19, 227, DateTimeKind.Utc).AddTicks(3418) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 29, 15, 12, 19, 227, DateTimeKind.Utc).AddTicks(3424), new DateTime(2022, 12, 29, 15, 12, 19, 227, DateTimeKind.Utc).AddTicks(3424) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsChecked",
                table: "Subjects");

            migrationBuilder.UpdateData(
                table: "Administration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 29, 13, 48, 17, 301, DateTimeKind.Utc).AddTicks(9341), new DateTime(2022, 12, 29, 13, 48, 17, 301, DateTimeKind.Utc).AddTicks(9342) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 29, 13, 48, 17, 301, DateTimeKind.Utc).AddTicks(9304), new DateTime(2022, 12, 29, 13, 48, 17, 301, DateTimeKind.Utc).AddTicks(9306) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 29, 13, 48, 17, 301, DateTimeKind.Utc).AddTicks(9319), new DateTime(2022, 12, 29, 13, 48, 17, 301, DateTimeKind.Utc).AddTicks(9319) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 29, 13, 48, 17, 301, DateTimeKind.Utc).AddTicks(9324), new DateTime(2022, 12, 29, 13, 48, 17, 301, DateTimeKind.Utc).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 29, 13, 48, 17, 301, DateTimeKind.Utc).AddTicks(9329), new DateTime(2022, 12, 29, 13, 48, 17, 301, DateTimeKind.Utc).AddTicks(9330) });
        }
    }
}

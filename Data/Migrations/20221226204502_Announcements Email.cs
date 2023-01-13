using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books_Stock_Market.Data.Migrations
{
    public partial class AnnouncementsEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Announcements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 26, 20, 45, 2, 545, DateTimeKind.Utc).AddTicks(5082), new DateTime(2022, 12, 26, 20, 45, 2, 545, DateTimeKind.Utc).AddTicks(5084) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 26, 20, 45, 2, 545, DateTimeKind.Utc).AddTicks(5098), new DateTime(2022, 12, 26, 20, 45, 2, 545, DateTimeKind.Utc).AddTicks(5098) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 26, 20, 45, 2, 545, DateTimeKind.Utc).AddTicks(5103), new DateTime(2022, 12, 26, 20, 45, 2, 545, DateTimeKind.Utc).AddTicks(5104) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 26, 20, 45, 2, 545, DateTimeKind.Utc).AddTicks(5109), new DateTime(2022, 12, 26, 20, 45, 2, 545, DateTimeKind.Utc).AddTicks(5109) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Announcements");

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 26, 20, 39, 1, 177, DateTimeKind.Utc).AddTicks(1567), new DateTime(2022, 12, 26, 20, 39, 1, 177, DateTimeKind.Utc).AddTicks(1568) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 26, 20, 39, 1, 177, DateTimeKind.Utc).AddTicks(1585), new DateTime(2022, 12, 26, 20, 39, 1, 177, DateTimeKind.Utc).AddTicks(1585) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 26, 20, 39, 1, 177, DateTimeKind.Utc).AddTicks(1590), new DateTime(2022, 12, 26, 20, 39, 1, 177, DateTimeKind.Utc).AddTicks(1590) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 26, 20, 39, 1, 177, DateTimeKind.Utc).AddTicks(1595), new DateTime(2022, 12, 26, 20, 39, 1, 177, DateTimeKind.Utc).AddTicks(1595) });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books_Stock_Market.Data.Migrations
{
    public partial class AnnouncementUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "PhoneAgree",
                table: "Announcements",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneAgree",
                table: "Announcements");

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 26, 20, 8, 20, 650, DateTimeKind.Utc).AddTicks(4100), new DateTime(2022, 12, 26, 20, 8, 20, 650, DateTimeKind.Utc).AddTicks(4101) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 26, 20, 8, 20, 650, DateTimeKind.Utc).AddTicks(4113), new DateTime(2022, 12, 26, 20, 8, 20, 650, DateTimeKind.Utc).AddTicks(4113) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 26, 20, 8, 20, 650, DateTimeKind.Utc).AddTicks(4119), new DateTime(2022, 12, 26, 20, 8, 20, 650, DateTimeKind.Utc).AddTicks(4119) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 26, 20, 8, 20, 650, DateTimeKind.Utc).AddTicks(4123), new DateTime(2022, 12, 26, 20, 8, 20, 650, DateTimeKind.Utc).AddTicks(4123) });
        }
    }
}

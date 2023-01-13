using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books_Stock_Market.Data.Migrations
{
    public partial class AnnouncementRequests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsChecked",
                table: "Announcements",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsChecked",
                table: "Announcements");

            migrationBuilder.UpdateData(
                table: "Administration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 29, 11, 42, 28, 227, DateTimeKind.Utc).AddTicks(4129), new DateTime(2022, 12, 29, 11, 42, 28, 227, DateTimeKind.Utc).AddTicks(4130) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 29, 11, 42, 28, 227, DateTimeKind.Utc).AddTicks(4077), new DateTime(2022, 12, 29, 11, 42, 28, 227, DateTimeKind.Utc).AddTicks(4081) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 29, 11, 42, 28, 227, DateTimeKind.Utc).AddTicks(4105), new DateTime(2022, 12, 29, 11, 42, 28, 227, DateTimeKind.Utc).AddTicks(4106) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 29, 11, 42, 28, 227, DateTimeKind.Utc).AddTicks(4111), new DateTime(2022, 12, 29, 11, 42, 28, 227, DateTimeKind.Utc).AddTicks(4111) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 29, 11, 42, 28, 227, DateTimeKind.Utc).AddTicks(4116), new DateTime(2022, 12, 29, 11, 42, 28, 227, DateTimeKind.Utc).AddTicks(4116) });
        }
    }
}

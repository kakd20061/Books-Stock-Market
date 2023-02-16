using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books_Stock_Market.Migrations
{
    public partial class updateimageentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Images",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Administration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 16, 15, 57, 7, 254, DateTimeKind.Utc).AddTicks(1848), new DateTime(2023, 2, 16, 15, 57, 7, 254, DateTimeKind.Utc).AddTicks(1849) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 16, 15, 57, 7, 254, DateTimeKind.Utc).AddTicks(1813), new DateTime(2023, 2, 16, 15, 57, 7, 254, DateTimeKind.Utc).AddTicks(1815) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 16, 15, 57, 7, 254, DateTimeKind.Utc).AddTicks(1828), new DateTime(2023, 2, 16, 15, 57, 7, 254, DateTimeKind.Utc).AddTicks(1828) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 16, 15, 57, 7, 254, DateTimeKind.Utc).AddTicks(1834), new DateTime(2023, 2, 16, 15, 57, 7, 254, DateTimeKind.Utc).AddTicks(1834) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 16, 15, 57, 7, 254, DateTimeKind.Utc).AddTicks(1839), new DateTime(2023, 2, 16, 15, 57, 7, 254, DateTimeKind.Utc).AddTicks(1839) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Images");

            migrationBuilder.UpdateData(
                table: "Administration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 30, 13, 59, 42, 213, DateTimeKind.Utc).AddTicks(8601), new DateTime(2023, 1, 30, 13, 59, 42, 213, DateTimeKind.Utc).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 30, 13, 59, 42, 213, DateTimeKind.Utc).AddTicks(8569), new DateTime(2023, 1, 30, 13, 59, 42, 213, DateTimeKind.Utc).AddTicks(8571) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 30, 13, 59, 42, 213, DateTimeKind.Utc).AddTicks(8583), new DateTime(2023, 1, 30, 13, 59, 42, 213, DateTimeKind.Utc).AddTicks(8583) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 30, 13, 59, 42, 213, DateTimeKind.Utc).AddTicks(8588), new DateTime(2023, 1, 30, 13, 59, 42, 213, DateTimeKind.Utc).AddTicks(8589) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 30, 13, 59, 42, 213, DateTimeKind.Utc).AddTicks(8593), new DateTime(2023, 1, 30, 13, 59, 42, 213, DateTimeKind.Utc).AddTicks(8593) });
        }
    }
}

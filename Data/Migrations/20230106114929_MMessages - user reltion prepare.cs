using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books_Stock_Market.Data.Migrations
{
    public partial class MMessagesuserreltionprepare : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Administration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 49, 29, 141, DateTimeKind.Utc).AddTicks(1394), new DateTime(2023, 1, 6, 11, 49, 29, 141, DateTimeKind.Utc).AddTicks(1395) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 49, 29, 141, DateTimeKind.Utc).AddTicks(1334), new DateTime(2023, 1, 6, 11, 49, 29, 141, DateTimeKind.Utc).AddTicks(1335) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 49, 29, 141, DateTimeKind.Utc).AddTicks(1374), new DateTime(2023, 1, 6, 11, 49, 29, 141, DateTimeKind.Utc).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 49, 29, 141, DateTimeKind.Utc).AddTicks(1381), new DateTime(2023, 1, 6, 11, 49, 29, 141, DateTimeKind.Utc).AddTicks(1381) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 49, 29, 141, DateTimeKind.Utc).AddTicks(1386), new DateTime(2023, 1, 6, 11, 49, 29, 141, DateTimeKind.Utc).AddTicks(1386) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Administration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 48, 16, 673, DateTimeKind.Utc).AddTicks(2060), new DateTime(2023, 1, 6, 11, 48, 16, 673, DateTimeKind.Utc).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 48, 16, 673, DateTimeKind.Utc).AddTicks(2026), new DateTime(2023, 1, 6, 11, 48, 16, 673, DateTimeKind.Utc).AddTicks(2028) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 48, 16, 673, DateTimeKind.Utc).AddTicks(2041), new DateTime(2023, 1, 6, 11, 48, 16, 673, DateTimeKind.Utc).AddTicks(2041) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 48, 16, 673, DateTimeKind.Utc).AddTicks(2046), new DateTime(2023, 1, 6, 11, 48, 16, 673, DateTimeKind.Utc).AddTicks(2046) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 48, 16, 673, DateTimeKind.Utc).AddTicks(2051), new DateTime(2023, 1, 6, 11, 48, 16, 673, DateTimeKind.Utc).AddTicks(2051) });
        }
    }
}

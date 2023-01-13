using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books_Stock_Market.Data.Migrations
{
    public partial class FirstAdminSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Administration",
                columns: new[] { "Id", "CreatedAt", "Email", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2022, 12, 29, 11, 42, 28, 227, DateTimeKind.Utc).AddTicks(4129), "gizard.biznes123@vp.pl", new DateTime(2022, 12, 29, 11, 42, 28, 227, DateTimeKind.Utc).AddTicks(4130) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Administration",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 29, 11, 22, 37, 560, DateTimeKind.Utc).AddTicks(8793), new DateTime(2022, 12, 29, 11, 22, 37, 560, DateTimeKind.Utc).AddTicks(8796) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 29, 11, 22, 37, 560, DateTimeKind.Utc).AddTicks(8820), new DateTime(2022, 12, 29, 11, 22, 37, 560, DateTimeKind.Utc).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 29, 11, 22, 37, 560, DateTimeKind.Utc).AddTicks(8831), new DateTime(2022, 12, 29, 11, 22, 37, 560, DateTimeKind.Utc).AddTicks(8831) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 29, 11, 22, 37, 560, DateTimeKind.Utc).AddTicks(8839), new DateTime(2022, 12, 29, 11, 22, 37, 560, DateTimeKind.Utc).AddTicks(8840) });
        }
    }
}

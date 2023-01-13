using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books_Stock_Market.Data.Migrations
{
    public partial class RespondsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnnouncementID",
                table: "RespondMessages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 28, 11, 55, 59, 187, DateTimeKind.Utc).AddTicks(4100), new DateTime(2022, 12, 28, 11, 55, 59, 187, DateTimeKind.Utc).AddTicks(4103) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 28, 11, 55, 59, 187, DateTimeKind.Utc).AddTicks(4145), new DateTime(2022, 12, 28, 11, 55, 59, 187, DateTimeKind.Utc).AddTicks(4145) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 28, 11, 55, 59, 187, DateTimeKind.Utc).AddTicks(4151), new DateTime(2022, 12, 28, 11, 55, 59, 187, DateTimeKind.Utc).AddTicks(4152) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 28, 11, 55, 59, 187, DateTimeKind.Utc).AddTicks(4157), new DateTime(2022, 12, 28, 11, 55, 59, 187, DateTimeKind.Utc).AddTicks(4157) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnnouncementID",
                table: "RespondMessages");

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 28, 11, 51, 11, 505, DateTimeKind.Utc).AddTicks(1325), new DateTime(2022, 12, 28, 11, 51, 11, 505, DateTimeKind.Utc).AddTicks(1327) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 28, 11, 51, 11, 505, DateTimeKind.Utc).AddTicks(1340), new DateTime(2022, 12, 28, 11, 51, 11, 505, DateTimeKind.Utc).AddTicks(1340) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 28, 11, 51, 11, 505, DateTimeKind.Utc).AddTicks(1346), new DateTime(2022, 12, 28, 11, 51, 11, 505, DateTimeKind.Utc).AddTicks(1346) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 28, 11, 51, 11, 505, DateTimeKind.Utc).AddTicks(1351), new DateTime(2022, 12, 28, 11, 51, 11, 505, DateTimeKind.Utc).AddTicks(1351) });
        }
    }
}

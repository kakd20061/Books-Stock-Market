using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books_Stock_Market.Migrations
{
    public partial class subjectupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsChecked",
                table: "Subjects",
                newName: "Status");

            migrationBuilder.UpdateData(
                table: "Administration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 16, 17, 22, 37, 602, DateTimeKind.Utc).AddTicks(5006), new DateTime(2023, 2, 16, 17, 22, 37, 602, DateTimeKind.Utc).AddTicks(5007) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 16, 17, 22, 37, 602, DateTimeKind.Utc).AddTicks(4971), 0, new DateTime(2023, 2, 16, 17, 22, 37, 602, DateTimeKind.Utc).AddTicks(4973) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 16, 17, 22, 37, 602, DateTimeKind.Utc).AddTicks(4986), 0, new DateTime(2023, 2, 16, 17, 22, 37, 602, DateTimeKind.Utc).AddTicks(4986) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 16, 17, 22, 37, 602, DateTimeKind.Utc).AddTicks(4991), 0, new DateTime(2023, 2, 16, 17, 22, 37, 602, DateTimeKind.Utc).AddTicks(4991) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Status", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 16, 17, 22, 37, 602, DateTimeKind.Utc).AddTicks(4996), 0, new DateTime(2023, 2, 16, 17, 22, 37, 602, DateTimeKind.Utc).AddTicks(4996) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Subjects",
                newName: "IsChecked");

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
                columns: new[] { "CreatedAt", "IsChecked", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 16, 15, 57, 7, 254, DateTimeKind.Utc).AddTicks(1813), false, new DateTime(2023, 2, 16, 15, 57, 7, 254, DateTimeKind.Utc).AddTicks(1815) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsChecked", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 16, 15, 57, 7, 254, DateTimeKind.Utc).AddTicks(1828), false, new DateTime(2023, 2, 16, 15, 57, 7, 254, DateTimeKind.Utc).AddTicks(1828) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsChecked", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 16, 15, 57, 7, 254, DateTimeKind.Utc).AddTicks(1834), false, new DateTime(2023, 2, 16, 15, 57, 7, 254, DateTimeKind.Utc).AddTicks(1834) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IsChecked", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 16, 15, 57, 7, 254, DateTimeKind.Utc).AddTicks(1839), false, new DateTime(2023, 2, 16, 15, 57, 7, 254, DateTimeKind.Utc).AddTicks(1839) });
        }
    }
}

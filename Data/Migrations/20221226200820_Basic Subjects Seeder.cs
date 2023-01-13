using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books_Stock_Market.Data.Migrations
{
    public partial class BasicSubjectsSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "CreatedAt", "SubjectName", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 12, 26, 20, 8, 20, 650, DateTimeKind.Utc).AddTicks(4100), "J. Angielski", new DateTime(2022, 12, 26, 20, 8, 20, 650, DateTimeKind.Utc).AddTicks(4101) },
                    { 2, new DateTime(2022, 12, 26, 20, 8, 20, 650, DateTimeKind.Utc).AddTicks(4113), "J. Polski", new DateTime(2022, 12, 26, 20, 8, 20, 650, DateTimeKind.Utc).AddTicks(4113) },
                    { 3, new DateTime(2022, 12, 26, 20, 8, 20, 650, DateTimeKind.Utc).AddTicks(4119), "J. Niemiecki", new DateTime(2022, 12, 26, 20, 8, 20, 650, DateTimeKind.Utc).AddTicks(4119) },
                    { 4, new DateTime(2022, 12, 26, 20, 8, 20, 650, DateTimeKind.Utc).AddTicks(4123), "Matematyka", new DateTime(2022, 12, 26, 20, 8, 20, 650, DateTimeKind.Utc).AddTicks(4123) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}

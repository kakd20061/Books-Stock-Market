using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books_Stock_Market.Data.Migrations
{
    public partial class Respondsbooladding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isAuthor",
                table: "RespondMessages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 28, 12, 20, 57, 371, DateTimeKind.Utc).AddTicks(3630), new DateTime(2022, 12, 28, 12, 20, 57, 371, DateTimeKind.Utc).AddTicks(3631) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 28, 12, 20, 57, 371, DateTimeKind.Utc).AddTicks(3643), new DateTime(2022, 12, 28, 12, 20, 57, 371, DateTimeKind.Utc).AddTicks(3643) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 28, 12, 20, 57, 371, DateTimeKind.Utc).AddTicks(3648), new DateTime(2022, 12, 28, 12, 20, 57, 371, DateTimeKind.Utc).AddTicks(3649) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 28, 12, 20, 57, 371, DateTimeKind.Utc).AddTicks(3653), new DateTime(2022, 12, 28, 12, 20, 57, 371, DateTimeKind.Utc).AddTicks(3653) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isAuthor",
                table: "RespondMessages");

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
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books_Stock_Market.Data.Migrations
{
    public partial class lastupdaterepairing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Images",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Administration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 1, 13, 15, 55, 873, DateTimeKind.Utc).AddTicks(5385), new DateTime(2023, 1, 1, 13, 15, 55, 873, DateTimeKind.Utc).AddTicks(5386) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 1, 13, 15, 55, 873, DateTimeKind.Utc).AddTicks(5352), new DateTime(2023, 1, 1, 13, 15, 55, 873, DateTimeKind.Utc).AddTicks(5354) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 1, 13, 15, 55, 873, DateTimeKind.Utc).AddTicks(5367), new DateTime(2023, 1, 1, 13, 15, 55, 873, DateTimeKind.Utc).AddTicks(5368) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 1, 13, 15, 55, 873, DateTimeKind.Utc).AddTicks(5373), new DateTime(2023, 1, 1, 13, 15, 55, 873, DateTimeKind.Utc).AddTicks(5373) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 1, 13, 15, 55, 873, DateTimeKind.Utc).AddTicks(5378), new DateTime(2023, 1, 1, 13, 15, 55, 873, DateTimeKind.Utc).AddTicks(5378) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Description",
                table: "Images",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Administration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 1, 13, 11, 5, 701, DateTimeKind.Utc).AddTicks(2967), new DateTime(2023, 1, 1, 13, 11, 5, 701, DateTimeKind.Utc).AddTicks(2967) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 1, 13, 11, 5, 701, DateTimeKind.Utc).AddTicks(2930), new DateTime(2023, 1, 1, 13, 11, 5, 701, DateTimeKind.Utc).AddTicks(2932) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 1, 13, 11, 5, 701, DateTimeKind.Utc).AddTicks(2945), new DateTime(2023, 1, 1, 13, 11, 5, 701, DateTimeKind.Utc).AddTicks(2945) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 1, 13, 11, 5, 701, DateTimeKind.Utc).AddTicks(2952), new DateTime(2023, 1, 1, 13, 11, 5, 701, DateTimeKind.Utc).AddTicks(2952) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 1, 13, 11, 5, 701, DateTimeKind.Utc).AddTicks(2957), new DateTime(2023, 1, 1, 13, 11, 5, 701, DateTimeKind.Utc).AddTicks(2957) });
        }
    }
}

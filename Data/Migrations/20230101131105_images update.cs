using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books_Stock_Market.Data.Migrations
{
    public partial class imagesupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Description",
                table: "Images",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Images",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Images");

            migrationBuilder.UpdateData(
                table: "Administration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 1, 12, 20, 16, 940, DateTimeKind.Utc).AddTicks(6439), new DateTime(2023, 1, 1, 12, 20, 16, 940, DateTimeKind.Utc).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 1, 12, 20, 16, 940, DateTimeKind.Utc).AddTicks(6400), new DateTime(2023, 1, 1, 12, 20, 16, 940, DateTimeKind.Utc).AddTicks(6401) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 1, 12, 20, 16, 940, DateTimeKind.Utc).AddTicks(6414), new DateTime(2023, 1, 1, 12, 20, 16, 940, DateTimeKind.Utc).AddTicks(6414) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 1, 12, 20, 16, 940, DateTimeKind.Utc).AddTicks(6420), new DateTime(2023, 1, 1, 12, 20, 16, 940, DateTimeKind.Utc).AddTicks(6420) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 1, 12, 20, 16, 940, DateTimeKind.Utc).AddTicks(6425), new DateTime(2023, 1, 1, 12, 20, 16, 940, DateTimeKind.Utc).AddTicks(6426) });
        }
    }
}

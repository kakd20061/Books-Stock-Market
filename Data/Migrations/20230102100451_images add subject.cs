using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books_Stock_Market.Data.Migrations
{
    public partial class imagesaddsubject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Subject",
                table: "Images",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Administration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 2, 10, 4, 51, 334, DateTimeKind.Utc).AddTicks(8368), new DateTime(2023, 1, 2, 10, 4, 51, 334, DateTimeKind.Utc).AddTicks(8369) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 2, 10, 4, 51, 334, DateTimeKind.Utc).AddTicks(8331), new DateTime(2023, 1, 2, 10, 4, 51, 334, DateTimeKind.Utc).AddTicks(8336) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 2, 10, 4, 51, 334, DateTimeKind.Utc).AddTicks(8349), new DateTime(2023, 1, 2, 10, 4, 51, 334, DateTimeKind.Utc).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 2, 10, 4, 51, 334, DateTimeKind.Utc).AddTicks(8354), new DateTime(2023, 1, 2, 10, 4, 51, 334, DateTimeKind.Utc).AddTicks(8354) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 2, 10, 4, 51, 334, DateTimeKind.Utc).AddTicks(8359), new DateTime(2023, 1, 2, 10, 4, 51, 334, DateTimeKind.Utc).AddTicks(8359) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Subject",
                table: "Images");

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
    }
}

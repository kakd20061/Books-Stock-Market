using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books_Stock_Market.Data.Migrations
{
    public partial class MessagesUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnnouncementForeignKey",
                table: "Messages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 9, 44, 437, DateTimeKind.Utc).AddTicks(8158), new DateTime(2022, 12, 27, 11, 9, 44, 437, DateTimeKind.Utc).AddTicks(8161) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 9, 44, 437, DateTimeKind.Utc).AddTicks(8189), new DateTime(2022, 12, 27, 11, 9, 44, 437, DateTimeKind.Utc).AddTicks(8189) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 9, 44, 437, DateTimeKind.Utc).AddTicks(8198), new DateTime(2022, 12, 27, 11, 9, 44, 437, DateTimeKind.Utc).AddTicks(8198) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 9, 44, 437, DateTimeKind.Utc).AddTicks(8206), new DateTime(2022, 12, 27, 11, 9, 44, 437, DateTimeKind.Utc).AddTicks(8206) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnnouncementForeignKey",
                table: "Messages");

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 6, 17, 169, DateTimeKind.Utc).AddTicks(5022), new DateTime(2022, 12, 27, 11, 6, 17, 169, DateTimeKind.Utc).AddTicks(5023) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 6, 17, 169, DateTimeKind.Utc).AddTicks(5037), new DateTime(2022, 12, 27, 11, 6, 17, 169, DateTimeKind.Utc).AddTicks(5037) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 6, 17, 169, DateTimeKind.Utc).AddTicks(5043), new DateTime(2022, 12, 27, 11, 6, 17, 169, DateTimeKind.Utc).AddTicks(5043) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 6, 17, 169, DateTimeKind.Utc).AddTicks(5048), new DateTime(2022, 12, 27, 11, 6, 17, 169, DateTimeKind.Utc).AddTicks(5048) });
        }
    }
}

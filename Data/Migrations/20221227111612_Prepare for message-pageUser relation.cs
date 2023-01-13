using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books_Stock_Market.Data.Migrations
{
    public partial class PrepareformessagepageUserrelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserForeignKey",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "pageUserId",
                table: "Messages",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 16, 12, 413, DateTimeKind.Utc).AddTicks(7694), new DateTime(2022, 12, 27, 11, 16, 12, 413, DateTimeKind.Utc).AddTicks(7695) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 16, 12, 413, DateTimeKind.Utc).AddTicks(7709), new DateTime(2022, 12, 27, 11, 16, 12, 413, DateTimeKind.Utc).AddTicks(7709) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 16, 12, 413, DateTimeKind.Utc).AddTicks(7715), new DateTime(2022, 12, 27, 11, 16, 12, 413, DateTimeKind.Utc).AddTicks(7715) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 16, 12, 413, DateTimeKind.Utc).AddTicks(7721), new DateTime(2022, 12, 27, 11, 16, 12, 413, DateTimeKind.Utc).AddTicks(7721) });

            migrationBuilder.CreateIndex(
                name: "IX_Messages_pageUserId",
                table: "Messages",
                column: "pageUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_AspNetUsers_pageUserId",
                table: "Messages",
                column: "pageUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AspNetUsers_pageUserId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_pageUserId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "UserForeignKey",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "pageUserId",
                table: "Messages");

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 10, 59, 957, DateTimeKind.Utc).AddTicks(9477), new DateTime(2022, 12, 27, 11, 10, 59, 957, DateTimeKind.Utc).AddTicks(9479) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 10, 59, 957, DateTimeKind.Utc).AddTicks(9493), new DateTime(2022, 12, 27, 11, 10, 59, 957, DateTimeKind.Utc).AddTicks(9493) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 10, 59, 957, DateTimeKind.Utc).AddTicks(9498), new DateTime(2022, 12, 27, 11, 10, 59, 957, DateTimeKind.Utc).AddTicks(9499) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 10, 59, 957, DateTimeKind.Utc).AddTicks(9503), new DateTime(2022, 12, 27, 11, 10, 59, 957, DateTimeKind.Utc).AddTicks(9503) });
        }
    }
}

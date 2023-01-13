using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books_Stock_Market.Data.Migrations
{
    public partial class UserandImagesUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserForeignKey",
                table: "Images",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "pageUserId",
                table: "Images",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Administration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 2, 11, 14, 52, 117, DateTimeKind.Utc).AddTicks(4614), new DateTime(2023, 1, 2, 11, 14, 52, 117, DateTimeKind.Utc).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 2, 11, 14, 52, 117, DateTimeKind.Utc).AddTicks(4578), new DateTime(2023, 1, 2, 11, 14, 52, 117, DateTimeKind.Utc).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 2, 11, 14, 52, 117, DateTimeKind.Utc).AddTicks(4594), new DateTime(2023, 1, 2, 11, 14, 52, 117, DateTimeKind.Utc).AddTicks(4594) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 2, 11, 14, 52, 117, DateTimeKind.Utc).AddTicks(4599), new DateTime(2023, 1, 2, 11, 14, 52, 117, DateTimeKind.Utc).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 2, 11, 14, 52, 117, DateTimeKind.Utc).AddTicks(4605), new DateTime(2023, 1, 2, 11, 14, 52, 117, DateTimeKind.Utc).AddTicks(4605) });

            migrationBuilder.CreateIndex(
                name: "IX_Images_pageUserId",
                table: "Images",
                column: "pageUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_AspNetUsers_pageUserId",
                table: "Images",
                column: "pageUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_AspNetUsers_pageUserId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_pageUserId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "UserForeignKey",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "pageUserId",
                table: "Images");

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
    }
}

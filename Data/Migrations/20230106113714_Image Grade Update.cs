using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books_Stock_Market.Data.Migrations
{
    public partial class ImageGradeUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_AspNetUsers_UserForeignKey",
                table: "Images");

            migrationBuilder.AddColumn<string>(
                name: "Grade",
                table: "Images",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Administration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 37, 14, 210, DateTimeKind.Utc).AddTicks(3699), new DateTime(2023, 1, 6, 11, 37, 14, 210, DateTimeKind.Utc).AddTicks(3699) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 37, 14, 210, DateTimeKind.Utc).AddTicks(3659), new DateTime(2023, 1, 6, 11, 37, 14, 210, DateTimeKind.Utc).AddTicks(3661) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 37, 14, 210, DateTimeKind.Utc).AddTicks(3676), new DateTime(2023, 1, 6, 11, 37, 14, 210, DateTimeKind.Utc).AddTicks(3677) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 37, 14, 210, DateTimeKind.Utc).AddTicks(3683), new DateTime(2023, 1, 6, 11, 37, 14, 210, DateTimeKind.Utc).AddTicks(3683) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 37, 14, 210, DateTimeKind.Utc).AddTicks(3688), new DateTime(2023, 1, 6, 11, 37, 14, 210, DateTimeKind.Utc).AddTicks(3688) });

            migrationBuilder.AddForeignKey(
                name: "FK_Images_AspNetUsers_UserForeignKey",
                table: "Images",
                column: "UserForeignKey",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_AspNetUsers_UserForeignKey",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "Grade",
                table: "Images");

            migrationBuilder.UpdateData(
                table: "Administration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 2, 11, 22, 6, 962, DateTimeKind.Utc).AddTicks(8167), new DateTime(2023, 1, 2, 11, 22, 6, 962, DateTimeKind.Utc).AddTicks(8168) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 2, 11, 22, 6, 962, DateTimeKind.Utc).AddTicks(8128), new DateTime(2023, 1, 2, 11, 22, 6, 962, DateTimeKind.Utc).AddTicks(8134) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 2, 11, 22, 6, 962, DateTimeKind.Utc).AddTicks(8148), new DateTime(2023, 1, 2, 11, 22, 6, 962, DateTimeKind.Utc).AddTicks(8149) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 2, 11, 22, 6, 962, DateTimeKind.Utc).AddTicks(8154), new DateTime(2023, 1, 2, 11, 22, 6, 962, DateTimeKind.Utc).AddTicks(8154) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 2, 11, 22, 6, 962, DateTimeKind.Utc).AddTicks(8159), new DateTime(2023, 1, 2, 11, 22, 6, 962, DateTimeKind.Utc).AddTicks(8159) });

            migrationBuilder.AddForeignKey(
                name: "FK_Images_AspNetUsers_UserForeignKey",
                table: "Images",
                column: "UserForeignKey",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

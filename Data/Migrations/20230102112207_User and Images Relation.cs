using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books_Stock_Market.Data.Migrations
{
    public partial class UserandImagesRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_AspNetUsers_pageUserId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_pageUserId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "pageUserId",
                table: "Images");

            migrationBuilder.AlterColumn<string>(
                name: "UserForeignKey",
                table: "Images",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Images",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.CreateIndex(
                name: "IX_Images_UserForeignKey",
                table: "Images",
                column: "UserForeignKey");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_AspNetUsers_UserForeignKey",
                table: "Images",
                column: "UserForeignKey",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_AspNetUsers_UserForeignKey",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_UserForeignKey",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Images");

            migrationBuilder.AlterColumn<string>(
                name: "UserForeignKey",
                table: "Images",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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
    }
}

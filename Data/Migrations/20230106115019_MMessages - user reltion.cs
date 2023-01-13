using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books_Stock_Market.Data.Migrations
{
    public partial class MMessagesuserreltion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MMessage_AspNetUsers_pageUserId",
                table: "MMessage");

            migrationBuilder.DropIndex(
                name: "IX_MMessage_pageUserId",
                table: "MMessage");

            migrationBuilder.DropColumn(
                name: "pageUserId",
                table: "MMessage");

            migrationBuilder.AlterColumn<string>(
                name: "UserForeignKey",
                table: "MMessage",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Administration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 50, 19, 112, DateTimeKind.Utc).AddTicks(3697), new DateTime(2023, 1, 6, 11, 50, 19, 112, DateTimeKind.Utc).AddTicks(3697) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 50, 19, 112, DateTimeKind.Utc).AddTicks(3658), new DateTime(2023, 1, 6, 11, 50, 19, 112, DateTimeKind.Utc).AddTicks(3660) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 50, 19, 112, DateTimeKind.Utc).AddTicks(3677), new DateTime(2023, 1, 6, 11, 50, 19, 112, DateTimeKind.Utc).AddTicks(3677) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 50, 19, 112, DateTimeKind.Utc).AddTicks(3683), new DateTime(2023, 1, 6, 11, 50, 19, 112, DateTimeKind.Utc).AddTicks(3683) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 50, 19, 112, DateTimeKind.Utc).AddTicks(3688), new DateTime(2023, 1, 6, 11, 50, 19, 112, DateTimeKind.Utc).AddTicks(3688) });

            migrationBuilder.CreateIndex(
                name: "IX_MMessage_UserForeignKey",
                table: "MMessage",
                column: "UserForeignKey");

            migrationBuilder.AddForeignKey(
                name: "FK_MMessage_AspNetUsers_UserForeignKey",
                table: "MMessage",
                column: "UserForeignKey",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MMessage_AspNetUsers_UserForeignKey",
                table: "MMessage");

            migrationBuilder.DropIndex(
                name: "IX_MMessage_UserForeignKey",
                table: "MMessage");

            migrationBuilder.AlterColumn<string>(
                name: "UserForeignKey",
                table: "MMessage",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "pageUserId",
                table: "MMessage",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Administration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 49, 29, 141, DateTimeKind.Utc).AddTicks(1394), new DateTime(2023, 1, 6, 11, 49, 29, 141, DateTimeKind.Utc).AddTicks(1395) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 49, 29, 141, DateTimeKind.Utc).AddTicks(1334), new DateTime(2023, 1, 6, 11, 49, 29, 141, DateTimeKind.Utc).AddTicks(1335) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 49, 29, 141, DateTimeKind.Utc).AddTicks(1374), new DateTime(2023, 1, 6, 11, 49, 29, 141, DateTimeKind.Utc).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 49, 29, 141, DateTimeKind.Utc).AddTicks(1381), new DateTime(2023, 1, 6, 11, 49, 29, 141, DateTimeKind.Utc).AddTicks(1381) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 49, 29, 141, DateTimeKind.Utc).AddTicks(1386), new DateTime(2023, 1, 6, 11, 49, 29, 141, DateTimeKind.Utc).AddTicks(1386) });

            migrationBuilder.CreateIndex(
                name: "IX_MMessage_pageUserId",
                table: "MMessage",
                column: "pageUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_MMessage_AspNetUsers_pageUserId",
                table: "MMessage",
                column: "pageUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books_Stock_Market.Data.Migrations
{
    public partial class MessagesAnnouncementRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AspNetUsers_pageUserId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_pageUserId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "pageUserId",
                table: "Messages");

            migrationBuilder.AlterColumn<string>(
                name: "UserForeignKey",
                table: "Messages",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 25, 15, 72, DateTimeKind.Utc).AddTicks(9603), new DateTime(2022, 12, 27, 11, 25, 15, 72, DateTimeKind.Utc).AddTicks(9604) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 25, 15, 72, DateTimeKind.Utc).AddTicks(9617), new DateTime(2022, 12, 27, 11, 25, 15, 72, DateTimeKind.Utc).AddTicks(9617) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 25, 15, 72, DateTimeKind.Utc).AddTicks(9622), new DateTime(2022, 12, 27, 11, 25, 15, 72, DateTimeKind.Utc).AddTicks(9622) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 27, 11, 25, 15, 72, DateTimeKind.Utc).AddTicks(9627), new DateTime(2022, 12, 27, 11, 25, 15, 72, DateTimeKind.Utc).AddTicks(9627) });

            migrationBuilder.CreateIndex(
                name: "IX_Messages_UserForeignKey",
                table: "Messages",
                column: "UserForeignKey");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_AspNetUsers_UserForeignKey",
                table: "Messages",
                column: "UserForeignKey",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AspNetUsers_UserForeignKey",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_UserForeignKey",
                table: "Messages");

            migrationBuilder.AlterColumn<string>(
                name: "UserForeignKey",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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
    }
}

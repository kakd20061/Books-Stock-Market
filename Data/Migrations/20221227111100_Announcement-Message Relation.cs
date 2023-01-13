using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books_Stock_Market.Data.Migrations
{
    public partial class AnnouncementMessageRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Announcements_announcementId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_announcementId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "announcementId",
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

            migrationBuilder.CreateIndex(
                name: "IX_Messages_AnnouncementForeignKey",
                table: "Messages",
                column: "AnnouncementForeignKey");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Announcements_AnnouncementForeignKey",
                table: "Messages",
                column: "AnnouncementForeignKey",
                principalTable: "Announcements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Announcements_AnnouncementForeignKey",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_AnnouncementForeignKey",
                table: "Messages");

            migrationBuilder.AddColumn<int>(
                name: "announcementId",
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

            migrationBuilder.CreateIndex(
                name: "IX_Messages_announcementId",
                table: "Messages",
                column: "announcementId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Announcements_announcementId",
                table: "Messages",
                column: "announcementId",
                principalTable: "Announcements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

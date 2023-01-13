using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books_Stock_Market.Data.Migrations
{
    public partial class MMessagesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MMessageEntity_AspNetUsers_pageUserId",
                table: "MMessageEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_MMessageEntity_Images_offersId",
                table: "MMessageEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MMessageEntity",
                table: "MMessageEntity");

            migrationBuilder.RenameTable(
                name: "MMessageEntity",
                newName: "MMessage");

            migrationBuilder.RenameIndex(
                name: "IX_MMessageEntity_pageUserId",
                table: "MMessage",
                newName: "IX_MMessage_pageUserId");

            migrationBuilder.RenameIndex(
                name: "IX_MMessageEntity_offersId",
                table: "MMessage",
                newName: "IX_MMessage_offersId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MMessage",
                table: "MMessage",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Administration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 46, 43, 203, DateTimeKind.Utc).AddTicks(9526), new DateTime(2023, 1, 6, 11, 46, 43, 203, DateTimeKind.Utc).AddTicks(9527) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 46, 43, 203, DateTimeKind.Utc).AddTicks(9492), new DateTime(2023, 1, 6, 11, 46, 43, 203, DateTimeKind.Utc).AddTicks(9494) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 46, 43, 203, DateTimeKind.Utc).AddTicks(9506), new DateTime(2023, 1, 6, 11, 46, 43, 203, DateTimeKind.Utc).AddTicks(9506) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 46, 43, 203, DateTimeKind.Utc).AddTicks(9512), new DateTime(2023, 1, 6, 11, 46, 43, 203, DateTimeKind.Utc).AddTicks(9512) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 46, 43, 203, DateTimeKind.Utc).AddTicks(9517), new DateTime(2023, 1, 6, 11, 46, 43, 203, DateTimeKind.Utc).AddTicks(9517) });

            migrationBuilder.AddForeignKey(
                name: "FK_MMessage_AspNetUsers_pageUserId",
                table: "MMessage",
                column: "pageUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MMessage_Images_offersId",
                table: "MMessage",
                column: "offersId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MMessage_AspNetUsers_pageUserId",
                table: "MMessage");

            migrationBuilder.DropForeignKey(
                name: "FK_MMessage_Images_offersId",
                table: "MMessage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MMessage",
                table: "MMessage");

            migrationBuilder.RenameTable(
                name: "MMessage",
                newName: "MMessageEntity");

            migrationBuilder.RenameIndex(
                name: "IX_MMessage_pageUserId",
                table: "MMessageEntity",
                newName: "IX_MMessageEntity_pageUserId");

            migrationBuilder.RenameIndex(
                name: "IX_MMessage_offersId",
                table: "MMessageEntity",
                newName: "IX_MMessageEntity_offersId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MMessageEntity",
                table: "MMessageEntity",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Administration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 45, 55, 749, DateTimeKind.Utc).AddTicks(4827), new DateTime(2023, 1, 6, 11, 45, 55, 749, DateTimeKind.Utc).AddTicks(4827) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 45, 55, 749, DateTimeKind.Utc).AddTicks(4795), new DateTime(2023, 1, 6, 11, 45, 55, 749, DateTimeKind.Utc).AddTicks(4796) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 45, 55, 749, DateTimeKind.Utc).AddTicks(4809), new DateTime(2023, 1, 6, 11, 45, 55, 749, DateTimeKind.Utc).AddTicks(4809) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 45, 55, 749, DateTimeKind.Utc).AddTicks(4814), new DateTime(2023, 1, 6, 11, 45, 55, 749, DateTimeKind.Utc).AddTicks(4814) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 45, 55, 749, DateTimeKind.Utc).AddTicks(4819), new DateTime(2023, 1, 6, 11, 45, 55, 749, DateTimeKind.Utc).AddTicks(4819) });

            migrationBuilder.AddForeignKey(
                name: "FK_MMessageEntity_AspNetUsers_pageUserId",
                table: "MMessageEntity",
                column: "pageUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MMessageEntity_Images_offersId",
                table: "MMessageEntity",
                column: "offersId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

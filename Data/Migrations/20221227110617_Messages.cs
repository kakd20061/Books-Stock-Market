using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books_Stock_Market.Data.Migrations
{
    public partial class Messages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    announcementId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_Announcements_announcementId",
                        column: x => x.announcementId,
                        principalTable: "Announcements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Messages_announcementId",
                table: "Messages",
                column: "announcementId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 26, 20, 45, 2, 545, DateTimeKind.Utc).AddTicks(5082), new DateTime(2022, 12, 26, 20, 45, 2, 545, DateTimeKind.Utc).AddTicks(5084) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 26, 20, 45, 2, 545, DateTimeKind.Utc).AddTicks(5098), new DateTime(2022, 12, 26, 20, 45, 2, 545, DateTimeKind.Utc).AddTicks(5098) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 26, 20, 45, 2, 545, DateTimeKind.Utc).AddTicks(5103), new DateTime(2022, 12, 26, 20, 45, 2, 545, DateTimeKind.Utc).AddTicks(5104) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 26, 20, 45, 2, 545, DateTimeKind.Utc).AddTicks(5109), new DateTime(2022, 12, 26, 20, 45, 2, 545, DateTimeKind.Utc).AddTicks(5109) });
        }
    }
}

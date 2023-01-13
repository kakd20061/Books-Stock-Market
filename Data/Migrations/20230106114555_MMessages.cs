using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books_Stock_Market.Data.Migrations
{
    public partial class MMessages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MMessageEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    offersId = table.Column<int>(type: "int", nullable: false),
                    OffersForeignKey = table.Column<int>(type: "int", nullable: false),
                    pageUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserForeignKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MMessageEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MMessageEntity_AspNetUsers_pageUserId",
                        column: x => x.pageUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MMessageEntity_Images_offersId",
                        column: x => x.offersId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_MMessageEntity_offersId",
                table: "MMessageEntity",
                column: "offersId");

            migrationBuilder.CreateIndex(
                name: "IX_MMessageEntity_pageUserId",
                table: "MMessageEntity",
                column: "pageUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MMessageEntity");

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
        }
    }
}

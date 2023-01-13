using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books_Stock_Market.Data.Migrations
{
    public partial class AnnouncementsPageUserRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Announcements_AspNetUsers_pageUserId",
                table: "Announcements");

            migrationBuilder.DropIndex(
                name: "IX_Announcements_pageUserId",
                table: "Announcements");

            migrationBuilder.DropColumn(
                name: "pageUserId",
                table: "Announcements");

            migrationBuilder.AlterColumn<string>(
                name: "UserForeignKey",
                table: "Announcements",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_UserForeignKey",
                table: "Announcements",
                column: "UserForeignKey");

            migrationBuilder.AddForeignKey(
                name: "FK_Announcements_AspNetUsers_UserForeignKey",
                table: "Announcements",
                column: "UserForeignKey",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Announcements_AspNetUsers_UserForeignKey",
                table: "Announcements");

            migrationBuilder.DropIndex(
                name: "IX_Announcements_UserForeignKey",
                table: "Announcements");

            migrationBuilder.AlterColumn<string>(
                name: "UserForeignKey",
                table: "Announcements",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "pageUserId",
                table: "Announcements",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_pageUserId",
                table: "Announcements",
                column: "pageUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Announcements_AspNetUsers_pageUserId",
                table: "Announcements",
                column: "pageUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}

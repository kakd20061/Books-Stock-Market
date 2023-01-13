using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books_Stock_Market.Data.Migrations
{
    public partial class Announcementedit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GradeNumber",
                table: "Announcements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Subject",
                table: "Announcements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GradeNumber",
                table: "Announcements");

            migrationBuilder.DropColumn(
                name: "Subject",
                table: "Announcements");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books_Stock_Market.Migrations
{
    public partial class announcementsupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsChecked",
                table: "Announcements");

            migrationBuilder.RenameColumn(
                name: "IsRejected",
                table: "Announcements",
                newName: "Status");

            migrationBuilder.UpdateData(
                table: "Administration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 16, 17, 43, 19, 558, DateTimeKind.Utc).AddTicks(1188), new DateTime(2023, 2, 16, 17, 43, 19, 558, DateTimeKind.Utc).AddTicks(1189) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 16, 17, 43, 19, 558, DateTimeKind.Utc).AddTicks(1149), new DateTime(2023, 2, 16, 17, 43, 19, 558, DateTimeKind.Utc).AddTicks(1151) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 16, 17, 43, 19, 558, DateTimeKind.Utc).AddTicks(1168), new DateTime(2023, 2, 16, 17, 43, 19, 558, DateTimeKind.Utc).AddTicks(1168) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 16, 17, 43, 19, 558, DateTimeKind.Utc).AddTicks(1174), new DateTime(2023, 2, 16, 17, 43, 19, 558, DateTimeKind.Utc).AddTicks(1174) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 16, 17, 43, 19, 558, DateTimeKind.Utc).AddTicks(1179), new DateTime(2023, 2, 16, 17, 43, 19, 558, DateTimeKind.Utc).AddTicks(1179) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Announcements",
                newName: "IsRejected");

            migrationBuilder.AddColumn<bool>(
                name: "IsChecked",
                table: "Announcements",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Administration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 16, 17, 22, 37, 602, DateTimeKind.Utc).AddTicks(5006), new DateTime(2023, 2, 16, 17, 22, 37, 602, DateTimeKind.Utc).AddTicks(5007) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 16, 17, 22, 37, 602, DateTimeKind.Utc).AddTicks(4971), new DateTime(2023, 2, 16, 17, 22, 37, 602, DateTimeKind.Utc).AddTicks(4973) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 16, 17, 22, 37, 602, DateTimeKind.Utc).AddTicks(4986), new DateTime(2023, 2, 16, 17, 22, 37, 602, DateTimeKind.Utc).AddTicks(4986) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 16, 17, 22, 37, 602, DateTimeKind.Utc).AddTicks(4991), new DateTime(2023, 2, 16, 17, 22, 37, 602, DateTimeKind.Utc).AddTicks(4991) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 2, 16, 17, 22, 37, 602, DateTimeKind.Utc).AddTicks(4996), new DateTime(2023, 2, 16, 17, 22, 37, 602, DateTimeKind.Utc).AddTicks(4996) });
        }
    }
}

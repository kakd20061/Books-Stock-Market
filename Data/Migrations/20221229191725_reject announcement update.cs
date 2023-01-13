using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books_Stock_Market.Data.Migrations
{
    public partial class rejectannouncementupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsRejected",
                table: "Announcements",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Administration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 29, 19, 17, 25, 256, DateTimeKind.Utc).AddTicks(8843), new DateTime(2022, 12, 29, 19, 17, 25, 256, DateTimeKind.Utc).AddTicks(8843) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 29, 19, 17, 25, 256, DateTimeKind.Utc).AddTicks(8758), new DateTime(2022, 12, 29, 19, 17, 25, 256, DateTimeKind.Utc).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 29, 19, 17, 25, 256, DateTimeKind.Utc).AddTicks(8775), new DateTime(2022, 12, 29, 19, 17, 25, 256, DateTimeKind.Utc).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 29, 19, 17, 25, 256, DateTimeKind.Utc).AddTicks(8828), new DateTime(2022, 12, 29, 19, 17, 25, 256, DateTimeKind.Utc).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 29, 19, 17, 25, 256, DateTimeKind.Utc).AddTicks(8834), new DateTime(2022, 12, 29, 19, 17, 25, 256, DateTimeKind.Utc).AddTicks(8835) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRejected",
                table: "Announcements");

            migrationBuilder.UpdateData(
                table: "Administration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 29, 15, 12, 19, 227, DateTimeKind.Utc).AddTicks(3433), new DateTime(2022, 12, 29, 15, 12, 19, 227, DateTimeKind.Utc).AddTicks(3434) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 29, 15, 12, 19, 227, DateTimeKind.Utc).AddTicks(3391), new DateTime(2022, 12, 29, 15, 12, 19, 227, DateTimeKind.Utc).AddTicks(3393) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 29, 15, 12, 19, 227, DateTimeKind.Utc).AddTicks(3411), new DateTime(2022, 12, 29, 15, 12, 19, 227, DateTimeKind.Utc).AddTicks(3411) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 29, 15, 12, 19, 227, DateTimeKind.Utc).AddTicks(3417), new DateTime(2022, 12, 29, 15, 12, 19, 227, DateTimeKind.Utc).AddTicks(3418) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 29, 15, 12, 19, 227, DateTimeKind.Utc).AddTicks(3424), new DateTime(2022, 12, 29, 15, 12, 19, 227, DateTimeKind.Utc).AddTicks(3424) });
        }
    }
}

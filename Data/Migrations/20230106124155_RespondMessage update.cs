using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books_Stock_Market.Data.Migrations
{
    public partial class RespondMessageupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsOffer",
                table: "RespondMessages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Administration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 12, 41, 55, 52, DateTimeKind.Utc).AddTicks(1945), new DateTime(2023, 1, 6, 12, 41, 55, 52, DateTimeKind.Utc).AddTicks(1945) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 12, 41, 55, 52, DateTimeKind.Utc).AddTicks(1915), new DateTime(2023, 1, 6, 12, 41, 55, 52, DateTimeKind.Utc).AddTicks(1916) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 12, 41, 55, 52, DateTimeKind.Utc).AddTicks(1927), new DateTime(2023, 1, 6, 12, 41, 55, 52, DateTimeKind.Utc).AddTicks(1927) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 12, 41, 55, 52, DateTimeKind.Utc).AddTicks(1932), new DateTime(2023, 1, 6, 12, 41, 55, 52, DateTimeKind.Utc).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 12, 41, 55, 52, DateTimeKind.Utc).AddTicks(1937), new DateTime(2023, 1, 6, 12, 41, 55, 52, DateTimeKind.Utc).AddTicks(1937) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsOffer",
                table: "RespondMessages");

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
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books_Stock_Market.Data.Migrations
{
    public partial class MMessagesofferRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MMessage_Images_offersId",
                table: "MMessage");

            migrationBuilder.DropIndex(
                name: "IX_MMessage_offersId",
                table: "MMessage");

            migrationBuilder.DropColumn(
                name: "offersId",
                table: "MMessage");

            migrationBuilder.UpdateData(
                table: "Administration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 48, 16, 673, DateTimeKind.Utc).AddTicks(2060), new DateTime(2023, 1, 6, 11, 48, 16, 673, DateTimeKind.Utc).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 48, 16, 673, DateTimeKind.Utc).AddTicks(2026), new DateTime(2023, 1, 6, 11, 48, 16, 673, DateTimeKind.Utc).AddTicks(2028) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 48, 16, 673, DateTimeKind.Utc).AddTicks(2041), new DateTime(2023, 1, 6, 11, 48, 16, 673, DateTimeKind.Utc).AddTicks(2041) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 48, 16, 673, DateTimeKind.Utc).AddTicks(2046), new DateTime(2023, 1, 6, 11, 48, 16, 673, DateTimeKind.Utc).AddTicks(2046) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 6, 11, 48, 16, 673, DateTimeKind.Utc).AddTicks(2051), new DateTime(2023, 1, 6, 11, 48, 16, 673, DateTimeKind.Utc).AddTicks(2051) });

            migrationBuilder.CreateIndex(
                name: "IX_MMessage_OffersForeignKey",
                table: "MMessage",
                column: "OffersForeignKey");

            migrationBuilder.AddForeignKey(
                name: "FK_MMessage_Images_OffersForeignKey",
                table: "MMessage",
                column: "OffersForeignKey",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MMessage_Images_OffersForeignKey",
                table: "MMessage");

            migrationBuilder.DropIndex(
                name: "IX_MMessage_OffersForeignKey",
                table: "MMessage");

            migrationBuilder.AddColumn<int>(
                name: "offersId",
                table: "MMessage",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_MMessage_offersId",
                table: "MMessage",
                column: "offersId");

            migrationBuilder.AddForeignKey(
                name: "FK_MMessage_Images_offersId",
                table: "MMessage",
                column: "offersId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

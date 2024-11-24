using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class avalin2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDateTime",
                table: "Ticket",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 21, 51, 45, 529, DateTimeKind.Local).AddTicks(1599),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 24, 21, 37, 4, 730, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Ticket",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 21, 51, 45, 529, DateTimeKind.Local).AddTicks(1134),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 24, 21, 37, 4, 730, DateTimeKind.Local).AddTicks(6607));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDateTime",
                table: "Blob",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 21, 51, 45, 522, DateTimeKind.Local).AddTicks(2832),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 24, 21, 37, 4, 724, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Blob",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 21, 51, 45, 522, DateTimeKind.Local).AddTicks(2389),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 24, 21, 37, 4, 724, DateTimeKind.Local).AddTicks(1107));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDateTime",
                table: "Ticket",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 21, 37, 4, 730, DateTimeKind.Local).AddTicks(7002),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 24, 21, 51, 45, 529, DateTimeKind.Local).AddTicks(1599));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Ticket",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 21, 37, 4, 730, DateTimeKind.Local).AddTicks(6607),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 24, 21, 51, 45, 529, DateTimeKind.Local).AddTicks(1134));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDateTime",
                table: "Blob",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 21, 37, 4, 724, DateTimeKind.Local).AddTicks(1537),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 24, 21, 51, 45, 522, DateTimeKind.Local).AddTicks(2832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Blob",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 21, 37, 4, 724, DateTimeKind.Local).AddTicks(1107),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 24, 21, 51, 45, 522, DateTimeKind.Local).AddTicks(2389));
        }
    }
}

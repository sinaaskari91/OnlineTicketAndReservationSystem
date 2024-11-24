using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class asli : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDateTime",
                table: "Ticket",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 22, 1, 27, 661, DateTimeKind.Local).AddTicks(8984),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 24, 21, 51, 45, 529, DateTimeKind.Local).AddTicks(1599));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Ticket",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 22, 1, 27, 661, DateTimeKind.Local).AddTicks(8504),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 24, 21, 51, 45, 529, DateTimeKind.Local).AddTicks(1134));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDateTime",
                table: "Blob",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 22, 1, 27, 654, DateTimeKind.Local).AddTicks(6999),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 24, 21, 51, 45, 522, DateTimeKind.Local).AddTicks(2832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Blob",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 22, 1, 27, 654, DateTimeKind.Local).AddTicks(6556),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 24, 21, 51, 45, 522, DateTimeKind.Local).AddTicks(2389));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDateTime",
                table: "Ticket",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 21, 51, 45, 529, DateTimeKind.Local).AddTicks(1599),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 24, 22, 1, 27, 661, DateTimeKind.Local).AddTicks(8984));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Ticket",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 21, 51, 45, 529, DateTimeKind.Local).AddTicks(1134),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 24, 22, 1, 27, 661, DateTimeKind.Local).AddTicks(8504));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDateTime",
                table: "Blob",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 21, 51, 45, 522, DateTimeKind.Local).AddTicks(2832),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 24, 22, 1, 27, 654, DateTimeKind.Local).AddTicks(6999));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Blob",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 21, 51, 45, 522, DateTimeKind.Local).AddTicks(2389),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 24, 22, 1, 27, 654, DateTimeKind.Local).AddTicks(6556));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class asli2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDateTime",
                table: "Ticket",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 22, 18, 19, 119, DateTimeKind.Local).AddTicks(801),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 24, 22, 1, 27, 661, DateTimeKind.Local).AddTicks(8984));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Ticket",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 22, 18, 19, 119, DateTimeKind.Local).AddTicks(334),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 24, 22, 1, 27, 661, DateTimeKind.Local).AddTicks(8504));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDateTime",
                table: "Blob",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 22, 18, 19, 111, DateTimeKind.Local).AddTicks(4779),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 24, 22, 1, 27, 654, DateTimeKind.Local).AddTicks(6999));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Blob",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 22, 18, 19, 111, DateTimeKind.Local).AddTicks(4333),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 24, 22, 1, 27, 654, DateTimeKind.Local).AddTicks(6556));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDateTime",
                table: "Ticket",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 22, 1, 27, 661, DateTimeKind.Local).AddTicks(8984),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 24, 22, 18, 19, 119, DateTimeKind.Local).AddTicks(801));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Ticket",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 22, 1, 27, 661, DateTimeKind.Local).AddTicks(8504),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 24, 22, 18, 19, 119, DateTimeKind.Local).AddTicks(334));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDateTime",
                table: "Blob",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 22, 1, 27, 654, DateTimeKind.Local).AddTicks(6999),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 24, 22, 18, 19, 111, DateTimeKind.Local).AddTicks(4779));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Blob",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 22, 1, 27, 654, DateTimeKind.Local).AddTicks(6556),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 24, 22, 18, 19, 111, DateTimeKind.Local).AddTicks(4333));
        }
    }
}

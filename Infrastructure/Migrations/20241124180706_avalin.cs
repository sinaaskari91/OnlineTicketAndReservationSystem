using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class avalin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDateTime",
                table: "Ticket",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 21, 37, 4, 730, DateTimeKind.Local).AddTicks(7002),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 24, 20, 20, 38, 543, DateTimeKind.Local).AddTicks(3024));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Ticket",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 21, 37, 4, 730, DateTimeKind.Local).AddTicks(6607),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 24, 20, 20, 38, 543, DateTimeKind.Local).AddTicks(2428));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDateTime",
                table: "Blob",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 21, 37, 4, 724, DateTimeKind.Local).AddTicks(1537),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 24, 20, 20, 38, 533, DateTimeKind.Local).AddTicks(3875));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Blob",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 21, 37, 4, 724, DateTimeKind.Local).AddTicks(1107),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 24, 20, 20, 38, 533, DateTimeKind.Local).AddTicks(3199));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDateTime",
                table: "Ticket",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 20, 20, 38, 543, DateTimeKind.Local).AddTicks(3024),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 24, 21, 37, 4, 730, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Ticket",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 20, 20, 38, 543, DateTimeKind.Local).AddTicks(2428),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 24, 21, 37, 4, 730, DateTimeKind.Local).AddTicks(6607));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDateTime",
                table: "Blob",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 20, 20, 38, 533, DateTimeKind.Local).AddTicks(3875),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 24, 21, 37, 4, 724, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Blob",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 24, 20, 20, 38, 533, DateTimeKind.Local).AddTicks(3199),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 24, 21, 37, 4, 724, DateTimeKind.Local).AddTicks(1107));
        }
    }
}

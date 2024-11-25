using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDateTime",
                table: "Ticket",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 25, 21, 2, 18, 870, DateTimeKind.Local).AddTicks(3197),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 25, 19, 50, 53, 932, DateTimeKind.Local).AddTicks(2235));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Ticket",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 25, 21, 2, 18, 870, DateTimeKind.Local).AddTicks(2586),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 25, 19, 50, 53, 932, DateTimeKind.Local).AddTicks(1572));

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "Category",
                type: "NVarChar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDateTime",
                table: "Blob",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 25, 21, 2, 18, 858, DateTimeKind.Local).AddTicks(7492),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 25, 19, 50, 53, 921, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Blob",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 25, 21, 2, 18, 858, DateTimeKind.Local).AddTicks(6890),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 25, 19, 50, 53, 921, DateTimeKind.Local).AddTicks(8021));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDateTime",
                table: "Ticket",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 25, 19, 50, 53, 932, DateTimeKind.Local).AddTicks(2235),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 25, 21, 2, 18, 870, DateTimeKind.Local).AddTicks(3197));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Ticket",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 25, 19, 50, 53, 932, DateTimeKind.Local).AddTicks(1572),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 25, 21, 2, 18, 870, DateTimeKind.Local).AddTicks(2586));

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "Category",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVarChar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDateTime",
                table: "Blob",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 25, 19, 50, 53, 921, DateTimeKind.Local).AddTicks(8746),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 25, 21, 2, 18, 858, DateTimeKind.Local).AddTicks(7492));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Blob",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 25, 19, 50, 53, 921, DateTimeKind.Local).AddTicks(8021),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 25, 21, 2, 18, 858, DateTimeKind.Local).AddTicks(6890));
        }
    }
}

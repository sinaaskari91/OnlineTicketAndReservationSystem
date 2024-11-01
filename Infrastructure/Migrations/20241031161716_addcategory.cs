using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addcategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "User",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDateTime",
                table: "Ticket",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 10, 31, 19, 47, 14, 53, DateTimeKind.Local).AddTicks(6954),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 10, 18, 16, 23, 56, 973, DateTimeKind.Local).AddTicks(1421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Ticket",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 10, 31, 19, 47, 14, 53, DateTimeKind.Local).AddTicks(6249),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 10, 18, 16, 23, 56, 973, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Ticket",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId1",
                table: "Ticket",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Ticket",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Ticket",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Ticket",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Category_User_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Category_User_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_CategoryId1",
                table: "Ticket",
                column: "CategoryId1");

            migrationBuilder.CreateIndex(
                name: "IX_Category_CreatedUserId",
                table: "Category",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Category_UpdatedUserId",
                table: "Category",
                column: "UpdatedUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Category_CategoryId1",
                table: "Ticket",
                column: "CategoryId1",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Category_CategoryId1",
                table: "Ticket");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_CategoryId1",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "CategoryId1",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Ticket");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "User",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDateTime",
                table: "Ticket",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 10, 18, 16, 23, 56, 973, DateTimeKind.Local).AddTicks(1421),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 10, 31, 19, 47, 14, 53, DateTimeKind.Local).AddTicks(6954));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Ticket",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 10, 18, 16, 23, 56, 973, DateTimeKind.Local).AddTicks(920),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 10, 31, 19, 47, 14, 53, DateTimeKind.Local).AddTicks(6249));
        }
    }
}

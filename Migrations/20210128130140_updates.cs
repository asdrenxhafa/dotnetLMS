using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Libraryms.Migrations
{
    public partial class updates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "created_at",
                table: "Pagesa");

            migrationBuilder.RenameColumn(
                name: "shuma",
                table: "Pagesa",
                newName: "Shuma");

            migrationBuilder.AlterColumn<int>(
                name: "Shuma",
                table: "Pagesa",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataEPageses",
                table: "Pagesa",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataESkadimit",
                table: "Pagesa",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataEPageses",
                table: "Pagesa");

            migrationBuilder.DropColumn(
                name: "DataESkadimit",
                table: "Pagesa");

            migrationBuilder.RenameColumn(
                name: "Shuma",
                table: "Pagesa",
                newName: "shuma");

            migrationBuilder.AlterColumn<string>(
                name: "shuma",
                table: "Pagesa",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "Pagesa",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}

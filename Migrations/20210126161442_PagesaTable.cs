using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Libraryms.Migrations
{
    public partial class PagesaTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pagesa",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    shuma = table.Column<string>(nullable: true),
                    Klienti_id = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    created_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagesa", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pagesa");
        }
    }
}

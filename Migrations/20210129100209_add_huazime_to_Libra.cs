using Microsoft.EntityFrameworkCore.Migrations;

namespace Libraryms.Migrations
{
    public partial class add_huazime_to_Libra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
            name: "huazime",
            table: "Libra",
            nullable: false
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropColumn(
                name: "huazime",
                table: "Libra"
                );

        }
    }
}

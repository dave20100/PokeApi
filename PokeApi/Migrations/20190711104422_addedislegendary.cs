using Microsoft.EntityFrameworkCore.Migrations;

namespace PokeApi.Migrations
{
    public partial class addedislegendary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Is_Legendary",
                table: "Pokemon",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "PokedexNumber",
                table: "Pokemon",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Is_Legendary",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "PokedexNumber",
                table: "Pokemon");
        }
    }
}

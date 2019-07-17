using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace PokeApi.Migrations
{
    public partial class idk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Move_PokeType_DamageTypeId",
                table: "Move");

            migrationBuilder.DropForeignKey(
                name: "FK_Move_Pokemon_PokemonId",
                table: "Move");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_Pokedexes_PokedexId",
                table: "Pokemon");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_Pokemon_PokemonId",
                table: "Pokemon");

            migrationBuilder.DropTable(
                name: "PokeType");

            migrationBuilder.DropIndex(
                name: "IX_Move_DamageTypeId",
                table: "Move");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pokemon",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "DamageTypeId",
                table: "Move");

            migrationBuilder.RenameTable(
                name: "Pokemon",
                newName: "Pokemons");

            migrationBuilder.RenameIndex(
                name: "IX_Pokemon_PokemonId",
                table: "Pokemons",
                newName: "IX_Pokemons_PokemonId");

            migrationBuilder.RenameIndex(
                name: "IX_Pokemon_PokedexId",
                table: "Pokemons",
                newName: "IX_Pokemons_PokedexId");

            migrationBuilder.AddColumn<string>(
                name: "DamageType",
                table: "Move",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pokemons",
                table: "Pokemons",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Move_Pokemons_PokemonId",
                table: "Move",
                column: "PokemonId",
                principalTable: "Pokemons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_Pokedexes_PokedexId",
                table: "Pokemons",
                column: "PokedexId",
                principalTable: "Pokedexes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_Pokemons_PokemonId",
                table: "Pokemons",
                column: "PokemonId",
                principalTable: "Pokemons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Move_Pokemons_PokemonId",
                table: "Move");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Pokedexes_PokedexId",
                table: "Pokemons");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Pokemons_PokemonId",
                table: "Pokemons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pokemons",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "DamageType",
                table: "Move");

            migrationBuilder.RenameTable(
                name: "Pokemons",
                newName: "Pokemon");

            migrationBuilder.RenameIndex(
                name: "IX_Pokemons_PokemonId",
                table: "Pokemon",
                newName: "IX_Pokemon_PokemonId");

            migrationBuilder.RenameIndex(
                name: "IX_Pokemons_PokedexId",
                table: "Pokemon",
                newName: "IX_Pokemon_PokedexId");

            migrationBuilder.AddColumn<int>(
                name: "DamageTypeId",
                table: "Move",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pokemon",
                table: "Pokemon",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "PokeType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokeType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Move_DamageTypeId",
                table: "Move",
                column: "DamageTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Move_PokeType_DamageTypeId",
                table: "Move",
                column: "DamageTypeId",
                principalTable: "PokeType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Move_Pokemon_PokemonId",
                table: "Move",
                column: "PokemonId",
                principalTable: "Pokemon",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemon_Pokedexes_PokedexId",
                table: "Pokemon",
                column: "PokedexId",
                principalTable: "Pokedexes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemon_Pokemon_PokemonId",
                table: "Pokemon",
                column: "PokemonId",
                principalTable: "Pokemon",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

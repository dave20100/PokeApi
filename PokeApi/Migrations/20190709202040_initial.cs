using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace PokeApi.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pokedexes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokedexes", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Pokemon",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    Hp = table.Column<int>(nullable: false),
                    Attack = table.Column<int>(nullable: false),
                    Defense = table.Column<int>(nullable: false),
                    Speed = table.Column<int>(nullable: false),
                    Sp_Atk = table.Column<int>(nullable: false),
                    Sp_Def = table.Column<int>(nullable: false),
                    FirstTypeId = table.Column<int>(nullable: true),
                    SecondTypeId = table.Column<int>(nullable: true),
                    PokedexId = table.Column<int>(nullable: true),
                    PokemonId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pokemon_PokeType_FirstTypeId",
                        column: x => x.FirstTypeId,
                        principalTable: "PokeType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pokemon_Pokedexes_PokedexId",
                        column: x => x.PokedexId,
                        principalTable: "Pokedexes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pokemon_Pokemon_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pokemon_PokeType_SecondTypeId",
                        column: x => x.SecondTypeId,
                        principalTable: "PokeType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Move",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    DamageTypeId = table.Column<int>(nullable: true),
                    PokemonId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Move", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Move_PokeType_DamageTypeId",
                        column: x => x.DamageTypeId,
                        principalTable: "PokeType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Move_Pokemon_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Move_DamageTypeId",
                table: "Move",
                column: "DamageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Move_PokemonId",
                table: "Move",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_FirstTypeId",
                table: "Pokemon",
                column: "FirstTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_PokedexId",
                table: "Pokemon",
                column: "PokedexId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_PokemonId",
                table: "Pokemon",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_SecondTypeId",
                table: "Pokemon",
                column: "SecondTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Move");

            migrationBuilder.DropTable(
                name: "Pokemon");

            migrationBuilder.DropTable(
                name: "PokeType");

            migrationBuilder.DropTable(
                name: "Pokedexes");
        }
    }
}

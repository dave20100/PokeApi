using Microsoft.EntityFrameworkCore.Migrations;

namespace PokeApi.Migrations
{
    public partial class pokemons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_PokeType_FirstTypeId",
                table: "Pokemon");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_Pokedexes_PokedexId",
                table: "Pokemon");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_PokeType_SecondTypeId",
                table: "Pokemon");

            migrationBuilder.DropIndex(
                name: "IX_Pokemon_FirstTypeId",
                table: "Pokemon");

            migrationBuilder.DropIndex(
                name: "IX_Pokemon_SecondTypeId",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "FirstTypeId",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "SecondTypeId",
                table: "Pokemon");

            migrationBuilder.RenameColumn(
                name: "PokedexNumber",
                table: "Pokemon",
                newName: "EntryNumber");

            migrationBuilder.AlterColumn<int>(
                name: "PokedexId",
                table: "Pokemon",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstType",
                table: "Pokemon",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondType",
                table: "Pokemon",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Pokemon",
                columns: new[] { "Id", "Attack", "Defense", "EntryNumber", "FirstType", "Hp", "Is_Legendary", "Name", "PokedexId", "PokemonId", "SecondType", "Sp_Atk", "Sp_Def", "Speed" },
                values: new object[,]
                {
                    { 1, 49, 49, 1, "Grass", 45, false, "Bulbasaur", 1, null, "Poison", 65, 65, 45 },
                    { 528, 165, 95, 475, "Psychic", 68, false, "GalladeMega Gallade", 4, null, "Fighting", 65, 115, 110 },
                    { 529, 55, 145, 476, "Rock", 60, false, "Probopass", 4, null, "Steel", 75, 150, 40 },
                    { 530, 100, 135, 477, "Ghost", 45, false, "Dusknoir", 4, null, "", 65, 135, 45 },
                    { 531, 80, 70, 478, "Ice", 70, false, "Froslass", 4, null, "Ghost", 80, 70, 110 },
                    { 532, 50, 77, 479, "Electric", 50, false, "Rotom", 4, null, "Ghost", 95, 77, 91 },
                    { 533, 65, 107, 479, "Electric", 50, false, "RotomHeat Rotom", 4, null, "Fire", 105, 107, 86 },
                    { 534, 65, 107, 479, "Electric", 50, false, "RotomWash Rotom", 4, null, "Water", 105, 107, 86 },
                    { 535, 65, 107, 479, "Electric", 50, false, "RotomFrost Rotom", 4, null, "Ice", 105, 107, 86 },
                    { 536, 65, 107, 479, "Electric", 50, false, "RotomFan Rotom", 4, null, "Flying", 105, 107, 86 },
                    { 537, 65, 107, 479, "Electric", 50, false, "RotomMow Rotom", 4, null, "Grass", 105, 107, 86 },
                    { 538, 75, 130, 480, "Psychic", 75, true, "Uxie", 4, null, "", 75, 130, 95 },
                    { 539, 105, 105, 481, "Psychic", 80, true, "Mesprit", 4, null, "", 105, 105, 80 },
                    { 540, 125, 70, 482, "Psychic", 75, true, "Azelf", 4, null, "", 125, 70, 115 },
                    { 541, 120, 120, 483, "Steel", 100, true, "Dialga", 4, null, "Dragon", 150, 100, 90 },
                    { 542, 120, 100, 484, "Water", 90, true, "Palkia", 4, null, "Dragon", 150, 120, 100 },
                    { 543, 90, 106, 485, "Fire", 91, true, "Heatran", 4, null, "Steel", 130, 106, 77 },
                    { 544, 160, 110, 486, "Normal", 110, true, "Regigigas", 4, null, "", 80, 110, 100 },
                    { 545, 100, 120, 487, "Ghost", 150, true, "GiratinaAltered Forme", 4, null, "Dragon", 100, 120, 90 },
                    { 546, 120, 100, 487, "Ghost", 150, true, "GiratinaOrigin Forme", 4, null, "Dragon", 120, 100, 90 },
                    { 547, 70, 120, 488, "Psychic", 120, false, "Cresselia", 4, null, "", 75, 130, 85 },
                    { 548, 80, 80, 489, "Water", 80, false, "Phione", 4, null, "", 80, 80, 80 },
                    { 527, 125, 65, 475, "Psychic", 68, false, "Gallade", 4, null, "Fighting", 65, 115, 80 },
                    { 549, 100, 100, 490, "Water", 100, false, "Manaphy", 4, null, "", 100, 100, 100 },
                    { 526, 80, 70, 474, "Normal", 85, false, "Porygon-Z", 4, null, "", 135, 75, 90 },
                    { 524, 95, 125, 472, "Ground", 75, false, "Gliscor", 4, null, "Flying", 45, 75, 95 },
                    { 503, 90, 110, 452, "Poison", 70, false, "Drapion", 4, null, "Dark", 60, 75, 95 },
                    { 504, 61, 40, 453, "Poison", 48, false, "Croagunk", 4, null, "Fighting", 61, 40, 50 },
                    { 505, 106, 65, 454, "Poison", 83, false, "Toxicroak", 4, null, "Fighting", 86, 65, 85 },
                    { 506, 100, 72, 455, "Grass", 74, false, "Carnivine", 4, null, "", 90, 72, 46 },
                    { 507, 49, 56, 456, "Water", 49, false, "Finneon", 4, null, "", 49, 61, 66 },
                    { 508, 69, 76, 457, "Water", 69, false, "Lumineon", 4, null, "", 69, 86, 91 },
                    { 509, 20, 50, 458, "Water", 45, false, "Mantyke", 4, null, "Flying", 60, 120, 50 },
                    { 510, 62, 50, 459, "Grass", 60, false, "Snover", 4, null, "Ice", 62, 60, 40 },
                    { 511, 92, 75, 460, "Grass", 90, false, "Abomasnow", 4, null, "Ice", 92, 85, 60 },
                    { 512, 132, 105, 460, "Grass", 90, false, "AbomasnowMega Abomasnow", 4, null, "Ice", 132, 105, 30 },
                    { 513, 120, 65, 461, "Dark", 70, false, "Weavile", 4, null, "Ice", 45, 85, 125 },
                    { 514, 70, 115, 462, "Electric", 70, false, "Magnezone", 4, null, "Steel", 130, 90, 60 },
                    { 515, 85, 95, 463, "Normal", 110, false, "Lickilicky", 4, null, "", 80, 95, 50 },
                    { 516, 140, 130, 464, "Ground", 115, false, "Rhyperior", 4, null, "Rock", 55, 55, 40 },
                    { 517, 100, 125, 465, "Grass", 100, false, "Tangrowth", 4, null, "", 110, 50, 50 },
                    { 518, 123, 67, 466, "Electric", 75, false, "Electivire", 4, null, "", 95, 85, 95 },
                    { 519, 95, 67, 467, "Fire", 75, false, "Magmortar", 4, null, "", 125, 95, 83 },
                    { 520, 50, 95, 468, "Fairy", 85, false, "Togekiss", 4, null, "Flying", 120, 115, 80 },
                    { 521, 76, 86, 469, "Bug", 86, false, "Yanmega", 4, null, "Flying", 116, 56, 95 },
                    { 522, 110, 130, 470, "Grass", 65, false, "Leafeon", 4, null, "", 60, 65, 95 },
                    { 523, 60, 110, 471, "Ice", 65, false, "Glaceon", 4, null, "", 130, 95, 65 },
                    { 525, 130, 80, 473, "Ice", 110, false, "Mamoswine", 4, null, "Ground", 70, 60, 80 },
                    { 502, 50, 90, 451, "Poison", 40, false, "Skorupi", 4, null, "Bug", 30, 55, 65 },
                    { 550, 90, 90, 491, "Dark", 70, true, "Darkrai", 4, null, "", 135, 90, 125 },
                    { 552, 103, 75, 492, "Grass", 100, true, "ShayminSky Forme", 4, null, "Flying", 120, 75, 127 },
                    { 578, 55, 85, 518, "Psychic", 116, false, "Musharna", 5, null, "", 107, 95, 29 },
                    { 579, 55, 50, 519, "Normal", 50, false, "Pidove", 5, null, "Flying", 36, 30, 43 },
                    { 580, 77, 62, 520, "Normal", 62, false, "Tranquill", 5, null, "Flying", 50, 42, 65 },
                    { 581, 115, 80, 521, "Normal", 80, false, "Unfezant", 5, null, "Flying", 65, 55, 93 },
                    { 582, 60, 32, 522, "Electric", 45, false, "Blitzle", 5, null, "", 50, 32, 76 },
                    { 583, 100, 63, 523, "Electric", 75, false, "Zebstrika", 5, null, "", 80, 63, 116 },
                    { 584, 75, 85, 524, "Rock", 55, false, "Roggenrola", 5, null, "", 25, 25, 15 },
                    { 585, 105, 105, 525, "Rock", 70, false, "Boldore", 5, null, "", 50, 40, 20 },
                    { 586, 135, 130, 526, "Rock", 85, false, "Gigalith", 5, null, "", 60, 80, 25 },
                    { 587, 45, 43, 527, "Psychic", 55, false, "Woobat", 5, null, "Flying", 55, 43, 72 },
                    { 588, 57, 55, 528, "Psychic", 67, false, "Swoobat", 5, null, "Flying", 77, 55, 114 },
                    { 589, 85, 40, 529, "Ground", 60, false, "Drilbur", 5, null, "", 30, 45, 68 },
                    { 590, 135, 60, 530, "Ground", 110, false, "Excadrill", 5, null, "Steel", 50, 65, 88 },
                    { 591, 60, 86, 531, "Normal", 103, false, "Audino", 5, null, "", 60, 86, 50 },
                    { 592, 60, 126, 531, "Normal", 103, false, "AudinoMega Audino", 5, null, "Fairy", 80, 126, 50 },
                    { 593, 80, 55, 532, "Fighting", 75, false, "Timburr", 5, null, "", 25, 35, 35 },
                    { 594, 105, 85, 533, "Fighting", 85, false, "Gurdurr", 5, null, "", 40, 50, 40 },
                    { 595, 140, 95, 534, "Fighting", 105, false, "Conkeldurr", 5, null, "", 55, 65, 45 },
                    { 596, 50, 40, 535, "Water", 50, false, "Tympole", 5, null, "", 50, 40, 64 },
                    { 597, 65, 55, 536, "Water", 75, false, "Palpitoad", 5, null, "Ground", 65, 55, 69 },
                    { 598, 95, 75, 537, "Water", 105, false, "Seismitoad", 5, null, "Ground", 85, 75, 74 },
                    { 577, 25, 45, 517, "Psychic", 76, false, "Munna", 5, null, "", 67, 55, 24 },
                    { 551, 100, 100, 492, "Grass", 100, true, "ShayminLand Forme", 4, null, "", 100, 100, 100 },
                    { 576, 98, 63, 516, "Water", 75, false, "Simipour", 5, null, "", 98, 63, 101 },
                    { 574, 98, 63, 514, "Fire", 75, false, "Simisear", 5, null, "", 98, 63, 101 },
                    { 553, 120, 120, 493, "Normal", 120, true, "Arceus", 4, null, "", 120, 120, 120 },
                    { 554, 100, 100, 494, "Psychic", 100, true, "Victini", 5, null, "Fire", 100, 100, 100 },
                    { 555, 45, 55, 495, "Grass", 45, false, "Snivy", 5, null, "", 45, 55, 63 },
                    { 556, 60, 75, 496, "Grass", 60, false, "Servine", 5, null, "", 60, 75, 83 },
                    { 557, 75, 95, 497, "Grass", 75, false, "Serperior", 5, null, "", 75, 95, 113 },
                    { 558, 63, 45, 498, "Fire", 65, false, "Tepig", 5, null, "", 45, 45, 45 },
                    { 559, 93, 55, 499, "Fire", 90, false, "Pignite", 5, null, "Fighting", 70, 55, 55 },
                    { 560, 123, 65, 500, "Fire", 110, false, "Emboar", 5, null, "Fighting", 100, 65, 65 },
                    { 561, 55, 45, 501, "Water", 55, false, "Oshawott", 5, null, "", 63, 45, 45 },
                    { 562, 75, 60, 502, "Water", 75, false, "Dewott", 5, null, "", 83, 60, 60 },
                    { 563, 100, 85, 503, "Water", 95, false, "Samurott", 5, null, "", 108, 70, 70 },
                    { 564, 55, 39, 504, "Normal", 45, false, "Patrat", 5, null, "", 35, 39, 42 },
                    { 565, 85, 69, 505, "Normal", 60, false, "Watchog", 5, null, "", 60, 69, 77 },
                    { 566, 60, 45, 506, "Normal", 45, false, "Lillipup", 5, null, "", 25, 45, 55 },
                    { 567, 80, 65, 507, "Normal", 65, false, "Herdier", 5, null, "", 35, 65, 60 },
                    { 568, 110, 90, 508, "Normal", 85, false, "Stoutland", 5, null, "", 45, 90, 80 },
                    { 569, 50, 37, 509, "Dark", 41, false, "Purrloin", 5, null, "", 50, 37, 66 },
                    { 570, 88, 50, 510, "Dark", 64, false, "Liepard", 5, null, "", 88, 50, 106 },
                    { 571, 53, 48, 511, "Grass", 50, false, "Pansage", 5, null, "", 53, 48, 64 },
                    { 572, 98, 63, 512, "Grass", 75, false, "Simisage", 5, null, "", 98, 63, 101 },
                    { 573, 53, 48, 513, "Fire", 50, false, "Pansear", 5, null, "", 53, 48, 64 },
                    { 575, 53, 48, 515, "Water", 50, false, "Panpour", 5, null, "", 53, 48, 64 },
                    { 599, 100, 85, 538, "Fighting", 120, false, "Throh", 5, null, "", 30, 85, 45 },
                    { 501, 112, 118, 450, "Ground", 108, false, "Hippowdon", 4, null, "", 68, 72, 47 },
                    { 499, 145, 88, 448, "Fighting", 70, false, "LucarioMega Lucario", 4, null, "Steel", 140, 70, 112 },
                    { 428, 100, 100, 385, "Steel", 100, true, "Jirachi", 3, null, "Psychic", 100, 100, 100 },
                    { 429, 150, 50, 386, "Psychic", 50, true, "DeoxysNormal Forme", 3, null, "", 150, 50, 150 },
                    { 430, 180, 20, 386, "Psychic", 50, true, "DeoxysAttack Forme", 3, null, "", 180, 20, 150 },
                    { 431, 70, 160, 386, "Psychic", 50, true, "DeoxysDefense Forme", 3, null, "", 70, 160, 90 },
                    { 432, 95, 90, 386, "Psychic", 50, true, "DeoxysSpeed Forme", 3, null, "", 95, 90, 180 },
                    { 433, 68, 64, 387, "Grass", 55, false, "Turtwig", 4, null, "", 45, 55, 31 },
                    { 434, 89, 85, 388, "Grass", 75, false, "Grotle", 4, null, "", 55, 65, 36 },
                    { 435, 109, 105, 389, "Grass", 95, false, "Torterra", 4, null, "Ground", 75, 85, 56 },
                    { 436, 58, 44, 390, "Fire", 44, false, "Chimchar", 4, null, "", 58, 44, 61 },
                    { 437, 78, 52, 391, "Fire", 64, false, "Monferno", 4, null, "Fighting", 78, 52, 81 },
                    { 438, 104, 71, 392, "Fire", 76, false, "Infernape", 4, null, "Fighting", 104, 71, 108 },
                    { 439, 51, 53, 393, "Water", 53, false, "Piplup", 4, null, "", 61, 56, 40 },
                    { 440, 66, 68, 394, "Water", 64, false, "Prinplup", 4, null, "", 81, 76, 50 },
                    { 441, 86, 88, 395, "Water", 84, false, "Empoleon", 4, null, "Steel", 111, 101, 60 },
                    { 442, 55, 30, 396, "Normal", 40, false, "Starly", 4, null, "Flying", 30, 30, 60 },
                    { 443, 75, 50, 397, "Normal", 55, false, "Staravia", 4, null, "Flying", 40, 40, 80 },
                    { 444, 120, 70, 398, "Normal", 85, false, "Staraptor", 4, null, "Flying", 50, 60, 100 },
                    { 445, 45, 40, 399, "Normal", 59, false, "Bidoof", 4, null, "", 35, 40, 31 },
                    { 446, 85, 60, 400, "Normal", 79, false, "Bibarel", 4, null, "Water", 55, 60, 71 },
                    { 447, 25, 41, 401, "Bug", 37, false, "Kricketot", 4, null, "", 25, 41, 25 },
                    { 448, 85, 51, 402, "Bug", 77, false, "Kricketune", 4, null, "", 55, 51, 65 },
                    { 427, 180, 100, 384, "Dragon", 105, true, "RayquazaMega Rayquaza", 3, null, "Flying", 180, 100, 115 },
                    { 449, 65, 34, 403, "Electric", 45, false, "Shinx", 4, null, "", 40, 34, 45 },
                    { 426, 150, 90, 384, "Dragon", 105, true, "Rayquaza", 3, null, "Flying", 150, 90, 95 },
                    { 424, 150, 140, 383, "Ground", 100, true, "Groudon", 3, null, "", 100, 90, 90 },
                    { 403, 104, 105, 367, "Water", 55, false, "Huntail", 3, null, "", 94, 75, 52 },
                    { 404, 84, 105, 368, "Water", 55, false, "Gorebyss", 3, null, "", 114, 75, 52 },
                    { 405, 90, 130, 369, "Water", 100, false, "Relicanth", 3, null, "Rock", 45, 65, 55 },
                    { 406, 30, 55, 370, "Water", 43, false, "Luvdisc", 3, null, "", 40, 65, 97 },
                    { 407, 75, 60, 371, "Dragon", 45, false, "Bagon", 3, null, "", 40, 30, 50 },
                    { 408, 95, 100, 372, "Dragon", 65, false, "Shelgon", 3, null, "", 60, 50, 50 },
                    { 409, 135, 80, 373, "Dragon", 95, false, "Salamence", 3, null, "Flying", 110, 80, 100 },
                    { 410, 145, 130, 373, "Dragon", 95, false, "SalamenceMega Salamence", 3, null, "Flying", 120, 90, 120 },
                    { 411, 55, 80, 374, "Steel", 40, false, "Beldum", 3, null, "Psychic", 35, 60, 30 },
                    { 412, 75, 100, 375, "Steel", 60, false, "Metang", 3, null, "Psychic", 55, 80, 50 },
                    { 413, 135, 130, 376, "Steel", 80, false, "Metagross", 3, null, "Psychic", 95, 90, 70 },
                    { 414, 145, 150, 376, "Steel", 80, false, "MetagrossMega Metagross", 3, null, "Psychic", 105, 110, 110 },
                    { 415, 100, 200, 377, "Rock", 80, true, "Regirock", 3, null, "", 50, 100, 50 },
                    { 416, 50, 100, 378, "Ice", 80, true, "Regice", 3, null, "", 100, 200, 50 },
                    { 417, 75, 150, 379, "Steel", 80, true, "Registeel", 3, null, "", 75, 150, 50 },
                    { 418, 80, 90, 380, "Dragon", 80, true, "Latias", 3, null, "Psychic", 110, 130, 110 },
                    { 419, 100, 120, 380, "Dragon", 80, true, "LatiasMega Latias", 3, null, "Psychic", 140, 150, 110 },
                    { 420, 90, 80, 381, "Dragon", 80, true, "Latios", 3, null, "Psychic", 130, 110, 110 },
                    { 421, 130, 100, 381, "Dragon", 80, true, "LatiosMega Latios", 3, null, "Psychic", 160, 120, 110 },
                    { 422, 100, 90, 382, "Water", 100, true, "Kyogre", 3, null, "", 150, 140, 90 },
                    { 423, 150, 90, 382, "Water", 100, true, "KyogrePrimal Kyogre", 3, null, "", 180, 160, 90 },
                    { 425, 180, 160, 383, "Ground", 100, true, "GroudonPrimal Groudon", 3, null, "Fire", 150, 90, 90 },
                    { 500, 72, 78, 449, "Ground", 68, false, "Hippopotas", 4, null, "", 38, 42, 32 },
                    { 450, 85, 49, 404, "Electric", 60, false, "Luxio", 4, null, "", 60, 49, 60 },
                    { 452, 30, 35, 406, "Grass", 40, false, "Budew", 4, null, "Poison", 50, 70, 55 },
                    { 478, 60, 60, 429, "Ghost", 60, false, "Mismagius", 4, null, "", 105, 105, 105 },
                    { 479, 125, 52, 430, "Dark", 100, false, "Honchkrow", 4, null, "Flying", 105, 52, 71 },
                    { 480, 55, 42, 431, "Normal", 49, false, "Glameow", 4, null, "", 42, 37, 85 },
                    { 481, 82, 64, 432, "Normal", 71, false, "Purugly", 4, null, "", 64, 59, 112 },
                    { 482, 30, 50, 433, "Psychic", 45, false, "Chingling", 4, null, "", 65, 50, 45 },
                    { 483, 63, 47, 434, "Poison", 63, false, "Stunky", 4, null, "Dark", 41, 41, 74 },
                    { 484, 93, 67, 435, "Poison", 103, false, "Skuntank", 4, null, "Dark", 71, 61, 84 },
                    { 485, 24, 86, 436, "Steel", 57, false, "Bronzor", 4, null, "Psychic", 24, 86, 23 },
                    { 486, 89, 116, 437, "Steel", 67, false, "Bronzong", 4, null, "Psychic", 79, 116, 33 },
                    { 487, 80, 95, 438, "Rock", 50, false, "Bonsly", 4, null, "", 10, 45, 10 },
                    { 488, 25, 45, 439, "Psychic", 20, false, "Mime Jr.", 4, null, "Fairy", 70, 90, 60 },
                    { 489, 5, 5, 440, "Normal", 100, false, "Happiny", 4, null, "", 15, 65, 30 },
                    { 490, 65, 45, 441, "Normal", 76, false, "Chatot", 4, null, "Flying", 92, 42, 91 },
                    { 491, 92, 108, 442, "Ghost", 50, false, "Spiritomb", 4, null, "Dark", 92, 108, 35 },
                    { 492, 70, 45, 443, "Dragon", 58, false, "Gible", 4, null, "Ground", 40, 45, 42 },
                    { 493, 90, 65, 444, "Dragon", 68, false, "Gabite", 4, null, "Ground", 50, 55, 82 },
                    { 494, 130, 95, 445, "Dragon", 108, false, "Garchomp", 4, null, "Ground", 80, 85, 102 },
                    { 495, 170, 115, 445, "Dragon", 108, false, "GarchompMega Garchomp", 4, null, "Ground", 120, 95, 92 },
                    { 496, 85, 40, 446, "Normal", 135, false, "Munchlax", 4, null, "", 40, 85, 5 },
                    { 497, 70, 40, 447, "Fighting", 40, false, "Riolu", 4, null, "", 35, 40, 60 },
                    { 498, 110, 70, 448, "Fighting", 70, false, "Lucario", 4, null, "Steel", 115, 70, 90 },
                    { 477, 136, 94, 428, "Normal", 65, false, "LopunnyMega Lopunny", 4, null, "Fighting", 54, 96, 135 },
                    { 451, 120, 79, 405, "Electric", 80, false, "Luxray", 4, null, "", 95, 79, 70 },
                    { 476, 76, 84, 428, "Normal", 65, false, "Lopunny", 4, null, "", 54, 96, 105 },
                    { 474, 80, 44, 426, "Ghost", 150, false, "Drifblim", 4, null, "Flying", 90, 54, 80 },
                    { 453, 70, 65, 407, "Grass", 60, false, "Roserade", 4, null, "Poison", 125, 105, 90 },
                    { 454, 125, 40, 408, "Rock", 67, false, "Cranidos", 4, null, "", 30, 30, 58 },
                    { 455, 165, 60, 409, "Rock", 97, false, "Rampardos", 4, null, "", 65, 50, 58 },
                    { 456, 42, 118, 410, "Rock", 30, false, "Shieldon", 4, null, "Steel", 42, 88, 30 },
                    { 457, 52, 168, 411, "Rock", 60, false, "Bastiodon", 4, null, "Steel", 47, 138, 30 },
                    { 458, 29, 45, 412, "Bug", 40, false, "Burmy", 4, null, "", 29, 45, 36 },
                    { 459, 59, 85, 413, "Bug", 60, false, "WormadamPlant Cloak", 4, null, "Grass", 79, 105, 36 },
                    { 460, 79, 105, 413, "Bug", 60, false, "WormadamSandy Cloak", 4, null, "Ground", 59, 85, 36 },
                    { 461, 69, 95, 413, "Bug", 60, false, "WormadamTrash Cloak", 4, null, "Steel", 69, 95, 36 },
                    { 462, 94, 50, 414, "Bug", 70, false, "Mothim", 4, null, "Flying", 94, 50, 66 },
                    { 463, 30, 42, 415, "Bug", 30, false, "Combee", 4, null, "Flying", 30, 42, 70 },
                    { 464, 80, 102, 416, "Bug", 70, false, "Vespiquen", 4, null, "Flying", 80, 102, 40 },
                    { 465, 45, 70, 417, "Electric", 60, false, "Pachirisu", 4, null, "", 45, 90, 95 },
                    { 466, 65, 35, 418, "Water", 55, false, "Buizel", 4, null, "", 60, 30, 85 },
                    { 467, 105, 55, 419, "Water", 85, false, "Floatzel", 4, null, "", 85, 50, 115 },
                    { 468, 35, 45, 420, "Grass", 45, false, "Cherubi", 4, null, "", 62, 53, 35 },
                    { 469, 60, 70, 421, "Grass", 70, false, "Cherrim", 4, null, "", 87, 78, 85 },
                    { 470, 48, 48, 422, "Water", 76, false, "Shellos", 4, null, "", 57, 62, 34 },
                    { 471, 83, 68, 423, "Water", 111, false, "Gastrodon", 4, null, "Ground", 92, 82, 39 },
                    { 472, 100, 66, 424, "Normal", 75, false, "Ambipom", 4, null, "", 60, 66, 115 },
                    { 473, 50, 34, 425, "Ghost", 90, false, "Drifloon", 4, null, "Flying", 60, 44, 70 },
                    { 475, 66, 44, 427, "Normal", 55, false, "Buneary", 4, null, "", 44, 56, 85 },
                    { 402, 64, 85, 366, "Water", 35, false, "Clamperl", 3, null, "", 74, 55, 32 },
                    { 600, 125, 75, 539, "Fighting", 75, false, "Sawk", 5, null, "", 30, 75, 85 },
                    { 602, 63, 90, 541, "Bug", 55, false, "Swadloon", 5, null, "Grass", 50, 80, 42 },
                    { 728, 36, 38, 659, "Normal", 38, false, "Bunnelby", 6, null, "", 32, 36, 57 },
                    { 729, 56, 77, 660, "Normal", 85, false, "Diggersby", 6, null, "Ground", 50, 77, 78 },
                    { 730, 50, 43, 661, "Normal", 45, false, "Fletchling", 6, null, "Flying", 40, 38, 62 },
                    { 731, 73, 55, 662, "Fire", 62, false, "Fletchinder", 6, null, "Flying", 56, 52, 84 },
                    { 732, 81, 71, 663, "Fire", 78, false, "Talonflame", 6, null, "Flying", 74, 69, 126 },
                    { 733, 35, 40, 664, "Bug", 38, false, "Scatterbug", 6, null, "", 27, 25, 35 },
                    { 734, 22, 60, 665, "Bug", 45, false, "Spewpa", 6, null, "", 27, 30, 29 },
                    { 735, 52, 50, 666, "Bug", 80, false, "Vivillon", 6, null, "Flying", 90, 50, 89 },
                    { 736, 50, 58, 667, "Fire", 62, false, "Litleo", 6, null, "Normal", 73, 54, 72 },
                    { 737, 68, 72, 668, "Fire", 86, false, "Pyroar", 6, null, "Normal", 109, 66, 106 },
                    { 738, 38, 39, 669, "Fairy", 44, false, "Flabébé", 6, null, "", 61, 79, 42 },
                    { 739, 45, 47, 670, "Fairy", 54, false, "Floette", 6, null, "", 75, 98, 52 },
                    { 740, 65, 68, 671, "Fairy", 78, false, "Florges", 6, null, "", 112, 154, 75 },
                    { 741, 65, 48, 672, "Grass", 66, false, "Skiddo", 6, null, "", 62, 57, 52 },
                    { 742, 100, 62, 673, "Grass", 123, false, "Gogoat", 6, null, "", 97, 81, 68 },
                    { 743, 82, 62, 674, "Fighting", 67, false, "Pancham", 6, null, "", 46, 48, 43 },
                    { 744, 124, 78, 675, "Fighting", 95, false, "Pangoro", 6, null, "Dark", 69, 71, 58 },
                    { 745, 80, 60, 676, "Normal", 75, false, "Furfrou", 6, null, "", 65, 90, 102 },
                    { 746, 48, 54, 677, "Psychic", 62, false, "Espurr", 6, null, "", 63, 60, 68 },
                    { 747, 48, 76, 678, "Psychic", 74, false, "MeowsticMale", 6, null, "", 83, 81, 104 },
                    { 748, 48, 76, 678, "Psychic", 74, false, "MeowsticFemale", 6, null, "", 83, 81, 104 },
                    { 727, 95, 67, 658, "Water", 72, false, "Greninja", 6, null, "Dark", 103, 71, 122 },
                    { 749, 80, 100, 679, "Steel", 45, false, "Honedge", 6, null, "Ghost", 35, 37, 28 },
                    { 726, 63, 52, 657, "Water", 54, false, "Frogadier", 6, null, "", 83, 56, 97 },
                    { 724, 69, 72, 655, "Fire", 75, false, "Delphox", 6, null, "Psychic", 114, 100, 104 },
                    { 703, 115, 70, 641, "Flying", 79, true, "TornadusIncarnate Forme", 5, null, "", 125, 80, 111 },
                    { 704, 100, 80, 641, "Flying", 79, true, "TornadusTherian Forme", 5, null, "", 110, 90, 121 },
                    { 705, 115, 70, 642, "Electric", 79, true, "ThundurusIncarnate Forme", 5, null, "Flying", 125, 80, 111 },
                    { 706, 105, 70, 642, "Electric", 79, true, "ThundurusTherian Forme", 5, null, "Flying", 145, 80, 101 },
                    { 707, 120, 100, 643, "Dragon", 100, true, "Reshiram", 5, null, "Fire", 150, 120, 90 },
                    { 708, 150, 120, 644, "Dragon", 100, true, "Zekrom", 5, null, "Electric", 120, 100, 90 },
                    { 709, 125, 90, 645, "Ground", 89, true, "LandorusIncarnate Forme", 5, null, "Flying", 115, 80, 101 },
                    { 710, 145, 90, 645, "Ground", 89, true, "LandorusTherian Forme", 5, null, "Flying", 105, 80, 91 },
                    { 711, 130, 90, 646, "Dragon", 125, true, "Kyurem", 5, null, "Ice", 130, 90, 95 },
                    { 712, 170, 100, 646, "Dragon", 125, true, "KyuremBlack Kyurem", 5, null, "Ice", 120, 90, 95 },
                    { 713, 120, 90, 646, "Dragon", 125, true, "KyuremWhite Kyurem", 5, null, "Ice", 170, 100, 95 },
                    { 714, 72, 90, 647, "Water", 91, false, "KeldeoOrdinary Forme", 5, null, "Fighting", 129, 90, 108 },
                    { 715, 72, 90, 647, "Water", 91, false, "KeldeoResolute Forme", 5, null, "Fighting", 129, 90, 108 },
                    { 716, 77, 77, 648, "Normal", 100, false, "MeloettaAria Forme", 5, null, "Psychic", 128, 128, 90 },
                    { 717, 128, 90, 648, "Normal", 100, false, "MeloettaPirouette Forme", 5, null, "Fighting", 77, 77, 128 },
                    { 718, 120, 95, 649, "Bug", 71, false, "Genesect", 5, null, "Steel", 120, 95, 99 },
                    { 719, 61, 65, 650, "Grass", 56, false, "Chespin", 6, null, "", 48, 45, 38 },
                    { 720, 78, 95, 651, "Grass", 61, false, "Quilladin", 6, null, "", 56, 58, 57 },
                    { 721, 107, 122, 652, "Grass", 88, false, "Chesnaught", 6, null, "Fighting", 74, 75, 64 },
                    { 722, 45, 40, 653, "Fire", 40, false, "Fennekin", 6, null, "", 62, 60, 60 },
                    { 723, 59, 58, 654, "Fire", 59, false, "Braixen", 6, null, "", 90, 70, 73 },
                    { 725, 56, 40, 656, "Water", 41, false, "Froakie", 6, null, "", 62, 44, 71 },
                    { 702, 90, 72, 640, "Grass", 91, true, "Virizion", 5, null, "Fighting", 90, 129, 108 },
                    { 750, 110, 150, 680, "Steel", 59, false, "Doublade", 6, null, "Ghost", 45, 49, 35 },
                    { 752, 50, 150, 681, "Steel", 60, false, "AegislashShield Forme", 6, null, "Ghost", 50, 150, 60 },
                    { 778, 80, 91, 707, "Steel", 57, false, "Klefki", 6, null, "Fairy", 80, 87, 75 },
                    { 779, 70, 48, 708, "Ghost", 43, false, "Phantump", 6, null, "Grass", 50, 60, 38 },
                    { 780, 110, 76, 709, "Ghost", 85, false, "Trevenant", 6, null, "Grass", 65, 82, 56 },
                    { 781, 66, 70, 710, "Ghost", 49, false, "PumpkabooAverage Size", 6, null, "Grass", 44, 55, 51 },
                    { 782, 66, 70, 710, "Ghost", 44, false, "PumpkabooSmall Size", 6, null, "Grass", 44, 55, 56 },
                    { 783, 66, 70, 710, "Ghost", 54, false, "PumpkabooLarge Size", 6, null, "Grass", 44, 55, 46 },
                    { 784, 66, 70, 710, "Ghost", 59, false, "PumpkabooSuper Size", 6, null, "Grass", 44, 55, 41 },
                    { 785, 90, 122, 711, "Ghost", 65, false, "GourgeistAverage Size", 6, null, "Grass", 58, 75, 84 },
                    { 786, 85, 122, 711, "Ghost", 55, false, "GourgeistSmall Size", 6, null, "Grass", 58, 75, 99 },
                    { 787, 95, 122, 711, "Ghost", 75, false, "GourgeistLarge Size", 6, null, "Grass", 58, 75, 69 },
                    { 788, 100, 122, 711, "Ghost", 85, false, "GourgeistSuper Size", 6, null, "Grass", 58, 75, 54 },
                    { 789, 69, 85, 712, "Ice", 55, false, "Bergmite", 6, null, "", 32, 35, 28 },
                    { 790, 117, 184, 713, "Ice", 95, false, "Avalugg", 6, null, "", 44, 46, 28 },
                    { 791, 30, 35, 714, "Flying", 40, false, "Noibat", 6, null, "Dragon", 45, 40, 55 },
                    { 792, 70, 80, 715, "Flying", 85, false, "Noivern", 6, null, "Dragon", 97, 80, 123 },
                    { 793, 131, 95, 716, "Fairy", 126, true, "Xerneas", 6, null, "", 131, 98, 99 },
                    { 794, 131, 95, 717, "Dark", 126, true, "Yveltal", 6, null, "Flying", 131, 98, 99 },
                    { 795, 100, 121, 718, "Dragon", 108, true, "Zygarde50% Forme", 6, null, "Ground", 81, 95, 95 },
                    { 796, 100, 150, 719, "Rock", 50, true, "Diancie", 6, null, "Fairy", 100, 150, 50 },
                    { 797, 160, 110, 719, "Rock", 50, true, "DiancieMega Diancie", 6, null, "Fairy", 160, 110, 110 },
                    { 798, 110, 60, 720, "Psychic", 80, true, "HoopaHoopa Confined", 6, null, "Ghost", 150, 130, 70 },
                    { 777, 100, 70, 706, "Dragon", 90, false, "Goodra", 6, null, "", 110, 150, 80 },
                    { 751, 150, 50, 681, "Steel", 60, false, "AegislashBlade Forme", 6, null, "Ghost", 150, 50, 60 },
                    { 776, 75, 53, 705, "Dragon", 68, false, "Sliggoo", 6, null, "", 83, 113, 60 },
                    { 774, 50, 150, 703, "Rock", 50, false, "Carbink", 6, null, "Fairy", 50, 150, 50 },
                    { 753, 52, 60, 682, "Fairy", 78, false, "Spritzee", 6, null, "", 63, 65, 23 },
                    { 754, 72, 72, 683, "Fairy", 101, false, "Aromatisse", 6, null, "", 99, 89, 29 },
                    { 755, 48, 66, 684, "Fairy", 62, false, "Swirlix", 6, null, "", 59, 57, 49 },
                    { 756, 80, 86, 685, "Fairy", 82, false, "Slurpuff", 6, null, "", 85, 75, 72 },
                    { 757, 54, 53, 686, "Dark", 53, false, "Inkay", 6, null, "Psychic", 37, 46, 45 },
                    { 758, 92, 88, 687, "Dark", 86, false, "Malamar", 6, null, "Psychic", 68, 75, 73 },
                    { 759, 52, 67, 688, "Rock", 42, false, "Binacle", 6, null, "Water", 39, 56, 50 },
                    { 760, 105, 115, 689, "Rock", 72, false, "Barbaracle", 6, null, "Water", 54, 86, 68 },
                    { 761, 60, 60, 690, "Poison", 50, false, "Skrelp", 6, null, "Water", 60, 60, 30 },
                    { 762, 75, 90, 691, "Poison", 65, false, "Dragalge", 6, null, "Dragon", 97, 123, 44 },
                    { 763, 53, 62, 692, "Water", 50, false, "Clauncher", 6, null, "", 58, 63, 44 },
                    { 764, 73, 88, 693, "Water", 71, false, "Clawitzer", 6, null, "", 120, 89, 59 },
                    { 765, 38, 33, 694, "Electric", 44, false, "Helioptile", 6, null, "Normal", 61, 43, 70 },
                    { 766, 55, 52, 695, "Electric", 62, false, "Heliolisk", 6, null, "Normal", 109, 94, 109 },
                    { 767, 89, 77, 696, "Rock", 58, false, "Tyrunt", 6, null, "Dragon", 45, 45, 48 },
                    { 768, 121, 119, 697, "Rock", 82, false, "Tyrantrum", 6, null, "Dragon", 69, 59, 71 },
                    { 769, 59, 50, 698, "Rock", 77, false, "Amaura", 6, null, "Ice", 67, 63, 46 },
                    { 770, 77, 72, 699, "Rock", 123, false, "Aurorus", 6, null, "Ice", 99, 92, 58 },
                    { 771, 65, 65, 700, "Fairy", 95, false, "Sylveon", 6, null, "", 110, 130, 60 },
                    { 772, 92, 75, 701, "Fighting", 78, false, "Hawlucha", 6, null, "Flying", 74, 63, 118 },
                    { 773, 58, 57, 702, "Electric", 67, false, "Dedenne", 6, null, "Fairy", 81, 67, 101 },
                    { 775, 50, 35, 704, "Dragon", 45, false, "Goomy", 6, null, "", 55, 75, 40 },
                    { 601, 53, 70, 540, "Bug", 45, false, "Sewaddle", 5, null, "Grass", 40, 60, 42 },
                    { 701, 129, 90, 639, "Rock", 91, true, "Terrakion", 5, null, "Fighting", 72, 90, 108 },
                    { 699, 60, 65, 637, "Bug", 85, false, "Volcarona", 5, null, "Fire", 135, 105, 100 },
                    { 628, 112, 45, 566, "Rock", 55, false, "Archen", 5, null, "Flying", 74, 45, 70 },
                    { 629, 140, 65, 567, "Rock", 75, false, "Archeops", 5, null, "Flying", 112, 65, 110 },
                    { 630, 50, 62, 568, "Poison", 50, false, "Trubbish", 5, null, "", 40, 62, 65 },
                    { 631, 95, 82, 569, "Poison", 80, false, "Garbodor", 5, null, "", 60, 82, 75 },
                    { 632, 65, 40, 570, "Dark", 40, false, "Zorua", 5, null, "", 80, 40, 65 },
                    { 633, 105, 60, 571, "Dark", 60, false, "Zoroark", 5, null, "", 120, 60, 105 },
                    { 634, 50, 40, 572, "Normal", 55, false, "Minccino", 5, null, "", 40, 40, 75 },
                    { 635, 95, 60, 573, "Normal", 75, false, "Cinccino", 5, null, "", 65, 60, 115 },
                    { 636, 30, 50, 574, "Psychic", 45, false, "Gothita", 5, null, "", 55, 65, 45 },
                    { 637, 45, 70, 575, "Psychic", 60, false, "Gothorita", 5, null, "", 75, 85, 55 },
                    { 638, 55, 95, 576, "Psychic", 70, false, "Gothitelle", 5, null, "", 95, 110, 65 },
                    { 639, 30, 40, 577, "Psychic", 45, false, "Solosis", 5, null, "", 105, 50, 20 },
                    { 640, 40, 50, 578, "Psychic", 65, false, "Duosion", 5, null, "", 125, 60, 30 },
                    { 641, 65, 75, 579, "Psychic", 110, false, "Reuniclus", 5, null, "", 125, 85, 30 },
                    { 642, 44, 50, 580, "Water", 62, false, "Ducklett", 5, null, "Flying", 44, 50, 55 },
                    { 643, 87, 63, 581, "Water", 75, false, "Swanna", 5, null, "Flying", 87, 63, 98 },
                    { 644, 50, 50, 582, "Ice", 36, false, "Vanillite", 5, null, "", 65, 60, 44 },
                    { 645, 65, 65, 583, "Ice", 51, false, "Vanillish", 5, null, "", 80, 75, 59 },
                    { 646, 95, 85, 584, "Ice", 71, false, "Vanilluxe", 5, null, "", 110, 95, 79 },
                    { 647, 60, 50, 585, "Normal", 60, false, "Deerling", 5, null, "Grass", 40, 50, 75 },
                    { 648, 100, 70, 586, "Normal", 80, false, "Sawsbuck", 5, null, "Grass", 60, 70, 95 },
                    { 627, 108, 133, 565, "Water", 74, false, "Carracosta", 5, null, "Rock", 83, 65, 32 },
                    { 649, 75, 60, 587, "Electric", 55, false, "Emolga", 5, null, "Flying", 75, 60, 103 },
                    { 626, 78, 103, 564, "Water", 54, false, "Tirtouga", 5, null, "Rock", 53, 45, 22 },
                    { 624, 30, 85, 562, "Ghost", 38, false, "Yamask", 5, null, "", 55, 65, 30 },
                    { 603, 103, 80, 542, "Bug", 75, false, "Leavanny", 5, null, "Grass", 70, 80, 92 },
                    { 604, 45, 59, 543, "Bug", 30, false, "Venipede", 5, null, "Poison", 30, 39, 57 },
                    { 605, 55, 99, 544, "Bug", 40, false, "Whirlipede", 5, null, "Poison", 40, 79, 47 },
                    { 606, 100, 89, 545, "Bug", 60, false, "Scolipede", 5, null, "Poison", 55, 69, 112 },
                    { 607, 27, 60, 546, "Grass", 40, false, "Cottonee", 5, null, "Fairy", 37, 50, 66 },
                    { 608, 67, 85, 547, "Grass", 60, false, "Whimsicott", 5, null, "Fairy", 77, 75, 116 },
                    { 609, 35, 50, 548, "Grass", 45, false, "Petilil", 5, null, "", 70, 50, 30 },
                    { 610, 60, 75, 549, "Grass", 70, false, "Lilligant", 5, null, "", 110, 75, 90 },
                    { 611, 92, 65, 550, "Water", 70, false, "Basculin", 5, null, "", 80, 55, 98 },
                    { 612, 72, 35, 551, "Ground", 50, false, "Sandile", 5, null, "Dark", 35, 35, 65 },
                    { 613, 82, 45, 552, "Ground", 60, false, "Krokorok", 5, null, "Dark", 45, 45, 74 },
                    { 614, 117, 80, 553, "Ground", 95, false, "Krookodile", 5, null, "Dark", 65, 70, 92 },
                    { 615, 90, 45, 554, "Fire", 70, false, "Darumaka", 5, null, "", 15, 45, 50 },
                    { 616, 140, 55, 555, "Fire", 105, false, "DarmanitanStandard Mode", 5, null, "", 30, 55, 95 },
                    { 617, 30, 105, 555, "Fire", 105, false, "DarmanitanZen Mode", 5, null, "Psychic", 140, 105, 55 },
                    { 618, 86, 67, 556, "Grass", 75, false, "Maractus", 5, null, "", 106, 67, 60 },
                    { 619, 65, 85, 557, "Bug", 50, false, "Dwebble", 5, null, "Rock", 35, 35, 55 },
                    { 620, 95, 125, 558, "Bug", 70, false, "Crustle", 5, null, "Rock", 65, 75, 45 },
                    { 621, 75, 70, 559, "Dark", 50, false, "Scraggy", 5, null, "Fighting", 35, 70, 48 },
                    { 622, 90, 115, 560, "Dark", 65, false, "Scrafty", 5, null, "Fighting", 45, 115, 58 },
                    { 623, 58, 80, 561, "Psychic", 72, false, "Sigilyph", 5, null, "Flying", 103, 80, 97 },
                    { 625, 50, 145, 563, "Ghost", 58, false, "Cofagrigus", 5, null, "", 95, 105, 30 },
                    { 700, 90, 129, 638, "Steel", 91, true, "Cobalion", 5, null, "Fighting", 90, 72, 108 },
                    { 650, 75, 45, 588, "Bug", 50, false, "Karrablast", 5, null, "", 40, 45, 60 },
                    { 652, 55, 45, 590, "Grass", 69, false, "Foongus", 5, null, "Poison", 55, 55, 15 },
                    { 678, 40, 85, 616, "Bug", 50, false, "Shelmet", 5, null, "", 40, 65, 25 },
                    { 679, 70, 40, 617, "Bug", 80, false, "Accelgor", 5, null, "", 100, 60, 145 },
                    { 680, 66, 84, 618, "Ground", 109, false, "Stunfisk", 5, null, "Electric", 81, 99, 32 },
                    { 681, 85, 50, 619, "Fighting", 45, false, "Mienfoo", 5, null, "", 55, 50, 65 },
                    { 682, 125, 60, 620, "Fighting", 65, false, "Mienshao", 5, null, "", 95, 60, 105 },
                    { 683, 120, 90, 621, "Dragon", 77, false, "Druddigon", 5, null, "", 60, 90, 48 },
                    { 684, 74, 50, 622, "Ground", 59, false, "Golett", 5, null, "Ghost", 35, 50, 35 },
                    { 685, 124, 80, 623, "Ground", 89, false, "Golurk", 5, null, "Ghost", 55, 80, 55 },
                    { 686, 85, 70, 624, "Dark", 45, false, "Pawniard", 5, null, "Steel", 40, 40, 60 },
                    { 687, 125, 100, 625, "Dark", 65, false, "Bisharp", 5, null, "Steel", 60, 70, 70 },
                    { 688, 110, 95, 626, "Normal", 95, false, "Bouffalant", 5, null, "", 40, 95, 55 },
                    { 689, 83, 50, 627, "Normal", 70, false, "Rufflet", 5, null, "Flying", 37, 50, 60 },
                    { 690, 123, 75, 628, "Normal", 100, false, "Braviary", 5, null, "Flying", 57, 75, 80 },
                    { 691, 55, 75, 629, "Dark", 70, false, "Vullaby", 5, null, "Flying", 45, 65, 60 },
                    { 692, 65, 105, 630, "Dark", 110, false, "Mandibuzz", 5, null, "Flying", 55, 95, 80 },
                    { 693, 97, 66, 631, "Fire", 85, false, "Heatmor", 5, null, "", 105, 66, 65 },
                    { 694, 109, 112, 632, "Bug", 58, false, "Durant", 5, null, "Steel", 48, 48, 109 },
                    { 695, 65, 50, 633, "Dark", 52, false, "Deino", 5, null, "Dragon", 45, 50, 38 },
                    { 696, 85, 70, 634, "Dark", 72, false, "Zweilous", 5, null, "Dragon", 65, 70, 58 },
                    { 697, 105, 90, 635, "Dark", 92, false, "Hydreigon", 5, null, "Dragon", 125, 90, 98 },
                    { 698, 85, 55, 636, "Bug", 55, false, "Larvesta", 5, null, "Fire", 50, 55, 60 },
                    { 677, 50, 30, 615, "Ice", 70, false, "Cryogonal", 5, null, "", 95, 135, 105 },
                    { 651, 135, 105, 589, "Bug", 70, false, "Escavalier", 5, null, "Steel", 60, 105, 20 },
                    { 676, 110, 80, 614, "Ice", 95, false, "Beartic", 5, null, "", 70, 80, 50 },
                    { 674, 147, 90, 612, "Dragon", 76, false, "Haxorus", 5, null, "", 60, 70, 97 },
                    { 653, 85, 70, 591, "Grass", 114, false, "Amoonguss", 5, null, "Poison", 85, 80, 30 },
                    { 654, 40, 50, 592, "Water", 55, false, "Frillish", 5, null, "Ghost", 65, 85, 40 },
                    { 655, 60, 70, 593, "Water", 100, false, "Jellicent", 5, null, "Ghost", 85, 105, 60 },
                    { 656, 75, 80, 594, "Water", 165, false, "Alomomola", 5, null, "", 40, 45, 65 },
                    { 657, 47, 50, 595, "Bug", 50, false, "Joltik", 5, null, "Electric", 57, 50, 65 },
                    { 658, 77, 60, 596, "Bug", 70, false, "Galvantula", 5, null, "Electric", 97, 60, 108 },
                    { 659, 50, 91, 597, "Grass", 44, false, "Ferroseed", 5, null, "Steel", 24, 86, 10 },
                    { 660, 94, 131, 598, "Grass", 74, false, "Ferrothorn", 5, null, "Steel", 54, 116, 20 },
                    { 661, 55, 70, 599, "Steel", 40, false, "Klink", 5, null, "", 45, 60, 30 },
                    { 662, 80, 95, 600, "Steel", 60, false, "Klang", 5, null, "", 70, 85, 50 },
                    { 663, 100, 115, 601, "Steel", 60, false, "Klinklang", 5, null, "", 70, 85, 90 },
                    { 664, 55, 40, 602, "Electric", 35, false, "Tynamo", 5, null, "", 45, 40, 60 },
                    { 665, 85, 70, 603, "Electric", 65, false, "Eelektrik", 5, null, "", 75, 70, 40 },
                    { 666, 115, 80, 604, "Electric", 85, false, "Eelektross", 5, null, "", 105, 80, 50 },
                    { 667, 55, 55, 605, "Psychic", 55, false, "Elgyem", 5, null, "", 85, 55, 30 },
                    { 668, 75, 75, 606, "Psychic", 75, false, "Beheeyem", 5, null, "", 125, 95, 40 },
                    { 669, 30, 55, 607, "Ghost", 50, false, "Litwick", 5, null, "Fire", 65, 55, 20 },
                    { 670, 40, 60, 608, "Ghost", 60, false, "Lampent", 5, null, "Fire", 95, 60, 55 },
                    { 671, 55, 90, 609, "Ghost", 60, false, "Chandelure", 5, null, "Fire", 145, 90, 80 },
                    { 672, 87, 60, 610, "Dragon", 46, false, "Axew", 5, null, "", 30, 40, 57 },
                    { 673, 117, 70, 611, "Dragon", 66, false, "Fraxure", 5, null, "", 40, 50, 67 },
                    { 675, 70, 40, 613, "Ice", 55, false, "Cubchoo", 5, null, "", 60, 40, 40 },
                    { 401, 80, 90, 365, "Ice", 110, false, "Walrein", 3, null, "Water", 95, 90, 65 },
                    { 400, 60, 70, 364, "Ice", 90, false, "Sealeo", 3, null, "Water", 75, 70, 45 },
                    { 399, 40, 50, 363, "Ice", 70, false, "Spheal", 3, null, "Water", 55, 50, 25 },
                    { 127, 65, 95, 117, "Water", 55, false, "Seadra", 1, null, "", 95, 45, 85 },
                    { 128, 67, 60, 118, "Water", 45, false, "Goldeen", 1, null, "", 35, 50, 63 },
                    { 129, 92, 65, 119, "Water", 80, false, "Seaking", 1, null, "", 65, 80, 68 },
                    { 130, 45, 55, 120, "Water", 30, false, "Staryu", 1, null, "", 70, 55, 85 },
                    { 131, 75, 85, 121, "Water", 60, false, "Starmie", 1, null, "Psychic", 100, 85, 115 },
                    { 132, 45, 65, 122, "Psychic", 40, false, "Mr. Mime", 1, null, "Fairy", 100, 120, 90 },
                    { 133, 110, 80, 123, "Bug", 70, false, "Scyther", 1, null, "Flying", 55, 80, 105 },
                    { 134, 50, 35, 124, "Ice", 65, false, "Jynx", 1, null, "Psychic", 115, 95, 95 },
                    { 135, 83, 57, 125, "Electric", 65, false, "Electabuzz", 1, null, "", 95, 85, 105 },
                    { 136, 95, 57, 126, "Fire", 65, false, "Magmar", 1, null, "", 100, 85, 93 },
                    { 137, 125, 100, 127, "Bug", 65, false, "Pinsir", 1, null, "", 55, 70, 85 },
                    { 138, 155, 120, 127, "Bug", 65, false, "PinsirMega Pinsir", 1, null, "Flying", 65, 90, 105 },
                    { 139, 100, 95, 128, "Normal", 75, false, "Tauros", 1, null, "", 40, 70, 110 },
                    { 140, 10, 55, 129, "Water", 20, false, "Magikarp", 1, null, "", 15, 20, 80 },
                    { 141, 125, 79, 130, "Water", 95, false, "Gyarados", 1, null, "Flying", 60, 100, 81 },
                    { 142, 155, 109, 130, "Water", 95, false, "GyaradosMega Gyarados", 1, null, "Dark", 70, 130, 81 },
                    { 143, 85, 80, 131, "Water", 130, false, "Lapras", 1, null, "Ice", 85, 95, 60 },
                    { 144, 48, 48, 132, "Normal", 48, false, "Ditto", 1, null, "", 48, 48, 48 },
                    { 145, 55, 50, 133, "Normal", 55, false, "Eevee", 1, null, "", 45, 65, 55 },
                    { 146, 65, 60, 134, "Water", 130, false, "Vaporeon", 1, null, "", 110, 95, 65 },
                    { 147, 65, 60, 135, "Electric", 65, false, "Jolteon", 1, null, "", 110, 95, 130 },
                    { 126, 40, 70, 116, "Water", 30, false, "Horsea", 1, null, "", 70, 25, 60 },
                    { 148, 130, 60, 136, "Fire", 65, false, "Flareon", 1, null, "", 95, 110, 65 },
                    { 125, 125, 100, 115, "Normal", 105, false, "KangaskhanMega Kangaskhan", 1, null, "", 60, 100, 100 },
                    { 123, 55, 115, 114, "Grass", 65, false, "Tangela", 1, null, "", 100, 40, 60 },
                    { 102, 65, 60, 94, "Ghost", 60, false, "Gengar", 1, null, "Poison", 130, 75, 110 },
                    { 103, 65, 80, 94, "Ghost", 60, false, "GengarMega Gengar", 1, null, "Poison", 170, 95, 130 },
                    { 104, 45, 160, 95, "Rock", 35, false, "Onix", 1, null, "Ground", 30, 45, 70 },
                    { 105, 48, 45, 96, "Psychic", 60, false, "Drowzee", 1, null, "", 43, 90, 42 },
                    { 106, 73, 70, 97, "Psychic", 85, false, "Hypno", 1, null, "", 73, 115, 67 },
                    { 107, 105, 90, 98, "Water", 30, false, "Krabby", 1, null, "", 25, 25, 50 },
                    { 108, 130, 115, 99, "Water", 55, false, "Kingler", 1, null, "", 50, 50, 75 },
                    { 109, 30, 50, 100, "Electric", 40, false, "Voltorb", 1, null, "", 55, 55, 100 },
                    { 110, 50, 70, 101, "Electric", 60, false, "Electrode", 1, null, "", 80, 80, 140 },
                    { 111, 40, 80, 102, "Grass", 60, false, "Exeggcute", 1, null, "Psychic", 60, 45, 40 },
                    { 112, 95, 85, 103, "Grass", 95, false, "Exeggutor", 1, null, "Psychic", 125, 65, 55 },
                    { 113, 50, 95, 104, "Ground", 50, false, "Cubone", 1, null, "", 40, 50, 35 },
                    { 114, 80, 110, 105, "Ground", 60, false, "Marowak", 1, null, "", 50, 80, 45 },
                    { 115, 120, 53, 106, "Fighting", 50, false, "Hitmonlee", 1, null, "", 35, 110, 87 },
                    { 116, 105, 79, 107, "Fighting", 50, false, "Hitmonchan", 1, null, "", 35, 110, 76 },
                    { 117, 55, 75, 108, "Normal", 90, false, "Lickitung", 1, null, "", 60, 75, 30 },
                    { 118, 65, 95, 109, "Poison", 40, false, "Koffing", 1, null, "", 60, 45, 35 },
                    { 119, 90, 120, 110, "Poison", 65, false, "Weezing", 1, null, "", 85, 70, 60 },
                    { 120, 85, 95, 111, "Ground", 80, false, "Rhyhorn", 1, null, "Rock", 30, 30, 25 },
                    { 121, 130, 120, 112, "Ground", 105, false, "Rhydon", 1, null, "Rock", 45, 45, 40 },
                    { 122, 5, 5, 113, "Normal", 250, false, "Chansey", 1, null, "", 35, 105, 50 },
                    { 124, 95, 80, 115, "Normal", 105, false, "Kangaskhan", 1, null, "", 40, 80, 90 },
                    { 101, 50, 45, 93, "Ghost", 45, false, "Haunter", 1, null, "Poison", 115, 55, 95 },
                    { 149, 60, 70, 137, "Normal", 65, false, "Porygon", 1, null, "", 85, 75, 40 },
                    { 151, 60, 125, 139, "Rock", 70, false, "Omastar", 1, null, "Water", 115, 70, 55 },
                    { 177, 76, 64, 162, "Normal", 85, false, "Furret", 2, null, "", 45, 55, 90 },
                    { 178, 30, 30, 163, "Normal", 60, false, "Hoothoot", 2, null, "Flying", 36, 56, 50 },
                    { 179, 50, 50, 164, "Normal", 100, false, "Noctowl", 2, null, "Flying", 76, 96, 70 },
                    { 180, 20, 30, 165, "Bug", 40, false, "Ledyba", 2, null, "Flying", 40, 80, 55 },
                    { 181, 35, 50, 166, "Bug", 55, false, "Ledian", 2, null, "Flying", 55, 110, 85 },
                    { 182, 60, 40, 167, "Bug", 40, false, "Spinarak", 2, null, "Poison", 40, 40, 30 },
                    { 183, 90, 70, 168, "Bug", 70, false, "Ariados", 2, null, "Poison", 60, 60, 40 },
                    { 184, 90, 80, 169, "Poison", 85, false, "Crobat", 2, null, "Flying", 70, 80, 130 },
                    { 185, 38, 38, 170, "Water", 75, false, "Chinchou", 2, null, "Electric", 56, 56, 67 },
                    { 186, 58, 58, 171, "Water", 125, false, "Lanturn", 2, null, "Electric", 76, 76, 67 },
                    { 187, 40, 15, 172, "Electric", 20, false, "Pichu", 2, null, "", 35, 35, 60 },
                    { 188, 25, 28, 173, "Fairy", 50, false, "Cleffa", 2, null, "", 45, 55, 15 },
                    { 189, 30, 15, 174, "Normal", 90, false, "Igglybuff", 2, null, "Fairy", 40, 20, 15 },
                    { 190, 20, 65, 175, "Fairy", 35, false, "Togepi", 2, null, "", 40, 65, 20 },
                    { 191, 40, 85, 176, "Fairy", 55, false, "Togetic", 2, null, "Flying", 80, 105, 40 },
                    { 192, 50, 45, 177, "Psychic", 40, false, "Natu", 2, null, "Flying", 70, 45, 70 },
                    { 193, 75, 70, 178, "Psychic", 65, false, "Xatu", 2, null, "Flying", 95, 70, 95 },
                    { 194, 40, 40, 179, "Electric", 55, false, "Mareep", 2, null, "", 65, 45, 35 },
                    { 195, 55, 55, 180, "Electric", 70, false, "Flaaffy", 2, null, "", 80, 60, 45 },
                    { 196, 75, 85, 181, "Electric", 90, false, "Ampharos", 2, null, "", 115, 90, 55 },
                    { 197, 95, 105, 181, "Electric", 90, false, "AmpharosMega Ampharos", 2, null, "Dragon", 165, 110, 45 },
                    { 176, 46, 34, 161, "Normal", 35, false, "Sentret", 2, null, "", 35, 45, 20 },
                    { 150, 40, 100, 138, "Rock", 35, false, "Omanyte", 1, null, "Water", 90, 55, 35 },
                    { 175, 105, 100, 160, "Water", 85, false, "Feraligatr", 2, null, "", 79, 83, 78 },
                    { 173, 65, 64, 158, "Water", 50, false, "Totodile", 2, null, "", 44, 48, 43 },
                    { 152, 80, 90, 140, "Rock", 30, false, "Kabuto", 1, null, "Water", 55, 45, 55 },
                    { 153, 115, 105, 141, "Rock", 60, false, "Kabutops", 1, null, "Water", 65, 70, 80 },
                    { 154, 105, 65, 142, "Rock", 80, false, "Aerodactyl", 1, null, "Flying", 60, 75, 130 },
                    { 155, 135, 85, 142, "Rock", 80, false, "AerodactylMega Aerodactyl", 1, null, "Flying", 70, 95, 150 },
                    { 156, 110, 65, 143, "Normal", 160, false, "Snorlax", 1, null, "", 65, 110, 30 },
                    { 157, 85, 100, 144, "Ice", 90, true, "Articuno", 1, null, "Flying", 95, 125, 85 },
                    { 158, 90, 85, 145, "Electric", 90, true, "Zapdos", 1, null, "Flying", 125, 90, 100 },
                    { 159, 100, 90, 146, "Fire", 90, true, "Moltres", 1, null, "Flying", 125, 85, 90 },
                    { 160, 64, 45, 147, "Dragon", 41, false, "Dratini", 1, null, "", 50, 50, 50 },
                    { 161, 84, 65, 148, "Dragon", 61, false, "Dragonair", 1, null, "", 70, 70, 70 },
                    { 162, 134, 95, 149, "Dragon", 91, false, "Dragonite", 1, null, "Flying", 100, 100, 80 },
                    { 163, 110, 90, 150, "Psychic", 106, true, "Mewtwo", 1, null, "", 154, 90, 130 },
                    { 164, 190, 100, 150, "Psychic", 106, true, "MewtwoMega Mewtwo X", 1, null, "Fighting", 154, 100, 130 },
                    { 165, 150, 70, 150, "Psychic", 106, true, "MewtwoMega Mewtwo Y", 1, null, "", 194, 120, 140 },
                    { 166, 100, 100, 151, "Psychic", 100, false, "Mew", 1, null, "", 100, 100, 100 },
                    { 167, 49, 65, 152, "Grass", 45, false, "Chikorita", 2, null, "", 49, 65, 45 },
                    { 168, 62, 80, 153, "Grass", 60, false, "Bayleef", 2, null, "", 63, 80, 60 },
                    { 169, 82, 100, 154, "Grass", 80, false, "Meganium", 2, null, "", 83, 100, 80 },
                    { 170, 52, 43, 155, "Fire", 39, false, "Cyndaquil", 2, null, "", 60, 50, 65 },
                    { 171, 64, 58, 156, "Fire", 58, false, "Quilava", 2, null, "", 80, 65, 80 },
                    { 172, 84, 78, 157, "Fire", 78, false, "Typhlosion", 2, null, "", 109, 85, 100 },
                    { 174, 80, 80, 159, "Water", 65, false, "Croconaw", 2, null, "", 59, 63, 58 },
                    { 198, 80, 95, 182, "Grass", 75, false, "Bellossom", 2, null, "", 90, 100, 50 },
                    { 100, 35, 30, 92, "Ghost", 30, false, "Gastly", 1, null, "Poison", 100, 35, 80 },
                    { 98, 65, 100, 90, "Water", 30, false, "Shellder", 1, null, "", 45, 25, 40 },
                    { 27, 60, 30, 21, "Normal", 40, false, "Spearow", 1, null, "Flying", 31, 31, 70 },
                    { 28, 90, 65, 22, "Normal", 65, false, "Fearow", 1, null, "Flying", 61, 61, 100 },
                    { 29, 60, 44, 23, "Poison", 35, false, "Ekans", 1, null, "", 40, 54, 55 },
                    { 30, 85, 69, 24, "Poison", 60, false, "Arbok", 1, null, "", 65, 79, 80 },
                    { 31, 55, 40, 25, "Electric", 35, false, "Pikachu", 1, null, "", 50, 50, 90 },
                    { 32, 90, 55, 26, "Electric", 60, false, "Raichu", 1, null, "", 90, 80, 110 },
                    { 33, 75, 85, 27, "Ground", 50, false, "Sandshrew", 1, null, "", 20, 30, 40 },
                    { 34, 100, 110, 28, "Ground", 75, false, "Sandslash", 1, null, "", 45, 55, 65 },
                    { 35, 47, 52, 29, "Poison", 55, false, "Nidoran♀", 1, null, "", 40, 40, 41 },
                    { 36, 62, 67, 30, "Poison", 70, false, "Nidorina", 1, null, "", 55, 55, 56 },
                    { 37, 92, 87, 31, "Poison", 90, false, "Nidoqueen", 1, null, "Ground", 75, 85, 76 },
                    { 38, 57, 40, 32, "Poison", 46, false, "Nidoran♂", 1, null, "", 40, 40, 50 },
                    { 39, 72, 57, 33, "Poison", 61, false, "Nidorino", 1, null, "", 55, 55, 65 },
                    { 40, 102, 77, 34, "Poison", 81, false, "Nidoking", 1, null, "Ground", 85, 75, 85 },
                    { 41, 45, 48, 35, "Fairy", 70, false, "Clefairy", 1, null, "", 60, 65, 35 },
                    { 42, 70, 73, 36, "Fairy", 95, false, "Clefable", 1, null, "", 95, 90, 60 },
                    { 43, 41, 40, 37, "Fire", 38, false, "Vulpix", 1, null, "", 50, 65, 65 },
                    { 44, 76, 75, 38, "Fire", 73, false, "Ninetales", 1, null, "", 81, 100, 100 },
                    { 45, 45, 20, 39, "Normal", 115, false, "Jigglypuff", 1, null, "Fairy", 45, 25, 20 },
                    { 46, 70, 45, 40, "Normal", 140, false, "Wigglytuff", 1, null, "Fairy", 85, 50, 45 },
                    { 47, 45, 35, 41, "Poison", 40, false, "Zubat", 1, null, "Flying", 30, 40, 55 },
                    { 26, 81, 60, 20, "Normal", 55, false, "Raticate", 1, null, "", 50, 70, 97 },
                    { 48, 80, 70, 42, "Poison", 75, false, "Golbat", 1, null, "Flying", 65, 75, 90 },
                    { 25, 56, 35, 19, "Normal", 30, false, "Rattata", 1, null, "", 25, 35, 72 },
                    { 23, 80, 75, 18, "Normal", 83, false, "Pidgeot", 1, null, "Flying", 70, 70, 101 },
                    { 2, 62, 63, 2, "Grass", 60, false, "Ivysaur", 1, null, "Poison", 80, 80, 60 },
                    { 3, 82, 83, 3, "Grass", 80, false, "Venusaur", 1, null, "Poison", 100, 100, 80 },
                    { 4, 100, 123, 3, "Grass", 80, false, "VenusaurMega Venusaur", 1, null, "Poison", 122, 120, 80 },
                    { 5, 52, 43, 4, "Fire", 39, false, "Charmander", 1, null, "", 60, 50, 65 },
                    { 6, 64, 58, 5, "Fire", 58, false, "Charmeleon", 1, null, "", 80, 65, 80 },
                    { 7, 84, 78, 6, "Fire", 78, false, "Charizard", 1, null, "Flying", 109, 85, 100 },
                    { 8, 130, 111, 6, "Fire", 78, false, "CharizardMega Charizard X", 1, null, "Dragon", 130, 85, 100 },
                    { 9, 104, 78, 6, "Fire", 78, false, "CharizardMega Charizard Y", 1, null, "Flying", 159, 115, 100 },
                    { 10, 48, 65, 7, "Water", 44, false, "Squirtle", 1, null, "", 50, 64, 43 },
                    { 11, 63, 80, 8, "Water", 59, false, "Wartortle", 1, null, "", 65, 80, 58 },
                    { 12, 83, 100, 9, "Water", 79, false, "Blastoise", 1, null, "", 85, 105, 78 },
                    { 13, 103, 120, 9, "Water", 79, false, "BlastoiseMega Blastoise", 1, null, "", 135, 115, 78 },
                    { 14, 30, 35, 10, "Bug", 45, false, "Caterpie", 1, null, "", 20, 20, 45 },
                    { 15, 20, 55, 11, "Bug", 50, false, "Metapod", 1, null, "", 25, 25, 30 },
                    { 16, 45, 50, 12, "Bug", 60, false, "Butterfree", 1, null, "Flying", 90, 80, 70 },
                    { 17, 35, 30, 13, "Bug", 40, false, "Weedle", 1, null, "Poison", 20, 20, 50 },
                    { 18, 25, 50, 14, "Bug", 45, false, "Kakuna", 1, null, "Poison", 25, 25, 35 },
                    { 19, 90, 40, 15, "Bug", 65, false, "Beedrill", 1, null, "Poison", 45, 80, 75 },
                    { 20, 150, 40, 15, "Bug", 65, false, "BeedrillMega Beedrill", 1, null, "Poison", 15, 80, 145 },
                    { 21, 45, 40, 16, "Normal", 40, false, "Pidgey", 1, null, "Flying", 35, 35, 56 },
                    { 22, 60, 55, 17, "Normal", 63, false, "Pidgeotto", 1, null, "Flying", 50, 50, 71 },
                    { 24, 80, 80, 18, "Normal", 83, false, "PidgeotMega Pidgeot", 1, null, "Flying", 135, 80, 121 },
                    { 99, 95, 180, 91, "Water", 50, false, "Cloyster", 1, null, "Ice", 85, 45, 70 },
                    { 49, 50, 55, 43, "Grass", 45, false, "Oddish", 1, null, "Poison", 75, 65, 30 },
                    { 51, 80, 85, 45, "Grass", 75, false, "Vileplume", 1, null, "Poison", 110, 90, 50 },
                    { 77, 90, 50, 70, "Grass", 65, false, "Weepinbell", 1, null, "Poison", 85, 45, 55 },
                    { 78, 105, 65, 71, "Grass", 80, false, "Victreebel", 1, null, "Poison", 100, 70, 70 },
                    { 79, 40, 35, 72, "Water", 40, false, "Tentacool", 1, null, "Poison", 50, 100, 70 },
                    { 80, 70, 65, 73, "Water", 80, false, "Tentacruel", 1, null, "Poison", 80, 120, 100 },
                    { 81, 80, 100, 74, "Rock", 40, false, "Geodude", 1, null, "Ground", 30, 30, 20 },
                    { 82, 95, 115, 75, "Rock", 55, false, "Graveler", 1, null, "Ground", 45, 45, 35 },
                    { 83, 120, 130, 76, "Rock", 80, false, "Golem", 1, null, "Ground", 55, 65, 45 },
                    { 84, 85, 55, 77, "Fire", 50, false, "Ponyta", 1, null, "", 65, 65, 90 },
                    { 85, 100, 70, 78, "Fire", 65, false, "Rapidash", 1, null, "", 80, 80, 105 },
                    { 86, 65, 65, 79, "Water", 90, false, "Slowpoke", 1, null, "Psychic", 40, 40, 15 },
                    { 87, 75, 110, 80, "Water", 95, false, "Slowbro", 1, null, "Psychic", 100, 80, 30 },
                    { 88, 75, 180, 80, "Water", 95, false, "SlowbroMega Slowbro", 1, null, "Psychic", 130, 80, 30 },
                    { 89, 35, 70, 81, "Electric", 25, false, "Magnemite", 1, null, "Steel", 95, 55, 45 },
                    { 90, 60, 95, 82, "Electric", 50, false, "Magneton", 1, null, "Steel", 120, 70, 70 },
                    { 91, 65, 55, 83, "Normal", 52, false, "Farfetch'd", 1, null, "Flying", 58, 62, 60 },
                    { 92, 85, 45, 84, "Normal", 35, false, "Doduo", 1, null, "Flying", 35, 35, 75 },
                    { 93, 110, 70, 85, "Normal", 60, false, "Dodrio", 1, null, "Flying", 60, 60, 100 },
                    { 94, 45, 55, 86, "Water", 65, false, "Seel", 1, null, "", 45, 70, 45 },
                    { 95, 70, 80, 87, "Water", 90, false, "Dewgong", 1, null, "Ice", 70, 95, 70 },
                    { 96, 80, 50, 88, "Poison", 80, false, "Grimer", 1, null, "", 40, 50, 25 },
                    { 97, 105, 75, 89, "Poison", 105, false, "Muk", 1, null, "", 65, 100, 50 },
                    { 76, 75, 35, 69, "Grass", 50, false, "Bellsprout", 1, null, "Poison", 70, 30, 40 },
                    { 50, 65, 70, 44, "Grass", 60, false, "Gloom", 1, null, "Poison", 85, 75, 40 },
                    { 75, 130, 80, 68, "Fighting", 90, false, "Machamp", 1, null, "", 65, 85, 55 },
                    { 73, 80, 50, 66, "Fighting", 70, false, "Machop", 1, null, "", 35, 35, 35 },
                    { 52, 70, 55, 46, "Bug", 35, false, "Paras", 1, null, "Grass", 45, 55, 25 },
                    { 53, 95, 80, 47, "Bug", 60, false, "Parasect", 1, null, "Grass", 60, 80, 30 },
                    { 54, 55, 50, 48, "Bug", 60, false, "Venonat", 1, null, "Poison", 40, 55, 45 },
                    { 55, 65, 60, 49, "Bug", 70, false, "Venomoth", 1, null, "Poison", 90, 75, 90 },
                    { 56, 55, 25, 50, "Ground", 10, false, "Diglett", 1, null, "", 35, 45, 95 },
                    { 57, 80, 50, 51, "Ground", 35, false, "Dugtrio", 1, null, "", 50, 70, 120 },
                    { 58, 45, 35, 52, "Normal", 40, false, "Meowth", 1, null, "", 40, 40, 90 },
                    { 59, 70, 60, 53, "Normal", 65, false, "Persian", 1, null, "", 65, 65, 115 },
                    { 60, 52, 48, 54, "Water", 50, false, "Psyduck", 1, null, "", 65, 50, 55 },
                    { 61, 82, 78, 55, "Water", 80, false, "Golduck", 1, null, "", 95, 80, 85 },
                    { 62, 80, 35, 56, "Fighting", 40, false, "Mankey", 1, null, "", 35, 45, 70 },
                    { 63, 105, 60, 57, "Fighting", 65, false, "Primeape", 1, null, "", 60, 70, 95 },
                    { 64, 70, 45, 58, "Fire", 55, false, "Growlithe", 1, null, "", 70, 50, 60 },
                    { 65, 110, 80, 59, "Fire", 90, false, "Arcanine", 1, null, "", 100, 80, 95 },
                    { 66, 50, 40, 60, "Water", 40, false, "Poliwag", 1, null, "", 40, 40, 90 },
                    { 67, 65, 65, 61, "Water", 65, false, "Poliwhirl", 1, null, "", 50, 50, 90 },
                    { 68, 95, 95, 62, "Water", 90, false, "Poliwrath", 1, null, "Fighting", 70, 90, 70 },
                    { 69, 20, 15, 63, "Psychic", 25, false, "Abra", 1, null, "", 105, 55, 90 },
                    { 70, 35, 30, 64, "Psychic", 40, false, "Kadabra", 1, null, "", 120, 70, 105 },
                    { 71, 50, 45, 65, "Psychic", 55, false, "Alakazam", 1, null, "", 135, 95, 120 },
                    { 72, 50, 65, 65, "Psychic", 55, false, "AlakazamMega Alakazam", 1, null, "", 175, 95, 150 },
                    { 74, 100, 70, 67, "Fighting", 80, false, "Machoke", 1, null, "", 50, 60, 45 },
                    { 199, 20, 50, 183, "Water", 70, false, "Marill", 2, null, "Fairy", 20, 50, 40 },
                    { 200, 50, 80, 184, "Water", 100, false, "Azumarill", 2, null, "Fairy", 60, 80, 50 },
                    { 201, 100, 115, 185, "Rock", 70, false, "Sudowoodo", 2, null, "", 30, 65, 30 },
                    { 328, 85, 125, 302, "Dark", 50, false, "SableyeMega Sableye", 3, null, "Ghost", 85, 115, 20 },
                    { 329, 85, 85, 303, "Steel", 50, false, "Mawile", 3, null, "Fairy", 55, 55, 50 },
                    { 330, 105, 125, 303, "Steel", 50, false, "MawileMega Mawile", 3, null, "Fairy", 55, 95, 50 },
                    { 331, 70, 100, 304, "Steel", 50, false, "Aron", 3, null, "Rock", 40, 40, 30 },
                    { 332, 90, 140, 305, "Steel", 60, false, "Lairon", 3, null, "Rock", 50, 50, 40 },
                    { 333, 110, 180, 306, "Steel", 70, false, "Aggron", 3, null, "Rock", 60, 60, 50 },
                    { 334, 140, 230, 306, "Steel", 70, false, "AggronMega Aggron", 3, null, "", 60, 80, 50 },
                    { 335, 40, 55, 307, "Fighting", 30, false, "Meditite", 3, null, "Psychic", 40, 55, 60 },
                    { 336, 60, 75, 308, "Fighting", 60, false, "Medicham", 3, null, "Psychic", 60, 75, 80 },
                    { 337, 100, 85, 308, "Fighting", 60, false, "MedichamMega Medicham", 3, null, "Psychic", 80, 85, 100 },
                    { 338, 45, 40, 309, "Electric", 40, false, "Electrike", 3, null, "", 65, 40, 65 },
                    { 339, 75, 60, 310, "Electric", 70, false, "Manectric", 3, null, "", 105, 60, 105 },
                    { 340, 75, 80, 310, "Electric", 70, false, "ManectricMega Manectric", 3, null, "", 135, 80, 135 },
                    { 341, 50, 40, 311, "Electric", 60, false, "Plusle", 3, null, "", 85, 75, 95 },
                    { 342, 40, 50, 312, "Electric", 60, false, "Minun", 3, null, "", 75, 85, 95 },
                    { 343, 73, 55, 313, "Bug", 65, false, "Volbeat", 3, null, "", 47, 75, 85 },
                    { 344, 47, 55, 314, "Bug", 65, false, "Illumise", 3, null, "", 73, 75, 85 },
                    { 345, 60, 45, 315, "Grass", 50, false, "Roselia", 3, null, "Poison", 100, 80, 65 },
                    { 346, 43, 53, 316, "Poison", 70, false, "Gulpin", 3, null, "", 43, 53, 40 },
                    { 347, 73, 83, 317, "Poison", 100, false, "Swalot", 3, null, "", 73, 83, 55 },
                    { 348, 90, 20, 318, "Water", 45, false, "Carvanha", 3, null, "Dark", 65, 20, 65 },
                    { 327, 75, 75, 302, "Dark", 50, false, "Sableye", 3, null, "Ghost", 65, 65, 50 },
                    { 349, 120, 40, 319, "Water", 70, false, "Sharpedo", 3, null, "Dark", 95, 40, 95 },
                    { 326, 65, 65, 301, "Normal", 70, false, "Delcatty", 3, null, "", 55, 55, 70 },
                    { 324, 45, 135, 299, "Rock", 30, false, "Nosepass", 3, null, "", 45, 90, 30 },
                    { 303, 50, 100, 279, "Water", 60, false, "Pelipper", 3, null, "Flying", 85, 70, 65 },
                    { 304, 25, 25, 280, "Psychic", 28, false, "Ralts", 3, null, "Fairy", 45, 35, 40 },
                    { 305, 35, 35, 281, "Psychic", 38, false, "Kirlia", 3, null, "Fairy", 65, 55, 50 },
                    { 306, 65, 65, 282, "Psychic", 68, false, "Gardevoir", 3, null, "Fairy", 125, 115, 80 },
                    { 307, 85, 65, 282, "Psychic", 68, false, "GardevoirMega Gardevoir", 3, null, "Fairy", 165, 135, 100 },
                    { 308, 30, 32, 283, "Bug", 40, false, "Surskit", 3, null, "Water", 50, 52, 65 },
                    { 309, 60, 62, 284, "Bug", 70, false, "Masquerain", 3, null, "Flying", 80, 82, 60 },
                    { 310, 40, 60, 285, "Grass", 60, false, "Shroomish", 3, null, "", 40, 60, 35 },
                    { 311, 130, 80, 286, "Grass", 60, false, "Breloom", 3, null, "Fighting", 60, 60, 70 },
                    { 312, 60, 60, 287, "Normal", 60, false, "Slakoth", 3, null, "", 35, 35, 30 },
                    { 313, 80, 80, 288, "Normal", 80, false, "Vigoroth", 3, null, "", 55, 55, 90 },
                    { 314, 160, 100, 289, "Normal", 150, false, "Slaking", 3, null, "", 95, 65, 100 },
                    { 315, 45, 90, 290, "Bug", 31, false, "Nincada", 3, null, "Ground", 30, 30, 40 },
                    { 316, 90, 45, 291, "Bug", 61, false, "Ninjask", 3, null, "Flying", 50, 50, 160 },
                    { 317, 90, 45, 292, "Bug", 1, false, "Shedinja", 3, null, "Ghost", 30, 30, 40 },
                    { 318, 51, 23, 293, "Normal", 64, false, "Whismur", 3, null, "", 51, 23, 28 },
                    { 319, 71, 43, 294, "Normal", 84, false, "Loudred", 3, null, "", 71, 43, 48 },
                    { 320, 91, 63, 295, "Normal", 104, false, "Exploud", 3, null, "", 91, 73, 68 },
                    { 321, 60, 30, 296, "Fighting", 72, false, "Makuhita", 3, null, "", 20, 30, 25 },
                    { 322, 120, 60, 297, "Fighting", 144, false, "Hariyama", 3, null, "", 40, 60, 50 },
                    { 323, 20, 40, 298, "Normal", 50, false, "Azurill", 3, null, "Fairy", 20, 40, 20 },
                    { 325, 45, 45, 300, "Normal", 50, false, "Skitty", 3, null, "", 35, 35, 50 },
                    { 302, 30, 30, 278, "Water", 40, false, "Wingull", 3, null, "Flying", 55, 30, 85 },
                    { 350, 140, 70, 319, "Water", 70, false, "SharpedoMega Sharpedo", 3, null, "Dark", 110, 65, 105 },
                    { 352, 90, 45, 321, "Water", 170, false, "Wailord", 3, null, "", 90, 45, 60 },
                    { 378, 41, 77, 345, "Rock", 66, false, "Lileep", 3, null, "Grass", 61, 87, 23 },
                    { 379, 81, 97, 346, "Rock", 86, false, "Cradily", 3, null, "Grass", 81, 107, 43 },
                    { 380, 95, 50, 347, "Rock", 45, false, "Anorith", 3, null, "Bug", 40, 50, 75 },
                    { 381, 125, 100, 348, "Rock", 75, false, "Armaldo", 3, null, "Bug", 70, 80, 45 },
                    { 382, 15, 20, 349, "Water", 20, false, "Feebas", 3, null, "", 10, 55, 80 },
                    { 383, 60, 79, 350, "Water", 95, false, "Milotic", 3, null, "", 100, 125, 81 },
                    { 384, 70, 70, 351, "Normal", 70, false, "Castform", 3, null, "", 70, 70, 70 },
                    { 385, 90, 70, 352, "Normal", 60, false, "Kecleon", 3, null, "", 60, 120, 40 },
                    { 386, 75, 35, 353, "Ghost", 44, false, "Shuppet", 3, null, "", 63, 33, 45 },
                    { 387, 115, 65, 354, "Ghost", 64, false, "Banette", 3, null, "", 83, 63, 65 },
                    { 388, 165, 75, 354, "Ghost", 64, false, "BanetteMega Banette", 3, null, "", 93, 83, 75 },
                    { 389, 40, 90, 355, "Ghost", 20, false, "Duskull", 3, null, "", 30, 90, 25 },
                    { 390, 70, 130, 356, "Ghost", 40, false, "Dusclops", 3, null, "", 60, 130, 25 },
                    { 391, 68, 83, 357, "Grass", 99, false, "Tropius", 3, null, "Flying", 72, 87, 51 },
                    { 392, 50, 70, 358, "Psychic", 65, false, "Chimecho", 3, null, "", 95, 80, 65 },
                    { 393, 130, 60, 359, "Dark", 65, false, "Absol", 3, null, "", 75, 60, 75 },
                    { 394, 150, 60, 359, "Dark", 65, false, "AbsolMega Absol", 3, null, "", 115, 60, 115 },
                    { 395, 23, 48, 360, "Psychic", 95, false, "Wynaut", 3, null, "", 23, 48, 23 },
                    { 396, 50, 50, 361, "Ice", 50, false, "Snorunt", 3, null, "", 50, 50, 50 },
                    { 397, 80, 80, 362, "Ice", 80, false, "Glalie", 3, null, "", 80, 80, 80 },
                    { 398, 120, 80, 362, "Ice", 80, false, "GlalieMega Glalie", 3, null, "", 120, 80, 100 },
                    { 377, 70, 105, 344, "Ground", 60, false, "Claydol", 3, null, "Psychic", 70, 120, 75 },
                    { 351, 70, 35, 320, "Water", 130, false, "Wailmer", 3, null, "", 70, 35, 60 },
                    { 376, 40, 55, 343, "Ground", 40, false, "Baltoy", 3, null, "Psychic", 40, 70, 55 },
                    { 374, 80, 65, 341, "Water", 43, false, "Corphish", 3, null, "", 50, 35, 35 },
                    { 353, 60, 40, 322, "Fire", 60, false, "Numel", 3, null, "Ground", 65, 45, 35 },
                    { 354, 100, 70, 323, "Fire", 70, false, "Camerupt", 3, null, "Ground", 105, 75, 40 },
                    { 355, 120, 100, 323, "Fire", 70, false, "CameruptMega Camerupt", 3, null, "Ground", 145, 105, 20 },
                    { 356, 85, 140, 324, "Fire", 70, false, "Torkoal", 3, null, "", 85, 70, 20 },
                    { 357, 25, 35, 325, "Psychic", 60, false, "Spoink", 3, null, "", 70, 80, 60 },
                    { 358, 45, 65, 326, "Psychic", 80, false, "Grumpig", 3, null, "", 90, 110, 80 },
                    { 359, 60, 60, 327, "Normal", 60, false, "Spinda", 3, null, "", 60, 60, 60 },
                    { 360, 100, 45, 328, "Ground", 45, false, "Trapinch", 3, null, "", 45, 45, 10 },
                    { 361, 70, 50, 329, "Ground", 50, false, "Vibrava", 3, null, "Dragon", 50, 50, 70 },
                    { 362, 100, 80, 330, "Ground", 80, false, "Flygon", 3, null, "Dragon", 80, 80, 100 },
                    { 363, 85, 40, 331, "Grass", 50, false, "Cacnea", 3, null, "", 85, 40, 35 },
                    { 364, 115, 60, 332, "Grass", 70, false, "Cacturne", 3, null, "Dark", 115, 60, 55 },
                    { 365, 40, 60, 333, "Normal", 45, false, "Swablu", 3, null, "Flying", 40, 75, 50 },
                    { 366, 70, 90, 334, "Dragon", 75, false, "Altaria", 3, null, "Flying", 70, 105, 80 },
                    { 367, 110, 110, 334, "Dragon", 75, false, "AltariaMega Altaria", 3, null, "Fairy", 110, 105, 80 },
                    { 368, 115, 60, 335, "Normal", 73, false, "Zangoose", 3, null, "", 60, 60, 90 },
                    { 369, 100, 60, 336, "Poison", 73, false, "Seviper", 3, null, "", 100, 60, 65 },
                    { 370, 55, 65, 337, "Rock", 70, false, "Lunatone", 3, null, "Psychic", 95, 85, 70 },
                    { 371, 95, 85, 338, "Rock", 70, false, "Solrock", 3, null, "Psychic", 55, 65, 70 },
                    { 372, 48, 43, 339, "Water", 50, false, "Barboach", 3, null, "Ground", 46, 41, 60 },
                    { 373, 78, 73, 340, "Water", 110, false, "Whiscash", 3, null, "Ground", 76, 71, 60 },
                    { 375, 120, 85, 342, "Water", 63, false, "Crawdaunt", 3, null, "Dark", 90, 55, 55 },
                    { 301, 85, 60, 277, "Normal", 60, false, "Swellow", 3, null, "Flying", 50, 50, 125 },
                    { 300, 55, 30, 276, "Normal", 40, false, "Taillow", 3, null, "Flying", 30, 30, 85 },
                    { 299, 100, 60, 275, "Grass", 90, false, "Shiftry", 3, null, "Dark", 90, 60, 80 },
                    { 227, 120, 75, 210, "Fairy", 90, false, "Granbull", 2, null, "", 60, 60, 45 },
                    { 228, 95, 75, 211, "Water", 65, false, "Qwilfish", 2, null, "Poison", 55, 55, 85 },
                    { 229, 130, 100, 212, "Bug", 70, false, "Scizor", 2, null, "Steel", 55, 80, 65 },
                    { 230, 150, 140, 212, "Bug", 70, false, "ScizorMega Scizor", 2, null, "Steel", 65, 100, 75 },
                    { 231, 10, 230, 213, "Bug", 20, false, "Shuckle", 2, null, "Rock", 10, 230, 5 },
                    { 232, 125, 75, 214, "Bug", 80, false, "Heracross", 2, null, "Fighting", 40, 95, 85 },
                    { 233, 185, 115, 214, "Bug", 80, false, "HeracrossMega Heracross", 2, null, "Fighting", 40, 105, 75 },
                    { 234, 95, 55, 215, "Dark", 55, false, "Sneasel", 2, null, "Ice", 35, 75, 115 },
                    { 235, 80, 50, 216, "Normal", 60, false, "Teddiursa", 2, null, "", 50, 50, 40 },
                    { 236, 130, 75, 217, "Normal", 90, false, "Ursaring", 2, null, "", 75, 75, 55 },
                    { 237, 40, 40, 218, "Fire", 40, false, "Slugma", 2, null, "", 70, 40, 20 },
                    { 238, 50, 120, 219, "Fire", 50, false, "Magcargo", 2, null, "Rock", 80, 80, 30 },
                    { 239, 50, 40, 220, "Ice", 50, false, "Swinub", 2, null, "Ground", 30, 30, 50 },
                    { 240, 100, 80, 221, "Ice", 100, false, "Piloswine", 2, null, "Ground", 60, 60, 50 },
                    { 241, 55, 85, 222, "Water", 55, false, "Corsola", 2, null, "Rock", 65, 85, 35 },
                    { 242, 65, 35, 223, "Water", 35, false, "Remoraid", 2, null, "", 65, 35, 65 },
                    { 243, 105, 75, 224, "Water", 75, false, "Octillery", 2, null, "", 105, 75, 45 },
                    { 244, 55, 45, 225, "Ice", 45, false, "Delibird", 2, null, "Flying", 65, 45, 75 },
                    { 245, 40, 70, 226, "Water", 65, false, "Mantine", 2, null, "Flying", 80, 140, 70 },
                    { 246, 80, 140, 227, "Steel", 65, false, "Skarmory", 2, null, "Flying", 40, 70, 70 },
                    { 247, 60, 30, 228, "Dark", 45, false, "Houndour", 2, null, "Fire", 80, 50, 65 },
                    { 226, 80, 50, 209, "Fairy", 60, false, "Snubbull", 2, null, "", 40, 40, 30 },
                    { 248, 90, 50, 229, "Dark", 75, false, "Houndoom", 2, null, "Fire", 110, 80, 95 },
                    { 225, 125, 230, 208, "Steel", 75, false, "SteelixMega Steelix", 2, null, "Ground", 55, 95, 30 },
                    { 223, 75, 105, 207, "Ground", 65, false, "Gligar", 2, null, "Flying", 35, 65, 85 },
                    { 202, 75, 75, 186, "Water", 90, false, "Politoed", 2, null, "", 90, 100, 70 },
                    { 203, 35, 40, 187, "Grass", 35, false, "Hoppip", 2, null, "Flying", 35, 55, 50 },
                    { 204, 45, 50, 188, "Grass", 55, false, "Skiploom", 2, null, "Flying", 45, 65, 80 },
                    { 205, 55, 70, 189, "Grass", 75, false, "Jumpluff", 2, null, "Flying", 55, 95, 110 },
                    { 206, 70, 55, 190, "Normal", 55, false, "Aipom", 2, null, "", 40, 55, 85 },
                    { 207, 30, 30, 191, "Grass", 30, false, "Sunkern", 2, null, "", 30, 30, 30 },
                    { 208, 75, 55, 192, "Grass", 75, false, "Sunflora", 2, null, "", 105, 85, 30 },
                    { 209, 65, 45, 193, "Bug", 65, false, "Yanma", 2, null, "Flying", 75, 45, 95 },
                    { 210, 45, 45, 194, "Water", 55, false, "Wooper", 2, null, "Ground", 25, 25, 15 },
                    { 211, 85, 85, 195, "Water", 95, false, "Quagsire", 2, null, "Ground", 65, 65, 35 },
                    { 212, 65, 60, 196, "Psychic", 65, false, "Espeon", 2, null, "", 130, 95, 110 },
                    { 213, 65, 110, 197, "Dark", 95, false, "Umbreon", 2, null, "", 60, 130, 65 },
                    { 214, 85, 42, 198, "Dark", 60, false, "Murkrow", 2, null, "Flying", 85, 42, 91 },
                    { 215, 75, 80, 199, "Water", 95, false, "Slowking", 2, null, "Psychic", 100, 110, 30 },
                    { 216, 60, 60, 200, "Ghost", 60, false, "Misdreavus", 2, null, "", 85, 85, 85 },
                    { 217, 72, 48, 201, "Psychic", 48, false, "Unown", 2, null, "", 72, 48, 48 },
                    { 218, 33, 58, 202, "Psychic", 190, false, "Wobbuffet", 2, null, "", 33, 58, 33 },
                    { 219, 80, 65, 203, "Normal", 70, false, "Girafarig", 2, null, "Psychic", 90, 65, 85 },
                    { 220, 65, 90, 204, "Bug", 50, false, "Pineco", 2, null, "", 35, 35, 15 },
                    { 221, 90, 140, 205, "Bug", 75, false, "Forretress", 2, null, "Steel", 60, 60, 40 },
                    { 222, 70, 70, 206, "Normal", 100, false, "Dunsparce", 2, null, "", 65, 65, 45 },
                    { 224, 85, 200, 208, "Steel", 75, false, "Steelix", 2, null, "Ground", 55, 65, 30 },
                    { 249, 90, 90, 229, "Dark", 75, false, "HoundoomMega Houndoom", 2, null, "Fire", 140, 90, 115 },
                    { 250, 95, 95, 230, "Water", 75, false, "Kingdra", 2, null, "Dragon", 95, 95, 85 },
                    { 251, 60, 60, 231, "Ground", 90, false, "Phanpy", 2, null, "", 40, 40, 40 },
                    { 278, 85, 60, 256, "Fire", 60, false, "Combusken", 3, null, "Fighting", 85, 60, 55 },
                    { 279, 120, 70, 257, "Fire", 80, false, "Blaziken", 3, null, "Fighting", 110, 70, 80 },
                    { 280, 160, 80, 257, "Fire", 80, false, "BlazikenMega Blaziken", 3, null, "Fighting", 130, 80, 100 },
                    { 281, 70, 50, 258, "Water", 50, false, "Mudkip", 3, null, "", 50, 50, 40 },
                    { 282, 85, 70, 259, "Water", 70, false, "Marshtomp", 3, null, "Ground", 60, 70, 50 },
                    { 283, 110, 90, 260, "Water", 100, false, "Swampert", 3, null, "Ground", 85, 90, 60 },
                    { 284, 150, 110, 260, "Water", 100, false, "SwampertMega Swampert", 3, null, "Ground", 95, 110, 70 },
                    { 285, 55, 35, 261, "Dark", 35, false, "Poochyena", 3, null, "", 30, 30, 35 },
                    { 286, 90, 70, 262, "Dark", 70, false, "Mightyena", 3, null, "", 60, 60, 70 },
                    { 287, 30, 41, 263, "Normal", 38, false, "Zigzagoon", 3, null, "", 30, 41, 60 },
                    { 288, 70, 61, 264, "Normal", 78, false, "Linoone", 3, null, "", 50, 61, 100 },
                    { 289, 45, 35, 265, "Bug", 45, false, "Wurmple", 3, null, "", 20, 30, 20 },
                    { 290, 35, 55, 266, "Bug", 50, false, "Silcoon", 3, null, "", 25, 25, 15 },
                    { 291, 70, 50, 267, "Bug", 60, false, "Beautifly", 3, null, "Flying", 100, 50, 65 },
                    { 292, 35, 55, 268, "Bug", 50, false, "Cascoon", 3, null, "", 25, 25, 15 },
                    { 293, 50, 70, 269, "Bug", 60, false, "Dustox", 3, null, "Poison", 50, 90, 65 },
                    { 294, 30, 30, 270, "Water", 40, false, "Lotad", 3, null, "Grass", 40, 50, 30 },
                    { 295, 50, 50, 271, "Water", 60, false, "Lombre", 3, null, "Grass", 60, 70, 50 },
                    { 296, 70, 70, 272, "Water", 80, false, "Ludicolo", 3, null, "Grass", 90, 100, 70 },
                    { 297, 40, 50, 273, "Grass", 40, false, "Seedot", 3, null, "", 30, 30, 30 },
                    { 298, 70, 40, 274, "Grass", 70, false, "Nuzleaf", 3, null, "Dark", 60, 40, 60 },
                    { 277, 60, 40, 255, "Fire", 45, false, "Torchic", 3, null, "", 70, 50, 45 },
                    { 276, 110, 75, 254, "Grass", 70, false, "SceptileMega Sceptile", 3, null, "Dragon", 145, 85, 145 },
                    { 275, 85, 65, 254, "Grass", 70, false, "Sceptile", 3, null, "", 105, 85, 120 },
                    { 274, 65, 45, 253, "Grass", 50, false, "Grovyle", 3, null, "", 85, 65, 95 },
                    { 252, 120, 120, 232, "Ground", 90, false, "Donphan", 2, null, "", 60, 60, 50 },
                    { 253, 80, 90, 233, "Normal", 85, false, "Porygon2", 2, null, "", 105, 95, 60 },
                    { 254, 95, 62, 234, "Normal", 73, false, "Stantler", 2, null, "", 85, 65, 85 },
                    { 255, 20, 35, 235, "Normal", 55, false, "Smeargle", 2, null, "", 20, 45, 75 },
                    { 256, 35, 35, 236, "Fighting", 35, false, "Tyrogue", 2, null, "", 35, 35, 35 },
                    { 257, 95, 95, 237, "Fighting", 50, false, "Hitmontop", 2, null, "", 35, 110, 70 },
                    { 258, 30, 15, 238, "Ice", 45, false, "Smoochum", 2, null, "Psychic", 85, 65, 65 },
                    { 259, 63, 37, 239, "Electric", 45, false, "Elekid", 2, null, "", 65, 55, 95 },
                    { 260, 75, 37, 240, "Fire", 45, false, "Magby", 2, null, "", 70, 55, 83 },
                    { 261, 80, 105, 241, "Normal", 95, false, "Miltank", 2, null, "", 40, 70, 100 },
                    { 799, 160, 60, 720, "Psychic", 80, true, "HoopaHoopa Unbound", 6, null, "Dark", 170, 130, 80 },
                    { 262, 10, 10, 242, "Normal", 255, false, "Blissey", 2, null, "", 75, 135, 55 },
                    { 264, 115, 85, 244, "Fire", 115, true, "Entei", 2, null, "", 90, 75, 100 },
                    { 265, 75, 115, 245, "Water", 100, true, "Suicune", 2, null, "", 90, 115, 85 },
                    { 266, 64, 50, 246, "Rock", 50, false, "Larvitar", 2, null, "Ground", 45, 50, 41 },
                    { 267, 84, 70, 247, "Rock", 70, false, "Pupitar", 2, null, "Ground", 65, 70, 51 },
                    { 268, 134, 110, 248, "Rock", 100, false, "Tyranitar", 2, null, "Dark", 95, 100, 61 },
                    { 269, 164, 150, 248, "Rock", 100, false, "TyranitarMega Tyranitar", 2, null, "Dark", 95, 120, 71 },
                    { 270, 90, 130, 249, "Psychic", 106, true, "Lugia", 2, null, "Flying", 90, 154, 110 },
                    { 271, 130, 90, 250, "Fire", 106, true, "Ho-oh", 2, null, "Flying", 110, 154, 90 },
                    { 272, 100, 100, 251, "Psychic", 100, false, "Celebi", 2, null, "Grass", 100, 100, 100 },
                    { 273, 45, 35, 252, "Grass", 40, false, "Treecko", 3, null, "", 65, 55, 70 },
                    { 263, 85, 75, 243, "Electric", 90, true, "Raikou", 2, null, "", 115, 100, 115 },
                    { 800, 110, 120, 721, "Fire", 80, true, "Volcanion", 6, null, "Water", 130, 90, 70 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemon_Pokedexes_PokedexId",
                table: "Pokemon",
                column: "PokedexId",
                principalTable: "Pokedexes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_Pokedexes_PokedexId",
                table: "Pokemon");

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "Pokemon",
                keyColumn: "Id",
                keyValue: 800);

            migrationBuilder.DropColumn(
                name: "FirstType",
                table: "Pokemon");

            migrationBuilder.DropColumn(
                name: "SecondType",
                table: "Pokemon");

            migrationBuilder.RenameColumn(
                name: "EntryNumber",
                table: "Pokemon",
                newName: "PokedexNumber");

            migrationBuilder.AlterColumn<int>(
                name: "PokedexId",
                table: "Pokemon",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "FirstTypeId",
                table: "Pokemon",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SecondTypeId",
                table: "Pokemon",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_FirstTypeId",
                table: "Pokemon",
                column: "FirstTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_SecondTypeId",
                table: "Pokemon",
                column: "SecondTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemon_PokeType_FirstTypeId",
                table: "Pokemon",
                column: "FirstTypeId",
                principalTable: "PokeType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemon_Pokedexes_PokedexId",
                table: "Pokemon",
                column: "PokedexId",
                principalTable: "Pokedexes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemon_PokeType_SecondTypeId",
                table: "Pokemon",
                column: "SecondTypeId",
                principalTable: "PokeType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

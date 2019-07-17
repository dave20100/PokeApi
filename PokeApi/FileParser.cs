using CsvHelper;
using PokeApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PokeApi
{
    public static class FileParser
    {
        public static List<Pokemon> ParsePokemon()
        {
            List<Pokemon> pokemons = new List<Pokemon>();

            using(StreamReader streamreader = new StreamReader("Poke.txt"))
            {
                string line;
                streamreader.ReadLine();
                while((line = streamreader.ReadLine()) != null)
                {
                    try
                    {
                        List<string> pokemonCharacteristics = line.Split(',').ToList<string>();

                        Pokemon pokemon = new Pokemon()
                        {
                            EntryNumber = Int32.Parse(pokemonCharacteristics[0]),
                            Name = pokemonCharacteristics[1],
                            FirstType = pokemonCharacteristics[2],
                            SecondType = pokemonCharacteristics[3],
                            Hp = Int32.Parse(pokemonCharacteristics[5]),
                            Attack = Int32.Parse(pokemonCharacteristics[6]),
                            Defense = Int32.Parse(pokemonCharacteristics[7]),
                            Sp_Atk = Int32.Parse(pokemonCharacteristics[8]),
                            Sp_Def = Int32.Parse(pokemonCharacteristics[9]),
                            Speed = Int32.Parse(pokemonCharacteristics[10]),
                            PokedexId = Int32.Parse(pokemonCharacteristics[11]),
                            Is_Legendary = Boolean.Parse(pokemonCharacteristics[12]),
                            Id = Int32.Parse(pokemonCharacteristics[13])
                        };
                        pokemons.Add(pokemon);
                    }
                    catch {
                        Console.WriteLine("blad");
                    }
                }
                
            }
            return pokemons;
        }
    }
}

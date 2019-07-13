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

            using(StreamReader reader = new StreamReader("Poke.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            return pokemons;
        }
    }
}

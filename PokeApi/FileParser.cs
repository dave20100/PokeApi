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

            using(StreamReader streamreader = new StreamReader("Poke.csv"))
            {
                var reader = new CsvReader(streamreader);

                
            }
            return pokemons;
        }
    }
}

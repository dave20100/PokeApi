using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokeApi.Models
{
    public class Pokedex
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Pokemon> Pokemons { get; set; }

        public Pokedex()
        {
            Pokemons = new List<Pokemon>();
        }
    }
}

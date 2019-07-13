using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokeApi.Models
{
    public class PokedexContext : DbContext
    {
        public PokedexContext(DbContextOptions<PokedexContext> options) : base(options){}

        public DbSet<Pokedex> Pokedexes { get; set; }
    }
}

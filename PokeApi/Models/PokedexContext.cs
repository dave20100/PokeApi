using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokeApi.Models
{
    public class PokedexContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder builder) 
        {
            foreach(Pokedex pkdx in new List<Pokedex>(){ new Pokedex() { Id = 1, Name = "Kanto"}, new Pokedex() { Id = 2, Name = "Johto" },
            new Pokedex() { Id = 3, Name = "Hoenn" }, new Pokedex() { Id = 4, Name = "Sinnoh" }, new Pokedex() { Id = 5, Name = "Unova" }, new Pokedex() { Id = 6, Name = "Kalos" } })
            {
                builder.Entity<Pokedex>().HasData(pkdx);
            }
            foreach (Pokemon poke in FileParser.ParsePokemon().OrderBy(pk => pk.EntryNumber))
            {
                poke.ImagePath = poke.EntryNumber + ".png";
                builder.Entity<Pokemon>().HasData(poke);
            }
        }
        public PokedexContext(DbContextOptions<PokedexContext> options) : base(options){}

        public DbSet<Pokedex> Pokedexes { get; set; }
        public DbSet<Pokemon> Pokemons { get; set; }
    }
}

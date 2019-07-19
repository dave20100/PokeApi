using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokeApi.Models;

namespace PokeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokedexController : ControllerBase
    {
        private readonly PokedexContext pokedexContext;

        public PokedexController(PokedexContext ctx) {
            pokedexContext = ctx;
        }

        [HttpGet("Pokedexes")]
        public JsonResult Show()
        {
            return new JsonResult(pokedexContext.Pokedexes);
        }
        [HttpGet("Pokemons/{pokedexnr?}")]
        public JsonResult ShowPokemons(int pokedexnr)
        {
            List<Pokemon> pokemons;
            if (pokedexnr == 0)
            {
                pokemons = pokedexContext.Pokemons.OrderBy(pk => pk.EntryNumber).ToList<Pokemon>();
            }
            else
            {
                pokemons = (pokedexContext.Pokemons.Where(pk => pk.PokedexId == pokedexnr).OrderBy(pk => pk.EntryNumber).ToList<Pokemon>());
            }
            return new JsonResult(pokemons.Select(pk => new { pk.Id, pk.Name, pk.FirstType, pk.SecondType}));
        }
        [HttpGet("Pokemons/{pokedexnr}/{pokemonnr}")]
        public JsonResult ShowDetailedInfo(int pokedexnr, int pokemonnr)
        {
            Pokemon selected = pokedexContext.Pokemons.FirstOrDefault(poke => poke.PokedexId == pokedexnr && poke.Id == pokemonnr);
            return new JsonResult(selected);
        }
        

    }
}
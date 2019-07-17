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
            if(pokedexnr == 0)
            {
                return new JsonResult(pokedexContext.Pokemons.OrderBy(pk => pk.EntryNumber ).Select(pk => new { pk.Name, pk.FirstType, pk.SecondType}));
            }
            return new JsonResult(pokedexContext.Pokemons.Where(pk => pk.PokedexId == pokedexnr).OrderBy(pk => pk.EntryNumber).Select(pk => new { pk.Name, pk.FirstType, pk.SecondType }));
        }
        
    }
}
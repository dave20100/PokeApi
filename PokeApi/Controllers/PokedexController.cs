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

        [HttpGet]
        public JsonResult Show()
        {
            
            return new JsonResult(pokedexContext.Pokedexes.FirstOrDefault(pkx => pkx.Id == 1).Pokemons);
        }
        [HttpPost]
        public ActionResult AddPokedex([FromBody]Pokedex pokedex)
        {
            pokedexContext.Add(pokedex);
            pokedexContext.SaveChanges();
            return Ok();
        }
        
        [HttpPost("AddPokemon/{pokedexName}")]
        public ActionResult AddPokemon(string pokedexName, [FromBody]Pokemon pokemon)
        {
            pokedexContext.Pokedexes.First(pkdx => pkdx.Name == pokedexName).Pokemons.Add(pokemon);
            pokedexContext.SaveChanges();
            return Ok();
        }
    }
}
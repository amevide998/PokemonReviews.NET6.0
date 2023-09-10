using System;
using Microsoft.AspNetCore.Mvc;
using PokemonReviews.Interfaces;
using PokemonReviews.Models;

namespace PokemonReviews.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class PokemonController: Controller
    {
        private readonly IPokemonRepository _pokemonRepository;

        public PokemonController(IPokemonRepository pokemonRepository)
        {
            _pokemonRepository = pokemonRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Pokemon>))]
        public IActionResult GetPokemons()
        {
            var pokemons = _pokemonRepository.GetPokemons();

            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(pokemons);
            
        }
    }
}
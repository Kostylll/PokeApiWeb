using Microsoft.AspNetCore.Mvc;
using PokeApi.Application.Abstraction.Domain.Request;
using PokeApi.Application.Interface;

namespace PokeAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PokeController : Controller
    {
        private readonly IPokemonService _pokeService;

        public PokeController(IPokemonService pokeService)
        {
            _pokeService = pokeService;
        }

        [HttpGet("name")]
        public async Task<IActionResult> GetPokemonByName(string Name)
        {
            var result = await _pokeService.ExibirPokemonByName(Name);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetPokemon()
        {
            var result = await _pokeService.ExibirPokemon();
            return Ok(result);
        }


        [HttpPost]

        public async Task<IActionResult> PostPokemon(string Name)
        {
            var result = await _pokeService.AdicionarPokemon(Name);
            return Ok(result);
        }

    }
}

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

        [HttpGet]
        public async Task<IActionResult> GetPokemon(string Name)
        {
            var result = await _pokeService.ExibirPokemon(Name);
            return Ok(result);
        }
    }
}

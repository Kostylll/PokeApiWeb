using Microsoft.AspNetCore.Mvc;
using PokeApi.Application.Abstraction.Domain.Request;
using PokeApi.Application.Interface;

namespace PokeAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlayerController : Controller
    {
        private readonly IPlayerService _playerService;

        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        [HttpPost]
        public async Task<IActionResult> AddPlayer(PlayerDTORequest request)
        {
           var result = await _playerService.AddPlayer(request);
          return Ok(result);
        }


        [HttpGet]

        public async Task<IActionResult> GetPlayer()
        {
            var result = await _playerService.GetPlayer();
            return Ok(result);
        }

    }
}

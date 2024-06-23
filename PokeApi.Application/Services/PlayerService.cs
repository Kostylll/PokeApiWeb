using PokeApi.Application.Abstraction.Domain.DTO;
using PokeApi.Application.Abstraction.Domain.Request;
using PokeApi.Application.Infra.Data.Repository;
using PokeApi.Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeApi.Application.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerDTORepository _respository;

        public PlayerService(IPlayerDTORepository respository)
        {
            _respository = respository;
        }



        public async Task<bool> AddPlayer(PlayerDTORequest request)
        {
            try
            {
                var player = new PlayerDTO()
                {
                    nome = request.nome,
                    vida = request.vida,
                    status = request.status,
                    energia = request.energia,
                };

              await  _respository.AddAsync(player);
              await _respository.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
                return true;
        }

        public async Task<List<PlayerDTORequest>> GetPlayer()
        {
            var playerViewModelList = new List<PlayerDTORequest>();
            var players = await _respository.GetAllAsync();

            foreach ( var player in players )
            {
                var playerViewModel = new PlayerDTORequest();

                playerViewModel.nome = player.nome;
                playerViewModel.vida = player.vida;
                playerViewModel.status = player.status;
                playerViewModel.energia = player.energia;

                playerViewModelList.Add(playerViewModel);




            }
            return playerViewModelList;
        }
    }
}

using PokeApi.Application.Abstraction.Domain.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeApi.Application.Interface
{
    public interface IPlayerService
    {
        Task<bool> AddPlayer(PlayerDTORequest request);

        Task<List<PlayerDTORequest>> GetPlayer();
    }
}

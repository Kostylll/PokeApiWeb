using PokeApi.Application.Abstraction.Domain.Request;
using PokeApi.Application.Abstraction.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeApi.Application.Interface
{
    public interface IPokemonService
    {
        Task<PokeDTOResponse> ExibirPokemon(string Name);

    }
}

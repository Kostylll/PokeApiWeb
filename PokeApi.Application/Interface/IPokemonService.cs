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
        Task<PokeDTOResponse> ExibirPokemonByName(string Name);

        Task<List<PokeDTORequest>> ExibirPokemon();

        Task<bool> AdicionarPokemon(string Name);

    }
}

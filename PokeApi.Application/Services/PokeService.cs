using Newtonsoft.Json;
using PokeApi.Application.Abstraction.Domain.Request;
using PokeApi.Application.Abstraction.Domain.Response;
using PokeApi.Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeApi.Application.Services
{
    public class PokeService : IPokemonService
    {
        public async Task<PokeDTOResponse> ExibirPokemon(string Name)
        {
            var lowerName = Name.ToLower();
            HttpClient client = new HttpClient();
            var response = await client.GetAsync("https://pokeapi.co/api/v2/pokemon/" + lowerName );
            var jsonValue = await response.Content.ReadAsStringAsync();
            var jsonObject = JsonConvert.DeserializeObject<PokeDTOResponse>(jsonValue);

            var viewModel = new PokeDTOResponse
            {
                Name = lowerName,
                Id = jsonObject.Id,
                base_experience = jsonObject.base_experience,
            };

            return viewModel;


        
        }
    }
}

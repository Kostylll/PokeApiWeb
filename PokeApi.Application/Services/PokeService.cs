using Newtonsoft.Json;
using PokeApi.Application.Abstraction.Domain.DTO;
using PokeApi.Application.Abstraction.Domain.Request;
using PokeApi.Application.Abstraction.Domain.Response;
using PokeApi.Application.Infra.Data.Repository;
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
        private readonly IPokeDTORepository _dtoRepository;

        public PokeService(IPokeDTORepository dtoRepository)
        {
            _dtoRepository = dtoRepository;
        }

        public async Task<bool> AdicionarPokemon(string Name)
        {
            var lowerName = Name.ToLower();
            HttpClient client = new HttpClient();
            var response = await client.GetAsync("https://pokeapi.co/api/v2/pokemon/" + lowerName);
            var jsonValue = await response.Content.ReadAsStringAsync();
            var jsonObject = JsonConvert.DeserializeObject<PokeDTO>(jsonValue);


            if (jsonValue != null)
            {
                var value = new PokeDTO
                {
                    Name = lowerName,
                    order = jsonObject.order,
                    weight = jsonObject.weight,

                };
                await _dtoRepository.AddAsync(value);
                await _dtoRepository.SaveChangesAsync();

                return true;

            }
                return false;
        }

        public async Task<List<PokeDTORequest>> ExibirPokemon()
        {
            var pokemonList = new List<PokeDTORequest>();
            var pokemon = await _dtoRepository.GetAllAsync();

            foreach(var pokemons in pokemon)
            {
                var pokemonViewModel = new PokeDTORequest();

                pokemonViewModel.Name = pokemons.Name;
                pokemonViewModel.order = pokemons.order;
                pokemonViewModel.weight = pokemons.weight;

                pokemonList.Add(pokemonViewModel);

            }
            return pokemonList;
        }

        public async Task<PokeDTOResponse> ExibirPokemonByName(string Name)
        {
            var lowerName = Name.ToLower();
            HttpClient client = new HttpClient();
            var response = await client.GetAsync("https://pokeapi.co/api/v2/pokemon/" + lowerName );
            var jsonValue = await response.Content.ReadAsStringAsync();
            var jsonObject = JsonConvert.DeserializeObject<PokeDTOResponse>(jsonValue);

            var viewModel = new PokeDTOResponse
            {
                Name = lowerName,
                order = jsonObject.order,
                weight = jsonObject.weight,

            };


            
            return viewModel;


        
        }
    }
}

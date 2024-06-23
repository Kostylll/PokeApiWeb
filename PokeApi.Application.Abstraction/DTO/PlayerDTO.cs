using PokeAPI.Application.Abstraction.Domain;

namespace PokeApi.Application.Abstraction.Domain.DTO
{
    public class PlayerDTO : Entity
    {
        public string nome  { get; set; }
        public int vida { get; set; } 
        public string status { get; set; }
        public int energia { get; set; } 




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeApi.Application.Abstraction.Domain.Request
{
    public class PokeDTORequest
    {
        public string Name { get; set; }
        public string order { get; set; }
        public string weight { get; set; }
    }
}


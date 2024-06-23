using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeApi.Application.Abstraction.Domain.Request
{
    public class PlayerDTORequest
    {
        public string nome { get; set; }
        public int vida { get; set; }
        public string status { get; set; }
        public int energia { get; set; } 



    }
}

using PokeAPI.Application.Abstraction.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeApi.Application.Abstraction.Domain.DTO
{
    public class PokeDTO : Entity
    {
        public string Name { get; set; }
       
    }
}
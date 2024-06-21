using PokeApi.Application.Abstraction.Domain.DTO;
using PokeApi.Application.Abstraction.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeApi.Application.Infra.Data.Repository
{
    public interface IPokeDTORepository : IRepository<PokeDTO>
    {
    }
}

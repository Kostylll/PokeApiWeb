﻿using Microsoft.EntityFrameworkCore;
using PokeApi.Application.Abstraction.Domain;
using PokeApi.Application.Abstraction.Domain.DTO;
using PokeApi.Application.Infra.Data.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeApi.Application.Infra.Data.Repository
{
    public class PlayerDTORepository : Repository<PlayerDTO>, IPlayerDTORepository
    {
        public PlayerDTORepository(PokeApiDbContext context) : base(context)
        {
        }
    }
}

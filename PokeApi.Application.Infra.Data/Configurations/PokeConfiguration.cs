using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PokeApi.Application.Abstraction.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeApi.Application.Infra.Data.Configurations
{
    public class PokeConfiguration : IEntityTypeConfiguration<PokeDTO>
    {
        public void Configure(EntityTypeBuilder<PokeDTO> builder)
        {
            builder.ToTable(name: nameof(PokeDTO));
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasMaxLength(36)
                .IsRequired()
                .ValueGeneratedNever();

            builder.Property(x => x.Name).HasMaxLength(255).IsRequired();
          
           
        }

    }
    
    }


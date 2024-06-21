using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PokeApi.Application.Abstraction.Domain.DTO;

namespace PokeApi.Application.Infra.Data.Configurations
{
    public class PlayerConfiguration : IEntityTypeConfiguration<PlayerDTO>
    {
       public void Configure(EntityTypeBuilder<PlayerDTO> builder)
        {
            builder.ToTable(name: nameof(PlayerDTO));
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasMaxLength(36)
                .IsRequired()
                .ValueGeneratedNever();

            builder.Property(x => x.nome).HasMaxLength(255).IsRequired();
            builder.Property(x => x.vida).IsRequired();
            builder.Property(x => x.status).IsRequired();
            builder.Property(x => x.energia).IsRequired();


        }
        
    }
}

using PokeApi.Application.Infra.Data.Repository;
using PokeApi.Application.Interface;
using PokeApi.Application.Services;

namespace PokeAPI.Extension
{
    public static class ServiceCollection
    {

        public static IServiceCollection AddFeatureServices(this IServiceCollection services)
        {
            services.AddServices();
            services.AddRepository();
            services.AddControllers();
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IPokemonService, PokeService>();
            services.AddScoped<IPlayerService, PlayerService>();
            return services;
        }

        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddScoped<IPlayerDTORepository, PlayerDTORepository>();
            services.AddScoped<IPokeDTORepository, PokeDTORepository>();
            return services;
        }



    }
}

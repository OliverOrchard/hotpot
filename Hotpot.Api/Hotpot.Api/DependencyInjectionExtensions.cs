using Hotpot.Data;
using Hotpot.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Hotpot.Api
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddUserProviders(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddSingleton<IPotProvider, PotProvider>();

            services.AddSingleton<IConnectionStringProvider, ConnectionStringProvider>();
            services.AddSingleton<IGetPotQuery, GetPotQuery>();
            services.AddSingleton<IPotRepository, PotRepository>();

            return services;
        }
    }
}
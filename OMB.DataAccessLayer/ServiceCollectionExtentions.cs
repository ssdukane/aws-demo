using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OMB.Application.Interfaces;


namespace OMB.DataAccessLayer
{
    public static class ServiceCollectionExtentions
    {
        public static IServiceCollection AddInfraServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<OMBContext>((sp) =>
            {
                _ = sp.UseSqlServer(configuration.GetConnectionString("DatabaseConnection"));
            });

            services.AddScoped<IOwnerRepository, OwnerRepository>();
            return services;
        }
    }
}

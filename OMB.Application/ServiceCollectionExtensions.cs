using Microsoft.Extensions.DependencyInjection;
using OMB.Application.Configuration;

namespace OMB.Application;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicatoinServices( this IServiceCollection services, ApplicationOptions options)
    {

        //services.AddRecurringJobs();
         return services;
    }
}

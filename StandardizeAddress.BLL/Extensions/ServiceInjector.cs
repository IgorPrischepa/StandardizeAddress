using Microsoft.Extensions.DependencyInjection;
using StandardizeAddress.BLL.Contracts;
using StandardizeAddress.BLL.Services;

namespace StandardizeAddress.BLL.Extensions
{
    public static class ServiceInjector
    {
        public static IServiceCollection AddServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IDadataService, DadataService>();

            return serviceCollection;
        }
    }
}
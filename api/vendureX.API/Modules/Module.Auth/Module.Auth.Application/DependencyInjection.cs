using Microsoft.Extensions.DependencyInjection;

namespace Module.Auth.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            return services;
        }
    }
}
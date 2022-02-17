using BygasProject.Repository;
using BygasProject.Repository.Interfaces;
using BygasProject.Service;
using BygasProject.Service.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BygasProject.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection AddDependencyInjectionConfig(this IServiceCollection services)
        {
            services.AddScoped<IFileRepository, FileRepository>();
            services.AddScoped<IDishService, DishService>();

            return services;
        }
    }
}

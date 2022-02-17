using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using BygasProject.API.Configuration;
using Microsoft.Extensions.Configuration;

namespace BygasProject.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDependencyInjectionConfig();
        }

        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }
    }
}

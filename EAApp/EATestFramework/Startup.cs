using EATestFramework.Driver;
using Microsoft.Extensions.DependencyInjection;

namespace EATestFramework
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IDriverFixture, DriverFixture>();
            services.AddScoped<IBrowserDriver, BrowserDriver>();
        }

    }
}

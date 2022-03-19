using Microsoft.Extensions.DependencyInjection;
using SeleniumXUnitBasic.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumXUnitBasic
{
    public class Startup
    {


        public void ConfigureServices(IServiceCollection services)
        {
            services.UseWebDriverInitializer(BrowserType.Edge);
            services.AddScoped<IDriverFixture, DriverFixture>();
            services.AddScoped<IBrowserDriver, BrowserDriver>();
        }
    }
}

using EATestFramework.Driver;
using EATestFramework.Extensions;
using EATestProject.Pages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATestProject
{
    public class Startup
    {


        public void ConfigureServices(IServiceCollection services)
        {
            services.UseWebDriverInitializer();
            services.AddScoped<IHomePage, HomePage>();
            services.AddScoped<IProductPage, ProductPage>();
            services.AddScoped<IDriverFixture, DriverFixture>();
            services.AddScoped<IBrowserDriver, BrowserDriver>();
        }
    }
}

using EATestFramework.Driver;
using EATestProject.Pages;
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
            services.UseWebDriverInitializer(BrowserType.Chrome);
            services.AddScoped<IHomePage, HomePage>();
            services.AddScoped<ICreateProductPage, CreateProductPage>();
            services.AddScoped<IDriverFixture, DriverFixture>();
            services.AddScoped<IBrowserDriver, BrowserDriver>();
        }
    }
}

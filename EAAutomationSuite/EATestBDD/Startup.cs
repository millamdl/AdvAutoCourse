﻿using Microsoft.Extensions.DependencyInjection;
using SolidToken.SpecFlow.DependencyInjection;

namespace EATestBDD
{
    public static class Startup
    {

        [ScenarioDependencies]
        public static IServiceCollection CreateServices()
        {
            var services = new ServiceCollection();

            services.UseWebDriverInitializer();
            services.AddScoped<IHomePage, HomePage>();
            services.AddScoped<IProductPage, ProductPage>();
            services.AddScoped<IDriverFixture, DriverFixture>();
            services.AddScoped<IBrowserDriver, BrowserDriver>();

            return services;
        }
    }
}

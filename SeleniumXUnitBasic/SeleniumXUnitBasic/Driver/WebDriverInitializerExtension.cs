using Microsoft.Extensions.DependencyInjection;
using SeleniumXUnitBasic.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumXUnitBasic.Driver
{
    public static class WebDriverInitializerExtension
    {
        public static IServiceCollection UseWebDriverInitializer(
            this IServiceCollection services,
            BrowserType browserType)
        {
            services.AddSingleton(new TestSettings
            {
                BrowserType = browserType,
            });

            return services;
        }
    }
}

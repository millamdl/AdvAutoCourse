using EATestFramework.Settings;
using OpenQA.Selenium;
using System;

namespace EATestFramework.Driver;

public class DriverFixture : IDisposable, IDriverFixture
{
    IWebDriver driver;
    private readonly TestSettings testSettings;
    private readonly IBrowserDriver browserDriver;

    // DI is happening
    public DriverFixture(TestSettings testSettings, IBrowserDriver browserDriver)
    {
        this.testSettings = testSettings;
        this.browserDriver = browserDriver;
        driver = GetWebDriver();
        driver.Navigate().GoToUrl(testSettings.ApplicationUrl);
    }

    public IWebDriver Driver => driver;

    private IWebDriver GetWebDriver()
    {
        return testSettings.BrowserType switch
        {
            BrowserType.Chrome => browserDriver.GetChromeDriver(),
            BrowserType.Firefox => browserDriver.GetFirefoxDriver(),
            BrowserType.Edge => browserDriver.GetEdgeDriver(),
            _ => browserDriver.GetChromeDriver()
        };
    }


    public void Dispose()
    {
        driver.Quit();
    }
}

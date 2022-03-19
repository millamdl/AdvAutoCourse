using OpenQA.Selenium;
using SeleniumXUnitBasic.Settings;
using System;

namespace SeleniumXUnitBasic.Driver;

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

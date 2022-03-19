using OpenQA.Selenium;

namespace SeleniumXUnitBasic.Driver;

public interface IBrowserDriver
{
    IWebDriver GetChromeDriver();
    IWebDriver GetFirefoxDriver();
    IWebDriver GetEdgeDriver();
}

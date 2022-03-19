using Autofac;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumXUnitBasic.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SeleniumXUnitBasic
{
    public class UnitTest3 : IDisposable
    {
        IWebDriver driver;
        IContainer container;
        public UnitTest3()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<BrowserDriver>().As<IBrowserDriver>();
            container = builder.Build();

            var driverFixture = new DriverFixture(container, Driver.BrowserType.Edge);
            driver = driverFixture.Driver;
            driver.Navigate().GoToUrl(new Uri("http://localhost:5001/"));
        }


        public void Dispose()
        {
            driver.Quit();
        }

        [Fact]
        public void Test6()
        {
            driver.FindElement(By.LinkText("Product")).Click();
            driver.FindElement(By.LinkText("Create")).Click();
            driver.FindElement(By.Id("Name")).SendKeys("Mic");
            driver.FindElement(By.Id("Description")).SendKeys("Microphone");
            driver.FindElement(By.Id("Price")).SendKeys("5000");
            var select = new SelectElement(driver.FindElement(By.Id("ProductType")));
            select.SelectByValue("1");
            driver.FindElement(By.Id("Create")).Submit();
        }

        [Fact]
        public void Test7()
        {
            driver.FindElement(By.LinkText("Product")).Click();
            driver.FindElement(By.LinkText("Create")).Click();
            driver.FindElement(By.Id("Name")).SendKeys("Headset");
            driver.FindElement(By.Id("Description")).SendKeys("Headphone set");
            driver.FindElement(By.Id("Price")).SendKeys("400");
            var select = new SelectElement(driver.FindElement(By.Id("ProductType")));
            select.SelectByValue("3");
            driver.FindElement(By.Id("Create")).Submit();
        }
    }
}

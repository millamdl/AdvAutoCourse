using EATestFramework.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using Xunit;

namespace EATestFramework
{
    public class UnitTest2 : IDisposable
    {
        IWebDriver driver;
        public UnitTest2(IDriverFixture driverFixture)
        {
            driver = driverFixture.Driver;
            driver.Navigate().GoToUrl(new Uri("http://localhost:5001/"));
        }


        public void Dispose()
        {
            driver.Quit();
        }

        [Fact]
        public void Test4()
        {
            driver.FindElement(By.LinkText("Product")).Click();
            driver.FindElement(By.LinkText("Create")).Click();
            driver.FindElement(By.Id("Name")).SendKeys("Motherboard");
            driver.FindElement(By.Id("Description")).SendKeys("Computer board");
            driver.FindElement(By.Id("Price")).SendKeys("5000");
            var select = new SelectElement(driver.FindElement(By.Id("ProductType")));
            select.SelectByValue("1");
            driver.FindElement(By.Id("Create")).Submit();
        }

        [Fact]
        public void Test5()
        {
            driver.FindElement(By.LinkText("Product")).Click();
            driver.FindElement(By.LinkText("Create")).Click();
            driver.FindElement(By.Id("Name")).SendKeys("Speakers");
            driver.FindElement(By.Id("Description")).SendKeys("Speakers sound system");
            driver.FindElement(By.Id("Price")).SendKeys("400");
            var select = new SelectElement(driver.FindElement(By.Id("ProductType")));
            select.SelectByValue("3");
            driver.FindElement(By.Id("Create")).Submit();
        }

    }
}
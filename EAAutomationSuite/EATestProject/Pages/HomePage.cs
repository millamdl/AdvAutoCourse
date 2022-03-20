using EATestFramework.Driver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATestProject.Pages
{
    public interface IHomePage
    {
        void CreateProduct();
    }

    public class HomePage : IHomePage
    {
        private readonly IWebDriver driver;

        public HomePage(IDriverFixture driverFixture) => driver = driverFixture.Driver;

        IWebElement lnkProduct => driver.FindElement(By.LinkText("Product"));
        IWebElement lnkCreate => driver.FindElement(By.LinkText("Create"));
        public void CreateProduct()
        {
            lnkProduct.Click();
            lnkCreate.Click();
        }

    }
}

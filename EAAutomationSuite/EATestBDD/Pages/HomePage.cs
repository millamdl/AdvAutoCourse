﻿
namespace EATestBDD.Pages
{
    public interface IHomePage
    {
        void ClickCreate();
        void ClickProduct();
        void CreateProduct();
        void PerformClickOnSpecialValue(string name, string operation);
    }

    public class HomePage : IHomePage
    {
        private readonly IWebDriver driver;

        public HomePage(IDriverFixture driverFixture) => driver = driverFixture.Driver;

        IWebElement lnkProduct => driver.FindElement(By.LinkText("Product"));
        IWebElement lnkCreate => driver.FindElement(By.LinkText("Create"));
        IWebElement tblList => driver.FindElement(By.CssSelector(".table"));
        public void CreateProduct()
        {
            lnkProduct.Click();
            lnkCreate.Click();
        }

        public void ClickProduct() => lnkProduct.Click();

        public void ClickCreate() => lnkCreate.Click();

        public void PerformClickOnSpecialValue(string name, string operation)
        {
            tblList.PerformActionOnCell("5", "Name", name, operation);
        }

    }
}

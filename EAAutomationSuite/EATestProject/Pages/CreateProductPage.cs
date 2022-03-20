﻿using EATestFramework.Driver;
using EATestProject.Model;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATestProject.Pages
{
    public interface ICreateProductPage
    {
        void EnterProductDetails(Product product);
    }

    public class CreateProductPage : ICreateProductPage
    {
        private readonly IWebDriver driver;

        public CreateProductPage(IDriverFixture driverFixture) => driver = driverFixture.Driver;
        IWebElement txtName => driver.FindElement(By.Id("Name"));
        IWebElement txtDescription => driver.FindElement(By.Id("Description"));
        IWebElement txtPrice => driver.FindElement(By.Id("Price"));
        IWebElement ddlProductType => driver.FindElement(By.Id("ProductType"));
        IWebElement btnCreate => driver.FindElement(By.Id("Create"));

        public void EnterProductDetails(Product product)
        {
            txtName.SendKeys(product.Name);
            txtDescription.SendKeys(product.Description);
            txtPrice.SendKeys(product.Price.ToString());
            var select = new SelectElement(ddlProductType);
            select.SelectByText(product.ProductType.ToString());
            btnCreate.Click();
        }

    }
}

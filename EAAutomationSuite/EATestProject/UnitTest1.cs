using AutoFixture.Xunit2;
using EATestFramework.Driver;
using EATestProject.Model;
using EATestProject.Pages;
using OpenQA.Selenium;
using System;
using Xunit;

namespace EATestProject
{
    public class UnitTest1 
    {
        private readonly IHomePage homePage;
        private readonly ICreateProductPage createProductPage;

        public UnitTest1(IHomePage homePage, ICreateProductPage createProductPage)
        {
            this.homePage = homePage;
            this.createProductPage = createProductPage;
        }

        [Theory, AutoData]
        public void Test1(Product product)
        {
            // Separation of Concern
            homePage.CreateProduct();

            createProductPage.EnterProductDetails(product);
        }
    }
}
using AutoFixture.Xunit2;
using EATestFramework.Driver;
using EATestProject.Model;
using EATestProject.Pages;
using FluentAssertions;
using OpenQA.Selenium;
using System;
using Xunit;

namespace EATestProject
{
    public class UnitTest1 
    {
        private readonly IHomePage homePage;
        private readonly IProductPage productPage;

        public UnitTest1(IHomePage homePage, IProductPage productPage)
        {
            this.homePage = homePage;
            this.productPage = productPage;
        }

        [Theory, AutoData]
        public void Test1(Product product)
        {
            // Separation of Concern
            homePage.CreateProduct();

            productPage.EnterProductDetails(product);

            homePage.PerformClickOnSpecialValue(product.Name,"Details");

            //assertion
            var actualProduct = productPage.GetProductDetails();

            actualProduct
                .Should()
                .BeEquivalentTo(product, option => option.Excluding(x => x.Id));
            
        }
    }
}
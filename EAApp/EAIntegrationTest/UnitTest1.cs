using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using ProductAPI;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace EAIntegrationTest;

public class UnitTest1 : IClassFixture<WebApplicationFactory<Startup>>
{
    private readonly WebApplicationFactory<Startup> webApplicationFactory;

    public UnitTest1(WebApplicationFactory<Startup> webApplicationFactory)
    {
        this.webApplicationFactory = webApplicationFactory;
    }

    //[Fact]
    //public void Test1()
    //{
    //    var client = new HttpClient();
    //    client.BaseAddress = new Uri("http://localhost:5000/");

    //    var response = client.Send(new HttpRequestMessage(HttpMethod.Get, "Product/GetProducts"));

    //    response.EnsureSuccessStatusCode(); 
    //}

    [Fact]
    public async Task TestWithWebAppFactory()
    {
        var webClient = webApplicationFactory.CreateClient();

        var product = await webClient.GetAsync("/Product/GetProducts");

        var result = product.Content.ReadAsStringAsync().Result;

        result.Should().Contain("Keyboard");


    }

    [Fact]
    public async Task TestWithGeneratedCode()
    {
        var webClient = webApplicationFactory.CreateClient();

        var product = new ProductAPI("https://localhost:44334/", webClient);

        var results = await product.GetProductsAsync();

        results.Select(x => x.Name == "Keyboard").Should().NotBeEmpty();


    }
}

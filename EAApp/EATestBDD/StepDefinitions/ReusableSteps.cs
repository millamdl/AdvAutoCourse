using ProductAPI.Repository;

namespace EATestBDD.StepDefinitions;

[Binding]
public class ReusableSteps
{
    private readonly ScenarioContext scenarioContext;
    private readonly IProductRepository productRepository;

    public ReusableSteps(ScenarioContext scenarioContext, IProductRepository productRepository)
    {
        this.scenarioContext = scenarioContext;
        this.productRepository = productRepository;
    }

    [Then(@"I delete the product (.*) for cleanup")]
    public void ThenIDeleteTheProductHeadphonesForCleanup(string productName)
    {
        productRepository.DeleteProduct(productName);
    }

}

﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace EATestBDD.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class ProductFeature : object, Xunit.IClassFixture<ProductFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "Product.feature"
#line hidden
        
        public ProductFeature(ProductFeature.FixtureData fixtureData, EATestBDD_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Product", "\tTest the product page functionalities", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 4
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description",
                        "Price",
                        "ProductType"});
            table1.AddRow(new string[] {
                        "Monitor",
                        "HD monitor",
                        "400",
                        "MONITOR"});
            table1.AddRow(new string[] {
                        "Headphones",
                        "Noise cancellation",
                        "300",
                        "PERIPHARALS"});
#line 5
 testRunner.Given("I cleanup following data", ((string)(null)), table1, "Given ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.TraitAttribute("FeatureTitle", "Product")]
        [Xunit.TraitAttribute("Description", "Create product and verify the details")]
        [Xunit.TraitAttribute("Category", "mytag")]
        [Xunit.TraitAttribute("Category", "retry(4)")]
        [xRetry.RetryFact(4, 0, new System.Type[] {
                typeof(Xunit.SkipException)}, DisplayName="Create product and verify the details")]
        public void CreateProductAndVerifyTheDetails()
        {
            string[] tagsOfScenario = new string[] {
                    "mytag",
                    "retry(4)"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create product and verify the details", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 11
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
#line 12
 testRunner.Given("I click the Product menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 13
 testRunner.And("I click the \"Create\" link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "Description",
                            "Price",
                            "ProductType"});
                table2.AddRow(new string[] {
                            "Headphones",
                            "Noise cancellation",
                            "300",
                            "PERIPHARALS"});
#line 14
 testRunner.And("I create product with following details", ((string)(null)), table2, "And ");
#line hidden
#line 17
 testRunner.When("I click the Details link of the newly created product", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 18
 testRunner.Then("I see all the product details are created as expected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 19
 testRunner.And("I delete the product Headphones for cleanup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Edit Product and verify if its updated")]
        [Xunit.TraitAttribute("FeatureTitle", "Product")]
        [Xunit.TraitAttribute("Description", "Edit Product and verify if its updated")]
        [Xunit.TraitAttribute("Category", "mytag")]
        public void EditProductAndVerifyIfItsUpdated()
        {
            string[] tagsOfScenario = new string[] {
                    "mytag"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Edit Product and verify if its updated", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 23
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "Description",
                            "Price",
                            "ProductType"});
                table3.AddRow(new string[] {
                            "Monitor",
                            "HD monitor",
                            "400",
                            "MONITOR"});
#line 24
 testRunner.Given("I ensure the following product is created", ((string)(null)), table3, "Given ");
#line hidden
#line 27
 testRunner.Given("I click the Product menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 28
 testRunner.When("I click the Edit link of the newly created product", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "Description",
                            "Price",
                            "ProductType"});
                table4.AddRow(new string[] {
                            "Monitor",
                            "HD Resolution monitor",
                            "500",
                            "MONITOR"});
#line 29
 testRunner.And("I Edit the product details with following", ((string)(null)), table4, "And ");
#line hidden
#line 32
 testRunner.And("I click the Details link of the newly created product", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 33
 testRunner.Then("I see all the product details are created as expected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 34
 testRunner.And("I delete the product Monitor for cleanup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                ProductFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                ProductFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion

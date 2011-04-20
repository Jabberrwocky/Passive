// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.5.0.0
//      Runtime Version:4.0.30319.225
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace Passive.Test.DynamicModelTests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.5.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class DynamicModelAllFeature : Xunit.IUseFixture<DynamicModelAllFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "All.feature"
#line hidden
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "DynamicModel All", "In order to access data\nAs a developer\nI want to get all rows from the database", GenerationTargetLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public virtual void SetFixture(DynamicModelAllFeature.FixtureData fixtureData)
        {
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            this.FeatureBackground();
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Name",
                        "Color",
                        "Amps"});
            table1.AddRow(new string[] {
                        "1",
                        "Toaster",
                        "Stainless Steel",
                        "7"});
            table1.AddRow(new string[] {
                        "2",
                        "Vacuum",
                        "Red",
                        "12"});
            table1.AddRow(new string[] {
                        "3",
                        "Stove",
                        "White",
                        "30"});
            table1.AddRow(new string[] {
                        "4",
                        "Microwave",
                        "White",
                        "20"});
#line 7
  testRunner.Given("a database with the following appliances", ((string)(null)), table1);
#line hidden
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "DynamicModel All")]
        [Xunit.TraitAttribute("Description", "Getting all records")]
        public virtual void GettingAllRecords()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Getting all records", ((string[])(null)));
#line 15
this.ScenarioSetup(scenarioInfo);
#line 16
  testRunner.Given("I have a model for Appliance");
#line 17
  testRunner.When("I ask for all rows");
#line 18
  testRunner.Then("I should get all items");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "DynamicModel All")]
        [Xunit.TraitAttribute("Description", "Getting some records")]
        public virtual void GettingSomeRecords()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Getting some records", ((string[])(null)));
#line 21
this.ScenarioSetup(scenarioInfo);
#line 22
  testRunner.Given("I have a model for Appliance");
#line 23
  testRunner.When("I ask for 2 rows");
#line 24
  testRunner.Then("I should only have 2 results");
#line 25
  testRunner.And("they should be a subset of all data");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.5.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                DynamicModelAllFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                DynamicModelAllFeature.FeatureTearDown();
            }
        }
    }
}
#endregion

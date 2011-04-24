// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.6.1.0
//      SpecFlow Generator Version:1.6.0.0
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
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.6.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class DynamicModelSingleFeature : Xunit.IUseFixture<DynamicModelSingleFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Single.feature"
#line hidden
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "DynamicModel Single()", "In order to access data\r\nAs a developer\r\nI want to get all rows from the database" +
                    "", GenerationTargetLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public virtual void SetFixture(DynamicModelSingleFeature.FixtureData fixtureData)
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
        [Xunit.TraitAttribute("FeatureTitle", "DynamicModel Single()")]
        [Xunit.TraitAttribute("Description", "Getting a record without any filtering")]
        public virtual void GettingARecordWithoutAnyFiltering()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Getting a record without any filtering", ((string[])(null)));
#line 15
this.ScenarioSetup(scenarioInfo);
#line 16
  testRunner.Given("I have a model for Appliance");
#line 17
  testRunner.When("I ask for a single row");
#line 18
  testRunner.Then("I should get 1 result");
#line 19
  testRunner.And("it should be a subset of all data");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "DynamicModel Single()")]
        [Xunit.TraitAttribute("Description", "Getting a record by id")]
        public virtual void GettingARecordById()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Getting a record by id", ((string[])(null)));
#line 21
this.ScenarioSetup(scenarioInfo);
#line 22
  testRunner.Given("I have a model for Appliance");
#line 23
  testRunner.When("I ask for the record with the id of 2");
#line 24
  testRunner.Then("I should get appliance #2");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "DynamicModel Single()")]
        [Xunit.TraitAttribute("Description", "Getting a record that doesn\'t exist")]
        public virtual void GettingARecordThatDoesnTExist()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Getting a record that doesn\'t exist", ((string[])(null)));
#line 26
this.ScenarioSetup(scenarioInfo);
#line 27
  testRunner.Given("I have a model for Appliance");
#line 28
  testRunner.When("I ask for the record with the id of 400");
#line 29
  testRunner.Then("I should get no results");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [Xunit.Extensions.TheoryAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "DynamicModel Single()")]
        [Xunit.TraitAttribute("Description", "Filtering records by an object")]
        [Xunit.Extensions.InlineDataAttribute("Stainless Steel", "1", new string[0])]
        [Xunit.Extensions.InlineDataAttribute("Red", "1", new string[0])]
        [Xunit.Extensions.InlineDataAttribute("White", "1", new string[0])]
        [Xunit.Extensions.InlineDataAttribute("Green", "0", new string[0])]
        public virtual void FilteringRecordsByAnObject(string value, string count, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Filtering records by an object", exampleTags);
#line 31
this.ScenarioSetup(scenarioInfo);
#line 32
  testRunner.Given("I have a model for Appliance");
#line 33
  testRunner.When("I ask for a single row");
#line 34
  testRunner.And(string.Format("I only want appliances colored {0}", value));
#line 35
  testRunner.Then(string.Format("I should get {0} results", count));
#line 36
  testRunner.And(string.Format("I should only get {0}-colored appliances", value));
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [Xunit.Extensions.TheoryAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "DynamicModel Single()")]
        [Xunit.TraitAttribute("Description", "Filtering records by string")]
        [Xunit.Extensions.InlineDataAttribute("6", "1", new string[0])]
        [Xunit.Extensions.InlineDataAttribute("7", "1", new string[0])]
        [Xunit.Extensions.InlineDataAttribute("10", "1", new string[0])]
        [Xunit.Extensions.InlineDataAttribute("15", "1", new string[0])]
        [Xunit.Extensions.InlineDataAttribute("20", "1", new string[0])]
        [Xunit.Extensions.InlineDataAttribute("30", "0", new string[0])]
        public virtual void FilteringRecordsByString(string value, string count, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Filtering records by string", exampleTags);
#line 45
this.ScenarioSetup(scenarioInfo);
#line 46
  testRunner.Given("I have a model for Appliance");
#line 47
  testRunner.When("I ask for a single row");
#line 48
  testRunner.And(string.Format("I only want appliances with more than {0} amps", value));
#line 49
  testRunner.Then(string.Format("I should get {0} results", count));
#line 50
  testRunner.And(string.Format("I should only get appliances with more than {0} amps", value));
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [Xunit.Extensions.TheoryAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "DynamicModel Single()")]
        [Xunit.TraitAttribute("Description", "Executing a query with order by")]
        [Xunit.Extensions.InlineDataAttribute("id", "1", new string[0])]
        [Xunit.Extensions.InlineDataAttribute("id desc", "4", new string[0])]
        [Xunit.Extensions.InlineDataAttribute("name", "4", new string[0])]
        [Xunit.Extensions.InlineDataAttribute("name desc", "2", new string[0])]
        [Xunit.Extensions.InlineDataAttribute("AMPS", "1", new string[0])]
        [Xunit.Extensions.InlineDataAttribute("AMPS DESC", "3", new string[0])]
        public virtual void ExecutingAQueryWithOrderBy(string orderby, string id, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Executing a query with order by", exampleTags);
#line 62
this.ScenarioSetup(scenarioInfo);
#line 63
  testRunner.Given("I have a model for Appliance");
#line 64
  testRunner.When("I ask for a single row");
#line 65
  testRunner.And("I order rows by Amps");
#line 66
  testRunner.Then("I should get appliance #1");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "DynamicModel Single()")]
        [Xunit.TraitAttribute("Description", "Selecting a subset of columns")]
        public virtual void SelectingASubsetOfColumns()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Selecting a subset of columns", ((string[])(null)));
#line 77
this.ScenarioSetup(scenarioInfo);
#line 78
  testRunner.Given("I have a model for Appliance");
#line 79
  testRunner.When("I ask for a single row");
#line 80
  testRunner.And("I ask for the columns \"Id, Name\"");
#line 81
  testRunner.Then("the records should only have the columns \"Id, Name\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "DynamicModel Single()")]
        [Xunit.TraitAttribute("Description", "Selecting an invalid column")]
        public virtual void SelectingAnInvalidColumn()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Selecting an invalid column", ((string[])(null)));
#line 83
this.ScenarioSetup(scenarioInfo);
#line 84
  testRunner.Given("I have a model for Appliance");
#line 85
  testRunner.When("I ask for a single row");
#line 86
  testRunner.And("I ask for an invalid column");
#line 87
  testRunner.Then("the query should throw an exception");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.6.1.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                DynamicModelSingleFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                DynamicModelSingleFeature.FeatureTearDown();
            }
        }
    }
}
#endregion
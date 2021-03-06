// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.3.5.2
//      Runtime Version:4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace Dominion.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.3.5.2")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Game Setup")]
    public partial class GameSetupFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "GameSetup.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Game Setup", "In order to play dominion\r\nAs a player\r\nI want the game to be set up according to" +
                    " the rules", ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Initial deck")]
        public virtual void InitialDeck()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Initial deck", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
testRunner.Given("A new game with 3 players");
#line 8
testRunner.Then("The initial deck for each player should comprise of 7 Copper and 3 Estate");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Draw opening hand")]
        public virtual void DrawOpeningHand()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Draw opening hand", ((string[])(null)));
#line 10
this.ScenarioSetup(scenarioInfo);
#line 11
testRunner.Given("A new game with 3 players");
#line 12
testRunner.Then("Each player should have 5 cards in hand");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void AvailableProvincesForNumberOfPlayers(string playerCount, string provinceCount)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Available provinces for number of players", ((string[])(null)));
#line 14
this.ScenarioSetup(scenarioInfo);
#line 15
testRunner.Given(string.Format("A new game with {0} players", playerCount));
#line 16
testRunner.Then(string.Format("There should be {0} Province available to buy", provinceCount));
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Available provinces for number of players")]
        public virtual void AvailableProvincesForNumberOfPlayers_1()
        {
            this.AvailableProvincesForNumberOfPlayers("1", "12");
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Available provinces for number of players")]
        public virtual void AvailableProvincesForNumberOfPlayers_2()
        {
            this.AvailableProvincesForNumberOfPlayers("2", "12");
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Available provinces for number of players")]
        public virtual void AvailableProvincesForNumberOfPlayers_3()
        {
            this.AvailableProvincesForNumberOfPlayers("3", "12");
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Available provinces for number of players")]
        public virtual void AvailableProvincesForNumberOfPlayers_4()
        {
            this.AvailableProvincesForNumberOfPlayers("4", "12");
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Available provinces for number of players")]
        public virtual void AvailableProvincesForNumberOfPlayers_5()
        {
            this.AvailableProvincesForNumberOfPlayers("5", "15");
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Available provinces for number of players")]
        public virtual void AvailableProvincesForNumberOfPlayers_6()
        {
            this.AvailableProvincesForNumberOfPlayers("6", "18");
        }
        
        public virtual void AvailableCursesForNumberOfPlayers(string playerCount, string curseCount)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Available curses for number of players", ((string[])(null)));
#line 27
this.ScenarioSetup(scenarioInfo);
#line 28
testRunner.Given(string.Format("A new game with {0} players", playerCount));
#line 29
testRunner.Then(string.Format("There should be {0} Curse available to buy", curseCount));
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Available curses for number of players")]
        public virtual void AvailableCursesForNumberOfPlayers_1()
        {
            this.AvailableCursesForNumberOfPlayers("1", "10");
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Available curses for number of players")]
        public virtual void AvailableCursesForNumberOfPlayers_2()
        {
            this.AvailableCursesForNumberOfPlayers("2", "10");
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Available curses for number of players")]
        public virtual void AvailableCursesForNumberOfPlayers_3()
        {
            this.AvailableCursesForNumberOfPlayers("3", "20");
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Available curses for number of players")]
        public virtual void AvailableCursesForNumberOfPlayers_4()
        {
            this.AvailableCursesForNumberOfPlayers("4", "30");
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Available curses for number of players")]
        public virtual void AvailableCursesForNumberOfPlayers_5()
        {
            this.AvailableCursesForNumberOfPlayers("5", "40");
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Available curses for number of players")]
        public virtual void AvailableCursesForNumberOfPlayers_6()
        {
            this.AvailableCursesForNumberOfPlayers("6", "50");
        }
    }
}
#endregion

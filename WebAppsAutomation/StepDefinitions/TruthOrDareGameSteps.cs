using SpecFlow;
using TechTalk.SpecFlow;
using FluentAssertions;
using WebAppsAutomation.Steps;
using TechTalk.SpecFlow.Assist;
using System.Collections.Generic;

namespace WebAppsAutomation.StepDefinitions
{
    [Binding]
    public class TruthOrDareGameSteps
    {
        

        private readonly TruthOrDareGame truthOrDare;
        public TruthOrDareGameSteps(TruthOrDareGame _truthOrDare)
        {
            truthOrDare = _truthOrDare; 
        }

        [Given(@"I have launched the TruthOrDare game")]
        public void GivenIHaveLaunchedTheTruthOrDareGame()
        {
            truthOrDare.IHaveLaunchedTheApp();
        }

        [Then(@"the app displays the following data")]
        public void ThenTheAppDisplaysTheFollowingData(Table contentTable)
        {
            var table = contentTable.CreateDynamicSet();
            List<string> tableValues = new List<string>();
            foreach (var item in table)
            {
                tableValues.Add((string)item.Value);
            }

            truthOrDare.TheAppDisplaysTheFollowingData(ConvertTableToList(contentTable)).Should().BeTrue();
            
        }

        [Given(@"I enter the following names")]
        public void GivenIEnterTheFollowingNames(Table table)
        {
            truthOrDare.IEnterTheFollowingNames(ConvertTableToList(table));
        }

        [Then(@"the following names are added")]
        public void ThenTheFollowingNamesAreAdded(Table table)
        {
            truthOrDare.ThenTheNamesAreAdded(ConvertTableToList(table)).Should().BeTrue();
        }

        [Given(@"I start the game")]
        public void GivenIStartTheGame()
        {
            truthOrDare.StartGame();
        }


        [Then(@"the '([^']*)' button is visible")]
        public void ThenTheButtonIsVisible(string buttonName)
        {
            truthOrDare.TheButtonIsVisible(buttonName);
        }

        [Then(@"the game container reads '([^']*)'")]
        public void ThenTheGameContainerReads(string value)
        {
            truthOrDare.GameContainerReads(value);
        }



        public List<string> ConvertTableToList(Table Table)
        {
            var table = Table.CreateDynamicSet();
            List<string> tableValues = new List<string>();
            foreach (var item in table)
            {
                tableValues.Add((string)item.Value);
            }
            return tableValues;
        }


    }
}

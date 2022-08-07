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

            truthOrDare.TheAppDisplaysTheFollowingData(tableValues).Should().BeTrue();
            
        }


    }
}

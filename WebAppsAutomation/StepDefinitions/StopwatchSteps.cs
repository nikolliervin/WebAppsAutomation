using FluentAssertions;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using WebAppsAutomation.Steps;

namespace WebAppsAutomation.StepDefinitions
{
    [Binding]
    public class StopwatchSteps
    {

        private readonly Stopwatch stopwatch;
        public StopwatchSteps(Stopwatch _stopwatch)
        {
            stopwatch = _stopwatch;
        }

        [Given(@"I have launched the Stopwatch")]
        public void GivenIHaveLaunchedTheStopwatch()
        {
            stopwatch.IHaveLaunchedTheStopwatch();
        }

        [Then(@"the following components are displayed:")]
        public void ThenTheFollowingComponentsAreDisplayed(Table table)
        {
            var components = table.CreateDynamicSet();
            List<string> tableValues = new List<string>();
            foreach (var item in components)
            {
                tableValues.Add((string)item.Components);
            }
            stopwatch.ThenTheComponentsAreShown(tableValues).Should().BeTrue();
        }


    }
}

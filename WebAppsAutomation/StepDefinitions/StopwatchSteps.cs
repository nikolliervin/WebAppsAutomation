using TechTalk.SpecFlow;
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

    }
}

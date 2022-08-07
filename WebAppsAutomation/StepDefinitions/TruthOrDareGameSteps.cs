using SpecFlow;
using TechTalk.SpecFlow;
using FluentAssertions;
using WebAppsAutomation.Steps;

namespace WebAppsAutomation.StepDefinitions
{
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



    }
}

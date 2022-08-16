using FluentAssertions;
using TechTalk.SpecFlow;
using WebAppsAutomation.Steps;

namespace WebAppsAutomation.StepDefinitions
{
    [Binding]
    public class PasswordGeneratorSteps
    {
        private readonly PasswordGenerator passwordGenerator;

        public PasswordGeneratorSteps(PasswordGenerator _passwordGenerator)
        {
            passwordGenerator = _passwordGenerator;
        }

        [Given(@"I have launched the Password Generator")]
        public void GivenIHaveLaunchedThePasswordGenerator()
        {
            passwordGenerator.IHaveLaunchedPasswordGenApp();

        }

        [Given(@"I click on '([^']*)' button")]
        public void GivenIClickOnButton(string option)
        {
            passwordGenerator.AndIClickTheGenerateButton(option);
        }

        [Then(@"the password shows in the '([^']*)' container")]
        public void ThenThePasswordShowsInTheContainer(string container)
        {
            passwordGenerator.ThenThePasswordShows(container).Should().BeTrue();
        }




    }
}

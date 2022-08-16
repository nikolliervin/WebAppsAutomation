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
        [When(@"I click on '([^']*)' button")]
        public void GivenIClickOnButton(string option)
        {
            passwordGenerator.AndIClickTheGenerateButton(option);
        }

        [Then(@"the password shows in the '([^']*)' container")]
        public void ThenThePasswordShowsInTheContainer(string container)
        {
            passwordGenerator.ThenThePasswordShows(container).Should().BeTrue();
        }

        [Then(@"the '([^']*)' value is on the clipboard")]
        public void ThenTheValueIsOnTheClipboard(string field)
        {
            passwordGenerator.ThenTheClipboardContainsThePassword(field);
        }

        [Then(@"the '([^']*)' lenght is '([^']*)' characters long")]
        public void ThenThePasswordLenghtIsCharactersLong(string field, int number)
        {
            passwordGenerator.ThenThePasswordShouldBe(field, number).Should().BeTrue();
        }

        [Given(@"I uncheck '([^']*)' tick")]
        public void GivenIUncheckTick(string tick)
        {
            throw new PendingStepException();
        }








    }
}

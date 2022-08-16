using WebAppsAutomation.PageElements;

namespace WebAppsAutomation.Steps
{
    public class PasswordGenerator : WebDriver.WebDriver
    {
        private readonly PasswordGeneratorElements elements;
        public PasswordGenerator(PasswordGeneratorElements _elements)
        {
            elements = _elements;
        }
        public void IHaveLaunchedPasswordGenApp()
        {
            driver.Navigate().GoToUrl("https://magical-otter-182798.netlify.app/");
        }

        public void AndIClickTheGenerateButton(string option)
        {
            driver.FindElement(elements.element(option)).Click();
        }

        public bool ThenThePasswordShows(string container)
        {
            return driver.FindElement(elements.element(container)).Text != "";
        }
    }
}

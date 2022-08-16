using TechTalk.SpecFlow;

namespace WebAppsAutomation.Hooks
{
    [Binding]
    public class Hooks : WebDriver.WebDriver
    {
        [AfterScenario("WebAppsAutomation", Order = 1)]

        public void CloseWebDriver()
        {


        }
    }
}

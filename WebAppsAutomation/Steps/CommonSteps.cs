using WebAppsAutomation.URLs;

namespace WebAppsAutomation.Steps
{

    public class CommonSteps : WebDriver.WebDriver
    {
        private readonly WebAppURLs url;
        public CommonSteps(WebAppURLs _url)
        {
            url = _url;
        }

        public void IHaveLaunchedTheApp(string AppName)
        {
            driver.Navigate().GoToUrl(url.AppURL[AppName]);
        }
    }
}

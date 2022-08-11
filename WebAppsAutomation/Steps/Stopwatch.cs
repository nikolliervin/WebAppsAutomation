using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebAppsAutomation.Pages;

namespace WebAppsAutomation.Steps
{
    public class Stopwatch
    {
        IWebDriver webDriver = new ChromeDriver();
        private readonly StopwatchElements stopwatchElements;
        public Stopwatch(StopwatchElements _stopwatchElements)
        {
            stopwatchElements = _stopwatchElements;
        }

        public void IHaveLaunchedTheStopwatch()
        {
            webDriver.Navigate().GoToUrl("https://courageous-dusk-90082b.netlify.app/");
        }


    }
}

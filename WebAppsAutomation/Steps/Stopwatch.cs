using System.Collections.Generic;
using System.Threading;
using WebAppsAutomation.Pages;

namespace WebAppsAutomation.Steps
{
    public class Stopwatch : WebDriver.WebDriver
    {
        private readonly StopwatchElements stopwatchElements;
        public Stopwatch(StopwatchElements _stopwatchElements)
        {
            stopwatchElements = _stopwatchElements;
        }

        public void IHaveLaunchedTheStopwatch()
        {
            driver.Navigate().GoToUrl("https://courageous-dusk-90082b.netlify.app/");
        }

        public bool ThenTheComponentsAreShown(List<string> components)
        {
            return driver.FindElement(stopwatchElements.Element(components[0].ToLower())).Displayed &&
                   driver.FindElement(stopwatchElements.Element(components[1].ToLower())).Displayed &&
                   driver.FindElement(stopwatchElements.Element(components[2].ToLower())).Displayed &&
                   driver.FindElement(stopwatchElements.Element(components[3].ToLower())).Displayed;

        }

        public void IClickTheStopwatchButton(string button)
        {
            driver.FindElement(stopwatchElements.Element(button)).Click();
        }

        public bool ThenTheStopwatchStarts()
        {
            Thread.Sleep(2000);
            driver.FindElement(stopwatchElements.Element("stop")).Click();
            return driver.FindElement(stopwatchElements.Element("timer")).Text != "00:00:00";
        }

        public void ThenIWaitSeconds(int seconds)
        {
            Thread.Sleep(seconds * 1000);
        }

        public bool ThenTheStopwatchDisplays(string field, string value)
        {
            return driver.FindElement(stopwatchElements.Element(field)).Text == value;
        }
    }
}

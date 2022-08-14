using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Threading;
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

        public bool ThenTheComponentsAreShown(List<string> components)
        {
            return webDriver.FindElement(stopwatchElements.Element(components[0].ToLower())).Displayed &&
                   webDriver.FindElement(stopwatchElements.Element(components[1].ToLower())).Displayed &&
                   webDriver.FindElement(stopwatchElements.Element(components[2].ToLower())).Displayed &&
                   webDriver.FindElement(stopwatchElements.Element(components[3].ToLower())).Displayed;

        }

        public void IClickTheStopwatchButton(string button)
        {
            webDriver.FindElement(stopwatchElements.Element(button)).Click();
        }

        public bool ThenTheStopwatchStarts()
        {
            Thread.Sleep(2000);
            webDriver.FindElement(stopwatchElements.Element("stop")).Click();
            return webDriver.FindElement(stopwatchElements.Element("timer")).Text != "00:00:00";
        }
    }
}

﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
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
            return webDriver.FindElement(stopwatchElements.Element(components[0])).Displayed &&
                   webDriver.FindElement(stopwatchElements.Element(components[1])).Displayed &&
                   webDriver.FindElement(stopwatchElements.Element(components[2])).Displayed &&
                   webDriver.FindElement(stopwatchElements.Element(components[3])).Displayed;

        }
    }
}

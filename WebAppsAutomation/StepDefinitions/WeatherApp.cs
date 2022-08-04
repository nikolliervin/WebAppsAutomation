using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using WebAppsAutomation.Page_Elements;

namespace WebAppsAutomation.StepDefinitions
{
    public class WeatherApp
    {
        IWebDriver webDriver = new ChromeDriver();
        private readonly WeatherAppElements weatherAppMap;
        public WeatherApp(WeatherAppElements weatherAppElements)
        {
            weatherAppMap = weatherAppElements;
        }

    }
}

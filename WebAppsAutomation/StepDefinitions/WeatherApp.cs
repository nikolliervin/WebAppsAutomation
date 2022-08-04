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

        public void IHaveLaunchedTheApp()
        {
            webDriver.Navigate().GoToUrl("https://marvelous-nougat-1199fd.netlify.app/");
        }

        public bool IsCitySetTo(string cityName)
        {
            return cityName == webDriver.FindElement(weatherAppMap.CityValue).Text;
        }

        public void ISearchFor(string cityName)
        {
            webDriver.FindElement(weatherAppMap.CityInput).SendKeys(cityName);
            webDriver.FindElement(weatherAppMap.SearchBtn).Click();
        }


      
    }
}

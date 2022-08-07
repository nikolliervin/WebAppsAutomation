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
        
        public bool TheDetailsAreEqual(List<string> details)
        {
            return
                webDriver.FindElement(weatherAppMap.DetailLabel("humidity")).Text.Contains(details[0]) &&
                webDriver.FindElement(weatherAppMap.DetailLabel("windSpeed")).Text.Contains(details[1]) &&
                webDriver.FindElement(weatherAppMap.DetailLabel("windDeg")).Text.Contains(details[2]) &&
                webDriver.FindElement(weatherAppMap.DetailLabel("minTemp")).Text.Contains(details[3]) &&
                webDriver.FindElement(weatherAppMap.DetailLabel("pressure")).Text.Contains(details[4]) &&
                webDriver.FindElement(weatherAppMap.DetailLabel("maxTemp")).Text.Contains(details[5]);
        }

        public bool CopyrightsShowOnFooter(string copyrights)
        {
           return webDriver.FindElement(weatherAppMap.FooterCopyrights).Text == copyrights;
        }

      
    }
}

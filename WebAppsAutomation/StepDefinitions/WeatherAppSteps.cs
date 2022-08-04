using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace WebAppsAutomation.StepDefinitions
{
    [Binding]
    public class WeatherAppSteps
    {
        private WeatherApp _weatherApp;
        public WeatherAppSteps(WeatherApp weatherApp)
        {
            _weatherApp = weatherApp;   
        }

        [Given(@"I have launched the WeatherApp")]
        public void GivenIHaveLauchedTheWeatherApp()
        {
            _weatherApp.IHaveLaunchedTheApp();
        }

        [Then(@"The default city is '([^']*)'")]
        public void ThenTheDefaultCityIs(string city)
        {
            _weatherApp.IsCitySetTo(city);
        }

        [When(@"I search for '([^']*)'")]
        public void WhenISearchFor(string city)
        {
           _weatherApp.ISearchFor(city);
        }

        [Then(@"The city name is set to '([^']*)'")]
        public void ThenTheCityNameIsSetTo(string cityName)
        {
            _weatherApp.IsCitySetTo(cityName);
        }




    }
}

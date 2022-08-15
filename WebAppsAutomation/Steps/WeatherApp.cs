using System.Collections.Generic;
using WebAppsAutomation.Page_Elements;

namespace WebAppsAutomation.Steps
{
    public class WeatherApp : WebDriver.WebDriver
    {


        private readonly WeatherAppElements weatherAppMap;
        public WeatherApp(WeatherAppElements weatherAppElements)
        {
            weatherAppMap = weatherAppElements;
        }

        public void IHaveLaunchedTheApp()
        {
            driver.Navigate().GoToUrl("https://marvelous-nougat-1199fd.netlify.app/");
        }

        public bool IsCitySetTo(string cityName)
        {
            return cityName == driver.FindElement(weatherAppMap.CityValue).Text;
        }

        public void ISearchFor(string cityName)
        {
            driver.FindElement(weatherAppMap.CityInput).SendKeys(cityName);
            driver.FindElement(weatherAppMap.SearchBtn).Click();
        }

        public bool TheDetailsAreEqual(List<string> details)
        {
            return
                driver.FindElement(weatherAppMap.DetailLabel("humidity")).Text.Contains(details[0]) &&
                driver.FindElement(weatherAppMap.DetailLabel("windSpeed")).Text.Contains(details[1]) &&
                driver.FindElement(weatherAppMap.DetailLabel("windDeg")).Text.Contains(details[2]) &&
                driver.FindElement(weatherAppMap.DetailLabel("minTemp")).Text.Contains(details[3]) &&
                driver.FindElement(weatherAppMap.DetailLabel("pressure")).Text.Contains(details[4]) &&
                driver.FindElement(weatherAppMap.DetailLabel("maxTemp")).Text.Contains(details[5]);
        }

        public bool CopyrightsShowOnFooter(string copyrights)
        {
            return driver.FindElement(weatherAppMap.FooterCopyrights).Text == copyrights;
        }


    }
}

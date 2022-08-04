using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace WebAppsAutomation.Page_Elements
{
    public partial class WeatherAppElements
    {
        public By CityValue => By.XPath("//*[@id='cityName']");

        public By CityInput => By.XPath("//*[@id='searchTextBox']");

        public By SearchBtn => By.XPath("//*[@id='searchBtn']");

        public By DetailLabel(string detailLabel) => By.XPath($"//*[@id='{detailLabel}Details']"); 
    }
}

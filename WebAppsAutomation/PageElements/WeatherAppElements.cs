using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace WebAppsAutomation.Page_Elements
{
    public partial class WeatherAppElements
    {
        public By CityValue => By.XPath("//*[@id='cityName']");
    }
}

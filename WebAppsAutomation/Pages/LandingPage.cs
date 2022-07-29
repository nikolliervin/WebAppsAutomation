using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebAppsAutomation.Pages
{
    public class LandingPage
    {   
        public IWebDriver WebDriver { get; set; }

        public LandingPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
    }
}

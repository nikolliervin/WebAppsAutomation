using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using WebAppsAutomation.Page_Elements;
using WebAppsAutomation.PageElements;

namespace WebAppsAutomation.Steps
{
    public class TruthOrDareGame
    {
        IWebDriver webDriver = new ChromeDriver();
        private readonly TruthOrDareGameElements truthOrDareMap;
        public TruthOrDareGame(TruthOrDareGameElements _truthOrDareMap)
        {
            truthOrDareMap = _truthOrDareMap;
        }

        public void IHaveLaunchedTheApp()
        {
            webDriver.Navigate().GoToUrl("https://boisterous-froyo-aacb2d.netlify.app/");
        }

    }
}

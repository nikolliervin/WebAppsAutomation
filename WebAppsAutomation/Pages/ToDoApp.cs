using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebAppsAutomation.Pages
{
    public class ToDoApp
    {
        IWebDriver webDriver = new ChromeDriver();
        public void GivenIHaveLaunchedTheApp()
        {
            webDriver.Navigate().GoToUrl("https://gorgeous-fudge-cc9998.netlify.app/");
        }
    }
}

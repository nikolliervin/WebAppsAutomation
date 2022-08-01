using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;

namespace WebAppsAutomation.Pages
{
    public class ToDoApp
    {
        IWebDriver webDriver = new ChromeDriver();
        private readonly ToDoAppMap _pagemap;
        public ToDoApp(ToDoAppMap pagemap)
        {
            _pagemap = pagemap;
        }


        public void IHaveLaunchedTheApp()
        {
            webDriver.Navigate().GoToUrl("https://gorgeous-fudge-cc9998.netlify.app/");
            
        }

        public bool DateIsSetToToday()
        {
            var today = DateTime.Now.Year.ToString("d2") + "-" + DateTime.Now.Month.ToString("d2") + "-" + DateTime.Now.Day.ToString("d2");
            return today==webDriver.FindElement(_pagemap.dateField).Text;
        }

    }
}

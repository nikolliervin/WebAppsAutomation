using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebAppsAutomation.Pages
{
    public partial class ToDoAppMap
    {   
        public IWebDriver WebDriver { get; set; }

        public ToDoAppMap(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
        
        public static By dateField => By.XPath("//*[@id='date']");

    }
}

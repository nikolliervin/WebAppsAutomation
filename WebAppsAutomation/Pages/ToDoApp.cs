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
        private readonly ToDoAppElements _pagemap;
        public ToDoApp(ToDoAppElements pagemap)
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

        public void AddTheTask(string taskName)
        {
            webDriver.FindElement(_pagemap.taskInput).SendKeys(taskName);
        }

        public void ClickButton(string buttonId)
        {
            webDriver.FindElement(_pagemap.buttons(buttonId)).Click();
        }

        public bool OneNewTaskIsAdded(int taskNumber)
        {
            return webDriver.FindElements(_pagemap.taskfieldAdded).Count == taskNumber;
        }

        public bool ThenTheTasksFieldIsEmpty()
        {
            return webDriver.FindElements(_pagemap.taskfieldAdded).Count == 0;
        }
        
        public bool ThenOneTaskIsDeleted(string theTaskName)
        {                     
            return webDriver.FindElement(_pagemap.taskContent).Text==theTaskName;
        }

        public bool InputFieldIsEmpty()
        {
            return webDriver.FindElement(_pagemap.taskInput).GetAttribute("value")=="";
        }

        public bool ThenNoTaskIsAdded()
        {
            try
            {
                webDriver.FindElement(_pagemap.taskfieldAdded);
                return false;
            }
            catch (NoSuchElementException)
            {
                return true;
            }
        }
    }
}

using OpenQA.Selenium;
using System;
using WebAppsAutomation.Pages;

namespace WebAppsAutomation.Steps
{
    public class ToDoApp : WebDriver.WebDriver
    {

        private readonly ToDoAppElements _pagemap;
        public ToDoApp(ToDoAppElements pagemap)
        {
            _pagemap = pagemap;
        }


        public void IHaveLaunchedTheApp()
        {
            driver.Navigate().GoToUrl("https://gorgeous-fudge-cc9998.netlify.app/");

        }

        public bool DateIsSetToToday()
        {
            var today = DateTime.Now.Year.ToString("d2") + "-" + DateTime.Now.Month.ToString("d2") + "-" + DateTime.Now.Day.ToString("d2");
            return today == driver.FindElement(_pagemap.dateField).Text;
        }

        public void AddTheTask(string taskName)
        {
            driver.FindElement(_pagemap.taskInput).SendKeys(taskName);
        }

        public void ClickButton(string buttonId)
        {
            driver.FindElement(_pagemap.buttons(buttonId)).Click();
        }

        public bool OneNewTaskIsAdded(int taskNumber)
        {
            return driver.FindElements(_pagemap.taskfieldAdded).Count == taskNumber;
        }

        public bool ThenTheTasksFieldIsEmpty()
        {
            return driver.FindElements(_pagemap.taskfieldAdded).Count == 0;
        }

        public bool ThenOneTaskIsDeleted(string theTaskName)
        {
            return driver.FindElement(_pagemap.taskContent).Text == theTaskName;
        }

        public bool InputFieldIsEmpty()
        {
            return driver.FindElement(_pagemap.taskInput).GetAttribute("value") == "";
        }

        public bool ThenNoTaskIsAdded()
        {
            try
            {
                driver.FindElement(_pagemap.taskfieldAdded);
                return false;
            }
            catch (NoSuchElementException)
            {
                return true;
            }
        }
    }
}

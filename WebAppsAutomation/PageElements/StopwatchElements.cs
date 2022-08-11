using OpenQA.Selenium;

namespace WebAppsAutomation.Pages
{
    public partial class StopwatchElements
    {
        public By Element(string option) => By.XPath($"//*[@id='{option}']");


    }
}


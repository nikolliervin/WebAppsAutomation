using OpenQA.Selenium;


namespace WebAppsAutomation.PageElements
{
    public class PasswordGeneratorElements
    {
        public By element(string option) => By.XPath($"//*[@id='{option}']");
    }
}

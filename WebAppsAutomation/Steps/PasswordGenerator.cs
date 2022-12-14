using System;
using System.Linq;
using WebAppsAutomation.PageElements;
using Xamarin.Essentials;

namespace WebAppsAutomation.Steps
{
    public class PasswordGenerator : WebDriver.WebDriver
    {
        private readonly PasswordGeneratorElements elements;
        public PasswordGenerator(PasswordGeneratorElements _elements)
        {
            elements = _elements;
        }
        public void IHaveLaunchedPasswordGenApp()
        {
            driver.Navigate().GoToUrl("https://magical-otter-182798.netlify.app/");
        }

        public void AndIClickTheGenerateButton(string option)
        {
            driver.FindElement(elements.element(option)).Click();
        }

        public bool ThenThePasswordShows(string container)
        {
            return driver.FindElement(elements.element(container)).Text != "";
        }

        public bool ThenTheClipboardContainsThePassword(string field)
        {
            //ToDo: reference the nuget package to make xamaring essentials work
            return Clipboard.HasText.ToString().Contains(driver.FindElement(elements.element(field)).Text);
        }

        public bool ThenThePasswordShouldBe(string field, int number)
        {
            return driver.FindElement(elements.element(field)).Text.Length == number;
        }

        public void IUnselect(string value)
        {
            driver.FindElement(elements.element(value)).Click();
        }

        public bool ThenThePasswordDoesNotContain(string field, string type)
        {
            if (type == "number")
                return driver.FindElement(elements.element(field)).Text.Any(char.IsDigit);
            else if (type == "symbol")
                return driver.FindElement(elements.element(field)).Text.Any(ch => !Char.IsLetterOrDigit(ch));
            else if (type == "uppercase")
                return driver.FindElement(elements.element(field)).Text.Any(char.IsUpper);
            else if (type == "lowercase")
                return driver.FindElement(elements.element(field)).Text.Any(char.IsLower);

            else return false;
        }
    }
}

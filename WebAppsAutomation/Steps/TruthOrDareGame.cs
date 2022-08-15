using System.Collections.Generic;
using WebAppsAutomation.PageElements;

namespace WebAppsAutomation.Steps
{
    public class TruthOrDareGame : WebDriver.WebDriver
    {

        private readonly TruthOrDareGameElements truthOrDareMap;
        public TruthOrDareGame(TruthOrDareGameElements _truthOrDareMap)
        {
            truthOrDareMap = _truthOrDareMap;
        }

        public void IHaveLaunchedTheApp()
        {
            driver.Navigate().GoToUrl("https://boisterous-froyo-aacb2d.netlify.app/");
        }

        public bool TheAppDisplaysTheFollowingData(List<string> datas)
        {
            return datas[0] == driver.FindElement(truthOrDareMap.Title).Text &&
                   datas[1] == driver.FindElement(truthOrDareMap.SmallTitle).Text &&
                   datas[2] == driver.FindElement(truthOrDareMap.PlayersContainer).Text;
        }

        public void IEnterTheFollowingNames(List<string> namesList)
        {
            foreach (var item in namesList)
            {
                driver.FindElement(truthOrDareMap.PlayerNameInput).SendKeys(item);
                driver.FindElement(truthOrDareMap.AddPlayerButton).Click();
            }
        }

        public bool ThenTheNamesAreAdded(List<string> namesAdded)
        {
            return namesAdded[0] == driver.FindElement(truthOrDareMap.NamesAdded(1)).Text &&
                   namesAdded[1] == driver.FindElement(truthOrDareMap.NamesAdded(2)).Text &&
                   namesAdded[2] == driver.FindElement(truthOrDareMap.NamesAdded(3)).Text;
            ;
        }

        public void StartGame()
        {
            driver.FindElement(truthOrDareMap.StartGameBtn).Click();
        }

        public bool TheButtonIsVisible(string buttonName)
        {
            return driver.FindElement(truthOrDareMap.StartGameButtons(buttonName.ToLower())).Displayed;
        }

        public bool GameContainerReads(string value)
        {
            return value == driver.FindElement(truthOrDareMap.GameContainer).Text;
        }

        public bool IsEnterNamesFieldDisplayed()
        {
            return driver.FindElement(truthOrDareMap.SmallTitle).Displayed;
        }

        public void ClickButton(string buttonId)
        {
            driver.FindElement(truthOrDareMap.Buttons(buttonId)).Click();
        }
    }
}

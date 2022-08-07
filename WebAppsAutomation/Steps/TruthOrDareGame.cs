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

        public bool TheAppDisplaysTheFollowingData(List<string> datas)
        {
            return datas[0] == webDriver.FindElement(truthOrDareMap.Title).Text &&
                   datas[1] == webDriver.FindElement(truthOrDareMap.SmallTitle).Text &&
                   datas[2] == webDriver.FindElement(truthOrDareMap.PlayersContainer).Text;
        }

        public void IEnterTheFollowingNames(List<string> namesList)
        {
            foreach (var item in namesList)
            {
                webDriver.FindElement(truthOrDareMap.PlayerNameInput).SendKeys(item);
                webDriver.FindElement(truthOrDareMap.AddPlayerButton).Click();
            }
        }

        public bool ThenTheNamesAreAdded(List<string> namesAdded)
        {
            return namesAdded[0]==webDriver.FindElement(truthOrDareMap.NamesAdded(1)).Text &&
                   namesAdded[1]==webDriver.FindElement(truthOrDareMap.NamesAdded(2)).Text &&
                   namesAdded[2]==webDriver.FindElement(truthOrDareMap.NamesAdded(3)).Text;
                   ;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace WebAppsAutomation.PageElements
{
    public partial class TruthOrDareGameElements
    {
        public By Title => By.XPath("//*[@id='startContainer']/header/h1");

        public By SmallTitle => By.XPath("//*[@id='startContainer']/header/h2");

        public By PlayersContainer => By.XPath("//*[@id='startContainer']/header/p");

    }
}

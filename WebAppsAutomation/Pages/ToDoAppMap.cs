using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;


namespace WebAppsAutomation.Pages
{
    public partial class ToDoAppMap
    {
        public By dateField => By.XPath("//*[@id='date']");

        public By taskInput => By.XPath("//*[@id='particles-js']/div/div/div[1]/input");

        public By taskfieldAdded => By.XPath("//*[@id='particles-js']/div/div/div[2]/div");
    
        public By buttons(string buttonId) => By.XPath($"//*[@id='{buttonId}']");

        public By taskContent => By.XPath("//*[@id='particles-js']/div/div/div[2]/div/p");

        

    }
}

using SpecFlow;
using TechTalk.SpecFlow;
using WebAppsAutomation.Pages;
using FluentAssertions;

namespace WebAppsAutomation.StepDefinitions
{
    [Binding]
    public class ToDoAppSteps
    {
        ToDoApp _toDoApp = new ToDoApp();
        [Given(@"I have launched the ToDoApp")]
        public void GivenIHaveLaunchedTheToDoApp()
        {
            _toDoApp.IHaveLaunchedTheApp();
        }

        [Then(@"the date is set to today")]
        public void ThenTheDateIsSetToToday()
        {
            _toDoApp.DateIsSetToToday().Should().BeTrue();
           
        }



    }
}
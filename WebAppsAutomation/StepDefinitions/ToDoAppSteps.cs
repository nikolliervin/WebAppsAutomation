using SpecFlow;
using TechTalk.SpecFlow;
using WebAppsAutomation.Pages;
using FluentAssertions;

namespace WebAppsAutomation.StepDefinitions
{
    [Binding]
    public class ToDoAppSteps
    {
        private ToDoApp _toDoApp;
        public ToDoAppSteps(ToDoApp toDoApp)
        {
            _toDoApp = toDoApp;
        }
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
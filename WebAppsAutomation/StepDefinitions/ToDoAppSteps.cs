using SpecFlow;
using TechTalk.SpecFlow;
using WebAppsAutomation.Pages;

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

    }
}
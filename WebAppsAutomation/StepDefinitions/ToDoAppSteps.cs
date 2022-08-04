using SpecFlow;
using TechTalk.SpecFlow;
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

        [Given(@"I add the task '([^']*)'")]
        public void GivenIAddTheTask(string taskName)
        {
            _toDoApp.AddTheTask(taskName);
        }

        [Given(@"I click the '([^']*)' button")]
        public void GivenIClickInTheButton(string buttonName)
        {
            _toDoApp.ClickButton(buttonName);
        }

        [Then(@"'([^']*)' new task is added in the to do app")]
        public void ThenNewTaskIsAddedInTheToDoApp(int taskNumber)
        {
            _toDoApp.OneNewTaskIsAdded(taskNumber).Should().BeTrue();
        }

        [Then(@"all the tasks have been deleted")]
        public void ThenTheTasksFieldIsEmpty()
        {
            _toDoApp.ThenTheTasksFieldIsEmpty().Should().BeTrue();
        }

        [Then(@"'([^']*)' task is deleted")]
        public void ThenTheTaskIsDeleted(string theTaskName)
        {
            _toDoApp.ThenOneTaskIsDeleted(theTaskName).Should().BeFalse();  
        }

        [Given(@"the task input field is empty")]
        public void GivenTheTaskInputFieldIsEmpty()
        {
            _toDoApp.InputFieldIsEmpty().Should().BeTrue();
        }

        [Then(@"No task is added")]
        public void ThenNoTaskIsAdded()
        {
            _toDoApp.ThenNoTaskIsAdded().Should().BeTrue();
        }









    }
}
Feature: ToDoApp

Scenario: Check if today's date is correct
	Given I have launched the ToDoApp
	Then the date is set to today

Scenario: Add task to ToDoApp
	Given I have launched the ToDoApp
	And I add the task 'Meeting at 10pm'
	And I click the 'addBtn' button
	Then '1' new task is added in the to do app

Scenario: Delete All tasks
	Given I have launched the ToDoApp
	And I add the task 'Automate WebApps'
	And I click the 'addBtn' button
	And I add the task 'Order Food'
	And I click the 'addBtn' button
	And I click the 'clearBtn' button
	Then all the tasks have been deleted

Scenario: Delete a certain task
	Given I have launched the ToDoApp
	And I add the task 'Delete a Certain Task'
	And I click the 'addBtn' button
	And I add the task 'Start Coding'
	And I click the 'addBtn' button
	And I click the 'deleteTaskBtn' button
	Then 'Delete a Certain Task' task is deleted

Scenario: Adding a task when the field is empty
	Given I have launched the ToDoApp
	And the task input field is empty
	And I click the 'addBtn' button
	Then No task is added

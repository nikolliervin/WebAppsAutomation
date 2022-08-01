Feature: ToDoApp

Scenario: Check if today's date is correct
	Given I have launched the ToDoApp
	Then the date is set to today

Scenario: Add task to ToDoApp
	Given I have launched the ToDoApp
	And I add the task 'Task1'
	And I click the 'addBtn' button
	Then '1' new task is added in the to do app

Scenario: Delete All tasks
	Given I have launched the ToDoApp
	And I click the 'clearBtn' button


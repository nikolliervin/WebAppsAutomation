Feature: ToDoApp

Scenario: Check if today's date is correct
	Given I have launched the ToDoApp
	Then the date is set to "today's date"

#Scenario: Add task to ToDoApp
	#Given I have launched the ToDoApp
	#And I click in the 'TextBox'
	#And I click in the 'Add Task' button
	#Then '1' new task is added in the to do app

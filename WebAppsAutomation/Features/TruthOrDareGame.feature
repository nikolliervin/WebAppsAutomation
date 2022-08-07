Feature: TruthOrDareGame


Scenario: I have launched the TruthOrDare game
	Given I have launched the TruthOrDare game
	Then the app displays the following data
			| Field            | Value             |
			| Title            | Truth or Dare!    |
			| SmallTitle       | Enter your Names: |
			| PlayersContainer | Players:          |

Scenario: Adding player names to the app
	Given I have launched the TruthOrDare game
	And I enter the following names
			| Value |
			| John  |
			| Mark  |
			| Jim   |
	Then the players container has the names

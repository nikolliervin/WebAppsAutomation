Feature: TruthOrDareGame


Scenario: I have launched the TruthOrDare game
	Given I have launched the TruthOrDare game
	Then the app displays the following data
			| field            | value             |
			| Title            | Truth or Dare!    |
			| SmallTitle       | Enter your Names: |
			| PlayersContainer | Players:          |
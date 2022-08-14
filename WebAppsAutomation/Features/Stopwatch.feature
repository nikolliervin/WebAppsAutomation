Feature: Stopwatch

Scenario: Launching stopwatch and checking components
		Given I have launched the Stopwatch
		Then the following components are displayed:
		| Components |
		| Time       |
		| Start      |
		| Stop       |
		| Reset      |
		| Timer      |

Scenario: Clicking start in the stopwatch, starts the stopwatch
		Given I have launched the Stopwatch
		And I click the 'start' stopwatch button
		Then the stopwatch starts

Scenario: Clicking reset in the stopwatch resets the stopwatch
		Given I have launched the Stopwatch
		And I click the 'start' stopwatch button
		And I wait '3' seconds
		When I click the 'reset' stopwatch button
		Then the "timer" field displays "00:00:00"
﻿Feature: Stopwatch

Scenario: Launching stopwatch and checking components
		Given I have launched the Stopwatch
		Then the following components are displayed:
		| Components |
		| Time       |
		| Start      |
		| Stop       |
		| Reset      |
		| Timer      |

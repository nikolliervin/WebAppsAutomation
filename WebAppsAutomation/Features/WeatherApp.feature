Feature: WeatherApp

Scenario: Checking if default city is 'London'
	Given I have lauched the WeatherApp
	Then The default city is 'London, GB'

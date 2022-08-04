Feature: WeatherApp

Scenario: Checking if default city is 'London'
	Given I have launched the WeatherApp
	Then The default city is 'London, GB'

Scenario: Checking the weather for a city
	Given I have launched the WeatherApp
	When I search for 'Tirana'
	Then The city name is set to 'Tirana, AL'




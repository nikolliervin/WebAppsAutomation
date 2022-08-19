Feature: PasswordGenerator
		

Scenario: Generating a password
	Given I have launched the Password Generator
	And I click on 'generate' button
	Then the password shows in the 'password' container

#Scenario: Copying a password by copy button
#	Given I have launched the Password Generator
#	And I click on 'generate' button
#	When I click on 'copy' button
#	Then the 'password' value is on the clipboard

Scenario: Check if the password default lenght is 16 characters
	Given I have launched the Password Generator
	And I click on 'generate' button
	Then the 'password' lenght is '16' characters long

Scenario: Password does not contain numbers when numbers is unchecked
	Given I have launched the Password Generator
	And I uncheck 'number' tick
	When I click on 'generate' button
	Then the 'password' does not contain a 'number'

Scenario: Password does not contain symbols when symbols is unchecked
	Given I have launched the Password Generator
	And I uncheck 'symbol' tick
	When I click on 'generate' button
	Then the 'password' does not contain a 'symbol'

Scenario: Password does not contain Uppercase when upercase is unchecked
	Given I have launched the Password Generator
	And I uncheck 'uppercase' tick
	When I click on 'generate' button
	Then the 'password' does not contain a 'uppercase'

Scenario: Passoword does not contain Lowercase when lowercase is unchecked
	Given I have launched the Password Generator
	And I uncheck 'lowercase' tick
	When I click on 'generate' button
	Then the 'password' does not contain a 'lowercase'
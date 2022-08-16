Feature: PasswordGenerator
		

Scenario: Generating a password
	Given I have launched the Password Generator
	And I click on 'generate' button
	Then the password shows in the 'password' container

Scenario: Copying a password by copy button
	Given I have launched the Password Generator
	And I click on 'generate' button
	When I click on 'copy' button
	Then the 'password' value is on the clipboard


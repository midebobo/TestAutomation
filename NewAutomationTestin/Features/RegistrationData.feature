Feature: RegistrationData

Navigating to the Website to see if user can register

@tag1
Scenario: Data Registration
	Given I Navigate to "https://angularjs.realworld.io/#/register"
	And I Click on Sign Up
	And I enter my Username "Midebobo"
	And I enter my Email "midebobo@demo.com"
	And I enter my Password "mide00"
	When I Click on the Sign up Button
	Then I should be to register successfully
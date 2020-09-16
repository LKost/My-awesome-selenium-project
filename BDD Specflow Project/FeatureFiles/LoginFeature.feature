Feature: LoginFeature
	Login functionality according
	to JIRA: TC ### 
	https://jira.com

@mytag
Scenario: Wrong credentials
	Given I'm on Main page
	When I try to login with wrong credentials 
	Then I can see popup message with warning text 'Ошибка'
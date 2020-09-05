Feature: ScrollFeature
	Test verify footer text
	using scroll JS step according to
	according to JIRA: TC ### 
	https://jira.com
	

@mytag
Scenario: Verify footer data is correct
	Given I'm on main page
	When I scroll to footer section
	Then The footer text display correct '2020' text
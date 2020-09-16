Feature: MenuFeature
	To ensure that all items are present
	we match verify all amoungth and 
	menu item text according to 
	///......

@mytag
Scenario: Verify menu items count/text
	Given We are on Main page
	When we count number menu items
	Then we should get '10' items
	When we get menu items text from each item
	Then Items text should be equals with expected
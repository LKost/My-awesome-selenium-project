Feature: CheckboxFilterFeature
	Verify work of checkbox filter
	on quadrocopters page, should 
	filter specific king of product according
	///...

@mytag
Scenario: Verify quadrocopter filter
	Given User is opening quadrocopters 'https://www.xiaomi.ua/quadrocopters-and-droids/' url
	And click on Brand Filter
	When user click on checkbox Mi
	Then expected quadrocopters with appropriate titles should be displayed on page
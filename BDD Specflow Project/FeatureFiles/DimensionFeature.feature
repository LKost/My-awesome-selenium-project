Feature: DimensionFeature
	In order to avoid mistakes in future
	Verify setting dimention functionallity
	according ... 

@mytag
Scenario: Change dimention
	Given open browser window
	And get dimension size of full screen
	When I change dimention resolutun to custom
	Then resolution should be differe from initial
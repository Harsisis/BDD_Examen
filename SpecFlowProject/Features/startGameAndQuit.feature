Feature: user

A short summary of the feature

@tag1
Scenario: Verify two entries and fill and fill player names and clic on play button
	Given the first player is Martin
	And the second player is Maurice
	When the player name are string
	And the textboxes are filled
	Then click on play button

Feature: MultipleWindows

Background: Preconditions
    Given I open the main page of the internet hero ku app

Scenario: Open a new page from multiple windows link
	When I click on 'Multiple Windows'
	Then the page should be open
	When I click on the Click here
	Then a new page should be open


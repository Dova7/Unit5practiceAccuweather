Feature: RecentLocations
	As a user, 
	I want to search for a city's weather 
	so that I can view accurate weather forecasts.
	after going back to main page city should be saved in recent locations.
	after clicking same city in recent locations.
	I should be able to view same forecast.

Background: Preconditions
    Given I open the main page of AccuWeather

Scenario: Search for city and verify recent locations functionality
    When I consent to data usage
	And I enter 'London' in the search field
	And I click on the '1' search result
	And I go back to the main page
	Then Main page of AccuWeather is displayed
	When I click on the '1' recent location
	Then the city weather page header contains 'London'

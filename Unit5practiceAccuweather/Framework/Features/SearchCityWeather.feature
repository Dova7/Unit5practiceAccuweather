Feature: SearchCityWeather
  As a user, 
  I want to search for a city's weather 
  so that I can view accurate weather forecasts.

Background: Preconditions
    Given I open the main page of AccuWeather

Scenario: Search for city and navigate to its weather page
    When I consent to data usage
    And I enter 'New York' in the search field
    Then I see a list of search results
    When I click on the '1' search result
    Then the city weather page header contains 'New York'

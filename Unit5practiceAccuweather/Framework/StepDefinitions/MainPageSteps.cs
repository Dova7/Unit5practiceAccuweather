using Reqnroll;
using Unit5practiceAccuweather.Framework.Pages;

namespace Unit5practiceAccuweather.Framework.StepDefinitions
{
    [Binding]
    public class MainPageSteps
    {
        AccuweatherMainPage mainPage = new AccuweatherMainPage();

        [Given(@"I open the main page of AccuWeather")]
        public void GivenIOpenTheMainPageOfAccuWeather()
        {
            Assert.That(mainPage.State.WaitForDisplayed(), Is.True, "Main page is not displayed");
        }

        [Then(@"Main page of AccuWeather is displayed")]
        public void ThenMainPageOfAccuWeatherIsDisplayed()
        {
            Assert.That(mainPage.State.WaitForDisplayed(), Is.True, "Main page is not displayed");
        }

        [When(@"I consent to data usage")]
        public void WhenIConsentToDataUsage()
        {
            mainPage.ClickDataConsentButton();
        }

        [When(@"I enter '(.*)' in the search field")]
        public void WhenIEnterInTheSearchField(string cityName)
        {
            mainPage.ClickSearchBar();
            mainPage.SendKeysToSearchBar(cityName);
        }

        [Then(@"I see a list of search results")]
        public void ThenISeeAListOfSearchResults()
        {
            Assert.That(mainPage.IsSearchResultsDisplayed(), Is.True, "Search results are not displayed");
        }

        [When(@"I click on the '(.*)' search result")]
        public void WhenIClickOnTheSearchResult(string index)
        {            
            mainPage.SelectSearchResult(int.Parse(index)-1);
        }
        [When(@"I click on the '(.*)' recent location")]
        public void WhenIClickOnTheRecentLocation(string index)
        {
            mainPage.SelectSearchResult(int.Parse(index) - 1);
        }

    }
}

using Aquality.Selenium.Elements;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace Unit5practiceAccuweather.Framework.Pages
{
    public class AccuweatherMainPage : Form
    {
        private static readonly By _searchBarLocator = By.ClassName("search-input");
        private static readonly ITextBox _searchBar = ElementFactory.GetTextBox(_searchBarLocator, "Search Bar");

        private static readonly By _dataConsentButtonLocator = By.ClassName("banner-button");
        private static readonly IButton _dataConsentButton = ElementFactory.GetButton(_dataConsentButtonLocator, "Data Consent Button");

        private static readonly By _searchResults = By.CssSelector(".results-container .search-bar-result");

        private static readonly By _recentLocations = By.ClassName("recent-location-item");

        public AccuweatherMainPage() : base(_searchBarLocator, "City Weather Page")
        {
            
        }

        public void ClickDataConsentButton()
        {
            _dataConsentButton.Click();
        }

        public void ClickSearchBar()
        {
            _searchBar.Click();
        }

        public void SendKeysToSearchBar(string text)
        {
            _searchBar.SendKeys(text);
        }

        public IList<ILink> GetSearchResults()
        {
            return ElementFactory.FindElements<ILink>(_searchResults, "Search Result list");
        }

        public bool IsSearchResultsDisplayed()
        {
            return ElementFactory.GetLabel(_searchResults, "Search Results").State.WaitForDisplayed();
        }

        public void SelectSearchResult(int index)
        {
            if (IsSearchResultsDisplayed())
            {
                var results = GetSearchResults();
                results[index].Click();
            }
        }

        public IList<ILink> GetRecentLocations()
        {
            return ElementFactory.FindElements<ILink>(_recentLocations, "Recent Location list");
        }

        public void SelectRecentLocation(int index)
        {
            var locations = GetRecentLocations();
            locations[index].Click();
        }
    }
}

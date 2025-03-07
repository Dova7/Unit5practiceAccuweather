using Reqnroll;
using Unit5practiceAccuweather.Framework.Pages;

namespace Unit5practiceAccuweather.Framework.StepDefinitions
{
    [Binding]
    public class CityWeatherPageSteps
    {
        CityWeatherPage cityWeatherPage = new CityWeatherPage();

        [Then(@"the city weather page header contains '(.*)'")]
        public void ThenTheCityWeatherPageHeaderContainsCityNameIEntered(string cityName)
        {
            Assert.That(cityWeatherPage.GetCityName().Contains(cityName), Is.True, "City name is not displayed in the header");
        }

        [When("I go back to the main page")]
        public void WhenIGoBackToTheMainPage()
        {
            cityWeatherPage.State.WaitForDisplayed();
            cityWeatherPage.GoBackToMainPage();
        }
    }
}

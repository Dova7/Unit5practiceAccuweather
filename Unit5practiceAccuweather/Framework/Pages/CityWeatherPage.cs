using Aquality.Selenium.Browsers;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace Unit5practiceAccuweather.Framework.Pages
{
    public class CityWeatherPage : Form
    {
        private static readonly By _todaysWeatherCard = By.ClassName("card-header");

        private static readonly By _cityNameLocator = By.ClassName("recent-location-item");
        private static readonly ILabel _cityName = ElementFactory.GetLabel(_cityNameLocator, "City name");

        public CityWeatherPage() : base(_todaysWeatherCard, "City weather page")
        {

        }

        public string GetCityName()
        {
            return _cityName.Text;
        }

        public void GoBackToMainPage()
        {
            AqualityServices.Browser.Driver.Navigate().Back();
        }
    }
}

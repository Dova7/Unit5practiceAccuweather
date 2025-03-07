using Aquality.Selenium.Browsers;
using Aquality.Selenium.Core.Utilities;
using Reqnroll;

namespace Unit5practiceAccuweather.Framework.Hooks
{
    [Binding]
    public class Hooks
    {
        private readonly Browser _browser = AqualityServices.Browser;
        private static readonly JsonSettingsFile _settings = new JsonSettingsFile("config.json");

        [BeforeScenario]
        public void Setup()
        {
            _browser.Maximize();
            _browser.GoTo(_settings.GetValue<string>("url"));
        }

        [AfterScenario]
        public void TearDown()
        {
            _browser.Quit();
        }

    }
}

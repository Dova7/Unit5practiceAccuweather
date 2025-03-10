using Aquality.Selenium.Browsers;
using Aquality.Selenium.Core.Utilities;
using Reqnroll;

namespace Unit5practiceAccuweather.Framework.Hooks
{
    [Binding]
    public class Hooks
    {
        
        private Browser _browser = null!;
        private static readonly JsonSettingsFile _settings = new JsonSettingsFile("config.json");

        public Hooks()
        {
            string browserName = Environment.GetEnvironmentVariable("browserName") ?? "chrome";
            Environment.SetEnvironmentVariable("browserName", browserName);

        }

        [BeforeScenario]
        public void Setup()
        {
            _browser = AqualityServices.Browser;
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

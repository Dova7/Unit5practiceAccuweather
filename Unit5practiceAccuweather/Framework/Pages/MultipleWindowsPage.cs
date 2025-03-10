using Aquality.Selenium.Browsers;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using Unit5practiceAccuweather.Framework.Utils;

namespace Unit5practiceAccuweather.Framework.Pages
{
    public class MultipleWindowsPage : Form
    {
        private static readonly By _multipleWindowsPageLocator = By.ClassName("example");

        private static readonly By _clickHereLocator = By.XPath(string.Format(LocatorConstants._preciseTextLocator, "Click Here"));
        private static readonly ILink _clickHere = ElementFactory.GetLink(_clickHereLocator, "click here link");

        public MultipleWindowsPage() : base(_multipleWindowsPageLocator, "Multiple Windows Page")
        {
            
        }

        public void ClickClickHere()
        {
            _clickHere.Click();
        }

        public bool IsNewTabOpen()
        {
            var tabs = AqualityServices.Browser.Tabs();
            int tabCount = tabs.Handles.Count();

            return tabCount > 1;
        }
    }
}

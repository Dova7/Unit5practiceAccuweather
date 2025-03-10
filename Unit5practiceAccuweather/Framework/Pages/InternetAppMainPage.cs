using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit5practiceAccuweather.Framework.Utils;

namespace Unit5practiceAccuweather.Framework.Pages
{
    public class InternetAppMainPage : Form
    {
        private static readonly By _mainPageLocator = By.XPath(string.Format(LocatorConstants._preciseTextLocator, "Welcome to the-internet"));

        private ILink navigationLink(string navigation) => ElementFactory.GetLink(
            By.XPath(string.Format(LocatorConstants._preciseTextLocator, navigation)), "Navigation link");

        public InternetAppMainPage() : base(_mainPageLocator,"Main Page")
        {
            
        }

        public void ClickNavigationLink(string navigationName)
        {
            navigationLink(navigationName).Click();
        }
    }
}

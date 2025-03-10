using Reqnroll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit5practiceAccuweather.Framework.Pages;

namespace Unit5practiceAccuweather.Framework.StepDefinitions
{
    [Binding]
    public class InternetAppMainPageSteps
    {
        InternetAppMainPage mainPage = new InternetAppMainPage();

        [Given(@"I open the main page of the internet hero ku app")]
        public void GivenIOpenTheMainPageOfTheInternetHeroKuApp()
        {
            Assert.That(mainPage.State.WaitForDisplayed(), Is.True, "Main page is not open");
        }

        [When(@"I click on '(.*)'")]
        public void WhenIClickOn(string navigation)
        {
            mainPage.ClickNavigationLink(navigation);
        }

    }
}

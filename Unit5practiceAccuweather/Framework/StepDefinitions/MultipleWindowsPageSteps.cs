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
    public class MultipleWindowsPageSteps
    {
        MultipleWindowsPage multipleWindowsPage = new MultipleWindowsPage();

        [Then(@"the page should be open")]
        public void ThenThePageShouldBeOpen()
        {
            Assert.That(multipleWindowsPage.State.WaitForDisplayed(), Is.True, "multiple windows page is not displayed");
        }

        [When("I click on the Click here")]
        public void WhenIClickOnTheClickHere()
        {
            multipleWindowsPage.ClickClickHere();
        }

        [Then("a new page should be open")]
        public void ThenANewPageShouldBeOpen()
        {
            Assert.That(multipleWindowsPage.IsNewTabOpen(), Is.True, "new tab is not open");
        }

    }
}

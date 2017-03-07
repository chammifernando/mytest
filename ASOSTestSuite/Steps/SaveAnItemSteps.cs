using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ASOSTestSuite.PageObjects;
using Assert = NUnit.Framework.Assert;

namespace ASOSTestSuite.Steps
{
    [Binding]
    public class UseTheWebsiteToSaveAnItemForLaterSteps
    {
        IWebDriver driver = new ChromeDriver();

        [When(@"I save an item for later")]
        public void WhenISaveAnItemForLater()
        {
            SearchPage searchPage = new SearchPage(driver);
            searchPage.SaveAnItem();
        }
        
        [Then(@"I should see that item is saved")]
        public void ThenIShouldSeeThatItemIsSaved()
        {
            ScenarioContext.Current.Pending();
        }
    }
}

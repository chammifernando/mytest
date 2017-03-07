using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ASOSTestSuite.PageObjects;
using Assert = NUnit.Framework.Assert;

namespace ASOSTestSuite.Steps
{
    [Binding]
    public class UseTheWebsiteToFindShirtsSteps
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"I want to order a shirt")]
        public void GivenIWantToOrderAShirt()
        {
            driver.Navigate().GoToUrl("http://www.asos.com/");
        }
        

        [When(@"I search for ""(.*)""")]
        public void WhenISearchFor(string searchParameter)
        {
            SearchPage searchPage = new SearchPage(driver);
            searchPage.Search(searchParameter);
        }


        [Then(@"I should see some purple t shirts")]
        public void ThenIShouldSeeSomePurpleTShirts()
        {
            string SearchTerm = driver.FindElement(By.ClassName("search-term")).Text;
            Assert.IsTrue(SearchTerm.Contains("Purple T Shirt"));

            driver.Close();
            driver.Dispose();
        }
    }
}

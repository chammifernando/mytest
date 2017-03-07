using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ASOSTestSuite.PageObjects;
using Assert = NUnit.Framework.Assert;


namespace ASOSTestSuite.Steps
{
    [Binding]
    public class UseTheWebsiteToChangeHowSearchResultsAreDisplayedSteps
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"I have searched for yellows t shirts on the Australian store")]
        public void GivenIHaveSearchedForYellowsTShirtsOnTheAustralianStore()
        {
            SearchPage searchPage = new SearchPage(driver);
            searchPage.ChangeStore();
            System.Threading.Thread.Sleep(3000);
            searchPage.SearchYellowTShirt();
            System.Threading.Thread.Sleep(3000);
        }

        [Given(@"I have some yellow t shirts displayed")]
        public void GivenIHaveSomeYellowTShirtsDisplayed()
        {
            string SearchTerm = driver.FindElement(By.ClassName("search-term")).Text;
            Assert.IsTrue(SearchTerm.Contains("Yellow T Shirt"));
        }
        
        [When(@"I organize them in four columns")]
        public void WhenIOrganizeThemInFourColumns()
        {
            SearchPage searchPage = new SearchPage(driver);
            searchPage.ChangeDisplauColumns();
        }
        
        [Then(@"I should see some yellow t shirts organized in four columns")]
        public void ThenIShouldSeeSomeYellowTShirtsOrganizedInFourColumns()
        {
            string DisplayColumns = driver.FindElement(By.ClassName("display-options")).Text;
            Assert.IsTrue(!DisplayColumns.Contains("regular active"));
            //string SearchTerm = driver.FindElement(By.ClassName("product product-link ")).;
            //Assert.IsTrue(SearchTerm.Contains("Yellow T Shirt"));

            driver.Close();
            driver.Dispose();
        }
    }
}

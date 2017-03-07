using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ASOSTestSuite.PageObjects;
using Assert = NUnit.Framework.Assert;


namespace ASOSTestSuite.Steps
{
    [Binding]
    public class SearchTShirtsAUStoreSteps
    {
        IWebDriver driver = new ChromeDriver();

        [When(@"I search for yellow t shirts in the Australian store")]
        public void WhenISearchForYellowTShirtsInTheAustralianStore()
        {
            SearchPage searchPage = new SearchPage(driver);
            searchPage.ChangeStore();
            System.Threading.Thread.Sleep(3000);
            searchPage.SearchYellowTShirt();
        }
        
        [Then(@"I should see some yellow t shirts")]
        public void ThenIShouldSeeSomeYellowTShirts()
        {
            string SearchTerm = driver.FindElement(By.ClassName("search-term")).Text;
            Assert.IsTrue(SearchTerm.Contains("Yellow T Shirt"));

            driver.Close();
            driver.Dispose();
        }
    }
}

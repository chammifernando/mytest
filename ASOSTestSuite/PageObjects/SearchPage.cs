using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;


namespace ASOSTestSuite.PageObjects
{
    public class SearchPage
    {
        private readonly IWebDriver driver;

        // Page Elements
        private readonly By searchBarInput = By.Id("txtSearch");

        // Methods
        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Search(string searchParameter)
        {
            IWebElement searchBar = driver.FindElement(searchBarInput);
            searchBar.SendKeys(searchParameter);
            searchBar.SendKeys(Keys.Return);
        }

        public void ChangeStore()
        {
            driver.Navigate().GoToUrl("http://www.asos.com/");

            var ausStore = driver.FindElement(By.XPath(".//*[@id='BodyTag']/div[4]/div/footer/div[2]/div[2]/div[2]/ul/li[6]/a/span"));
            ausStore.Click();   
        }

        public void SearchYellowTShirt()
        {
            IWebElement searchBar = driver.FindElement(By.Id("txtSearch"));
            searchBar.SendKeys("yellow t shirt");
            searchBar.SendKeys(Keys.Return);
        }

        public void ChangeDisplauColumns()
        {
            var displayColumns = driver.FindElement(By.XPath(".//*[@id='productlist-results']/div/div[3]/p[2]/a[2]"));
            displayColumns.Click();
        }

        public void SaveAnItem()
        {
            var selectAnItem = driver.FindElement(By.XPath(".//*[@id='productlist-results']/div/div[4]/ul/li[1]/a/div[1]/img"));
            selectAnItem.Click();
            System.Threading.Thread.Sleep(3000);
            var saveAnItem = driver.FindElement(By.XPath(".//*[@id='product-save']/div/a/span[2]"));
            saveAnItem.Click();

        }
    }
}

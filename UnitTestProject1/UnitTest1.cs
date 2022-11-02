using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.ObjectModel;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://google.com");

            IWebElement element = driver.FindElement(By.Id("gbqfq"));
            element.SendKeys("selenium webdriver");

            // Get the search results panel that contains the link for each result.
            IWebElement resultsPanel = driver.FindElement(By.Id("search"));

            // Get all the links only contained within the search result panel.
            ReadOnlyCollection<IWebElement> searchResults = resultsPanel.FindElements(By.XPath(".//a"));

            // Print the text for every link in the search results.
            foreach (IWebElement result in searchResults)
            {
                Console.WriteLine(result.Text);
            }

        }
    }
}

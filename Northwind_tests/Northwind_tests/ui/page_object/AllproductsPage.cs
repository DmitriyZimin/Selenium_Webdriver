using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Northwind_tests
{
    class AllproductsPage
    {
        private IWebDriver driver;
        
        public AllproductsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement Allproductsheader => driver.FindElement(By.XPath("//h2[contains(.,'All Products')]"));
        public string GetAllproductsheader()
        {
            return Allproductsheader.Text;
        }

        public ProductPage ProductEditingPage()
        {
            driver.FindElement(By.XPath("//a[contains(text(),'Create new')]")).Click();
            return new ProductPage(driver);
        }
        public ProductPage ViewingItem(string item)
        {
            driver.FindElement(By.XPath($"//a[contains(text(), \"{item}\")]")).Click();
            return new ProductPage(driver);
        }

        public AllproductsPage DeletingItem(string item)
        {
            driver.FindElement(By.XPath($"//a[contains(text(), \"{item}\")]/following::td[10]/a")).Click();
            driver.SwitchTo().Alert().Accept();
            return new AllproductsPage(driver);
        }

        public bool CheckItemNotPresent(string item)
        {
            try
            {
                driver.FindElement(By.XPath($"//a[contains(text(),\"{item}\")]"));
                return true;
               
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

    }
}

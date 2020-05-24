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
        private readonly By _Englishtea = By.XPath("//a[contains(text(),'English tea')]");

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
        public ProductPage ViewingItem()
        {
            driver.FindElement(By.XPath("//a[contains(text(),'English tea')]")).Click();
            return new ProductPage(driver);
        }

        public AllproductsPage DeletingItem()
        {
            driver.FindElement(By.XPath("//a[contains(text(),'English tea')]/following::td[10]/a")).Click();
            driver.SwitchTo().Alert().Accept();
            return new AllproductsPage(driver);
        }

        public bool CheckItemNotPresent()
        {
            try
            {
                driver.FindElement(_Englishtea);
                return true;
               
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

    }
}

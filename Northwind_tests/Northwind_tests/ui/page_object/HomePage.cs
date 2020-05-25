using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind_tests
{
    class HomePage
    {
        private IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement Homepageheader => driver.FindElement(By.XPath("//h2[contains(.,'Home page')]"));
        private IWebElement Logoutbutton => driver.FindElement(By.XPath("//a[contains(text(),'Logout')]"));

        public string GetHomepageheader()
        {
            return Homepageheader.Text;
        }
        public AllproductsPage Allproducts()
        {
            driver.FindElement(By.XPath("//a[contains(text(),'All Products')]")).Click();
            return new AllproductsPage(driver);
        }
        public LogoutPage Logout()
        {
            new Actions(driver).Click(Logoutbutton).Build().Perform();
            return new LogoutPage(driver);
        }
    }
}

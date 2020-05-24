using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind_tests
{
    class LogoutPage
    {
        private IWebDriver driver;
        public LogoutPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement Loginheader => driver.FindElement(By.XPath("//h2[contains(.,'Login')]"));

        public string GetLoginheader()
        {
            return Loginheader.Text;
        }
    }
}

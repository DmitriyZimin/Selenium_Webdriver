using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind_tests
{
    class LoginPage
    {
        private IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement NameInput => driver.FindElement(By.XPath("//input[@id='Name']"));

        private IWebElement PasswordInput => driver.FindElement(By.XPath("//input[@id='Password']"));
                
        public HomePage AuthorizationPage(string login, string password)
        {
            NameInput.SendKeys(login);
            PasswordInput.SendKeys(password);
            new Actions(driver).SendKeys(Keys.Enter).Build().Perform();
            return new HomePage(driver);
        }
    }
}

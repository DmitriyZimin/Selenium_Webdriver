using Northwind_tests.business_object;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind_tests.service.ui
{
    class LoginService
    {
        public static HomePage Login(LoginPassword user, IWebDriver driver)
        {
            LoginPage loginPage = new LoginPage(driver);
            return loginPage.AuthorizationPage(user.selectLogin, user.selectPassword);
                        
        }
    }
}

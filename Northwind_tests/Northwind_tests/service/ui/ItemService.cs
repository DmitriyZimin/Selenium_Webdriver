using Northwind_tests.business_object;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind_tests.service.ui
{
    class ItemService
    {
        public static AllproductsPage OpenAllProducts(IWebDriver driver)
        {
            HomePage homePage = new HomePage(driver);
            return homePage.Allproducts();
            
        }
    }
}

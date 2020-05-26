using Northwind_tests.business_object;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind_tests.service.ui
{
    class NewItemService
    {
        public static AllproductsPage Add(ItemAdd item, IWebDriver driver)
        {
            HomePage homePage = new HomePage(driver);
            homePage.Allproducts();
            AllproductsPage allproductsPage = new AllproductsPage(driver);
            allproductsPage.ProductEditingPage();
            ProductPage productPage = new ProductPage(driver);
            return productPage.AddingProduct(item.selectName, item.selectCategory, item.selectSupplier, item.selectPrice, item.selectQuantity, item.selectInstock, item.selectOnorder, item.selectReorder);
            
        }
    }
}

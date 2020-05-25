using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind_tests
{
    class ProductPage
    {
        private IWebDriver driver;
        public ProductPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement ProductNameInput => driver.FindElement(By.XPath("//input[@id='ProductName']"));
        private IWebElement CategoryIdInput => driver.FindElement(By.XPath("//select[@id='CategoryId']"));
        private IWebElement SupplierIdInput => driver.FindElement(By.XPath("//select[@id='SupplierId']"));
        private IWebElement UnitPriceInput => driver.FindElement(By.XPath("//input[@id='UnitPrice']"));
        private IWebElement QuantityPerUnitInput => driver.FindElement(By.XPath("//input[@id='QuantityPerUnit']"));
        private IWebElement UnitsInStockInput => driver.FindElement(By.XPath("//input[@id='UnitsInStock']"));
        private IWebElement UnitsOnOrderInput => driver.FindElement(By.XPath("//input[@id='UnitsOnOrder']"));
        private IWebElement ReorderLevelInput => driver.FindElement(By.XPath("//input[@id='ReorderLevel']"));
        
        public AllproductsPage AddingProduct(string name, string category, string supplier, string price, string quantity, string instock, string onorder, string reorder)
        {
            ProductNameInput.SendKeys(name);
            CategoryIdInput.SendKeys(category);
            SupplierIdInput.SendKeys(supplier);
            UnitPriceInput.SendKeys(price);
            QuantityPerUnitInput.SendKeys(quantity);
            UnitsInStockInput.SendKeys(instock);
            UnitsOnOrderInput.SendKeys(onorder);
            ReorderLevelInput.SendKeys(reorder);
            new Actions(driver).SendKeys(Keys.Enter).Build().Perform();
            return new AllproductsPage(driver);
        }

        public string ProductName()
        {
            return ProductNameInput.GetAttribute("value");
        }
        public string CategoryId()
        {
            return CategoryIdInput.GetAttribute("value");
        }
        public string SupplierId()
        {
            return SupplierIdInput.GetAttribute("value");
        }
        public string UnitPrice()
        {
            return UnitPriceInput.GetAttribute("value");
        }
        public string QuantityPerUnit()
        {
            return QuantityPerUnitInput.GetAttribute("value");
        }
        public string UnitsInStock()
        {
            return UnitsInStockInput.GetAttribute("value");
        }
        public string UnitsOnOrder()
        {
            return UnitsOnOrderInput.GetAttribute("value");
        }
        public string ReorderLevel()
        {
            return ReorderLevelInput.GetAttribute("value");
        }

        public AllproductsPage Allproducts()
        {
            driver.FindElement(By.XPath("//a[contains(text(),'All Products')]")).Click();
            return new AllproductsPage(driver);
        }
    }
}

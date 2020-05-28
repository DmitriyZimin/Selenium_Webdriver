using Northwind_tests.business_object;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Northwind_tests.step_definition
{
    [Binding]
    class ItemSteps
    {
        private IWebDriver driver;

        [Given(@"I open ""(.*)"" url")]
        public void GivenIOpenUrl(string url)
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = url;
        }

        [When(@"I type in Name field ""(.*)"" login, Password field ""(.*)"" password")]
        public void WhenITypeInLoginPassword(string login, string password)
        {
            new LoginPage(driver).AuthorizationPage(new LoginPassword(login, password));
        }

        [When(@"I click on submit button to log in")]
        public void WhenIClickOnSubmitButton()
        {
            new LoginPage(driver).ClickSubmitButton();
        }

        [When(@"I click on 'All products' button")]
        public void WhenIClickOnAllproductsButton()
        {
            new HomePage(driver).Allproducts();
        }

        [When(@"I click on 'Create new' button")]
        public void WhenIClickOnCreatenewButton()
        {
            new AllproductsPage(driver).ProductEditingPage();
        }

        [When(@"I type in ProductName field ""(.*)"" name")]
        public void WhenITypeInProductName(string name)
        {
            new ProductPage(driver).AddingName(new ItemAdd(name, null, null, null, null, null, null, null));
        }

        [When(@"I select ""(.*)"" category")]
        public void WhenISelectCategory(string category)
        {
            new ProductPage(driver).AddingCategory(new ItemAdd(null, category, null, null, null, null, null, null));
        }

        [When(@"I select ""(.*)"" supplier")]
        public void WhenISelectSupplier(string supplier)
        {
            new ProductPage(driver).AddingSupplier(new ItemAdd(null, null, supplier, null, null, null, null, null));
        }

        [When(@"I type in UnitPrice field ""(.*)"" price")]
        public void WhenITypeInUnitPrice(string price)
        {
            new ProductPage(driver).AddingUnitPrice(new ItemAdd(null, null, null, price, null, null, null, null));
        }

        [When(@"I type in QuantityPerUnit field ""(.*)"" quantity")]
        public void WhenITypeInQuantityPerUnit(string quantity)
        {
            new ProductPage(driver).AddingQuantity(new ItemAdd(null, null, null, null, quantity, null, null, null));
        }

        [When(@"I type in UnitsInStock field ""(.*)"" quantity")]
        public void WhenITypeInUnitsInStock(string quantity)
        {
            new ProductPage(driver).AddingUnitsInStock(new ItemAdd(null, null, null, null, null, quantity, null, null));
        }

        [When(@"I type in UnitsOnOrder field ""(.*)"" quantity")]
        public void WhenITypeInUnitsOnOrder(string quantity)
        {
            new ProductPage(driver).AddingUnitsOnOrder(new ItemAdd(null, null, null, null, null, null, quantity, null));
        }

        [When(@"I type in ReorderLevel field ""(.*)"" level")]
        public void WhenITypeInReorderLevel(string level)
        {
            new ProductPage(driver).AddingReorderLevel(new ItemAdd(null, null, null, null, null, null, null, level));
        }

        [When(@"I click on submit button to add an item")]
        public void WhenIClickOnSubmitAddingButton()
        {
            new ProductPage(driver).clickSubmitButton();
        }

        [Then(@"All products page should be opened with ""(.*)"" header")]
        public void ThenAllproductspageShouldBe(string allproductsHeader)
        {
            Assert.AreEqual(allproductsHeader, new AllproductsPage(driver).GetAllproductsheader());
        }
    }
}

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Northwind_tests
{
    public class Tests
    {
        private IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000");
            driver.Manage().Window.Maximize();
                        
        }

        [SetUp]
        public void Setup1()
        {
            driver.FindElement(By.XPath("//input[@id='Name']")).SendKeys("user");
            driver.FindElement(By.XPath("//input[@id='Password']")).SendKeys("user");
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();

        }

        [Test]
        public void Login()
        {
            var login = driver.FindElement(By.XPath("//h2[contains(.,'Home page')]"));
            Assert.AreEqual("Home page", login.Text);
        }

        [Test]
        public void AddVerifyItem()
        {                   
            driver.FindElement(By.XPath("//a[contains(text(),'All Products')]")).Click();
            driver.FindElement(By.XPath("//a[contains(text(),'Create new')]")).Click();
            driver.FindElement(By.XPath("//input[@id='ProductName']")).Click();
            driver.FindElement(By.XPath("//input[@id='ProductName']")).SendKeys("English tea");
            driver.FindElement(By.XPath("//select[@id='CategoryId']")).Click();
            driver.FindElement(By.XPath("//select[@id='CategoryId']")).SendKeys("Beverages");
            driver.FindElement(By.XPath("//select[@id='SupplierId']")).Click();
            driver.FindElement(By.XPath("//select[@id='SupplierId']")).SendKeys("Mayumi's");
            driver.FindElement(By.XPath("//input[@id='UnitPrice']")).Click();
            driver.FindElement(By.XPath("//input[@id='UnitPrice']")).SendKeys("500");
            driver.FindElement(By.XPath("//input[@id='QuantityPerUnit']")).Click();
            driver.FindElement(By.XPath("//input[@id='QuantityPerUnit']")).SendKeys("15");
            driver.FindElement(By.XPath("//input[@id='UnitsInStock']")).Click();
            driver.FindElement(By.XPath("//input[@id='UnitsInStock']")).SendKeys("10");
            driver.FindElement(By.XPath("//input[@id='UnitsOnOrder']")).Click();
            driver.FindElement(By.XPath("//input[@id='UnitsOnOrder']")).SendKeys("5");
            driver.FindElement(By.XPath("//input[@id='ReorderLevel']")).Click();
            driver.FindElement(By.XPath("//input[@id='ReorderLevel']")).SendKeys("1");
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();
            var additem = driver.FindElement(By.XPath("//h2[contains(.,'All Products')]"));
            Assert.AreEqual("All Products", additem.Text);
                                
            driver.FindElement(By.XPath("//a[contains(text(),'English tea')]")).Click();
            var ProductName = driver.FindElement(By.XPath("//input[@id='ProductName']"));
            Assert.AreEqual(ProductName.GetAttribute("value"), "English tea");
            var CategoryId = driver.FindElement(By.XPath("//select[@id='CategoryId']"));
            Assert.AreEqual(CategoryId.GetAttribute("value"), "1");
            var SupplierId = driver.FindElement(By.XPath("//select[@id='SupplierId']"));
            Assert.AreEqual(SupplierId.GetAttribute("value"), "6");
            var UnitPrice = driver.FindElement(By.XPath("//input[@id='UnitPrice']"));
            Assert.AreEqual(UnitPrice.GetAttribute("value"), "500,0000");
            var QuantityPerUnit = driver.FindElement(By.XPath("//input[@id='QuantityPerUnit']"));
            Assert.AreEqual(QuantityPerUnit.GetAttribute("value"), "15");
            var UnitsInStock = driver.FindElement(By.XPath("//input[@id='UnitsInStock']"));
            Assert.AreEqual(UnitsInStock.GetAttribute("value"), "10");
            var UnitsOnOrder = driver.FindElement(By.XPath("//input[@id='UnitsOnOrder']"));
            Assert.AreEqual(UnitsOnOrder.GetAttribute("value"), "5");
            var ReorderLevel = driver.FindElement(By.XPath("//input[@id='ReorderLevel']"));
            Assert.AreEqual(ReorderLevel.GetAttribute("value"), "1");
            var checkbox = driver.FindElement(By.XPath("//input[@type='checkbox']"));
            Assert.AreEqual(checkbox.GetAttribute("value"), "true");
                             
        }

        [Test]
        public void Logout()
        {
            driver.FindElement(By.XPath("//a[contains(text(),'Logout')]")).Click();
            var logout = driver.FindElement(By.XPath("//h2[contains(.,'Login')]"));
            Assert.AreEqual("Login", logout.Text);
            driver.FindElement(By.XPath("//input[@id='Name']")).SendKeys("user");
            driver.FindElement(By.XPath("//input[@id='Password']")).SendKeys("user");
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();

        }

        [TearDown]
        public void TearDown1()
        {
            driver.FindElement(By.XPath("//a[contains(text(),'Logout')]")).Click();
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
        }

    }
      
}

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Northwind_tests
{
    public class Tests
    {
        private IWebDriver driver;
        private LoginPage loginPage;
        private HomePage homePage;
        private AllproductsPage allproductsPage;
        private ProductPage productPage;
        private LogoutPage logoutPage;
        private string baseUrl;
        private const string login = "user";
        private const string password = "user";
        private const string name = "English tea";
        private const string category = "Beverages";
        private const string category1 = "1";
        private const string supplier = "Mayumi's";
        private const string supplier1 = "6";
        private const string price = "500";
        private const string price1 = "500,0000";
        private const string quantity = "15";
        private const string instock = "10";
        private const string onorder = "5";
        private const string reorder = "1";
        private const string HeaderAllproducts = "All Products";
        private const string HeaderHomePage = "Home page";
        private const string HeaderLogin = "Login";
        private const string SelectItem = "English tea";

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            baseUrl = "http://localhost:5000";
            driver.Navigate().GoToUrl(baseUrl);
            driver.Manage().Window.Maximize();
                        
        }

        [SetUp]
        public void Authorization()
        {
            loginPage = new LoginPage(driver);
            loginPage.AuthorizationPage(login,password);
                         
        }

        [Test]
        public void Login()
        {
            homePage = new HomePage(driver);
            Assert.AreEqual(HeaderHomePage, homePage.GetHomepageheader());
        }

        [Test]
        public void AddVerifyDeleteItem()
        {
            homePage = new HomePage(driver);
            homePage.Allproducts();
            allproductsPage = new AllproductsPage(driver);
            allproductsPage.ProductEditingPage();
            productPage = new ProductPage(driver);
            productPage.AddingProduct(name, category, supplier, price, quantity, instock, onorder, reorder);
            Assert.AreEqual(HeaderAllproducts, allproductsPage.GetAllproductsheader());

            allproductsPage.ViewingItem();
            Assert.AreEqual(name, productPage.ProductName());
            Assert.AreEqual(category1, productPage.CategoryId());
            Assert.AreEqual(supplier1, productPage.SupplierId());
            Assert.AreEqual(price1, productPage.UnitPrice());
            Assert.AreEqual(quantity, productPage.QuantityPerUnit());
            Assert.AreEqual(instock, productPage.UnitsInStock());
            Assert.AreEqual(onorder, productPage.UnitsOnOrder());
            Assert.AreEqual(reorder, productPage.ReorderLevel());
            productPage.Allproducts();

            allproductsPage.DeletingItem(SelectItem);
            
        }

        [Test]
        public void ItemNotPresent()
        {
            homePage = new HomePage(driver);
            homePage.Allproducts();
            allproductsPage = new AllproductsPage(driver);
            Assert.IsFalse(allproductsPage.CheckItemNotPresent());

        }

        [Test]
        public void Logout()
        {
            homePage = new HomePage(driver);
            logoutPage = homePage.Logout();
            Assert.AreEqual(HeaderLogin, logoutPage.GetLoginheader());
            loginPage.AuthorizationPage(login, password);

        }

        [TearDown]
        public void TearDown1()
        {
            homePage = new HomePage(driver);
            logoutPage = homePage.Logout();

        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
        }

    }

}

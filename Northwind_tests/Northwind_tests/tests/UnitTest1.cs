using Northwind_tests.business_object;
using Northwind_tests.service.ui;
using Northwind_tests.tests;
using NUnit.Framework;

namespace Northwind_tests
{
    public class Tests : BaseTest
    {
        private LoginPage loginPage;
        private HomePage homePage;
        private AllproductsPage allproductsPage;
        private ProductPage productPage;
        private LogoutPage logoutPage;              
        private ItemAdd item = new ItemAdd("English tea", "Beverages", "Mayumi's", "500", "15", "10", "5", "1");
        private ItemVerify checkitem = new ItemVerify("English tea", "1", "6", "500,0000", "15", "10", "5", "1");
        private LoginPassword login = new LoginPassword("user", "user");
        private Headers header = new Headers("All Products", "Home page", "Login");

        [SetUp]
        public void Authorization()
        {
            loginPage = new LoginPage(driver);
            loginPage.AuthorizationPage(login.selectLogin, login.selectPassword);

        }

        [Test]
        public void Login()
        {
            homePage = new HomePage(driver);
            Assert.AreEqual(header.HomePage, homePage.GetHomepageheader());
        }

        [Test]
        public void AddVerifyDeleteItem()
        {
            allproductsPage = ItemService.OpenAllProducts(driver);
            allproductsPage.ProductEditingPage();
            productPage = new ProductPage(driver);
            productPage.AddingProduct(item.selectName, item.selectCategory, item.selectSupplier, item.selectPrice, item.selectQuantity, item.selectInstock, item.selectOnorder, item.selectReorder);
            Assert.AreEqual(header.Allproducts, allproductsPage.GetAllproductsheader());

            allproductsPage.ViewingItem();
            Assert.AreEqual(checkitem.selectName, productPage.ProductName());
            Assert.AreEqual(checkitem.selectCategory, productPage.CategoryId());
            Assert.AreEqual(checkitem.selectSupplier, productPage.SupplierId());
            Assert.AreEqual(checkitem.selectPrice, productPage.UnitPrice());
            Assert.AreEqual(checkitem.selectQuantity, productPage.QuantityPerUnit());
            Assert.AreEqual(checkitem.selectInstock, productPage.UnitsInStock());
            Assert.AreEqual(checkitem.selectOnorder, productPage.UnitsOnOrder());
            Assert.AreEqual(checkitem.selectReorder, productPage.ReorderLevel());
            productPage.Allproducts();

            allproductsPage.DeletingItem(item.selectName);

        }

        [Test]
        public void ItemNotPresent()
        {
            allproductsPage = ItemService.OpenAllProducts(driver);
            Assert.IsFalse(allproductsPage.CheckItemNotPresent());

        }

        [Test]
        public void Logout()
        {
            logoutPage = LogoutService.Logout(driver);
            Assert.AreEqual(header.Login, logoutPage.GetLoginheader());
            loginPage.AuthorizationPage(login.selectLogin, login.selectPassword);

        }

        [TearDown]
        public void TearDown1()
        {
            logoutPage = LogoutService.Logout(driver);
        }

    }

}

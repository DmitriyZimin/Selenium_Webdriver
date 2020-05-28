using Northwind_tests.business_object;
using Northwind_tests.service.ui;
using Northwind_tests.tests;
using NUnit.Framework;

namespace Northwind_tests
{
    public class Tests : BaseTest
    {
        //private HomePage homePage;
        //private AllproductsPage allproductsPage;
        //private ProductPage productPage;
        //private LogoutPage logoutPage;              
        //private ItemAdd item = new ItemAdd("English tea", "Beverages", "Mayumi's", "500", "15", "10", "5", "1");
        //private ItemVerify checkitem = new ItemVerify("English tea", "1", "6", "500,0000", "15", "10", "5", "1");
        //private LoginPassword user = new LoginPassword("user", "user");
        //private Headers header = new Headers("All Products", "Home page", "Login");

        //[SetUp]
        //public void Authorization()
        //{
        //    homePage = LoginService.Login(user, driver);
        //}

        //[Test]
        //public void Login()
        //{
        //    Assert.AreEqual(header.HomePage, homePage.GetHomepageheader());
        //}

        //[Test]
        //public void AddVerifyDeleteItem()
        //{
        //    allproductsPage = NewItemService.Add(item, driver);
        //    Assert.AreEqual(header.Allproducts, allproductsPage.GetAllproductsheader());

        //    productPage = ItemViewingService.ViewItem(item.selectName, driver);
        //    Assert.AreEqual(checkitem.selectName, productPage.ProductName());
        //    Assert.AreEqual(checkitem.selectCategory, productPage.CategoryId());
        //    Assert.AreEqual(checkitem.selectSupplier, productPage.SupplierId());
        //    Assert.AreEqual(checkitem.selectPrice, productPage.UnitPrice());
        //    Assert.AreEqual(checkitem.selectQuantity, productPage.QuantityPerUnit());
        //    Assert.AreEqual(checkitem.selectInstock, productPage.UnitsInStock());
        //    Assert.AreEqual(checkitem.selectOnorder, productPage.UnitsOnOrder());
        //    Assert.AreEqual(checkitem.selectReorder, productPage.ReorderLevel());
        //    allproductsPage = OpenAllProductsService.Open(driver);

        //    allproductsPage = DeleteItemService.DeleteItem(item.selectName, driver);

        //}

        //[Test]
        //public void ItemNotPresent()
        //{
        //    allproductsPage = OpenAllProductsService.Open(driver);
        //    Assert.IsFalse(allproductsPage.CheckItemNotPresent(item.selectName));

        //}

        //[Test]
        //public void Logout()
        //{
        //    logoutPage = LogoutService.Logout(driver);
        //    Assert.AreEqual(header.Login, logoutPage.GetLoginheader());
        //    homePage = LoginService.Login(user, driver);

        //}

        //[TearDown]
        //public void TearDown1()
        //{
        //    logoutPage = LogoutService.Logout(driver);
        //}

    }

}

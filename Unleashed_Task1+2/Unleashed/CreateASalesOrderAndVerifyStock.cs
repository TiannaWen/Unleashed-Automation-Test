using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Unleashed
{
    [Binding]
    public class CreateASalesOrderAndVerifyStock
    {
        [Given(@"I have created a new customer")]
        public void GivenIHaveCreatedANewCustomer()
        {
            DriverCmn.driver = new ChromeDriver();
            DriverCmn.driver.Navigate().GoToUrl("https://go.unleashedsoftware.com/v2");
            DriverCmn.driver.Manage().Window.Maximize();

            string eml = "qa+applicant@unleashedsoftware.com";
            string pwd = "P@ssw0rd12345";

            Login LoginObj = new Login();
            LoginObj.LoginPg(eml, pwd);

            AddCustomer ACObj1 = new AddCustomer();
            ACObj1.NvgAddCustomer();

            string ccode = "TIANNA10";
            string cname = "Tianna";

            AddCustomer ACObj2 = new AddCustomer();
            ACObj2.AddNewCustomer(ccode, cname);
        }
        
        [Given(@"I have verified the available stock of the product")]
        public void GivenIHaveVerifiedTheAvailableStockOfTheProduct()
        {
            ViewProducts VPObj1 = new ViewProducts();
            VPObj1.NvgViewProducts();

            string pname = "Wooden Bookshelf";
            
            ViewProducts VPObj2 = new ViewProducts();
            VPObj2.QuantityCheck(pname);
            
        }
        
        [Then(@"I create a sales order")]
        public void ThenICreateASalesOrder()
        {
            AddSalesOrder AOObj1 = new AddSalesOrder();
            AOObj1.NvgAddOrder();

            string ccode = "TIANNA";
            string cname = "Tianna Wen";
            string pname = "Wooden Bookshelf";
            string qty = "1";

            AddSalesOrder AOObj2 = new AddSalesOrder();
            AOObj2.AddOrder(ccode, cname, pname, qty);
        }
    }
}
